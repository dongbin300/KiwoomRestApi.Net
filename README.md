<div align="center">

# KiwoomRestApi.Net

**키움증권 OpenAPI REST API 를 위한 현대적이고 직관적인 .NET Wrapper 라이브러리**

[![NuGet Version](https://img.shields.io/nuget/v/KiwoomRestApi.Net.svg?label=NuGet&color=blue)](https://www.nuget.org/packages/KiwoomRestApi.Net)
[![NuGet Downloads](https://img.shields.io/nuget/dt/KiwoomRestApi.Net.svg?label=Downloads&color=blueviolet)](https://www.nuget.org/packages/KiwoomRestApi.Net)
[![License](https://img.shields.io/github/license/dongbin300/KiwoomRestApi.Net.svg?label=License&color=green)](https://github.com/dongbin300/KiwoomRestApi.Net/blob/main/LICENSE)
[![.NET](https://img.shields.io/badge/.NET-Standard%202.0%20%7C%206%20%7C%208%20%7C%209%20%7C%2010-512bd4)](https://dotnet.microsoft.com/)

[문서](https://dongbin300.github.io/KiwoomRestApi.Net/) · [이슈](https://github.com/dongbin300/KiwoomRestApi.Net/issues) · [FAQ](docs/FAQ.html) · [키움 API 가이드](https://openapi.kiwoom.com/guide/apiguide)

</div>

---

## Quick Start

```bash
dotnet add package KiwoomRestApi.Net
```

```csharp
using KiwoomRestApi.Net.Clients;

// 1. 클라이언트 생성
var client = await KiwoomRestApiClient.CreateAsync("_APP키_", "_SECRET키_", isMock: true);

// 2. 삼성전자 주식 정보 조회
var stockInfo = await client.StockInfo.GetStockInfoAsync("005930", DateTime.Today, KiwoomStockInfoMarginLoanType.Loan);
Console.WriteLine($"삼성전자 현재가: {stockInfo.Data.CurrentPrice}원");

// 3. 당일 실현손익 조회
var todayRealizedProfitLoss = await client.Account.GetTodayRealizedProfitLossAsync("005930");
Console.WriteLine($"평가금액: {todayRealizedProfitLoss.Data.TodayRealizedProfitLoss}%");
```

---

## Features

| Feature | Description |
|:-------:|-------------|
| **OAuth 인증** | 토큰 발급/갱신 관리 |
| **계좌 관리** | 잔고, 주문내역, 예수금, 평가잔고, 실현손익 |
| **주식 정보** | 현재가, 호가, 체결정보 |
| **차트 데이터** | 일/주/월/분봉 차트 |
| **주문 관리** | 매수/매도, 정정, 취소 |
| **시장 정보** | 업종, 테마, 순위, 외국인/기관 |
| **실시간 데이터** | WebSocket 실시간 구독 |
| **종목 검색** | ETF, ELW, 종목 정보 조회 |
| **금현물 거래** | 금현물 시세, 주문, 잔고 |

---

## Key Features

### Complete Async Support

```csharp
// CancellationToken 완벽 지원
using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));
var result = await client.Account.GetDailyStatusAsync(cts.Token);
```

### Dependency Injection Support

```csharp
// Program.cs 또는 Startup.cs
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
    
    public TradingController(KiwoomRestApiClient client) => _client = client;
}
```

---

## Usage Examples

### 주식 정보 조회

```csharp
// 현재가 조회
var stockInfo = await client.StockInfo.GetStockInfoAsync("005930", DateTime.Today, KiwoomStockInfoMarginLoanType.Loan);
Console.WriteLine($"삼성전자 현재가: {stockInfo.Data.CurrentPrice}원");

// 호가 조회
var orderBook = await client.MarketCondition.GetOrderBookAsync("005930");
Console.WriteLine($"매수 1호가: {orderBook.Data.BuyPrice1}원");

// 차트 데이터 조회
var chartData = await client.Chart.GetDailyChartsAsync("005930", DateTime.Today, true);
Console.WriteLine($"삼성전자 전일종가: {chartData.Data.Items.ElementAt(1).CurrentPrice}원");
```

### 계좌 및 주문 관리

```csharp
// 예수금 및 자금 관리
var deposits = await client.Account.GetDepositsAsync(KiwoomAccountDepositQueryType.Normal);
Console.WriteLine($"예수금: {deposits.Data.Deposit:N0}원");

var estimatedAsset = await client.Account.GetEstimatedDepositAssetAsync(isExcludeDelisted: false);
Console.WriteLine($"평가자산 총액: {estimatedAsset.Data.EstimatedDepositAsset:N0}원");

// 잔고 평가
var evaluationBalances = await client.Account.GetEvaluationBalancesAsync(
    	KiwoomAccountEvaluationBalanceQueryType.Aggregate,
	KiwoomAccountDomesticStockExchangeType2.Krx);
Console.WriteLine($"총평가금액: {evaluationBalances.Data.TotalEvaluationAmount:N0}원");

// 수익률 분석
var dailyBalanceProfitRates = await client.Account.GetDailyBalanceProfitRatesAsync(DateTime.Today);
Console.WriteLine($"일별잔고수익률: {dailyBalanceProfitRates.Data.DailyBalanceProfitRates:F2}%");

// 주문 관리
var unfilledOrders = await client.Account.GetUnfilledOrdersAsync(
    KiwoomAccountQueryType.All,
    KiwoomAccountTransactionType.All,
    KiwoomAccountStockExchangeType.Unified);
Console.WriteLine($"미체결 주문 수: {unfilledOrders.Data.Item.Count()}");

// 주문 실행
var buyOrderResult = await _client.Order.PlaceOrderAsync(
	KiwoomOrderType.Buy,
	KiwoomOrderDomesticStockExchangeType.Krx,
	"005930",
	10,
	KiwoomOrderTransactionType.Normal,
	80000);

// 주문 수정/취소
var modifyResult = await _client.Order.ModifyOrderAsync(
	KiwoomOrderDomesticStockExchangeType.Krx,
	"_원주문번호_",
	"005930",
	8,
	82000);

var cancelResult = await _client.Order.CancelOrderAsync(
	KiwoomOrderDomesticStockExchangeType.Krx,
	"_원주문번호_",
	"005930",
	cancelQuantity: 3);
```

### 실시간 데이터 구독

```csharp
var socketClient = await KiwoomSocketClient.CreateAsync(client.Token, isMock: true);

// 실시간 주식체결 수신 이벤트
socketClient.OnRealtimeStockTradeReceived += (message) =>
{
	Console.WriteLine($"체결가: {message.ElementAt(0).Values.CurrentPrice}원");
};

// 실시간 주식체결 구독
await socketClient.WebSocket.SubscribeAsync(
	[KiwoomWebSocketServiceName.StockTrade],
	["005930", "000660"]);
```

### 차트 데이터 유틸리티

> 기간별 차트 데이터를 간편하게 조회할 수 있는 유틸리티 메서드입니다.

```csharp
// 주식 틱차트 조회 (기간)
var tickCharts = await client.Chart.GetTickChartsByRangeAsync(
    "005930",
    1,
    DateTime.Today.AddDays(-3),
    DateTime.Today,
    true
);

// 주식 분봉차트 조회 (기간)
var minuteCharts = await client.Chart.GetMinuteChartsByRangeAsync(
    "005930",
    1,
    DateTime.Today.AddDays(-30),
    DateTime.Today,
    true
);

// 주식 일봉차트 조회 (기간)
var dailyCharts = await client.Chart.GetDailyChartsByRangeAsync(
    "005930", 
    DateTime.Today.AddDays(-100), 
    DateTime.Today,
    true
);

// 주식 주봉차트 조회 (기간)
var weeklyCharts = await client.Chart.GetWeeklyChartsByRangeAsync(
    "005930", 
    DateTime.Today.AddDays(-100), 
    DateTime.Today,
    true
);

// 주식 월봉차트 조회 (기간)
var monthlyCharts = await client.Chart.GetMonthlyChartsByRangeAsync(
    "005930", 
    DateTime.Today.AddDays(-365), 
    DateTime.Today,
    true
);

// 주식 년봉차트 조회 (기간)
var yearlyCharts = await client.Chart.GetYearlyChartsByRangeAsync(
    "005930", 
    DateTime.Today.AddYears(-5), 
    DateTime.Today,
    true
);

// 업종 차트도 동일하게 지원
var industryTickCharts = await client.Chart.GetIndustryTickChartsByRangeAsync(
    KiwoomChartIndustryCode.Kospi200,
    1,
    DateTime.Today.AddDays(-3),
    DateTime.Today
);

// 금현물 차트도 지원
var goldSpotTickCharts = await client.Chart.GetGoldSpotTickChartsByRangeAsync(
    KiwoomGoldSpotStockCode.Gold_1kg,
    1,
    DateTime.Today.AddDays(-30),
    DateTime.Today,
    true
);
```

### 금현물 거래

```csharp
// 금현물 주문
var goldBuyOrderResult = await client.Order.GoldSpotPlaceOrderAsync(
    KiwoomOrderType.Buy,
    KiwoomGoldSpotStockCode.Gold_1kg,
    1,
    KiwoomOrderGoldSpotTransactionType.Normal,
    8500000);

// 금현물 잔고확인
var goldEvaluationBalances = await client.Account.GetGoldEvaluationBalancesAsync();
Console.WriteLine($"금현물 잔고평가금액: {goldEvaluationBalances.Data.BalanceEvaluation:N0}원");
```

---

## Performance Tips

### API 제한사항

| 구분 | 제한 | 권장사항 |
|:----:|:----:|----------|
| **API 호출** | 초당 20 회 | Rate limiting 구현 |
| **실시간 구독** | 동시 40 종목 | 필요한 종목만 구독 |
| **WebSocket** | 연결당 1 개 | 연결 상태 모니터링 |
| **토큰 유효기간** | 24 시간 | 자동 갱신 로직 구현 |

### 최적화 가이드

```csharp
// 권장: CancellationToken 사용
using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(10));
var result = await client.StockInfo.GetStockInfoAsync(
    "005930", 
    DateTime.Today,
    KiwoomStockInfoMarginLoanType.Loan, 
    cts.Token);

// 권장: 배치 처리
var stockCodes = new[] { "005930", "000660", "035420" };
var tasks = stockCodes.Select(code =>
    client.StockInfo.GetStockInfoAsync(code, DateTime.Today, KiwoomStockInfoMarginLoanType.Loan));
var results = await Task.WhenAll(tasks);

// 주의: 동기 블로킹은 피하세요
// var result = client.StockInfo.GetStockInfoAsync("005930", DateTime.Today, KiwoomStockInfoMarginLoanType.Loan).Result;
```

---

## Supported Platforms

| Platform | Version |
|:---------|:--------|
| .NET Standard | 2.0 (Unity, Xamarin 호환) |
| .NET Standard | 2.1 |
| .NET | 6.0 |
| .NET | 8.0 |
| .NET | 9.0 |
| .NET | 10.0 |

---

<details>
<summary><strong>Release Notes</strong></summary>

### v0.8.0 (2026-06-29)
- 추가: | ka01300 | 관심종목 그룹 리스트 조회 (`GetWatchlistGroupsAsync`)
- 추가: | ka01301 | 관심종목 그룹 상세 조회 (`GetWatchlistGroupDetailsAsync`)

### v0.7.2 (2026-04-29)
- 변경: 전체적인 성능 개선

### v0.7.0 (2026-03-18)
- 추가: | ka00001 | 계좌번호조회 (`GetAccountIdAsync`)
- 추가: | kt50020 | 금현물 잔고확인 (`GetGoldEvaluationBalancesAsync`)
- 추가: | kt50021 | 금현물 예수금 (`GetGoldDepositAsync`)
- 추가: | kt50030 | 금현물 주문체결전체조회 (`GetGoldAllTradesAsync`)
- 추가: | kt50031 | 금현물 주문체결조회 (`GetGoldTradesAsync`)
- 추가: | kt50032 | 금현물 거래내역조회 (`GetGoldTradeHistoriesAsync`)
- 추가: | kt50075 | 금현물 미체결조회 (`GetGoldUnfilledOrdersAsync`)
- 추가: 주식틱차트조회요청 (기간) (`GetTickChartsByRangeAsync`)
- 추가: 주식분봉차트조회요청 (기간) (`GetMinuteChartsByRangeAsync`)
- 추가: 주식일봉차트조회요청 (기간) (`GetDailyChartsByRangeAsync`)
- 추가: 주식주봉차트조회요청 (기간) (`GetWeeklyChartsByRangeAsync`)
- 추가: 주식월봉차트조회요청 (기간) (`GetMonthlyChartsByRangeAsync`)
- 추가: 주식년봉차트조회요청 (기간) (`GetYearlyChartsByRangeAsync`)
- 추가: 업종틱차트조회요청 (기간) (`GetIndustryTickChartsByRangeAsync`)
- 추가: 업종분봉조회요청 (기간) (`GetIndustryMinuteChartsByRangeAsync`)
- 추가: 업종일봉조회요청 (기간) (`GetIndustryDailyChartsByRangeAsync`)
- 추가: 업종주봉조회요청 (기간) (`GetIndustryWeeklyChartsByRangeAsync`)
- 추가: 업종월봉조회요청 (기간) (`GetIndustryMonthlyChartsByRangeAsync`)
- 추가: 업종년봉조회요청 (기간) (`GetIndustryYearlyChartsByRangeAsync`)
- 추가: 금현물틱차트조회요청 (기간) (`GetGoldSpotTickChartsByRangeAsync`)
- 추가: 금현물분봉차트조회요청 (기간) (`GetGoldSpotMinuteChartsByRangeAsync`)
- 추가: 금현물일봉차트조회요청 (기간) (`GetGoldSpotDailyChartsByRangeAsync`)
- 추가: 금현물주봉차트조회요청 (기간) (`GetGoldSpotWeeklyChartsByRangeAsync`)
- 추가: 금현물월봉차트조회요청 (기간) (`GetGoldSpotMonthlyChartsByRangeAsync`)
- 변경: `KiwoomAccountTransactionTypeType` -> `KiwoomAccountTransactionType4`
- 변경: `GetEvaluationBalancesAsync`파라미터 `KiwoomAccountDomesticStockExchangeType` -> `KiwoomAccountDomesticStockExchangeType2`
- 변경: `GetEvaluationsAsync`파라미터 `KiwoomAccountStockExchangeType` -> `KiwoomAccountStockExchangeType2`
- 변경: | ka10080 | 주식분봉차트조회요청 기준일자 (`date`) 파라미터 추가
- 변경: | ka20005 | 업종분봉조회요청 기준일자 (`date`) 파라미터 추가

### v0.6.2 (2026-02-05)
- 변경: `KiwoomWebSocketRealtimeOrderTrade`.`AccountId`, `OrderId`, `ManagerId`를 `decimal?` -> `string?` (#2)
- 변경: `KiwoomWebSocketRealtimeBalance`.`AccountId`를 `decimal?` -> `string?` (#2)

### v0.6.1 (2026-02-05)
- 변경: `KiwoomWebSocketRealtimeBalance`.`StockCode`를 `decimal?` -> `string?` (#2)
- 변경: `KiwoomWebSocketRealtimeOrderTrade`.`StockCode`를 `decimal?` -> `string?` (#2)

### v0.6.0 (2026-01-02)
- 변경: 대용량 메시지 수신 시 JSON 파싱 에러 해결 (#1)
- 변경: Microsoft.Extensions, System.Text.Json 최신 버전으로 업데이트 (10.0.1)
- 변경: | kt00005 | 체결잔고요청 `KiwoomAccountStockExchangeType` -> `KiwoomAccountStockExchangeType2`
- 변경: | ka10073 | 일자별종목별실현손익요청_기간 `TodayHtsSellFee` 를 `string` 로 변경
- 변경: | ka30002 | 거래원별 ELW 순매매상위요청 `issuerCompanyCode` 파라미터를 `string` 로 변경
- 변경: | ka10005 | 주식일주월시분요청 `KiwoomMarketConditionGetDailyWeeklyMonthly` 멤버 변경
- 변경: | ka10101 | 업종코드 리스트 `marketCode` 를 `list` 로 변경
- 변경: KiwoomWebSocketRealtime 멤버변수 일부 `string` -> `KiwoomString`

### v0.5.1 (2025-11-05)
- 삭제: | ka10079 | 주식틱차트조회요청 체결일
- 삭제: | ka20004 | 업종틱차트조회요청 체결일

### v0.5.0 (2025-10-16)
- 추가: | ka50010 | 금현물체결추이 API (`GetGoldTradeTrendsAsync`)
- 추가: | ka50012 | 금현물일별추이 API (`GetGoldDailyTrendsAsync`)
- 추가: | ka50087 | 금현물예상체결 API (`GetGoldExpectedTradesAsync`)
- 추가: | ka50100 | 금현물시세정보 API (`GetGoldInfoAsync`)
- 추가: | ka50101 | 금현물 호가 API (`GetGoldQuotesAsync`)
- 추가: | kt50000 | 금현물 매수주문 API (`GoldSpotPlaceOrderAsync`)
- 추가: | kt50001 | 금현물 매도주문 API (`GoldSpotPlaceOrderAsync`)
- 추가: | kt50002 | 금현물 정정주문 API (`GoldSpotModifyOrderAsync`)
- 추가: | kt50003 | 금현물 취소주문 API (`GoldSpotCancelOrderAsync`)
- 추가: | ka50079 | 금현물틱차트조회요청 API (`GetGoldSpotTickChartsAsync`)
- 추가: | ka50080 | 금현물분봉차트조회요청 API (`GetGoldSpotMinuteChartsAsync`)
- 추가: | ka50081 | 금현물일봉차트조회요청 API (`GetGoldSpotDailyChartsAsync`)
- 추가: | ka50082 | 금현물주봉차트조회요청 API (`GetGoldSpotWeeklyChartsAsync`)
- 추가: | ka50083 | 금현물월봉차트조회요청 API (`GetGoldSpotMonthlyChartsAsync`)
- 추가: | ka50091 | 금현물당일틱차트조회요청 API (`GetGoldSpotTodayTickChartsAsync`)
- 추가: | ka50092 | 금현물당일분봉차트조회요청 API (`GetGoldSpotTodayMinuteChartsAsync`)
- 추가: | ka52301 | 금현물투자자현황 API (`GetGoldSpotInvestorStatusAsync`)
- 추가: | 0I | 국제금환산가격 API (`OnRealtimeInternationalGoldPriceReceived`)
- 변경: `KiwoomChartGetTickChartItem`
- 변경: `KiwoomChartGetChartItem`
- 변경: `KiwoomChartGetYearlyCharts`
- 추가: `KiwoomChartGetYearChartItem`
- 변경: `KiwoomChartGetIndustryTickChartItem`
- 변경: `KiwoomChartGetIndustryMinuteCharts`
- 추가: `KiwoomChartGetIndustryMinuteChartItem`
- 변경: `KiwoomChartGetIndustryChartItem`
- 변경: API 문서화 개선

### v0.4.0 (2025-09-15)
- 추가: .NET 10.0 타겟 프레임워크 추가 (Preview)
- 변경: `GetCreditLoanAvailableStocksAsync` 요청필드명 `crd_stk_grae_tp` -> `crd_stk_grde_tp`
- 변경: `KiwoomAccountGetDeposits.MinimumOrderable` 를 `decimal`로 수정
- 변경: `KiwoomAccountGetCreditDepositOrders.StockDepositRate` 를 `string`로 수정
- 변경: `KiwoomAccountGetMarginOrders.AccountMarginRate` 를 `string`로 수정
- 변경: `ExchangeType` 관련 필드를 모두 `~StockExchangeType` 로 수정
- 변경: `StockExchangeType` 관련 필드를 모두 `~StockExchangeType` 로 수정
- 변경: `IndustryCode` 필드를 `KiwoomChartIndustryCode` 로 수정
- 변경: `ContYn` 필드를 `bool`로 수정
- 변경: `NxtEnable` 필드를 `bool`로 수정
- 변경: `Rank` 필드를 `decimal` -> `int`
- 변경: `Count` 관련 필드를 모두 `int`, `KiwoomInt`로 수정
- 변경: `ProfitLoss` 관련 필드를 모두 `KiwoomDecimal`로 수정
- 변경: `AfterMarketSinglePriceChange` 를 `KiwoomDecimal`로 수정
- 변경: `NetBuyVolume`, `NetBuyAmount` 필드를 `KiwoomDecimal`로 수정
- 변경: `AfterMarketSinglePriceChangeRate` 를 `KiwoomDecimal`로 수정
- 변경: `KiwoomStockInfoGetTradeItem.TradeVolume` 를 `KiwoomDecimal`로 수정
- 변경: `BuyBrokerVolume`, `SellBrokerVolume` 필드를 `KiwoomDecimal`로 수정
- 변경: `KiwoomMarketConditionGetStockInstitutionTransactionTrendItem.InstitutionPeriodAccumulation`, `InstitutionDailyNetVolume`, `ForeignPeriodAccumulation`, `ForeignDailyNetVolume`를 `KiwoomDecimal`로 수정
- 변경: `TopBuyExitBroker` 필드를 `KiwoomString`로 수정
- 변경: `HoldingCount` 를 `HoldingQuantity` 로 수정
- 변경: `AcquirableCount` 를 `AcquirableQuantity` 로 수정
- 변경: `GetHourlyProgramTradeTrendsAsync`, `GetDailyProgramTradeTrendsAsync` 파라미터를 `KiwoomMarketConditionMarketType3` 로 수정
- 변경: `KiwoomMarketConditionGetStockOriginTradeTrends` -> `KiwoomMarketConditionGetStockInstitutionTransactionTrends`

### v0.3.1 (2025-09-09)
- 추가: `KiwoomString` 타입
- 변경: `KiwoomDecimal`로 변환 작업
- 변경: `Rank` 필드를 `string` -> `decimal`
- 추가: `KiwoomMarketConditionGetDailyInstitutionTradingStockItem`에 누락된 필드 추가
- 변경: `KiwoomTimeSpanConverter` 에서 파싱 실패하는 경우는 `null`로 반환하도록 수정

<details>
<summary><strong>v0.3.0 및 이전 버전</strong></summary>

### v0.3.0 (2025-09-09)

#### 금융 시스템 네이밍 체계화
##### 기본 수치 개념
- 합, 합계, 전체: `Total`
- 수량, 금액: `Quantity`, `Amount`
- 누적: `Accumulated`
- 율, 비율, 대비율: `Rate`

##### 위치/방향 개념
- 상위, 하위: `Top`, `Bottom`
- 상한, 하한: `Upper`, `Lower`
- 상승, 보합, 하락: `Up`, `Flat`, `Down`
- 입금, 출금: `Deposit`, `Withdrawal`
- 입고, 출고: `Incoming`, `Outgoing`

##### 거래 행위
- 매수, 매도: `Buy`, `Sell`
- 순매수, 순매도: `NetBuy`, `NetSell`
- 거래, 매매: `Transaction`
- 체결, 미체결: `Trade`, `Unfilled`
- 위탁: `Consignment`
- 접수: `Submission`

##### 호가 및 잔량
- 호가: `Quote`
- 잔량, 호가잔량: `RemainQuantity`, `OrderBook`

##### 가격 데이터
- 시가, 고가, 저가, 종가: `Open`, `High`, `Low`, `Close`

##### 거래량 관련
- 거래량, 거래수량, 매매수량: `Volume`
- 거래금액, 거래대금: `TransactionAmount`
- 거래량대비: `VolumeChange`
- 전일거래량: `PreviousDayVolume`

##### 시간 개념
- 금일, 전일: `Today`, `PreviousDay`
- D+1, D+2: `-D1`, `-D2`
- 일별: `Daily`

##### 변화 개념
- 전일대비: `Change`, `PreviousDayChange`(한 레코드 안에 대비 개념이 중복될 경우)
- 급증, 급감: `Spike`, `Drop`
- 급등, 급락: `Surge`, `Plunge`
- 강도: `Momentum`
- 기호: `Sign`

##### 투자자 분류
- 개인, 기관, 외국인: `Retail`, `Institution`, `Foreign`
- 거래원: `Broker`

##### 자금 및 신용 관련
- 현금, 신용, 대출, 융자, 담보, 대주, 대용: `Cash`, `Credit`, `Loan`, `CreditLoan`, `Collateral`, `ShortSell`, `Substitute`
- 변제, 상환: `Repayment`
- 미납, 미상환: `Unpaid`
- 납부: `Payment`

##### 보증금 및 증거금
- 증거금, 미수금: `Margin`, `Unsettled`
- 예수금, 보증금: `Deposit`

##### 비용 관련
- 수수료, 세금: `Fee`, `Tax`

##### 투자 상품 분류
- 주식, 투자, 원금: `Stock`, `Investment`, `Principal`
- 유가증권, 수익증권, 채권: `Securities`, `Fund`, `Bond`
- 업종: `Industry`

##### 기타 거래 개념
- 차익: `Arbitrage`
- 정산: `Settlement`
- 보유: `Holding`
- 행사, 상장: `Exercise`, `List`
- 시가총액: `MarketCapitalization`
- 대차거래: `SecuritiesLending`

### v0.2.1 (2025-09-03)
- 추가: 소스코드 주석
- 추가: | ka01690 | 일별잔고수익률 API
- 삭제: `KiwoomRealteQuoteRequests`
- 삭제: `KiwoomRealteQuoteRequestItem`
- 삭제: `KiwoomRealteQuoteRegistrations`
- 삭제: `KiwoomRealteQuoteRegistrationItem`
- 삭제: `KiwoomRealteQuoteValue`
- 변경: `KiwoomRankingInfoGetForeignPeriodTransactionTopItem.NetBuyQuantity` 를 `KiwoomDecimal`로 수정
- 변경: 종속성 라이브러리 버전별 분기

### v0.2.0 (2025-08-29)
- 추가: 소스코드 주석
- 추가: | ka00198 | 실시간종목조회순위 API
- 추가: `KiwoomStockInfoStockCondition.ExcludeManagedAndPreferredAndCaution`
- 추가: `KiwoomWebSocketStockExchangeType.Unified`, `NXT` 추가
- 변경: | ka10061 | 종목별투자자기관별합계요청의 `trde_tp` 값 `0` 으로 고정
- 변경: | kt10003 | 주식 취소주문의 API ID 를 `kt10002`로 잘못 호출하고 있던 문제 수정
- 변경: `KiwoomAccountDelistingQueryType` 을 `bool`로 수정 (`isExcludeDelisted`)
- 변경: `KiwoomChartUseOption` 을 `bool`로 수정 (`isUpdateStockPrice`)
- 변경: `KiwoomRankingInfoInclusionOption` 을 `bool`로 수정
- 변경: `KiwoomStockInfonInclusionOption` 을 `bool`로 수정
- 변경: `KiwoomStockInfoUseOption` 을 `bool`로 수정
- 변경: `KiwoomElwTradeQuantityType` 을 `decimal`로 수정 (`minVolume`)
- 변경: `KiwoomRankingInfoTradeQuantityType` 을 `decimal`로 수정 (`minVolume`)
- 변경: `KiwoomRankingInfoTradePriceCondition` 을 `decimal`로 수정 (`minTransactionAmount`)
- 변경: `KiwoomStockInfoTradeQuantityType` 을 `decimal`로 수정 (`minVolume`)
- 변경: `KiwoomForeignInstitutionPeriodQueryType` 을 `int`로 수정 (`period`)
- 변경: `KiwoomAccountDepositQueryType.General` -> `KiwoomAccountDepositQueryType.Normal`
- 변경: `KiwoomMarketConditionEstimatedUnitPriceType` -> `KiwoomMarketConditionUnitPriceType`
- 변경: `KiwoomRankingInfoTradeQuantitySortType.TradingVolume` -> `Volume`
- 변경: `KiwoomRankingInfoTradeQuantitySortType.TradingAmount` -> `TransactionAmount`
- 변경: `KiwoomRankingInfoPreviousTradeQuantityQueryType.Top100ByYesterdayTradingAmount` -> `Top100ByYesterdayTransactionAmount`
- 변경: `KiwoomWebSocketRealtimeOrderExecution.ExchangeType` 타입을 `KiwoomWebSocketStockExchangeType` 로 수정
- 변경: `KiwoomWebSocketRealtimeStockExecution.ExchangeType` 타입을 `KiwoomWebSocketStockExchangeType` 로 수정
- 삭제: `KiwoomForeignInstitutionNetSellAmountType` (`2` 고정값)
- 삭제: `KiwoomSecuritiesLendingQueryType`

### v0.1.2 (2025-08-27)
- 아이콘 업데이트 및 NuGet 패키지 메타데이터 개선
- 코드 문서화 개선
- 프로젝트 아이콘 변경
- README 문서 구조 개선

### v0.1.1 (2025-08-27)
- NuGet 패키지 최초 릴리즈
- 패키지 메타데이터 및 설명 추가
- API 문서화 개선
- 빌드 설정 최적화
- FAQ 문서 추가
- 패키지 참조 오류 수정

</details>
</details>

---

## Disclaimer

> 이 라이브러리는 키움증권과 공식적인 관계가 없는 개인 프로젝트입니다.
> 실제 거래 시에는 충분한 테스트를 거쳐 사용하시기 바랍니다.

## License

This project is licensed under the [MIT License](LICENSE).

---

<div align="center">

**If this project helped you, consider giving it a star!**

[Report Bug](https://github.com/dongbin300/KiwoomRestApi.Net/issues) · [Request Feature](https://github.com/dongbin300/KiwoomRestApi.Net/issues) · [Documentation](https://dongbin300.github.io/KiwoomRestApi.Net/)

</div>
