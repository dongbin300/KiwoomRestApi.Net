using KiwoomRestApi.Net.Converters;
using KiwoomRestApi.Net.Objects.Commons;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models
{
	public record KiwoomForeignInstitutionGetStockForeigners
	{
		/// <summary>
		/// 주식외국인
		/// </summary>
		[JsonProperty("stk_frgnr")]
		public IEnumerable<KiwoomForeignInstitutionGetStockForeignerItem>? Items;
	}
	public record KiwoomForeignInstitutionGetStockForeignerItem
	{
		/// <summary>
		/// 일자
		/// </summary>
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		/// <summary>
		/// 종가
		/// </summary>
		[JsonProperty("close_pric")]
		public KiwoomDecimal? Close;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 변동수량
		/// </summary>
		[JsonProperty("chg_qty")]
		public KiwoomDecimal? ChangeQuantity;
		/// <summary>
		/// 보유주식수
		/// </summary>
		[JsonProperty("poss_stkcnt")]
		public decimal? HoldingQuantity;
		/// <summary>
		/// 비중
		/// </summary>
		[JsonProperty("wght")]
		public KiwoomDecimal? Weight;
		/// <summary>
		/// 취득가능주식수
		/// </summary>
		[JsonProperty("gain_pos_stkcnt")]
		public decimal? AcquirableQuantity;
		/// <summary>
		/// 외국인한도
		/// </summary>
		[JsonProperty("frgnr_limit")]
		public decimal? ForeignerLimit;
		/// <summary>
		/// 외국인한도증감
		/// </summary>
		[JsonProperty("frgnr_limit_irds")]
		public decimal? ForeignerLimitIncrease;
		/// <summary>
		/// 한도소진률
		/// </summary>
		[JsonProperty("limit_exh_rt")]
		public KiwoomDecimal? LimitUsageRate;
	}

	public record KiwoomForeignInstitutionGetStockInstitutions
	{
		/// <summary>
		/// 날짜
		/// </summary>
		[JsonProperty("date")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		/// <summary>
		/// 종가
		/// </summary>
		[JsonProperty("close_pric")]
		public KiwoomDecimal? Close;
		/// <summary>
		/// 대비
		/// </summary>
		[JsonProperty("pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 기관기간누적
		/// </summary>
		[JsonProperty("orgn_dt_acc")]
		public decimal? InstitutionPeriodAccumulated;
		/// <summary>
		/// 기관일별순매매
		/// </summary>
		[JsonProperty("orgn_daly_nettrde")]
		public decimal? InstitutionDailyNetTransaction;
		/// <summary>
		/// 외국인일별순매매
		/// </summary>
		[JsonProperty("frgnr_daly_nettrde")]
		public decimal? ForeignerDailyNetTransaction;
		/// <summary>
		/// 외국인지분율
		/// </summary>
		[JsonProperty("frgnr_qota_rt")]
		public decimal? ForeignerHoldingRate;
	}

	public record KiwoomForeignInstitutionGetContinuousTransactions
	{
		/// <summary>
		/// 기관외국인연속매매현황
		/// </summary>
		[JsonProperty("orgn_frgnr_cont_trde_prst")]
		public IEnumerable<KiwoomForeignInstitutionGetContinuousTransactionItem>? Items;
	}
	public record KiwoomForeignInstitutionGetContinuousTransactionItem
	{
		/// <summary>
		/// 순위
		/// </summary>
		[JsonProperty("rank")]
		public int? Rank;
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 기간중주가등락률
		/// </summary>
		[JsonProperty("prid_stkpc_flu_rt")]
		public KiwoomDecimal? PriceChangeRateDuringPeriod;
		/// <summary>
		/// 기관순매매금액
		/// </summary>
		[JsonProperty("orgn_nettrde_amt")]
		public KiwoomDecimal? InstitutionNetTransactionAmount;
		/// <summary>
		/// 기관순매매량
		/// </summary>
		[JsonProperty("orgn_nettrde_qty")]
		public KiwoomDecimal? InstitutionNetVolume;
		/// <summary>
		/// 기관계연속순매수일수
		/// </summary>
		[JsonProperty("orgn_cont_netprps_dys")]
		public KiwoomDecimal? InstitutionContinuousNetBuyDays;
		/// <summary>
		/// 기관계연속순매수량
		/// </summary>
		[JsonProperty("orgn_cont_netprps_qty")]
		public KiwoomDecimal? InstitutionContinuousNetBuyQuantity;
		/// <summary>
		/// 기관계연속순매수금액
		/// </summary>
		[JsonProperty("orgn_cont_netprps_amt")]
		public KiwoomDecimal? InstitutionContinuousNetBuyAmount;
		/// <summary>
		/// 외국인순매매량
		/// </summary>
		[JsonProperty("frgnr_nettrde_qty")]
		public KiwoomDecimal? ForeignerNetVolume;
		/// <summary>
		/// 외국인순매매액
		/// </summary>
		[JsonProperty("frgnr_nettrde_amt")]
		public KiwoomDecimal? ForeignerNetTransactionAmount;
		/// <summary>
		/// 외국인연속순매수일수
		/// </summary>
		[JsonProperty("frgnr_cont_netprps_dys")]
		public KiwoomDecimal? ForeignerContinuousNetBuyDays;
		/// <summary>
		/// 외국인연속순매수량
		/// </summary>
		[JsonProperty("frgnr_cont_netprps_qty")]
		public KiwoomDecimal? ForeignerContinuousNetBuyQuantity;
		/// <summary>
		/// 외국인연속순매수금액
		/// </summary>
		[JsonProperty("frgnr_cont_netprps_amt")]
		public KiwoomDecimal? ForeignerContinuousNetBuyAmount;
		/// <summary>
		/// 순매매량
		/// </summary>
		[JsonProperty("nettrde_qty")]
		public KiwoomDecimal? NetVolume;
		/// <summary>
		/// 순매매액
		/// </summary>
		[JsonProperty("nettrde_amt")]
		public KiwoomDecimal? NetTransactionAmount;
		/// <summary>
		/// 합계연속순매수일수
		/// </summary>
		[JsonProperty("tot_cont_netprps_dys")]
		public KiwoomDecimal? TotalContinuousNetBuyDays;
		/// <summary>
		/// 합계연속순매매수량
		/// </summary>
		[JsonProperty("tot_cont_nettrde_qty")]
		public KiwoomDecimal? TotalContinuousNetVolume;
		/// <summary>
		/// 합계연속순매수금액
		/// </summary>
		[JsonProperty("tot_cont_netprps_amt")]
		public KiwoomDecimal? TotalContinuousNetBuyAmount;
	}

    public record KiwoomForeignInstitutionGetGoldSpotInvestorStatus
    {
        /// <summary>
        /// 금현물투자자현황
        /// </summary>
        [JsonProperty("inve_trad_stat")]
        public IEnumerable<KiwoomForeignInstitutionGetGoldSpotInvestorStatusItem>? Items;
    }
    public record KiwoomForeignInstitutionGetGoldSpotInvestorStatusItem
    {
		/// <summary>
		/// 투자자별 매도 수량(천)
		/// </summary>
		[JsonProperty("all_dfrt_trst_sell_qty")]
		public decimal? InvestorSellQuantity;
		/// <summary>
		/// 투자자별 매도 수량 증감(천)
		/// </summary>
		[JsonProperty("sell_qty_irds")]
		public KiwoomDecimal? InvestorSellQuantityChange;
        /// <summary>
        /// 투자자별 매도 금액(억)
        /// </summary>
        [JsonProperty("all_dfrt_trst_sell_amt")]
        public decimal? InvestorSellAmount;
		/// <summary>
		/// 투자자별 매도 금액 증감(억)
		/// </summary>
		[JsonProperty("sell_amt_irds")]
		public KiwoomDecimal? InvestorSellAmountChange;
		/// <summary>
		/// 투자자별 매수 수량(천)
		/// </summary>
		[JsonProperty("all_dfrt_trst_buy_qty")]
		public decimal? InvestorBuyQuantity;
		/// <summary>
		/// 투자자별 매수 수량 증감(천)
		/// </summary>
		[JsonProperty("buy_qty_irds")]
		public KiwoomDecimal? InvestorBuyQuantityChange;
		/// <summary>
		/// 투자자별 매수 금액(억)
		/// </summary>
		[JsonProperty("all_dfrt_trst_buy_amt")]
		public decimal? InvestorBuyAmount;
		/// <summary>
		/// 투자자별 매수 금액 증감(억)
		/// </summary>
		[JsonProperty("buy_amt_irds")]
		public KiwoomDecimal? InvestorBuyAmountChange;
		/// <summary>
		/// 투자자별 순매수 수량(천)
		/// </summary>
		[JsonProperty("all_dfrt_trst_netprps_qty")]
		public KiwoomDecimal? InvestorNetBuyQuantity;
		/// <summary>
		/// 투자자별 순매수 수량 증감(천)
		/// </summary>
		[JsonProperty("netprps_qty_irds")]
		public KiwoomDecimal? InvestorNetBuyQuantityChange;
		/// <summary>
		/// 투자자별 순매수 금액(억)
		/// </summary>
		[JsonProperty("all_dfrt_trst_netprps_amt")]
		public KiwoomDecimal? InvestorNetBuyAmount;
		/// <summary>
		/// 투자자별 순매수 금액 증감(억)
		/// </summary>
		[JsonProperty("netprps_amt_irds")]
		public KiwoomDecimal? InvestorNetBuyAmountChange;
        /// <summary>
        /// 투자자별 매도 단가
        /// </summary>
        [JsonProperty("sell_uv")]
        public decimal? InvestorSellPrice;
        /// <summary>
        /// 투자자별 매수 단가
        /// </summary>
        [JsonProperty("buy_uv")]
        public decimal? InvestorBuyPrice;
        /// <summary>
        /// 투자자 구분명
        /// </summary>
        [JsonProperty("stk_nm")]
        public string? InvestorCodeName;
        /// <summary>
        /// 누적 순매수 금액(억)
        /// </summary>
        [JsonProperty("acc_netprps_amt")]
        public KiwoomDecimal? AccumulatedNetBuyAmount;
		/// <summary>
		/// 누적 순매수 수량(천)
		/// </summary>
		[JsonProperty("acc_netprps_qty")]
		public KiwoomDecimal? AccumulatedNetBuyQuantity;
        /// <summary>
        /// 투자자 코드
        /// </summary>
        [JsonProperty("stk_cd")]
        public string? InvestorCode;
    }
}
