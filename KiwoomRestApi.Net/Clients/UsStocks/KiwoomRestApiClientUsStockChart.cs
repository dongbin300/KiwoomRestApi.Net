using KiwoomRestApi.Net.Enums.UsStock.Chart;
using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models.UsStock;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.UsStocks
{
	/// <summary>
	/// 미국주식 차트 API 클라이언트
	/// 현재 7개
	/// </summary>
	/// <param name="client"></param>
	public class KiwoomRestApiClientUsStockChart(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = ApiEndpoint.UsStock.Chart;

		/// <summary>
		/// | usa06010 | 미국주식 틱 차트
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="tickCount">틱범위</param>
		/// <param name="isUpdateStockPrice">수정주가구분</param>
		/// <param name="isApplyExchangeRate">환율적용구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockChartGetTickCharts>> GetTickChartsAsync(KiwoomUsStockChartExchangeType exchangeType, string stockCode, int tickCount, bool isUpdateStockPrice = false, bool isApplyExchangeRate = false, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa06010";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cd", stockCode)
				.AddField("tic_scope", tickCount)
				.AddField("upd_stkpc_tp", isUpdateStockPrice)
				.AddField("exrt_appl_tp", isApplyExchangeRate);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockChartGetTickCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// 미국주식 틱 차트(기간)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="tickCount">틱범위</param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="isUpdateStockPrice">수정주가구분</param>
		/// <param name="isApplyExchangeRate">환율적용구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<List<KiwoomUsStockChartGetTickChartItem>> GetTickChartsByRangeAsync(KiwoomUsStockChartExchangeType exchangeType, string stockCode, int tickCount, DateTime startDate, DateTime endDate, bool isUpdateStockPrice = false, bool isApplyExchangeRate = false, CancellationToken cancellationToken = default)
		{
			var results = new List<KiwoomUsStockChartGetTickChartItem>();
			_client.NextKey = string.Empty;
			_client.ContYn = false;

			while (true)
			{
				var result = await GetTickChartsAsync(exchangeType, stockCode, tickCount, isUpdateStockPrice, isApplyExchangeRate, cancellationToken)
					.ConfigureAwait(false);

				if (result?.Data?.Items == null || !result.Data.Items.Any()) break;

				results.AddRange(result.Data.Items.Where(x => x.TradeTime >= startDate && x.TradeTime <= endDate));

				if (result.Data.Items.Last().TradeTime < startDate) break;
				if (string.IsNullOrEmpty(result.NextKey)) break;

				_client.NextKey = result.NextKey;
				_client.ContYn = true;

				await Task.Delay(_client.PagingDelay, cancellationToken);
			}

			return results;
		}

		/// <summary>
		/// | usa06011 | 미국주식 분 차트
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="tickCount">XX분봉</param>
		/// <param name="startDate">시작일자</param>
		/// <param name="isUpdateStockPrice">수정주가구분</param>
		/// <param name="isApplyExchangeRate">환율적용구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockChartGetMinuteCharts>> GetMinuteChartsAsync(KiwoomUsStockChartExchangeType exchangeType, string stockCode, int tickCount, DateTime? startDate = null, bool isUpdateStockPrice = false, bool isApplyExchangeRate = false, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa06011";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cd", stockCode)
				.AddField("strt_dt", startDate)
				.AddField("tic_scope", tickCount)
				.AddField("upd_stkpc_tp", isUpdateStockPrice)
				.AddField("exrt_appl_tp", isApplyExchangeRate);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockChartGetMinuteCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// 미국주식 분 차트(기간)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="tickCount">XX분봉</param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="isUpdateStockPrice">수정주가구분</param>
		/// <param name="isApplyExchangeRate">환율적용구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<List<KiwoomUsStockChartGetTickChartItem>> GetMinuteChartsByRangeAsync(KiwoomUsStockChartExchangeType exchangeType, string stockCode, int tickCount, DateTime startDate, DateTime endDate, bool isUpdateStockPrice = false, bool isApplyExchangeRate = false, CancellationToken cancellationToken = default)
		{
			var results = new List<KiwoomUsStockChartGetTickChartItem>();
			_client.NextKey = string.Empty;
			_client.ContYn = false;

			while (true)
			{
				var result = await GetMinuteChartsAsync(exchangeType, stockCode, tickCount, endDate, isUpdateStockPrice, isApplyExchangeRate, cancellationToken)
					.ConfigureAwait(false);

				if (result?.Data?.Items == null || !result.Data.Items.Any()) break;

				results.AddRange(result.Data.Items.Where(x => x.TradeTime >= startDate && x.TradeTime <= endDate));

				if (result.Data.Items.Last().TradeTime < startDate) break;
				if (string.IsNullOrEmpty(result.NextKey)) break;

				_client.NextKey = result.NextKey;
				_client.ContYn = true;

				await Task.Delay(_client.PagingDelay, cancellationToken);
			}

			return results;
		}

		/// <summary>
		/// | usa06012 | 미국주식 일 차트
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="startDate">시작일자</param>
		/// <param name="isUpdateStockPrice">수정주가구분</param>
		/// <param name="isApplyExchangeRate">환율적용구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockChartGetDailyCharts>> GetDailyChartsAsync(KiwoomUsStockChartExchangeType exchangeType, string stockCode, DateTime? startDate = null, bool isUpdateStockPrice = false, bool isApplyExchangeRate = false, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa06012";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cd", stockCode)
				.AddField("strt_dt", startDate)
				.AddField("upd_stkpc_tp", isUpdateStockPrice)
				.AddField("exrt_appl_tp", isApplyExchangeRate);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockChartGetDailyCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// 미국주식 일 차트(기간)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="isUpdateStockPrice">수정주가구분</param>
		/// <param name="isApplyExchangeRate">환율적용구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<List<KiwoomUsStockChartGetDailyChartItem>> GetDailyChartsByRangeAsync(KiwoomUsStockChartExchangeType exchangeType, string stockCode, DateTime startDate, DateTime endDate, bool isUpdateStockPrice = false, bool isApplyExchangeRate = false, CancellationToken cancellationToken = default)
		{
			var results = new List<KiwoomUsStockChartGetDailyChartItem>();
			_client.NextKey = string.Empty;
			_client.ContYn = false;

			while (true)
			{
				var result = await GetDailyChartsAsync(exchangeType, stockCode, endDate, isUpdateStockPrice, isApplyExchangeRate, cancellationToken)
					.ConfigureAwait(false);

				if (result?.Data?.Items == null || !result.Data.Items.Any()) break;

				results.AddRange(result.Data.Items.Where(x => x.Date >= startDate && x.Date <= endDate));

				if (result.Data.Items.Last().Date < startDate) break;
				if (string.IsNullOrEmpty(result.NextKey)) break;

				_client.NextKey = result.NextKey;
				_client.ContYn = true;

				await Task.Delay(_client.PagingDelay, cancellationToken);
			}

			return results;
		}

		/// <summary>
		/// | usa06013 | 미국주식 주 차트
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="startDate">시작일자</param>
		/// <param name="isUpdateStockPrice">수정주가구분</param>
		/// <param name="isApplyExchangeRate">환율적용구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockChartGetWeeklyCharts>> GetWeeklyChartsAsync(KiwoomUsStockChartExchangeType exchangeType, string stockCode, DateTime? startDate = null, bool isUpdateStockPrice = false, bool isApplyExchangeRate = false, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa06013";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cd", stockCode)
				.AddField("strt_dt", startDate)
				.AddField("upd_stkpc_tp", isUpdateStockPrice)
				.AddField("exrt_appl_tp", isApplyExchangeRate);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockChartGetWeeklyCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// 미국주식 주 차트(기간)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="isUpdateStockPrice">수정주가구분</param>
		/// <param name="isApplyExchangeRate">환율적용구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<List<KiwoomUsStockChartGetChartItem>> GetWeeklyChartsByRangeAsync(KiwoomUsStockChartExchangeType exchangeType, string stockCode, DateTime startDate, DateTime endDate, bool isUpdateStockPrice = false, bool isApplyExchangeRate = false, CancellationToken cancellationToken = default)
		{
			var results = new List<KiwoomUsStockChartGetChartItem>();
			_client.NextKey = string.Empty;
			_client.ContYn = false;

			while (true)
			{
				var result = await GetWeeklyChartsAsync(exchangeType, stockCode, endDate, isUpdateStockPrice, isApplyExchangeRate, cancellationToken)
					.ConfigureAwait(false);

				if (result?.Data?.Items == null || !result.Data.Items.Any()) break;

				results.AddRange(result.Data.Items.Where(x => x.Date >= startDate && x.Date <= endDate));

				if (result.Data.Items.Last().Date < startDate) break;
				if (string.IsNullOrEmpty(result.NextKey)) break;

				_client.NextKey = result.NextKey;
				_client.ContYn = true;

				await Task.Delay(_client.PagingDelay, cancellationToken);
			}

			return results;
		}

		/// <summary>
		/// | usa06014 | 미국주식 월 차트
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="startDate">시작일자</param>
		/// <param name="isUpdateStockPrice">수정주가구분</param>
		/// <param name="isApplyExchangeRate">환율적용구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockChartGetMonthlyCharts>> GetMonthlyChartsAsync(KiwoomUsStockChartExchangeType exchangeType, string stockCode, DateTime? startDate = null, bool isUpdateStockPrice = false, bool isApplyExchangeRate = false, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa06014";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cd", stockCode)
				.AddField("strt_dt", startDate)
				.AddField("upd_stkpc_tp", isUpdateStockPrice)
				.AddField("exrt_appl_tp", isApplyExchangeRate);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockChartGetMonthlyCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// 미국주식 월 차트(기간)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="isUpdateStockPrice">수정주가구분</param>
		/// <param name="isApplyExchangeRate">환율적용구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<List<KiwoomUsStockChartGetChartItem>> GetMonthlyChartsByRangeAsync(KiwoomUsStockChartExchangeType exchangeType, string stockCode, DateTime startDate, DateTime endDate, bool isUpdateStockPrice = false, bool isApplyExchangeRate = false, CancellationToken cancellationToken = default)
		{
			var results = new List<KiwoomUsStockChartGetChartItem>();
			_client.NextKey = string.Empty;
			_client.ContYn = false;

			while (true)
			{
				var result = await GetMonthlyChartsAsync(exchangeType, stockCode, endDate, isUpdateStockPrice, isApplyExchangeRate, cancellationToken)
					.ConfigureAwait(false);

				if (result?.Data?.Items == null || !result.Data.Items.Any()) break;

				results.AddRange(result.Data.Items.Where(x => x.Date >= startDate && x.Date <= endDate));

				if (result.Data.Items.Last().Date < startDate) break;
				if (string.IsNullOrEmpty(result.NextKey)) break;

				_client.NextKey = result.NextKey;
				_client.ContYn = true;

				await Task.Delay(_client.PagingDelay, cancellationToken);
			}

			return results;
		}

		/// <summary>
		/// | usa06015 | 미국주식 년 차트
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="startDate">시작일자</param>
		/// <param name="isUpdateStockPrice">수정주가구분</param>
		/// <param name="isApplyExchangeRate">환율적용구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockChartGetYearlyCharts>> GetYearlyChartsAsync(KiwoomUsStockChartExchangeType exchangeType, string stockCode, DateTime? startDate = null, bool isUpdateStockPrice = false, bool isApplyExchangeRate = false, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa06015";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cd", stockCode)
				.AddField("strt_dt", startDate)
				.AddField("upd_stkpc_tp", isUpdateStockPrice)
				.AddField("exrt_appl_tp", isApplyExchangeRate);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockChartGetYearlyCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// 미국주식 년 차트(기간)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="isUpdateStockPrice">수정주가구분</param>
		/// <param name="isApplyExchangeRate">환율적용구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<List<KiwoomUsStockChartGetChartItem>> GetYearlyChartsByRangeAsync(KiwoomUsStockChartExchangeType exchangeType, string stockCode, DateTime startDate, DateTime endDate, bool isUpdateStockPrice = false, bool isApplyExchangeRate = false, CancellationToken cancellationToken = default)
		{
			var results = new List<KiwoomUsStockChartGetChartItem>();
			_client.NextKey = string.Empty;
			_client.ContYn = false;

			while (true)
			{
				var result = await GetYearlyChartsAsync(exchangeType, stockCode, endDate, isUpdateStockPrice, isApplyExchangeRate, cancellationToken)
					.ConfigureAwait(false);

				if (result?.Data?.Items == null || !result.Data.Items.Any()) break;

				results.AddRange(result.Data.Items.Where(x => x.Date >= startDate && x.Date <= endDate));

				if (result.Data.Items.Last().Date < startDate) break;
				if (string.IsNullOrEmpty(result.NextKey)) break;

				_client.NextKey = result.NextKey;
				_client.ContYn = true;

				await Task.Delay(_client.PagingDelay, cancellationToken);
			}

			return results;
		}

		/// <summary>
		/// | usa06016 | 미국주식 분기 차트
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="startDate">시작일자</param>
		/// <param name="isUpdateStockPrice">수정주가구분</param>
		/// <param name="isApplyExchangeRate">환율적용구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockChartGetQuarterlyCharts>> GetQuarterlyChartsAsync(KiwoomUsStockChartExchangeType exchangeType, string stockCode, DateTime? startDate = null, bool isUpdateStockPrice = false, bool isApplyExchangeRate = false, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa06016";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cd", stockCode)
				.AddField("strt_dt", startDate)
				.AddField("upd_stkpc_tp", isUpdateStockPrice)
				.AddField("exrt_appl_tp", isApplyExchangeRate);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockChartGetQuarterlyCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// 미국주식 분기 차트(기간)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="isUpdateStockPrice">수정주가구분</param>
		/// <param name="isApplyExchangeRate">환율적용구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<List<KiwoomUsStockChartGetChartItem>> GetQuarterlyChartsByRangeAsync(KiwoomUsStockChartExchangeType exchangeType, string stockCode, DateTime startDate, DateTime endDate, bool isUpdateStockPrice = false, bool isApplyExchangeRate = false, CancellationToken cancellationToken = default)
		{
			var results = new List<KiwoomUsStockChartGetChartItem>();
			_client.NextKey = string.Empty;
			_client.ContYn = false;

			while (true)
			{
				var result = await GetQuarterlyChartsAsync(exchangeType, stockCode, endDate, isUpdateStockPrice, isApplyExchangeRate, cancellationToken)
					.ConfigureAwait(false);

				if (result?.Data?.Items == null || !result.Data.Items.Any()) break;

				results.AddRange(result.Data.Items.Where(x => x.Date >= startDate && x.Date <= endDate));

				if (result.Data.Items.Last().Date < startDate) break;
				if (string.IsNullOrEmpty(result.NextKey)) break;

				_client.NextKey = result.NextKey;
				_client.ContYn = true;

				await Task.Delay(_client.PagingDelay, cancellationToken);
			}

			return results;
		}
	}
}
