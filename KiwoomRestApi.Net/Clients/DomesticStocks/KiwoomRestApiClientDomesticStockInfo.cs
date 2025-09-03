﻿using KiwoomRestApi.Net.Enums.StockInfo;
using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models;

using System;
using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.DomesticStocks
{
	/// <summary>
	/// 종목정보 API 클라이언트
	/// 현재 31개
	/// </summary>
	/// <param name="client"></param>
	public class KiwoomRestApiClientDomesticStockInfo(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = ApiEndpoint.DomesticStock.StockInfo;

		/// <summary>
		/// | ka00198 | 실시간종목조회순위
		/// </summary>
		/// <param name="queryType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetRealtimeStockRanks>> GetRealtimeStockRanksAsync(KiwoomStockInfoQueryType queryType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka00198";
			var body = new HttpParameterMap()
				.AddField("qry_tp", queryType);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetRealtimeStockRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10001 | 주식기본정보요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="date"></param>
		/// <param name="marginLoanType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetStockInfo>> GetStockInfoAsync(string stockCode, DateTime date, KiwoomStockInfoMarginLoanType marginLoanType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10001";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("dt", date)
				.AddField("qry_tp", marginLoanType);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetStockInfo>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10002 | 주식거래원요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetTradeInfo>> GetTradeInfoAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10002";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetTradeInfo>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10003 | 체결정보요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetContracts>> GetContractsAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10003";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetContracts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10013 | 신용매매동향요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="date"></param>
		/// <param name="marginLoanType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetCreditTradeTrends>> GetCreditTradeTrendsAsync(string stockCode, DateTime date, KiwoomStockInfoMarginLoanType marginLoanType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10013";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("dt", date)
				.AddField("qry_tp", marginLoanType);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetCreditTradeTrends>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10015 | 일별거래상세요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="startDate"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetDailyTradeDetails>> GetDailyTradeDetailsAsync(string stockCode, DateTime startDate, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10015";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("strt_dt", startDate);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetDailyTradeDetails>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10016 | 신고저가요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="newHighLowType"></param>
		/// <param name="highLowCloseType"></param>
		/// <param name="stockCondition"></param>
		/// <param name="minVolume"></param>
		/// <param name="creditCondition"></param>
		/// <param name="isIncludeUpDown"></param>
		/// <param name="period"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetLowPrices>> GetLowPricesAsync(KiwoomStockInfoMarketType marketType, KiwoomStockInfoNewHighLowType newHighLowType, KiwoomStockInfoHighLowCloseType highLowCloseType, KiwoomStockInfoStockCondition stockCondition, decimal minVolume, KiwoomStockInfoCreditCondition creditCondition, bool isIncludeUpDown, int period, KiwoomStockInfoStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10016";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("ntl_tp", newHighLowType)
				.AddField("high_low_close_tp", highLowCloseType)
				.AddField("stk_cnd", stockCondition)
				.AddField("trde_qty_tp", minVolume / 1000)
				.AddField("crd_cnd", creditCondition)
				.AddField("updown_incls", isIncludeUpDown)
				.AddField("dt", period)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetLowPrices>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10017 | 상하한가요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="upDownType"></param>
		/// <param name="sortType"></param>
		/// <param name="stockCondition"></param>
		/// <param name="minVolume"></param>
		/// <param name="creditCondition"></param>
		/// <param name="tradeAmountType"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetUpdownPrices>> GetUpdownPricesAsync(KiwoomStockInfoMarketType marketType, KiwoomStockInfoUpDownType upDownType, KiwoomStockInfoUpDownPriceSortType sortType, KiwoomStockInfoStockCondition stockCondition, decimal minVolume, KiwoomStockInfoCreditCondition creditCondition, KiwoomStockInfoPriceCondition tradeAmountType, KiwoomStockInfoStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10017";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("updown_tp", upDownType)
				.AddField("sort_tp", sortType)
				.AddField("stk_cnd", stockCondition)
				.AddField("trde_qty_tp", minVolume / 1000)
				.AddField("crd_cnd", creditCondition)
				.AddField("trde_gold_tp", tradeAmountType)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetUpdownPrices>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10018 | 고저가근접요청
		/// </summary>
		/// <param name="newHighLowType"></param>
		/// <param name="approachRate"></param>
		/// <param name="marketType"></param>
		/// <param name="minVolume"></param>
		/// <param name="stockCondition"></param>
		/// <param name="creditCondition"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetHighLowPriceProximities>> GetHighLowPriceProximitiesAsync(KiwoomStockInfoNewHighLowType newHighLowType, decimal approachRate, KiwoomStockInfoMarketType marketType, decimal minVolume, KiwoomStockInfoStockCondition stockCondition, KiwoomStockInfoCreditCondition creditCondition, KiwoomStockInfoStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10018";
			var body = new HttpParameterMap()
				.AddField("high_low_tp", newHighLowType)
				.AddField("alacc_rt", approachRate * 10)
				.AddField("mrkt_tp", marketType)
				.AddField("trde_qty_tp", minVolume / 1000)
				.AddField("stk_cnd", stockCondition)
				.AddField("crd_cnd", creditCondition)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetHighLowPriceProximities>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10019 | 가격급등락요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="fluctuationType"></param>
		/// <param name="timeType"></param>
		/// <param name="timeValue"></param>
		/// <param name="minVolume"></param>
		/// <param name="stockCondition"></param>
		/// <param name="creditCondition"></param>
		/// <param name="priceCondition"></param>
		/// <param name="isIncludeUpDown"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetPriceJumpFluctuations>> GetPriceJumpFluctuationsAsync(KiwoomStockInfoMarketType marketType, KiwoomStockInfoFluctuationType fluctuationType, KiwoomStockInfoTimeType timeType, int timeValue, decimal minVolume, KiwoomStockInfoStockCondition stockCondition, KiwoomStockInfoCreditCondition creditCondition, KiwoomStockInfoPriceCondition priceCondition, bool isIncludeUpDown, KiwoomStockInfoStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10019";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("flu_tp", fluctuationType)
				.AddField("tm_tp", timeType)
				.AddField("tm", timeValue)
				.AddField("trde_qty_tp", minVolume / 1000)
				.AddField("stk_cnd", stockCondition)
				.AddField("crd_cnd", creditCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("updown_incls", isIncludeUpDown)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetPriceJumpFluctuations>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10024 | 거래량갱신요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="cycleDays"></param>
		/// <param name="minVolume"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetTradeVolumeUpdates>> GetTradeVolumeUpdatesAsync(KiwoomStockInfoMarketType marketType, int cycleDays, decimal minVolume, KiwoomStockInfoStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10024";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("cycle_tp", cycleDays)
				.AddField("trde_qty_tp", minVolume / 1000)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetTradeVolumeUpdates>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10025 | 매물대집중요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="propertyConcentrationRate"></param>
		/// <param name="isIncludeCurrentPriceEntry"></param>
		/// <param name="propertyCount"></param>
		/// <param name="cycleDays"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetPriceConcentrations>> GetPriceConcentrationsAsync(KiwoomStockInfoMarketType marketType, decimal propertyConcentrationRate, bool isIncludeCurrentPriceEntry, int propertyCount, int cycleDays, KiwoomStockInfoStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10025";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("prps_cnctr_rt", propertyConcentrationRate)
				.AddField("cur_prc_entry", isIncludeCurrentPriceEntry)
				.AddField("prpscnt", propertyCount)
				.AddField("cycle_tp", cycleDays)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetPriceConcentrations>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10026 | 고저PER요청
		/// </summary>
		/// <param name="perType"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetHighLowPers>> GetHighLowPersAsync(KiwoomStockInfoPerType perType, KiwoomStockInfoStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10026";
			var body = new HttpParameterMap()
				.AddField("pertp", perType)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetHighLowPers>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10028 | 시가대비등락률요청
		/// </summary>
		/// <param name="sortType"></param>
		/// <param name="minVolume"></param>
		/// <param name="marketType"></param>
		/// <param name="isIncludeUpDown"></param>
		/// <param name="stockCondition"></param>
		/// <param name="creditCondition"></param>
		/// <param name="tradeAmountCondition"></param>
		/// <param name="fluctuationCondition"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetOpenPriceCompareFluctuations>> GetOpenPriceCompareFluctuationsAsync(KiwoomStockInfoFluctuationSortType sortType, decimal minVolume, KiwoomStockInfoMarketType marketType, bool isIncludeUpDown, KiwoomStockInfoStockCondition stockCondition, KiwoomStockInfoCreditCondition creditCondition, KiwoomStockInfoPriceCondition tradeAmountCondition, KiwoomStockInfoFluctuationCondition fluctuationCondition, KiwoomStockInfoStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10028";
			var body = new HttpParameterMap()
				.AddField("sort_tp", sortType)
				.AddField("trde_qty_cnd", minVolume / 1000)
				.AddField("mrkt_tp", marketType)
				.AddField("updown_incls", isIncludeUpDown)
				.AddField("stk_cnd", stockCondition)
				.AddField("crd_cnd", creditCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition)
				.AddField("flu_cnd", fluctuationCondition)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetOpenPriceCompareFluctuations>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10043 | 거래원매물대분석요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="queryDateType"></param>
		/// <param name="pointType"></param>
		/// <param name="period"></param>
		/// <param name="sortType"></param>
		/// <param name="memberCode"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
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

		/// <summary>
		/// | ka10052 | 거래원순간거래량요청
		/// </summary>
		/// <param name="memberCode"></param>
		/// <param name="marketType"></param>
		/// <param name="quantity"></param>
		/// <param name="priceCondition"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
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

		/// <summary>
		/// | ka10054 | 변동성완화장치발동종목요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="beforeMarketType"></param>
		/// <param name="triggerType"></param>
		/// <param name="skipStockType"></param>
		/// <param name="isUseVolumeOption"></param>
		/// <param name="minVolume"></param>
		/// <param name="maxVolume"></param>
		/// <param name="isUseTransactionAmountOption"></param>
		/// <param name="minTransactionAmount"></param>
		/// <param name="maxTransactionAmount"></param>
		/// <param name="triggerDirection"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetMotionStocks>> GetMotionStocksAsync(KiwoomStockInfoMarketType marketType, KiwoomStockInfoBeforeMarketType beforeMarketType, KiwoomStockInfoTriggerType triggerType, KiwoomStockInfoSkipStockType skipStockType, bool isUseVolumeOption, decimal minVolume, decimal maxVolume, bool isUseTransactionAmountOption, decimal minTransactionAmount, decimal maxTransactionAmount, KiwoomStockInfoTriggerDirection triggerDirection, KiwoomStockInfoStockExchangeType stockExchangeType, string stockCode = "", CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10054";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("bf_mkrt_tp", beforeMarketType)
				.AddField("motn_tp", triggerType)
				.AddField("skip_stk", skipStockType)
				.AddField("trde_qty_tp", isUseVolumeOption)
				.AddField("min_trde_qty", minVolume)
				.AddField("max_trde_qty", maxVolume)
				.AddField("trde_prica_tp", isUseTransactionAmountOption)
				.AddField("min_trde_prica", minTransactionAmount / 1_000_000)
				.AddField("max_trde_prica", maxTransactionAmount / 1_000_000)
				.AddField("motn_drc", triggerDirection)
				.AddField("stex_tp", stockExchangeType)
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetMotionStocks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10055 | 당일전일체결량요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="dayType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetTodayPreviousTradeQuantities>> GetTodayPreviousTradeQuantitiesAsync(string stockCode, KiwoomStockInfoDayType2 dayType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10055";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("tdy_pred", dayType);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetTodayPreviousTradeQuantities>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10058 | 투자자별일별매매종목요청
		/// </summary>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="tradeType"></param>
		/// <param name="marketType"></param>
		/// <param name="investorType"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
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

		/// <summary>
		/// | ka10059 | 종목별투자자기관별요청
		/// </summary>
		/// <param name="date"></param>
		/// <param name="stockCode"></param>
		/// <param name="amountQuantityType"></param>
		/// <param name="tradeType"></param>
		/// <param name="unitType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
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

		/// <summary>
		/// | ka10061 | 종목별투자자기관별합계요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="amountQuantityType"></param>
		/// <param name="unitType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetStockInvestorInstitutionTotals>> GetStockInvestorInstitutionTotalsAsync(string stockCode, DateTime startDate, DateTime endDate, KiwoomStockInfoAmountQuantityType amountQuantityType, KiwoomStockInfoUnitType unitType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10061";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate)
				.AddField("amt_qty_tp", amountQuantityType)
				.AddField("trde_tp", "0") // 순매수
				.AddField("unit_tp", unitType);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetStockInvestorInstitutionTotals>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10084 | 당일전일체결요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="dayType"></param>
		/// <param name="tickMinuteType"></param>
		/// <param name="time"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
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

		/// <summary>
		/// | ka10095 | 관심종목정보요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetAttentionStocks>> GetAttentionStocksAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10095";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetAttentionStocks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10099 | 종목정보 리스트
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetLists>> GetListsAsync(KiwoomStockInfoMarketType3 marketType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10099";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetLists>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10100 | 종목정보 조회
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetListItem>> GetListItemAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10100";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetListItem>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10101 | 업종코드 리스트
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetMarketCodes>> GetMarketCodesAsync(KiwoomStockInfoMarketType4 marketType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10101";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetMarketCodes>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10102 | 회원사 리스트
		/// </summary>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetMemberCodes>> GetMemberCodesAsync(CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10102";
			var body = new HttpParameterMap();

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetMemberCodes>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka90003 | 프로그램순매수상위50요청
		/// </summary>
		/// <param name="tradeUpperType"></param>
		/// <param name="amountQuantityType"></param>
		/// <param name="marketType"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
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

		/// <summary>
		/// | ka90004 | 종목별프로그램매매현황요청
		/// </summary>
		/// <param name="date"></param>
		/// <param name="marketType"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetProgramTradeStatus>> GetProgramTradeStatusAsync(DateTime date, KiwoomStockInfoMarketType5 marketType, KiwoomStockInfoStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka90004";
			var body = new HttpParameterMap()
				.AddField("dt", date)
				.AddField("mrkt_tp", marketType)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetProgramTradeStatus>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | kt20016 | 신용융자 가능종목요청
		/// </summary>
		/// <param name="marketDealType"></param>
		/// <param name="creditStockGradeType"></param>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetCreditLoanPossibleStocks>> GetCreditLoanPossibleStocksAsync(KiwoomStockInfoMarketDealType marketDealType, KiwoomStockInfoCreditStockGradeType creditStockGradeType = KiwoomStockInfoCreditStockGradeType.All, string stockCode = "", CancellationToken cancellationToken = default)
		{
			const string apiId = "kt20016";
			var body = new HttpParameterMap()
				.AddField("mrkt_deal_tp", marketDealType)
				.AddField("crd_stk_grae_tp", creditStockGradeType)
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetCreditLoanPossibleStocks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | kt20017 | 신용융자 가능문의
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomStockInfoGetCreditAllowYn>> GetCreditAllowYnAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "kt20017";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomStockInfoGetCreditAllowYn>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}
	}
}
