using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Models;

using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.DomesticStocks
{
	public class KiwoomRestApiClientDomesticStockMarketCondition(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = "/api/dostk/mrkcond";

		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetOrderBook>> GetOrderBookAsync(string stockCode)
		{
			const string apiId = "ka10004";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetOrderBook>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetOrderBookList>> GetOrderBookListAsync(string stockCode)
		{
			const string apiId = "ka10004";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			var response = await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetOrderBook>(_endpoint, apiId, body).ConfigureAwait(false);
			return response.MapResponse(r => new KiwoomMarketConditionGetOrderBookList(r));
		}
	}
}
