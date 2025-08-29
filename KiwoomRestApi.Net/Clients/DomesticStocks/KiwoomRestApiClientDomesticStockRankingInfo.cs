using KiwoomRestApi.Net.Enums.RankingInfo;
using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models;

using System;
using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.DomesticStocks
{
	/// <summary>
	/// 순위정보 API 클라이언트
	/// </summary>
	/// <param name="client"></param>
	public class KiwoomRestApiClientDomesticStockRankingInfo(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = ApiEndpoint.DomesticStock.RankingInfo;

		/// <summary>
		/// | ka10020 | 호가잔량상위요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="sortType"></param>
		/// <param name="minVolume"></param>
		/// <param name="stockCondition"></param>
		/// <param name="creditCondition"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetBidRequestUppers>> GetBidRequestUppersAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoSortType sortType, decimal minVolume, KiwoomRankingInfoStockCondition stockCondition, KiwoomRankingInfoCreditCondition creditCondition, KiwoomRankingInfoStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10020";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("sort_tp", sortType)
				.AddField("trde_qty_tp", minVolume / 1000)
				.AddField("stk_cnd", stockCondition)
				.AddField("crd_cnd", creditCondition)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetBidRequestUppers>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10021 | 호가잔량급증요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="tradeType"></param>
		/// <param name="sortType"></param>
		/// <param name="minVolume"></param>
		/// <param name="stockCondition"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="timeMinute"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetBidRequestSuddenIncreases>> GetBidRequestSuddenIncreasesAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoTradeType tradeType, KiwoomRankingInfoSuddenIncreaseSortType sortType, decimal minVolume, KiwoomRankingInfoStockCondition stockCondition, KiwoomRankingInfoStockExchangeType stockExchangeType, int timeMinute, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10021";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("trde_tp", tradeType)
				.AddField("sort_tp", sortType)
				.AddField("trde_qty_tp", minVolume / 1000)
				.AddField("stk_cnd", stockCondition)
				.AddField("stex_tp", stockExchangeType)
				.AddField("tm_tp", timeMinute);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetBidRequestSuddenIncreases>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10022 | 잔량율급증요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="ratioType"></param>
		/// <param name="minVolume"></param>
		/// <param name="stockCondition"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="timeMinute"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetRequestRateSuddenIncreases>> GetRequestRateSuddenIncreasesAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoRatioType ratioType, decimal minVolume, KiwoomRankingInfoStockCondition stockCondition, KiwoomRankingInfoStockExchangeType stockExchangeType, int timeMinute, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10022";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("rt_tp", ratioType)
				.AddField("trde_qty_tp", minVolume / 1000)
				.AddField("stk_cnd", stockCondition)
				.AddField("stex_tp", stockExchangeType)
				.AddField("tm_tp", timeMinute);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetRequestRateSuddenIncreases>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10023 | 거래량급증요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="sortType"></param>
		/// <param name="timeType"></param>
		/// <param name="tradeQuantityType"></param>
		/// <param name="stockCondition"></param>
		/// <param name="priceType"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="timeMinute"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetTradedQuantitySuddenIncreases>> GetTradedQuantitySuddenIncreasesAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoSuddenIncreaseSortType sortType, KiwoomRankingInfoTimeType timeType, decimal minVolume, KiwoomRankingInfoStockCondition stockCondition, KiwoomRankingInfoPriceType priceType, KiwoomRankingInfoStockExchangeType stockExchangeType, int timeMinute, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10023";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("sort_tp", sortType)
				.AddField("tm_tp", timeType)
				.AddField("trde_qty_tp", minVolume / 1000)
				.AddField("stk_cnd", stockCondition)
				.AddField("pric_tp", priceType)
				.AddField("stex_tp", stockExchangeType)
				.AddField("tm", timeMinute);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetTradedQuantitySuddenIncreases>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10027 | 전일대비등락률상위요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="sortType"></param>
		/// <param name="minVolume"></param>
		/// <param name="stockCondition"></param>
		/// <param name="creditCondition"></param>
		/// <param name="isIncludeUpDown"></param>
		/// <param name="priceCondition"></param>
		/// <param name="minTransactionAmount"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetPreviousDayFluctuationRateUppers>> GetPreviousDayFluctuationRateUppersAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoFluctuationSortType sortType, decimal minVolume, KiwoomRankingInfoStockCondition stockCondition, KiwoomRankingInfoCreditCondition creditCondition,
bool isIncludeUpDown, KiwoomRankingInfoPriceCondition priceCondition, decimal minTransactionAmount, KiwoomRankingInfoStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10027";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("sort_tp", sortType)
				.AddField("trde_qty_cnd", minVolume / 1000)
				.AddField("stk_cnd", stockCondition)
				.AddField("crd_cnd", creditCondition)
				.AddField("updown_incls", isIncludeUpDown)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_prica_cnd", minTransactionAmount / 10_000_000)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetPreviousDayFluctuationRateUppers>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10029 | 예상체결등락률상위요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="sortType"></param>
		/// <param name="minVolume"></param>
		/// <param name="stockCondition"></param>
		/// <param name="creditCondition"></param>
		/// <param name="priceCondition"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetExpectedContractFluctuationRateUppers>> GetExpectedContractFluctuationRateUppersAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoContractFluctuationSortType sortType, decimal minVolume, KiwoomRankingInfoStockCondition stockCondition, KiwoomRankingInfoCreditCondition creditCondition,
KiwoomRankingInfoPriceCondition priceCondition, KiwoomRankingInfoStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10029";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("sort_tp", sortType)
				.AddField("trde_qty_cnd", minVolume / 1000)
				.AddField("stk_cnd", stockCondition)
				.AddField("crd_cnd", creditCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetExpectedContractFluctuationRateUppers>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10030 | 당일거래량상위요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="sortType"></param>
		/// <param name="stockCondition"></param>
		/// <param name="creditCondition"></param>
		/// <param name="minVolume"></param>
		/// <param name="priceCondition"></param>
		/// <param name="minTransactionAmount"></param>
		/// <param name="marketOpenType"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetTodayTradeQuantityUppers>> GetTodayTradeQuantityUppersAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoTradeQuantitySortType sortType, KiwoomRankingInfoStockCondition stockCondition, KiwoomRankingInfoCreditCondition creditCondition, decimal minVolume,
KiwoomRankingInfoPriceCondition2 priceCondition, decimal minTransactionAmount, KiwoomRankingInfoMarketOpenType marketOpenType, KiwoomRankingInfoStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10030";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("sort_tp", sortType)
				.AddField("mang_stk_incls", stockCondition)
				.AddField("crd_tp", creditCondition)
				.AddField("trde_qty_tp", minVolume / 1000)
				.AddField("pric_tp", priceCondition)
				.AddField("trde_prica_tp", minTransactionAmount / 10_000_000)
				.AddField("mrkt_open_tp", marketOpenType)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetTodayTradeQuantityUppers>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10031 | 전일거래량상위요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="queryType"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="startRank"></param>
		/// <param name="endRank"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetPreviousTradeQuantityUppers>> GetPreviousTradeQuantityUppersAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoPreviousTradeQuantityQueryType queryType, KiwoomRankingInfoStockExchangeType stockExchangeType, int startRank, int endRank, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10031";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("qry_tp", queryType)
				.AddField("stex_tp", stockExchangeType)
				.AddField("rank_strt", startRank)
				.AddField("rank_end", endRank);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetPreviousTradeQuantityUppers>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10032 | 거래대금상위요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="isIncludeManagedStock"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetTradePriceUppers>> GetTradePriceUppersAsync(KiwoomRankingInfoMarketType marketType, bool isIncludeManagedStock, KiwoomRankingInfoStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10032";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("mang_stk_incls", isIncludeManagedStock)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetTradePriceUppers>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10033 | 신용비율상위요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="minVolume"></param>
		/// <param name="stockCondition"></param>
		/// <param name="isIncludeUpDown"></param>
		/// <param name="creditCondition"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetCreditRateUppers>> GetCreditRateUppersAsync(KiwoomRankingInfoMarketType marketType, decimal minVolume, KiwoomRankingInfoStockCondition stockCondition, bool isIncludeUpDown, KiwoomRankingInfoCreditCondition creditCondition, KiwoomRankingInfoStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10033";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("trde_qty_tp", minVolume / 1000)
				.AddField("stk_cnd", stockCondition)
				.AddField("updown_incls", isIncludeUpDown)
				.AddField("crd_cnd", creditCondition)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetCreditRateUppers>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10034 | 외인기간별매매상위요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="tradeType"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="period"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetForeignTradePerPeriodUppers>> GetForeignTradePerPeriodUppersAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoNetTradeType tradeType, KiwoomRankingInfoStockExchangeType stockExchangeType, int period, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10034";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("trde_tp", tradeType)
				.AddField("stex_tp", stockExchangeType)
				.AddField("dt", period);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetForeignTradePerPeriodUppers>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10035 | 외인연속순매매상위요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="tradeType"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="period"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetForeignContinuousNetTradeUppers>> GetForeignContinuousNetTradeUppersAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoContinuousNetTradeType tradeType, KiwoomRankingInfoStockExchangeType stockExchangeType, int period, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10035";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("trde_tp", tradeType)
				.AddField("stex_tp", stockExchangeType)
				.AddField("base_dt_tp", period);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetForeignContinuousNetTradeUppers>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10036 | 외인한도소진율증가상위
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="period"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetForeignLimitExhaustionRateIncreases>> GetForeignLimitExhaustionRateIncreasesAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoStockExchangeType stockExchangeType, int period, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10036";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("stex_tp", stockExchangeType)
				.AddField("dt", period);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetForeignLimitExhaustionRateIncreases>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10037 | 외국계창구매매상위요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="tradeType"></param>
		/// <param name="sortType"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="period"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetForeignWicketTradeUppers>> GetForeignWicketTradeUppersAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoForeignWicketTradeType tradeType, KiwoomRankingInfoAmountQuantityType sortType, KiwoomRankingInfoStockExchangeType stockExchangeType, int period, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10037";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("trde_tp", tradeType)
				.AddField("sort_tp", sortType)
				.AddField("stex_tp", stockExchangeType)
				.AddField("dt", period);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetForeignWicketTradeUppers>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10038 | 종목별증권사순위요청
		/// </summary>
		/// <param name="queryType"></param>
		/// <param name="stockCode"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="period"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetStockSecuritiesRanks>> GetStockSecuritiesRanksAsync(KiwoomRankingInfoSecuritiesRankQueryType queryType, string stockCode, DateTime startDate, DateTime endDate, int period, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10038";
			var body = new HttpParameterMap()
				.AddField("qry_tp", queryType)
				.AddField("stk_cd", stockCode)
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate)
				.AddField("dt", period - 1);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetStockSecuritiesRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10039 | 증권사별매매상위요청
		/// </summary>
		/// <param name="minVolume"></param>
		/// <param name="tradeType"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="memberCompanyCode"></param>
		/// <param name="period"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetSecuritiesTradeUppers>> GetSecuritiesTradeUppersAsync(decimal minVolume, KiwoomRankingInfoNetTradeType2 tradeType, KiwoomRankingInfoStockExchangeType stockExchangeType, string memberCompanyCode, int period, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10039";
			var body = new HttpParameterMap()
				.AddField("trde_qty_tp", minVolume / 1000)
				.AddField("trde_tp", tradeType)
				.AddField("stex_tp", stockExchangeType)
				.AddField("mmcm_cd", memberCompanyCode)
				.AddField("dt", period);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetSecuritiesTradeUppers>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10040 | 당일주요거래원요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetTodayMainTradeOrigins>> GetTodayMainTradeOriginsAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10040";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetTodayMainTradeOrigins>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10042 | 순매수거래원순위요청
		/// </summary>
		/// <param name="queryDateType"></param>
		/// <param name="pointType"></param>
		/// <param name="sortBase"></param>
		/// <param name="stockCode"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="period"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetNetPurchaseTradeOriginRanks>> GetNetPurchaseTradeOriginRanksAsync(KiwoomRankingInfoTradeOriginRankQueryDateType queryDateType, KiwoomRankingInfoDayType pointType, KiwoomRankingInfoTradeOriginRankSortType sortBase, string stockCode, DateTime? startDate = null, DateTime? endDate = null, int? period = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10042";
			var body = new HttpParameterMap()
				.AddField("qry_dt_tp", queryDateType)
				.AddField("pot_tp", pointType)
				.AddField("sort_base", sortBase)
				.AddField("stk_cd", stockCode)
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate)
				.AddField("dt", period);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetNetPurchaseTradeOriginRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10053 | 당일상위이탈원요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetTodayUpperSecessionOrigins>> GetTodayUpperSecessionOriginsAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10053";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetTodayUpperSecessionOrigins>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10062 | 동일순매매순위요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="tradeType"></param>
		/// <param name="sortType"></param>
		/// <param name="unitType"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetEqualNetTradeRanks>> GetEqualNetTradeRanksAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoNetTradeType2 tradeType, KiwoomRankingInfoEqualNetTradeRankSortType sortType, KiwoomRankingInfoUnitType unitType, KiwoomRankingInfoStockExchangeType stockExchangeType, DateTime startDate, DateTime? endDate = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10062";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("trde_tp", tradeType)
				.AddField("sort_cnd", sortType)
				.AddField("unit_tp", unitType)
				.AddField("stex_tp", stockExchangeType)
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetEqualNetTradeRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10065 | 장중투자자별매매상위요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="tradeType"></param>
		/// <param name="institutionType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetOpenMarketInvestorTradeUppers>> GetOpenMarketInvestorTradeUppersAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoNetTradeType2 tradeType, KiwoomRankingInfoInstitutionType institutionType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10065";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("trde_tp", tradeType)
				.AddField("orgn_tp", institutionType);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetOpenMarketInvestorTradeUppers>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10098 | 시간외단일가등락율순위요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="sortType"></param>
		/// <param name="stockCondition"></param>
		/// <param name="minVolume"></param>
		/// <param name="creditCondition"></param>
		/// <param name="minTransactionAmount"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetOvertimeSinglePriceFluctuationRateRanks>> GetOvertimeSinglePriceFluctuationRateRanksAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoFluctuationSortType sortType, KiwoomRankingInfoStockCondition stockCondition, decimal minVolume, KiwoomRankingInfoCreditCondition creditCondition, decimal minTransactionAmount, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10098";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("sort_base", sortType)
				.AddField("stk_cnd", stockCondition)
				.AddField("trde_qty_cnd", minVolume / 1000)
				.AddField("crd_cnd", creditCondition)
				.AddField("trde_prica", minTransactionAmount);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetOvertimeSinglePriceFluctuationRateRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka90009 | 외국인기관매매상위요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="amountQuantityType"></param>
		/// <param name="isIncludeQueryDate"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="date"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetForeignInstitutionTradeUppers>> GetForeignInstitutionTradeUppersAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoAmountQuantityType amountQuantityType, bool isIncludeQueryDate, KiwoomRankingInfoStockExchangeType stockExchangeType, DateTime? date = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka90009";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("amt_qty_tp", amountQuantityType)
				.AddField("qry_dt_tp", isIncludeQueryDate)
				.AddField("stex_tp", stockExchangeType)
				.AddField("date", date);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetForeignInstitutionTradeUppers>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}
	}
}
