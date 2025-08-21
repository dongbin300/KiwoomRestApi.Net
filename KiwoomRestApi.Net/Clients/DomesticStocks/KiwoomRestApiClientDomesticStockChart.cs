using KiwoomRestApi.Net.Enums.Chart;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models;

using System;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.DomesticStocks
{
	public class KiwoomRestApiClientDomesticStockChart(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = "/api/dostk/chart";

		public async Task<KiwoomRestApiResponse<KiwoomChartGetInvestorInstitutionCharts>> GetStockInvestorInstitutionChartsAsync(DateTime date, string stockCode, KiwoomChartAmountQuantityType amountQuantityType, KiwoomChartTradeType tradeType, KiwoomChartUnitType unitType)
		{
			const string apiId = "ka10060";
			var body = new HttpParameterMap()
				.AddField("dt", date)
				.AddField("stk_cd", stockCode)
				.AddField("amt_qty_tp", amountQuantityType)
				.AddField("trde_tp", tradeType)
				.AddField("unit_tp", unitType);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetInvestorInstitutionCharts>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomChartGetIntradayInvestorTradeCharts>> GetIntradayInvestorTradeChartsAsync(KiwoomChartMarketType marketType, KiwoomChartAmountQuantityType amountQuantityType, KiwoomChartTradeType tradeType, string stockCode)
		{
			const string apiId = "ka10064";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("amt_qty_tp", amountQuantityType)
				.AddField("trde_tp", tradeType)
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetIntradayInvestorTradeCharts>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomChartGetTickCharts>> GetTickChartsAsync(string stockCode, int tickCount, KiwoomChartUseOption updateStockPrice)
		{
			const string apiId = "ka10079";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("tic_scope", tickCount)
				.AddField("upd_stkpc_tp", updateStockPrice);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetTickCharts>(_endpoint, apiId, body).ConfigureAwait(false);
		}
	}
}
