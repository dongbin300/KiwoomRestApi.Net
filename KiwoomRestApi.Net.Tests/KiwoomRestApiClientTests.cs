using KiwoomRestApi.Net.Clients;
using KiwoomRestApi.Net.Enums;

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

		[TestCase(KiwoomQueryType.All, KiwoomTradeType.All, KiwoomStockExchangeType.Unified)]
		public async Task GetOutstandingOrdersAsync(KiwoomQueryType queryType, KiwoomTradeType tradeType, KiwoomStockExchangeType stockExchangeType)
		{
			var result = await client.Account.GetOutstandingOrdersAsync(queryType, tradeType, stockExchangeType);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomQueryType.All, KiwoomTradeType.All, KiwoomStockExchangeType.Unified)]
		public async Task GetContractsAsync(KiwoomQueryType queryType, KiwoomTradeType tradeType, KiwoomStockExchangeType stockExchangeType)
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

		[TestCase(KiwoomStockExchangeType.Unified)]
		public async Task GetProfitRateAsync(KiwoomStockExchangeType stockExchangeType)
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

		[TestCase(KiwoomOddLotType.TodayBuyTodaySell, KiwoomCashCreditType.All)]
		[TestCase(KiwoomOddLotType.TodayBuyTodaySell, KiwoomCashCreditType.All, "2025-08-01")]
		public async Task GetTodayTradeDiariesAsync(KiwoomOddLotType oddLotType, KiwoomCashCreditType cashCreditType, string _date = "2025-01-01")
		{
			DateTime date = DateTime.Parse(_date);
			var result = await client.Account.GetTodayTradeDiariesAsync(oddLotType, cashCreditType, date);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomQueryTypeDeposit.General)]
		public async Task GetDepositsAsync(KiwoomQueryTypeDeposit queryType)
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

		[TestCase(KiwoomQueryTypeDelisting.All)]
		public async Task GetEstimatedDepositAssetAsync(KiwoomQueryTypeDelisting queryType)
		{
			var result = await client.Account.GetEstimatedDepositAssetAsync(queryType);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomQueryTypeDelisting.All, KiwoomStockExchangeType.Unified)]
		public async Task GetEvaluationsAsync(KiwoomQueryTypeDelisting queryType, KiwoomStockExchangeType stockExchangeType)
		{
			var result = await client.Account.GetEvaluationsAsync(queryType, stockExchangeType);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomStockExchangeType.Unified)]
		public async Task GetContractBalancesAsync(KiwoomStockExchangeType stockExchangeType)
		{
			var result = await client.Account.GetContractBalancesAsync(stockExchangeType);

			Assert.That(result.ReturnCode, Is.EqualTo(0).Or.EqualTo(20)); // 모의투자 지원불가
		}

		[TestCase(KiwoomQueryTypeOrder.OrderSequence, KiwoomStockBondType.All, KiwoomTradeType.All, KiwoomDomesticStockExchangeType.All)]
		[TestCase(KiwoomQueryTypeOrder.OrderSequence, KiwoomStockBondType.All, KiwoomTradeType.All, KiwoomDomesticStockExchangeType.All, "2025-08-01")]
		public async Task GetOrderContractDetailsAsync(KiwoomQueryTypeOrder queryType, KiwoomStockBondType stockBondType, KiwoomTradeType tradeType, KiwoomDomesticStockExchangeType domesticStockExchangeType, string _date = "2025-01-01", string stockCode = "", string fromOrderId = "")
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

		[TestCase(KiwoomQueryTypeOrderContract.All, KiwoomStockBondType.All, KiwoomTradeType.All, KiwoomDomesticStockExchangeType.All, KiwoomMarketType.All)]
		[TestCase(KiwoomQueryTypeOrderContract.All, KiwoomStockBondType.All, KiwoomTradeType.All, KiwoomDomesticStockExchangeType.All, KiwoomMarketType.All, "2025-08-01")]
		public async Task GetOrderContractsAsync(KiwoomQueryTypeOrderContract queryType, KiwoomStockBondType stockBondType, KiwoomTradeType tradeType, KiwoomDomesticStockExchangeType domesticStockExchangeType, KiwoomMarketType marketType, string _date = "2025-01-01", string stockCode = "", string fromOrderId = "")
		{
			DateTime date = DateTime.Parse(_date);
			var result = await client.Account.GetOrderContractsAsync(queryType, stockBondType, tradeType, domesticStockExchangeType, marketType, date, stockCode, fromOrderId);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}


		[TestCase("005930", KiwoomTradeType.All, "12345")]
		[TestCase("005930", KiwoomTradeType.All, "12345", "2")]
		public async Task GetMarginOrderAmountsAsync(string stockCode, KiwoomTradeType tradeType, string _buyPrice, string _buyQuantity = "0", string _inOutAmount = "0", string _expectedBuyPrice = "0")
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

		[TestCase(KiwoomTransactionType.All, KiwoomGoodsType.All, KiwoomDomesticStockExchangeType.All, "2025-08-01", "2025-08-04")]
		[TestCase(KiwoomTransactionType.All, KiwoomGoodsType.All, KiwoomDomesticStockExchangeType.All, "2025-08-01", "2025-08-04", "005930")]
		public async Task GetConsignmentTradesAsync(KiwoomTransactionType transactionType, KiwoomGoodsType goodsType, KiwoomDomesticStockExchangeType domesticStockExchangeType, string _startDate, string _endDate, string stockCode = "", string currencyCode = "", string foreignStockExchangeCode = "")
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

		[TestCase(KiwoomQueryTypeEvaluationBalance.Aggregate, KiwoomDomesticStockExchangeType.All)]
		public async Task GetEvaluationBalancesAsync(KiwoomQueryTypeEvaluationBalance queryType, KiwoomDomesticStockExchangeType domesticStockExchangeType)
		{
			var result = await client.Account.GetEvaluationBalancesAsync(queryType, domesticStockExchangeType);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}
	}
}
