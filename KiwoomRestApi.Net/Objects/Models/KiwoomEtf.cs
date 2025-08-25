using KiwoomRestApi.Net.Converters;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models
{
	public record KiwoomEtfGetProfitRates
	{
		[JsonProperty("etfprft_rt_lst")]
		public IEnumerable<KiwoomEtfGetProfitRateItem>? Items;
	}
	public record KiwoomEtfGetProfitRateItem
	{
		[JsonProperty("etfprft_rt")]
		public decimal? EtfProfitRate;
		[JsonProperty("cntr_prft_rt")]
		public decimal? ContractProfitRate;
		[JsonProperty("for_netprps_qty")]
		public decimal? ForeignNetPurchaseQuantity;
		[JsonProperty("orgn_netprps_qty")]
		public decimal? OrganizationNetPurchaseQuantity;
	}

	public record KiwoomEtfGetInfo
	{
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("etfobjt_idex_nm")]
		public string? EtfTargetIndexName;
		[JsonProperty("wonju_pric")]
		public decimal? OriginalUnitPrice;
		[JsonProperty("etftxon_type")]
		public string? EtfTaxType;
		[JsonProperty("etntxon_type")]
		public string? EtnTaxType;
	}

	public record KiwoomEtfGetDailyTransactions
	{
		[JsonProperty("etfdaly_trnsn")]
		public IEnumerable<KiwoomEtfGetDailyTransactionItem>? Items;
	}
	public record KiwoomEtfGetDailyTransactionItem
	{
		[JsonProperty("cntr_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? ContractDate;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pre_sig")]
		public string? DifferenceSign;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		[JsonProperty("pre_rt")]
		public decimal? DifferenceRate;
		[JsonProperty("trde_qty")]
		public decimal? TradeVolume;
		[JsonProperty("nav")]
		public decimal? Nav;
		[JsonProperty("acc_trde_prica")]
		public decimal? AccumulatedTradeAmount;
		[JsonProperty("navidex_dispty_rt")]
		public decimal? NavIndexDisparityRate;
		[JsonProperty("navetfdispty_rt")]
		public decimal? NavEtfDisparityRate;
		[JsonProperty("trace_eor_rt")]
		public decimal? TrackingErrorRate;
		[JsonProperty("trace_cur_prc")]
		public decimal? TrackingCurrentPrice;
		[JsonProperty("trace_pred_pre")]
		public decimal? TrackingPreviousDifference;
		[JsonProperty("trace_pre_sig")]
		public string? TrackingDifferenceSign;
	}

	public record KiwoomEtfGetAllMarketPrices
	{
		[JsonProperty("etfall_mrpr")]
		public IEnumerable<KiwoomEtfGetAllMarketPriceItem>? Items;
	}
	public record KiwoomEtfGetAllMarketPriceItem
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_cls")]
		public string? StockClassification;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("close_pric")]
		public decimal? ClosingPrice;
		[JsonProperty("pre_sig")]
		public string? DifferenceSign;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		[JsonProperty("pre_rt")]
		public decimal? DifferenceRate;
		[JsonProperty("trde_qty")]
		public decimal? TradeVolume;
		[JsonProperty("nav")]
		public decimal? Nav;
		[JsonProperty("trace_eor_rt")]
		public decimal? TrackingErrorRate;
		[JsonProperty("txbs")]
		public string? TaxBase;
		[JsonProperty("dvid_bf_base")]
		public string? DividendBeforeBase;
		[JsonProperty("pred_dvida")]
		public decimal? PreviousDividend;
		[JsonProperty("trace_idex_nm")]
		public string? TrackingIndexName;
		[JsonProperty("drng")]
		public decimal? Multiple;
		[JsonProperty("trace_idex_cd")]
		public string? TrackingIndexCode;
		[JsonProperty("trace_idex")]
		public decimal? TrackingIndex;
		[JsonProperty("trace_flu_rt")]
		public decimal? TrackingFluctuationRate;
	}

	public record KiwoomEtfGetTimeIntervalTransitions
	{
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("etfobjt_idex_nm")]
		public string? EtfTargetIndexName;
		[JsonProperty("wonju_pric")]
		public decimal? OriginalUnitPrice;
		[JsonProperty("etftxon_type")]
		public string? EtfTaxType;
		[JsonProperty("etntxon_type")]
		public string? EtnTaxType;
		[JsonProperty("etftisl_trnsn")]
		public IEnumerable<KiwoomEtfGetTimeIntervalTransitionItem>? Items;
	}
	public record KiwoomEtfGetTimeIntervalTransitionItem
	{
		[JsonProperty("tm")]
		public string? Time;
		[JsonProperty("close_pric")]
		public decimal? ClosingPrice;
		[JsonProperty("pre_sig")]
		public string? DifferenceSign;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		[JsonProperty("trde_qty")]
		public decimal? TradeVolume;
		[JsonProperty("nav")]
		public decimal? Nav;
		[JsonProperty("trde_prica")]
		public decimal? TradeAmount;
		[JsonProperty("navidex")]
		public decimal? NavIndex;
		[JsonProperty("navetf")]
		public decimal? NavEtf;
		[JsonProperty("trace")]
		public decimal? Tracking;
		[JsonProperty("trace_idex")]
		public decimal? TrackingIndex;
		[JsonProperty("trace_idex_pred_pre")]
		public decimal? TrackingIndexPreviousDifference;
		[JsonProperty("trace_idex_pred_pre_sig")]
		public string? TrackingIndexPreviousDifferenceSign;
	}

	public record KiwoomEtfGetTimeIntervalContracts
	{
		[JsonProperty("stk_cls")]
		public string? StockClassification;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("etfobjt_idex_nm")]
		public string? EtfTargetIndexName;
		[JsonProperty("etfobjt_idex_cd")]
		public string? EtfTargetIndexCode;
		[JsonProperty("objt_idex_pre_rt")]
		public decimal? TargetIndexDifferenceRate;
		[JsonProperty("wonju_pric")]
		public decimal? OriginalUnitPrice;
		[JsonProperty("etftisl_cntr_array")]
		public IEnumerable<KiwoomEtfGetTimeIntervalContractItem>? Items;
	}
	public record KiwoomEtfGetTimeIntervalContractItem
	{
		[JsonProperty("cntr_tm")]
		public string? TransactionTime;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pre_sig")]
		public string? DifferenceSign;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		[JsonProperty("trde_qty")]
		public decimal? TradeVolume;
		[JsonProperty("stex_tp")]
		public string? StockExchangeType;
	}

	public record KiwoomEtfGetNetPurchaseQuantities
	{
		[JsonProperty("cntr_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? TransactionTime;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pre_sig")]
		public string? DifferenceSign;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		[JsonProperty("trde_qty")]
		public decimal? TradeVolume;
		[JsonProperty("etfnetprps_qty_array")]
		public IEnumerable<KiwoomEtfGetNetPurchaseQuantityItem>? Items;
	}
	public record KiwoomEtfGetNetPurchaseQuantityItem
	{
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		[JsonProperty("cur_prc_n")]
		public decimal? CurrentPriceN;
		[JsonProperty("pre_sig_n")]
		public string? DifferenceSignN;
		[JsonProperty("pred_pre_n")]
		public decimal? PreviousDifferenceN;
		[JsonProperty("acc_trde_qty")]
		public decimal? AccumulatedTradeVolume;
		[JsonProperty("for_netprps_qty")]
		public decimal? ForeignNetPurchaseQuantity;
		[JsonProperty("orgn_netprps_qty")]
		public decimal? OrganizationNetPurchaseQuantity;
	}

	public record KiwoomEtfGetNavs
	{
		[JsonProperty("etfnavarray")]
		public IEnumerable<KiwoomEtfGetNavItem>? Items;
	}
	public record KiwoomEtfGetNavItem
	{
		[JsonProperty("nav")]
		public decimal? Nav;
		[JsonProperty("navpred_pre")]
		public decimal? NavPreviousDifference;
		[JsonProperty("navflu_rt")]
		public decimal? NavFluctuationRate;
		[JsonProperty("trace_eor_rt")]
		public decimal? TrackingErrorRate;
		[JsonProperty("dispty_rt")]
		public decimal? DisparityRate;
		[JsonProperty("stkcnt")]
		public int? StockCount;
		[JsonProperty("base_pric")]
		public decimal? BasePrice;
		[JsonProperty("for_rmnd_qty")]
		public decimal? ForeignRemainingQuantity;
		[JsonProperty("repl_pric")]
		public decimal? ReplacementPrice;
		[JsonProperty("conv_pric")]
		public decimal? ConvertedPrice;
		[JsonProperty("drstk")]
		public decimal? DrPerStock;
		[JsonProperty("wonju_pric")]
		public decimal? OriginalUnitPrice;
	}

	public record KiwoomEtfGetTimeIntervalTransitions2
	{
		[JsonProperty("etftisl_trnsn")]
		public IEnumerable<KiwoomEtfGetTimeIntervalTransitionItem2>? Items;
	}
	public record KiwoomEtfGetTimeIntervalTransitionItem2
	{
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pre_sig")]
		public string? DifferenceSign;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		[JsonProperty("trde_qty")]
		public decimal? TradeVolume;
		[JsonProperty("for_netprps")]
		public decimal? ForeignNetPurchase;
	}
}
