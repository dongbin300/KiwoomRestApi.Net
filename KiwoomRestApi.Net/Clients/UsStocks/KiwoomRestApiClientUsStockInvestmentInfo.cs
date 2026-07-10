using KiwoomRestApi.Net.Enums.UsStock.InvestmentInfo;
using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models.UsStock;

using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.UsStocks
{
	/// <summary>
	/// 미국주식 투자정보 API 클라이언트
	/// 현재 1개
	/// </summary>
	/// <param name="client"></param>
	public class KiwoomRestApiClientUsStockInvestmentInfo(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = ApiEndpoint.UsStock.InvestmentInfo;

		/// <summary>
		/// | usa24300 | 미국주식 리서치(미국주식/ETF)
		/// </summary>
		/// <param name="queryType">주식/ETF 구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockInvestmentInfoGetResearches>> GetResearchesAsync(KiwoomUsStockInvestmentInfoQueryType? queryType = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa24300";
			var body = new HttpParameterMap()
				.AddField("qry_tp", queryType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockInvestmentInfoGetResearches>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}
	}
}
