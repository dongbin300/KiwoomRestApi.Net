using KiwoomRestApi.Net.Converters;
using KiwoomRestApi.Net.Objects.Commons;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models
{
	public record KiwoomForeignInstitutionGetStockForeigners
	{
		[JsonProperty("stk_frgnr")]
		public IEnumerable<KiwoomForeignInstitutionGetStockForeignerItem>? Items;
	}
	public record KiwoomForeignInstitutionGetStockForeignerItem
	{
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		[JsonProperty("close_pric")]
		public decimal? ClosePrice;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDayChange;
		[JsonProperty("trde_qty")]
		public decimal? TradeQuantity;
		[JsonProperty("chg_qty")]
		public decimal? ChangeQuantity;
		[JsonProperty("poss_stkcnt")]
		public decimal? HoldingStockCount;
		[JsonProperty("wght")]
		public decimal? Weight;
		[JsonProperty("gain_pos_stkcnt")]
		public decimal? GainPossibleStockCount;
		[JsonProperty("frgnr_limit")]
		public decimal? ForeignerLimit;
		[JsonProperty("frgnr_limit_irds")]
		public decimal? ForeignerLimitIncrease;
		[JsonProperty("limit_exh_rt")]
		public decimal? LimitExhaustionRate;
	}

	public record KiwoomForeignInstitutionGetDaily
	{
		[JsonProperty("date")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		[JsonProperty("close_pric")]
		public decimal? ClosePrice;
		[JsonProperty("pre")]
		public decimal? Change;
		[JsonProperty("orgn_dt_acc")]
		public decimal? InstitutionPeriodAccumulated;
		[JsonProperty("orgn_daly_nettrde")]
		public decimal? InstitutionDailyNetTrade;
		[JsonProperty("frgnr_daly_nettrde")]
		public decimal? ForeignerDailyNetTrade;
		[JsonProperty("frgnr_qota_rt")]
		public decimal? ForeignerQuotaRate;
	}

	public record KiwoomForeignInstitutionGetContinuousTrades
	{
		[JsonProperty("orgn_frgnr_cont_trde_prst")]
		public IEnumerable<KiwoomForeignInstitutionGetContinuousTradeItem>? Items;
	}
	public record KiwoomForeignInstitutionGetContinuousTradeItem
	{
		[JsonProperty("rank")]
		public string? Rank;
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("prid_stkpc_flu_rt")]
		public decimal? StockPriceFluctuationRateDuringPeriod;
		[JsonProperty("orgn_nettrde_amt")]
		public KiwoomDecimal? InstitutionNetTradeAmount;
		[JsonProperty("orgn_nettrde_qty")]
		public KiwoomDecimal? InstitutionNetTradeQuantity;
		[JsonProperty("orgn_cont_netprps_dys")]
		public decimal? InstitutionContinuousNetPurchaseDays;
		[JsonProperty("orgn_cont_netprps_qty")]
		public KiwoomDecimal? InstitutionContinuousNetPurchaseQuantity;
		[JsonProperty("orgn_cont_netprps_amt")]
		public KiwoomDecimal? InstitutionContinuousNetPurchaseAmount;
		[JsonProperty("frgnr_nettrde_qty")]
		public KiwoomDecimal? ForeignerNetTradeQuantity;
		[JsonProperty("frgnr_nettrde_amt")]
		public KiwoomDecimal? ForeignerNetTradeAmount;
		[JsonProperty("frgnr_cont_netprps_dys")]
		public decimal? ForeignerContinuousNetPurchaseDays;
		[JsonProperty("frgnr_cont_netprps_qty")]
		public KiwoomDecimal? ForeignerContinuousNetPurchaseQuantity;
		[JsonProperty("frgnr_cont_netprps_amt")]
		public KiwoomDecimal? ForeignerContinuousNetPurchaseAmount;
		[JsonProperty("nettrde_qty")]
		public KiwoomDecimal? NetTradeQuantity;
		[JsonProperty("nettrde_amt")]
		public KiwoomDecimal? NetTradeAmount;
		[JsonProperty("tot_cont_netprps_dys")]
		public decimal? TotalContinuousNetPurchaseDays;
		[JsonProperty("tot_cont_nettrde_qty")]
		public KiwoomDecimal? TotalContinuousNetTradeQuantity;
		[JsonProperty("tot_cont_netprps_amt")]
		public KiwoomDecimal? TotalContinuousNetPurchaseAmount;
	}

}
