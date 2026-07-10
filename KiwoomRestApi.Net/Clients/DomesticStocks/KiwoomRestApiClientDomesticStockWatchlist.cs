using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models;
using KiwoomRestApi.Net.Objects.Models.DomesticStock;

using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.DomesticStocks
{
	/// <summary>
	/// 관심종목 API 클라이언트
	/// 현재 2개
	/// </summary>
	/// <param name="client"></param>
	public class KiwoomRestApiClientDomesticStockWatchlist(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = ApiEndpoint.DomesticStock.Watchlist;

		/// <summary>
		/// | ka01300 | 관심종목 그룹 리스트 조회
		/// </summary>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomWatchlistGetWatchlistGroups>> GetWatchlistGroupsAsync(CancellationToken cancellationToken = default)
		{
			const string apiId = "ka01300";
			var body = new HttpParameterMap();

			return await _client.PostKiwoomRestApiAsync<KiwoomWatchlistGetWatchlistGroups>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka01301 | 관심종목 그룹 상세 조회
		/// </summary>
		/// <param name="groupCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomWatchlistGetWatchlistGroupDetails>> GetWatchlistGroupDetailsAsync(string groupCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka01301";
			var body = new HttpParameterMap()
				.AddField("arn_grp_id", groupCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomWatchlistGetWatchlistGroupDetails>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}
	}
}
