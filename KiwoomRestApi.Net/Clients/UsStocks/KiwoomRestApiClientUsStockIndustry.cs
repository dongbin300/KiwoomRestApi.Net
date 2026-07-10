using KiwoomRestApi.Net.Enums.UsStock.Industry;
using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models.UsStock;

using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.UsStocks
{
	/// <summary>
	/// 미국주식 업종 API 클라이언트
	/// 현재 2개
	/// </summary>
	/// <param name="client"></param>
	public class KiwoomRestApiClientUsStockIndustry(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = ApiEndpoint.UsStock.Industry;

		/// <summary>
		/// | usa23000 | 미국주식 업종별 기간별 수익률 조회
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="industryCode">업종코드</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockIndustryGetPeriodReturns>> GetPeriodReturnsAsync(KiwoomUsStockIndustryExchangeType? exchangeType = null, string? industryCode = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa23000";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("inds_cd", industryCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockIndustryGetPeriodReturns>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa23100 | 미국주식 업종별 등락률 상위/하위 조회
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="sortType">정렬기준구분</param>
		/// <param name="industryCode">업종코드</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockIndustryGetChangeRateRanks>> GetChangeRateRanksAsync(KiwoomUsStockIndustryExchangeType? exchangeType = null, KiwoomUsStockIndustrySortType? sortType = null, string? industryCode = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa23100";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("sort_tp", sortType)
				.AddField("inds_cd", industryCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockIndustryGetChangeRateRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}
	}
}
