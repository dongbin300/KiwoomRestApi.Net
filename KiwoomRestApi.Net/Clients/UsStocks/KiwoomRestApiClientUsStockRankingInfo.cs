using KiwoomRestApi.Net.Enums.UsStock.RankingInfo;
using KiwoomRestApi.Net.Enums.UsStock.StockInfo;
using KiwoomRestApi.Net.Extensions;
using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models.UsStock;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.UsStocks
{
	/// <summary>
	/// 미국주식 순위정보 API 클라이언트
	/// 현재 35개
	/// </summary>
	/// <param name="client"></param>
	public class KiwoomRestApiClientUsStockRankingInfo(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = ApiEndpoint.UsStock.RankingInfo;

		private static string? FormatDecimal(decimal? value) => value?.ToString(CultureInfo.InvariantCulture);

		private static List<KiwoomUsStockInfoWatchlistStock> ToWatchlist(IEnumerable<(KiwoomUsStockInfoExchangeType ExchangeType, string StockCode)> watchlist)
		{
			return watchlist.Select(w => new KiwoomUsStockInfoWatchlistStock
			{
				StockExchangeType = w.ExchangeType.ToEnumString(),
				StockCode = w.StockCode
			}).ToList();
		}

		/// <summary>
		/// | usa01980 | 미국주식 실시간 종목 조회 순위
		/// </summary>
		/// <param name="serviceType">서비스 유형</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockRankingInfoGetRealtimeQueryRanks>> GetRealtimeQueryRanksAsync(KiwoomUsStockRankingInfoServiceType? serviceType = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa01980";
			var body = new HttpParameterMap()
				.AddField("svc_type", serviceType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockRankingInfoGetRealtimeQueryRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa01990 | 미국주식 관심종목 등록 상위
		/// </summary>
		/// <param name="dateUnitType">일,주,월단위구분</param>
		/// <param name="marketType">시장구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockRankingInfoGetWatchlistRegistrationRanks>> GetWatchlistRegistrationRanksAsync(KiwoomUsStockRankingInfoDateUnitType? dateUnitType = null, KiwoomUsStockRankingInfoMarketType? marketType = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa01990";
			var body = new HttpParameterMap()
				.AddField("dt_unit_tp", dateUnitType)
				.AddField("stk_tp", marketType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockRankingInfoGetWatchlistRegistrationRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa20510 | 미국주식 기간별 등락률상위(주식/업종)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="industryCode">업종코드</param>
		/// <param name="stockType">종목구분</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="daysAgo">n일전 구분 (1,5,10,30, 기본값:1)</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="priceCondition">가격조건</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockRankingInfoGetPeriodChangeRateRanks>> GetPeriodChangeRateRanksAsync(KiwoomUsStockInfoRankingExchangeType? exchangeType = null, string? industryCode = null, KiwoomUsStockInfoStockType? stockType = null, KiwoomUsStockInfoStockCondition? stockCondition = null, int? daysAgo = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa20510";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("inds_cd", industryCode)
				.AddField("stk_tp", stockType)
				.AddField("stk_cnd", stockCondition)
				.AddField("tm", daysAgo)
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockRankingInfoGetPeriodChangeRateRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa20511 | 미국주식 기간별 등락률상위(ETF)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="etfCategory1">ETF코드1</param>
		/// <param name="etfCategory2">ETF코드2</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="daysAgo">n일전 구분 (1,5,10,30, 기본값:1)</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="priceCondition">가격조건</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockRankingInfoGetPeriodChangeRateRanks>> GetEtfPeriodChangeRateRanksAsync(KiwoomUsStockInfoRankingExchangeType? exchangeType = null, string? etfCategory1 = null, string? etfCategory2 = null, KiwoomUsStockInfoStockCondition? stockCondition = null, int? daysAgo = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa20511";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("etf_cat1", etfCategory1)
				.AddField("etf_cat2", etfCategory2)
				.AddField("stk_cnd", stockCondition)
				.AddField("tm", daysAgo)
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockRankingInfoGetPeriodChangeRateRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa20512 | 미국주식 기간별 등락률상위(관심종목)
		/// </summary>
		/// <param name="watchlist">관심종목 (거래소구분, 종목코드)</param>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="daysAgo">n일전 설정 (1,5,10,30, 기본값:1)</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="priceCondition">가격조건</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockRankingInfoGetPeriodChangeRateRanks>> GetWatchlistPeriodChangeRateRanksAsync(IEnumerable<(KiwoomUsStockInfoExchangeType ExchangeType, string StockCode)> watchlist, KiwoomUsStockInfoRankingExchangeType? exchangeType = null, int? daysAgo = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa20512";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddRawField("stk_cd", ToWatchlist(watchlist))
				.AddField("tm", daysAgo)
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("stk_cnd", stockCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockRankingInfoGetPeriodChangeRateRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa20530 | 미국주식 당일 거래량 상위(주식/업종)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="industryCode">업종코드</param>
		/// <param name="stockType">종목구분</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="sortType">정렬기준구분</param>
		/// <param name="stockCondition">종목필터구분</param>
		/// <param name="priceCondition">검색가격대구분</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockRankingInfoGetVolumeRanks>> GetVolumeRanksAsync(KiwoomUsStockInfoRankingExchangeType? exchangeType = null, string? industryCode = null, KiwoomUsStockInfoStockType? stockType = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, KiwoomUsStockRankingInfoSortType? sortType = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa20530";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("inds_cd", industryCode)
				.AddField("stk_tp", stockType)
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("qry_tp", sortType)
				.AddField("stk_cnd", stockCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockRankingInfoGetVolumeRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa20531 | 미국주식 당일 거래량 상위(ETF)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="etfCategory1">ETF카테고리코드1</param>
		/// <param name="etfCategory2">ETF카테고리코드2</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="sortType">정렬기준구분</param>
		/// <param name="stockCondition">종목필터구분</param>
		/// <param name="priceCondition">검색가격대구분</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockRankingInfoGetVolumeRanks>> GetEtfVolumeRanksAsync(KiwoomUsStockInfoRankingExchangeType? exchangeType = null, string? etfCategory1 = null, string? etfCategory2 = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, KiwoomUsStockRankingInfoSortType? sortType = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa20531";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("etf_cat1", etfCategory1)
				.AddField("etf_cat2", etfCategory2)
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("qry_tp", sortType)
				.AddField("stk_cnd", stockCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockRankingInfoGetVolumeRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa20540 | 미국주식 당일 거래대금 상위(주식/업종)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="industryCode">업종코드</param>
		/// <param name="stockType">종목구분</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="stockCondition">종목필터구분</param>
		/// <param name="priceCondition">검색가격대구분</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockRankingInfoGetTransactionAmountRanks>> GetTransactionAmountRanksAsync(KiwoomUsStockInfoRankingExchangeType? exchangeType = null, string? industryCode = null, KiwoomUsStockInfoStockType? stockType = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa20540";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("inds_cd", industryCode)
				.AddField("stk_tp", stockType)
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("stk_cnd", stockCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockRankingInfoGetTransactionAmountRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa20541 | 미국주식 당일 거래대금 상위(ETF)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="etfCategory1">ETF카테고리코드1</param>
		/// <param name="etfCategory2">ETF카테고리코드2</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="stockCondition">종목필터구분</param>
		/// <param name="priceCondition">검색가격대구분</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockRankingInfoGetTransactionAmountRanks>> GetEtfTransactionAmountRanksAsync(KiwoomUsStockInfoRankingExchangeType? exchangeType = null, string? etfCategory1 = null, string? etfCategory2 = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa20541";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("etf_cat1", etfCategory1)
				.AddField("etf_cat2", etfCategory2)
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("stk_cnd", stockCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockRankingInfoGetTransactionAmountRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa20550 | 미국주식 시가총액상위(주식/업종)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="industryCode">업종코드</param>
		/// <param name="stockType">종목구분</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="stockCondition">종목필터구분</param>
		/// <param name="priceCondition">검색가격대구분</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockRankingInfoGetMarketCapRanks>> GetMarketCapRanksAsync(KiwoomUsStockInfoRankingExchangeType? exchangeType = null, string? industryCode = null, KiwoomUsStockInfoStockType? stockType = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa20550";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("inds_cd", industryCode)
				.AddField("stk_tp", stockType)
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("stk_cnd", stockCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockRankingInfoGetMarketCapRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa20551 | 미국주식 시가총액상위(ETF)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="etfCategory1">ETF카테고리코드1</param>
		/// <param name="etfCategory2">ETF카테고리코드2</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="stockCondition">종목필터구분</param>
		/// <param name="priceCondition">검색가격대구분</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockRankingInfoGetMarketCapRanks>> GetEtfMarketCapRanksAsync(KiwoomUsStockInfoRankingExchangeType? exchangeType = null, string? etfCategory1 = null, string? etfCategory2 = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa20551";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("etf_cat1", etfCategory1)
				.AddField("etf_cat2", etfCategory2)
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("stk_cnd", stockCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockRankingInfoGetMarketCapRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa20880 | 키움 거래 상위 종목(미국주식)
		/// </summary>
		/// <param name="queryType">조회구분</param>
		/// <param name="dateUnitType">일,주,월단위구분 (분단위 포함)</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockRankingInfoGetKiwoomTradeRanks>> GetKiwoomTradeRanksAsync(KiwoomUsStockRankingInfoKiwoomQueryType? queryType = null, KiwoomUsStockRankingInfoKiwoomDateUnitType? dateUnitType = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa20880";
			var body = new HttpParameterMap()
				.AddField("qry_tp", queryType)
				.AddField("dt_unit_tp", dateUnitType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockRankingInfoGetKiwoomTradeRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa20881 | 키움 거래 상위 종목(미국 ETF)
		/// </summary>
		/// <param name="queryType">조회구분</param>
		/// <param name="dateUnitType">일,주,월단위구분 (분단위 포함)</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockRankingInfoGetKiwoomTradeRanks>> GetEtfKiwoomTradeRanksAsync(KiwoomUsStockRankingInfoKiwoomQueryType? queryType = null, KiwoomUsStockRankingInfoKiwoomDateUnitType? dateUnitType = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa20881";
			var body = new HttpParameterMap()
				.AddField("qry_tp", queryType)
				.AddField("dt_unit_tp", dateUnitType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockRankingInfoGetKiwoomTradeRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa20910 | 미국주식 전일대비 등락률상위(주식/업종)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="industryCode">업종코드</param>
		/// <param name="industryClassType">미국업종구분 (stk_tp가 0일 경우)</param>
		/// <param name="sortType">정렬기준</param>
		/// <param name="stockType">종목구분</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="priceCondition">가격조건</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockRankingInfoGetChangeRateRanks>> GetChangeRateRanksAsync(KiwoomUsStockInfoRankingExchangeType? exchangeType = null, string? industryCode = null, KiwoomUsStockRankingInfoIndustryClassType? industryClassType = null, KiwoomUsStockRankingInfoChangeSortType? sortType = null, KiwoomUsStockInfoStockType? stockType = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa20910";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("inds_cd", industryCode)
				.AddField("inds_cls_tp", industryClassType)
				.AddField("sort_tp", sortType)
				.AddField("stk_tp", stockType)
				.AddField("stk_cnd", stockCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition)
				.AddField("trde_qty_tp", tradeVolumeCondition);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockRankingInfoGetChangeRateRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa20911 | 미국주식 전일대비 등락률상위(ETF)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="etfCategory1">ETF카테고리코드1</param>
		/// <param name="etfCategory2">ETF카테고리코드2</param>
		/// <param name="sortType">정렬기준</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="priceCondition">가격조건</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockRankingInfoGetChangeRateRanks>> GetEtfChangeRateRanksAsync(KiwoomUsStockInfoRankingExchangeType? exchangeType = null, string? etfCategory1 = null, string? etfCategory2 = null, KiwoomUsStockRankingInfoChangeSortType? sortType = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa20911";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("etf_cat1", etfCategory1)
				.AddField("etf_cat2", etfCategory2)
				.AddField("sort_tp", sortType)
				.AddField("stk_cnd", stockCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition)
				.AddField("trde_qty_tp", tradeVolumeCondition);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockRankingInfoGetChangeRateRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa20920 | 미국주식 시가대비 등락률상위(주식/업종)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="industryCode">업종코드</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="stockType">종목구분</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="priceCondition">가격조건</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="sortType">정렬기준</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockRankingInfoGetOpenPriceChangeRateRanks>> GetOpenPriceChangeRateRanksAsync(KiwoomUsStockInfoRankingExchangeType? exchangeType = null, string? industryCode = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, KiwoomUsStockInfoStockType? stockType = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, KiwoomUsStockRankingInfoUpDownSortType? sortType = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa20920";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("inds_cd", industryCode)
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("stk_tp", stockType)
				.AddField("stk_cnd", stockCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition)
				.AddField("sort_tp", sortType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockRankingInfoGetOpenPriceChangeRateRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa20921 | 미국주식 시가대비 등락률상위(ETF)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="etfCategory1">ETF카테고리코드1</param>
		/// <param name="etfCategory2">ETF카테고리코드2</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="priceCondition">가격조건</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="sortType">정렬기준</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockRankingInfoGetOpenPriceChangeRateRanks>> GetEtfOpenPriceChangeRateRanksAsync(KiwoomUsStockInfoRankingExchangeType? exchangeType = null, string? etfCategory1 = null, string? etfCategory2 = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, KiwoomUsStockRankingInfoUpDownSortType? sortType = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa20921";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("etf_cat1", etfCategory1)
				.AddField("etf_cat2", etfCategory2)
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("stk_cnd", stockCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition)
				.AddField("sort_tp", sortType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockRankingInfoGetOpenPriceChangeRateRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa20922 | 미국주식 시가대비 등락률상위(관심종목)
		/// </summary>
		/// <param name="watchlist">관심종목 (거래소구분, 종목코드)</param>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="sortType">정렬기준</param>
		/// <param name="stockType">종목구분</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="priceCondition">가격조건</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockRankingInfoGetOpenPriceChangeRateRanks>> GetWatchlistOpenPriceChangeRateRanksAsync(IEnumerable<(KiwoomUsStockInfoExchangeType ExchangeType, string StockCode)> watchlist, KiwoomUsStockInfoRankingExchangeType? exchangeType = null, KiwoomUsStockRankingInfoUpDownSortType? sortType = null, KiwoomUsStockRankingInfoStockType? stockType = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa20922";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddRawField("stk_cd", ToWatchlist(watchlist))
				.AddField("sort_tp", sortType)
				.AddField("stk_tp", stockType)
				.AddField("stk_cnd", stockCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition)
				.AddField("trde_qty_tp", tradeVolumeCondition);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockRankingInfoGetOpenPriceChangeRateRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa20940 | 미국주식 누적 등락률 상위(주식/업종)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="industryCode">업종코드</param>
		/// <param name="stockType">종목구분</param>
		/// <param name="sortType">정렬기준구분</param>
		/// <param name="priceStart">가격1 구분</param>
		/// <param name="priceEnd">가격2 구분</param>
		/// <param name="baseDate">기준일자</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="priceCondition">검색가격대구분</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockRankingInfoGetCumulativeChangeRateRanks>> GetCumulativeChangeRateRanksAsync(KiwoomUsStockInfoRankingExchangeType2? exchangeType = null, string? industryCode = null, KiwoomUsStockInfoStockType? stockType = null, KiwoomUsStockRankingInfoCumulativeSortType? sortType = null, decimal? priceStart = null, decimal? priceEnd = null, DateTime? baseDate = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa20940";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("inds_cd", industryCode)
				.AddField("stk_tp", stockType)
				.AddField("sort_tp", sortType)
				.AddField("pric_cnd1", FormatDecimal(priceStart))
				.AddField("pric_cnd2", FormatDecimal(priceEnd))
				.AddField("base_dt", baseDate)
				.AddField("stk_cnd", stockCondition)
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockRankingInfoGetCumulativeChangeRateRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa20941 | 미국주식 누적 등락률 상위(ETF)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="etfCategory1">ETF카테고리코드1</param>
		/// <param name="etfCategory2">ETF카테고리코드2</param>
		/// <param name="sortType">정렬기준구분</param>
		/// <param name="priceStart">가격1 구분</param>
		/// <param name="priceEnd">가격2 구분</param>
		/// <param name="baseDate">기준일자</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="priceCondition">검색가격대구분</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockRankingInfoGetCumulativeChangeRateRanks>> GetEtfCumulativeChangeRateRanksAsync(KiwoomUsStockInfoRankingExchangeType2? exchangeType = null, string? etfCategory1 = null, string? etfCategory2 = null, KiwoomUsStockRankingInfoCumulativeSortType? sortType = null, decimal? priceStart = null, decimal? priceEnd = null, DateTime? baseDate = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa20941";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("etf_cat1", etfCategory1)
				.AddField("etf_cat2", etfCategory2)
				.AddField("sort_tp", sortType)
				.AddField("pric_cnd1", FormatDecimal(priceStart))
				.AddField("pric_cnd2", FormatDecimal(priceEnd))
				.AddField("base_dt", baseDate)
				.AddField("stk_cnd", stockCondition)
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockRankingInfoGetCumulativeChangeRateRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa20960 | 미국주식 전일 거래상위(주식/업종)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="industryCode">업종코드</param>
		/// <param name="stockType">종목구분</param>
		/// <param name="sortType">정렬기준구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockRankingInfoGetPreviousDayTradeRanks>> GetPreviousDayTradeRanksAsync(KiwoomUsStockInfoRankingExchangeType2? exchangeType = null, string? industryCode = null, KiwoomUsStockInfoStockType? stockType = null, KiwoomUsStockRankingInfoPreviousDaySortType? sortType = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa20960";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("inds_cd", industryCode)
				.AddField("stk_tp", stockType)
				.AddField("qry_tp", sortType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockRankingInfoGetPreviousDayTradeRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa20961 | 미국주식 전일 거래상위(ETF)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="etfCategory1">ETF카테고리코드1</param>
		/// <param name="etfCategory2">ETF카테고리코드2</param>
		/// <param name="sortType">정렬기준구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockRankingInfoGetPreviousDayTradeRanks>> GetEtfPreviousDayTradeRanksAsync(KiwoomUsStockInfoRankingExchangeType2? exchangeType = null, string? etfCategory1 = null, string? etfCategory2 = null, KiwoomUsStockRankingInfoPreviousDaySortType? sortType = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa20961";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("etf_cat1", etfCategory1)
				.AddField("etf_cat2", etfCategory2)
				.AddField("qry_tp", sortType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockRankingInfoGetPreviousDayTradeRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa24110 | 미국주식 최고최저가대비 상승하락(주식/업종)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="industryCode">업종코드</param>
		/// <param name="stockType">종목구분</param>
		/// <param name="sortType">정렬기준구분</param>
		/// <param name="periodType">기간구분</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="priceCondition">가격조건</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockRankingInfoGetHighLowChangeRanks>> GetHighLowChangeRanksAsync(KiwoomUsStockInfoRankingExchangeType2? exchangeType = null, string? industryCode = null, KiwoomUsStockInfoStockType? stockType = null, KiwoomUsStockRankingInfoHighLowSortType? sortType = null, KiwoomUsStockRankingInfoPeriodType? periodType = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa24110";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("inds_cd", industryCode)
				.AddField("stk_tp", stockType)
				.AddField("sort_tp", sortType)
				.AddField("dt_tp", periodType)
				.AddField("stk_cnd", stockCondition)
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockRankingInfoGetHighLowChangeRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa24111 | 미국주식 최고최저가대비 상승하락(ETF)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="etfCategory1">ETF카테고리코드1</param>
		/// <param name="etfCategory2">ETF카테고리코드2</param>
		/// <param name="sortType">정렬기준구분</param>
		/// <param name="periodType">기간구분</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="priceCondition">가격조건</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockRankingInfoGetHighLowChangeRanks>> GetEtfHighLowChangeRanksAsync(KiwoomUsStockInfoRankingExchangeType2? exchangeType = null, string? etfCategory1 = null, string? etfCategory2 = null, KiwoomUsStockRankingInfoHighLowSortType? sortType = null, KiwoomUsStockRankingInfoPeriodType? periodType = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa24111";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("etf_cat1", etfCategory1)
				.AddField("etf_cat2", etfCategory2)
				.AddField("sort_tp", sortType)
				.AddField("dt_tp", periodType)
				.AddField("stk_cnd", stockCondition)
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockRankingInfoGetHighLowChangeRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa24120 | 미국주식 특정일자 상승/하락(주식/업종)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="industryCode">업종코드</param>
		/// <param name="stockType">종목구분</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="priceCondition">가격조건</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="baseDate">기간</param>
		/// <param name="sortType">정렬기준구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockRankingInfoGetSpecificDayChangeRanks>> GetSpecificDayChangeRanksAsync(KiwoomUsStockInfoRankingExchangeType2? exchangeType = null, string? industryCode = null, KiwoomUsStockInfoStockType? stockType = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, DateTime? baseDate = null, KiwoomUsStockRankingInfoSpecificDaySortType? sortType = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa24120";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("inds_cd", industryCode)
				.AddField("stk_tp", stockType)
				.AddField("stk_cnd", stockCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition)
				.AddField("base_dt", baseDate)
				.AddField("sort_tp", sortType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockRankingInfoGetSpecificDayChangeRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa24121 | 미국주식 특정일자 상승/하락(ETF)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="etfCategory1">ETF카테고리코드1</param>
		/// <param name="etfCategory2">ETF카테고리코드2</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="priceCondition">가격조건</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="baseDate">기간</param>
		/// <param name="sortType">정렬기준구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockRankingInfoGetSpecificDayChangeRanks>> GetEtfSpecificDayChangeRanksAsync(KiwoomUsStockInfoRankingExchangeType2? exchangeType = null, string? etfCategory1 = null, string? etfCategory2 = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, DateTime? baseDate = null, KiwoomUsStockRankingInfoSpecificDaySortType? sortType = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa24121";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("etf_cat1", etfCategory1)
				.AddField("etf_cat2", etfCategory2)
				.AddField("stk_cnd", stockCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition)
				.AddField("base_dt", baseDate)
				.AddField("sort_tp", sortType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockRankingInfoGetSpecificDayChangeRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa24150 | 미국주식 회전율 상위(주식/업종)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="industryCode">업종코드</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="stockType">종목구분</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="priceCondition">가격조건</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockRankingInfoGetTurnoverRateRanks>> GetTurnoverRateRanksAsync(KiwoomUsStockInfoRankingExchangeType? exchangeType = null, string? industryCode = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, KiwoomUsStockInfoStockType? stockType = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa24150";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("inds_cd", industryCode)
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("stk_tp", stockType)
				.AddField("stk_cnd", stockCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockRankingInfoGetTurnoverRateRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa24151 | 미국주식 회전율 상위(ETF)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="etfCategory1">ETF카테고리코드1</param>
		/// <param name="etfCategory2">ETF카테고리코드2</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="priceCondition">가격조건</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockRankingInfoGetTurnoverRateRanks>> GetEtfTurnoverRateRanksAsync(KiwoomUsStockInfoRankingExchangeType? exchangeType = null, string? etfCategory1 = null, string? etfCategory2 = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa24151";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("etf_cat1", etfCategory1)
				.AddField("etf_cat2", etfCategory2)
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("stk_cnd", stockCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockRankingInfoGetTurnoverRateRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa24160 | 미국주식 연속상승/하락 순위(주식/업종)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="industryCode">업종코드</param>
		/// <param name="stockType">종목구분</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="priceCondition">가격조건</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="sortType">정렬기준</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockRankingInfoGetContinuousChangeRanks>> GetContinuousChangeRanksAsync(KiwoomUsStockInfoRankingExchangeType2? exchangeType = null, string? industryCode = null, KiwoomUsStockInfoStockType? stockType = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, KiwoomUsStockRankingInfoContinuousSortType? sortType = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa24160";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("inds_cd", industryCode)
				.AddField("stk_tp", stockType)
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("stk_cnd", stockCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition)
				.AddField("sort_tp", sortType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockRankingInfoGetContinuousChangeRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa24162 | 미국주식 연속상승/하락 순위(관심종목)
		/// </summary>
		/// <param name="watchlist">관심종목 (거래소구분, 종목코드)</param>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="priceCondition">가격조건</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="sortType">정렬기준</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockRankingInfoGetWatchlistContinuousChangeRanks>> GetWatchlistContinuousChangeRanksAsync(IEnumerable<(KiwoomUsStockInfoExchangeType ExchangeType, string StockCode)> watchlist, KiwoomUsStockInfoRankingExchangeType2? exchangeType = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, KiwoomUsStockRankingInfoContinuousSortType? sortType = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa24162";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddRawField("stk_cd", ToWatchlist(watchlist))
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("stk_cnd", stockCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition)
				.AddField("sort_tp", sortType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockRankingInfoGetWatchlistContinuousChangeRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa24200 | 미국주식 호가잔량상위(주식/업종)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="industryCode">업종코드</param>
		/// <param name="stockType">종목구분</param>
		/// <param name="sortType">정렬기준</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="priceCondition">가격조건</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockRankingInfoGetOrderBookRanks>> GetOrderBookRanksAsync(KiwoomUsStockInfoRankingExchangeType? exchangeType = null, string? industryCode = null, KiwoomUsStockInfoStockType? stockType = null, KiwoomUsStockRankingInfoOrderBookSortType? sortType = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa24200";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("inds_cd", industryCode)
				.AddField("stk_tp", stockType)
				.AddField("sort_tp", sortType)
				.AddField("stk_cnd", stockCondition)
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockRankingInfoGetOrderBookRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa24290 | 미국주식 주간거래 괴리율 상위(주식/업종)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="industryCode">업종코드</param>
		/// <param name="industryClassType">해외주식업종분류구분</param>
		/// <param name="stockType">종목구분</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="priceCondition">가격조건</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="sortType">정렬기준구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockRankingInfoGetDisparityRateRanks>> GetDisparityRateRanksAsync(KiwoomUsStockInfoRankingExchangeType2? exchangeType = null, string? industryCode = null, KiwoomUsStockRankingInfoIndustryClassType? industryClassType = null, KiwoomUsStockInfoStockType? stockType = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, KiwoomUsStockRankingInfoDisparityRateSortType? sortType = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa24290";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("inds_cd", industryCode)
				.AddField("inds_cls_tp", industryClassType)
				.AddField("stk_tp", stockType)
				.AddField("stk_cnd", stockCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition)
				.AddField("sort_tp", sortType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockRankingInfoGetDisparityRateRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa24291 | 미국주식 주간거래 괴리율 상위(ETF)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="etfCategory1">ETF카테고리코드1</param>
		/// <param name="etfCategory2">ETF카테고리코드2</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="priceCondition">가격조건</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="sortType">정렬기준구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockRankingInfoGetDisparityRateRanks>> GetEtfDisparityRateRanksAsync(KiwoomUsStockInfoRankingExchangeType2? exchangeType = null, string? etfCategory1 = null, string? etfCategory2 = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, KiwoomUsStockRankingInfoDisparityRateSortType? sortType = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa24291";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("etf_cat1", etfCategory1)
				.AddField("etf_cat2", etfCategory2)
				.AddField("stk_cnd", stockCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition)
				.AddField("sort_tp", sortType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockRankingInfoGetDisparityRateRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa24201 | 미국주식 호가잔량상위(ETF)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="etfCategory1">ETF카테고리코드1</param>
		/// <param name="etfCategory2">ETF카테고리코드2</param>
		/// <param name="sortType">정렬기준</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="priceCondition">가격조건</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockRankingInfoGetOrderBookRanks>> GetEtfOrderBookRanksAsync(KiwoomUsStockInfoRankingExchangeType? exchangeType = null, string? etfCategory1 = null, string? etfCategory2 = null, KiwoomUsStockRankingInfoOrderBookSortType? sortType = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa24201";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("etf_cat1", etfCategory1)
				.AddField("etf_cat2", etfCategory2)
				.AddField("sort_tp", sortType)
				.AddField("stk_cnd", stockCondition)
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockRankingInfoGetOrderBookRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa24161 | 미국주식 연속상승/하락 순위(ETF)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="etfCategory1">ETF카테고리코드1</param>
		/// <param name="etfCategory2">ETF카테고리코드2</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="priceCondition">가격조건</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="sortType">정렬기준</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockRankingInfoGetContinuousChangeRanks>> GetEtfContinuousChangeRanksAsync(KiwoomUsStockInfoRankingExchangeType2? exchangeType = null, string? etfCategory1 = null, string? etfCategory2 = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, KiwoomUsStockRankingInfoContinuousSortType? sortType = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa24161";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("etf_cat1", etfCategory1)
				.AddField("etf_cat2", etfCategory2)
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("stk_cnd", stockCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition)
				.AddField("sort_tp", sortType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockRankingInfoGetContinuousChangeRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}
	}
}
