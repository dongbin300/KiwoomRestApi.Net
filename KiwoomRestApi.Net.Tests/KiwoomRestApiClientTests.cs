using KiwoomRestApi.Net.Clients;
using KiwoomRestApi.Net.Enums;

namespace KiwoomRestApi.Net.Tests
{
	public class KiwoomRestApiClientTests
	{
		KiwoomRestApiClient client;

		[SetUp]
		public void Setup()
		{
			var appKey = File.ReadAllText("D:\\Assets\\kiwoom_appkey_mock.txt");
			var secretKey = File.ReadAllText("D:\\Assets\\kiwoom_secretkey_mock.txt");

			client = new KiwoomRestApiClient(appKey, secretKey, true);
		}

		[Test]
		public async Task GetAccessAndRevokeToken()
		{
			var result = await client.OAuth.GetAccessToken();
			var token = result.Data?.Token ?? string.Empty;

			Assert.Multiple(() =>
			{
				Assert.That(result.ReturnCode, Is.EqualTo(0));
				Assert.That(string.IsNullOrEmpty(token), Is.False);
			});

			var result2 = await client.OAuth.RevokeAccessToken(token);

			Assert.That(result2.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930", "2025-08-04")]
		public async Task GetDateStockRealizedProfitLoss(string stockCode, string _date)
		{
			DateTime date = DateTime.Parse(_date);
			var result = await client.Account.GetDateStockRealizedProfitLoss(stockCode, date);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("005930", "2025-08-01", "2025-08-04")]
		public async Task GetPeriodStockRealizedProfitLoss(string stockCode, string _startDate, string _endDate)
		{
			DateTime startDate = DateTime.Parse(_startDate);
			DateTime endDate = DateTime.Parse(_endDate);
			var result = await client.Account.GetPeriodStockRealizedProfitLoss(stockCode, startDate, endDate);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase("2025-08-01", "2025-08-04")]
		public async Task GetRealizedProfitLoss(string _startDate, string _endDate)
		{
			DateTime startDate = DateTime.Parse(_startDate);
			DateTime endDate = DateTime.Parse(_endDate);
			var result = await client.Account.GetRealizedProfitLoss(startDate, endDate);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomQueryType.All, KiwoomTradeType.All, KiwoomStockExchangeType.Unified)]
		public async Task GetOutstandingOrders(KiwoomQueryType queryType, KiwoomTradeType tradeType, KiwoomStockExchangeType stockExchangeType)
		{
			var result = await client.Account.GetOutstandingOrders(queryType, tradeType, stockExchangeType);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}

		[TestCase(KiwoomQueryType.All, KiwoomTradeType.All, KiwoomStockExchangeType.Unified)]
		public async Task GetContracts(KiwoomQueryType queryType, KiwoomTradeType tradeType, KiwoomStockExchangeType stockExchangeType)
		{
			var result = await client.Account.GetContracts(queryType, tradeType, stockExchangeType);

			Assert.That(result.ReturnCode, Is.EqualTo(0));
		}
	}
}
