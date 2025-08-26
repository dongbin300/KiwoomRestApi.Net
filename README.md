# 🚀 KiwoomRestApi.Net

[![NuGet Version](https://img.shields.io/nuget/v/KiwoomRestApi.Net.svg)](https://www.nuget.org/packages/KiwoomRestApi.Net)
[![NuGet Downloads](https://img.shields.io/nuget/dt/KiwoomRestApi.Net.svg)](https://www.nuget.org/packages/KiwoomRestApi.Net)
[![Build Status](https://img.shields.io/github/actions/workflow/status/dongbin300/KiwoomRestApi.Net/ci.yml?branch=main)](https://github.com/dongbin300/KiwoomRestApi.Net/actions)
[![License](https://img.shields.io/github/license/dongbin300/KiwoomRestApi.Net.svg)](https://github.com/dongbin300/KiwoomRestApi.Net/blob/main/LICENSE)

**키움증권 OpenAPI REST API를 위한 현대적이고 직관적인 .NET Wrapper 라이브러리**

주식 거래, 계좌 조회, 실시간 데이터, 차트 분석 등 키움증권의 모든 REST API 기능을 간편하게 사용할 수 있습니다.

## ⚡ 30초 만에 시작하기

```bash
# NuGet 패키지 설치
dotnet add package KiwoomRestApi.Net
```

```csharp
using KiwoomRestApi.Net.Clients;

// 1. 클라이언트 생성 및 초기화
var client = await KiwoomRestApiClient.CreateAsync("YOUR_APP_KEY", "YOUR_SECRET_KEY", isMock: true);

// 2. 삼성전자 주식 정보 조회
var stockInfo = await client.StockInfo.GetPriceAsync("005930");
Console.WriteLine($"삼성전자 현재가: {stockInfo.CurrentPrice:N0}원");

// 3. 계좌 잔고 조회  
var balance = await client.Account.GetBalanceAsync("계좌번호");
Console.WriteLine($"평가금액: {balance.TotalEvaluationAmount:N0}원");
```

## ✨ 주요 특징

### 🎯 **직관적인 API 설계**
```csharp
// 메서드 체이닝 지원
var client = new KiwoomRestApiClient(config)
    .WithToken("bearer-token")
    .WithTimeout(TimeSpan.FromSeconds(60));

// 강타입 지원
await client.GetAsync<StockInfo>(ApiEndpoint.DomesticStock.StockInfo, cancellationToken);
```

### ⚡ **완전한 비동기 지원**
```csharp
// CancellationToken 지원
using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));
var result = await client.StockInfo.GetPriceAsync("005930", cts.Token);
```

### 🔧 **의존성 주입 (DI) 지원**
```csharp
// Startup.cs 또는 Program.cs
services.AddKiwoomRestApi(config => {
    config.AppKey = "your-app-key";
    config.SecretKey = "your-secret-key"; 
    config.IsMock = true;
    config.RequestTimeout = TimeSpan.FromSeconds(30);
});

// 컨트롤러에서 사용
public class TradingController : ControllerBase
{
    private readonly KiwoomRestApiClient _client;
    
    public TradingController(KiwoomRestApiClient client)
    {
        _client = client;
    }
}
```

### 🛡️ **안전하고 견고한 설계**
```csharp
// Result<T> 패턴으로 안전한 에러 핸들링
var result = await client.TryGetStockInfoAsync("005930");
if (result.IsSuccess)
{
    Console.WriteLine($"주가: {result.Value.CurrentPrice}");
}
else
{
    Console.WriteLine($"오류: {result.Error.Message}");
}
```

## 📋 지원 기능

| 기능 | 설명 | 상태 |
|------|------|------|
| 🔐 **OAuth 인증** | 토큰 발급/갱신 | ✅ |
| 💰 **계좌 관리** | 잔고조회, 주문내역 | ✅ |
| 📈 **주식 정보** | 현재가, 호가, 체결 | ✅ |
| 📊 **차트 데이터** | 일/분봉 데이터 | ✅ |
| 🛒 **주문 관리** | 매수/매도 주문 | ✅ |
| 📊 **시장 정보** | 업종, 테마, 순위 | ✅ |
| 📡 **실시간 데이터** | WebSocket 연결 | ✅ |
| 🌍 **해외주식** | 미국주식 거래 | 🔄 개발중 |

## 🚀 사용 예제

### 기본 사용법

```csharp
using KiwoomRestApi.Net.Clients;
using KiwoomRestApi.Net.Configuration;

// 설정 기반 초기화
var config = new KiwoomConfiguration
{
    AppKey = "your-app-key",
    SecretKey = "your-secret-key", 
    IsMock = true,
    RequestTimeout = TimeSpan.FromSeconds(30)
};

var client = new KiwoomRestApiClient(config);
await client.InitializeAsync();
```

### 주식 정보 조회

```csharp
// 현재가 조회
var price = await client.StockInfo.GetPriceAsync("005930");
Console.WriteLine($"삼성전자: {price.CurrentPrice:N0}원 ({price.ChangeRate:+0.00;-0.00}%)");

// 호가 조회  
var orderBook = await client.MarketCondition.GetOrderBookAsync("005930");
Console.WriteLine($"매수1호가: {orderBook.BuyPrice1:N0}원");

// 차트 데이터 조회
var chartData = await client.Chart.GetDailyPriceAsync("005930", 
    startDate: DateTime.Today.AddDays(-30),
    endDate: DateTime.Today);
```

### 계좌 및 주문 관리

```csharp
// 계좌 잔고 조회
var accounts = await client.Account.GetAccountsAsync();
var balance = await client.Account.GetBalanceAsync(accounts.First().AccountNumber);

// 매수 주문
var buyOrder = new OrderRequest
{
    AccountNumber = "계좌번호",
    StockCode = "005930", 
    OrderType = OrderType.Limit,
    Side = OrderSide.Buy,
    Quantity = 10,
    Price = 80000
};
var orderResult = await client.Order.PlaceOrderAsync(buyOrder);

// 주문 내역 조회
var orders = await client.Order.GetOrdersAsync("계좌번호");
```

### 실시간 데이터 구독

```csharp
using KiwoomRestApi.Net.Clients;

var socketClient = await KiwoomSocketClient.CreateAsync(client.Token, isMock: true);

// 실시간 호가 구독
socketClient.OnOrderBookReceived += (stockCode, orderBook) => 
{
    Console.WriteLine($"{stockCode}: {orderBook.BuyPrice1:N0}원");
};

await socketClient.SubscribeOrderBookAsync("005930");
```

## ⚙️ 고급 설정

### 재시도 정책

```csharp
var config = new KiwoomConfiguration
{
    AppKey = "your-app-key",
    SecretKey = "your-secret-key",
    RetryOptions = new RetryOptions
    {
        MaxRetries = 3,
        DelayBetweenRetries = TimeSpan.FromSeconds(1),
        ExponentialBackoff = true
    }
};
```

### 커스텀 HttpClient

```csharp
var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Add("User-Agent", "MyApp/1.0");

var config = new KiwoomConfiguration
{
    AppKey = "your-app-key", 
    SecretKey = "your-secret-key",
    HttpClient = httpClient,
    DisposeHttpClient = false // HttpClient를 직접 관리
};
```

## 📊 성능 및 제한사항

| 구분 | 제한사항 |
|------|----------|
| **API 호출** | 초당 20회 |
| **실시간 구독** | 동시 40종목 |
| **WebSocket** | 연결당 1개 |
| **토큰 유효기간** | 24시간 |

## 🏗️ 지원 플랫폼

- **.NET Standard 2.0** (Unity, Xamarin 호환)
- **.NET Standard 2.1**  
- **.NET 6.0**
- **.NET 8.0**
- **.NET 9.0**

## 🤝 기여하기

1. Fork 후 브랜치 생성: `git checkout -b feature/amazing-feature`
2. 변경사항 커밋: `git commit -m 'Add amazing feature'`
3. 브랜치에 Push: `git push origin feature/amazing-feature`
4. Pull Request 생성

## 📝 라이선스

이 프로젝트는 [MIT 라이선스](LICENSE) 하에 배포됩니다.

## ⚠️ 면책 조항

이 라이브러리는 키움증권과 공식적인 관계가 없는 개인 프로젝트입니다.  
실제 거래 시에는 충분한 테스트를 거쳐 사용하시기 바랍니다.

## 🔗 관련 링크

- [키움증권 공식 API 문서](https://openapi.kiwoom.com/guide/apiguide)
- [API 문서](https://dongbin300.github.io/KiwoomRestApi.Net/)
- [GitHub 리포지토리](https://github.com/dongbin300/KiwoomRestApi.Net)
- [버그 리포트](https://github.com/dongbin300/KiwoomRestApi.Net/issues)

---

⭐ 이 프로젝트가 도움이 되었다면 스타를 눌러주세요!