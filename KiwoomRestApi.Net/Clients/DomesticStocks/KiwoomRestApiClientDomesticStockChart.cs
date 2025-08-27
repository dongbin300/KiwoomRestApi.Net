using KiwoomRestApi.Net.Enums.Chart;
using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models;

using System;
using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.DomesticStocks
{
	public class KiwoomRestApiClientDomesticStockChart(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = ApiEndpoint.DomesticStock.Chart;

		public async Task<KiwoomRestApiResponse<KiwoomChartGetInvestorInstitutionCharts>> GetStockInvestorInstitutionChartsAsync(DateTime date, string stockCode, KiwoomChartAmountQuantityType amountQuantityType, KiwoomChartTradeType tradeType, KiwoomChartUnitType unitType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10060";
			var body = new HttpParameterMap()
				.AddField("dt", date)
				.AddField("stk_cd", stockCode)
				.AddField("amt_qty_tp", amountQuantityType)
				.AddField("trde_tp", tradeType)
				.AddField("unit_tp", unitType);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetInvestorInstitutionCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomChartGetIntradayInvestorTradeCharts>> GetIntradayInvestorTradeChartsAsync(KiwoomChartMarketType marketType, KiwoomChartAmountQuantityType amountQuantityType, KiwoomChartTradeType tradeType, string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10064";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("amt_qty_tp", amountQuantityType)
				.AddField("trde_tp", tradeType)
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetIntradayInvestorTradeCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomChartGetTickCharts>> GetTickChartsAsync(string stockCode, int tickCount, KiwoomChartUseOption updateStockPrice, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10079";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("tic_scope", tickCount)
				.AddField("upd_stkpc_tp", updateStockPrice);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetTickCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomChartGetMinuteCharts>> GetMinuteChartsAsync(string stockCode, int tickCount, KiwoomChartUseOption updateStockPrice, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10080";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("tic_scope", tickCount)
				.AddField("upd_stkpc_tp", updateStockPrice);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetMinuteCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomChartGetDailyCharts>> GetDailyChartsAsync(string stockCode, DateTime date, KiwoomChartUseOption updateStockPrice, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10081";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("base_dt", date)
				.AddField("upd_stkpc_tp", updateStockPrice);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetDailyCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomChartGetWeeklyCharts>> GetWeeklyChartsAsync(string stockCode, DateTime date, KiwoomChartUseOption updateStockPrice, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10082";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("base_dt", date)
				.AddField("upd_stkpc_tp", updateStockPrice);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetWeeklyCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomChartGetMonthlyCharts>> GetMonthlyChartsAsync(string stockCode, DateTime date, KiwoomChartUseOption updateStockPrice, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10083";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("base_dt", date)
				.AddField("upd_stkpc_tp", updateStockPrice);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetMonthlyCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomChartGetYearlyCharts>> GetYearlyChartsAsync(string stockCode, DateTime date, KiwoomChartUseOption updateStockPrice, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10094";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("base_dt", date)
				.AddField("upd_stkpc_tp", updateStockPrice);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetYearlyCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomChartGetIndustryTickCharts>> GetIndustryTickChartsAsync(KiwoomChartIndustryCode industryCode, int tickCount, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka20004";
			var body = new HttpParameterMap()
				.AddField("inds_cd", industryCode)
				.AddField("tic_scope", tickCount);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetIndustryTickCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomChartGetIndustryMinuteCharts>> GetIndustryMinuteChartsAsync(KiwoomChartIndustryCode industryCode, int tickCount, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka20005";
			var body = new HttpParameterMap()
				.AddField("inds_cd", industryCode)
				.AddField("tic_scope", tickCount);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetIndustryMinuteCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomChartGetIndustryDailyCharts>> GetIndustryDailyChartsAsync(KiwoomChartIndustryCode industryCode, DateTime date, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka20006";
			var body = new HttpParameterMap()
				.AddField("inds_cd", industryCode)
				.AddField("base_dt", date);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetIndustryDailyCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomChartGetIndustryWeeklyCharts>> GetIndustryWeeklyChartsAsync(KiwoomChartIndustryCode industryCode, DateTime date, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka20007";
			var body = new HttpParameterMap()
				.AddField("inds_cd", industryCode)
				.AddField("base_dt", date);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetIndustryWeeklyCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomChartGetIndustryMonthlyCharts>> GetIndustryMonthlyChartsAsync(KiwoomChartIndustryCode industryCode, DateTime date, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka20008";
			var body = new HttpParameterMap()
				.AddField("inds_cd", industryCode)
				.AddField("base_dt", date);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetIndustryMonthlyCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomChartGetIndustryYearlyCharts>> GetIndustryYearlyChartsAsync(KiwoomChartIndustryCode industryCode, DateTime date, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka20019";
			var body = new HttpParameterMap()
				.AddField("inds_cd", industryCode)
				.AddField("base_dt", date);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetIndustryYearlyCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}
	}
}
