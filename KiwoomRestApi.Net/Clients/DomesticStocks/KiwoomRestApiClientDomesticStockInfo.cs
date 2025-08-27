using KiwoomRestApi.Net.Enums.StockInfo;
using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models;

using System;
using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.DomesticStocks
{
	public class KiwoomRestApiClientDomesticStockInfo(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = ApiEndpoint.DomesticStock.StockInfo;

		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetStockInfo>> GetStockInfoAsync(string stockCode, DateTime date, KiwoomStockInfoMarginLoanType marginLoanType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10001";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("dt", date)
				.AddField("qry_tp", marginLoanType);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetStockInfo>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetTradeInfo>> GetTradeInfoAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10002";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetTradeInfo>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetContracts>> GetContractsAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10003";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetContracts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetCreditTradeTrends>> GetCreditTradeTrendsAsync(string stockCode, DateTime date, KiwoomStockInfoMarginLoanType marginLoanType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10013";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("dt", date)
				.AddField("qry_tp", marginLoanType);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetCreditTradeTrends>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetDailyTradeDetails>> GetDailyTradeDetailsAsync(string stockCode, DateTime startDate, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10015";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("strt_dt", startDate);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetDailyTradeDetails>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetLowPrices>> GetLowPricesAsync(KiwoomStockInfoMarketType marketType, KiwoomStockInfoNewHighLowType newHighLowType, KiwoomStockInfoHighLowCloseType highLowCloseType, KiwoomStockInfoStockCondition stockCondition, KiwoomStockInfoTradeQuantityType tradeQuantityType, KiwoomStockInfoCreditCondition creditCondition, KiwoomStockInfonInclusionOption upDownInclusion, int period, KiwoomStockInfoStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10016";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("ntl_tp", newHighLowType)
				.AddField("high_low_close_tp", highLowCloseType)
				.AddField("stk_cnd", stockCondition)
				.AddField("trde_qty_tp", tradeQuantityType)
				.AddField("crd_cnd", creditCondition)
				.AddField("updown_incls", upDownInclusion)
				.AddField("dt", period)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetLowPrices>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetUpdownPrices>> GetUpdownPricesAsync(KiwoomStockInfoMarketType marketType, KiwoomStockInfoUpDownType upDownType, KiwoomStockInfoUpDownPriceSortType sortType, KiwoomStockInfoStockCondition stockCondition, KiwoomStockInfoTradeQuantityType tradeQuantityType, KiwoomStockInfoCreditCondition creditCondition, KiwoomStockInfoPriceCondition tradeAmountType, KiwoomStockInfoStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10017";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("updown_tp", upDownType)
				.AddField("sort_tp", sortType)
				.AddField("stk_cnd", stockCondition)
				.AddField("trde_qty_tp", tradeQuantityType)
				.AddField("crd_cnd", creditCondition)
				.AddField("trde_gold_tp", tradeAmountType)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetUpdownPrices>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetHighLowPriceProximities>> GetHighLowPriceProximitiesAsync(KiwoomStockInfoNewHighLowType newHighLowType, decimal approachRate, KiwoomStockInfoMarketType marketType, KiwoomStockInfoTradeQuantityType tradeQuantityType, KiwoomStockInfoStockCondition stockCondition, KiwoomStockInfoCreditCondition creditCondition, KiwoomStockInfoStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10018";
			var body = new HttpParameterMap()
				.AddField("high_low_tp", newHighLowType)
				.AddField("alacc_rt", approachRate * 10)
				.AddField("mrkt_tp", marketType)
				.AddField("trde_qty_tp", tradeQuantityType)
				.AddField("stk_cnd", stockCondition)
				.AddField("crd_cnd", creditCondition)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetHighLowPriceProximities>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetPriceJumpFluctuations>> GetPriceJumpFluctuationsAsync(KiwoomStockInfoMarketType marketType, KiwoomStockInfoFluctuationType fluctuationType, KiwoomStockInfoTimeType timeType, int timeValue, KiwoomStockInfoTradeQuantityType tradeQuantityType, KiwoomStockInfoStockCondition stockCondition, KiwoomStockInfoCreditCondition creditCondition, KiwoomStockInfoPriceCondition priceCondition, KiwoomStockInfonInclusionOption upDownInclusion, KiwoomStockInfoStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10019";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("flu_tp", fluctuationType)
				.AddField("tm_tp", timeType)
				.AddField("tm", timeValue)
				.AddField("trde_qty_tp", tradeQuantityType)
				.AddField("stk_cnd", stockCondition)
				.AddField("crd_cnd", creditCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("updown_incls", upDownInclusion)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetPriceJumpFluctuations>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetTradeVolumeUpdates>> GetTradeVolumeUpdatesAsync(KiwoomStockInfoMarketType marketType, int cycleDays, KiwoomStockInfoTradeQuantityType tradeQuantityType, KiwoomStockInfoStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10024";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("cycle_tp", cycleDays)
				.AddField("trde_qty_tp", tradeQuantityType)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetTradeVolumeUpdates>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetPriceConcentrations>> GetPriceConcentrationsAsync(KiwoomStockInfoMarketType marketType, decimal propertyConcentrationRate, KiwoomStockInfonInclusionOption currentPriceEntryInclusion, int propertyCount, int cycleDays, KiwoomStockInfoStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10025";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("prps_cnctr_rt", propertyConcentrationRate)
				.AddField("cur_prc_entry", currentPriceEntryInclusion)
				.AddField("prpscnt", propertyCount)
				.AddField("cycle_tp", cycleDays)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetPriceConcentrations>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetHighLowPers>> GetHighLowPersAsync(KiwoomStockInfoPerType perType, KiwoomStockInfoStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10026";
			var body = new HttpParameterMap()
				.AddField("pertp", perType)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetHighLowPers>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetOpenPriceCompareFluctuations>> GetOpenPriceCompareFluctuationsAsync(KiwoomStockInfoFluctuationSortType sortType, KiwoomStockInfoTradeQuantityType tradeQuantityType, KiwoomStockInfoMarketType marketType, KiwoomStockInfonInclusionOption upDownInclusion, KiwoomStockInfoStockCondition stockCondition, KiwoomStockInfoCreditCondition creditCondition, KiwoomStockInfoPriceCondition tradeAmountCondition, KiwoomStockInfoFluctuationCondition fluctuationCondition, KiwoomStockInfoStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10028";
			var body = new HttpParameterMap()
				.AddField("sort_tp", sortType)
				.AddField("trde_qty_cnd", tradeQuantityType)
				.AddField("mrkt_tp", marketType)
				.AddField("updown_incls", upDownInclusion)
				.AddField("stk_cnd", stockCondition)
				.AddField("crd_cnd", creditCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition)
				.AddField("flu_cnd", fluctuationCondition)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetOpenPriceCompareFluctuations>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetTradeOriginPriceAnalyses>> GetTradeOriginPriceAnalysesAsync(string stockCode, DateTime startDate, DateTime endDate, KiwoomStockInfoQueryDateType queryDateType, KiwoomStockInfoDayType pointType, int period, KiwoomStockInfoSortType sortType, string memberCode, KiwoomStockInfoStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10043";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate)
				.AddField("qry_dt_tp", queryDateType)
				.AddField("pot_tp", pointType)
				.AddField("dt", period)
				.AddField("sort_base", sortType)
				.AddField("mmcm_cd", memberCode)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetTradeOriginPriceAnalyses>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetTradeOriginMomentTradeVolumes>> GetTradeOriginMomentTradeVolumesAsync(string memberCode, KiwoomStockInfoMarketType2 marketType, int quantity, KiwoomStockInfoPriceCondition priceCondition, KiwoomStockInfoStockExchangeType stockExchangeType, string stockCode = "", CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10052";
			var body = new HttpParameterMap()
				.AddField("mmcm_cd", memberCode)
				.AddField("mrkt_tp", marketType)
				.AddField("qty_tp", quantity / 1000)
				.AddField("pric_tp", priceCondition)
				.AddField("stex_tp", stockExchangeType)
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetTradeOriginMomentTradeVolumes>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetMotionStocks>> GetMotionStocksAsync(KiwoomStockInfoMarketType marketType, KiwoomStockInfoBeforeMarketType beforeMarketType, KiwoomStockInfoTriggerType triggerType, KiwoomStockInfoSkipStockType skipStockType, KiwoomStockInfoUseOption tradeQuantityOption, decimal minTradeQuantity, decimal maxTradeQuantity, KiwoomStockInfoUseOption tradeAmountOption, decimal minTradeAmount, decimal maxTradeAmount, KiwoomStockInfoTriggerDirection triggerDirection, KiwoomStockInfoStockExchangeType stockExchangeType, string stockCode = "", CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10054";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("bf_mkrt_tp", beforeMarketType)
				.AddField("motn_tp", triggerType)
				.AddField("skip_stk", skipStockType)
				.AddField("trde_qty_tp", tradeQuantityOption)
				.AddField("min_trde_qty", minTradeQuantity)
				.AddField("max_trde_qty", maxTradeQuantity)
				.AddField("trde_prica_tp", tradeAmountOption)
				.AddField("min_trde_prica", minTradeAmount / 1_000_000)
				.AddField("max_trde_prica", maxTradeAmount / 1_000_000)
				.AddField("motn_drc", triggerDirection)
				.AddField("stex_tp", stockExchangeType)
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetMotionStocks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetTodayPreviousTradeQuantities>> GetTodayPreviousTradeQuantitiesAsync(string stockCode, KiwoomStockInfoDayType2 dayType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10055";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("tdy_pred", dayType);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetTodayPreviousTradeQuantities>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetInvestorDailyTradeStocks>> GetInvestorDailyTradeStocksAsync(DateTime startDate, DateTime endDate, KiwoomStockInfoNetTradeType tradeType, KiwoomStockInfoMarketType marketType, KiwoomStockInfoInvestorType investorType, KiwoomStockInfoStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10058";
			var body = new HttpParameterMap()
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate)
				.AddField("trde_tp", tradeType)
				.AddField("mrkt_tp", marketType)
				.AddField("invsr_tp", investorType)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetInvestorDailyTradeStocks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetStockInvestorInstitutions>> GetStockInvestorInstitutionsAsync(DateTime date, string stockCode, KiwoomStockInfoAmountQuantityType amountQuantityType, KiwoomStockInfoTradeType tradeType, KiwoomStockInfoUnitType unitType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10059";
			var body = new HttpParameterMap()
				.AddField("dt", date)
				.AddField("stk_cd", stockCode)
				.AddField("amt_qty_tp", amountQuantityType)
				.AddField("trde_tp", tradeType)
				.AddField("unit_tp", unitType);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetStockInvestorInstitutions>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetStockInvestorInstitutionTotals>> GetStockInvestorInstitutionTotalsAsync(string stockCode, DateTime startDate, DateTime endDate, KiwoomStockInfoAmountQuantityType amountQuantityType, KiwoomStockInfoTradeType tradeType, KiwoomStockInfoUnitType unitType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10061";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate)
				.AddField("amt_qty_tp", amountQuantityType)
				.AddField("trde_tp", tradeType)
				.AddField("unit_tp", unitType);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetStockInvestorInstitutionTotals>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetTodayPreviousContracts>> GetTodayPreviousContractsAsync(string stockCode, KiwoomStockInfoDayType2 dayType, KiwoomStockInfoTickMinuteType tickMinuteType, TimeSpan time, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10084";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("tdy_pred", dayType)
				.AddField("tic_min", tickMinuteType)
				.AddField("tm", time.ToString("hhmm"));

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetTodayPreviousContracts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetAttentionStocks>> GetAttentionStocksAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10095";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetAttentionStocks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetLists>> GetListsAsync(KiwoomStockInfoMarketType3 marketType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10099";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetLists>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetListItem>> GetListItemAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10100";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetListItem>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetMarketCodes>> GetMarketCodesAsync(KiwoomStockInfoMarketType4 marketType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10101";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetMarketCodes>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetMemberCodes>> GetMemberCodesAsync(CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10102";
			var body = new HttpParameterMap();

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetMemberCodes>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetProgramNetPurchaseUpper50>> GetProgramNetPurchaseUpper50Async(KiwoomStockInfoNetTradeType tradeUpperType, KiwoomStockInfoAmountQuantityType amountQuantityType, KiwoomStockInfoMarketType5 marketType, KiwoomStockInfoStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka90003";
			var body = new HttpParameterMap()
				.AddField("trde_upper_tp", tradeUpperType)
				.AddField("amt_qty_tp", amountQuantityType)
				.AddField("mrkt_tp", marketType)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetProgramNetPurchaseUpper50>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetProgramTradeStatus>> GetProgramTradeStatusAsync(DateTime date, KiwoomStockInfoMarketType5 marketType, KiwoomStockInfoStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka90004";
			var body = new HttpParameterMap()
				.AddField("dt", date)
				.AddField("mrkt_tp", marketType)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetProgramTradeStatus>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetCreditLoanPossibleStocks>> GetCreditLoanPossibleStocksAsync(KiwoomStockInfoMarketDealType marketDealType, KiwoomStockInfoCreditStockGradeType creditStockGradeType = KiwoomStockInfoCreditStockGradeType.All, string stockCode = "", CancellationToken cancellationToken = default)
		{
			const string apiId = "kt20016";
			var body = new HttpParameterMap()
				.AddField("mrkt_deal_tp", marketDealType)
				.AddField("crd_stk_grae_tp", creditStockGradeType)
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetCreditLoanPossibleStocks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetCreditAllowYn>> GetCreditAllowYnAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "kt20017";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetCreditAllowYn>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}
	}
}
