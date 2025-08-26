using KiwoomRestApi.Net.Enums.Theme;
using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models;

using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.DomesticStocks
{
	public class KiwoomRestApiClientDomesticStockTheme(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = ApiEndpoint.DomesticStock.Theme;

		public async Task<KiwoomRestApiResponse<KiwoomThemeGetGroups>> GetGroupsAsync(KiwoomThemeQueryType queryType, int daysBefore, KiwoomThemeFluctuationProfitType fluctuationProfitType, KiwoomThemeStockExchangeType stockExchangeType, string stockCode = "", string themeName = "")
		{
			const string apiId = "ka90001";
			var body = new HttpParameterMap()
				.AddField("qry_tp", queryType)
				.AddField("date_tp", daysBefore)
				.AddField("flu_pl_amt_tp", fluctuationProfitType)
				.AddField("stex_tp", stockExchangeType)
				.AddField("stk_cd", stockCode)
				.AddField("thema_nm", themeName);

			return await _client.PostKiwoomRestApiAsync<KiwoomThemeGetGroups>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomThemeGetComponentStocks>> GetComponentStocksAsync(string themeGroupCode, KiwoomThemeStockExchangeType stockExchangeType, int daysBefore = 1)
		{
			const string apiId = "ka90002";
			var body = new HttpParameterMap()
				.AddField("thema_grp_cd", themeGroupCode)
				.AddField("stex_tp", stockExchangeType)
				.AddField("date_tp", daysBefore);

			return await _client.PostKiwoomRestApiAsync<KiwoomThemeGetComponentStocks>(_endpoint, apiId, body).ConfigureAwait(false);
		}
	}
}
