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
using KiwoomRestApi.Net.Enums.Industry;
using KiwoomRestApi.Net.Enums.SecuritiesLending;
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
		[TestCase("2025-08-01", "005930", KiwoomChartAmountQuantityType.Amount, KiwoomChartTransactionType.Buy, KiwoomChartUnitType.One)]
		public async Task GetStockInvestorInstitutionChartsAsync(string _date, string stockCode, KiwoomChartAmountQuantityType amountQuantityType, KiwoomChartTransactionType tradeType, KiwoomChartUnitType unitType)
		{
			DateTime date = DateTime.Parse(_date);
			var result = await client.Chart.GetStockInvestorInstitutionChartsAsync(date, stockCode, amountQuantityType, tradeType, unitType);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomChartMarketType.Kospi, KiwoomChartAmountQuantityType.Amount, KiwoomChartTransactionType.Buy, "005930")]
		public async Task GetIntradayInvestorTradeChartsAsync(KiwoomChartMarketType marketType, KiwoomChartAmountQuantityType amountQuantityType, KiwoomChartTransactionType tradeType, string stockCode)
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

		[TestCase(KiwoomChartIndustryCode.KospiComposite, 100)]
		public async Task GetIndustryTickChartsAsync(KiwoomChartIndustryCode industryCode, int tickCount)
		{
			var result = await client.Chart.GetIndustryTickChartsAsync(industryCode, tickCount);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomChartIndustryCode.KospiComposite, 100)]
		public async Task GetIndustryMinuteChartsAsync(KiwoomChartIndustryCode industryCode, int tickCount)
		{
			var result = await client.Chart.GetIndustryMinuteChartsAsync(industryCode, tickCount);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomChartIndustryCode.KospiComposite, "2025-08-01")]
		public async Task GetIndustryDailyChartsAsync(KiwoomChartIndustryCode industryCode, string _date)
		{
			DateTime date = DateTime.Parse(_date);
			var result = await client.Chart.GetIndustryDailyChartsAsync(industryCode, date);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomChartIndustryCode.KospiComposite, "2025-08-01")]
		public async Task GetIndustryWeeklyChartsAsync(KiwoomChartIndustryCode industryCode, string _date)
		{
			DateTime date = DateTime.Parse(_date);
			var result = await client.Chart.GetIndustryWeeklyChartsAsync(industryCode, date);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomChartIndustryCode.KospiComposite, "2025-08-01")]
		public async Task GetIndustryMonthlyChartsAsync(KiwoomChartIndustryCode industryCode, string _date)
		{
			DateTime date = DateTime.Parse(_date);
			var result = await client.Chart.GetIndustryMonthlyChartsAsync(industryCode, date);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomChartIndustryCode.KospiComposite, "2025-08-01")]
		public async Task GetIndustryYearlyChartsAsync(KiwoomChartIndustryCode industryCode, string _date)
		{
			DateTime date = DateTime.Parse(_date);
			var result = await client.Chart.GetIndustryYearlyChartsAsync(industryCode, date);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}
		#endregion

		#region CreditOrder
		[TestCase(KiwoomCreditOrderDomesticStockExchangeType.Krx, "005930", 100.0, KiwoomCreditOrderTransactionType.Normal, 50000.0)]
		public async Task GetCreditOrderBuyAsync(KiwoomCreditOrderDomesticStockExchangeType domesticStockExchangeType, string stockCode, decimal orderQuantity, KiwoomCreditOrderTransactionType tradeType, decimal? orderPrice)
		{
			var result = await client.CreditOrder.PlaceBuyOrderAsync(domesticStockExchangeType, stockCode, orderQuantity, tradeType, orderPrice);

			Assert.That(result.ReturnCode, Is.EqualTo(0).Or.EqualTo(20));
		}

		[TestCase(KiwoomCreditOrderDomesticStockExchangeType.Krx, "005930", 100.0, KiwoomCreditOrderTransactionType.Normal, KiwoomCreditOrderCreditTransactionType.Loan, 50000.0)]
		public async Task GetCreditOrderSellAsync(KiwoomCreditOrderDomesticStockExchangeType domesticStockExchangeType, string stockCode, decimal orderQuantity, KiwoomCreditOrderTransactionType tradeType, KiwoomCreditOrderCreditTransactionType dealType, decimal? orderPrice)
		{
			var result = await client.CreditOrder.PlaceSellOrderAsync(domesticStockExchangeType, stockCode, orderQuantity, tradeType, dealType, orderPrice);

			Assert.That(result.ReturnCode, Is.EqualTo(0).Or.EqualTo(20));
		}

		[TestCase(KiwoomCreditOrderDomesticStockExchangeType.Krx, "12345", "005930", 50.0, 51000.0)]
		public async Task GetCreditOrderModifyOrderAsync(KiwoomCreditOrderDomesticStockExchangeType domesticStockExchangeType, string originalOrderId, string stockCode, decimal modifyQuantity, decimal modifyPrice)
		{
			var result = await client.CreditOrder.ModifyOrderAsync(domesticStockExchangeType, originalOrderId, stockCode, modifyQuantity, modifyPrice);

			Assert.That(result.ReturnCode, Is.EqualTo(0).Or.EqualTo(20));
		}

		[TestCase(KiwoomCreditOrderDomesticStockExchangeType.Krx, "12345", "005930", 25.0)]
		public async Task GetCreditOrderCancellationAsync(KiwoomCreditOrderDomesticStockExchangeType domesticStockExchangeType, string originalOrderId, string stockCode, decimal cancelQuantity)
		{
			var result = await client.CreditOrder.CancelOrderAsync(domesticStockExchangeType, originalOrderId, stockCode, cancelQuantity);

			Assert.That(result.ReturnCode, Is.EqualTo(0).Or.EqualTo(20));
		}
		#endregion

		#region Order
		[TestCase(KiwoomOrderType.Buy, KiwoomOrderDomesticStockExchangeType.Krx, "005930", 100.0, KiwoomOrderTransactionType.Normal, 50000.0)]
		public async Task PlaceOrderAsync(KiwoomOrderType orderType, KiwoomOrderDomesticStockExchangeType domesticStockExchangeType, string stockCode, decimal orderQuantity, KiwoomOrderTransactionType tradeType, decimal? orderPrice)
		{
			var result = await client.Order.PlaceOrderAsync(orderType, domesticStockExchangeType, stockCode, orderQuantity, tradeType, orderPrice);

			Assert.That(result.ReturnCode, Is.EqualTo(0).Or.EqualTo(20));
		}

		[TestCase(KiwoomOrderDomesticStockExchangeType.Krx, "12345", "005930", 50.0, 51000.0)]
		public async Task ModifyOrderAsync(KiwoomOrderDomesticStockExchangeType domesticStockExchangeType, string originalOrderId, string stockCode, decimal modifyQuantity, decimal modifyPrice)
		{
			var result = await client.Order.ModifyOrderAsync(domesticStockExchangeType, originalOrderId, stockCode, modifyQuantity, modifyPrice);

			Assert.That(result.ReturnCode, Is.EqualTo(0).Or.EqualTo(20));
		}

		[TestCase(KiwoomOrderDomesticStockExchangeType.Krx, "12345", "005930", 25.0)]
		public async Task CancelOrderAsync(KiwoomOrderDomesticStockExchangeType domesticStockExchangeType, string originalOrderId, string stockCode, decimal cancelQuantity)
		{
			var result = await client.Order.CancelOrderAsync(domesticStockExchangeType, originalOrderId, stockCode, cancelQuantity);

			Assert.That(result.ReturnCode, Is.EqualTo(0).Or.EqualTo(20));
		}
		#endregion

		#region Account
		[TestCase("2025-08-04")]
		public async Task GetDailyBalanceProfitRatesAsync(string _date)
		{
			DateTime date = DateTime.Parse(_date);
			var result = await client.Account.GetDailyBalanceProfitRatesAsync(date);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930", "2025-08-04")]
		public async Task GetDailyStockRealizedProfitLossesAsync(string stockCode, string _date)
		{
			DateTime date = DateTime.Parse(_date);
			var result = await client.Account.GetDailyStockRealizedProfitLossesAsync(stockCode, date);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930", "2025-08-01", "2025-08-04")]
		public async Task GetDailyStockRealizedProfitLossPeriodAsync(string stockCode, string _startDate, string _endDate)
		{
			DateTime startDate = DateTime.Parse(_startDate);
			DateTime endDate = DateTime.Parse(_endDate);
			var result = await client.Account.GetDailyStockRealizedProfitLossPeriodsAsync(stockCode, startDate, endDate);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("2025-08-01", "2025-08-04")]
		public async Task GetRealizedProfitLossAsync(string _startDate, string _endDate)
		{
			DateTime startDate = DateTime.Parse(_startDate);
			DateTime endDate = DateTime.Parse(_endDate);
			var result = await client.Account.GetDailyRealizedProfitLossesAsync(startDate, endDate);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomAccountQueryType.All, KiwoomAccountTransactionType.All, KiwoomAccountStockExchangeType.Unified)]
		public async Task GetUnfilledOrdersAsync(KiwoomAccountQueryType queryType, KiwoomAccountTransactionType tradeType, KiwoomAccountStockExchangeType stockExchangeType)
		{
			var result = await client.Account.GetUnfilledOrdersAsync(queryType, tradeType, stockExchangeType);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomAccountQueryType.All, KiwoomAccountTransactionType.All, KiwoomAccountStockExchangeType.Unified)]
		public async Task GetContractsAsync(KiwoomAccountQueryType queryType, KiwoomAccountTransactionType tradeType, KiwoomAccountStockExchangeType stockExchangeType)
		{
			var result = await client.Account.GetFilledOrdersAsync(queryType, tradeType, stockExchangeType);

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
			var result = await client.Account.GetProfitRatesAsync(stockExchangeType);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("00000000")]
		public async Task GetUnfilledSplitOrdersAsync(string orderId)
		{
			var result = await client.Account.GetUnfilledSplitOrdersAsync(orderId);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomAccountOddLotType.TodayBuyTodaySell, KiwoomAccountCashCreditType.All)]
		[TestCase(KiwoomAccountOddLotType.TodayBuyTodaySell, KiwoomAccountCashCreditType.All, "2025-08-01")]
		public async Task GetTodayTransactionJournalAsync(KiwoomAccountOddLotType oddLotType, KiwoomAccountCashCreditType cashCreditType, string _date = "2025-01-01")
		{
			DateTime date = DateTime.Parse(_date);
			var result = await client.Account.GetTodayTransactionJournalsAsync(oddLotType, cashCreditType, date);

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
			var result = await client.Account.GetTradeBalancesAsync(stockExchangeType);

			Assert.That(result.ReturnCode, Is.EqualTo(0).Or.EqualTo(20));
		}

		[TestCase(KiwoomAccountOrderQueryType.OrderSequence, KiwoomAccountStockBondType.All, KiwoomAccountTransactionType.All, KiwoomAccountDomesticStockExchangeType.All)]
		[TestCase(KiwoomAccountOrderQueryType.OrderSequence, KiwoomAccountStockBondType.All, KiwoomAccountTransactionType.All, KiwoomAccountDomesticStockExchangeType.All, "2025-08-01")]
		public async Task GetOrderTradeDetailsAsync(KiwoomAccountOrderQueryType queryType, KiwoomAccountStockBondType stockBondType, KiwoomAccountTransactionType tradeType, KiwoomAccountDomesticStockExchangeType domesticStockExchangeType, string _date = "2025-01-01", string stockCode = "", string fromOrderId = "")
		{
			DateTime date = DateTime.Parse(_date);
			var result = await client.Account.GetOrderTradeDetailsAsync(queryType, stockBondType, tradeType, domesticStockExchangeType, date, stockCode, fromOrderId);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase()]
		[TestCase("00000000")]
		public async Task GetNextDaySettlementsAsync(string startDealCodeId = "")
		{
			var result = await client.Account.GetNextDaySettlementsAsync(startDealCodeId);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomAccountOrderTradeQueryType.All, KiwoomAccountStockBondType.All, KiwoomAccountTransactionType.All, KiwoomAccountDomesticStockExchangeType.All, KiwoomAccountMarketType.All)]
		[TestCase(KiwoomAccountOrderTradeQueryType.All, KiwoomAccountStockBondType.All, KiwoomAccountTransactionType.All, KiwoomAccountDomesticStockExchangeType.All, KiwoomAccountMarketType.All, "2025-08-01")]
		public async Task GetOrderContractsAsync(KiwoomAccountOrderTradeQueryType queryType, KiwoomAccountStockBondType stockBondType, KiwoomAccountTransactionType tradeType, KiwoomAccountDomesticStockExchangeType domesticStockExchangeType, KiwoomAccountMarketType marketType, string _date = "2025-01-01", string stockCode = "", string fromOrderId = "")
		{
			DateTime date = DateTime.Parse(_date);
			var result = await client.Account.GetOrderTradesAsync(queryType, stockBondType, tradeType, domesticStockExchangeType, marketType, date, stockCode, fromOrderId);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}


		[TestCase("005930", KiwoomAccountTransactionType.All, "12345")]
		[TestCase("005930", KiwoomAccountTransactionType.All, "12345", "2")]
		public async Task GetAvailableWithdrawalAmountsAsync(string stockCode, KiwoomAccountTransactionType tradeType, string _buyPrice, string _buyQuantity = "0", string _inOutAmount = "0", string _expectedBuyPrice = "0")
		{
			decimal buyPrice = decimal.Parse(_buyPrice);
			decimal buyQuantity = decimal.Parse(_buyQuantity);
			decimal inOutAmount = decimal.Parse(_inOutAmount);
			decimal expectedBuyPrice = decimal.Parse(_expectedBuyPrice);
			var result = await client.Account.GetAvailableWithdrawalAmountsAsync(stockCode, tradeType, buyPrice, buyQuantity, inOutAmount, expectedBuyPrice);

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
		public async Task GetCreditDepositOrdersAsync(string stockCode, string _buyPrice = "0")
		{
			decimal buyPrice = decimal.Parse(_buyPrice);
			var result = await client.Account.GetCreditDepositOrdersAsync(stockCode, buyPrice);

			Assert.That(result.ReturnCode, Is.EqualTo(0).Or.EqualTo(20));
		}

		[Test]
		public async Task GetMarginDetailsAsync()
		{
			var result = await client.Account.GetMarginDetailsAsync();

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomAccountTransactionType2.All, KiwoomAccountGoodsType.All, KiwoomAccountDomesticStockExchangeType.All, "2025-08-01", "2025-08-04")]
		[TestCase(KiwoomAccountTransactionType2.All, KiwoomAccountGoodsType.All, KiwoomAccountDomesticStockExchangeType.All, "2025-08-01", "2025-08-04", "005930")]
		public async Task GetConsignedTransactionsAsync(KiwoomAccountTransactionType2 transactionType, KiwoomAccountGoodsType goodsType, KiwoomAccountDomesticStockExchangeType domesticStockExchangeType, string _startDate, string _endDate, string stockCode = "", string currencyCode = "", string foreignStockExchangeCode = "")
		{
			DateTime startDate = DateTime.Parse(_startDate);
			DateTime endDate = DateTime.Parse(_endDate);
			var result = await client.Account.GetConsignedTransactionsAsync(transactionType, goodsType, domesticStockExchangeType, startDate, endDate, stockCode, currencyCode, foreignStockExchangeCode);

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
			var result = await client.ForeignInstitution.GetStockInstitutionsAsync(stockCode);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomForeignInstitutionStockExchangeType.Unified, KiwoomForeignInstitutionMarketType.Kospi, KiwoomForeignInstitutionStockIndustryType.Stock, KiwoomForeignInstitutionAmountQuantityType.Amount, 7)]
		public async Task GetContinuousTradesAsync(KiwoomForeignInstitutionStockExchangeType stockExchangeType, KiwoomForeignInstitutionMarketType marketType, KiwoomForeignInstitutionStockIndustryType stockIndustryType, KiwoomForeignInstitutionAmountQuantityType amountQuantityType, int period = 0, string _startDate = "2025-08-01", string _endDate = "2025-08-04")
		{
			DateTime startDate = DateTime.Parse(_startDate);
			DateTime endDate = DateTime.Parse(_endDate);
			var result = await client.ForeignInstitution.GetContinuousTransactionsAsync(stockExchangeType, marketType, stockIndustryType, amountQuantityType, period, startDate, endDate);

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
			var result = await client.SecuritiesLending.GetBorrowedTradesAsync(startDate, endDate);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomSecuritiesLendingMarketType.Kospi, "2025-08-01")]
		public async Task GetBorrowedTradeTop10Async(KiwoomSecuritiesLendingMarketType marketType, string _startDate, string _endDate = "2025-08-04")
		{
			DateTime startDate = DateTime.Parse(_startDate);
			DateTime endDate = DateTime.Parse(_endDate);
			var result = await client.SecuritiesLending.GetBorrowedTradeTop10Async(marketType, startDate, endDate);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930")]
		public async Task GetStockBorrowedTradeAsync(string stockCode, string _startDate = "2025-08-01", string _endDate = "2025-08-04")
		{
			DateTime startDate = DateTime.Parse(_startDate);
			DateTime endDate = DateTime.Parse(_endDate);
			var result = await client.SecuritiesLending.GetStockBorrowedTradesAsync(stockCode, startDate, endDate);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomSecuritiesLendingMarketType.Kospi, "2025-08-01")]
		public async Task GetBorrowedTradeHistoriesAsync(KiwoomSecuritiesLendingMarketType marketType, string _date)
		{
			DateTime date = DateTime.Parse(_date);
			var result = await client.SecuritiesLending.GetBorrowedTradeHistoriesAsync(marketType, date);

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

		[TestCase(KiwoomElwChangeType.Surge, KiwoomElwTimeType.Minute, 30, 712, KiwoomElwCompanyCode.All, "005930", KiwoomElwRightsType.Call, KiwoomElwCompanyCode.All, false)]
		public async Task GetPriceVolatilitiesAsync(KiwoomElwChangeType changeType, KiwoomElwTimeType timeType, int timeValue, decimal minVolume, KiwoomElwCompanyCode issuerCompanyCode, string baseAssetCode, KiwoomElwRightsType rightType, KiwoomElwCompanyCode lpCode, bool isExcludeEndedElw)
		{
			var result = await client.Elw.GetPriceVolatilitiesAsync(changeType, timeType, timeValue, minVolume, issuerCompanyCode, baseAssetCode, rightType, lpCode, isExcludeEndedElw);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomElwCompanyCode.All, 715, KiwoomElwNetTransactionType.NetBuy, 30, false)]
		public async Task GetBrokerNetTransactionTopsAsync(KiwoomElwCompanyCode issuerCompanyCode, decimal minVolume, KiwoomElwNetTransactionType tradeType, int period, bool isExcludeEndedElw)
		{
			var result = await client.Elw.GetBrokerNetTransactionTopsAsync(issuerCompanyCode, minVolume, tradeType, period, isExcludeEndedElw);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930", "2025-08-01")]
		public async Task GetLpHoldingDailyTrendsAsync(string baseAssetCode, string _date)
		{
			DateTime date = DateTime.Parse(_date);
			var result = await client.Elw.GetLpHoldingDailyTrendsAsync(baseAssetCode, date);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomElwCompanyCode.All, "005930", KiwoomElwRightsType.Call, KiwoomElwCompanyCode.All, false)]
		public async Task GetDisparityRatesAsync(KiwoomElwCompanyCode issuerCompanyCode, string baseAssetCode, KiwoomElwRightsType rightType, KiwoomElwCompanyCode lpCode, bool isExcludeEndedElw)
		{
			var result = await client.Elw.GetDisparityRatesAsync(issuerCompanyCode, baseAssetCode, rightType, lpCode, isExcludeEndedElw);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomElwCompanyCode.All, "005930", KiwoomElwRightsType.Call, KiwoomElwCompanyCode.All, KiwoomElwSortType.Volume)]
		public async Task GetConditionSearchsAsync(KiwoomElwCompanyCode issuerCompanyCode, string baseAssetCode, KiwoomElwRightsType rightType, KiwoomElwCompanyCode lpCode, KiwoomElwSortType sortType)
		{
			var result = await client.Elw.GetConditionSearchsAsync(issuerCompanyCode, baseAssetCode, rightType, lpCode, sortType);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomElwSortType.Volume, KiwoomElwRightsType.Call, false)]
		public async Task GetFluctuationRateRanksAsync(KiwoomElwSortType sortType, KiwoomElwRightsType rightType, bool isExcludeEnded)
		{
			var result = await client.Elw.GetChangeRateRanksAsync(sortType, rightType, isExcludeEnded);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomElwSortType2.NetBuyTop, KiwoomElwRightsType.Call, false)]
		public async Task GetRequestRanksAsync(KiwoomElwSortType2 sortType, KiwoomElwRightsType rightType, bool isExcludeEnded)
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
			var result = await client.Elw.GetStockInfoAsync(stockCode);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}
		#endregion

		#region Etf
		[TestCase("152100", "Krx200", KiwoomEtfPeriodType.Week1)]
		public async Task GetProfitRatesAsync(string stockCode, string etfObjectIndexCode, KiwoomEtfPeriodType periodType)
		{
			var result = await client.Etf.GetProfitRatesAsync(stockCode, etfObjectIndexCode, periodType);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("152100")]
		public async Task GetInfoAsync(string stockCode)
		{
			var result = await client.Etf.GetStockInfoAsync(stockCode);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("152100")]
		public async Task GetDailyTransactionsAsync(string stockCode)
		{
			var result = await client.Etf.GetDailyTransactionsAsync(stockCode);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomEtfTaxType.All, KiwoomEtfNavChange.All, KiwoomEtfManagementCompany.All, KiwoomEtfTaxationType.All, KiwoomEtfStockExchangeType.Krx)]
		public async Task GetAllMarketPricesAsync(KiwoomEtfTaxType taxType, KiwoomEtfNavChange navComparison, KiwoomEtfManagementCompany managementCompany, KiwoomEtfTaxationType taxationType, KiwoomEtfStockExchangeType stockExchangeType)
		{
			var result = await client.Etf.GetAllMarketPricesAsync(taxType, navComparison, managementCompany, taxationType, stockExchangeType);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("152100")]
		public async Task GetHourlyTransactionsAsync(string stockCode)
		{
			var result = await client.Etf.GetHourlyTransactionsAsync(stockCode);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("152100")]
		public async Task GetHourlyTradesAsync(string stockCode)
		{
			var result = await client.Etf.GetHourlyTradesAsync(stockCode);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("152100")]
		public async Task GetNetBuyQuantitiesAsync(string stockCode)
		{
			var result = await client.Etf.GetDailyTradesAsync(stockCode);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("152100")]
		public async Task GetNavsAsync(string stockCode)
		{
			var result = await client.Etf.GetHourlyTrades2Async(stockCode);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("152100")]
		public async Task GetHourlyTransactions2Async(string stockCode)
		{
			var result = await client.Etf.GetHourlyTransactions2Async(stockCode);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}
		#endregion

		#region StockInfo
		[TestCase(KiwoomStockInfoQueryType.OneHour)]
		public async Task GetRealtimeStockRanksAsync(KiwoomStockInfoQueryType queryType)
		{
			var result = await client.StockInfo.GetRealtimeStockRanksAsync(queryType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930", "2025-08-01", KiwoomStockInfoMarginLoanType.Loan)]
		public async Task GetStockInfoAsync(string stockCode, string dateStr, KiwoomStockInfoMarginLoanType marginLoanType)
		{
			var date = DateTime.Parse(dateStr);
			var result = await client.StockInfo.GetStockInfoAsync(stockCode, date, marginLoanType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930")]
		public async Task GetBrokerInfoAsync(string stockCode)
		{
			var result = await client.StockInfo.GetBrokerInfoAsync(stockCode);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930")]
		public async Task GetStockInfoContractsAsync(string stockCode)
		{
			var result = await client.StockInfo.GetTradesAsync(stockCode);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930", "2025-08-01", KiwoomStockInfoMarginLoanType.Loan)]
		public async Task GetCreditTransactionTrendsAsync(string stockCode, string dateStr, KiwoomStockInfoMarginLoanType marginLoanType)
		{
			var date = DateTime.Parse(dateStr);
			var result = await client.StockInfo.GetCreditTransactionTrendsAsync(stockCode, date, marginLoanType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930", "2025-08-01")]
		public async Task GetDailyTransactionDetailsAsync(string stockCode, string startDateStr)
		{
			var startDate = DateTime.Parse(startDateStr);
			var result = await client.StockInfo.GetDailyTransactionDetailsAsync(stockCode, startDate);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomStockInfoMarketType.Kospi, KiwoomStockInfoNewHighLowType.NewHigh, KiwoomStockInfoHighLowCloseType.HighLow, KiwoomStockInfoStockCondition.All, 0, KiwoomStockInfoCreditCondition.All, true, 30, KiwoomStockInfoStockExchangeType.Krx)]
		public async Task GetNewHighLowsAsync(KiwoomStockInfoMarketType marketType, KiwoomStockInfoNewHighLowType newHighLowType, KiwoomStockInfoHighLowCloseType highLowCloseType, KiwoomStockInfoStockCondition stockCondition, decimal minVolume, KiwoomStockInfoCreditCondition creditCondition, bool isIncludeUpDown, int period, KiwoomStockInfoStockExchangeType stockExchangeType)
		{
			var result = await client.StockInfo.GetNewHighLowsAsync(marketType, newHighLowType, highLowCloseType, stockCondition, minVolume, creditCondition, isIncludeUpDown, period, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomStockInfoMarketType.Kospi, KiwoomStockInfoUpDownType.Up, KiwoomStockInfoUpDownPriceSortType.StockCode, KiwoomStockInfoStockCondition.All, 0, KiwoomStockInfoCreditCondition.All, KiwoomStockInfoPriceCondition.All, KiwoomStockInfoStockExchangeType.Krx)]
		public async Task GetUpdownPricesAsync(KiwoomStockInfoMarketType marketType, KiwoomStockInfoUpDownType upDownType, KiwoomStockInfoUpDownPriceSortType sortType, KiwoomStockInfoStockCondition stockCondition, decimal minVolume, KiwoomStockInfoCreditCondition creditCondition, KiwoomStockInfoPriceCondition tradeAmountType, KiwoomStockInfoStockExchangeType stockExchangeType)
		{
			var result = await client.StockInfo.GetUpperLowersAsync(marketType, upDownType, sortType, stockCondition, minVolume, creditCondition, tradeAmountType, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomStockInfoNewHighLowType.NewHigh, 0.05, KiwoomStockInfoMarketType.Kospi, 0, KiwoomStockInfoStockCondition.All, KiwoomStockInfoCreditCondition.All, KiwoomStockInfoStockExchangeType.Krx)]
		public async Task GetHighLowProximitiesAsync(KiwoomStockInfoNewHighLowType newHighLowType, decimal approachRate, KiwoomStockInfoMarketType marketType, decimal minVolume, KiwoomStockInfoStockCondition stockCondition, KiwoomStockInfoCreditCondition creditCondition, KiwoomStockInfoStockExchangeType stockExchangeType)
		{
			var result = await client.StockInfo.GetHighLowProximitiesAsync(newHighLowType, approachRate, marketType, minVolume, stockCondition, creditCondition, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomStockInfoMarketType.Kospi, KiwoomStockInfoChangeType.Surge, KiwoomStockInfoTimeType.MinutesAgo, 30, 0, KiwoomStockInfoStockCondition.All, KiwoomStockInfoCreditCondition.All, KiwoomStockInfoPriceCondition.All, true, KiwoomStockInfoStockExchangeType.Krx)]
		public async Task GetPriceVolatilitiesAsync(KiwoomStockInfoMarketType marketType, KiwoomStockInfoChangeType changeType, KiwoomStockInfoTimeType timeType, int timeValue, decimal minVolume, KiwoomStockInfoStockCondition stockCondition, KiwoomStockInfoCreditCondition creditCondition, KiwoomStockInfoPriceCondition priceCondition, bool isIncludeUpDown, KiwoomStockInfoStockExchangeType stockExchangeType)
		{
			var result = await client.StockInfo.GetPriceVolatilitiesAsync(marketType, changeType, timeType, timeValue, minVolume, stockCondition, creditCondition, priceCondition, isIncludeUpDown, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomStockInfoMarketType.Kospi, 5, 0, KiwoomStockInfoStockExchangeType.Krx)]
		public async Task GetTradeVolumeUpdatesAsync(KiwoomStockInfoMarketType marketType, int cycleDays, decimal minVolume, KiwoomStockInfoStockExchangeType stockExchangeType)
		{
			var result = await client.StockInfo.GetVolumeUpdatesAsync(marketType, cycleDays, minVolume, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomStockInfoMarketType.Kospi, 0.1, true, 10, 5, KiwoomStockInfoStockExchangeType.Krx)]
		public async Task GetPriceConcentrationsAsync(KiwoomStockInfoMarketType marketType, decimal propertyConcentrationRate, bool isIncludeCurrentPriceEntry, int propertyCount, int cycleDays, KiwoomStockInfoStockExchangeType stockExchangeType)
		{
			var result = await client.StockInfo.GetPriceConcentrationsAsync(marketType, propertyConcentrationRate, isIncludeCurrentPriceEntry, propertyCount, cycleDays, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomStockInfoPerType.LowPer, KiwoomStockInfoStockExchangeType.Krx)]
		public async Task GetHighLowPersAsync(KiwoomStockInfoPerType perType, KiwoomStockInfoStockExchangeType stockExchangeType)
		{
			var result = await client.StockInfo.GetHighLowPersAsync(perType, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomStockInfoChangeSortType.Open, 0, KiwoomStockInfoMarketType.Kospi, true, KiwoomStockInfoStockCondition.All, KiwoomStockInfoCreditCondition.All, KiwoomStockInfoPriceCondition.All, KiwoomStockInfoChangeCondition.Top, KiwoomStockInfoStockExchangeType.Krx)]
		public async Task GetOpenChangeRatesAsync(KiwoomStockInfoChangeSortType sortType, decimal minVolume, KiwoomStockInfoMarketType marketType, bool isIncludeUpDown, KiwoomStockInfoStockCondition stockCondition, KiwoomStockInfoCreditCondition creditCondition, KiwoomStockInfoPriceCondition tradeAmountCondition, KiwoomStockInfoChangeCondition changeCondition, KiwoomStockInfoStockExchangeType stockExchangeType)
		{
			var result = await client.StockInfo.GetOpenChangeRatesAsync(sortType, minVolume, marketType, isIncludeUpDown, stockCondition, creditCondition, tradeAmountCondition, changeCondition, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930", "2025-08-01", "2025-08-15", KiwoomStockInfoQueryDateType.Period, KiwoomStockInfoDayType.Today, 14, KiwoomStockInfoSortType.Close, "001", KiwoomStockInfoStockExchangeType.Krx)]
		public async Task GetBrokerPriceAnalysesAsync(string stockCode, string startDateStr, string endDateStr, KiwoomStockInfoQueryDateType queryDateType, KiwoomStockInfoDayType pointType, int period, KiwoomStockInfoSortType sortType, string memberCode, KiwoomStockInfoStockExchangeType stockExchangeType)
		{
			var startDate = DateTime.Parse(startDateStr);
			var endDate = DateTime.Parse(endDateStr);
			var result = await client.StockInfo.GetBrokerPriceAnalysesAsync(stockCode, startDate, endDate, queryDateType, pointType, period, sortType, memberCode, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("001", KiwoomStockInfoMarketType2.Kospi, 1000, KiwoomStockInfoPriceCondition.All, KiwoomStockInfoStockExchangeType.Krx, "005930")]
		[TestCase("001", KiwoomStockInfoMarketType2.Kospi, 1000, KiwoomStockInfoPriceCondition.All, KiwoomStockInfoStockExchangeType.Krx, "")]
		public async Task GetBrokerInstantVolumesAsync(string memberCode, KiwoomStockInfoMarketType2 marketType, int quantity, KiwoomStockInfoPriceCondition priceCondition, KiwoomStockInfoStockExchangeType stockExchangeType, string stockCode)
		{
			var result = await client.StockInfo.GetBrokerInstantVolumesAsync(memberCode, marketType, quantity, priceCondition, stockExchangeType, stockCode);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomStockInfoMarketType.Kospi, KiwoomStockInfoBeforeMarketType.All, KiwoomStockInfoTriggerType.All, KiwoomStockInfoSkipStockType.Preferred, true, 1000, 10000, true, 1000000, 10000000, KiwoomStockInfoTriggerDirection.All, KiwoomStockInfoStockExchangeType.Krx, "005930")]
		[TestCase(KiwoomStockInfoMarketType.Kospi, KiwoomStockInfoBeforeMarketType.All, KiwoomStockInfoTriggerType.All, KiwoomStockInfoSkipStockType.Preferred, true, 1000, 10000, true, 1000000, 10000000, KiwoomStockInfoTriggerDirection.All, KiwoomStockInfoStockExchangeType.Krx, "")]
		public async Task GetViStrikeStocksAsync(KiwoomStockInfoMarketType marketType, KiwoomStockInfoBeforeMarketType beforeMarketType, KiwoomStockInfoTriggerType triggerType, KiwoomStockInfoSkipStockType skipStockType, bool isUseVolumeOption, decimal minTradeQuantity, decimal maxTradeQuantity, bool isUseTransactionAmountOption, decimal minTradeAmount, decimal maxTradeAmount, KiwoomStockInfoTriggerDirection triggerDirection, KiwoomStockInfoStockExchangeType stockExchangeType, string stockCode)
		{
			var result = await client.StockInfo.GetViStrikeStocksAsync(marketType, beforeMarketType, triggerType, skipStockType, isUseVolumeOption, minTradeQuantity, maxTradeQuantity, isUseTransactionAmountOption, minTradeAmount, maxTradeAmount, triggerDirection, stockExchangeType, stockCode);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930", KiwoomStockInfoDayType2.Today)]
		public async Task GetTodayPreviousDayTradeQuantitiesAsync(string stockCode, KiwoomStockInfoDayType2 dayType)
		{
			var result = await client.StockInfo.GetTodayPreviousDayTradeQuantitiesAsync(stockCode, dayType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("2025-08-01", "2025-08-15", KiwoomStockInfoNetTransactionType.NetBuy, KiwoomStockInfoMarketType.Kospi, KiwoomStockInfoInvestorType.Retail, KiwoomStockInfoStockExchangeType.Krx)]
		public async Task GetInvestorDailyTransactionStocksAsync(string startDateStr, string endDateStr, KiwoomStockInfoNetTransactionType tradeType, KiwoomStockInfoMarketType marketType, KiwoomStockInfoInvestorType investorType, KiwoomStockInfoStockExchangeType stockExchangeType)
		{
			var startDate = DateTime.Parse(startDateStr);
			var endDate = DateTime.Parse(endDateStr);
			var result = await client.StockInfo.GetInvestorDailyTransactionStocksAsync(startDate, endDate, tradeType, marketType, investorType, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("2025-08-01", "005930", KiwoomStockInfoAmountQuantityType.Amount, KiwoomStockInfoTransactionType.NetBuy, KiwoomStockInfoUnitType.One)]
		public async Task GetStockInvestorInstitutionsAsync(string dateStr, string stockCode, KiwoomStockInfoAmountQuantityType amountQuantityType, KiwoomStockInfoTransactionType tradeType, KiwoomStockInfoUnitType unitType)
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
		public async Task GetTodayPreviousDayTradesAsync(string stockCode, KiwoomStockInfoDayType2 dayType, KiwoomStockInfoTickMinuteType tickMinuteType, string timeStr)
		{
			var time = TimeSpan.Parse(timeStr);
			var result = await client.StockInfo.GetTodayPreviousDayTradesAsync(stockCode, dayType, tickMinuteType, time);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930")]
		public async Task GetFavoriteStocksAsync(string stockCode)
		{
			var result = await client.StockInfo.GetFavoriteStocksAsync(stockCode);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomStockInfoMarketType3.Kospi)]
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

		[TestCase(KiwoomStockInfoMarketType4.Kospi)]
		public async Task GetMarketCodesAsync(KiwoomStockInfoMarketType4 marketType)
		{
			var result = await client.StockInfo.GetIndustryCodesAsync(marketType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[Test]
		public async Task GetMemberCodesAsync()
		{
			var result = await client.StockInfo.GetMemberCompanysAsync();
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomStockInfoNetTransactionType.NetBuy, KiwoomStockInfoAmountQuantityType.Amount, KiwoomStockInfoMarketType5.Kospi, KiwoomStockInfoStockExchangeType.Krx)]
		public async Task GetProgramNetBuyTop50Async(KiwoomStockInfoNetTransactionType tradeUpperType, KiwoomStockInfoAmountQuantityType amountQuantityType, KiwoomStockInfoMarketType5 marketType, KiwoomStockInfoStockExchangeType stockExchangeType)
		{
			var result = await client.StockInfo.GetProgramNetBuyTop50Async(tradeUpperType, amountQuantityType, marketType, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("2025-08-01", KiwoomStockInfoMarketType5.Kospi, KiwoomStockInfoStockExchangeType.Krx)]
		public async Task GetProgramTradeStatusAsync(string dateStr, KiwoomStockInfoMarketType5 marketType, KiwoomStockInfoStockExchangeType stockExchangeType)
		{
			var date = DateTime.Parse(dateStr);
			var result = await client.StockInfo.GetStockProgramTransactionStatusAsync(date, marketType, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomStockInfoMarketDealType.Kospi, KiwoomStockInfoCreditStockGradeType.All, "005930")]
		[TestCase(KiwoomStockInfoMarketDealType.Kospi, KiwoomStockInfoCreditStockGradeType.A, "")]
		public async Task GetCreditLoanAvailableStocksAsync(KiwoomStockInfoMarketDealType marketDealType, KiwoomStockInfoCreditStockGradeType creditStockGradeType, string stockCode)
		{
			var result = await client.StockInfo.GetCreditLoanAvailableStocksAsync(marketDealType, creditStockGradeType, stockCode);
			Assert.That(result.ReturnCode, Is.EqualTo(0).Or.EqualTo(20));
		}

		[TestCase("005930")]
		public async Task GetCreditLoanAvailableAsync(string stockCode)
		{
			var result = await client.StockInfo.GetCreditLoanAvailableAsync(stockCode);
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

		[TestCase(KiwoomMarketConditionMarketType.Kospi, KiwoomMarketConditionNetTransactionType.NetBuy, KiwoomMarketConditionStockExchangeType.Krx, "2025-08-01", "2025-08-25")]
		public async Task GetDailyInstitutionTradingStocksAsync(KiwoomMarketConditionMarketType marketType, KiwoomMarketConditionNetTransactionType tradeType, KiwoomMarketConditionStockExchangeType stockExchangeType, string startDateStr, string endDateStr)
		{
			var startDate = DateTime.Parse(startDateStr);
			var endDate = DateTime.Parse(endDateStr);
			var result = await client.MarketCondition.GetDailyInstitutionTradingStocksAsync(marketType, tradeType, stockExchangeType, startDate, endDate);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930", "2025-08-01", "2025-08-25", KiwoomMarketConditionUnitPriceType.BuyPrice, KiwoomMarketConditionUnitPriceType.SellPrice)]
		public async Task GetStockInstitutionTransactionTrendsAsync(string stockCode, string startDateStr, string endDateStr, KiwoomMarketConditionUnitPriceType institutionEstimatedUnitPriceType, KiwoomMarketConditionUnitPriceType foreignEstimatedUnitPriceType)
		{
			var startDate = DateTime.Parse(startDateStr);
			var endDate = DateTime.Parse(endDateStr);
			var result = await client.MarketCondition.GetStockInstitutionTransactionTrendsAsync(stockCode, startDate, endDate, institutionEstimatedUnitPriceType, foreignEstimatedUnitPriceType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930")]
		public async Task GetHourlyTradeMomentumsAsync(string stockCode)
		{
			var result = await client.MarketCondition.GetHourlyTradeMomentumsAsync(stockCode);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930")]
		public async Task GetDailyTradeMomentumsAsync(string stockCode)
		{
			var result = await client.MarketCondition.GetDailyTradeMomentumsAsync(stockCode);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomMarketConditionMarketType.Kospi, KiwoomMarketConditionAmountQuantityType.Amount, KiwoomMarketConditionInvestorType.Foreign, true, false, KiwoomMarketConditionStockExchangeType.Krx)]
		public async Task GetIntradayInvestorTradingsAsync(KiwoomMarketConditionMarketType marketType, KiwoomMarketConditionAmountQuantityType amountQuantityType, KiwoomMarketConditionInvestorType investorType, bool isForeignAll, bool isSimultaneousNetBuyType, KiwoomMarketConditionStockExchangeType stockExchangeType)
		{
			var result = await client.MarketCondition.GetIntradayInvestorTradingsAsync(marketType, amountQuantityType, investorType, isForeignAll, isSimultaneousNetBuyType, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomMarketConditionMarketType.Kospi, KiwoomMarketConditionAmountQuantityType.Amount, KiwoomMarketConditionTransactionType.NetBuy, KiwoomMarketConditionStockExchangeType.Krx)]
		public async Task GetIntradayInvestorTradeChartsAsync(KiwoomMarketConditionMarketType marketType, KiwoomMarketConditionAmountQuantityType amountQuantityType, KiwoomMarketConditionTransactionType tradeType, KiwoomMarketConditionStockExchangeType stockExchangeType)
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
		public async Task GetAfterMarketSinglePriceOrderBookAsync(string stockCode)
		{
			var result = await client.MarketCondition.GetAfterMarketSinglePriceOrderBookAsync(stockCode);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930")]
		public async Task GetAfterMarketSinglePriceOrderBookListAsync(string stockCode)
		{
			var result = await client.MarketCondition.GetAfterMarketSinglePriceOrderBookListAsync(stockCode);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("2025-08-25", KiwoomMarketConditionAmountQuantityType3.Amount1M, KiwoomMarketConditionMarketType3.Kospi, KiwoomMarketConditionTickMinuteType.Tick, KiwoomMarketConditionStockExchangeType.Krx)]
		public async Task GetHourlyProgramTradeTrendsAsync(string dateStr, KiwoomMarketConditionAmountQuantityType3 amountQuantityType, KiwoomMarketConditionMarketType3 marketType, KiwoomMarketConditionTickMinuteType tickMinuteType, KiwoomMarketConditionStockExchangeType stockExchangeType)
		{
			var date = DateTime.Parse(dateStr);
			var result = await client.MarketCondition.GetHourlyProgramTradeTrendsAsync(date, amountQuantityType, marketType, tickMinuteType, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("2025-08-25", KiwoomMarketConditionStockExchangeType.Krx)]
		public async Task GetProgramArbitrageBalanceTrendsAsync(string dateStr, KiwoomMarketConditionStockExchangeType stockExchangeType)
		{
			var date = DateTime.Parse(dateStr);
			var result = await client.MarketCondition.GetProgramArbitrageBalanceTrendsAsync(date, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("2025-08-25", KiwoomMarketConditionAmountQuantityType.Amount, KiwoomMarketConditionMarketType2.Kospi, KiwoomMarketConditionStockExchangeType.Krx)]
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

		[TestCase("2025-08-25", KiwoomMarketConditionAmountQuantityType3.Amount1M, KiwoomMarketConditionMarketType3.Kospi, KiwoomMarketConditionTickMinuteType.Minute, KiwoomMarketConditionStockExchangeType.Krx)]
		public async Task GetDailyProgramTradeTrendsAsync(string dateStr, KiwoomMarketConditionAmountQuantityType3 amountQuantityType, KiwoomMarketConditionMarketType3 marketType, KiwoomMarketConditionTickMinuteType tickMinuteType, KiwoomMarketConditionStockExchangeType stockExchangeType)
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

		[TestCase(KiwoomRankingInfoMarketType.Kospi, KiwoomRankingInfoSortType.NetBuyQuantity, 0, KiwoomRankingInfoStockCondition.All, KiwoomRankingInfoCreditCondition.All, KiwoomRankingInfoStockExchangeType.Krx)]
		public async Task GetOrderBookTopsAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoSortType sortType, decimal minVolume, KiwoomRankingInfoStockCondition stockCondition, KiwoomRankingInfoCreditCondition creditCondition, KiwoomRankingInfoStockExchangeType stockExchangeType)
		{
			var result = await client.RankingInfo.GetOrderBookTopsAsync(marketType, sortType, minVolume, stockCondition, creditCondition, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomRankingInfoMarketType.Kosdaq, KiwoomRankingInfoTransactionType.BuyQuantity, KiwoomRankingInfoSpikeSortType.SpikeRate, 1000, KiwoomRankingInfoStockCondition.ExcludeManaged, KiwoomRankingInfoStockExchangeType.Krx, 10)]
		public async Task GetOrderBookSpikesAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoTransactionType tradeType, KiwoomRankingInfoSpikeSortType sortType, decimal minVolume, KiwoomRankingInfoStockCondition stockCondition, KiwoomRankingInfoStockExchangeType stockExchangeType, int timeMinute)
		{
			var result = await client.RankingInfo.GetOrderBookSpikesAsync(marketType, tradeType, sortType, minVolume, stockCondition, stockExchangeType, timeMinute);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomRankingInfoMarketType.Kospi, KiwoomRankingInfoRateType.BuyToSellRate, 5000, KiwoomRankingInfoStockCondition.All, KiwoomRankingInfoStockExchangeType.Krx, 15)]
		public async Task GetRemainQuantityRateSpikesAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoRateType rateType, decimal minVolume, KiwoomRankingInfoStockCondition stockCondition, KiwoomRankingInfoStockExchangeType stockExchangeType, int timeMinute)
		{
			var result = await client.RankingInfo.GetRemainQuantityRateSpikesAsync(marketType, rateType, minVolume, stockCondition, stockExchangeType, timeMinute);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomRankingInfoMarketType.Kosdaq, KiwoomRankingInfoSpikeSortType.Spike, KiwoomRankingInfoTimeType.Minute, 10000, KiwoomRankingInfoStockCondition.OnlyKospi100, KiwoomRankingInfoPriceType.Over1K, KiwoomRankingInfoStockExchangeType.Krx, 30)]
		public async Task GetVolumeSpikesAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoSpikeSortType sortType, KiwoomRankingInfoTimeType timeType, decimal minVolume, KiwoomRankingInfoStockCondition stockCondition, KiwoomRankingInfoPriceType priceType, KiwoomRankingInfoStockExchangeType stockExchangeType, int timeMinute)
		{
			var result = await client.RankingInfo.GetVolumeSpikesAsync(marketType, sortType, timeType, minVolume, stockCondition, priceType, stockExchangeType, timeMinute);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomRankingInfoMarketType.Kospi, KiwoomRankingInfoChangeSortType.UpRate, 50000, KiwoomRankingInfoStockCondition.ExcludePreferredStock, KiwoomRankingInfoCreditCondition.CreditA, true, KiwoomRankingInfoPriceCondition.Over1K, 50_000_000, KiwoomRankingInfoStockExchangeType.Krx)]
		public async Task GetChangeRateTopsAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoChangeSortType sortType, decimal minVolume, KiwoomRankingInfoStockCondition stockCondition, KiwoomRankingInfoCreditCondition creditCondition, bool isIncludeUpDown, KiwoomRankingInfoPriceCondition priceCondition, decimal minTransactionAmount, KiwoomRankingInfoStockExchangeType stockExchangeType)
		{
			var result = await client.RankingInfo.GetChangeRateTopsAsync(marketType, sortType, minVolume, stockCondition, creditCondition, isIncludeUpDown, priceCondition, minTransactionAmount, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomRankingInfoMarketType.Kosdaq, KiwoomRankingInfoTradeChangeSortType.Up, 100_000, KiwoomRankingInfoStockCondition.All, KiwoomRankingInfoCreditCondition.All, KiwoomRankingInfoPriceCondition.Range1KTo2K, KiwoomRankingInfoStockExchangeType.Krx)]
		public async Task GetExpectedTradeChangeRateTopsAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoTradeChangeSortType sortType, decimal minVolume, KiwoomRankingInfoStockCondition stockCondition, KiwoomRankingInfoCreditCondition creditCondition, KiwoomRankingInfoPriceCondition priceCondition, KiwoomRankingInfoStockExchangeType stockExchangeType)
		{
			var result = await client.RankingInfo.GetExpectedTradeChangeRateTopsAsync(marketType, sortType, minVolume, stockCondition, creditCondition, priceCondition, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomRankingInfoMarketType.Kospi, KiwoomRankingInfoVolumeSortType.Volume, KiwoomRankingInfoStockCondition.ExcludeManagedPreferred, KiwoomRankingInfoCreditCondition.CreditB, 150_000, KiwoomRankingInfoPriceCondition2.Range2KTo5K, 100_000_000, KiwoomRankingInfoMarketOpenType.DuringMarket, KiwoomRankingInfoStockExchangeType.Krx)]
		public async Task GetTodayVolumeTopsAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoVolumeSortType sortType, KiwoomRankingInfoStockCondition stockCondition, KiwoomRankingInfoCreditCondition creditCondition, decimal minVolume, KiwoomRankingInfoPriceCondition2 priceCondition, decimal minTransactionAmount, KiwoomRankingInfoMarketOpenType marketOpenType, KiwoomRankingInfoStockExchangeType stockExchangeType)
		{
			var result = await client.RankingInfo.GetTodayVolumeTopsAsync(marketType, sortType, stockCondition, creditCondition, minVolume, priceCondition, minTransactionAmount, marketOpenType, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomRankingInfoMarketType.Kosdaq, KiwoomRankingInfoPreviousDayVolumeQueryType.PreviousDayVolumeTop100, KiwoomRankingInfoStockExchangeType.Krx, 1, 50)]
		public async Task GetPreviousDayVolumeTopsAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoPreviousDayVolumeQueryType queryType, KiwoomRankingInfoStockExchangeType stockExchangeType, int startRank, int endRank)
		{
			var result = await client.RankingInfo.GetPreviousDayVolumeTopsAsync(marketType, queryType, stockExchangeType, startRank, endRank);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomRankingInfoMarketType.Kospi, false, KiwoomRankingInfoStockExchangeType.Krx)]
		public async Task GetTransactionAmountTopsAsync(KiwoomRankingInfoMarketType marketType, bool isIncludeManagedStock, KiwoomRankingInfoStockExchangeType stockExchangeType)
		{
			var result = await client.RankingInfo.GetTransactionAmountTopsAsync(marketType, isIncludeManagedStock, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomRankingInfoMarketType.Kosdaq, 200_000, KiwoomRankingInfoStockCondition.OnlyKospi50, true, KiwoomRankingInfoCreditCondition.CreditC, KiwoomRankingInfoStockExchangeType.Krx)]
		public async Task GetCreditRateTopsAsync(KiwoomRankingInfoMarketType marketType, decimal minVolume, KiwoomRankingInfoStockCondition stockCondition, bool isIncludeUpDown, KiwoomRankingInfoCreditCondition creditCondition, KiwoomRankingInfoStockExchangeType stockExchangeType)
		{
			var result = await client.RankingInfo.GetCreditRateTopsAsync(marketType, minVolume, stockCondition, isIncludeUpDown, creditCondition, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomRankingInfoMarketType.Kospi, KiwoomRankingInfoNetTransactionType.NetBuy, KiwoomRankingInfoStockExchangeType.Krx, 5)]
		public async Task GetForeignPeriodTransactionTopsAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoNetTransactionType tradeType, KiwoomRankingInfoStockExchangeType stockExchangeType, int period)
		{
			var result = await client.RankingInfo.GetForeignPeriodTransactionTopsAsync(marketType, tradeType, stockExchangeType, period);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomRankingInfoMarketType.Kosdaq, KiwoomRankingInfoContinuousNetTransactionType.ContinuousNetBuy, KiwoomRankingInfoStockExchangeType.Krx, 3)]
		public async Task GetForeignContinuousNetTransactionTopsAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoContinuousNetTransactionType tradeType, KiwoomRankingInfoStockExchangeType stockExchangeType, int period)
		{
			var result = await client.RankingInfo.GetForeignContinuousNetTransactionTopsAsync(marketType, tradeType, stockExchangeType, period);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomRankingInfoMarketType.Kospi, KiwoomRankingInfoStockExchangeType.Krx, 7)]
		public async Task GetForeignLimitUsageRateIncreaseTopsAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoStockExchangeType stockExchangeType, int period)
		{
			var result = await client.RankingInfo.GetForeignLimitUsageRateIncreaseTopsAsync(marketType, stockExchangeType, period);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomRankingInfoMarketType.Kosdaq, KiwoomRankingInfoForeignWicketTransactionType.NetBuy, KiwoomRankingInfoAmountQuantityType.Amount, KiwoomRankingInfoStockExchangeType.Krx, 10)]
		public async Task GetForeignWicketTransactionTopsAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoForeignWicketTransactionType tradeType, KiwoomRankingInfoAmountQuantityType sortType, KiwoomRankingInfoStockExchangeType stockExchangeType, int period)
		{
			var result = await client.RankingInfo.GetForeignWicketTransactionTopsAsync(marketType, tradeType, sortType, stockExchangeType, period);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomRankingInfoSecuritiesRankQueryType.NetSellRankSort, "005930", "2025-08-01", "2025-08-25", 5)]
		public async Task GetStockSecuritiesRanksAsync(KiwoomRankingInfoSecuritiesRankQueryType queryType, string stockCode, string startDateStr, string endDateStr, int period)
		{
			var startDate = DateTime.Parse(startDateStr);
			var endDate = DateTime.Parse(endDateStr);
			var result = await client.RankingInfo.GetStockSecuritiesRanksAsync(queryType, stockCode, startDate, endDate, period);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(300_000, KiwoomRankingInfoNetTransactionType2.NetBuy, KiwoomRankingInfoStockExchangeType.Krx, "001", 3)]
		public async Task GetSecuritiesTransactionTopsAsync(decimal minVolume, KiwoomRankingInfoNetTransactionType2 tradeType, KiwoomRankingInfoStockExchangeType stockExchangeType, string memberCompanyCode, int period)
		{
			var result = await client.RankingInfo.GetSecuritiesTransactionTopsAsync(minVolume, tradeType, stockExchangeType, memberCompanyCode, period);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930")]
		public async Task GetTodayMainBrokersAsync(string stockCode)
		{
			var result = await client.RankingInfo.GetTodayMainBrokersAsync(stockCode);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomRankingInfoBrokerRankQueryDateType.Period, KiwoomRankingInfoDayType.Today, KiwoomRankingInfoBrokerRankSortType.Close, "005930", "2025-08-01", "2025-08-25", 5)]
		[TestCase(KiwoomRankingInfoBrokerRankQueryDateType.StartEndDate, KiwoomRankingInfoDayType.PreviousDay, KiwoomRankingInfoBrokerRankSortType.Date, "005930", "2025-08-01", "2025-08-25", null)]
		public async Task GetNetBuyBrokerRanksAsync(KiwoomRankingInfoBrokerRankQueryDateType queryDateType, KiwoomRankingInfoDayType pointType, KiwoomRankingInfoBrokerRankSortType sortBase, string stockCode, string startDateStr, string endDateStr, int? period)
		{
			DateTime? startDate = string.IsNullOrEmpty(startDateStr) ? null : DateTime.Parse(startDateStr);
			DateTime? endDate = string.IsNullOrEmpty(endDateStr) ? null : DateTime.Parse(endDateStr);
			var result = await client.RankingInfo.GetNetBuyBrokerRanksAsync(queryDateType, pointType, sortBase, stockCode, startDate, endDate, period);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930")]
		public async Task GetTodayTopExitBrokersAsync(string stockCode)
		{
			var result = await client.RankingInfo.GetTodayTopExitBrokersAsync(stockCode);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomRankingInfoMarketType.Kospi, KiwoomRankingInfoNetTransactionType2.NetBuy, KiwoomRankingInfoEqualNetTransactionRankSortType.Amount, KiwoomRankingInfoUnitType.One, KiwoomRankingInfoStockExchangeType.Krx, "2025-08-01", "2025-08-25")]
		[TestCase(KiwoomRankingInfoMarketType.Kosdaq, KiwoomRankingInfoNetTransactionType2.NetSell, KiwoomRankingInfoEqualNetTransactionRankSortType.Quantity, KiwoomRankingInfoUnitType.Thousand, KiwoomRankingInfoStockExchangeType.Krx, "2025-08-10", "2025-08-25")]
		public async Task GetEqualNetTransactionRanksAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoNetTransactionType2 tradeType, KiwoomRankingInfoEqualNetTransactionRankSortType sortType, KiwoomRankingInfoUnitType unitType, KiwoomRankingInfoStockExchangeType stockExchangeType, string startDateStr, string endDateStr)
		{
			var startDate = DateTime.Parse(startDateStr);
			DateTime? endDate = string.IsNullOrEmpty(endDateStr) ? null : DateTime.Parse(endDateStr);
			var result = await client.RankingInfo.GetEqualNetTransactionRanksAsync(marketType, tradeType, sortType, unitType, stockExchangeType, startDate, endDate);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomRankingInfoMarketType.Kospi, KiwoomRankingInfoNetTransactionType2.NetBuy, KiwoomRankingInfoInstitutionType.ForeignCompany)]
		public async Task GetOpenMarketInvestorTransactionTopsAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoNetTransactionType2 tradeType, KiwoomRankingInfoInstitutionType institutionType)
		{
			var result = await client.RankingInfo.GetOpenMarketInvestorTransactionTopsAsync(marketType, tradeType, institutionType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomRankingInfoMarketType.Kosdaq, KiwoomRankingInfoChangeSortType.DownRate, KiwoomRankingInfoStockCondition.OnlyKospi30, 500_000, KiwoomRankingInfoCreditCondition.CreditD, 300_000_000)]
		public async Task GetAfterMarketSinglePriceChangeRateRanksAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoChangeSortType sortType, KiwoomRankingInfoStockCondition stockCondition, decimal minVolume, KiwoomRankingInfoCreditCondition creditCondition, decimal minTransactionAmount)
		{
			var result = await client.RankingInfo.GetAfterMarketSinglePriceChangeRateRanksAsync(marketType, sortType, stockCondition, minVolume, creditCondition, minTransactionAmount);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomRankingInfoMarketType.Kospi, KiwoomRankingInfoAmountQuantityType.Quantity, true, KiwoomRankingInfoStockExchangeType.Krx, "2025-08-25")]
		[TestCase(KiwoomRankingInfoMarketType.Kosdaq, KiwoomRankingInfoAmountQuantityType.Amount, false, KiwoomRankingInfoStockExchangeType.Krx, "2025-08-25")]
		public async Task GetForeignInstitutionTransactionTopsAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoAmountQuantityType amountQuantityType, bool isIncludeQueryDate, KiwoomRankingInfoStockExchangeType stockExchangeType, string dateStr)
		{
			DateTime? date = string.IsNullOrEmpty(dateStr) ? null : DateTime.Parse(dateStr);
			var result = await client.RankingInfo.GetForeignInstitutionTransactionTopsAsync(marketType, amountQuantityType, isIncludeQueryDate, stockExchangeType, date);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		#endregion

		#region Industry

		[TestCase("005930")]
		public async Task GetProgramTransactionInfoAsync(string stockCode)
		{
			var result = await client.Industry.GetProgramTransactionInfoAsync(stockCode);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomIndustryMarketType.Kospi, KiwoomIndustryAmountQuantityType.Amount, KiwoomIndustryStockExchangeType.Krx, "2025-08-25")]
		[TestCase(KiwoomIndustryMarketType.Kosdaq, KiwoomIndustryAmountQuantityType.Quantity, KiwoomIndustryStockExchangeType.Krx, "2025-08-25")]
		public async Task GetInvestorNetBuysAsync(KiwoomIndustryMarketType marketType, KiwoomIndustryAmountQuantityType amountQuantityType, KiwoomIndustryStockExchangeType stockExchangeType, string dateStr)
		{
			DateTime? date = string.IsNullOrEmpty(dateStr) ? null : DateTime.Parse(dateStr);
			var result = await client.Industry.GetInvestorNetBuysAsync(marketType, amountQuantityType, stockExchangeType, date);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomIndustryMarketType.Kospi, KiwoomIndustryCode.KospiComposite)]
		[TestCase(KiwoomIndustryMarketType.Kosdaq, KiwoomIndustryCode.KosdaqComposite)]
		public async Task GetCurrentPricesAsync(KiwoomIndustryMarketType marketType, KiwoomIndustryCode industryCode)
		{
			var result = await client.Industry.GetCurrentPricesAsync(marketType, industryCode);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomIndustryMarketType.Kospi200, KiwoomIndustryCode.Kospi200, KiwoomIndustryStockExchangeType.Krx)]
		public async Task GetPricesAsync(KiwoomIndustryMarketType marketType, KiwoomIndustryCode industryCode, KiwoomIndustryStockExchangeType stockExchangeType)
		{
			var result = await client.Industry.GetPricesAsync(marketType, industryCode, stockExchangeType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomIndustryMarketType2.Kospi)]
		[TestCase(KiwoomIndustryMarketType2.Kosdaq)]
		public async Task GetAllIndustryIndicesAsync(KiwoomIndustryMarketType2 marketType)
		{
			var result = await client.Industry.GetAllIndustryIndicesAsync(marketType);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomIndustryMarketType.Kospi, KiwoomIndustryCode.KospiLargeCap)]
		[TestCase(KiwoomIndustryMarketType.Kosdaq, KiwoomIndustryCode.KospiMidCap)]
		public async Task GetDailyPricesAsync(KiwoomIndustryMarketType marketType, KiwoomIndustryCode industryCode)
		{
			var result = await client.Industry.GetDailyPricesAsync(marketType, industryCode);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		#endregion

		#region Theme

		[TestCase(KiwoomThemeQueryType.All, 1, KiwoomThemeChangeProfitType.TopPeriodProfitRate, KiwoomThemeStockExchangeType.Krx, "", "")]
		[TestCase(KiwoomThemeQueryType.Stock, 5, KiwoomThemeChangeProfitType.TopChangeRate, KiwoomThemeStockExchangeType.Krx, "005930", "")]
		[TestCase(KiwoomThemeQueryType.Theme, 3, KiwoomThemeChangeProfitType.BottomPeriodProfitRate, KiwoomThemeStockExchangeType.Krx, "", "AI")]
		public async Task GetGroupsAsync(KiwoomThemeQueryType queryType, int daysBefore, KiwoomThemeChangeProfitType changeProfitType, KiwoomThemeStockExchangeType stockExchangeType, string stockCode, string themeName)
		{
			var result = await client.Theme.GetGroupsAsync(queryType, daysBefore, changeProfitType, stockExchangeType, stockCode, themeName);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("001", KiwoomThemeStockExchangeType.Krx, 1)]
		[TestCase("002", KiwoomThemeStockExchangeType.Krx, 7)]
		public async Task GetComponentStocksAsync(string themeGroupCode, KiwoomThemeStockExchangeType stockExchangeType, int daysBefore)
		{
			var result = await client.Theme.GetComponentStocksAsync(themeGroupCode, stockExchangeType, daysBefore);
			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		#endregion

	}
}