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
		public decimal? ClosePrice;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDayChange;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? TradeQuantity;
		/// <summary>
		/// 변동수량
		/// </summary>
		[JsonProperty("chg_qty")]
		public decimal? ChangeQuantity;
		/// <summary>
		/// 보유주식수
		/// </summary>
		[JsonProperty("poss_stkcnt")]
		public decimal? HoldingStockCount;
		/// <summary>
		/// 비중
		/// </summary>
		[JsonProperty("wght")]
		public decimal? Weight;
		/// <summary>
		/// 취득가능주식수
		/// </summary>
		[JsonProperty("gain_pos_stkcnt")]
		public decimal? GainPossibleStockCount;
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
		public decimal? LimitExhaustionRate;
	}

	public record KiwoomForeignInstitutionGetDaily
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
		public decimal? ClosePrice;
		/// <summary>
		/// 대비
		/// </summary>
		[JsonProperty("pre")]
		public decimal? Change;
		/// <summary>
		/// 기관기간누적
		/// </summary>
		[JsonProperty("orgn_dt_acc")]
		public decimal? InstitutionPeriodAccumulated;
		/// <summary>
		/// 기관일별순매매
		/// </summary>
		[JsonProperty("orgn_daly_nettrde")]
		public decimal? InstitutionDailyNetTrade;
		/// <summary>
		/// 외국인일별순매매
		/// </summary>
		[JsonProperty("frgnr_daly_nettrde")]
		public decimal? ForeignerDailyNetTrade;
		/// <summary>
		/// 외국인지분율ㄴ
		/// </summary>
		[JsonProperty("frgnr_qota_rt")]
		public decimal? ForeignerQuotaRate;
	}

	public record KiwoomForeignInstitutionGetContinuousTrades
	{
		/// <summary>
		/// 기관외국인연속매매현황
		/// </summary>
		[JsonProperty("orgn_frgnr_cont_trde_prst")]
		public IEnumerable<KiwoomForeignInstitutionGetContinuousTradeItem>? Items;
	}
	public record KiwoomForeignInstitutionGetContinuousTradeItem
	{
		/// <summary>
		/// 순위
		/// </summary>
		[JsonProperty("rank")]
		public string? Rank;
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
		public decimal? StockPriceFluctuationRateDuringPeriod;
		/// <summary>
		/// 기관순매매금액
		/// </summary>
		[JsonProperty("orgn_nettrde_amt")]
		public KiwoomDecimal? InstitutionNetTradeAmount;
		/// <summary>
		/// 기관순매매량
		/// </summary>
		[JsonProperty("orgn_nettrde_qty")]
		public KiwoomDecimal? InstitutionNetTradeQuantity;
		/// <summary>
		/// 기관계연속순매수일수
		/// </summary>
		[JsonProperty("orgn_cont_netprps_dys")]
		public decimal? InstitutionContinuousNetPurchaseDays;
		/// <summary>
		/// 기관계연속순매수량
		/// </summary>
		[JsonProperty("orgn_cont_netprps_qty")]
		public KiwoomDecimal? InstitutionContinuousNetPurchaseQuantity;
		/// <summary>
		/// 기관계연속순매수금액
		/// </summary>
		[JsonProperty("orgn_cont_netprps_amt")]
		public KiwoomDecimal? InstitutionContinuousNetPurchaseAmount;
		/// <summary>
		/// 외국인순매매량
		/// </summary>
		[JsonProperty("frgnr_nettrde_qty")]
		public KiwoomDecimal? ForeignerNetTradeQuantity;
		/// <summary>
		/// 외국인순매매액
		/// </summary>
		[JsonProperty("frgnr_nettrde_amt")]
		public KiwoomDecimal? ForeignerNetTradeAmount;
		/// <summary>
		/// 외국인연속순매수일수
		/// </summary>
		[JsonProperty("frgnr_cont_netprps_dys")]
		public decimal? ForeignerContinuousNetPurchaseDays;
		/// <summary>
		/// 외국인연속순매수량
		/// </summary>
		[JsonProperty("frgnr_cont_netprps_qty")]
		public KiwoomDecimal? ForeignerContinuousNetPurchaseQuantity;
		/// <summary>
		/// 외국인연속순매수금액
		/// </summary>
		[JsonProperty("frgnr_cont_netprps_amt")]
		public KiwoomDecimal? ForeignerContinuousNetPurchaseAmount;
		/// <summary>
		/// 순매매량
		/// </summary>
		[JsonProperty("nettrde_qty")]
		public KiwoomDecimal? NetTradeQuantity;
		/// <summary>
		/// 순매매액
		/// </summary>
		[JsonProperty("nettrde_amt")]
		public KiwoomDecimal? NetTradeAmount;
		/// <summary>
		/// 합계연속순매수일수
		/// </summary>
		[JsonProperty("tot_cont_netprps_dys")]
		public decimal? TotalContinuousNetPurchaseDays;
		/// <summary>
		/// 합계연속순매매수량
		/// </summary>
		[JsonProperty("tot_cont_nettrde_qty")]
		public KiwoomDecimal? TotalContinuousNetTradeQuantity;
		/// <summary>
		/// 합계연속순매수금액
		/// </summary>
		[JsonProperty("tot_cont_netprps_amt")]
		public KiwoomDecimal? TotalContinuousNetPurchaseAmount;
	}

}
