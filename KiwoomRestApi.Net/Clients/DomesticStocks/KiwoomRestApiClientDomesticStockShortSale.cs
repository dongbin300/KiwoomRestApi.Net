using KiwoomRestApi.Net.Enums.ShortSale;
using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models;

using System;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.DomesticStocks
{
	public class KiwoomRestApiClientDomesticStockShortSale(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = ApiEndpoint.DomesticStock.ShortSale;

		public async Task<KiwoomRestApiResponse<KiwoomShortSaleGetShortsTransactions>> GetShortsTransactionsAsync(string stockCode, DateTime startDate, DateTime endDate, KiwoomShortSaleTimeType timeType = KiwoomShortSaleTimeType.StartDate)
		{
			const string apiId = "ka10014";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate)
				.AddField("tm_tp", timeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomShortSaleGetShortsTransactions>(_endpoint, apiId, body).ConfigureAwait(false);
		}
	}
}
