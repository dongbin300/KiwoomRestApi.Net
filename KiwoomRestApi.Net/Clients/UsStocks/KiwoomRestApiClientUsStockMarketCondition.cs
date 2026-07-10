using KiwoomRestApi.Net.Enums.UsStock.MarketCondition;
using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models.UsStock;

using System;
using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.UsStocks
{
	/// <summary>
	/// 미국주식 시세 API 클라이언트
	/// 현재 5개
	/// </summary>
	/// <param name="client"></param>
	public class KiwoomRestApiClientUsStockMarketCondition(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = ApiEndpoint.UsStock.MarketCondition;

		/// <summary>
		/// | usa20100 | 미국주식 현재가 종목정보
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockMarketConditionGetStockInfo>> GetStockInfoAsync(KiwoomUsStockMarketConditionExchangeType exchangeType, string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa20100";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockMarketConditionGetStockInfo>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa20101 | 미국주식 현재가 10호가
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockMarketConditionGetOrderBook>> GetOrderBookAsync(KiwoomUsStockMarketConditionExchangeType exchangeType, string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa20101";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockMarketConditionGetOrderBook>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa20150 | 미국주식 상세 체결내역
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockMarketConditionGetDetailedTrades>> GetDetailedTradesAsync(KiwoomUsStockMarketConditionExchangeType exchangeType, string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa20150";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockMarketConditionGetDetailedTrades>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa20151 | 미국주식 일별 체결내역
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="baseDate">기준일자 (이전 내역 조회)</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockMarketConditionGetDailyTrades>> GetDailyTradesAsync(KiwoomUsStockMarketConditionExchangeType exchangeType, string stockCode, DateTime? baseDate = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa20151";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cd", stockCode)
				.AddField("base_dt", baseDate);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockMarketConditionGetDailyTrades>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa20590 | 미국주식 일별주가
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="baseDate">기준일자 (이전 내역 조회)</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockMarketConditionGetDailyPrices>> GetDailyPricesAsync(KiwoomUsStockMarketConditionExchangeType? exchangeType = null, string? stockCode = null, DateTime? baseDate = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa20590";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cd", stockCode)
				.AddField("base_dt", baseDate);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockMarketConditionGetDailyPrices>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}
	}
}
