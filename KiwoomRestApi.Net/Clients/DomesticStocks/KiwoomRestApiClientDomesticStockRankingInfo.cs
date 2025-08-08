using KiwoomRestApi.Net.Enums.RankingInfo;
using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Models;

using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.DomesticStocks
{
	public class KiwoomRestApiClientDomesticStockRankingInfo(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = "/api/dostk/rkinfo";

		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetBidRequestUppers>> GetBidRequestUppersAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoSortType sortType, KiwoomRankingInfoTradeQuantityType tradeQuantityType, KiwoomRankingInfoStockCondition stockCondition, KiwoomRankingInfoCreditCondition creditCondition, KiwoomRankingInfoStockExchangeType stockExchangeType)
		{
			const string apiId = "ka10020";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("sort_tp", sortType)
				.AddField("trde_qty_tp", tradeQuantityType)
				.AddField("stk_cnd", stockCondition)
				.AddField("crd_cnd", creditCondition)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetBidRequestUppers>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetBidRequestSuddenIncreases>> GetBidRequestSuddenIncreasesAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoTradeType tradeType, KiwoomRankingInfoSuddenIncreaseSortType sortType, KiwoomRankingInfoTradeQuantityType tradeQuantityType, KiwoomRankingInfoStockCondition stockCondition, KiwoomRankingInfoStockExchangeType stockExchangeType, int timeMinute)
		{
			const string apiId = "ka10021";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("trde_tp", tradeType)
				.AddField("sort_tp", sortType)
				.AddField("trde_qty_tp", tradeQuantityType)
				.AddField("stk_cnd", stockCondition)
				.AddField("stex_tp", stockExchangeType)
				.AddField("tm_tp", timeMinute);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetBidRequestSuddenIncreases>(_endpoint, apiId, body).ConfigureAwait(false);
		}
	}
}
