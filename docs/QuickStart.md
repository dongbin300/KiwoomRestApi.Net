# 🚀 빠른 시작 가이드

이 가이드는 KiwoomRestApi.Net을 사용하여 5분 안에 첫 번째 키움증권 API 호출을 수행하는 방법을 설명합니다.

## 📋 사전 준비사항

1. **키움증권 계좌**: 키움증권 계좌가 필요합니다.
2. **OpenAPI 신청**: 키움증권 홈페이지에서 OpenAPI를 신청해야 합니다.
3. **앱 키 발급**: 키움증권에서 App Key와 Secret Key를 발급받아야 합니다.

## 🔧 설치

### Package Manager Console
```
Install-Package KiwoomRestApi.Net
```

### .NET CLI
```bash
dotnet add package KiwoomRestApi.Net
```

### PackageReference
```xml
<PackageReference Include="KiwoomRestApi.Net" Version="1.0.0" />
```

## 🎯 첫 번째 API 호출

### 1단계: 네임스페이스 추가

```csharp
using KiwoomRestApi.Net.Clients;
using KiwoomRestApi.Net.Configuration;
```

### 2단계: 클라이언트 초기화

```csharp
// 방법 1: 간단한 초기화 (권장)
var client = await KiwoomRestApiClient.CreateAsync(
    appKey: "YOUR_APP_KEY",
    secretKey: "YOUR_SECRET_KEY", 
    isMock: true  // 실제 거래시에는 false
);

// 방법 2: 설정 객체 사용
var config = new KiwoomConfiguration
{
    AppKey = "YOUR_APP_KEY",
    SecretKey = "YOUR_SECRET_KEY",
    IsMock = true,
    RequestTimeout = TimeSpan.FromSeconds(30)
};
var client = new KiwoomRestApiClient(config);
await client.InitializeAsync();
```

### 3단계: 주식 정보 조회

```csharp
try 
{
    // 삼성전자(005930) 현재가 조회
    var stockInfo = await client.StockInfo.GetPriceAsync("005930");
    
    Console.WriteLine($"종목명: {stockInfo.StockName}");
    Console.WriteLine($"현재가: {stockInfo.CurrentPrice:N0}원");
    Console.WriteLine($"전일대비: {stockInfo.PreviousDayChange:+#,0;-#,0} ({stockInfo.ChangeRate:+0.00;-0.00}%)");
    
    // 거래량 정보
    Console.WriteLine($"거래량: {stockInfo.TradingVolume:N0}주");
    Console.WriteLine($"거래대금: {stockInfo.TradingValue:N0}원");
}
catch (Exception ex)
{
    Console.WriteLine($"오류 발생: {ex.Message}");
}
finally
{
    // 리소스 정리
    client.Dispose();
}
```

## 🏁 완성된 예제

다음은 완전한 콘솔 애플리케이션 예제입니다:

```csharp
using System;
using System.Threading.Tasks;
using KiwoomRestApi.Net.Clients;

class Program
{
    static async Task Main(string[] args)
    {
        // 키움증권에서 발급받은 키 입력
        const string APP_KEY = "YOUR_APP_KEY";
        const string SECRET_KEY = "YOUR_SECRET_KEY";
        
        KiwoomRestApiClient? client = null;
        
        try
        {
            Console.WriteLine("키움 API 클라이언트 초기화 중...");
            client = await KiwoomRestApiClient.CreateAsync(APP_KEY, SECRET_KEY, isMock: true);
            Console.WriteLine("초기화 완료!");
            
            // 삼성전자 주식 정보 조회
            Console.WriteLine("\n삼성전자 주식 정보 조회 중...");
            var samsung = await client.StockInfo.GetPriceAsync("005930");
            
            Console.WriteLine($"\n📈 {samsung.StockName} (005930)");
            Console.WriteLine($"현재가: {samsung.CurrentPrice:N0}원");
            Console.WriteLine($"전일대비: {samsung.PreviousDayChange:+#,0;-#,0} ({samsung.ChangeRate:+0.00;-0.00}%)");
            Console.WriteLine($"거래량: {samsung.TradingVolume:N0}주");
            
            // SK하이닉스 주식 정보 조회
            Console.WriteLine("\nSK하이닉스 주식 정보 조회 중...");
            var skhynix = await client.StockInfo.GetPriceAsync("000660");
            
            Console.WriteLine($"\n📈 {skhynix.StockName} (000660)");
            Console.WriteLine($"현재가: {skhynix.CurrentPrice:N0}원");
            Console.WriteLine($"전일대비: {skhynix.PreviousDayChange:+#,0;-#,0} ({skhynix.ChangeRate:+0.00;-0.00}%)");
            Console.WriteLine($"거래량: {skhynix.TradingVolume:N0}주");
            
            Console.WriteLine("\n✅ 모든 작업이 완료되었습니다!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ 오류 발생: {ex.Message}");
        }
        finally
        {
            client?.Dispose();
            Console.WriteLine("\n프로그램을 종료하려면 아무 키나 누르세요...");
            Console.ReadKey();
        }
    }
}
```

## ⚠️ 중요 사항

1. **모의투자 사용**: 개발 및 테스트 시에는 반드시 `isMock: true`를 설정하세요.
2. **키 보안**: App Key와 Secret Key는 절대 소스코드에 하드코딩하지 마세요.
3. **에러 처리**: 네트워크 오류나 API 제한 등을 고려하여 적절한 예외 처리를 구현하세요.
4. **리소스 정리**: 사용이 끝난 클라이언트는 반드시 Dispose()를 호출하세요.

## 🆘 도움이 필요한가요?

- [전체 문서](../README.md)
- [키움증권 공식 API 문서](https://openapi.kiwoom.com/guide/apiguide)
- [API 문서](https://dongbin300.github.io/KiwoomRestApi.Net/)
- [GitHub 리포지토리](https://github.com/dongbin300/KiwoomRestApi.Net)
- [버그 리포트](https://github.com/dongbin300/KiwoomRestApi.Net/issues)