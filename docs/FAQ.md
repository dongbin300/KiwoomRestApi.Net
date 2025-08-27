# ❓ 자주 묻는 질문 (FAQ)

## 🔧 설치 및 설정

### Q: NuGet 패키지가 설치되지 않습니다.
**A:** 다음 사항들을 확인해주세요:
- .NET 6.0 이상 또는 .NET Standard 2.0 이상을 지원하는 프로젝트인지 확인
- 프로젝트 파일의 `<TargetFramework>` 설정 확인
- NuGet 소스가 올바르게 구성되어 있는지 확인

### Q: "App Key"와 "Secret Key"는 어디서 받나요?
**A:** 키움증권 홈페이지에서 OpenAPI를 신청한 후 발급받을 수 있습니다:
1. 키움증권 홈페이지 → 고객센터 → OpenAPI
2. 신청서 작성 및 제출
3. 승인 후 App Key, Secret Key 발급

### Q: 모의투자용과 실거래용 키가 다른가요?
**A:** 네, 모의투자용과 실거래용 키가 별도로 발급됩니다. 개발 시에는 반드시 모의투자용 키를 사용하세요.

## 🔐 인증 관련

### Q: "Token is null" 오류가 발생합니다.
**A:** 다음을 확인해주세요:
- App Key와 Secret Key가 정확한지 확인
- 키움증권 OpenAPI 서비스가 정상 운영 중인지 확인
- 네트워크 연결 상태 확인
- 모의투자/실거래 설정이 키와 일치하는지 확인

```csharp
// 올바른 초기화 방법
var client = await KiwoomRestApiClient.CreateAsync("your-app-key", "your-secret-key", isMock: true);
```

### Q: 토큰 유효기간이 얼마나 되나요?
**A:** 액세스 토큰의 유효기간은 24시간입니다. 자동으로 갱신되지 않으므로 필요시 재발급받아야 합니다.

## 📈 데이터 조회

### Q: 종목코드는 어떻게 찾나요?
**A:** 한국거래소나 키움증권 사이트에서 확인할 수 있습니다:
- 삼성전자: 005930
- SK하이닉스: 000660  
- NAVER: 035420
- 카카오: 035720

### Q: 조회할 수 있는 데이터 종류는?
**A:** 다음과 같은 데이터를 조회할 수 있습니다:
- 현재가, 호가, 체결가
- 차트 데이터 (일봉, 분봉)
- 계좌 잔고 및 보유종목
- 주문 내역
- 업종 정보, 테마 정보
- 외국인/기관 매매 동향

### Q: 실시간 데이터도 지원하나요?
**A:** 네, WebSocket을 통한 실시간 데이터를 지원합니다:

```csharp
using KiwoomRestApi.Net.Clients;

var socketClient = await KiwoomSocketClient.CreateAsync(client.Token, isMock: true);

// 실시간 주식체결 수신
socketClient.OnRealtimeStockExecutionReceived += (message) => 
{
    Console.WriteLine($"체결가: {message.ElementAt(0).Values.CurrentPrice}원");
};

// 실시간 주식체결 구독
await socketClient.WebSocket.SubscribeAsync([KiwoomWebSocketServiceName.StockExecution], ["005930", "000660"]);
```

## 💰 계좌 및 주문

### Q: 모의계좌도 조회되나요?
**A:** 네, 모의투자 모드에서는 모의계좌 정보를 조회할 수 있습니다.

### Q: 실제 주문도 가능한가요?
**A:** 네, 실거래 모드에서는 실제 주문이 가능합니다. 단, 충분한 테스트 후 사용하시기 바랍니다.

```csharp
// 매수 주문
var buyOrderResult = await client.Order.PlaceOrderAsync(
	KiwoomOrderType.Buy,                                    // 매수
	KiwoomOrderDomesticStockExchangeType.KRX,               // 거래소
	"005930",                                               // 삼성전자
	10,                                                     // 주문수량
	KiwoomOrderTradeType.Normal,                            // 지정가
	80000);                                                 // 주문가격

// 매도 주문
var sellOrderResult = await client.Order.PlaceOrderAsync(
	KiwoomOrderType.Sell,                                   // 매도
	KiwoomOrderDomesticStockExchangeType.KRX,               // 거래소
	"005930",                                               // 삼성전자
	5,                                                      // 주문수량
	KiwoomOrderTradeType.Market);                          // 시장가

// 미체결 주문 조회
var outstandingOrders = await client.Account.GetOutstandingOrdersAsync(
	KiwoomAccountQueryType.All,
	KiwoomAccountTradeType.All,
	KiwoomAccountStockExchangeType.Unified);

// 주문 수정
var modifyResult = await client.Order.ModifyOrderAsync(
	KiwoomOrderDomesticStockExchangeType.KRX,               // 거래소
	"원주문번호",                                            // 원주문번호
	"005930",                                               // 종목코드
	8,                                                      // 수정수량
	82000);                                                 // 수정가격

// 주문 취소
var cancelResult = await client.Order.CancelOrderAsync(
	KiwoomOrderDomesticStockExchangeType.KRX,               // 거래소
	"원주문번호",                                            // 원주문번호
	"005930");                                              // 종목코드
```

## 🚫 제한사항 및 오류

### Q: API 호출 제한이 있나요?
**A:** 네, 키움증권 API에는 다음과 같은 제한이 있습니다:
- 초당 호출 제한: 약 20회
- 분당 호출 제한: 약 1,000회
- 일일 호출 제한: 약 100,000회

### Q: "Rate limit exceeded" 오류가 발생합니다.
**A:** API 호출 제한을 초과했습니다. 다음 방법으로 해결하세요:
- 호출 간격을 늘리기
- 배치 처리로 한 번에 여러 데이터 조회
- 캐싱을 통해 중복 호출 방지

```csharp
// 호출 간격 조절 예제
await Task.Delay(100); // 100ms 대기
var orderBook = await client.MarketCondition.GetOrderBookAsync("005930");
```

### Q: 특정 시간에만 API가 동작하나요?
**A:** 네, 주식시장 운영시간과 연관이 있습니다:
- 평일 09:00 ~ 15:30: 정상 서비스
- 야간, 주말: 일부 데이터만 제공
- 공휴일: 서비스 중단

## 🔧 기술적 문제

### Q: .NET Framework에서 사용할 수 있나요?
**A:** .NET Standard 2.0을 지원하므로 .NET Framework 4.6.1 이상에서 사용 가능합니다.

### Q: Xamarin이나 Unity에서 사용할 수 있나요?
**A:** 네, .NET Standard 2.0 호환성으로 인해 대부분의 플랫폼에서 사용 가능합니다.

### Q: 비동기 메서드만 있나요?
**A:** 권장사항은 비동기 메서드이지만, 필요시 `.Result`를 사용할 수 있습니다:

```csharp
// 비동기 (권장)
var orderBook = await client.MarketCondition.GetOrderBookAsync("005930");

// 동기 (권장하지 않음)  
var orderBook = client.MarketCondition.GetOrderBookAsync("005930").Result;
```

### Q: 메모리 누수가 발생합니다.
**A:** 반드시 리소스를 정리해주세요:

```csharp
// using 문 사용 (권장)
using var client = await KiwoomRestApiClient.CreateAsync("your-app-key", "your-secret-key");

// 또는 명시적 해제
var client = await KiwoomRestApiClient.CreateAsync("your-app-key", "your-secret-key");
try { /* 작업 */ }
finally { client.Dispose(); }
```

## 🏗️ 개발 관련

### Q: 의존성 주입(DI)을 사용할 수 있나요?
**A:** 네, ASP.NET Core에서 쉽게 사용할 수 있습니다:

```csharp
// Program.cs (DI 등록 방법은 실제 구현에 따라 다를 수 있음)
services.AddSingleton<KiwoomRestApiClient>(provider => 
{
    return KiwoomRestApiClient.CreateAsync("your-app-key", "your-secret-key").GetAwaiter().GetResult();
});
```

### Q: 설정을 외부 파일로 관리할 수 있나요?
**A:** 네, appsettings.json을 활용할 수 있습니다:

```json
{
  "KiwoomApi": {
    "AppKey": "your-app-key",
    "SecretKey": "your-secret-key",
    "IsMock": true
  }
}
```

```csharp
// Microsoft.Extensions.Configuration.Json 패키지 설치 후
services.Configure<KiwoomConfiguration>(configuration.GetSection("KiwoomApi"));
```

### Q: 로깅은 어떻게 설정하나요?
**A:** .NET의 표준 로깅 인터페이스를 지원합니다:

```csharp
services.AddLogging();
services.AddSingleton<KiwoomRestApiClient>(provider => 
{
    return KiwoomRestApiClient.CreateAsync("your-app-key", "your-secret-key").GetAwaiter().GetResult();
});
```

## 🆘 문제 해결

### Q: 여전히 문제가 해결되지 않습니다.
**A:** 다음 순서로 도움을 요청하세요:

1. **GitHub Issues**: [버그 리포트](https://github.com/dongbin300/KiwoomRestApi.Net/issues)
2. **E-MAIL**: dongbin300@gmail.com

### 이슈 보고시 포함할 정보:
- .NET 버전
- KiwoomRestApi.Net 버전
- 오류 메시지 전체
- 재현 가능한 최소 코드
- 운영체제 정보

## 📚 더 많은 정보

- [빠른 시작 가이드](QuickStart.md)
- [키움증권 공식 API 문서](https://openapi.kiwoom.com/guide/apiguide)
- [API 문서](https://dongbin300.github.io/KiwoomRestApi.Net/)
- [GitHub 리포지토리](https://github.com/dongbin300/KiwoomRestApi.Net)