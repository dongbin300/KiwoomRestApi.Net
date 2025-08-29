using KiwoomRestApi.Net.Clients;
using KiwoomRestApi.Net.Enums.Account;
using KiwoomRestApi.Net.Enums.Chart;
using KiwoomRestApi.Net.Enums.CreditOrder;
using KiwoomRestApi.Net.Enums.Elw;
using KiwoomRestApi.Net.Enums.Etf;
using KiwoomRestApi.Net.Enums.ForeignInstitution;
using KiwoomRestApi.Net.Enums.MarketCondition;
using KiwoomRestApi.Net.Enums.Order;
using KiwoomRestApi.Net.Enums.RankingInfo;
using KiwoomRestApi.Net.Enums.Sector;
using KiwoomRestApi.Net.Enums.SecuritiesLendingAndBorrowing;
using KiwoomRestApi.Net.Enums.ShortSale;
using KiwoomRestApi.Net.Enums.StockInfo;
using KiwoomRestApi.Net.Enums.Theme;

namespace KiwoomRestApi.Net.Tests
{
	public class KiwoomRestApiClientTests
	{
		KiwoomRestApiClient client = default!;

		[OneTimeSetUp]
		public async Task OneTimeSetUp()
		{
			var appKey = File.ReadAllText("D:\\Assets\\kiwoom_appkey_mock.txt");
			var secretKey = File.ReadAllText("D:\\Assets\\kiwoom_secretkey_mock.txt");
			client = await KiwoomRestApiClient.CreateAsync(appKey, secretKey, true);
		}

		#region OAuth
		//[Test]
		//public async Task GetAccessAndRevokeToken()
		//{
		//	var client = new KiwoomRestApiClient(appKey, secretKey, true);
		//	var result = await client.OAuth.GetAccessToken();
		//	var token = result.Data?.Token ?? string.Empty;

		//	Assert.Multiple(() =>
		//	{
		//		Assert.That(result.ReturnCode, Is.EqualTo(0));
		//		Assert.That(string.IsNullOrEmpty(token), Is.False);
		//	});

		//	var result2 = await client.OAuth.RevokeAccessToken(token);

		//	Assert.That(result2.ReturnCode, Is.EqualTo(0));
		//}
		#endregion

		#region Chart
		[TestCase("2025-08-01", "005930", KiwoomChartAmountQuantityType.Amount, KiwoomChartTradeType.Buy, KiwoomChartUnitType.One)]
		public async Task GetStockInvestorInstitutionChartsAsync(string _date, string stockCode, KiwoomChartAmountQuantityType amountQuantityType, KiwoomChartTradeType tradeType, KiwoomChartUnitType unitType)
		{
			DateTime date = DateTime.Parse(_date);
			var result = await client.Chart.GetStockInvestorInstitutionChartsAsync(date, stockCode, amountQuantityType, tradeType, unitType);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomChartMarketType.KOSPI, KiwoomChartAmountQuantityType.Amount, KiwoomChartTradeType.Buy, "005930")]
		public async Task GetIntradayInvestorTradeChartsAsync(KiwoomChartMarketType marketType, KiwoomChartAmountQuantityType amountQuantityType, KiwoomChartTradeType tradeType, string stockCode)
		{
			var result = await client.Chart.GetIntradayInvestorTradeChartsAsync(marketType, amountQuantityType, tradeType, stockCode);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930", 100, true)]
		public async Task GetTickChartsAsync(string stockCode, int tickCount, bool isUpdateStockPrice)
		{
			var result = await client.Chart.GetTickChartsAsync(stockCode, tickCount, isUpdateStockPrice);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930", 100, true)]
		public async Task GetMinuteChartsAsync(string stockCode, int tickCount, bool isUpdateStockPrice)
		{
			var result = await client.Chart.GetMinuteChartsAsync(stockCode, tickCount, isUpdateStockPrice);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930", "2025-08-01", true)]
		public async Task GetDailyChartsAsync(string stockCode, string _date, bool isUpdateStockPrice)
		{
			DateTime date = DateTime.Parse(_date);
			var result = await client.Chart.GetDailyChartsAsync(stockCode, date, isUpdateStockPrice);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930", "2025-08-01", true)]
		public async Task GetWeeklyChartsAsync(string stockCode, string _date, bool isUpdateStockPrice)
		{
			DateTime date = DateTime.Parse(_date);
			var result = await client.Chart.GetWeeklyChartsAsync(stockCode, date, isUpdateStockPrice);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930", "2025-08-01", true)]
		public async Task GetMonthlyChartsAsync(string stockCode, string _date, bool isUpdateStockPrice)
		{
			DateTime date = DateTime.Parse(_date);
			var result = await client.Chart.GetMonthlyChartsAsync(stockCode, date, isUpdateStockPrice);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930", "2025-08-01", true)]
		public async Task GetYearlyChartsAsync(string stockCode, string _date, bool isUpdateStockPrice)
		{
			DateTime date = DateTime.Parse(_date);
			var result = await client.Chart.GetYearlyChartsAsync(stockCode, date, isUpdateStockPrice);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomChartIndustryCode.CompositeKOSPI, 100)]
		public async Task GetIndustryTickChartsAsync(KiwoomChartIndustryCode industryCode, int tickCount)
		{
			var result = await client.Chart.GetIndustryTickChartsAsync(industryCode, tickCount);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomChartIndustryCode.CompositeKOSPI, 100)]
		public async Task GetIndustryMinuteChartsAsync(KiwoomChartIndustryCode industryCode, int tickCount)
		{
			var result = await client.Chart.GetIndustryMinuteChartsAsync(industryCode, tickCount);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomChartIndustryCode.CompositeKOSPI, "2025-08-01")]
		public async Task GetIndustryDailyChartsAsync(KiwoomChartIndustryCode industryCode, string _date)
		{
			DateTime date = DateTime.Parse(_date);
			var result = await client.Chart.GetIndustryDailyChartsAsync(industryCode, date);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomChartIndustryCode.CompositeKOSPI, "2025-08-01")]
		public async Task GetIndustryWeeklyChartsAsync(KiwoomChartIndustryCode industryCode, string _date)
		{
			DateTime date = DateTime.Parse(_date);
			var result = await client.Chart.GetIndustryWeeklyChartsAsync(industryCode, date);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomChartIndustryCode.CompositeKOSPI, "2025-08-01")]
		public async Task GetIndustryMonthlyChartsAsync(KiwoomChartIndustryCode industryCode, string _date)
		{
			DateTime date = DateTime.Parse(_date);
			var result = await client.Chart.GetIndustryMonthlyChartsAsync(industryCode, date);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomChartIndustryCode.CompositeKOSPI, "2025-08-01")]
		public async Task GetIndustryYearlyChartsAsync(KiwoomChartIndustryCode industryCode, string _date)
		{
			DateTime date = DateTime.Parse(_date);
			var result = await client.Chart.GetIndustryYearlyChartsAsync(industryCode, date);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}
		#endregion

		#region CreditOrder
		[TestCase(KiwoomCreditOrderDomesticStockExchangeType.KRX, "005930", 100.0, KiwoomCreditOrderTradeType.Normal, 50000.0)]
		public async Task GetCreditOrderBuyAsync(KiwoomCreditOrderDomesticStockExchangeType domesticStockExchangeType, string stockCode, decimal orderQuantity, KiwoomCreditOrderTradeType tradeType, decimal? orderPrice)
		{
			var result = await client.CreditOrder.GetCreditOrderBuyAsync(domesticStockExchangeType, stockCode, orderQuantity, tradeType, orderPrice);

			Assert.That(result.ReturnCode, Is.EqualTo(0).Or.EqualTo(20));
		}

		[TestCase(KiwoomCreditOrderDomesticStockExchangeType.KRX, "005930", 100.0, KiwoomCreditOrderTradeType.Normal, KiwoomCreditOrderDealType.Loan, 50000.0)]
		public async Task GetCreditOrderSellAsync(KiwoomCreditOrderDomesticStockExchangeType domesticStockExchangeType, string stockCode, decimal orderQuantity, KiwoomCreditOrderTradeType tradeType, KiwoomCreditOrderDealType dealType, decimal? orderPrice)
		{
			var result = await client.CreditOrder.GetCreditOrderSellAsync(domesticStockExchangeType, stockCode, orderQuantity, tradeType, dealType, orderPrice);

			Assert.That(result.ReturnCode, Is.EqualTo(0).Or.EqualTo(20));
		}

		[TestCase(KiwoomCreditOrderDomesticStockExchangeType.KRX, "12345", "005930", 50.0, 51000.0)]
		public async Task GetCreditOrderModificationAsync(KiwoomCreditOrderDomesticStockExchangeType domesticStockExchangeType, string originalOrderId, string stockCode, decimal modifyQuantity, decimal modifyPrice)
		{
			var result = await client.CreditOrder.GetCreditOrderModificationAsync(domesticStockExchangeType, originalOrderId, stockCode, modifyQuantity, modifyPrice);

			Assert.That(result.ReturnCode, Is.EqualTo(0).Or.EqualTo(20));
		}

		[TestCase(KiwoomCreditOrderDomesticStockExchangeType.KRX, "12345", "005930", 25.0)]
		public async Task GetCreditOrderCancellationAsync(KiwoomCreditOrderDomesticStockExchangeType domesticStockExchangeType, string originalOrderId, string stockCode, decimal cancelQuantity)
		{
			var result = await client.CreditOrder.GetCreditOrderCancellationAsync(domesticStockExchangeType, originalOrderId, stockCode, cancelQuantity);

			Assert.That(result.ReturnCode, Is.EqualTo(0).Or.EqualTo(20));
		}
		#endregion

		#region Order
		[TestCase(KiwoomOrderType.Buy, KiwoomOrderDomesticStockExchangeType.KRX, "005930", 100.0, KiwoomOrderTradeType.Normal, 50000.0)]
		public async Task PlaceOrderAsync(KiwoomOrderType orderType, KiwoomOrderDomesticStockExchangeType domesticStockExchangeType, string stockCode, decimal orderQuantity, KiwoomOrderTradeType tradeType, decimal? orderPrice)
		{
			var result = await client.Order.PlaceOrderAsync(orderType, domesticStockExchangeType, stockCode, orderQuantity, tradeType, orderPrice);

			Assert.That(result.ReturnCode, Is.EqualTo(0).Or.EqualTo(20));
		}

		[TestCase(KiwoomOrderDomesticStockExchangeType.KRX, "12345", "005930", 50.0, 51000.0)]
		public async Task ModifyOrderAsync(KiwoomOrderDomesticStockExchangeType domesticStockExchangeType, string originalOrderId, string stockCode, decimal modifyQuantity, decimal modifyPrice)
		{
			var result = await client.Order.ModifyOrderAsync(domesticStockExchangeType, originalOrderId, stockCode, modifyQuantity, modifyPrice);

			Assert.That(result.ReturnCode, Is.EqualTo(0).Or.EqualTo(20));
		}

		[TestCase(KiwoomOrderDomesticStockExchangeType.KRX, "12345", "005930", 25.0)]
		public async Task CancelOrderAsync(KiwoomOrderDomesticStockExchangeType domesticStockExchangeType, string originalOrderId, string stockCode, decimal cancelQuantity)
		{
			var result = await client.Order.CancelOrderAsync(domesticStockExchangeType, originalOrderId, stockCode, cancelQuantity);

			Assert.That(result.ReturnCode, Is.EqualTo(0).Or.EqualTo(2));
		}
		#endregion

		#region Account
		[TestCase("005930", "2025-08-04")]
		public async Task GetDateStockRealizedProfitLossAsync(string stockCode, string _date)
		{
			DateTime date = DateTime.Parse(_date);
			var result = await client.Account.GetDateStockRealizedProfitLossAsync(stockCode, date);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930", "2025-08-01", "2025-08-04")]
		public async Task GetPeriodStockRealizedProfitLossAsync(string stockCode, string _startDate, string _endDate)
		{
			DateTime startDate = DateTime.Parse(_startDate);
			DateTime endDate = DateTime.Parse(_endDate);
			var result = await client.Account.GetPeriodStockRealizedProfitLossAsync(stockCode, startDate, endDate);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("2025-08-01", "2025-08-04")]
		public async Task GetRealizedProfitLossAsync(string _startDate, string _endDate)
		{
			DateTime startDate = DateTime.Parse(_startDate);
			DateTime endDate = DateTime.Parse(_endDate);
			var result = await client.Account.GetRealizedProfitLossAsync(startDate, endDate);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomAccountQueryType.All, KiwoomAccountTradeType.All, KiwoomAccountStockExchangeType.Unified)]
		public async Task GetOutstandingOrdersAsync(KiwoomAccountQueryType queryType, KiwoomAccountTradeType tradeType, KiwoomAccountStockExchangeType stockExchangeType)
		{
			var result = await client.Account.GetOutstandingOrdersAsync(queryType, tradeType, stockExchangeType);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomAccountQueryType.All, KiwoomAccountTradeType.All, KiwoomAccountStockExchangeType.Unified)]
		public async Task GetContractsAsync(KiwoomAccountQueryType queryType, KiwoomAccountTradeType tradeType, KiwoomAccountStockExchangeType stockExchangeType)
		{
			var result = await client.Account.GetContractsAsync(queryType, tradeType, stockExchangeType);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930")]
		public async Task GetTodayRealizedProfitLossAsync(string stockCode)
		{
			var result = await client.Account.GetTodayRealizedProfitLossAsync(stockCode);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomAccountStockExchangeType.Unified)]
		public async Task GetProfitRateAsync(KiwoomAccountStockExchangeType stockExchangeType)
		{
			var result = await client.Account.GetProfitRateAsync(stockExchangeType);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("00000000")]
		public async Task GetOutstandingPartialOrdersAsync(string orderId)
		{
			var result = await client.Account.GetOutstandingPartialOrdersAsync(orderId);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomAccountOddLotType.TodayBuyTodaySell, KiwoomAccountCashCreditType.All)]
		[TestCase(KiwoomAccountOddLotType.TodayBuyTodaySell, KiwoomAccountCashCreditType.All, "2025-08-01")]
		public async Task GetTodayTradeDiariesAsync(KiwoomAccountOddLotType oddLotType, KiwoomAccountCashCreditType cashCreditType, string _date = "2025-01-01")
		{
			DateTime date = DateTime.Parse(_date);
			var result = await client.Account.GetTodayTradeDiariesAsync(oddLotType, cashCreditType, date);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomAccountDepositQueryType.Normal)]
		public async Task GetDepositsAsync(KiwoomAccountDepositQueryType queryType)
		{
			var result = await client.Account.GetDepositsAsync(queryType);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("2025-08-01", "2025-08-04")]
		public async Task GetDailyEstimatedDepositAssetsAsync(string _startDate, string _endDate)
		{
			DateTime startDate = DateTime.Parse(_startDate);
			DateTime endDate = DateTime.Parse(_endDate);
			var result = await client.Account.GetDailyEstimatedDepositAssetsAsync(startDate, endDate);

			Assert.That(result.ReturnCode, Is.EqualTo(0).Or.EqualTo(20));
		}

		[TestCase(false)]
		public async Task GetEstimatedDepositAssetAsync(bool isExcludeDelisted)
		{
			var result = await client.Account.GetEstimatedDepositAssetAsync(isExcludeDelisted);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(false, KiwoomAccountStockExchangeType.Unified)]
		public async Task GetEvaluationsAsync(bool isExcludeDelisted, KiwoomAccountStockExchangeType stockExchangeType)
		{
			var result = await client.Account.GetEvaluationsAsync(isExcludeDelisted, stockExchangeType);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomAccountStockExchangeType.Unified)]
		public async Task GetContractBalancesAsync(KiwoomAccountStockExchangeType stockExchangeType)
		{
			var result = await client.Account.GetContractBalancesAsync(stockExchangeType);

			Assert.That(result.ReturnCode, Is.EqualTo(0).Or.EqualTo(20));
		}

		[TestCase(KiwoomAccountOrderQueryType.OrderSequence, KiwoomAccountStockBondType.All, KiwoomAccountTradeType.All, KiwoomAccountDomesticStockExchangeType.All)]
		[TestCase(KiwoomAccountOrderQueryType.OrderSequence, KiwoomAccountStockBondType.All, KiwoomAccountTradeType.All, KiwoomAccountDomesticStockExchangeType.All, "2025-08-01")]
		public async Task GetOrderContractDetailsAsync(KiwoomAccountOrderQueryType queryType, KiwoomAccountStockBondType stockBondType, KiwoomAccountTradeType tradeType, KiwoomAccountDomesticStockExchangeType domesticStockExchangeType, string _date = "2025-01-01", string stockCode = "", string fromOrderId = "")
		{
			DateTime date = DateTime.Parse(_date);
			var result = await client.Account.GetOrderContractDetailsAsync(queryType, stockBondType, tradeType, domesticStockExchangeType, date, stockCode, fromOrderId);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase()]
		[TestCase("00000000")]
		public async Task GetNextDaySettlementsAsync(string startDealCodeId = "")
		{
			var result = await client.Account.GetNextDaySettlementsAsync(startDealCodeId);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomAccountOrderContractQueryType.All, KiwoomAccountStockBondType.All, KiwoomAccountTradeType.All, KiwoomAccountDomesticStockExchangeType.All, KiwoomAccountMarketType.All)]
		[TestCase(KiwoomAccountOrderContractQueryType.All, KiwoomAccountStockBondType.All, KiwoomAccountTradeType.All, KiwoomAccountDomesticStockExchangeType.All, KiwoomAccountMarketType.All, "2025-08-01")]
		public async Task GetOrderContractsAsync(KiwoomAccountOrderContractQueryType queryType, KiwoomAccountStockBondType stockBondType, KiwoomAccountTradeType tradeType, KiwoomAccountDomesticStockExchangeType domesticStockExchangeType, KiwoomAccountMarketType marketType, string _date = "2025-01-01", string stockCode = "", string fromOrderId = "")
		{
			DateTime date = DateTime.Parse(_date);
			var result = await client.Account.GetOrderContractsAsync(queryType, stockBondType, tradeType, domesticStockExchangeType, marketType, date, stockCode, fromOrderId);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}


		[TestCase("005930", KiwoomAccountTradeType.All, "12345")]
		[TestCase("005930", KiwoomAccountTradeType.All, "12345", "2")]
		public async Task GetMarginOrderAmountsAsync(string stockCode, KiwoomAccountTradeType tradeType, string _buyPrice, string _buyQuantity = "0", string _inOutAmount = "0", string _expectedBuyPrice = "0")
		{
			decimal buyPrice = decimal.Parse(_buyPrice);
			decimal buyQuantity = decimal.Parse(_buyQuantity);
			decimal inOutAmount = decimal.Parse(_inOutAmount);
			decimal expectedBuyPrice = decimal.Parse(_expectedBuyPrice);
			var result = await client.Account.GetMarginOrderAmountsAsync(stockCode, tradeType, buyPrice, buyQuantity, inOutAmount, expectedBuyPrice);

			Assert.That(result.ReturnCode, Is.EqualTo(0).Or.EqualTo(20));
		}

		[TestCase("005930")]
		[TestCase("005930", "12345")]
		public async Task GetMarginOrdersAsync(string stockCode, string _buyPrice = "0")
		{
			decimal buyPrice = decimal.Parse(_buyPrice);
			var result = await client.Account.GetMarginOrdersAsync(stockCode, buyPrice);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930")]
		[TestCase("005930", "12345")]
		public async Task GetAssuranceMarginOrdersAsync(string stockCode, string _buyPrice = "0")
		{
			decimal buyPrice = decimal.Parse(_buyPrice);
			var result = await client.Account.GetAssuranceMarginOrdersAsync(stockCode, buyPrice);

			Assert.That(result.ReturnCode, Is.EqualTo(0).Or.EqualTo(20));
		}

		[Test]
		public async Task GetMarginDetailsAsync()
		{
			var result = await client.Account.GetMarginDetailsAsync();

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomAccountTransactionType.All, KiwoomAccountGoodsType.All, KiwoomAccountDomesticStockExchangeType.All, "2025-08-01", "2025-08-04")]
		[TestCase(KiwoomAccountTransactionType.All, KiwoomAccountGoodsType.All, KiwoomAccountDomesticStockExchangeType.All, "2025-08-01", "2025-08-04", "005930")]
		public async Task GetConsignmentTradesAsync(KiwoomAccountTransactionType transactionType, KiwoomAccountGoodsType goodsType, KiwoomAccountDomesticStockExchangeType domesticStockExchangeType, string _startDate, string _endDate, string stockCode = "", string currencyCode = "", string foreignStockExchangeCode = "")
		{
			DateTime startDate = DateTime.Parse(_startDate);
			DateTime endDate = DateTime.Parse(_endDate);
			var result = await client.Account.GetConsignmentTradesAsync(transactionType, goodsType, domesticStockExchangeType, startDate, endDate, stockCode, currencyCode, foreignStockExchangeCode);

			Assert.That(result.ReturnCode, Is.EqualTo(0).Or.EqualTo(20));
		}

		[TestCase("2025-08-01", "2025-08-04")]
		public async Task GetDailyProfitRateDetailsAsync(string _startDate, string _endDate)
		{
			DateTime startDate = DateTime.Parse(_startDate);
			DateTime endDate = DateTime.Parse(_endDate);
			var result = await client.Account.GetDailyProfitRateDetailsAsync(startDate, endDate);

			Assert.That(result.ReturnCode, Is.EqualTo(0).Or.EqualTo(20));
		}

		[Test]
		public async Task GetDailyStatusAsync()
		{
			var result = await client.Account.GetDailyStatusAsync();

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomAccountEvaluationBalanceQueryType.Aggregate, KiwoomAccountDomesticStockExchangeType.All)]
		public async Task GetEvaluationBalancesAsync(KiwoomAccountEvaluationBalanceQueryType queryType, KiwoomAccountDomesticStockExchangeType domesticStockExchangeType)
		{
			var result = await client.Account.GetEvaluationBalancesAsync(queryType, domesticStockExchangeType);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}
		#endregion

		#region ShortSale
		[TestCase("005930", "2025-08-01", "2025-08-04")]
		[TestCase("005930", "2025-08-01", "2025-08-04", KiwoomShortSaleTimeType.Period)]
		public async Task GetShortsTransactionsAsync(string stockCode, string _startDate, string _endDate, KiwoomShortSaleTimeType timeType = KiwoomShortSaleTimeType.StartDate)
		{
			DateTime startDate = DateTime.Parse(_startDate);
			DateTime endDate = DateTime.Parse(_endDate);
			var result = await client.ShortSale.GetShortsTransactionsAsync(stockCode, startDate, endDate, timeType);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}
		#endregion

		#region ForeignInstitution
		[TestCase("005930")]
		public async Task GetStockForeignersAsync(string stockCode)
		{
			var result = await client.ForeignInstitution.GetStockForeignersAsync(stockCode);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930")]
		public async Task GetDailyAsync(string stockCode)
		{
			var result = await client.ForeignInstitution.GetDailyAsync(stockCode);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomForeignInstitutionStockExchangeType.Unified, KiwoomForeignInstitutionMarketType.KOSPI, KiwoomForeignInstitutionStockIndustryType.Stock, KiwoomForeignInstitutionAmountQuantityType.Amount, 7)]
		public async Task GetContinuousTradesAsync(KiwoomForeignInstitutionStockExchangeType stockExchangeType, KiwoomForeignInstitutionMarketType marketType, KiwoomForeignInstitutionStockIndustryType stockIndustryType, KiwoomForeignInstitutionAmountQuantityType amountQuantityType, int period = 0, string _startDate = "2025-08-01", string _endDate = "2025-08-04")
		{
			DateTime startDate = DateTime.Parse(_startDate);
			DateTime endDate = DateTime.Parse(_endDate);
			var result = await client.ForeignInstitution.GetContinuousTradesAsync(stockExchangeType, marketType, stockIndustryType, amountQuantityType, period, startDate, endDate);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}
		#endregion

		#region SLB
		[TestCase()]
		[TestCase("2025-08-01")]
		public async Task GetBorrowedTradesAsync(string _startDate = "2025-08-01", string _endDate = "2025-08-04")
		{
			DateTime startDate = DateTime.Parse(_startDate);
			DateTime endDate = DateTime.Parse(_endDate);
			var result = await client.SLB.GetBorrowedTradesAsync(startDate, endDate);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomSecuritiesLendingAndBorrowingMarketType.KOSPI, "2025-08-01")]
		public async Task GetBorrowedTradeTop10Async(KiwoomSecuritiesLendingAndBorrowingMarketType marketType, string _startDate, string _endDate = "2025-08-04")
		{
			DateTime startDate = DateTime.Parse(_startDate);
			DateTime endDate = DateTime.Parse(_endDate);
			var result = await client.SLB.GetBorrowedTradeTop10Async(marketType, startDate, endDate);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930")]
		public async Task GetBorrowedTradesByStockAsync(string stockCode, string _startDate = "2025-08-01", string _endDate = "2025-08-04")
		{
			DateTime startDate = DateTime.Parse(_startDate);
			DateTime endDate = DateTime.Parse(_endDate);
			var result = await client.SLB.GetBorrowedTradesByStockAsync(stockCode, startDate, endDate);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomSecuritiesLendingAndBorrowingMarketType.KOSPI, "2025-08-01")]
		public async Task GetBorrowedTradeHistoriesAsync(KiwoomSecuritiesLendingAndBorrowingMarketType marketType, string _date)
		{
			DateTime date = DateTime.Parse(_date);
			var result = await client.SLB.GetBorrowedTradeHistoriesAsync(marketType, date);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}
		#endregion

		#region Elw
		[TestCase("500001")]
		public async Task GetDailySensitivityIndicesAsync(string stockCode)
		{
			var result = await client.Elw.GetDailySensitivityIndicesAsync(stockCode);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("500001")]
		public async Task GetSensitivityIndeicesAsync(string stockCode)
		{
			var result = await client.Elw.GetSensitivityIndeicesAsync(stockCode);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomElwFluctuationType.SuddenIncrease, KiwoomElwTimeType.Minute, 30, 712, KiwoomElwCompanyCode.All, "005930", KiwoomElwRightType.Call, KiwoomElwCompanyCode.All, false)]
		public async Task GetPriceJumpFluctuationsAsync(KiwoomElwFluctuationType fluctuationType, KiwoomElwTimeType timeType, int timeValue, decimal minVolume, KiwoomElwCompanyCode issuerCompanyCode, string baseAssetCode, KiwoomElwRightType rightType, KiwoomElwCompanyCode lpCode, bool isExcludeEndedElw)
		{
			var result = await client.Elw.GetPriceJumpFluctuationsAsync(fluctuationType, timeType, timeValue, minVolume, issuerCompanyCode, baseAssetCode, rightType, lpCode, isExcludeEndedElw);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomElwCompanyCode.All, 715, KiwoomElwNetTradeType.NetBuy, 30, false)]
		public async Task GetNetTradeTopByTradersAsync(KiwoomElwCompanyCode issuerCompanyCode, decimal minVolume, KiwoomElwNetTradeType tradeType, int period, bool isExcludeEndedElw)
		{
			var result = await client.Elw.GetNetTradeTopByTradersAsync(issuerCompanyCode, minVolume, tradeType, period, isExcludeEndedElw);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930", "2025-08-01")]
		public async Task GetLpHoldingDailyTrendsAsync(string baseAssetCode, string _date)
		{
			DateTime date = DateTime.Parse(_date);
			var result = await client.Elw.GetLpHoldingDailyTrendsAsync(baseAssetCode, date);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomElwCompanyCode.All, "005930", KiwoomElwRightType.Call, KiwoomElwCompanyCode.All, false)]
		public async Task GetDisparityRatesAsync(KiwoomElwCompanyCode issuerCompanyCode, string baseAssetCode, KiwoomElwRightType rightType, KiwoomElwCompanyCode lpCode, bool isExcludeEndedElw)
		{
			var result = await client.Elw.GetDisparityRatesAsync(issuerCompanyCode, baseAssetCode, rightType, lpCode, isExcludeEndedElw);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomElwCompanyCode.All, "005930", KiwoomElwRightType.Call, KiwoomElwCompanyCode.All, KiwoomElwSortType.Volume)]
		public async Task GetConditionSearchsAsync(KiwoomElwCompanyCode issuerCompanyCode, string baseAssetCode, KiwoomElwRightType rightType, KiwoomElwCompanyCode lpCode, KiwoomElwSortType sortType)
		{
			var result = await client.Elw.GetConditionSearchsAsync(issuerCompanyCode, baseAssetCode, rightType, lpCode, sortType);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomElwSortType.Volume, KiwoomElwRightType.Call, false)]
		public async Task GetFluctuationRateRanksAsync(KiwoomElwSortType sortType, KiwoomElwRightType rightType, bool isExcludeEnded)
		{
			var result = await client.Elw.GetFluctuationRateRanksAsync(sortType, rightType, isExcludeEnded);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomElwSortType2.NetBuyTop, KiwoomElwRightType.Call, false)]
		public async Task GetRequestRanksAsync(KiwoomElwSortType2 sortType, KiwoomElwRightType rightType, bool isExcludeEnded)
		{
			var result = await client.Elw.GetRequestRanksAsync(sortType, rightType, isExcludeEnded);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("500001")]
		public async Task GetProximityRatesAsync(string stockCode)
		{
			var result = await client.Elw.GetProximityRatesAsync(stockCode);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("500001")]
		public async Task GetAssetInfoAsync(string stockCode)
		{
			var result = await client.Elw.GetAssetInfoAsync(stockCode);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}
		#endregion

		#region Etf
		[TestCase("152100", "KRX200", KiwoomEtfPeriodType.Week1)]
		public async Task GetProfitRatesAsync(string stockCode, string etfObjectIndexCode, KiwoomEtfPeriodType periodType)
		{
			var result = await client.Etf.GetProfitRatesAsync(stockCode, etfObjectIndexCode, periodType);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("152100")]
		public async Task GetInfoAsync(string stockCode)
		{
			var result = await client.Etf.GetInfoAsync(stockCode);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("152100")]
		public async Task GetDailyTransactionsAsync(string stockCode)
		{
			var result = await client.Etf.GetDailyTransactionsAsync(stockCode);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomEtfTaxType.All, KiwoomEtfNavComparison.All, KiwoomEtfManagementCompany.All, KiwoomEtfTaxationType.All, KiwoomEtfStockExchangeType.KRX)]
		public async Task GetAllMarketPricesAsync(KiwoomEtfTaxType taxType, KiwoomEtfNavComparison navComparison, KiwoomEtfManagementCompany managementCompany, KiwoomEtfTaxationType taxationType, KiwoomEtfStockExchangeType stockExchangeType)
		{
			var result = await client.Etf.GetAllMarketPricesAsync(taxType, navComparison, managementCompany, taxationType, stockExchangeType);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("152100")]
		public async Task GetTimeIntervalTransitionsAsync(string stockCode)
		{
			var result = await client.Etf.GetTimeIntervalTransitionsAsync(stockCode);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("152100")]
		public async Task GetTimeIntervalContractsAsync(string stockCode)
		{
			var result = await client.Etf.GetTimeIntervalContractsAsync(stockCode);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("152100")]
		public async Task GetNetPurchaseQuantitiesAsync(string stockCode)
		{
			var result = await client.Etf.GetNetPurchaseQuantitiesAsync(stockCode);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("152100")]
		public async Task GetNavsAsync(string stockCode)
		{
			var result = await client.Etf.GetNavsAsync(stockCode);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("152100")]
		public async Task GetTimeIntervalTransitions2Async(string stockCode)
		{
			var result = await client.Etf.GetTimeIntervalTransitions2Async(stockCode);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}
		#endregion

		#region StockInfo
		[TestCase("005930", "2025-08-01", KiwoomStockInfoMarginLoanType.Loan)]
		public async Task GetStockInfoAsync(string stockCode, string dateStr, KiwoomStockInfoMarginLoanType marginLoanType)
		{
			var date = DateTime.Parse(dateStr);
			var result = await client.StockInfo.GetStockInfoAsync(stockCode, date, marginLoanType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930")]
		public async Task GetTradeInfoAsync(string stockCode)
		{
			var result = await client.StockInfo.GetTradeInfoAsync(stockCode);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930")]
		public async Task GetStockInfoContractsAsync(string stockCode)
		{
			var result = await client.StockInfo.GetContractsAsync(stockCode);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930", "2025-08-01", KiwoomStockInfoMarginLoanType.Loan)]
		public async Task GetCreditTradeTrendsAsync(string stockCode, string dateStr, KiwoomStockInfoMarginLoanType marginLoanType)
		{
			var date = DateTime.Parse(dateStr);
			var result = await client.StockInfo.GetCreditTradeTrendsAsync(stockCode, date, marginLoanType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930", "2025-08-01")]
		public async Task GetDailyTradeDetailsAsync(string stockCode, string startDateStr)
		{
			var startDate = DateTime.Parse(startDateStr);
			var result = await client.StockInfo.GetDailyTradeDetailsAsync(stockCode, startDate);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomStockInfoMarketType.KOSPI, KiwoomStockInfoNewHighLowType.NewHigh, KiwoomStockInfoHighLowCloseType.HighLow, KiwoomStockInfoStockCondition.All, 0, KiwoomStockInfoCreditCondition.All, true, 30, KiwoomStockInfoStockExchangeType.KRX)]
		public async Task GetLowPricesAsync(KiwoomStockInfoMarketType marketType, KiwoomStockInfoNewHighLowType newHighLowType, KiwoomStockInfoHighLowCloseType highLowCloseType, KiwoomStockInfoStockCondition stockCondition, decimal minVolume, KiwoomStockInfoCreditCondition creditCondition, bool isIncludeUpDown, int period, KiwoomStockInfoStockExchangeType stockExchangeType)
		{
			var result = await client.StockInfo.GetLowPricesAsync(marketType, newHighLowType, highLowCloseType, stockCondition, minVolume, creditCondition, isIncludeUpDown, period, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomStockInfoMarketType.KOSPI, KiwoomStockInfoUpDownType.Rise, KiwoomStockInfoUpDownPriceSortType.StockCode, KiwoomStockInfoStockCondition.All, 0, KiwoomStockInfoCreditCondition.All, KiwoomStockInfoPriceCondition.All, KiwoomStockInfoStockExchangeType.KRX)]
		public async Task GetUpdownPricesAsync(KiwoomStockInfoMarketType marketType, KiwoomStockInfoUpDownType upDownType, KiwoomStockInfoUpDownPriceSortType sortType, KiwoomStockInfoStockCondition stockCondition, decimal minVolume, KiwoomStockInfoCreditCondition creditCondition, KiwoomStockInfoPriceCondition tradeAmountType, KiwoomStockInfoStockExchangeType stockExchangeType)
		{
			var result = await client.StockInfo.GetUpdownPricesAsync(marketType, upDownType, sortType, stockCondition, minVolume, creditCondition, tradeAmountType, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomStockInfoNewHighLowType.NewHigh, 0.05, KiwoomStockInfoMarketType.KOSPI, 0, KiwoomStockInfoStockCondition.All, KiwoomStockInfoCreditCondition.All, KiwoomStockInfoStockExchangeType.KRX)]
		public async Task GetHighLowPriceProximitiesAsync(KiwoomStockInfoNewHighLowType newHighLowType, decimal approachRate, KiwoomStockInfoMarketType marketType, decimal minVolume, KiwoomStockInfoStockCondition stockCondition, KiwoomStockInfoCreditCondition creditCondition, KiwoomStockInfoStockExchangeType stockExchangeType)
		{
			var result = await client.StockInfo.GetHighLowPriceProximitiesAsync(newHighLowType, approachRate, marketType, minVolume, stockCondition, creditCondition, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomStockInfoMarketType.KOSPI, KiwoomStockInfoFluctuationType.SharpRise, KiwoomStockInfoTimeType.MinutesAgo, 30, 0, KiwoomStockInfoStockCondition.All, KiwoomStockInfoCreditCondition.All, KiwoomStockInfoPriceCondition.All, true, KiwoomStockInfoStockExchangeType.KRX)]
		public async Task GetPriceJumpFluctuationsAsync(KiwoomStockInfoMarketType marketType, KiwoomStockInfoFluctuationType fluctuationType, KiwoomStockInfoTimeType timeType, int timeValue, decimal minVolume, KiwoomStockInfoStockCondition stockCondition, KiwoomStockInfoCreditCondition creditCondition, KiwoomStockInfoPriceCondition priceCondition, bool isIncludeUpDown, KiwoomStockInfoStockExchangeType stockExchangeType)
		{
			var result = await client.StockInfo.GetPriceJumpFluctuationsAsync(marketType, fluctuationType, timeType, timeValue, minVolume, stockCondition, creditCondition, priceCondition, isIncludeUpDown, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomStockInfoMarketType.KOSPI, 5, 0, KiwoomStockInfoStockExchangeType.KRX)]
		public async Task GetTradeVolumeUpdatesAsync(KiwoomStockInfoMarketType marketType, int cycleDays, decimal minVolume, KiwoomStockInfoStockExchangeType stockExchangeType)
		{
			var result = await client.StockInfo.GetTradeVolumeUpdatesAsync(marketType, cycleDays, minVolume, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomStockInfoMarketType.KOSPI, 0.1, true, 10, 5, KiwoomStockInfoStockExchangeType.KRX)]
		public async Task GetPriceConcentrationsAsync(KiwoomStockInfoMarketType marketType, decimal propertyConcentrationRate, bool isIncludeCurrentPriceEntry, int propertyCount, int cycleDays, KiwoomStockInfoStockExchangeType stockExchangeType)
		{
			var result = await client.StockInfo.GetPriceConcentrationsAsync(marketType, propertyConcentrationRate, isIncludeCurrentPriceEntry, propertyCount, cycleDays, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomStockInfoPerType.LowPer, KiwoomStockInfoStockExchangeType.KRX)]
		public async Task GetHighLowPersAsync(KiwoomStockInfoPerType perType, KiwoomStockInfoStockExchangeType stockExchangeType)
		{
			var result = await client.StockInfo.GetHighLowPersAsync(perType, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomStockInfoFluctuationSortType.OpenPrice, 0, KiwoomStockInfoMarketType.KOSPI, true, KiwoomStockInfoStockCondition.All, KiwoomStockInfoCreditCondition.All, KiwoomStockInfoPriceCondition.All, KiwoomStockInfoFluctuationCondition.Upper, KiwoomStockInfoStockExchangeType.KRX)]
		public async Task GetOpenPriceCompareFluctuationsAsync(KiwoomStockInfoFluctuationSortType sortType, decimal minVolume, KiwoomStockInfoMarketType marketType, bool isIncludeUpDown, KiwoomStockInfoStockCondition stockCondition, KiwoomStockInfoCreditCondition creditCondition, KiwoomStockInfoPriceCondition tradeAmountCondition, KiwoomStockInfoFluctuationCondition fluctuationCondition, KiwoomStockInfoStockExchangeType stockExchangeType)
		{
			var result = await client.StockInfo.GetOpenPriceCompareFluctuationsAsync(sortType, minVolume, marketType, isIncludeUpDown, stockCondition, creditCondition, tradeAmountCondition, fluctuationCondition, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930", "2025-08-01", "2025-08-15", KiwoomStockInfoQueryDateType.Period, KiwoomStockInfoDayType.Today, 14, KiwoomStockInfoSortType.ClosePriceOrder, "001", KiwoomStockInfoStockExchangeType.KRX)]
		public async Task GetTradeOriginPriceAnalysesAsync(string stockCode, string startDateStr, string endDateStr, KiwoomStockInfoQueryDateType queryDateType, KiwoomStockInfoDayType pointType, int period, KiwoomStockInfoSortType sortType, string memberCode, KiwoomStockInfoStockExchangeType stockExchangeType)
		{
			var startDate = DateTime.Parse(startDateStr);
			var endDate = DateTime.Parse(endDateStr);
			var result = await client.StockInfo.GetTradeOriginPriceAnalysesAsync(stockCode, startDate, endDate, queryDateType, pointType, period, sortType, memberCode, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("001", KiwoomStockInfoMarketType2.KOSPI, 1000, KiwoomStockInfoPriceCondition.All, KiwoomStockInfoStockExchangeType.KRX, "005930")]
		[TestCase("001", KiwoomStockInfoMarketType2.KOSPI, 1000, KiwoomStockInfoPriceCondition.All, KiwoomStockInfoStockExchangeType.KRX, "")]
		public async Task GetTradeOriginMomentTradeVolumesAsync(string memberCode, KiwoomStockInfoMarketType2 marketType, int quantity, KiwoomStockInfoPriceCondition priceCondition, KiwoomStockInfoStockExchangeType stockExchangeType, string stockCode)
		{
			var result = await client.StockInfo.GetTradeOriginMomentTradeVolumesAsync(memberCode, marketType, quantity, priceCondition, stockExchangeType, stockCode);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomStockInfoMarketType.KOSPI, KiwoomStockInfoBeforeMarketType.All, KiwoomStockInfoTriggerType.All, KiwoomStockInfoSkipStockType.Preferred, true, 1000, 10000, true, 1000000, 10000000, KiwoomStockInfoTriggerDirection.All, KiwoomStockInfoStockExchangeType.KRX, "005930")]
		[TestCase(KiwoomStockInfoMarketType.KOSPI, KiwoomStockInfoBeforeMarketType.All, KiwoomStockInfoTriggerType.All, KiwoomStockInfoSkipStockType.Preferred, true, 1000, 10000, true, 1000000, 10000000, KiwoomStockInfoTriggerDirection.All, KiwoomStockInfoStockExchangeType.KRX, "")]
		public async Task GetMotionStocksAsync(KiwoomStockInfoMarketType marketType, KiwoomStockInfoBeforeMarketType beforeMarketType, KiwoomStockInfoTriggerType triggerType, KiwoomStockInfoSkipStockType skipStockType, bool isUseVolumeOption, decimal minTradeQuantity, decimal maxTradeQuantity, bool isUseTransactionAmountOption, decimal minTradeAmount, decimal maxTradeAmount, KiwoomStockInfoTriggerDirection triggerDirection, KiwoomStockInfoStockExchangeType stockExchangeType, string stockCode)
		{
			var result = await client.StockInfo.GetMotionStocksAsync(marketType, beforeMarketType, triggerType, skipStockType, isUseVolumeOption, minTradeQuantity, maxTradeQuantity, isUseTransactionAmountOption, minTradeAmount, maxTradeAmount, triggerDirection, stockExchangeType, stockCode);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930", KiwoomStockInfoDayType2.Today)]
		public async Task GetTodayPreviousTradeQuantitiesAsync(string stockCode, KiwoomStockInfoDayType2 dayType)
		{
			var result = await client.StockInfo.GetTodayPreviousTradeQuantitiesAsync(stockCode, dayType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("2025-08-01", "2025-08-15", KiwoomStockInfoNetTradeType.NetBuy, KiwoomStockInfoMarketType.KOSPI, KiwoomStockInfoInvestorType.Individual, KiwoomStockInfoStockExchangeType.KRX)]
		public async Task GetInvestorDailyTradeStocksAsync(string startDateStr, string endDateStr, KiwoomStockInfoNetTradeType tradeType, KiwoomStockInfoMarketType marketType, KiwoomStockInfoInvestorType investorType, KiwoomStockInfoStockExchangeType stockExchangeType)
		{
			var startDate = DateTime.Parse(startDateStr);
			var endDate = DateTime.Parse(endDateStr);
			var result = await client.StockInfo.GetInvestorDailyTradeStocksAsync(startDate, endDate, tradeType, marketType, investorType, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("2025-08-01", "005930", KiwoomStockInfoAmountQuantityType.Amount, KiwoomStockInfoTradeType.NetBuy, KiwoomStockInfoUnitType.One)]
		public async Task GetStockInvestorInstitutionsAsync(string dateStr, string stockCode, KiwoomStockInfoAmountQuantityType amountQuantityType, KiwoomStockInfoTradeType tradeType, KiwoomStockInfoUnitType unitType)
		{
			var date = DateTime.Parse(dateStr);
			var result = await client.StockInfo.GetStockInvestorInstitutionsAsync(date, stockCode, amountQuantityType, tradeType, unitType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930", "2025-08-01", "2025-08-15", KiwoomStockInfoAmountQuantityType.Amount, KiwoomStockInfoUnitType.One)]
		public async Task GetStockInvestorInstitutionTotalsAsync(string stockCode, string startDateStr, string endDateStr, KiwoomStockInfoAmountQuantityType amountQuantityType, KiwoomStockInfoUnitType unitType)
		{
			var startDate = DateTime.Parse(startDateStr);
			var endDate = DateTime.Parse(endDateStr);
			var result = await client.StockInfo.GetStockInvestorInstitutionTotalsAsync(stockCode, startDate, endDate, amountQuantityType, unitType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930", KiwoomStockInfoDayType2.Today, KiwoomStockInfoTickMinuteType.Tick, "09:30")]
		public async Task GetTodayPreviousContractsAsync(string stockCode, KiwoomStockInfoDayType2 dayType, KiwoomStockInfoTickMinuteType tickMinuteType, string timeStr)
		{
			var time = TimeSpan.Parse(timeStr);
			var result = await client.StockInfo.GetTodayPreviousContractsAsync(stockCode, dayType, tickMinuteType, time);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930")]
		public async Task GetAttentionStocksAsync(string stockCode)
		{
			var result = await client.StockInfo.GetAttentionStocksAsync(stockCode);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomStockInfoMarketType3.KOSPI)]
		public async Task GetListsAsync(KiwoomStockInfoMarketType3 marketType)
		{
			var result = await client.StockInfo.GetListsAsync(marketType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930")]
		public async Task GetListItemAsync(string stockCode)
		{
			var result = await client.StockInfo.GetListItemAsync(stockCode);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomStockInfoMarketType4.KOSPI)]
		public async Task GetMarketCodesAsync(KiwoomStockInfoMarketType4 marketType)
		{
			var result = await client.StockInfo.GetMarketCodesAsync(marketType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[Test]
		public async Task GetMemberCodesAsync()
		{
			var result = await client.StockInfo.GetMemberCodesAsync();
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomStockInfoNetTradeType.NetBuy, KiwoomStockInfoAmountQuantityType.Amount, KiwoomStockInfoMarketType5.KOSPI, KiwoomStockInfoStockExchangeType.KRX)]
		public async Task GetProgramNetPurchaseUpper50Async(KiwoomStockInfoNetTradeType tradeUpperType, KiwoomStockInfoAmountQuantityType amountQuantityType, KiwoomStockInfoMarketType5 marketType, KiwoomStockInfoStockExchangeType stockExchangeType)
		{
			var result = await client.StockInfo.GetProgramNetPurchaseUpper50Async(tradeUpperType, amountQuantityType, marketType, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("2025-08-01", KiwoomStockInfoMarketType5.KOSPI, KiwoomStockInfoStockExchangeType.KRX)]
		public async Task GetProgramTradeStatusAsync(string dateStr, KiwoomStockInfoMarketType5 marketType, KiwoomStockInfoStockExchangeType stockExchangeType)
		{
			var date = DateTime.Parse(dateStr);
			var result = await client.StockInfo.GetProgramTradeStatusAsync(date, marketType, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomStockInfoMarketDealType.KOSPI, KiwoomStockInfoCreditStockGradeType.All, "005930")]
		[TestCase(KiwoomStockInfoMarketDealType.KOSPI, KiwoomStockInfoCreditStockGradeType.A, "")]
		public async Task GetCreditLoanPossibleStocksAsync(KiwoomStockInfoMarketDealType marketDealType, KiwoomStockInfoCreditStockGradeType creditStockGradeType, string stockCode)
		{
			var result = await client.StockInfo.GetCreditLoanPossibleStocksAsync(marketDealType, creditStockGradeType, stockCode);
			Assert.That(result.ReturnCode, Is.EqualTo(0).Or.EqualTo(20));
		}

		[TestCase("005930")]
		public async Task GetCreditAllowYnAsync(string stockCode)
		{
			var result = await client.StockInfo.GetCreditAllowYnAsync(stockCode);
			Assert.That(result.ReturnCode, Is.EqualTo(0).Or.EqualTo(20));
		}
		#endregion

		#region MarketCondition

		[TestCase("005930")]
		public async Task GetOrderBookAsync(string stockCode)
		{
			var result = await client.MarketCondition.GetOrderBookAsync(stockCode);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930")]
		public async Task GetOrderBookListAsync(string stockCode)
		{
			var result = await client.MarketCondition.GetOrderBookListAsync(stockCode);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930")]
		public async Task GetDailyWeeklyMonthlyAsync(string stockCode)
		{
			var result = await client.MarketCondition.GetDailyWeeklyMonthlyAsync(stockCode);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930")]
		public async Task GetHourMinuteAsync(string stockCode)
		{
			var result = await client.MarketCondition.GetHourMinuteAsync(stockCode);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930")]
		public async Task GetQuoteAsync(string stockCode)
		{
			var result = await client.MarketCondition.GetQuoteAsync(stockCode);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930")]
		public async Task GetQuoteListAsync(string stockCode)
		{
			var result = await client.MarketCondition.GetQuoteListAsync(stockCode);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomMarketConditionRightsType.All)]
		[TestCase(KiwoomMarketConditionRightsType.WarrantSecurity)]
		public async Task GetAllMarketQuoteForRightsOfferingsAsync(KiwoomMarketConditionRightsType rightsType)
		{
			var result = await client.MarketCondition.GetAllMarketQuoteForRightsOfferingsAsync(rightsType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomMarketConditionMarketType.KOSPI, KiwoomMarketConditionNetTradeType.NetBuy, KiwoomMarketConditionStockExchangeType.KRX, "2025-08-01", "2025-08-25")]
		public async Task GetDailyInstitutionTradingStocksAsync(KiwoomMarketConditionMarketType marketType, KiwoomMarketConditionNetTradeType tradeType, KiwoomMarketConditionStockExchangeType stockExchangeType, string startDateStr, string endDateStr)
		{
			var startDate = DateTime.Parse(startDateStr);
			var endDate = DateTime.Parse(endDateStr);
			var result = await client.MarketCondition.GetDailyInstitutionTradingStocksAsync(marketType, tradeType, stockExchangeType, startDate, endDate);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930", "2025-08-01", "2025-08-25", KiwoomMarketConditionUnitPriceType.BuyUnitPrice, KiwoomMarketConditionUnitPriceType.SellUnitPrice)]
		public async Task GetStockOriginTradeTrendsAsync(string stockCode, string startDateStr, string endDateStr, KiwoomMarketConditionUnitPriceType institutionEstimatedUnitPriceType, KiwoomMarketConditionUnitPriceType foreignEstimatedUnitPriceType)
		{
			var startDate = DateTime.Parse(startDateStr);
			var endDate = DateTime.Parse(endDateStr);
			var result = await client.MarketCondition.GetStockOriginTradeTrendsAsync(stockCode, startDate, endDate, institutionEstimatedUnitPriceType, foreignEstimatedUnitPriceType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930")]
		public async Task GetHourlyContractStrengthsAsync(string stockCode)
		{
			var result = await client.MarketCondition.GetHourlyContractStrengthsAsync(stockCode);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930")]
		public async Task GetDailyContractStrengthsAsync(string stockCode)
		{
			var result = await client.MarketCondition.GetDailyContractStrengthsAsync(stockCode);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomMarketConditionMarketType.KOSPI, KiwoomMarketConditionAmountQuantityType.Amount, KiwoomMarketConditionInvestorType.Foreign, true, false, KiwoomMarketConditionStockExchangeType.KRX)]
		public async Task GetIntradayInvestorTradingsAsync(KiwoomMarketConditionMarketType marketType, KiwoomMarketConditionAmountQuantityType amountQuantityType, KiwoomMarketConditionInvestorType investorType, bool isForeignAll, bool isSimultaneousNetPurchaseType, KiwoomMarketConditionStockExchangeType stockExchangeType)
		{
			var result = await client.MarketCondition.GetIntradayInvestorTradingsAsync(marketType, amountQuantityType, investorType, isForeignAll, isSimultaneousNetPurchaseType, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomMarketConditionMarketType.KOSPI, KiwoomMarketConditionAmountQuantityType.Amount, KiwoomMarketConditionTradeType.NetBuy, KiwoomMarketConditionStockExchangeType.KRX)]
		public async Task GetIntradayInvestorTradeChartsAsync(KiwoomMarketConditionMarketType marketType, KiwoomMarketConditionAmountQuantityType amountQuantityType, KiwoomMarketConditionTradeType tradeType, KiwoomMarketConditionStockExchangeType stockExchangeType)
		{
			var result = await client.MarketCondition.GetIntradayInvestorTradeChartsAsync(marketType, amountQuantityType, tradeType, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("001", "005930", "2025-08-01", "2025-08-25")]
		public async Task GetSecurityFirmStockTradeTrendsAsync(string memberCompanyCode, string stockCode, string startDateStr, string endDateStr)
		{
			var startDate = DateTime.Parse(startDateStr);
			var endDate = DateTime.Parse(endDateStr);
			var result = await client.MarketCondition.GetSecurityFirmStockTradeTrendsAsync(memberCompanyCode, stockCode, startDate, endDate);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930", "2025-08-25", KiwoomMarketConditionAmountQuantityType2.Quantity)]
		public async Task GetDailyStockPricesAsync(string stockCode, string dateStr, KiwoomMarketConditionAmountQuantityType2 amountQuantityType)
		{
			var date = DateTime.Parse(dateStr);
			var result = await client.MarketCondition.GetDailyStockPricesAsync(stockCode, date, amountQuantityType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930")]
		public async Task GetAfterHoursSinglePriceOrderBookAsync(string stockCode)
		{
			var result = await client.MarketCondition.GetAfterHoursSinglePriceOrderBookAsync(stockCode);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930")]
		public async Task GetAfterHoursSinglePriceOrderBookListAsync(string stockCode)
		{
			var result = await client.MarketCondition.GetAfterHoursSinglePriceOrderBookListAsync(stockCode);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("2025-08-25", KiwoomMarketConditionAmountQuantityType3.Amount1M, KiwoomMarketConditionMarketType.KOSPI, KiwoomMarketConditionTickMinuteType.Tick, KiwoomMarketConditionStockExchangeType.KRX)]
		public async Task GetHourlyProgramTradeTrendsAsync(string dateStr, KiwoomMarketConditionAmountQuantityType3 amountQuantityType, KiwoomMarketConditionMarketType marketType, KiwoomMarketConditionTickMinuteType tickMinuteType, KiwoomMarketConditionStockExchangeType stockExchangeType)
		{
			var date = DateTime.Parse(dateStr);
			var result = await client.MarketCondition.GetHourlyProgramTradeTrendsAsync(date, amountQuantityType, marketType, tickMinuteType, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("2025-08-25", KiwoomMarketConditionStockExchangeType.KRX)]
		public async Task GetProgramArbitrageBalanceTrendsAsync(string dateStr, KiwoomMarketConditionStockExchangeType stockExchangeType)
		{
			var date = DateTime.Parse(dateStr);
			var result = await client.MarketCondition.GetProgramArbitrageBalanceTrendsAsync(date, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("2025-08-25", KiwoomMarketConditionAmountQuantityType.Amount, KiwoomMarketConditionMarketType2.KOSPI, KiwoomMarketConditionStockExchangeType.KRX)]
		public async Task GetProgramTradeAccumulatedTrendsAsync(string dateStr, KiwoomMarketConditionAmountQuantityType amountQuantityType, KiwoomMarketConditionMarketType2 marketType, KiwoomMarketConditionStockExchangeType stockExchangeType)
		{
			var date = DateTime.Parse(dateStr);
			var result = await client.MarketCondition.GetProgramTradeAccumulatedTrendsAsync(date, amountQuantityType, marketType, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("2025-08-25", "005930", KiwoomMarketConditionAmountQuantityType.Amount)]
		public async Task GetStockTimeProgramTradeTrendsAsync(string dateStr, string stockCode, KiwoomMarketConditionAmountQuantityType amountQuantityType)
		{
			var date = DateTime.Parse(dateStr);
			var result = await client.MarketCondition.GetStockTimeProgramTradeTrendsAsync(date, stockCode, amountQuantityType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("2025-08-25", KiwoomMarketConditionAmountQuantityType3.Amount1M, KiwoomMarketConditionMarketType.KOSPI, KiwoomMarketConditionTickMinuteType.Minute, KiwoomMarketConditionStockExchangeType.KRX)]
		public async Task GetDailyProgramTradeTrendsAsync(string dateStr, KiwoomMarketConditionAmountQuantityType3 amountQuantityType, KiwoomMarketConditionMarketType marketType, KiwoomMarketConditionTickMinuteType tickMinuteType, KiwoomMarketConditionStockExchangeType stockExchangeType)
		{
			var date = DateTime.Parse(dateStr);
			var result = await client.MarketCondition.GetDailyProgramTradeTrendsAsync(date, amountQuantityType, marketType, tickMinuteType, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("2025-08-25", "005930", KiwoomMarketConditionAmountQuantityType.Quantity)]
		public async Task GetStockDailyProgramTradeTrendsAsync(string dateStr, string stockCode, KiwoomMarketConditionAmountQuantityType amountQuantityType)
		{
			var date = DateTime.Parse(dateStr);
			var result = await client.MarketCondition.GetStockDailyProgramTradeTrendsAsync(date, stockCode, amountQuantityType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		#endregion

		#region RankingInfo

		[TestCase(KiwoomRankingInfoMarketType.KOSPI, KiwoomRankingInfoSortType.NetBuyQuantity, 0, KiwoomRankingInfoStockCondition.All, KiwoomRankingInfoCreditCondition.All, KiwoomRankingInfoStockExchangeType.KRX)]
		public async Task GetBidRequestUppersAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoSortType sortType, decimal minVolume, KiwoomRankingInfoStockCondition stockCondition, KiwoomRankingInfoCreditCondition creditCondition, KiwoomRankingInfoStockExchangeType stockExchangeType)
		{
			var result = await client.Ranking.GetBidRequestUppersAsync(marketType, sortType, minVolume, stockCondition, creditCondition, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomRankingInfoMarketType.KOSDAQ, KiwoomRankingInfoTradeType.BuyQuantity, KiwoomRankingInfoSuddenIncreaseSortType.SuddenIncreaseRate, 1000, KiwoomRankingInfoStockCondition.ExcludeManaged, KiwoomRankingInfoStockExchangeType.KRX, 10)]
		public async Task GetBidRequestSuddenIncreasesAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoTradeType tradeType, KiwoomRankingInfoSuddenIncreaseSortType sortType, decimal minVolume, KiwoomRankingInfoStockCondition stockCondition, KiwoomRankingInfoStockExchangeType stockExchangeType, int timeMinute)
		{
			var result = await client.Ranking.GetBidRequestSuddenIncreasesAsync(marketType, tradeType, sortType, minVolume, stockCondition, stockExchangeType, timeMinute);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomRankingInfoMarketType.KOSPI, KiwoomRankingInfoRatioType.BuyToSellRatio, 5000, KiwoomRankingInfoStockCondition.All, KiwoomRankingInfoStockExchangeType.KRX, 15)]
		public async Task GetRequestRateSuddenIncreasesAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoRatioType ratioType, decimal minVolume, KiwoomRankingInfoStockCondition stockCondition, KiwoomRankingInfoStockExchangeType stockExchangeType, int timeMinute)
		{
			var result = await client.Ranking.GetRequestRateSuddenIncreasesAsync(marketType, ratioType, minVolume, stockCondition, stockExchangeType, timeMinute);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomRankingInfoMarketType.KOSDAQ, KiwoomRankingInfoSuddenIncreaseSortType.SuddenIncreaseAmount, KiwoomRankingInfoTimeType.Minute, 10000, KiwoomRankingInfoStockCondition.OnlyKOSPI100, KiwoomRankingInfoPriceType.Over1K, KiwoomRankingInfoStockExchangeType.KRX, 30)]
		public async Task GetTradedQuantitySuddenIncreasesAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoSuddenIncreaseSortType sortType, KiwoomRankingInfoTimeType timeType, decimal minVolume, KiwoomRankingInfoStockCondition stockCondition, KiwoomRankingInfoPriceType priceType, KiwoomRankingInfoStockExchangeType stockExchangeType, int timeMinute)
		{
			var result = await client.Ranking.GetTradedQuantitySuddenIncreasesAsync(marketType, sortType, timeType, minVolume, stockCondition, priceType, stockExchangeType, timeMinute);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomRankingInfoMarketType.KOSPI, KiwoomRankingInfoFluctuationSortType.IncreaseRate, 50000, KiwoomRankingInfoStockCondition.ExcludePreferredStock, KiwoomRankingInfoCreditCondition.CreditA, true, KiwoomRankingInfoPriceCondition.Over1K, 50_000_000, KiwoomRankingInfoStockExchangeType.KRX)]
		public async Task GetPreviousDayFluctuationRateUppersAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoFluctuationSortType sortType, decimal minVolume, KiwoomRankingInfoStockCondition stockCondition, KiwoomRankingInfoCreditCondition creditCondition, bool isIncludeUpDown, KiwoomRankingInfoPriceCondition priceCondition, decimal minTransactionAmount, KiwoomRankingInfoStockExchangeType stockExchangeType)
		{
			var result = await client.Ranking.GetPreviousDayFluctuationRateUppersAsync(marketType, sortType, minVolume, stockCondition, creditCondition, isIncludeUpDown, priceCondition, minTransactionAmount, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomRankingInfoMarketType.KOSDAQ, KiwoomRankingInfoContractFluctuationSortType.IncreaseAmount, 100_000, KiwoomRankingInfoStockCondition.All, KiwoomRankingInfoCreditCondition.All, KiwoomRankingInfoPriceCondition.Range1KTo2K, KiwoomRankingInfoStockExchangeType.KRX)]
		public async Task GetExpectedContractFluctuationRateUppersAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoContractFluctuationSortType sortType, decimal minVolume, KiwoomRankingInfoStockCondition stockCondition, KiwoomRankingInfoCreditCondition creditCondition, KiwoomRankingInfoPriceCondition priceCondition, KiwoomRankingInfoStockExchangeType stockExchangeType)
		{
			var result = await client.Ranking.GetExpectedContractFluctuationRateUppersAsync(marketType, sortType, minVolume, stockCondition, creditCondition, priceCondition, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomRankingInfoMarketType.KOSPI, KiwoomRankingInfoTradeQuantitySortType.Volume, KiwoomRankingInfoStockCondition.ExcludeManagedAndPreferred, KiwoomRankingInfoCreditCondition.CreditB, 150_000, KiwoomRankingInfoPriceCondition2.Range2KTo5K, 100_000_000, KiwoomRankingInfoMarketOpenType.DuringMarket, KiwoomRankingInfoStockExchangeType.KRX)]
		public async Task GetTodayTradeQuantityUppersAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoTradeQuantitySortType sortType, KiwoomRankingInfoStockCondition stockCondition, KiwoomRankingInfoCreditCondition creditCondition, decimal minVolume, KiwoomRankingInfoPriceCondition2 priceCondition, decimal minTransactionAmount, KiwoomRankingInfoMarketOpenType marketOpenType, KiwoomRankingInfoStockExchangeType stockExchangeType)
		{
			var result = await client.Ranking.GetTodayTradeQuantityUppersAsync(marketType, sortType, stockCondition, creditCondition, minVolume, priceCondition, minTransactionAmount, marketOpenType, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomRankingInfoMarketType.KOSDAQ, KiwoomRankingInfoPreviousTradeQuantityQueryType.Top100ByYesterdayVolume, KiwoomRankingInfoStockExchangeType.KRX, 1, 50)]
		public async Task GetPreviousTradeQuantityUppersAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoPreviousTradeQuantityQueryType queryType, KiwoomRankingInfoStockExchangeType stockExchangeType, int startRank, int endRank)
		{
			var result = await client.Ranking.GetPreviousTradeQuantityUppersAsync(marketType, queryType, stockExchangeType, startRank, endRank);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomRankingInfoMarketType.KOSPI, false, KiwoomRankingInfoStockExchangeType.KRX)]
		public async Task GetTradePriceUppersAsync(KiwoomRankingInfoMarketType marketType, bool isIncludeManagedStock, KiwoomRankingInfoStockExchangeType stockExchangeType)
		{
			var result = await client.Ranking.GetTradePriceUppersAsync(marketType, isIncludeManagedStock, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomRankingInfoMarketType.KOSDAQ, 200_000, KiwoomRankingInfoStockCondition.OnlyKOSPI50, true, KiwoomRankingInfoCreditCondition.CreditC, KiwoomRankingInfoStockExchangeType.KRX)]
		public async Task GetCreditRateUppersAsync(KiwoomRankingInfoMarketType marketType, decimal minVolume, KiwoomRankingInfoStockCondition stockCondition, bool isIncludeUpDown, KiwoomRankingInfoCreditCondition creditCondition, KiwoomRankingInfoStockExchangeType stockExchangeType)
		{
			var result = await client.Ranking.GetCreditRateUppersAsync(marketType, minVolume, stockCondition, isIncludeUpDown, creditCondition, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomRankingInfoMarketType.KOSPI, KiwoomRankingInfoNetTradeType.NetBuy, KiwoomRankingInfoStockExchangeType.KRX, 5)]
		public async Task GetForeignTradePerPeriodUppersAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoNetTradeType tradeType, KiwoomRankingInfoStockExchangeType stockExchangeType, int period)
		{
			var result = await client.Ranking.GetForeignTradePerPeriodUppersAsync(marketType, tradeType, stockExchangeType, period);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomRankingInfoMarketType.KOSDAQ, KiwoomRankingInfoContinuousNetTradeType.ContinuousNetBuy, KiwoomRankingInfoStockExchangeType.KRX, 3)]
		public async Task GetForeignContinuousNetTradeUppersAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoContinuousNetTradeType tradeType, KiwoomRankingInfoStockExchangeType stockExchangeType, int period)
		{
			var result = await client.Ranking.GetForeignContinuousNetTradeUppersAsync(marketType, tradeType, stockExchangeType, period);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomRankingInfoMarketType.KOSPI, KiwoomRankingInfoStockExchangeType.KRX, 7)]
		public async Task GetForeignLimitExhaustionRateIncreasesAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoStockExchangeType stockExchangeType, int period)
		{
			var result = await client.Ranking.GetForeignLimitExhaustionRateIncreasesAsync(marketType, stockExchangeType, period);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomRankingInfoMarketType.KOSDAQ, KiwoomRankingInfoForeignWicketTradeType.NetBuy, KiwoomRankingInfoAmountQuantityType.Amount, KiwoomRankingInfoStockExchangeType.KRX, 10)]
		public async Task GetForeignWicketTradeUppersAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoForeignWicketTradeType tradeType, KiwoomRankingInfoAmountQuantityType sortType, KiwoomRankingInfoStockExchangeType stockExchangeType, int period)
		{
			var result = await client.Ranking.GetForeignWicketTradeUppersAsync(marketType, tradeType, sortType, stockExchangeType, period);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomRankingInfoSecuritiesRankQueryType.NetSellRankSort, "005930", "2025-08-01", "2025-08-25", 5)]
		public async Task GetStockSecuritiesRanksAsync(KiwoomRankingInfoSecuritiesRankQueryType queryType, string stockCode, string startDateStr, string endDateStr, int period)
		{
			var startDate = DateTime.Parse(startDateStr);
			var endDate = DateTime.Parse(endDateStr);
			var result = await client.Ranking.GetStockSecuritiesRanksAsync(queryType, stockCode, startDate, endDate, period);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(300_000, KiwoomRankingInfoNetTradeType2.NetBuy, KiwoomRankingInfoStockExchangeType.KRX, "001", 3)]
		public async Task GetSecuritiesTradeUppersAsync(decimal minVolume, KiwoomRankingInfoNetTradeType2 tradeType, KiwoomRankingInfoStockExchangeType stockExchangeType, string memberCompanyCode, int period)
		{
			var result = await client.Ranking.GetSecuritiesTradeUppersAsync(minVolume, tradeType, stockExchangeType, memberCompanyCode, period);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930")]
		public async Task GetTodayMainTradeOriginsAsync(string stockCode)
		{
			var result = await client.Ranking.GetTodayMainTradeOriginsAsync(stockCode);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomRankingInfoTradeOriginRankQueryDateType.ByPeriod, KiwoomRankingInfoDayType.Today, KiwoomRankingInfoTradeOriginRankSortType.ByClosingPrice, "005930", "2025-08-01", "2025-08-25", 5)]
		[TestCase(KiwoomRankingInfoTradeOriginRankQueryDateType.ByStartAndEndDate, KiwoomRankingInfoDayType.PreviousDay, KiwoomRankingInfoTradeOriginRankSortType.ByDate, "005930", "2025-08-01", "2025-08-25", null)]
		public async Task GetNetPurchaseTradeOriginRanksAsync(KiwoomRankingInfoTradeOriginRankQueryDateType queryDateType, KiwoomRankingInfoDayType pointType, KiwoomRankingInfoTradeOriginRankSortType sortBase, string stockCode, string startDateStr, string endDateStr, int? period)
		{
			DateTime? startDate = string.IsNullOrEmpty(startDateStr) ? null : DateTime.Parse(startDateStr);
			DateTime? endDate = string.IsNullOrEmpty(endDateStr) ? null : DateTime.Parse(endDateStr);
			var result = await client.Ranking.GetNetPurchaseTradeOriginRanksAsync(queryDateType, pointType, sortBase, stockCode, startDate, endDate, period);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930")]
		public async Task GetTodayUpperSecessionOriginsAsync(string stockCode)
		{
			var result = await client.Ranking.GetTodayUpperSecessionOriginsAsync(stockCode);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomRankingInfoMarketType.KOSPI, KiwoomRankingInfoNetTradeType2.NetBuy, KiwoomRankingInfoEqualNetTradeRankSortType.Amount, KiwoomRankingInfoUnitType.One, KiwoomRankingInfoStockExchangeType.KRX, "2025-08-01", "2025-08-25")]
		[TestCase(KiwoomRankingInfoMarketType.KOSDAQ, KiwoomRankingInfoNetTradeType2.NetSell, KiwoomRankingInfoEqualNetTradeRankSortType.Quantity, KiwoomRankingInfoUnitType.Thousand, KiwoomRankingInfoStockExchangeType.KRX, "2025-08-10", "2025-08-25")]
		public async Task GetEqualNetTradeRanksAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoNetTradeType2 tradeType, KiwoomRankingInfoEqualNetTradeRankSortType sortType, KiwoomRankingInfoUnitType unitType, KiwoomRankingInfoStockExchangeType stockExchangeType, string startDateStr, string endDateStr)
		{
			var startDate = DateTime.Parse(startDateStr);
			DateTime? endDate = string.IsNullOrEmpty(endDateStr) ? null : DateTime.Parse(endDateStr);
			var result = await client.Ranking.GetEqualNetTradeRanksAsync(marketType, tradeType, sortType, unitType, stockExchangeType, startDate, endDate);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomRankingInfoMarketType.KOSPI, KiwoomRankingInfoNetTradeType2.NetBuy, KiwoomRankingInfoInstitutionType.ForeignCompany)]
		public async Task GetOpenMarketInvestorTradeUppersAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoNetTradeType2 tradeType, KiwoomRankingInfoInstitutionType institutionType)
		{
			var result = await client.Ranking.GetOpenMarketInvestorTradeUppersAsync(marketType, tradeType, institutionType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomRankingInfoMarketType.KOSDAQ, KiwoomRankingInfoFluctuationSortType.DecreaseRate, KiwoomRankingInfoStockCondition.OnlyKOSPI30, 500_000, KiwoomRankingInfoCreditCondition.CreditD, 300_000_000)]
		public async Task GetOvertimeSinglePriceFluctuationRateRanksAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoFluctuationSortType sortType, KiwoomRankingInfoStockCondition stockCondition, decimal minVolume, KiwoomRankingInfoCreditCondition creditCondition, decimal minTransactionAmount)
		{
			var result = await client.Ranking.GetOvertimeSinglePriceFluctuationRateRanksAsync(marketType, sortType, stockCondition, minVolume, creditCondition, minTransactionAmount);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomRankingInfoMarketType.KOSPI, KiwoomRankingInfoAmountQuantityType.Quantity, true, KiwoomRankingInfoStockExchangeType.KRX, "2025-08-25")]
		[TestCase(KiwoomRankingInfoMarketType.KOSDAQ, KiwoomRankingInfoAmountQuantityType.Amount, false, KiwoomRankingInfoStockExchangeType.KRX, "2025-08-25")]
		public async Task GetForeignInstitutionTradeUppersAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoAmountQuantityType amountQuantityType, bool isIncludeQueryDate, KiwoomRankingInfoStockExchangeType stockExchangeType, string dateStr)
		{
			DateTime? date = string.IsNullOrEmpty(dateStr) ? null : DateTime.Parse(dateStr);
			var result = await client.Ranking.GetForeignInstitutionTradeUppersAsync(marketType, amountQuantityType, isIncludeQueryDate, stockExchangeType, date);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		#endregion

		#region Sector

		[TestCase("005930")]
		public async Task GetStockProgramTradingInfoAsync(string stockCode)
		{
			var result = await client.Sector.GetStockProgramTradingInfoAsync(stockCode);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomSectorMarketType.KOSPI, KiwoomSectorAmountQuantityType.Amount, KiwoomSectorStockExchangeType.KRX, "2025-08-25")]
		[TestCase(KiwoomSectorMarketType.KOSDAQ, KiwoomSectorAmountQuantityType.Quantity, KiwoomSectorStockExchangeType.KRX, "2025-08-25")]
		public async Task GetIndustryNetPurchasesAsync(KiwoomSectorMarketType marketType, KiwoomSectorAmountQuantityType amountQuantityType, KiwoomSectorStockExchangeType stockExchangeType, string dateStr)
		{
			DateTime? date = string.IsNullOrEmpty(dateStr) ? null : DateTime.Parse(dateStr);
			var result = await client.Sector.GetIndustryNetPurchasesAsync(marketType, amountQuantityType, stockExchangeType, date);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomSectorMarketType.KOSPI, KiwoomSectorIndustryCode.CompositeKOSPI)]
		[TestCase(KiwoomSectorMarketType.KOSDAQ, KiwoomSectorIndustryCode.CompositeKOSDAQ)]
		public async Task GetIndustryCurrentPricesAsync(KiwoomSectorMarketType marketType, KiwoomSectorIndustryCode industryCode)
		{
			var result = await client.Sector.GetIndustryCurrentPricesAsync(marketType, industryCode);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomSectorMarketType.KOSPI200, KiwoomSectorIndustryCode.KOSPI200, KiwoomSectorStockExchangeType.KRX)]
		public async Task GetIndustryStockPricesAsync(KiwoomSectorMarketType marketType, KiwoomSectorIndustryCode industryCode, KiwoomSectorStockExchangeType stockExchangeType)
		{
			var result = await client.Sector.GetIndustryStockPricesAsync(marketType, industryCode, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomSectorMarketType2.KOSPI)]
		[TestCase(KiwoomSectorMarketType2.KOSDAQ)]
		public async Task GetAllIndustryIndicesAsync(KiwoomSectorMarketType2 marketType)
		{
			var result = await client.Sector.GetAllIndustryIndicesAsync(marketType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomSectorMarketType.KOSPI, KiwoomSectorIndustryCode.LargeCap)]
		[TestCase(KiwoomSectorMarketType.KOSDAQ, KiwoomSectorIndustryCode.MidCap)]
		public async Task GetDailyIndustryPricesAsync(KiwoomSectorMarketType marketType, KiwoomSectorIndustryCode industryCode)
		{
			var result = await client.Sector.GetDailyIndustryPricesAsync(marketType, industryCode);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		#endregion

		#region Theme

		[TestCase(KiwoomThemeQueryType.All, 1, KiwoomThemeFluctuationProfitType.TopPeriodProfitRate, KiwoomThemeStockExchangeType.KRX, "", "")]
		[TestCase(KiwoomThemeQueryType.Stock, 5, KiwoomThemeFluctuationProfitType.TopFluctuationRate, KiwoomThemeStockExchangeType.KRX, "005930", "")]
		[TestCase(KiwoomThemeQueryType.Theme, 3, KiwoomThemeFluctuationProfitType.BottomPeriodProfitRate, KiwoomThemeStockExchangeType.KRX, "", "AI")]
		public async Task GetGroupsAsync(KiwoomThemeQueryType queryType, int daysBefore, KiwoomThemeFluctuationProfitType fluctuationProfitType, KiwoomThemeStockExchangeType stockExchangeType, string stockCode, string themeName)
		{
			var result = await client.Theme.GetGroupsAsync(queryType, daysBefore, fluctuationProfitType, stockExchangeType, stockCode, themeName);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("001", KiwoomThemeStockExchangeType.KRX, 1)]
		[TestCase("002", KiwoomThemeStockExchangeType.KRX, 7)]
		public async Task GetComponentStocksAsync(string themeGroupCode, KiwoomThemeStockExchangeType stockExchangeType, int daysBefore)
		{
			var result = await client.Theme.GetComponentStocksAsync(themeGroupCode, stockExchangeType, daysBefore);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		#endregion

	}
}