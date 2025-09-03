using KiwoomRestApi.Net.Enums.ShortSale;
using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models;

using System;
using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.DomesticStocks
{
	/// <summary>
	/// 공매도 API 클라이언트
	/// 현재 1개
	/// </summary>
	/// <param name="client"></param>
	public class KiwoomRestApiClientDomesticStockShortSale(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = ApiEndpoint.DomesticStock.ShortSale;

		/// <summary>
		/// | ka10014 | 공매도추이요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="timeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomShortSaleGetShortsTransactions>> GetShortsTransactionsAsync(string stockCode, DateTime startDate, DateTime endDate, KiwoomShortSaleTimeType timeType = KiwoomShortSaleTimeType.StartDate, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10014";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate)
				.AddField("tm_tp", timeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomShortSaleGetShortsTransactions>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}
	}
}
