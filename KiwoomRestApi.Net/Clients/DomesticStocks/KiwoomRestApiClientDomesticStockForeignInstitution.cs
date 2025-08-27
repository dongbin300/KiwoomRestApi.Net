using KiwoomRestApi.Net.Enums.ForeignInstitution;
using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models;

using System;
using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.DomesticStocks
{
	public class KiwoomRestApiClientDomesticStockForeignInstitution(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = ApiEndpoint.DomesticStock.ForeignInstitution;

		public async Task<KiwoomRestApiResponse<KiwoomForeignInstitutionGetStockForeigners>> GetStockForeignersAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10008";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomForeignInstitutionGetStockForeigners>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomForeignInstitutionGetDaily>> GetDailyAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10009";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomForeignInstitutionGetDaily>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomForeignInstitutionGetContinuousTrades>> GetContinuousTradesAsync(KiwoomForeignInstitutionPeriodQueryType queryType, KiwoomForeignInstitutionStockExchangeType stockExchangeType, KiwoomForeignInstitutionMarketType marketType, KiwoomForeignInstitutionNetSellAmountType netSellAmountType, KiwoomForeignInstitutionStockIndustryType stockIndustryType, KiwoomForeignInstitutionAmountQuantityType amountQuantityType, DateTime? startDate = null, DateTime? endDate = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10131";
			var body = new HttpParameterMap()
				.AddField("dt", queryType)
				.AddField("stex_tp", stockExchangeType)
				.AddField("mrkt_tp", marketType)
				.AddField("netslmt_tp", netSellAmountType)
				.AddField("stk_inds_tp", stockIndustryType)
				.AddField("amt_qty_tp", amountQuantityType)
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate);

			return await _client.PostKiwoomRestApiAsync<KiwoomForeignInstitutionGetContinuousTrades>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}
	}
}
