# 🚀 KiwoomRestApi.Net

[KiwoomRestApi.Net 문서](https://dongbin300.github.io/KiwoomRestApi.Net/)

[![NuGet Version](https://img.shields.io/nuget/v/KiwoomRestApi.Net.svg)](https://www.nuget.org/packages/KiwoomRestApi.Net)
[![NuGet Downloads](https://img.shields.io/nuget/dt/KiwoomRestApi.Net.svg)](https://www.nuget.org/packages/KiwoomRestApi.Net)
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
var stockInfo = await client.StockInfo.GetStockInfoAsync("005930", DateTime.Today, KiwoomStockInfoMarginLoanType.Loan);
Console.WriteLine($"삼성전자 현재가: {stockInfo.Data.CurrentPrice}원");

// 3. 당일 삼성전자 실현손익 조회  
var todayRealizedProfitLoss = await client.Account.GetTodayRealizedProfitLossAsync("005930");
Console.WriteLine($"평가금액: {todayRealizedProfitLoss.ProfitLossRate}%");
```

## ✨ 주요 특징

### ⚡ **완전한 비동기 지원**
```csharp
// CancellationToken 지원
using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));
var result = await client.Account.GetDailyStatusAsync(cts.Token);
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
[ApiController]
public class TradingController : ControllerBase
{
    private readonly KiwoomRestApiClient _client;
    
    public TradingController(KiwoomRestApiClient client)
    {
        _client = client;
    }
}
```

## 📋 지원 기능

| 기능 | 설명 | 상세 기능 | 상태 |
|------|------|----------|------|
| 🔐 **OAuth 인증** | 토큰 발급/갱신 | 액세스 토큰, 리프레시 토큰 관리 | ✅ |
| 💰 **계좌 관리** | 잔고조회, 주문내역 | 예수금, 평가잔고, 실현손익, 미체결주문 | ✅ |
| 📈 **주식 정보** | 현재가, 호가, 체결 | 주식기본정보, 호가정보, 체결정보 | ✅ |
| 📊 **차트 데이터** | 일/분봉 데이터 | 일봉, 분봉, 기간별 차트 | ✅ |
| 🛒 **주문 관리** | 매수/매도 주문 | 신규주문, 정정주문, 취소주문 | ✅ |
| 📊 **시장 정보** | 업종, 테마, 순위 | 업종지수, 테마정보, 순위정보 | ✅ |
| 📡 **실시간 데이터** | WebSocket 연결 | 실시간 주식체결, 호가, 체결강도 | ✅ |
| 🔍 **종목 검색** | 종목 정보 조회 | ETF, ELW, 외국인/기관 정보 | ✅ |

## 🚀 사용 예제

### 기본 사용법

```csharp
using KiwoomRestApi.Net.Clients;

var client = KiwoomRestApiClient.Create(appKey, secretKey, true);
```

### 주식 정보 조회

```csharp
// 현재가 조회
var stockInfo = await client.StockInfo.GetStockInfoAsync("005930", DateTime.Today, KiwoomStockInfoMarginLoanType.Loan);
Console.WriteLine($"삼성전자 현재가: {stockInfo.Data.CurrentPrice}원");

// 호가 조회  
var orderBook = await client.MarketCondition.GetOrderBookAsync("005930");
Console.WriteLine($"매수1호가: {orderBook.Data.BidLevel1Price}원");

// 차트 데이터 조회
var chartData = await client.Chart.GetDailyChartsAsync("005930", DateTime.Today, KiwoomChartUseOption.Use);
Console.WriteLine($"삼성전자 전일종가: {chartData.Data.Items.ElementAt(1).CurrentPrice}원");
```

### 계좌 및 주문 관리

```csharp
// 💰 예수금 및 자금 관리
var deposits = await client.Account.GetDepositsAsync(KiwoomAccountDepositQueryType.Normal);
Console.WriteLine($"예수금: {deposits.Data.DepositAmount:N0}원");

var dailyEstimatedAssets = await client.Account.GetDailyEstimatedDepositAssetsAsync(
    DateTime.Today.AddDays(-7), DateTime.Today);
Console.WriteLine($"추정예탁자산: {dailyEstimatedAssets.Data.TotalEstimatedDepositAsset:N0}원");

var estimatedAsset = await client.Account.GetEstimatedDepositAssetAsync(isExcludeDelisted: false);
Console.WriteLine($"평가자산 총액: {estimatedAsset.Data.TotalAssetAmount:N0}원");

// 📊 잔고 및 평가
var evaluations = await client.Account.GetEvaluationsAsync(
    isExcludeDelisted: false, KiwoomAccountStockExchangeType.KRX);
Console.WriteLine($"총평가금액: {evaluations.Data.TotalAssetAmount:N0}원");

var tradeBalances = await client.Account.GetTradeBalancesAsync(KiwoomAccountStockExchangeType.KRX);
Console.WriteLine($"매입금액: {tradeBalances.Data.TotalBuyAmount:N0}원");

var evaluationBalances = await client.Account.GetEvaluationBalancesAsync(
    KiwoomAccountEvaluationBalanceQueryType.TotalProfitLoss,
    KiwoomAccountDomesticStockExchangeType.All);
Console.WriteLine($"총평가손익: {evaluationBalances.Data.TotalProfitLossAmount:N0}원");

// 📈 수익률 및 손익 분석
var dailyBalanceProfitRates = await client.Account.GetDailyBalanceProfitRatesAsync(DateTime.Today);
Console.WriteLine($"일별잔고수익률: {dailyBalanceProfitRates.Data.TotalProfitLossRate:F2}%");

var todayRealizedProfitLoss = await client.Account.GetTodayRealizedProfitLossAsync("005930");
Console.WriteLine($"금일 실현손익률: {todayRealizedProfitLoss.ProfitLossRate:F2}%");

var dailyRealizedProfitLosses = await client.Account.GetDailyRealizedProfitLossesAsync(
    DateTime.Today.AddDays(-30), DateTime.Today);
Console.WriteLine($"30일간 실현손익: {dailyRealizedProfitLosses.Data.TotalProfitLossAmount:N0}원");

var profitRates = await client.Account.GetProfitRatesAsync(KiwoomAccountStockExchangeType.KRX);
Console.WriteLine($"계좌 수익률: {profitRates.Data.TotalProfitLossRate:F2}%");

// 🔄 주문 관리
var unfilledOrders = await client.Account.GetUnfilledOrdersAsync(
    KiwoomAccountQueryType.All,
    KiwoomAccountTransactionType.All,
    KiwoomAccountStockExchangeType.Unified);
Console.WriteLine($"미체결 주문 수: {unfilledOrders.Data.Count}");

var filledOrders = await client.Account.GetFilledOrdersAsync(
    KiwoomAccountQueryType.Today,
    KiwoomAccountTransactionType.All,
    KiwoomAccountStockExchangeType.Unified);
Console.WriteLine($"체결 주문 수: {filledOrders.Data.Count}");

// 📋 거래 내역 조회
var todayTransactionJournals = await client.Account.GetTodayTransactionJournalsAsync(
    KiwoomAccountOddLotType.IncludeOddLot,
    KiwoomAccountCashCreditType.All);
Console.WriteLine($"금일 거래 내역 수: {todayTransactionJournals.Data.Count}");

var orderTradeDetails = await client.Account.GetOrderTradeDetailsAsync(
    KiwoomAccountOrderQueryType.Today,
    KiwoomAccountStockBondType.Stock,
    KiwoomAccountTransactionType.All,
    KiwoomAccountDomesticStockExchangeType.KRX);
Console.WriteLine($"주문 거래 상세 수: {orderTradeDetails.Data.Count}");

// 💳 신용 거래
var marginOrders = await client.Account.GetMarginOrdersAsync("005930");
Console.WriteLine($"융자 주문 가능 수량: {marginOrders.Data.MarginBuyableQuantity:N0}주");

var creditDepositOrders = await client.Account.GetCreditDepositOrdersAsync("005930");
Console.WriteLine($"신용보증금율: {creditDepositOrders.Data.StockDepositRate:F2}%");

var marginDetails = await client.Account.GetMarginDetailsAsync();
Console.WriteLine($"융자비율: {marginDetails.Data.MarginRate:F2}%");

// 🎯 주문 가능량 조회
var availableWithdrawalAmounts = await client.Account.GetAvailableWithdrawalAmountsAsync(
    "005930", KiwoomAccountTransactionType.Buy, 85000);
Console.WriteLine($"출금가능금액: {availableWithdrawalAmounts.Data.AvailableWithdrawalAmount:N0}원");

// 📅 정산 및 상태
var nextDaySettlements = await client.Account.GetNextDaySettlementsAsync();
Console.WriteLine($"D+1 정산 금액: {nextDaySettlements.Data.TotalBuyAmount:N0}원");

var dailyStatus = await client.Account.GetDailyStatusAsync();
Console.WriteLine($"계좌 상태: {dailyStatus.Data.AccountStatus}");

// 📊 종목별 실현손익
var dailyStockRealizedProfitLosses = await client.Account.GetDailyStockRealizedProfitLossesAsync(
    "005930", DateTime.Today.AddDays(-30));
Console.WriteLine($"종목별 실현손익: {dailyStockRealizedProfitLosses.Data.TotalProfitLossAmount:N0}원");

var dailyStockRealizedProfitLossPeriods = await client.Account.GetDailyStockRealizedProfitLossPeriodsAsync(
    "005930", DateTime.Today.AddDays(-30), DateTime.Today);
Console.WriteLine($"기간별 실현손익: {dailyStockRealizedProfitLossPeriods.Data.TotalProfitLossAmount:N0}원");

// 🏦 위탁 및 예수
var consignedTransactions = await client.Account.GetConsignedTransactionsAsync(
    KiwoomAccountTransactionType2.All,
    KiwoomAccountGoodsType.Stock,
    KiwoomAccountDomesticStockExchangeType.KRX,
    DateTime.Today.AddDays(-7), DateTime.Today);
Console.WriteLine($"위탁 매매 수량: {consignedTransactions.Data.TotalOrderQuantity:N0}주");

// 📈 주문 분할 정보
var unfilledSplitOrders = await client.Account.GetUnfilledSplitOrdersAsync("주문번호");
Console.WriteLine($"분할 미체결 수량: {unfilledSplitOrders.Data.RemainQuantity:N0}주");

// 📊 일별 수익률 상세
var dailyProfitRateDetails = await client.Account.GetDailyProfitRateDetailsAsync(
    DateTime.Today.AddDays(-30), DateTime.Today);
Console.WriteLine($"일별 수익률 상세: {dailyProfitRateDetails.Data.Count}일 데이터");

// 🛒 주문 실행 (신용 거래 포함)
var buyOrderResult = await client.Order.PlaceOrderAsync(
    KiwoomOrderType.Buy,                                    // 매수
    KiwoomOrderDomesticStockExchangeType.KRX,               // 거래소
    "005930",                                               // 삼성전자
    10,                                                     // 주문수량
    KiwoomOrderTradeType.Normal,                            // 지정가
    80000);                                                 // 주문가격

var sellOrderResult = await client.Order.PlaceOrderAsync(
    KiwoomOrderType.Sell,                                   // 매도
    KiwoomOrderDomesticStockExchangeType.KRX,               // 거래소
    "005930",                                               // 삼성전자
    5,                                                      // 주문수량
    KiwoomOrderTradeType.Market);                          // 시장가

// 🔧 주문 수정 및 취소
var modifyResult = await client.Order.ModifyOrderAsync(
    KiwoomOrderDomesticStockExchangeType.KRX,               // 거래소
    "원주문번호",                                            // 원주문번호
    "005930",                                               // 종목코드
    8,                                                      // 수정수량
    82000);                                                 // 수정가격

var cancelResult = await client.Order.CancelOrderAsync(
    KiwoomOrderDomesticStockExchangeType.KRX,               // 거래소
    "원주문번호",                                            // 원주문번호
    "005930",                                               // 종목코드
    cancelQuantity: 3);                                     // 취소수량

// 🥇 금현물 거래
var goldBuyOrderResult = await client.Order.GoldSpotPlaceOrderAsync(
    KiwoomOrderType.Buy,                                    // 매수
    KiwoomGoldSpotStockCode.Gold_1kg,                       // 금 1kg
    1,                                                      // 주문수량
    KiwoomOrderGoldSpotTransactionType.Normal,              // 보통
    8500000);                                               // 주문가격
```

### 실시간 데이터 구독

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

## ⚡ 성능 최적화 팁

### 📊 API 제한사항

| 구분 | 제한사항 | 권장사항 |
|------|----------|----------|
| **API 호출** | 초당 20회 | Rate limiting 구현 권장 |
| **실시간 구독** | 동시 40종목 | 필요한 종목만 구독 |
| **WebSocket** | 연결당 1개 | 연결 상태 모니터링 필요 |
| **토큰 유효기간** | 24시간 | 자동 갱신 로직 구현 |

### 🚀 최적화 가이드

```csharp
// ✅ 좋은 예: CancellationToken 사용
using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(10));
var result = await client.StockInfo.GetStockInfoAsync("005930", DateTime.Today,
    KiwoomStockInfoMarginLoanType.Loan, cts.Token);

// ✅ 좋은 예: 배치 처리
var stockCodes = new[] { "005930", "000660", "035420" };
var tasks = stockCodes.Select(code =>
    client.StockInfo.GetStockInfoAsync(code, DateTime.Today, KiwoomStockInfoMarginLoanType.Loan));
var results = await Task.WhenAll(tasks);

// ❌ 나쁜 예: 동기 블로킹 호출
// var result = client.StockInfo.GetStockInfoAsync("005930", DateTime.Today, KiwoomStockInfoMarginLoanType.Loan).Result;
```

## 🏗️ 지원 플랫폼

- **.NET Standard 2.0** (Unity, Xamarin 호환)
- **.NET Standard 2.1**
- **.NET 6.0**
- **.NET 8.0**
- **.NET 9.0**
- **.NET 10.0**

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

## 📋 릴리즈 노트

### v0.6.1 (2026-02-05)
- `KiwoomWebSocketRealtimeBalance`.`StockCode`를 `decimal?`에서 `string?`으로 수정 (#2)
- `KiwoomWebSocketRealtimeOrderTrade`.`StockCode`를 `decimal?`에서 `string?`으로 수정 (#2)

---

### v0.6.0 (2026-01-02)
- 대용량 메시지 수신 시 JSON 파싱 에러 해결 (#1)
- Microsoft.Extensions, System.Text.Json 최신 버전으로 업데이트 (10.0.1)
- | kt00005 | 체결잔고요청 `KiwoomAccountStockExchangeType`을 `KiwoomAccountStockExchangeType2`로 수정
- | ka10073 | 일자별종목별실현손익요청_기간 `TodayHtsSellFee` `string`로 수정
- | ka30002 | 거래원별ELW순매매상위요청 `issuerCompanyCode` 파라미터를 `string`로 수정
- | ka10005 | 주식일주월시분요청 `KiwoomMarketConditionGetDailyWeeklyMonthly` 멤버 수정
- | ka10101 | 업종코드 리스트 `marketCode`를 `list`로 수정
- KiwoomWebSocketRealtime 멤버변수 일부 `string`을 `KiwoomString`으로 수정

---

### v0.5.1 (2025-11-05)
- | ka10079 | 주식틱차트조회요청 체결일 삭제
- | ka20004 | 업종틱차트조회요청 체결일 삭제

---

### v0.5.0 (2025-10-16)
- | ka50010 | 금현물체결추이 API 추가 (`GetGoldTradeTrendsAsync`)
- | ka50012 | 금현물일별추이 API 추가 (`GetGoldDailyTrendsAsync`)
- | ka50087 | 금현물예상체결 API 추가 (`GetGoldExpectedTradesAsync`)
- | ka50100 | 금현물시세정보 API 추가 (`GetGoldInfoAsync`)
- | ka50101 | 금현물 호가 API 추가 (`GetGoldQuotesAsync`)
- | kt50000 | 금현물 매수주문 API 추가 (`GoldSpotPlaceOrderAsync`)
- | kt50001 | 금현물 매도주문 API 추가 (`GoldSpotPlaceOrderAsync`)
- | kt50002 | 금현물 정정주문 API 추가 (`GoldSpotModifyOrderAsync`)
- | kt50003 | 금현물 취소주문 API 추가 (`GoldSpotCancelOrderAsync`)
- | ka50079 | 금현물틱차트조회요청 API 추가 (`GetGoldSpotTickChartsAsync`)
- | ka50080 | 금현물분봉차트조회요청 API 추가 (`GetGoldSpotMinuteChartsAsync`)
- | ka50081 | 금현물일봉차트조회요청 API 추가 (`GetGoldSpotDailyChartsAsync`)
- | ka50082 | 금현물주봉차트조회요청 API 추가 (`GetGoldSpotWeeklyChartsAsync`)
- | ka50083 | 금현물월봉차트조회요청 API 추가 (`GetGoldSpotMonthlyChartsAsync`)
- | ka50091 | 금현물당일틱차트조회요청 API 추가 (`GetGoldSpotTodayTickChartsAsync`)
- | ka50092 | 금현물당일분봉차트조회요청 API 추가 (`GetGoldSpotTodayMinuteChartsAsync`)
- | ka52301 | 금현물투자자현황 API 추가 (`GetGoldSpotInvestorStatusAsync`)
- | 0I | 국제금환산가격 API 추가 (`OnRealtimeInternationalGoldPriceReceived`)
- `KiwoomChartGetTickChartItem` 수정
- `KiwoomChartGetChartItem` 수정
- `KiwoomChartGetYearlyCharts` 수정
- `KiwoomChartGetYearChartItem` 추가
- `KiwoomChartGetIndustryTickChartItem` 수정
- `KiwoomChartGetIndustryMinuteCharts` 수정
- `KiwoomChartGetIndustryMinuteChartItem` 추가
- `KiwoomChartGetIndustryChartItem` 수정
- API 문서화 개선

---

### v0.4.0 (2025-09-15)
- .NET 10.0 타겟 프레임워크 추가(Preview)
- `GetCreditLoanAvailableStocksAsync` 요청필드명 `crd_stk_grae_tp`에서 `crd_stk_grde_tp`로 오류 수정
- `KiwoomAccountGetDeposits.MinimumOrderable`를 `decimal`로 수정
- `KiwoomAccountGetCreditDepositOrders.StockDepositRate`를 `string`로 수정
- `KiwoomAccountGetMarginOrders.AccountMarginRate`를 `string`로 수정
- `ExchangeType` 관련 필드를 모두 `~StockExchangeType`로 수정
- `StockExchangeType` 관련 필드를 모두 `~StockExchangeType`로 수정
- `IndustryCode` 필드를 `KiwoomChartIndustryCode`로 수정
- `ContYn` 필드를 `bool`로 수정
- `NxtEnable` 필드를 `bool`로 수정
- `Rank` 필드를 `decimal`에서 `int`로 수정
- `Count` 관련 필드를 모두 `int`, `KiwoomInt`로 수정
- `ProfitLoss` 관련 필드를 모두 `KiwoomDecimal`로 수정
- `AfterMarketSinglePriceChange`를 `KiwoomDecimal`로 수정
- `NetBuyVolume`, `NetBuyAmount` 필드를 `KiwoomDecimal`로 수정
- `AfterMarketSinglePriceChangeRate`를 `KiwoomDecimal`로 수정
- `KiwoomStockInfoGetTradeItem.TradeVolume`를 `KiwoomDecimal`로 수정
- `BuyBrokerVolume`, `SellBrokerVolume` 필드를 `KiwoomDecimal`로 수정
- `KiwoomMarketConditionGetStockInstitutionTransactionTrendItem.InstitutionPeriodAccumulation`, `InstitutionDailyNetVolume`, `ForeignPeriodAccumulation`, `ForeignDailyNetVolume`를 `KiwoomDecimal`로 수정
- `TopBuyExitBroker` 필드를 `KiwoomString`로 수정
- `HoldingCount`를 `HoldingQuantity`로 수정
- `AcquirableCount`를 `AcquirableQuantity`로 수정
- `GetHourlyProgramTradeTrendsAsync`, `GetDailyProgramTradeTrendsAsync` 파라미터를 `KiwoomMarketConditionMarketType3`로 수정
- `KiwoomMarketConditionGetStockOriginTradeTrends`를 `KiwoomMarketConditionGetStockInstitutionTransactionTrends`로 수정

---

### v0.3.1 (2025-09-09)
- `KiwoomString` 타입 추가
- `KiwoomDecimal`로 변환 작업
- `Rank` 필드를 `string`에서 `decimal`로 수정
- `KiwoomMarketConditionGetDailyInstitutionTradingStockItem`에 누락된 필드 추가
- `KiwoomTimeSpanConverter`에서 파싱 실패하는 경우는 `null`로 반환하도록 수정

---

### v0.3.0 (2025-09-09)
#### 금융 시스템 네이밍 체계화
##### 1. 기본 수치 개념
- 합, 합계, 전체: `Total`
- 수량, 금액: `Quantity`, `Amount`
- 누적: `Accumulated`
- 율, 비율, 대비율: `Rate`
##### 2. 위치/방향 개념
- 상위, 하위: `Top`, `Bottom`
- 상한, 하한: `Upper`, `Lower`
- 상승, 보합, 하락: `Up`, `Flat`, `Down`
- 입금, 출금: `Deposit`, `Withdrawal`
- 입고, 출고: `Incoming`, `Outgoing`
##### 3. 거래 행위
- 매수, 매도: `Buy`, `Sell`
- 순매수, 순매도: `NetBuy`, `NetSell`
- 거래, 매매: `Transaction`
- 체결, 미체결: `Trade`, `Unfilled`
- 위탁: `Consignment`
- 접수: `Submission`
##### 4. 호가 및 잔량
- 호가: `Quote`
- 잔량, 호가잔량: `RemainQuantity`, `OrderBook`
##### 5. 가격 데이터
- 시가, 고가, 저가, 종가: `Open`, `High`, `Low`, `Close`
##### 6. 거래량 관련
- 거래량, 거래수량, 매매수량: `Volume`
- 거래금액, 거래대금: `TransactionAmount`
- 거래량대비: `VolumeChange`
- 전일거래량: `PreviousDayVolume`
##### 7. 시간 개념
- 금일, 전일: `Today`, `PreviousDay`
- D+1, D+2: `-D1`, `-D2`
- 일별: `Daily`
##### 8. 변화 개념
- 전일대비: `Change`, `PreviousDayChange`(한 레코드 안에 대비 개념이 중복될 경우)
- 급증, 급감: `Spike`, `Drop`
- 급등, 급락: `Surge`, `Plunge`
- 강도: `Momentum`
- 기호: `Sign`
##### 9. 투자자 분류
- 개인, 기관, 외국인: `Retail`, `Institution`, `Foreign`
- 거래원: `Broker`
##### 10. 자금 및 신용 관련
- 현금, 신용, 대출, 융자, 담보, 대주, 대용: `Cash`, `Credit`, `Loan`, `CreditLoan`, `Collateral`, `ShortSell`, `Substitute`
- 변제, 상환: `Repayment`
- 미납, 미상환: `Unpaid`
- 납부: `Payment`
##### 11. 보증금 및 증거금
- 증거금, 미수금: `Margin`, `Unsettled`
- 예수금, 보증금: `Deposit`
##### 12. 비용 관련
- 수수료, 세금: `Fee`, `Tax`
##### 13. 투자 상품 분류
- 주식, 투자, 원금: `Stock`, `Investment`, `Principal`
- 유가증권, 수익증권, 채권: `Securities`, `Fund`, `Bond`
- 업종: `Industry`
##### 14. 기타 거래 개념
- 차익: `Arbitrage`
- 정산: `Settlement`
- 보유: `Holding`
- 행사, 상장: `Exercise`, `List`
- 시가총액: `MarketCapitalization`
- 대차거래: `SecuritiesLending`

---

### v0.2.1 (2025-09-03)
- 소스코드 주석 추가
- | ka01690 | 일별잔고수익률 API 추가
- `KiwoomRealtimeQuoteRequests` 삭제
- `KiwoomRealtimeQuoteRequestItem` 삭제
- `KiwoomRealtimeQuoteRegistrations` 삭제
- `KiwoomRealtimeQuoteRegistrationItem` 삭제
- `KiwoomRealtimeQuoteValue` 삭제
- `KiwoomRankingInfoGetForeignPeriodTransactionTopItem.NetBuyQuantity`를 `KiwoomDecimal`로 수정
- 종속성 라이브러리 버전별 분기

---

### v0.2.0 (2025-08-29)
- 소스코드 주석 추가
- | ka00198 | 실시간종목조회순위 API 추가
- `KiwoomStockInfoStockCondition.ExcludeManagedAndPreferredAndCaution` 추가
- `KiwoomWebSocketStockExchangeType.Unified`, `NXT` 추가
- | ka10061 | 종목별투자자기관별합계요청의 `trde_tp` 값 `0`으로 고정
- | kt10003 | 주식 취소주문의 API ID를 `kt10002`로 잘못 호출하고 있던 문제 수정
- `KiwoomAccountDelistingQueryType`을 `bool`로 수정 (`isExcludeDelisted`)
- `KiwoomChartUseOption`을 `bool`로 수정 (`isUpdateStockPrice`)
- `KiwoomRankingInfoInclusionOption`을 `bool`로 수정
- `KiwoomStockInfonInclusionOption`을 `bool`로 수정
- `KiwoomStockInfoUseOption`을 `bool`로 수정
- `KiwoomElwTradeQuantityType`을 `decimal`로 수정 (`minVolume`)
- `KiwoomRankingInfoTradeQuantityType`을 `decimal`로 수정 (`minVolume`)
- `KiwoomRankingInfoTradePriceCondition`을 `decimal`로 수정 (`minTransactionAmount`)
- `KiwoomStockInfoTradeQuantityType`을 `decimal`로 수정 (`minVolume`)
- `KiwoomForeignInstitutionPeriodQueryType`을 `int`로 수정 (`period`)
- `KiwoomAccountDepositQueryType.General`을 `KiwoomAccountDepositQueryType.Normal`로 수정
- `KiwoomMarketConditionEstimatedUnitPriceType`을 `KiwoomMarketConditionUnitPriceType`로 수정
- `KiwoomRankingInfoTradeQuantitySortType.TradingVolume`을 `Volume`로 수정
- `KiwoomRankingInfoTradeQuantitySortType.TradingAmount`을 `TransactionAmount`로 수정
- `KiwoomRankingInfoPreviousTradeQuantityQueryType.Top100ByYesterdayTradingAmount`을 `Top100ByYesterdayTransactionAmount`로 수정
- `KiwoomWebSocketRealtimeOrderExecution.ExchangeType` 타입을 `KiwoomWebSocketStockExchangeType`로 수정
- `KiwoomWebSocketRealtimeStockExecution.ExchangeType` 타입을 `KiwoomWebSocketStockExchangeType`로 수정
- `KiwoomForeignInstitutionNetSellAmountType` 삭제 (`2` 고정값)
- `KiwoomSecuritiesLendingQueryType` 삭제

---

### v0.1.2 (2025-08-27)
- 아이콘 업데이트 및 NuGet 패키지 메타데이터 개선
- 코드 문서화 개선
- 프로젝트 아이콘 변경
- README 문서 구조 개선

---

### v0.1.1 (2025-08-27)
- NuGet 패키지 최초 릴리즈
- 패키지 메타데이터 및 설명 추가
- API 문서화 개선
- 빌드 설정 최적화
- FAQ 문서 추가
- 패키지 참조 오류 수정

---

⭐ 이 프로젝트가 도움이 되었다면 스타를 눌러주세요!