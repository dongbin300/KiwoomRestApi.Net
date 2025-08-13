using KiwoomRestApi.Net.Enums.Sector;
using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Models;

using System;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.DomesticStocks
{
	public class KiwoomRestApiClientDomesticStockSector(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = "/api/dostk/sect";

		public async Task<KiwoomRestApiResponse<KiwoomSectorGetStockProgramTradingInfo>> GetStockProgramTradingInfoAsync(string stockCode)
		{
			const string apiId = "ka10010";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomSectorGetStockProgramTradingInfo>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomSectorGetIndustryNetPurchases>> GetIndustryNetPurchasesAsync(KiwoomSectorMarketType marketType, KiwoomSectorAmountQuantityType amountQuantityType, KiwoomSectorStockExchangeType stockExchangeType, DateTime? date = null)
		{
			const string apiId = "ka10051";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("amt_qty_tp", amountQuantityType)
				.AddField("base_dt", date)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomSectorGetIndustryNetPurchases>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomSectorGetIndustryCurrentPrices>> GetIndustryCurrentPricesAsync(KiwoomSectorMarketType marketType, KiwoomSectorIndustryCode industryCode)
		{
			const string apiId = "ka20001";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("inds_cd", industryCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomSectorGetIndustryCurrentPrices>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomSectorGetIndustryStockPrices>> GetIndustryStockPricesAsync(KiwoomSectorMarketType marketType, KiwoomSectorIndustryCode industryCode, KiwoomSectorStockExchangeType stockExchangeType)
		{
			const string apiId = "ka20002";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("inds_cd", industryCode)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomSectorGetIndustryStockPrices>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomSectorGetAllIndustryIndices>> GetAllIndustryIndicesAsync(KiwoomSectorMarketType2 marketType)
		{
			const string apiId = "ka20002";
			var body = new HttpParameterMap()
				.AddField("inds_cd", marketType);

			return await _client.PostKiwoomRestApiAsync<KiwoomSectorGetAllIndustryIndices>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomSectorGetDailyIndustryPrices>> GetDailyIndustryPricesAsync(KiwoomSectorMarketType marketType, KiwoomSectorIndustryCode industryCode)
		{
			const string apiId = "ka20009";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("inds_cd", industryCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomSectorGetDailyIndustryPrices>(_endpoint, apiId, body).ConfigureAwait(false);
		}
	}
}
