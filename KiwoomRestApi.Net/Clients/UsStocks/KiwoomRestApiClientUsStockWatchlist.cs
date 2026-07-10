using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models.UsStock;

using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.UsStocks
{
	/// <summary>
	/// 미국주식 관심종목 API 클라이언트
	/// </summary>
	/// <param name="client"></param>
	public class KiwoomRestApiClientUsStockWatchlist(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = ApiEndpoint.UsStock.Watchlist;

		/// <summary>
		/// | usa20200 | 미국주식 관심종목 그룹 리스트 조회
		/// </summary>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockWatchlistGetWatchlistGroups>> GetWatchlistGroupsAsync(CancellationToken cancellationToken = default)
		{
			const string apiId = "usa20200";
			var body = new HttpParameterMap();

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockWatchlistGetWatchlistGroups>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa20201 | 미국주식 관심종목 그룹 상세 조회
		/// </summary>
		/// <param name="groupCode">그룹SEQ (usa20200 응답 결과의 gcod값을 입력)</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockWatchlistGetWatchlistGroupDetails>> GetWatchlistGroupDetailsAsync(string groupCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa20201";
			var body = new HttpParameterMap()
				.AddField("arn_grp_id", groupCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockWatchlistGetWatchlistGroupDetails>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}
	}
}
