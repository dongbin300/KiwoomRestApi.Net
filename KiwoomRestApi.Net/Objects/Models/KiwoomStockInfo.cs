using KiwoomRestApi.Net.Converters;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models
{
	public record KiwoomStockInfoGetStockInfo
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("setl_mm")]
		public decimal? SettlementMonth;
		[JsonProperty("fav")]
		public decimal? FaceValue;
		[JsonProperty("cap")]
		public decimal? Capital;
		[JsonProperty("flo_stk")]
		public decimal? ListedStocks;
		[JsonProperty("crd_rt")]
		public decimal? CreditRatio;
		[JsonProperty("oyr_hgst")]
		public decimal? YearHigh;
		[JsonProperty("oyr_lwst")]
		public decimal? YearLow;
		[JsonProperty("mac")]
		public decimal? MarketCap;
		[JsonProperty("mac_wght")]
		public decimal? MarketCapWeight;
		[JsonProperty("for_exh_rt")]
		public decimal? ForeignOwnershipRate;
		[JsonProperty("repl_pric")]
		public decimal? SubstitutePrice;
		[JsonProperty("per")]
		public decimal? PER;
		[JsonProperty("eps")]
		public decimal? EPS;
		[JsonProperty("roe")]
		public decimal? ROE;
		[JsonProperty("pbr")]
		public decimal? PBR;
		[JsonProperty("ev")]
		public decimal? EV;
		[JsonProperty("bps")]
		public decimal? BPS;
		[JsonProperty("sale_amt")]
		public decimal? SalesAmount;
		[JsonProperty("bus_pro")]
		public decimal? OperatingProfit;
		[JsonProperty("cup_nga")]
		public decimal? NetIncome;
		[JsonProperty("250hgst")]
		public decimal? High250;
		[JsonProperty("250lwst")]
		public decimal? Low250;
		[JsonProperty("high_pric")]
		public decimal? HighPrice;
		[JsonProperty("open_pric")]
		public decimal? OpenPrice;
		[JsonProperty("low_pric")]
		public decimal? LowPrice;
		[JsonProperty("upl_pric")]
		public decimal? UpperLimitPrice;
		[JsonProperty("lst_pric")]
		public decimal? LowerLimitPrice;
		[JsonProperty("base_pric")]
		public decimal? BasePrice;
		[JsonProperty("exp_cntr_pric")]
		public decimal? ExpectedContractPrice;
		[JsonProperty("exp_cntr_qty")]
		public decimal? ExpectedContractQuantity;
		[JsonProperty("250hgst_pric_dt")]
		[JsonConverter(typeof(KiwoomNullableDateConverter))]
		public DateTime? DateHigh250;
		[JsonProperty("250hgst_pric_pre_rt")]
		public decimal? RateComparedToHigh250;
		[JsonProperty("250lwst_pric_dt")]
		[JsonConverter(typeof(KiwoomNullableDateConverter))]
		public DateTime? DateLow250;
		[JsonProperty("250lwst_pric_pre_rt")]
		public decimal? RateComparedToLow250;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pre_sig")]
		public string? PriceDiffSymbol;
		[JsonProperty("pred_pre")]
		public decimal? PriceDiffAmount;
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		[JsonProperty("trde_qty")]
		public decimal? TradeVolume;
		[JsonProperty("trde_pre")]
		public decimal? TradeComparison;
		[JsonProperty("fav_unit")]
		public string? FaceValueUnit;
		[JsonProperty("dstr_stk")]
		public decimal? DistributionStocks;
		[JsonProperty("dstr_rt")]
		public decimal? DistributionRate;
	}

	public record KiwoomStockInfoGetTradeInfo
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("flu_smbol")]
		public string? FluctuationSymbol;
		[JsonProperty("base_pric")]
		public decimal? BasePrice;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		[JsonProperty("sel_trde_ori_nm_1")]
		public string? SellTraderName1;
		[JsonProperty("sel_trde_ori_1")]
		public string? SellTrader1;
		[JsonProperty("sel_trde_qty_1")]
		public decimal? SellTradeQty1;
		[JsonProperty("buy_trde_ori_nm_1")]
		public string? BuyTraderName1;
		[JsonProperty("buy_trde_ori_1")]
		public string? BuyTrader1;
		[JsonProperty("buy_trde_qty_1")]
		public decimal? BuyTradeQty1;
		[JsonProperty("sel_trde_ori_nm_2")]
		public string? SellTraderName2;
		[JsonProperty("sel_trde_ori_2")]
		public string? SellTrader2;
		[JsonProperty("sel_trde_qty_2")]
		public decimal? SellTradeQty2;
		[JsonProperty("buy_trde_ori_nm_2")]
		public string? BuyTraderName2;
		[JsonProperty("buy_trde_ori_2")]
		public string? BuyTrader2;
		[JsonProperty("buy_trde_qty_2")]
		public decimal? BuyTradeQty2;
		[JsonProperty("sel_trde_ori_nm_3")]
		public string? SellTraderName3;
		[JsonProperty("sel_trde_ori_3")]
		public string? SellTrader3;
		[JsonProperty("sel_trde_qty_3")]
		public decimal? SellTradeQty3;
		[JsonProperty("buy_trde_ori_nm_3")]
		public string? BuyTraderName3;
		[JsonProperty("buy_trde_ori_3")]
		public string? BuyTrader3;
		[JsonProperty("buy_trde_qty_3")]
		public decimal? BuyTradeQty3;
		[JsonProperty("sel_trde_ori_nm_4")]
		public string? SellTraderName4;
		[JsonProperty("sel_trde_ori_4")]
		public string? SellTrader4;
		[JsonProperty("sel_trde_qty_4")]
		public decimal? SellTradeQty4;
		[JsonProperty("buy_trde_ori_nm_4")]
		public string? BuyTraderName4;
		[JsonProperty("buy_trde_ori_4")]
		public string? BuyTrader4;
		[JsonProperty("buy_trde_qty_4")]
		public decimal? BuyTradeQty4;
		[JsonProperty("sel_trde_ori_nm_5")]
		public string? SellTraderName5;
		[JsonProperty("sel_trde_ori_5")]
		public string? SellTrader5;
		[JsonProperty("sel_trde_qty_5")]
		public decimal? SellTradeQty5;
		[JsonProperty("buy_trde_ori_nm_5")]
		public string? BuyTraderName5;
		[JsonProperty("buy_trde_ori_5")]
		public string? BuyTrader5;
		[JsonProperty("buy_trde_qty_5")]
		public decimal? BuyTradeQty5;
	}

	public record KiwoomStockInfoGetContracts
	{
		[JsonProperty("cntr_infr")]
		public IEnumerable<KiwoomStockInfoGetContractItem>? Items;
	}
	public record KiwoomStockInfoGetContractItem
	{
		[JsonProperty("tm")]
		[JsonConverter(typeof(KiwoomTimeConverter))]
		public TimeSpan? Time;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		[JsonProperty("pre_rt")]
		public decimal? DifferenceRate;
		[JsonProperty("pri_sel_bid_unit")]
		public decimal? PrioritySellBidUnit;
		[JsonProperty("pri_buy_bid_unit")]
		public decimal? PriorityBuyBidUnit;
		[JsonProperty("cntr_trde_qty")]
		public decimal? TradeQuantity;
		[JsonProperty("sign")]
		public string? Sign;
		[JsonProperty("acc_trde_qty")]
		public decimal? AccumulatedTradeQuantity;
		[JsonProperty("acc_trde_prica")]
		public decimal? AccumulatedTradeAmount;
		[JsonProperty("cntr_str")]
		public decimal? TradeStrength;
		[JsonProperty("stex_tp")]
		public string? ExchangeType;
	}

	public record KiwoomStockInfoGetCreditTradeTrends
	{
		[JsonProperty("crd_trde_trend")]
		public IEnumerable<KiwoomStockInfoGetCreditTradeTrendItem>? Items;
	}
	public record KiwoomStockInfoGetCreditTradeTrendItem
	{
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomNullableDateConverter))]
		public DateTime? Date;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pred_pre_sig")]
		public string? PreviousDifferenceSymbol;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		[JsonProperty("trde_qty")]
		public decimal? TradeQuantity;
		[JsonProperty("new")]
		public decimal? NewCount;
		[JsonProperty("rpya")]
		public decimal? Repayment;
		[JsonProperty("remn")]
		public decimal? Balance;
		[JsonProperty("amt")]
		public decimal? Amount;
		[JsonProperty("pre")]
		public decimal? Difference;
		[JsonProperty("shr_rt")]
		public decimal? LoanRate;
		[JsonProperty("remn_rt")]
		public decimal? BalanceRate;
	}

	public record KiwoomStockInfoGetDailyTradeDetails
	{
		[JsonProperty("daly_trde_dtl")]
		public IEnumerable<KiwoomStockInfoGetDailyTradeDetailItem>? Items;
	}
	public record KiwoomStockInfoGetDailyTradeDetailItem
	{
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomNullableDateConverter))]
		public DateTime? Date;
		[JsonProperty("close_pric")]
		public decimal? ClosePrice;
		[JsonProperty("pred_pre_sig")]
		public string? PreviousDifferenceSymbol;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		[JsonProperty("trde_qty")]
		public decimal? TradeQuantity;
		[JsonProperty("trde_prica")]
		public decimal? TradeAmount;
		[JsonProperty("bf_mkrt_trde_qty")]
		public decimal? BeforeMarketTradeQuantity;
		[JsonProperty("bf_mkrt_trde_wght")]
		public decimal? BeforeMarketTradeWeight;
		[JsonProperty("opmr_trde_qty")]
		public decimal? OpenMarketTradeQuantity;
		[JsonProperty("opmr_trde_wght")]
		public decimal? OpenMarketTradeWeight;
		[JsonProperty("af_mkrt_trde_qty")]
		public decimal? AfterMarketTradeQuantity;
		[JsonProperty("af_mkrt_trde_wght")]
		public decimal? AfterMarketTradeWeight;
		[JsonProperty("tot_3")]
		public decimal? Total3;
		[JsonProperty("prid_trde_qty")]
		public decimal? PeriodTradeQuantity;
		[JsonProperty("cntr_str")]
		public decimal? ContractStrength;
		[JsonProperty("for_poss")]
		public decimal? ForeignPossession;
		[JsonProperty("for_wght")]
		public decimal? ForeignWeight;
		[JsonProperty("for_netprps")]
		public decimal? ForeignNetPurchase;
		[JsonProperty("orgn_netprps")]
		public decimal? InstitutionNetPurchase;
		[JsonProperty("ind_netprps")]
		public decimal? IndividualNetPurchase;
		[JsonProperty("frgn")]
		public decimal? ForeignType;
		[JsonProperty("crd_remn_rt")]
		public decimal? CreditBalanceRate;
		[JsonProperty("prm")]
		public decimal? Program;
		[JsonProperty("bf_mkrt_trde_prica")]
		public decimal? BeforeMarketTradeAmount;
		[JsonProperty("bf_mkrt_trde_prica_wght")]
		public decimal? BeforeMarketTradeAmountWeight;
		[JsonProperty("opmr_trde_prica")]
		public decimal? OpenMarketTradeAmount;
		[JsonProperty("opmr_trde_prica_wght")]
		public decimal? OpenMarketTradeAmountWeight;
		[JsonProperty("af_mkrt_trde_prica")]
		public decimal? AfterMarketTradeAmount;
		[JsonProperty("af_mkrt_trde_prica_wght")]
		public decimal? AfterMarketTradeAmountWeight;
	}

	public record KiwoomStockInfoGetLowPrices
	{
		[JsonProperty("ntl_pric")]
		public IEnumerable<KiwoomStockInfoGetLowPriceItem>? Items;
	}
	public record KiwoomStockInfoGetLowPriceItem
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pred_pre_sig")]
		public string? PreviousDifferenceSymbol;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		[JsonProperty("trde_qty")]
		public decimal? TradeQuantity;
		[JsonProperty("pred_trde_qty_pre_rt")]
		public decimal? PreviousTradeQtyRate;
		[JsonProperty("sel_bid")]
		public decimal? SellBid;
		[JsonProperty("buy_bid")]
		public decimal? BuyBid;
		[JsonProperty("high_pric")]
		public decimal? HighPrice;
		[JsonProperty("low_pric")]
		public decimal? LowPrice;
	}

	public record KiwoomStockInfoGetUpdownPrices
	{
		[JsonProperty("updown_pric")]
		public IEnumerable<KiwoomStockInfoGetUpdownPriceItem>? Items;
	}
	public record KiwoomStockInfoGetUpdownPriceItem
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_infr")]
		public string? StockInfo;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pred_pre_sig")]
		public string? PreviousDifferenceSymbol;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		[JsonProperty("trde_qty")]
		public decimal? TradeQuantity;
		[JsonProperty("pred_trde_qty")]
		public decimal? PreviousTradeQuantity;
		[JsonProperty("sel_req")]
		public decimal? SellRemainingQuantity;
		[JsonProperty("sel_bid")]
		public decimal? SellBid;
		[JsonProperty("buy_bid")]
		public decimal? BuyBid;
		[JsonProperty("buy_req")]
		public decimal? BuyRemainingQuantity;
		[JsonProperty("cnt")]
		public decimal? Count;
	}

	public record KiwoomStockInfoGetHighLowPriceProximities
	{
		[JsonProperty("high_low_pric_alacc")]
		public IEnumerable<KiwoomStockInfoGetHighLowPriceProximityItem>? Items;
	}
	public record KiwoomStockInfoGetHighLowPriceProximityItem
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pred_pre_sig")]
		public string? PreviousDifferenceSymbol;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		[JsonProperty("trde_qty")]
		public decimal? TradeQuantity;
		[JsonProperty("sel_bid")]
		public decimal? SellBid;
		[JsonProperty("buy_bid")]
		public decimal? BuyBid;
		[JsonProperty("tdy_high_pric")]
		public decimal? TodayHighPrice;
		[JsonProperty("tdy_low_pric")]
		public decimal? TodayLowPrice;
	}

	public record KiwoomStockInfoGetPriceJumpFluctuations
	{
		[JsonProperty("pric_jmpflu")]
		public IEnumerable<KiwoomStockInfoGetPriceJumpFluctuationItem>? Items;
	}
	public record KiwoomStockInfoGetPriceJumpFluctuationItem
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_cls")]
		public string? StockClass;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("pred_pre_sig")]
		public string? PreviousDifferenceSymbol;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		[JsonProperty("base_pric")]
		public decimal? BasePrice;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("base_pre")]
		public decimal? BaseDifference;
		[JsonProperty("trde_qty")]
		public decimal? TradeQuantity;
		[JsonProperty("jmp_rt")]
		public decimal? JumpRate;
	}

	public record KiwoomStockInfoGetTradeVolumeUpdates
	{
		[JsonProperty("trde_qty_updt")]
		public IEnumerable<KiwoomStockInfoGetTradeVolumeUpdateItem>? Items;
	}
	public record KiwoomStockInfoGetTradeVolumeUpdateItem
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pred_pre_sig")]
		public string? PreviousDifferenceSymbol;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		[JsonProperty("prev_trde_qty")]
		public decimal? PreviousTradeQuantity;
		[JsonProperty("now_trde_qty")]
		public decimal? CurrentTradeQuantity;
		[JsonProperty("sel_bid")]
		public decimal? SellBid;
		[JsonProperty("buy_bid")]
		public decimal? BuyBid;
	}

	public record KiwoomStockInfoGetPriceConcentrations
	{
		[JsonProperty("prps_cnctr")]
		public IEnumerable<KiwoomStockInfoGetPriceConcentrationItem>? Items;
	}
	public record KiwoomStockInfoGetPriceConcentrationItem
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pred_pre_sig")]
		public string? PreviousDifferenceSymbol;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		[JsonProperty("now_trde_qty")]
		public decimal? CurrentTradeQuantity;
		[JsonProperty("pric_strt")]
		public decimal? PriceStart;
		[JsonProperty("pric_end")]
		public decimal? PriceEnd;
		[JsonProperty("prps_qty")]
		public decimal? PriceQuantity;
		[JsonProperty("prps_rt")]
		public decimal? PriceRatio;
	}

	public record KiwoomStockInfoGetHighLowPers
	{
		[JsonProperty("high_low_per")]
		public IEnumerable<KiwoomStockInfoGetHighLowPerItem>? Items;
	}
	public record KiwoomStockInfoGetHighLowPerItem
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("per")]
		public decimal? PER;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pred_pre_sig")]
		public string? PreviousDifferenceSymbol;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		[JsonProperty("now_trde_qty")]
		public decimal? CurrentTradeQuantity;
		[JsonProperty("sel_bid")]
		public decimal? SellBid;
	}

	public record KiwoomStockInfoGetOpenPriceCompareFluctuations
	{
		[JsonProperty("open_pric_pre_flu_rt")]
		public IEnumerable<KiwoomStockInfoGetOpenPriceCompareFluctuationItem>? Items;
	}
	public record KiwoomStockInfoGetOpenPriceCompareFluctuationItem
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pred_pre_sig")]
		public string? PreviousDifferenceSymbol;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		[JsonProperty("open_pric")]
		public decimal? OpenPrice;
		[JsonProperty("high_pric")]
		public decimal? HighPrice;
		[JsonProperty("low_pric")]
		public decimal? LowPrice;
		[JsonProperty("open_pric_pre")]
		public string? OpenPriceCompared;
		[JsonProperty("now_trde_qty")]
		public decimal? CurrentTradeQuantity;
		[JsonProperty("cntr_str")]
		public decimal? TradeStrength;
	}

	public record KiwoomStockInfoGetTradeOriginPriceAnalyses
	{
		[JsonProperty("trde_ori_prps_anly")]
		public IEnumerable<KiwoomStockInfoGetTradeOriginPriceAnalysisItem>? Items;
	}
	public record KiwoomStockInfoGetTradeOriginPriceAnalysisItem
	{
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomNullableDateConverter))]
		public DateTime? Date;
		[JsonProperty("close_pric")]
		public decimal? ClosePrice;
		[JsonProperty("pre_sig")]
		public string? DifferenceSymbol;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		[JsonProperty("sel_qty")]
		public decimal? SellQuantity;
		[JsonProperty("buy_qty")]
		public decimal? BuyQuantity;
		[JsonProperty("netprps_qty")]
		public decimal? NetPurchaseQuantity;
		[JsonProperty("trde_qty_sum")]
		public decimal? TotalTradeQuantity;
		[JsonProperty("trde_wght")]
		public decimal? TradeWeight;
	}

	public record KiwoomStockInfoGetTradeOriginMomentTradeVolumes
	{
		[JsonProperty("trde_ori_mont_trde_qty")]
		public IEnumerable<KiwoomStockInfoGetTradeOriginMomentTradeVolumeItem>? Items;
	}
	public record KiwoomStockInfoGetTradeOriginMomentTradeVolumeItem
	{
		[JsonProperty("tm")]
		[JsonConverter(typeof(KiwoomTimeConverter))]
		public TimeSpan? Time;
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("trde_ori_nm")]
		public string? TradeOriginName;
		[JsonProperty("tp")]
		public string? Type;
		[JsonProperty("mont_trde_qty")]
		public decimal? MomentTradeQuantity;
		[JsonProperty("acc_netprps")]
		public decimal? AccumulatedNetPurchase;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pred_pre_sig")]
		public string? PreviousDifferenceSymbol;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
	}

	public record KiwoomStockInfoGetMotionStocks
	{
		[JsonProperty("motn_stk")]
		public IEnumerable<KiwoomStockInfoGetMotionStockItem>? Items;
	}
	public record KiwoomStockInfoGetMotionStockItem
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("acc_trde_qty")]
		public decimal? AccumulatedTradeQuantity;
		[JsonProperty("motn_pric")]
		public decimal? MotionPrice;
		[JsonProperty("dynm_dispty_rt")]
		public decimal? DynamicDisparityRate;
		[JsonProperty("trde_cntr_proc_time")]
		[JsonConverter(typeof(KiwoomTimeConverter))]
		public TimeSpan? TradeContractProcessTime;
		[JsonProperty("virelis_time")]
		[JsonConverter(typeof(KiwoomTimeConverter))]
		public TimeSpan? ViReleaseTime;
		[JsonProperty("viaplc_tp")]
		public string? ViApplyType;
		[JsonProperty("dynm_stdpc")]
		public decimal? DynamicStandardPrice;
		[JsonProperty("static_stdpc")]
		public decimal? StaticStandardPrice;
		[JsonProperty("static_dispty_rt")]
		public decimal? StaticDisparityRate;
		[JsonProperty("open_pric_pre_flu_rt")]
		public decimal? OpenPriceComparedFluctuationRate;
		[JsonProperty("vimotn_cnt")]
		public decimal? ViMotionCount;
		[JsonProperty("stex_tp")]
		public string? ExchangeType;
	}

	public record KiwoomStockInfoGetTodayPreviousTradeQuantities
	{
		[JsonProperty("tdy_pred_cntr_qty")]
		public IEnumerable<KiwoomStockInfoGetTodayPreviousTradeQuantityItem>? Items;
	}
	public record KiwoomStockInfoGetTodayPreviousTradeQuantityItem
	{
		[JsonProperty("cntr_tm")]
		[JsonConverter(typeof(KiwoomTimeConverter))]
		public TimeSpan? TradeTime;
		[JsonProperty("cntr_pric")]
		public decimal? TradePrice;
		[JsonProperty("pred_pre_sig")]
		public string? PreviousDifferenceSymbol;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		[JsonProperty("cntr_qty")]
		public decimal? TradeQuantity;
		[JsonProperty("acc_trde_qty")]
		public decimal? AccumulatedTradeQuantity;
		[JsonProperty("acc_trde_prica")]
		public decimal? AccumulatedTradeAmount;
	}

	public record KiwoomStockInfoGetInvestorDailyTradeStocks
	{
		[JsonProperty("invsr_daly_trde_stk")]
		public IEnumerable<KiwoomStockInfoGetInvestorDailyTradeStockItem>? Items;
	}
	public record KiwoomStockInfoGetInvestorDailyTradeStockItem
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("netslmt_qty")]
		public decimal? NetSellQuantity;
		[JsonProperty("netslmt_amt")]
		public decimal? NetSellAmount;
		[JsonProperty("prsm_avg_pric")]
		public decimal? EstimatedAveragePrice;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pre_sig")]
		public string? DifferenceSymbol;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		[JsonProperty("avg_pric_pre")]
		public decimal? AveragePriceDifference;
		[JsonProperty("pre_rt")]
		public decimal? DifferenceRate;
		[JsonProperty("dt_trde_qty")]
		public decimal? PeriodTradeQuantity;
	}

	public record KiwoomStockInfoGetStockInvestorOrganizations
	{
		[JsonProperty("stk_invsr_orgn")]
		public IEnumerable<KiwoomStockInfoGetStockInvestorOrganizationItem>? Items;
	}
	public record KiwoomStockInfoGetStockInvestorOrganizationItem
	{
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomNullableDateConverter))]
		public DateTime? Date;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pre_sig")]
		public string? DifferenceSymbol;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		[JsonProperty("acc_trde_qty")]
		public decimal? AccumulatedTradeQuantity;
		[JsonProperty("acc_trde_prica")]
		public decimal? AccumulatedTradeAmount;
		[JsonProperty("ind_invsr")]
		public string? IndividualInvestor;
		[JsonProperty("frgnr_invsr")]
		public string? ForeignInvestor;
		[JsonProperty("orgn")]
		public string? Organization;
		[JsonProperty("fnnc_invt")]
		public string? FinancialInvestment;
		[JsonProperty("insrnc")]
		public string? Insurance;
		[JsonProperty("invtrt")]
		public string? InvestmentTrust;
		[JsonProperty("etc_fnnc")]
		public string? OtherFinancial;
		[JsonProperty("bank")]
		public string? Bank;
		[JsonProperty("penfnd_etc")]
		public string? PensionEtc;
		[JsonProperty("samo_fund")]
		public string? PrivateFund;
		[JsonProperty("natn")]
		public string? Nation;
		[JsonProperty("etc_corp")]
		public string? OtherCorporation;
		[JsonProperty("natfor")]
		public string? DomesticAndForeign;
	}

	public record KiwoomStockInfoGetStockInvestorOrganizationTotals
	{
		[JsonProperty("stk_invsr_orgn_tot")]
		public IEnumerable<KiwoomStockInfoGetStockInvestorOrganizationTotalItem>? Items;
	}
	public record KiwoomStockInfoGetStockInvestorOrganizationTotalItem
	{
		[JsonProperty("ind_invsr")]
		public decimal? IndividualInvestors;
		[JsonProperty("frgnr_invsr")]
		public decimal? ForeignInvestors;
		[JsonProperty("orgn")]
		public decimal? Organizations;
		[JsonProperty("fnnc_invt")]
		public decimal? FinancialInvestments;
		[JsonProperty("insrnc")]
		public decimal? Insurances;
		[JsonProperty("invtrt")]
		public decimal? InvestmentTrusts;
		[JsonProperty("etc_fnnc")]
		public decimal? OtherFinancials;
		[JsonProperty("bank")]
		public decimal? Banks;
		[JsonProperty("penfnd_etc")]
		public decimal? PensionEtcs;
		[JsonProperty("samo_fund")]
		public decimal? PrivateFunds;
		[JsonProperty("natn")]
		public decimal? Nations;
		[JsonProperty("etc_corp")]
		public decimal? OtherCorporations;
		[JsonProperty("natfor")]
		public decimal? DomesticAndForeign;
	}

	public record KiwoomStockInfoGetTodayPreviousContracts
	{
		[JsonProperty("tdy_pred_cntr")]
		public IEnumerable<KiwoomStockInfoGetTodayPreviousContractItem>? Items;
	}
	public record KiwoomStockInfoGetTodayPreviousContractItem
	{
		[JsonProperty("tm")]
		[JsonConverter(typeof(KiwoomTimeConverter))]
		public TimeSpan? Time;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		[JsonProperty("pre_rt")]
		public decimal? DifferenceRate;
		[JsonProperty("pri_sel_bid_unit")]
		public decimal? PrioritySellBidUnit;
		[JsonProperty("pri_buy_bid_unit")]
		public decimal? PriorityBuyBidUnit;
		[JsonProperty("cntr_trde_qty")]
		public decimal? ContractTradeQuantity;
		[JsonProperty("sign")]
		public string? PreviousDifferenceSymbol;
		[JsonProperty("acc_trde_qty")]
		public decimal? AccumulatedTradeQuantity;
		[JsonProperty("acc_trde_prica")]
		public decimal? AccumulatedTradeAmount;
		[JsonProperty("cntr_str")]
		public decimal? ContractStrength;
		[JsonProperty("stex_tp")]
		public string? ExchangeType;
	}

	public record KiwoomStockInfoGetAttentionStocks
	{
		[JsonProperty("atn_stk_infr")]
		public IEnumerable<KiwoomStockInfoGetAttentionStockItem>? Items;
	}
	public record KiwoomStockInfoGetAttentionStockItem
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("base_pric")]
		public decimal? BasePrice;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		[JsonProperty("pred_pre_sig")]
		public string? PreviousDifferenceSymbol;
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		[JsonProperty("trde_qty")]
		public decimal? TradeQuantity;
		[JsonProperty("trde_prica")]
		public decimal? TradeAmount;
		[JsonProperty("cntr_qty")]
		public decimal? ContractQuantity;
		[JsonProperty("cntr_str")]
		public decimal? ContractStrength;
		[JsonProperty("pred_trde_qty_pre")]
		public decimal? PreviousTradeQuantityDifference;
		[JsonProperty("sel_bid")]
		public decimal? SellBid;
		[JsonProperty("buy_bid")]
		public decimal? BuyBid;
		[JsonProperty("sel_1th_bid")]
		public decimal? SellFirstBid;
		[JsonProperty("sel_2th_bid")]
		public decimal? SellSecondBid;
		[JsonProperty("sel_3th_bid")]
		public decimal? SellThirdBid;
		[JsonProperty("sel_4th_bid")]
		public decimal? SellFourthBid;
		[JsonProperty("sel_5th_bid")]
		public decimal? SellFifthBid;
		[JsonProperty("buy_1th_bid")]
		public decimal? BuyFirstBid;
		[JsonProperty("buy_2th_bid")]
		public decimal? BuySecondBid;
		[JsonProperty("buy_3th_bid")]
		public decimal? BuyThirdBid;
		[JsonProperty("buy_4th_bid")]
		public decimal? BuyFourthBid;
		[JsonProperty("buy_5th_bid")]
		public decimal? BuyFifthBid;
		[JsonProperty("upl_pric")]
		public decimal? UpperPriceLimit;
		[JsonProperty("lst_pric")]
		public decimal? LowerPriceLimit;
		[JsonProperty("open_pric")]
		public decimal? OpenPrice;
		[JsonProperty("high_pric")]
		public decimal? HighPrice;
		[JsonProperty("low_pric")]
		public decimal? LowPrice;
		[JsonProperty("close_pric")]
		public decimal? ClosePrice;
		[JsonProperty("cntr_tm")]
		[JsonConverter(typeof(KiwoomTimeConverter))]
		public TimeSpan? ContractTime;
		[JsonProperty("exp_cntr_pric")]
		public decimal? ExpectedContractPrice;
		[JsonProperty("exp_cntr_qty")]
		public decimal? ExpectedContractQuantity;
		[JsonProperty("cap")]
		public decimal? Capital;
		[JsonProperty("fav")]
		public decimal? FaceValue;
		[JsonProperty("mac")]
		public decimal? MarketCapitalization;
		[JsonProperty("stkcnt")]
		public decimal? StockCount;
		[JsonProperty("bid_tm")]
		[JsonConverter(typeof(KiwoomTimeConverter))]
		public TimeSpan? BidTime;
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomNullableDateConverter))]
		public DateTime? Date;
		[JsonProperty("pri_sel_req")]
		public decimal? PrioritySellRequest;
		[JsonProperty("pri_buy_req")]
		public decimal? PriorityBuyRequest;
		[JsonProperty("pri_sel_cnt")]
		public decimal? PrioritySellCount;
		[JsonProperty("pri_buy_cnt")]
		public decimal? PriorityBuyCount;
		[JsonProperty("tot_sel_req")]
		public decimal? TotalSellRequest;
		[JsonProperty("tot_buy_req")]
		public decimal? TotalBuyRequest;
		[JsonProperty("tot_sel_cnt")]
		public decimal? TotalSellCount;
		[JsonProperty("tot_buy_cnt")]
		public decimal? TotalBuyCount;
		[JsonProperty("prty")]
		public decimal? Parity;
		[JsonProperty("gear")]
		public decimal? Gearing;
		[JsonProperty("pl_qutr")]
		public decimal? BreakEvenPoint;
		[JsonProperty("cap_support")]
		public decimal? CapitalSupport;
		[JsonProperty("elwexec_pric")]
		public decimal? ELWExercisePrice;
		[JsonProperty("cnvt_rt")]
		public decimal? ConversionRate;
		[JsonProperty("elwexpr_dt")]
		[JsonConverter(typeof(KiwoomNullableDateConverter))]
		public DateTime? ELWExpirationDate;
		[JsonProperty("cntr_engg")]
		public decimal? OutstandingContracts;
		[JsonProperty("cntr_pred_pre")]
		public decimal? OutstandingPreviousDifference;
		[JsonProperty("theory_pric")]
		public decimal? TheoreticalPrice;
		[JsonProperty("innr_vltl")]
		public decimal? ImpliedVolatility;
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
	}

	public record KiwoomStockInfoGetLists
	{
		[JsonProperty("list")]
		public IEnumerable<KiwoomStockInfoGetListItem>? Items;
	}
	public record KiwoomStockInfoGetListItem
	{
		[JsonProperty("code")]
		public string? StockCode;
		[JsonProperty("name")]
		public string? StockName;
		[JsonProperty("listCount")]
		public decimal? ListedShareCount;
		[JsonProperty("auditInfo")]
		public string? AuditInfo;
		[JsonProperty("regDay")]
		[JsonConverter(typeof(KiwoomNullableDateConverter))]
		public DateTime? ListingDate;
		[JsonProperty("lastPrice")]
		public decimal? PreviousClosePrice;
		[JsonProperty("state")]
		public string? StockState;
		[JsonProperty("marketCode")]
		public string? MarketCode;
		[JsonProperty("marketName")]
		public string? MarketName;
		[JsonProperty("upName")]
		public string? IndustryName;
		[JsonProperty("upSizeName")]
		public string? CompanySizeCategory;
		[JsonProperty("companyClassName")]
		public string? CompanyClassName;
		[JsonProperty("orderWarning")]
		public string? OrderWarningFlag;
		[JsonProperty("nxtEnable")]
		public string? NxtEnabled;
	}

	public record KiwoomStockInfoGetMarketCodes
	{
		[JsonProperty("marketCode")]
		public IEnumerable<KiwoomStockInfoGetMarketCodeItem>? Items;
	}
	public record KiwoomStockInfoGetMarketCodeItem
	{
		[JsonProperty("code")]
		public string? Code;
		[JsonProperty("name")]
		public string? IndustryName;
		[JsonProperty("group")]
		public string? Group;
	}

	public record KiwoomStockInfoGetMemberCodes
	{
		[JsonProperty("list")]
		public IEnumerable<KiwoomStockInfoGetMemberCodeItem>? Items;
	}
	public record KiwoomStockInfoGetMemberCodeItem
	{
		[JsonProperty("code")]
		public string? Code;
		[JsonProperty("name")]
		public string? IndustryName;
		[JsonProperty("gb")]
		public string? Category;
	}

	public record KiwoomStockInfoGetProgramNetPurchaseUpper50
	{
		[JsonProperty("prm_netprps_upper_50")]
		public IEnumerable<KiwoomStockInfoGetProgramNetPurchaseUpper50Item>? Items;
	}
	public record KiwoomStockInfoGetProgramNetPurchaseUpper50Item
	{
		[JsonProperty("rank")]
		public int? Rank;
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("flu_sig")]
		public string? FluctuationSymbol;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		[JsonProperty("acc_trde_qty")]
		public decimal? AccumulatedTradeQuantity;
		[JsonProperty("prm_sell_amt")]
		public decimal? ProgramSellAmount;
		[JsonProperty("prm_buy_amt")]
		public decimal? ProgramBuyAmount;
		[JsonProperty("prm_netprps_amt")]
		public decimal? ProgramNetPurchaseAmount;
	}

	public record KiwoomStockInfoGetProgramTradeStatus
	{
		[JsonProperty("tot_1")]
		public decimal? TotalBuyContractQuantity;
		[JsonProperty("tot_2")]
		public decimal? TotalBuyContractAmount;
		[JsonProperty("tot_3")]
		public decimal? TotalSellContractQuantity;
		[JsonProperty("tot_4")]
		public decimal? TotalSellContractAmount;
		[JsonProperty("tot_5")]
		public decimal? TotalNetBuyAmount;
		[JsonProperty("tot_6")]
		public decimal? Total6;
		[JsonProperty("stk_prm_trde_prst")]
		public IEnumerable<KiwoomStockInfoGetStockProgramTradeStatusItem>? Items;
	}
	public record KiwoomStockInfoGetStockProgramTradeStatusItem
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("flu_sig")]
		public string? FluctuationSymbol;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		[JsonProperty("buy_cntr_qty")]
		public decimal? BuyContractQuantity;
		[JsonProperty("buy_cntr_amt")]
		public decimal? BuyContractAmount;
		[JsonProperty("sel_cntr_qty")]
		public decimal? SellContractQuantity;
		[JsonProperty("sel_cntr_amt")]
		public decimal? SellContractAmount;
		[JsonProperty("netprps_prica")]
		public decimal? NetBuyAmount;
		[JsonProperty("all_trde_rt")]
		public decimal? TotalTradeRate;
	}

	public record KiwoomStockInfoGetCreditLoanPossibleStocks
	{
		[JsonProperty("crd_loan_able")]
		public string? CreditLoanable;
		[JsonProperty("crd_loan_pos_stk")]
		public IEnumerable<KiwoomStockInfoGetCreditLoanPossibleStockItem>? Items;
	}
	public record KiwoomStockInfoGetCreditLoanPossibleStockItem
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("crd_assr_rt")]
		public decimal? CreditAssuranceRate;
		[JsonProperty("repl_pric")]
		public decimal? ReplacementPrice;
		[JsonProperty("pred_close_pric")]
		public decimal? PreviousClosePrice;
		[JsonProperty("crd_limit_over_yn")]
		public string? CreditLimitOverFlag;
		[JsonProperty("crd_limit_over_txt")]
		public string? CreditLimitOverText;
	}

	public record KiwoomStockInfoGetCreditAllowYn
	{
		[JsonProperty("crd_alow_yn")]
		public string? CreditAllowYn;
	}
}
