using KiwoomRestApi.Net.Enums.Chart;
using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models;

using System;
using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.DomesticStocks
{
	/// <summary>
	/// 차트 API 클라이언트
	/// </summary>
	/// <param name="client"></param>
	public class KiwoomRestApiClientDomesticStockChart(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = ApiEndpoint.DomesticStock.Chart;

		/// <summary>
		/// | ka10060 | 종목별투자자기관별차트요청
		/// </summary>
		/// <param name="date"></param>
		/// <param name="stockCode"></param>
		/// <param name="amountQuantityType"></param>
		/// <param name="tradeType"></param>
		/// <param name="unitType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
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

		/// <summary>
		/// | ka10064 | 장중투자자별매매차트요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="amountQuantityType"></param>
		/// <param name="tradeType"></param>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
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

		/// <summary>
		/// | ka10079 | 주식틱차트조회요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="tickCount"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomChartGetTickCharts>> GetTickChartsAsync(string stockCode, int tickCount, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10079";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("tic_scope", tickCount)
				.AddField("upd_stkpc_tp", isUpdateStockPrice);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetTickCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10080 | 주식분봉차트조회요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="tickCount"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomChartGetMinuteCharts>> GetMinuteChartsAsync(string stockCode, int tickCount, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10080";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("tic_scope", tickCount)
				.AddField("upd_stkpc_tp", isUpdateStockPrice);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetMinuteCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10081 | 주식일봉차트조회요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="date"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomChartGetDailyCharts>> GetDailyChartsAsync(string stockCode, DateTime date, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10081";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("base_dt", date)
				.AddField("upd_stkpc_tp", isUpdateStockPrice);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetDailyCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10082 | 주식주봉차트조회요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="date"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomChartGetWeeklyCharts>> GetWeeklyChartsAsync(string stockCode, DateTime date, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10082";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("base_dt", date)
				.AddField("upd_stkpc_tp", isUpdateStockPrice);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetWeeklyCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10083 | 주식월봉차트조회요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="date"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomChartGetMonthlyCharts>> GetMonthlyChartsAsync(string stockCode, DateTime date, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10083";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("base_dt", date)
				.AddField("upd_stkpc_tp", isUpdateStockPrice);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetMonthlyCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10094 | 주식년봉차트조회요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="date"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomChartGetYearlyCharts>> GetYearlyChartsAsync(string stockCode, DateTime date, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10094";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("base_dt", date)
				.AddField("upd_stkpc_tp", isUpdateStockPrice);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetYearlyCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka20004 | 업종틱차트조회요청
		/// </summary>
		/// <param name="industryCode"></param>
		/// <param name="tickCount"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomChartGetIndustryTickCharts>> GetIndustryTickChartsAsync(KiwoomChartIndustryCode industryCode, int tickCount, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka20004";
			var body = new HttpParameterMap()
				.AddField("inds_cd", industryCode)
				.AddField("tic_scope", tickCount);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetIndustryTickCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka20005 | 업종분봉조회요청
		/// </summary>
		/// <param name="industryCode"></param>
		/// <param name="tickCount"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomChartGetIndustryMinuteCharts>> GetIndustryMinuteChartsAsync(KiwoomChartIndustryCode industryCode, int tickCount, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka20005";
			var body = new HttpParameterMap()
				.AddField("inds_cd", industryCode)
				.AddField("tic_scope", tickCount);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetIndustryMinuteCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka20006 | 업종일봉조회요청
		/// </summary>
		/// <param name="industryCode"></param>
		/// <param name="date"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomChartGetIndustryDailyCharts>> GetIndustryDailyChartsAsync(KiwoomChartIndustryCode industryCode, DateTime date, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka20006";
			var body = new HttpParameterMap()
				.AddField("inds_cd", industryCode)
				.AddField("base_dt", date);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetIndustryDailyCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka20007 | 업종주봉조회요청
		/// </summary>
		/// <param name="industryCode"></param>
		/// <param name="date"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomChartGetIndustryWeeklyCharts>> GetIndustryWeeklyChartsAsync(KiwoomChartIndustryCode industryCode, DateTime date, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka20007";
			var body = new HttpParameterMap()
				.AddField("inds_cd", industryCode)
				.AddField("base_dt", date);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetIndustryWeeklyCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka20008 | 업종월봉조회요청
		/// </summary>
		/// <param name="industryCode"></param>
		/// <param name="date"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomChartGetIndustryMonthlyCharts>> GetIndustryMonthlyChartsAsync(KiwoomChartIndustryCode industryCode, DateTime date, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka20008";
			var body = new HttpParameterMap()
				.AddField("inds_cd", industryCode)
				.AddField("base_dt", date);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetIndustryMonthlyCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka20019 | 업종년봉조회요청
		/// </summary>
		/// <param name="industryCode"></param>
		/// <param name="date"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
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
