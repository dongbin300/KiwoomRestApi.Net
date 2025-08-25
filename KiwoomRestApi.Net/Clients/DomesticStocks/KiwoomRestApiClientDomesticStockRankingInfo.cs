using KiwoomRestApi.Net.Enums.RankingInfo;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models;

using System;
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

		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetRequestRateSuddenIncreases>> GetRequestRateSuddenIncreasesAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoRatioType ratioType, KiwoomRankingInfoTradeQuantityType tradeQuantityType, KiwoomRankingInfoStockCondition stockCondition, KiwoomRankingInfoStockExchangeType stockExchangeType, int timeMinute)
		{
			const string apiId = "ka10022";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("rt_tp", ratioType)
				.AddField("trde_qty_tp", tradeQuantityType)
				.AddField("stk_cnd", stockCondition)
				.AddField("stex_tp", stockExchangeType)
				.AddField("tm_tp", timeMinute);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetRequestRateSuddenIncreases>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetTradedQuantitySuddenIncreases>> GetTradedQuantitySuddenIncreasesAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoSuddenIncreaseSortType sortType, KiwoomRankingInfoTimeType timeType, KiwoomRankingInfoTradeQuantityType tradeQuantityType, KiwoomRankingInfoStockCondition stockCondition, KiwoomRankingInfoPriceType priceType, KiwoomRankingInfoStockExchangeType stockExchangeType, int timeMinute)
		{
			const string apiId = "ka10023";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("sort_tp", sortType)
				.AddField("tm_tp", timeType)
				.AddField("trde_qty_tp", tradeQuantityType)
				.AddField("stk_cnd", stockCondition)
				.AddField("pric_tp", priceType)
				.AddField("stex_tp", stockExchangeType)
				.AddField("tm", timeMinute);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetTradedQuantitySuddenIncreases>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetPreviousDayFluctuationRateUppers>> GetPreviousDayFluctuationRateUppersAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoFluctuationSortType sortType, KiwoomRankingInfoTradeQuantityType tradeQuantityType, KiwoomRankingInfoStockCondition stockCondition, KiwoomRankingInfoCreditCondition creditCondition,
KiwoomRankingInfoInclusionOption upDownInclusion, KiwoomRankingInfoPriceCondition priceCondition, KiwoomRankingInfoTradePriceCondition tradePriceCondition, KiwoomRankingInfoStockExchangeType stockExchangeType)
		{
			const string apiId = "ka10027";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("sort_tp", sortType)
				.AddField("trde_qty_cnd", tradeQuantityType)
				.AddField("stk_cnd", stockCondition)
				.AddField("crd_cnd", creditCondition)
				.AddField("updown_incls", upDownInclusion)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_prica_cnd", tradePriceCondition)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetPreviousDayFluctuationRateUppers>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetExpectedContractFluctuationRateUppers>> GetExpectedContractFluctuationRateUppersAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoContractFluctuationSortType sortType, KiwoomRankingInfoTradeQuantityType tradeQuantityType, KiwoomRankingInfoStockCondition stockCondition, KiwoomRankingInfoCreditCondition creditCondition,
KiwoomRankingInfoPriceCondition priceCondition, KiwoomRankingInfoStockExchangeType stockExchangeType)
		{
			const string apiId = "ka10029";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("sort_tp", sortType)
				.AddField("trde_qty_cnd", tradeQuantityType)
				.AddField("stk_cnd", stockCondition)
				.AddField("crd_cnd", creditCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetExpectedContractFluctuationRateUppers>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetTodayTradeQuantityUppers>> GetTodayTradeQuantityUppersAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoTradeQuantitySortType sortType, KiwoomRankingInfoStockCondition stockCondition, KiwoomRankingInfoCreditCondition creditCondition, KiwoomRankingInfoTradeQuantityType tradeQuantityType,
KiwoomRankingInfoPriceCondition2 priceCondition, KiwoomRankingInfoTradePriceCondition tradePriceCondition, KiwoomRankingInfoMarketOpenType marketOpenType, KiwoomRankingInfoStockExchangeType stockExchangeType)
		{
			const string apiId = "ka10030";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("sort_tp", sortType)
				.AddField("mang_stk_incls", stockCondition)
				.AddField("crd_tp", creditCondition)
				.AddField("trde_qty_tp", tradeQuantityType)
				.AddField("pric_tp", priceCondition)
				.AddField("trde_prica_tp", tradePriceCondition)
				.AddField("mrkt_open_tp", marketOpenType)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetTodayTradeQuantityUppers>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetPreviousTradeQuantityUppers>> GetPreviousTradeQuantityUppersAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoPreviousTradeQuantityQueryType queryType, KiwoomRankingInfoStockExchangeType stockExchangeType, int startRank, int endRank)
		{
			const string apiId = "ka10031";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("qry_tp", queryType)
				.AddField("stex_tp", stockExchangeType)
				.AddField("rank_strt", startRank)
				.AddField("rank_end", endRank);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetPreviousTradeQuantityUppers>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetTradePriceUppers>> GetTradePriceUppersAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoInclusionOption managedStockInclusion, KiwoomRankingInfoStockExchangeType stockExchangeType)
		{
			const string apiId = "ka10032";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("mang_stk_incls", managedStockInclusion)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetTradePriceUppers>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetCreditRateUppers>> GetCreditRateUppersAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoTradeQuantityType tradeQuantityType, KiwoomRankingInfoStockCondition stockCondition, KiwoomRankingInfoInclusionOption upDownInclusion, KiwoomRankingInfoCreditCondition creditCondition, KiwoomRankingInfoStockExchangeType stockExchangeType)
		{
			const string apiId = "ka10033";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("trde_qty_tp", tradeQuantityType)
				.AddField("stk_cnd", stockCondition)
				.AddField("updown_incls", upDownInclusion)
				.AddField("crd_cnd", creditCondition)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetCreditRateUppers>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetForeignTradePerPeriodUppers>> GetForeignTradePerPeriodUppersAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoNetTradeType tradeType, KiwoomRankingInfoStockExchangeType stockExchangeType, int period)
		{
			const string apiId = "ka10034";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("trde_tp", tradeType)
				.AddField("stex_tp", stockExchangeType)
				.AddField("dt", period);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetForeignTradePerPeriodUppers>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetForeignContinuousNetTradeUppers>> GetForeignContinuousNetTradeUppersAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoContinuousNetTradeType tradeType, KiwoomRankingInfoStockExchangeType stockExchangeType, int period)
		{
			const string apiId = "ka10035";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("trde_tp", tradeType)
				.AddField("stex_tp", stockExchangeType)
				.AddField("base_dt_tp", period);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetForeignContinuousNetTradeUppers>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetForeignLimitExhaustionRateIncreases>> GetForeignLimitExhaustionRateIncreasesAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoStockExchangeType stockExchangeType, int period)
		{
			const string apiId = "ka10036";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("stex_tp", stockExchangeType)
				.AddField("dt", period);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetForeignLimitExhaustionRateIncreases>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetForeignWicketTradeUppers>> GetForeignWicketTradeUppersAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoForeignWicketTradeType tradeType, KiwoomRankingInfoAmountQuantityType sortType, KiwoomRankingInfoStockExchangeType stockExchangeType, int period)
		{
			const string apiId = "ka10037";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("trde_tp", tradeType)
				.AddField("sort_tp", sortType)
				.AddField("stex_tp", stockExchangeType)
				.AddField("dt", period);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetForeignWicketTradeUppers>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetStockSecuritiesRanks>> GetStockSecuritiesRanksAsync(KiwoomRankingInfoSecuritiesRankQueryType queryType, string stockCode, DateTime startDate, DateTime endDate, int period)
		{
			const string apiId = "ka10038";
			var body = new HttpParameterMap()
				.AddField("qry_tp", queryType)
				.AddField("stk_cd", stockCode)
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate)
				.AddField("dt", period - 1);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetStockSecuritiesRanks>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetSecuritiesTradeUppers>> GetSecuritiesTradeUppersAsync(KiwoomRankingInfoTradeQuantityType tradeQuantityType, KiwoomRankingInfoNetTradeType2 tradeType, KiwoomRankingInfoStockExchangeType stockExchangeType, string memberCompanyCode, int period)
		{
			const string apiId = "ka10039";
			var body = new HttpParameterMap()
				.AddField("trde_qty_tp", tradeQuantityType)
				.AddField("trde_tp", tradeType)
				.AddField("stex_tp", stockExchangeType)
				.AddField("mmcm_cd", memberCompanyCode)
				.AddField("dt", period);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetSecuritiesTradeUppers>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetTodayMainTradeOrigins>> GetTodayMainTradeOriginsAsync(string stockCode)
		{
			const string apiId = "ka10040";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetTodayMainTradeOrigins>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetNetPurchaseTradeOriginRanks>> GetNetPurchaseTradeOriginRanksAsync(KiwoomRankingInfoTradeOriginRankQueryDateType queryDateType, KiwoomRankingInfoDayType pointType, KiwoomRankingInfoTradeOriginRankSortType sortBase, string stockCode, DateTime? startDate = null, DateTime? endDate = null, int? period = null)
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

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetNetPurchaseTradeOriginRanks>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetTodayUpperSecessionOrigins>> GetTodayUpperSecessionOriginsAsync(string stockCode)
		{
			const string apiId = "ka10053";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetTodayUpperSecessionOrigins>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetEqualNetTradeRanks>> GetEqualNetTradeRanksAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoNetTradeType2 tradeType, KiwoomRankingInfoEqualNetTradeRankSortType sortType, KiwoomRankingInfoUnitType unitType, KiwoomRankingInfoStockExchangeType stockExchangeType, DateTime startDate, DateTime? endDate = null)
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

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetEqualNetTradeRanks>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetOpenMarketInvestorTradeUppers>> GetOpenMarketInvestorTradeUppersAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoNetTradeType2 tradeType, KiwoomRankingInfoInstitutionType institutionType)
		{
			const string apiId = "ka10065";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("trde_tp", tradeType)
				.AddField("orgn_tp", institutionType);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetOpenMarketInvestorTradeUppers>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetOvertimeSinglePriceFluctuationRateRanks>> GetOvertimeSinglePriceFluctuationRateRanksAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoFluctuationSortType sortType, KiwoomRankingInfoStockCondition stockCondition, KiwoomRankingInfoTradeQuantityType tradeQuantityType, KiwoomRankingInfoCreditCondition creditCondition, KiwoomRankingInfoTradePriceCondition tradePriceCondition)
		{
			const string apiId = "ka10098";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("sort_base", sortType)
				.AddField("stk_cnd", stockCondition)
				.AddField("trde_qty_cnd", tradeQuantityType)
				.AddField("crd_cnd", creditCondition)
				.AddField("trde_prica", tradePriceCondition);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetOvertimeSinglePriceFluctuationRateRanks>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetForeignInstitutionTradeUppers>> GetForeignInstitutionTradeUppersAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoAmountQuantityType amountQuantityType, KiwoomRankingInfoInclusionOption queryDateInclusion, KiwoomRankingInfoStockExchangeType stockExchangeType, DateTime? date = null)
		{
			const string apiId = "ka90009";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("amt_qty_tp", amountQuantityType)
				.AddField("qry_dt_tp", queryDateInclusion)
				.AddField("stex_tp", stockExchangeType)
				.AddField("date", date);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetForeignInstitutionTradeUppers>(_endpoint, apiId, body).ConfigureAwait(false);
		}
	}
}
