using KiwoomRestApi.Net.Clients;
using KiwoomRestApi.Net.Enums.Account;
using KiwoomRestApi.Net.Enums.ForeignInstitution;
using KiwoomRestApi.Net.Enums.SecuritiesLendingAndBorrowing;
using KiwoomRestApi.Net.Enums.ShortSale;

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

		[TestCase(KiwoomAccountDepositQueryType.General)]
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

			Assert.That(result.ReturnCode, Is.EqualTo(0).Or.EqualTo(20)); // 모의투자 지원불가
		}

		[TestCase(KiwoomAccountDelistingQueryType.All)]
		public async Task GetEstimatedDepositAssetAsync(KiwoomAccountDelistingQueryType queryType)
		{
			var result = await client.Account.GetEstimatedDepositAssetAsync(queryType);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomAccountDelistingQueryType.All, KiwoomAccountStockExchangeType.Unified)]
		public async Task GetEvaluationsAsync(KiwoomAccountDelistingQueryType queryType, KiwoomAccountStockExchangeType stockExchangeType)
		{
			var result = await client.Account.GetEvaluationsAsync(queryType, stockExchangeType);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomAccountStockExchangeType.Unified)]
		public async Task GetContractBalancesAsync(KiwoomAccountStockExchangeType stockExchangeType)
		{
			var result = await client.Account.GetContractBalancesAsync(stockExchangeType);

			Assert.That(result.ReturnCode, Is.EqualTo(0).Or.EqualTo(20)); // 모의투자 지원불가
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

			Assert.That(result.ReturnCode, Is.EqualTo(0).Or.EqualTo(20)); // 모의투자 지원불가
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

			Assert.That(result.ReturnCode, Is.EqualTo(0).Or.EqualTo(20)); // 모의투자 지원불가
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

			Assert.That(result.ReturnCode, Is.EqualTo(0).Or.EqualTo(20)); // 모의투자 지원불가
		}

		[TestCase("2025-08-01", "2025-08-04")]
		public async Task GetDailyProfitRateDetailsAsync(string _startDate, string _endDate)
		{
			DateTime startDate = DateTime.Parse(_startDate);
			DateTime endDate = DateTime.Parse(_endDate);
			var result = await client.Account.GetDailyProfitRateDetailsAsync(startDate, endDate);

			Assert.That(result.ReturnCode, Is.EqualTo(0).Or.EqualTo(20)); // 모의투자 지원불가
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

		[TestCase(KiwoomForeignInstitutionPeriodQueryType.RecentDay, KiwoomForeignInstitutionStockExchangeType.Unified, KiwoomForeignInstitutionMarketType.KOSPI, KiwoomForeignInstitutionNetSellAmountType.NetBuy, KiwoomForeignInstitutionStockIndustryType.Stock, KiwoomForeignInstitutionAmountQuantityType.Amount)]
		public async Task GetContinuousTradesAsync(KiwoomForeignInstitutionPeriodQueryType queryType, KiwoomForeignInstitutionStockExchangeType stockExchangeType, KiwoomForeignInstitutionMarketType marketType, KiwoomForeignInstitutionNetSellAmountType netSellAmountType, KiwoomForeignInstitutionStockIndustryType stockIndustryType, KiwoomForeignInstitutionAmountQuantityType amountQuantityType, string _startDate = "2025-08-01", string _endDate = "2025-08-04")
		{
			DateTime startDate = DateTime.Parse(_startDate);
			DateTime endDate = DateTime.Parse(_endDate);
			var result = await client.ForeignInstitution.GetContinuousTradesAsync(queryType, stockExchangeType, marketType, netSellAmountType, stockIndustryType, amountQuantityType, startDate, endDate);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}
		#endregion

		#region SLB
		[TestCase(KiwoomSecuritiesLendingAndBorrowingQueryType.All)]
		[TestCase(KiwoomSecuritiesLendingAndBorrowingQueryType.All, "2025-08-01")]
		public async Task GetBorrowedTradesAsync(KiwoomSecuritiesLendingAndBorrowingQueryType queryType, string _startDate = "2025-08-01", string _endDate = "2025-08-04")
		{
			DateTime startDate = DateTime.Parse(_startDate);
			DateTime endDate = DateTime.Parse(_endDate);
			var result = await client.SLB.GetBorrowedTradesAsync(queryType, startDate, endDate);

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
		public async Task GetBorrowedTradesByStockAsync(string stockCode, KiwoomSecuritiesLendingAndBorrowingQueryType queryType = KiwoomSecuritiesLendingAndBorrowingQueryType.StockCode, string _startDate = "2025-08-01", string _endDate = "2025-08-04")
		{
			DateTime startDate = DateTime.Parse(_startDate);
			DateTime endDate = DateTime.Parse(_endDate);
			var result = await client.SLB.GetBorrowedTradesByStockAsync(stockCode, queryType, startDate, endDate);

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
	}
}
