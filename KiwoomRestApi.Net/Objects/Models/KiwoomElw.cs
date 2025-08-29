using KiwoomRestApi.Net.Converters;
using KiwoomRestApi.Net.Objects.Commons;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models
{
	public record KiwoomElwGetDailySensitivityIndices
	{
		[JsonProperty("elwdaly_snst_ix")]
		public IEnumerable<KiwoomElwGetDailySensitivityIndexItem>? Items;
	}
	public record KiwoomElwGetDailySensitivityIndexItem
	{
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		[JsonProperty("iv")]
		public decimal? Iv;
		[JsonProperty("delta")]
		public decimal? Delta;
		[JsonProperty("gam")]
		public decimal? Gamma;
		[JsonProperty("theta")]
		public decimal? Theta;
		[JsonProperty("vega")]
		public decimal? Vega;
		[JsonProperty("law")]
		public decimal? Law;
		[JsonProperty("lp")]
		public decimal? Lp;
	}

	public record KiwoomElwGetSensitivityIndeices
	{
		[JsonProperty("elwsnst_ix_array")]
		public IEnumerable<KiwoomElwGetSensitivityIndexItem>? Items;
	}
	public record KiwoomElwGetSensitivityIndexItem
	{
		[JsonProperty("cntr_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? ContractTime;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("elwtheory_pric")]
		public decimal? ElwTheoryPrice;
		[JsonProperty("iv")]
		public decimal? Iv;
		[JsonProperty("delta")]
		public decimal? Delta;
		[JsonProperty("gam")]
		public decimal? Gamma;
		[JsonProperty("theta")]
		public decimal? Theta;
		[JsonProperty("vega")]
		public decimal? Vega;
		[JsonProperty("law")]
		public decimal? Law;
		[JsonProperty("lp")]
		public decimal? Lp;
	}

	public record KiwoomElwGetPriceJumpFluctuations
	{
		[JsonProperty("base_pric_tm")]
		public string? BasePriceTime;
		[JsonProperty("elwpric_jmpflu")]
		public IEnumerable<KiwoomElwGetPriceJumpFluctuationItem>? Items;
	}
	public record KiwoomElwGetPriceJumpFluctuationItem
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("rank")]
		public int? Rank;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("pre_sig")]
		public string? PreviousSign;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		[JsonProperty("trde_end_elwbase_pric")]
		public decimal? TradeEndElwBasePrice;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("base_pre")]
		public decimal? BaseDifference;
		[JsonProperty("trde_qty")]
		public decimal? TradeVolume;
		[JsonProperty("jmp_rt")]
		public decimal? JumpRate;
	}

	public record KiwoomElwGetNetTradeTopByTraders
	{
		[JsonProperty("trde_ori_elwnettrde_upper")]
		public IEnumerable<KiwoomElwGetNetTradeTopByTraderItem>? Items;
	}
	public record KiwoomElwGetNetTradeTopByTraderItem
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("stkpc_flu")]
		public KiwoomDecimal? PriceFluctuation;
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		[JsonProperty("trde_qty")]
		public decimal? TradeVolume;
		[JsonProperty("netprps")]
		public decimal? NetPurchase;
		[JsonProperty("buy_trde_qty")]
		public decimal? BuyTradeVolume;
		[JsonProperty("sel_trde_qty")]
		public decimal? SellTradeVolume;
	}

	public record KiwoomElwGetLpHoldingDailyTrends
	{
		[JsonProperty("elwlpposs_daly_trnsn")]
		public IEnumerable<KiwoomElwGetLpHoldingDailyTrendItem>? Items;
	}
	public record KiwoomElwGetLpHoldingDailyTrendItem
	{
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pre_tp")]
		public string? DifferenceType;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		[JsonProperty("trde_qty")]
		public decimal? TradeVolume;
		[JsonProperty("trde_prica")]
		public decimal? TradeAmount;
		[JsonProperty("chg_qty")]
		public decimal? ChangeQuantity;
		[JsonProperty("lprmnd_qty")]
		public decimal? LpHoldingQuantity;
		[JsonProperty("wght")]
		public decimal? Weight;
	}

	public record KiwoomElwGetDisparityRates
	{
		[JsonProperty("elwdispty_rt")]
		public IEnumerable<KiwoomElwGetDisparityRateItem>? Items;
	}

	public record KiwoomElwGetDisparityRateItem
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("isscomp_nm")]
		public string? IssuerCompanyName;
		[JsonProperty("sqnc")]
		public string? Sequence;
		[JsonProperty("base_aset_nm")]
		public string? BaseAssetName;
		[JsonProperty("rght_tp")]
		public string? RightType;
		[JsonProperty("dispty_rt")]
		public KiwoomDecimal? DisparityRate;
		[JsonProperty("basis")]
		public KiwoomDecimal? Basis;
		[JsonProperty("srvive_dys")]
		public int? RemainingDays;
		[JsonProperty("theory_pric")]
		public decimal? TheoryPrice;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pre_tp")]
		public string? DifferenceType;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		[JsonProperty("trde_qty")]
		public decimal? TradeVolume;
		[JsonProperty("stk_nm")]
		public string? StockName;
	}

	public record KiwoomElwGetConditionSearchs
	{
		[JsonProperty("elwcnd_qry")]
		public IEnumerable<KiwoomElwGetConditionSearchItem>? Items;
	}
	public record KiwoomElwGetConditionSearchItem
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("isscomp_nm")]
		public string? IssuerCompanyName;
		[JsonProperty("sqnc")]
		public string? Sequence;
		[JsonProperty("base_aset_nm")]
		public string? BaseAssetName;
		[JsonProperty("rght_tp")]
		public string? RightType;
		[JsonProperty("expr_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? ExpirationDate;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pre_tp")]
		public string? DifferenceType;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		[JsonProperty("trde_qty")]
		public decimal? TradeVolume;
		[JsonProperty("trde_qty_pre")]
		public decimal? TradeVolumeCompared;
		[JsonProperty("trde_prica")]
		public decimal? TradeAmount;
		[JsonProperty("pred_trde_qty")]
		public decimal? PreviousTradeVolume;
		[JsonProperty("sel_bid")]
		public decimal? SellBidPrice;
		[JsonProperty("buy_bid")]
		public decimal? BuyBidPrice;
		[JsonProperty("prty")]
		public decimal? Parity;
		[JsonProperty("gear_rt")]
		public decimal? GearingRatio;
		[JsonProperty("pl_qutr_rt")]
		public decimal? BreakEvenRatio;
		[JsonProperty("cfp")]
		public decimal? CapitalSupportPoint;
		[JsonProperty("theory_pric")]
		public decimal? TheoryPrice;
		[JsonProperty("innr_vltl")]
		public decimal? ImpliedVolatility;
		[JsonProperty("delta")]
		public decimal? Delta;
		[JsonProperty("lvrg")]
		public decimal? Leverage;
		[JsonProperty("exec_pric")]
		public decimal? ExercisePrice;
		[JsonProperty("cnvt_rt")]
		public decimal? ConversionRatio;
		[JsonProperty("lpposs_rt")]
		public decimal? LpHoldingRate;
		[JsonProperty("pl_qutr_pt")]
		public decimal? BreakEvenPoint;
		[JsonProperty("fin_trde_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? FinalTradeDate;
		[JsonProperty("flo_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? ListingDate;
		[JsonProperty("lpinitlast_suply_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? LpInitialLastSupplyDate;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("srvive_dys")]
		public int? RemainingDays;
		[JsonProperty("dispty_rt")]
		public decimal? DisparityRate;
		[JsonProperty("lpmmcm_nm")]
		public string? LpMemberName;
		[JsonProperty("lpmmcm_nm_1")]
		public string? LpMemberName1;
		[JsonProperty("lpmmcm_nm_2")]
		public string? LpMemberName2;
		[JsonProperty("xraymont_cntr_qty_arng_trde_tp")]
		public string? XrayInstantTradeClassification;
		[JsonProperty("xraymont_cntr_qty_profa_100tp")]
		public string? XrayInstantTradeMargin100Classification;
	}

	public record KiwoomElwGetFluctuationRateRanks
	{
		[JsonProperty("elwflu_rt_rank")]
		public IEnumerable<KiwoomElwGetFluctuationRateRankItem>? Items;
	}
	public record KiwoomElwGetFluctuationRateRankItem
	{
		[JsonProperty("rank")]
		public int? Rank;
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pre_sig")]
		public string? DifferenceSign;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		[JsonProperty("sel_req")]
		public decimal? SellRequestVolume;
		[JsonProperty("buy_req")]
		public decimal? BuyRequestVolume;
		[JsonProperty("trde_qty")]
		public decimal? TradeVolume;
		[JsonProperty("trde_prica")]
		public decimal? TradeAmount;
	}

	public record KiwoomElwGetRequestRanks
	{
		[JsonProperty("elwreq_rank")]
		public IEnumerable<KiwoomElwGetRequestRankItem>? Items;
	}
	public record KiwoomElwGetRequestRankItem
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("rank")]
		public int? Rank;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pre_sig")]
		public string? DifferenceSign;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		[JsonProperty("trde_qty")]
		public decimal? TradeVolume;
		[JsonProperty("sel_req")]
		public decimal? SellRequestVolume;
		[JsonProperty("buy_req")]
		public decimal? BuyRequestVolume;
		[JsonProperty("netprps_req")]
		public decimal? NetPurchaseRequestVolume;
		[JsonProperty("trde_prica")]
		public decimal? TradeAmount;
	}

	public record KiwoomElwGetProximityRates
	{
		[JsonProperty("elwalacc_rt")]
		public IEnumerable<KiwoomElwGetProximityRateItem>? Items;
	}
	public record KiwoomElwGetProximityRateItem
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pre_sig")]
		public string? DifferenceSign;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		[JsonProperty("acc_trde_qty")]
		public decimal? AccumulatedTradeVolume;
		[JsonProperty("alacc_rt")]
		public decimal? ProximityRate;
	}

	public record KiwoomElwGetAssetInfo
	{
		[JsonProperty("aset_cd")]
		public string? AssetCode;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pred_pre_sig")]
		public string? PreviousDifferenceSign;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		[JsonProperty("lpmmcm_nm")]
		public string? LpMemberName;
		[JsonProperty("lpmmcm_nm_1")]
		public string? LpMemberName1;
		[JsonProperty("lpmmcm_nm_2")]
		public string? LpMemberName2;
		[JsonProperty("elwrght_cntn")]
		public string? ElwRightContent;
		[JsonProperty("elwexpr_evlt_pric")]
		public decimal? ElwExpirationEvaluationPrice;
		[JsonProperty("elwtheory_pric")]
		public decimal? ElwTheoryPrice;
		[JsonProperty("dispty_rt")]
		public decimal? DisparityRate;
		[JsonProperty("elwinnr_vltl")]
		public decimal? ElwImpliedVolatility;
		[JsonProperty("exp_rght_pric")]
		public decimal? ExpectedRightPrice;
		[JsonProperty("elwpl_qutr_rt")]
		public decimal? ElwBreakEvenRatio;
		[JsonProperty("elwexec_pric")]
		public decimal? ElwExercisePrice;
		[JsonProperty("elwcnvt_rt")]
		public decimal? ElwConversionRatio;
		[JsonProperty("elwcmpn_rt")]
		public decimal? ElwCompensationRatio;
		[JsonProperty("elwpric_rising_part_rt")]
		public decimal? ElwPriceRisingParticipationRate;
		[JsonProperty("elwrght_type")]
		public string? ElwRightType;
		[JsonProperty("elwsrvive_dys")]
		public int? ElwRemainingDays;
		[JsonProperty("stkcnt")]
		public int? StockCount;
		[JsonProperty("elwlpord_pos")]
		public string? ElwLpOrderPossible;
		[JsonProperty("lpposs_rt")]
		public decimal? LpHoldingRate;
		[JsonProperty("lprmnd_qty")]
		public decimal? LpHoldingQuantity;
		[JsonProperty("elwspread")]
		public decimal? ElwSpread;
		[JsonProperty("elwprty")]
		public decimal? ElwParity;
		[JsonProperty("elwgear")]
		public decimal? ElwGearing;
		[JsonProperty("elwflo_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? ElwListingDate;
		[JsonProperty("elwfin_trde_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? ElwFinalTradeDate;
		[JsonProperty("expr_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? ExpirationDate;
		[JsonProperty("exec_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? ExerciseDate;
		[JsonProperty("lpsuply_end_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? LpSupplyEndDate;
		[JsonProperty("elwpay_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? ElwPaymentDate;
		[JsonProperty("elwinvt_ix_comput")]
		public string? ElwInvestmentIndexComputation;
		[JsonProperty("elwpay_agnt")]
		public string? ElwPaymentAgent;
		[JsonProperty("elwappr_way")]
		public string? ElwApprovalMethod;
		[JsonProperty("elwrght_exec_way")]
		public string? ElwRightExerciseMethod;
		[JsonProperty("elwpblicte_orgn")]
		public string? ElwIssuingInstitution;
		[JsonProperty("dcsn_pay_amt")]
		public decimal? DecisionPaymentAmount;
		[JsonProperty("kobarr")]
		public string? KoBarrier;
		[JsonProperty("iv")]
		public decimal? ImpliedVolatility;
		[JsonProperty("clsprd_end_elwocr")]
		public string? ClosingPeriodEndElwOccurrence;
		[JsonProperty("bsis_aset_1")]
		public string? BaseAsset1;
		[JsonProperty("bsis_aset_comp_rt_1")]
		public decimal? BaseAssetCompositionRate1;
		[JsonProperty("bsis_aset_2")]
		public string? BaseAsset2;
		[JsonProperty("bsis_aset_comp_rt_2")]
		public decimal? BaseAssetCompositionRate2;
		[JsonProperty("bsis_aset_3")]
		public string? BaseAsset3;
		[JsonProperty("bsis_aset_comp_rt_3")]
		public decimal? BaseAssetCompositionRate3;
		[JsonProperty("bsis_aset_4")]
		public string? BaseAsset4;
		[JsonProperty("bsis_aset_comp_rt_4")]
		public decimal? BaseAssetCompositionRate4;
		[JsonProperty("bsis_aset_5")]
		public string? BaseAsset5;
		[JsonProperty("bsis_aset_comp_rt_5")]
		public decimal? BaseAssetCompositionRate5;
		[JsonProperty("fr_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? EvaluationStartDate;
		[JsonProperty("to_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? EvaluationEndDate;
		[JsonProperty("fr_tm")]
		public string? EvaluationStartTime;
		[JsonProperty("evlt_end_tm")]
		public string? EvaluationEndTime;
		[JsonProperty("evlt_pric")]
		public decimal? EvaluationPrice;
		[JsonProperty("evlt_fnsh_yn")]
		public string? EvaluationFinishedYn;
		[JsonProperty("all_hgst_pric")]
		public decimal? AllTimeHighPrice;
		[JsonProperty("all_lwst_pric")]
		public decimal? AllTimeLowPrice;
		[JsonProperty("imaf_hgst_pric")]
		public decimal? ImmediateAfterHighPrice;
		[JsonProperty("imaf_lwst_pric")]
		public decimal? ImmediateAfterLowPrice;
		[JsonProperty("sndhalf_mrkt_hgst_pric")]
		public decimal? SecondHalfMarketHighPrice;
		[JsonProperty("sndhalf_mrkt_lwst_pric")]
		public decimal? SecondHalfMarketLowPrice;
	}
}
