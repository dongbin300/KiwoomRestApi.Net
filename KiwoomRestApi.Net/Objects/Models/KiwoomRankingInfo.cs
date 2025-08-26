using KiwoomRestApi.Net.Converters;
using KiwoomRestApi.Net.Objects.Commons;

using Newtonsoft.Json;

using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models
{
	public record KiwoomRankingInfoGetBidRequestUppers
	{
		[JsonProperty("bid_req_upper")]
		public IEnumerable<KiwoomRankingInfoGetBidRequestUpperItem>? Items;
	}
	public record KiwoomRankingInfoGetBidRequestUpperItem
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pred_pre_sig")]
		public decimal? PreviousDayChangeSign;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDayChange;
		[JsonProperty("trde_qty")]
		public decimal? TradeQuantity;
		[JsonProperty("tot_sel_req")]
		public decimal? TotalSellRequest;
		[JsonProperty("tot_buy_req")]
		public decimal? TotalBuyRequest;
		[JsonProperty("netprps_req")]
		public decimal? NetPurchaseRequest;
		[JsonProperty("buy_rt")]
		public decimal? BuyRate;
	}

	public record KiwoomRankingInfoGetBidRequestSuddenIncreases
	{
		[JsonProperty("bid_req_sdnin")]
		public IEnumerable<KiwoomRankingInfoGetBidRequestSuddenIncreaseItem>? Items;
	}
	public record KiwoomRankingInfoGetBidRequestSuddenIncreaseItem
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pred_pre_sig")]
		public string? PreviousDayChangeSign;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDayChange;
		[JsonProperty("int")]
		public decimal? StandardRate;
		[JsonProperty("now")]
		public decimal? CurrentValue;
		[JsonProperty("sdnin_qty")]
		public decimal? SuddenIncreaseQuantity;
		[JsonProperty("sdnin_rt")]
		public decimal? SuddenIncreaseRate;
		[JsonProperty("tot_buy_qty")]
		public decimal? TotalBuyQuantity;
	}

	public record KiwoomRankingInfoGetRequestRateSuddenIncreases
	{
		[JsonProperty("req_rt_sdnin")]
		public IEnumerable<KiwoomRankingInfoGetRequestRateSuddenIncreaseItem>? Items;
	}
	public record KiwoomRankingInfoGetRequestRateSuddenIncreaseItem
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pred_pre_sig")]
		public string? PreviousDayChangeSign;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDayChange;
		[JsonProperty("int")]
		public decimal? StandardRate;
		[JsonProperty("now_rt")]
		public decimal? CurrentRatio;
		[JsonProperty("sdnin_rt")]
		public decimal? SuddenIncreaseRate;
		[JsonProperty("tot_sel_req")]
		public decimal? TotalSellRequest;
		[JsonProperty("tot_buy_req")]
		public decimal? TotalBuyRequest;
	}

	public record KiwoomRankingInfoGetTradedQuantitySuddenIncreases
	{
		[JsonProperty("trde_qty_sdnin")]
		public IEnumerable<KiwoomRankingInfoGetTradedQuantitySuddenIncreaseItem>? Items;
	}
	public record KiwoomRankingInfoGetTradedQuantitySuddenIncreaseItem
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pred_pre_sig")]
		public string? PreviousDayChangeSign;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDayChange;
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		[JsonProperty("prev_trde_qty")]
		public decimal? PreviousTradeQuantity;
		[JsonProperty("now_trde_qty")]
		public decimal? CurrentTradeQuantity;
		[JsonProperty("sdnin_qty")]
		public decimal? SuddenIncreaseQuantity;
		[JsonProperty("sdnin_rt")]
		public decimal? SuddenIncreaseRate;
	}

	public record KiwoomRankingInfoGetPreviousDayFluctuationRateUppers
	{
		[JsonProperty("pred_pre_flu_rt_upper")]
		public IEnumerable<KiwoomRankingInfoGetPreviousDayFluctuationRateUpperItem>? Items;
	}
	public record KiwoomRankingInfoGetPreviousDayFluctuationRateUpperItem
	{
		[JsonProperty("stk_cls")]
		public string? StockClass;
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pred_pre_sig")]
		public string? PreviousDayChangeSign;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDayChange;
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		[JsonProperty("sel_req")]
		public decimal? SellRequest;
		[JsonProperty("buy_req")]
		public decimal? BuyRequest;
		[JsonProperty("now_trde_qty")]
		public decimal? CurrentTradeQuantity;
		[JsonProperty("cntr_str")]
		public decimal? ContractStrength;
		[JsonProperty("cnt")]
		public decimal? Count;
	}

	public record KiwoomRankingInfoGetExpectedContractFluctuationRateUppers
	{
		[JsonProperty("exp_cntr_flu_rt_upper")]
		public IEnumerable<KiwoomRankingInfoGetExpectedContractFluctuationRateUpperItem>? Items;
	}
	public record KiwoomRankingInfoGetExpectedContractFluctuationRateUpperItem
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("exp_cntr_pric")]
		public decimal? ExpectedContractPrice;
		[JsonProperty("base_pric")]
		public decimal? BasePrice;
		[JsonProperty("pred_pre_sig")]
		public string? PreviousDayChangeSign;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDayChange;
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		[JsonProperty("exp_cntr_qty")]
		public decimal? ExpectedContractQuantity;
		[JsonProperty("sel_req")]
		public decimal? SellRequest;
		[JsonProperty("sel_bid")]
		public decimal? SellBid;
		[JsonProperty("buy_bid")]
		public decimal? BuyBid;
		[JsonProperty("buy_req")]
		public decimal? BuyRequest;
	}

	public record KiwoomRankingInfoGetTodayTradeQuantityUppers
	{
		[JsonProperty("tdy_trde_qty_upper")]
		public IEnumerable<KiwoomRankingInfoGetTodayTradeQuantityUpperItem>? Items;
	}
	public record KiwoomRankingInfoGetTodayTradeQuantityUpperItem
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pred_pre_sig")]
		public string? PreviousDayChangeSign;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDayChange;
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		[JsonProperty("trde_qty")]
		public decimal? TradeQuantity;
		[JsonProperty("pred_rt")]
		public decimal? PreviousDayRatio;
		[JsonProperty("trde_tern_rt")]
		public decimal? TradeTurnoverRate;
		[JsonProperty("trde_amt")]
		public decimal? TradeAmount;
		[JsonProperty("opmr_trde_qty")]
		public decimal? IntradayTradeQuantity;
		[JsonProperty("opmr_pred_rt")]
		public decimal? IntradayPreviousDayRatio;
		[JsonProperty("opmr_trde_rt")]
		public decimal? IntradayTradeTurnoverRate;
		[JsonProperty("opmr_trde_amt")]
		public decimal? IntradayTradeAmount;
		[JsonProperty("af_mkrt_trde_qty")]
		public decimal? AfterMarketTradeQuantity;
		[JsonProperty("af_mkrt_pred_rt")]
		public decimal? AfterMarketPreviousDayRatio;
		[JsonProperty("af_mkrt_trde_rt")]
		public decimal? AfterMarketTradeTurnoverRate;
		[JsonProperty("af_mkrt_trde_amt")]
		public decimal? AfterMarketTradeAmount;
		[JsonProperty("bf_mkrt_trde_qty")]
		public decimal? BeforeMarketTradeQuantity;
		[JsonProperty("bf_mkrt_pred_rt")]
		public decimal? BeforeMarketPreviousDayRatio;
		[JsonProperty("bf_mkrt_trde_rt")]
		public decimal? BeforeMarketTradeTurnoverRate;
		[JsonProperty("bf_mkrt_trde_amt")]
		public decimal? BeforeMarketTradeAmount;
	}

	public record KiwoomRankingInfoGetPreviousTradeQuantityUppers
	{
		[JsonProperty("pred_trde_qty_upper")]
		public IEnumerable<KiwoomRankingInfoGetPreviousTradeQuantityUpperItem>? Items;
	}
	public record KiwoomRankingInfoGetPreviousTradeQuantityUpperItem
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pred_pre_sig")]
		public string? PreviousDayChangeSign;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDayChange;
		[JsonProperty("trde_qty")]
		public decimal? TradeQuantity;
	}

	public record KiwoomRankingInfoGetTradePriceUppers
	{
		[JsonProperty("trde_prica_upper")]
		public IEnumerable<KiwoomRankingInfoGetTradePriceUpperItem>? Items;
	}
	public record KiwoomRankingInfoGetTradePriceUpperItem
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("now_rank")]
		public string? CurrentRank;
		[JsonProperty("pred_rank")]
		public string? PreviousRank;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pred_pre_sig")]
		public string? PreviousDayChangeSign;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDayChange;
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		[JsonProperty("sel_bid")]
		public decimal? SellBid;
		[JsonProperty("buy_bid")]
		public decimal? BuyBid;
		[JsonProperty("now_trde_qty")]
		public decimal? CurrentTradeQuantity;
		[JsonProperty("pred_trde_qty")]
		public decimal? PreviousTradeQuantity;
		[JsonProperty("trde_prica")]
		public decimal? TradePriceAmount;
	}

	public record KiwoomRankingInfoGetCreditRateUppers
	{
		[JsonProperty("crd_rt_upper")]
		public IEnumerable<KiwoomRankingInfoGetCreditRateUpperItem>? Items;
	}
	public record KiwoomRankingInfoGetCreditRateUpperItem
	{
		[JsonProperty("stk_infr")]
		public string? StockInfo;
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pred_pre_sig")]
		public string? PreviousDayChangeSign;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDayChange;
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		[JsonProperty("crd_rt")]
		public decimal? CreditRate;
		[JsonProperty("sel_req")]
		public decimal? SellRequest;
		[JsonProperty("buy_req")]
		public decimal? BuyRequest;
		[JsonProperty("now_trde_qty")]
		public decimal? CurrentTradeQuantity;
	}

	public record KiwoomRankingInfoGetForeignTradePerPeriodUppers
	{
		[JsonProperty("for_dt_trde_upper")]
		public IEnumerable<KiwoomRankingInfoGetForeignTradePerPeriodUpperItem>? Items;
	}
	public record KiwoomRankingInfoGetForeignTradePerPeriodUpperItem
	{
		[JsonProperty("rank")]
		public decimal? Rank;
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pred_pre_sig")]
		public string? PreviousDayChangeSign;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDayChange;
		[JsonProperty("sel_bid")]
		public decimal? SellBid;
		[JsonProperty("buy_bid")]
		public decimal? BuyBid;
		[JsonProperty("trde_qty")]
		public decimal? TradeQuantity;
		[JsonProperty("netprps_qty")]
		public string? NetPurchaseQuantity; // --
		[JsonProperty("gain_pos_stkcnt")]
		public decimal? GainableStockCount;
	}

	public record KiwoomRankingInfoGetForeignContinuousNetTradeUppers
	{
		[JsonProperty("for_cont_nettrde_upper")]
		public IEnumerable<KiwoomRankingInfoGetForeignContinuousNetTradeUpperItem>? Items;
	}
	public record KiwoomRankingInfoGetForeignContinuousNetTradeUpperItem
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pred_pre_sig")]
		public string? PreviousDayChangeSign;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDayChange;
		[JsonProperty("dm1")]
		public decimal? DMinus1;
		[JsonProperty("dm2")]
		public decimal? DMinus2;
		[JsonProperty("dm3")]
		public decimal? DMinus3;
		[JsonProperty("tot")]
		public decimal? Total;
		[JsonProperty("limit_exh_rt")]
		public decimal? LimitExhaustionRate;
		[JsonProperty("pred_pre_1")]
		public decimal? PreviousDayChange1;
		[JsonProperty("pred_pre_2")]
		public decimal? PreviousDayChange2;
		[JsonProperty("pred_pre_3")]
		public decimal? PreviousDayChange3;
	}

	public record KiwoomRankingInfoGetForeignLimitExhaustionRateIncreases
	{
		[JsonProperty("for_limit_exh_rt_incrs_upper")]
		public IEnumerable<KiwoomRankingInfoGetForeignLimitExhaustionRateIncreaseItem>? Items;
	}
	public record KiwoomRankingInfoGetForeignLimitExhaustionRateIncreaseItem
	{
		[JsonProperty("rank")]
		public string? Rank;
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pred_pre_sig")]
		public string? PreviousDayChangeSign;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDayChange;
		[JsonProperty("trde_qty")]
		public decimal? TradeQuantity;
		[JsonProperty("poss_stkcnt")]
		public decimal? PossessedStockCount;
		[JsonProperty("gain_pos_stkcnt")]
		public decimal? GainableStockCount;
		[JsonProperty("base_limit_exh_rt")]
		public decimal? BaseLimitExhaustionRate;
		[JsonProperty("limit_exh_rt")]
		public decimal? LimitExhaustionRate;
		[JsonProperty("exh_rt_incrs")]
		public decimal? ExhaustionRateIncrease;
	}

	public record KiwoomRankingInfoGetForeignWicketTradeUppers
	{
		[JsonProperty("frgn_wicket_trde_upper")]
		public IEnumerable<KiwoomRankingInfoGetForeignWicketTradeUpperItem>? Items;
	}
	public record KiwoomRankingInfoGetForeignWicketTradeUpperItem
	{
		[JsonProperty("rank")]
		public string? Rank;
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pred_pre_sig")]
		public string? PreviousDayChangeSign;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDayChange;
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		[JsonProperty("sel_trde_qty")]
		public decimal? SellTradeQuantity;
		[JsonProperty("buy_trde_qty")]
		public decimal? BuyTradeQuantity;
		[JsonProperty("netprps_trde_qty")]
		public decimal? NetPurchaseTradeQuantity;
		[JsonProperty("netprps_prica")]
		public decimal? NetPurchasePriceAmount;
		[JsonProperty("trde_qty")]
		public decimal? TradeQuantity;
		[JsonProperty("trde_prica")]
		public decimal? TradePriceAmount;
	}

	public record KiwoomRankingInfoGetStockSecuritiesRanks
	{
		[JsonProperty("rank_1")]
		public string? Rank1;
		[JsonProperty("rank_2")]
		public string? Rank2;
		[JsonProperty("rank_3")]
		public string? Rank3;
		[JsonProperty("prid_trde_qty")]
		public string? PeriodTradeQuantity;
		[JsonProperty("stk_sec_rank")]
		public IEnumerable<KiwoomRankingInfoGetStockSecuritiesRankItem>? Items;
	}
	public record KiwoomRankingInfoGetStockSecuritiesRankItem
	{
		[JsonProperty("rank")]
		public string? Rank;
		[JsonProperty("mmcm_nm")]
		public string? MemberCompanyName;
		[JsonProperty("buy_qty")]
		public string? BuyQuantity;
		[JsonProperty("sell_qty")]
		public string? SellQuantity;
		[JsonProperty("acc_netprps_qty")]
		public string? AccumulatedNetPurchaseQuantity;
	}

	public record KiwoomRankingInfoGetSecuritiesTradeUppers
	{
		[JsonProperty("sec_trde_upper")]
		public IEnumerable<KiwoomRankingInfoGetSecuritiesTradeUpperItem>? Items;
	}
	public record KiwoomRankingInfoGetSecuritiesTradeUpperItem
	{
		[JsonProperty("rank")]
		public string? Rank;
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("prid_stkpc_flu")]
		public string? PeriodStockPriceFluctuation;
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		[JsonProperty("prid_trde_qty")]
		public decimal? PeriodTradeQuantity;
		[JsonProperty("netprps")]
		public decimal? NetPurchase;
		[JsonProperty("buy_trde_qty")]
		public decimal? BuyTradeQuantity;
		[JsonProperty("sel_trde_qty")]
		public decimal? SellTradeQuantity;
	}

	public record KiwoomRankingInfoGetTodayMainTradeOrigins
	{
		[JsonProperty("sel_trde_ori_irds_1")]
		public string? SellTradeOriginChange1;
		[JsonProperty("sel_trde_ori_qty_1")]
		public string? SellTradeOriginQuantity1;
		[JsonProperty("sel_trde_ori_1")]
		public string? SellTradeOrigin1;
		[JsonProperty("sel_trde_ori_cd_1")]
		public string? SellTradeOriginCode1;
		[JsonProperty("buy_trde_ori_1")]
		public string? BuyTradeOrigin1;
		[JsonProperty("buy_trde_ori_cd_1")]
		public string? BuyTradeOriginCode1;
		[JsonProperty("buy_trde_ori_qty_1")]
		public string? BuyTradeOriginQuantity1;
		[JsonProperty("buy_trde_ori_irds_1")]
		public string? BuyTradeOriginChange1;
		[JsonProperty("sel_trde_ori_irds_2")]
		public string? SellTradeOriginChange2;
		[JsonProperty("sel_trde_ori_qty_2")]
		public string? SellTradeOriginQuantity2;
		[JsonProperty("sel_trde_ori_2")]
		public string? SellTradeOrigin2;
		[JsonProperty("sel_trde_ori_cd_2")]
		public string? SellTradeOriginCode2;
		[JsonProperty("buy_trde_ori_2")]
		public string? BuyTradeOrigin2;
		[JsonProperty("buy_trde_ori_cd_2")]
		public string? BuyTradeOriginCode2;
		[JsonProperty("buy_trde_ori_qty_2")]
		public string? BuyTradeOriginQuantity2;
		[JsonProperty("buy_trde_ori_irds_2")]
		public string? BuyTradeOriginChange2;
		[JsonProperty("sel_trde_ori_irds_3")]
		public string? SellTradeOriginChange3;
		[JsonProperty("sel_trde_ori_qty_3")]
		public string? SellTradeOriginQuantity3;
		[JsonProperty("sel_trde_ori_3")]
		public string? SellTradeOrigin3;
		[JsonProperty("sel_trde_ori_cd_3")]
		public string? SellTradeOriginCode3;
		[JsonProperty("buy_trde_ori_3")]
		public string? BuyTradeOrigin3;
		[JsonProperty("buy_trde_ori_cd_3")]
		public string? BuyTradeOriginCode3;
		[JsonProperty("buy_trde_ori_qty_3")]
		public string? BuyTradeOriginQuantity3;
		[JsonProperty("buy_trde_ori_irds_3")]
		public string? BuyTradeOriginChange3;
		[JsonProperty("sel_trde_ori_irds_4")]
		public string? SellTradeOriginChange4;
		[JsonProperty("sel_trde_ori_qty_4")]
		public string? SellTradeOriginQuantity4;
		[JsonProperty("sel_trde_ori_4")]
		public string? SellTradeOrigin4;
		[JsonProperty("sel_trde_ori_cd_4")]
		public string? SellTradeOriginCode4;
		[JsonProperty("buy_trde_ori_4")]
		public string? BuyTradeOrigin4;
		[JsonProperty("buy_trde_ori_cd_4")]
		public string? BuyTradeOriginCode4;
		[JsonProperty("buy_trde_ori_qty_4")]
		public string? BuyTradeOriginQuantity4;
		[JsonProperty("buy_trde_ori_irds_4")]
		public string? BuyTradeOriginChange4;
		[JsonProperty("sel_trde_ori_irds_5")]
		public string? SellTradeOriginChange5;
		[JsonProperty("sel_trde_ori_qty_5")]
		public string? SellTradeOriginQuantity5;
		[JsonProperty("sel_trde_ori_5")]
		public string? SellTradeOrigin5;
		[JsonProperty("sel_trde_ori_cd_5")]
		public string? SellTradeOriginCode5;
		[JsonProperty("buy_trde_ori_5")]
		public string? BuyTradeOrigin5;
		[JsonProperty("buy_trde_ori_cd_5")]
		public string? BuyTradeOriginCode5;
		[JsonProperty("buy_trde_ori_qty_5")]
		public string? BuyTradeOriginQuantity5;
		[JsonProperty("buy_trde_ori_irds_5")]
		public string? BuyTradeOriginChange5;
		[JsonProperty("frgn_sel_prsm_sum_chang")]
		public string? ForeignSellEstimateSumChange;
		[JsonProperty("frgn_sel_prsm_sum")]
		public string? ForeignSellEstimateSum;
		[JsonProperty("frgn_buy_prsm_sum")]
		public string? ForeignBuyEstimateSum;
		[JsonProperty("frgn_buy_prsm_sum_chang")]
		public string? ForeignBuyEstimateSumChange;
		[JsonProperty("tdy_main_trde_ori")]
		public IEnumerable<KiwoomRankingInfoGetTodayMainTradeOriginItem>? Items;
	}
	public record KiwoomRankingInfoGetTodayMainTradeOriginItem
	{
		[JsonProperty("sel_scesn_tm")]
		public string? SellExitTime;
		[JsonProperty("sell_qty")]
		public string? SellQuantity;
		[JsonProperty("sel_upper_scesn_ori")]
		public string? SellTopExitOrigin;
		[JsonProperty("buy_scesn_tm")]
		public string? BuyExitTime;
		[JsonProperty("buy_qty")]
		public string? BuyQuantity;
		[JsonProperty("buy_upper_scesn_ori")]
		public string? BuyTopExitOrigin;
		[JsonProperty("qry_dt")]
		public string? QueryDate;
		[JsonProperty("qry_tm")]
		public string? QueryTime;
	}

	public record KiwoomRankingInfoGetNetPurchaseTradeOriginRanks
	{
		[JsonProperty("netprps_trde_ori_rank")]
		public IEnumerable<KiwoomRankingInfoGetNetPurchaseTradeOriginRankItem>? Items;
	}
	public record KiwoomRankingInfoGetNetPurchaseTradeOriginRankItem
	{
		[JsonProperty("rank")]
		public string? Rank;
		[JsonProperty("mmcm_cd")]
		public string? MemberCode;
		[JsonProperty("mmcm_nm")]
		public string? MemberName;
	}

	public record KiwoomRankingInfoGetTodayUpperSecessionOrigins
	{
		[JsonProperty("tdy_upper_scesn_ori")]
		public IEnumerable<KiwoomRankingInfoGetTodayUpperSecessionOriginItem>? Items;
	}
	public record KiwoomRankingInfoGetTodayUpperSecessionOriginItem
	{
		[JsonProperty("sel_scesn_tm")]
		public string? SellExitTime;
		[JsonProperty("sell_qty")]
		public string? SellQuantity;
		[JsonProperty("sel_upper_scesn_ori")]
		public string? SellUpperExitOrigin;
		[JsonProperty("buy_scesn_tm")]
		public string? BuyExitTime;
		[JsonProperty("buy_qty")]
		public string? BuyQuantity;
		[JsonProperty("buy_upper_scesn_ori")]
		public string? BuyUpperExitOrigin;
		[JsonProperty("qry_dt")]
		public string? QueryDate;
		[JsonProperty("qry_tm")]
		public string? QueryTime;
	}

	public record KiwoomRankingInfoGetEqualNetTradeRanks
	{
		[JsonProperty("eql_nettrde_rank")]
		public IEnumerable<KiwoomRankingInfoGetEqualNetTradeRankItem>? Items;
	}
	public record KiwoomRankingInfoGetEqualNetTradeRankItem
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("rank")]
		public string? Rank;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("cur_prc")]
		public KiwoomDecimal CurrentPrice;
		[JsonProperty("pre_sig")]
		public string? ChangeSign;
		[JsonProperty("pred_pre")]
		public KiwoomDecimal PreviousDayChange;
		[JsonProperty("flu_rt")]
		public KiwoomDecimal FluctuationRate;
		[JsonProperty("acc_trde_qty")]
		public decimal? AccumulatedTradeQuantity;
		[JsonProperty("orgn_nettrde_qty")]
		public KiwoomDecimal InstitutionNetTradeQuantity;
		[JsonProperty("orgn_nettrde_amt")]
		public KiwoomDecimal InstitutionNetTradeAmount;
		[JsonProperty("orgn_nettrde_avg_pric")]
		public decimal? InstitutionNetTradeAveragePrice;
		[JsonProperty("for_nettrde_qty")]
		public KiwoomDecimal ForeignerNetTradeQuantity;
		[JsonProperty("for_nettrde_amt")]
		public KiwoomDecimal ForeignerNetTradeAmount;
		[JsonProperty("for_nettrde_avg_pric")]
		public decimal? ForeignerNetTradeAveragePrice;
		[JsonProperty("nettrde_qty")]
		public KiwoomDecimal NetTradeQuantity;
		[JsonProperty("nettrde_amt")]
		public KiwoomDecimal NetTradeAmount;
	}

	public record KiwoomRankingInfoGetOpenMarketInvestorTradeUppers
	{
		[JsonProperty("opmr_invsr_trde_upper")]
		public IEnumerable<KiwoomRankingInfoGetOpenMarketInvestorTradeUpperItem>? Items;
	}
	public record KiwoomRankingInfoGetOpenMarketInvestorTradeUpperItem
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("sel_qty")]
		public decimal? SellQuantity;
		[JsonProperty("buy_qty")]
		public decimal? BuyQuantity;
		[JsonProperty("netslmt")]
		public decimal? NetSell;
	}

	public record KiwoomRankingInfoGetOvertimeSinglePriceFluctuationRateRanks
	{
		[JsonProperty("ovt_sigpric_flu_rt_rank")]
		public IEnumerable<KiwoomRankingInfoGetOvertimeSinglePriceFluctuationRateRankItem>? Items;
	}
	public record KiwoomRankingInfoGetOvertimeSinglePriceFluctuationRateRankItem
	{
		[JsonProperty("rank")]
		public string? Rank;
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pred_pre_sig")]
		public string? PreviousDayChangeSign;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDayChange;
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		[JsonProperty("sel_tot_req")]
		public decimal? TotalSellRequest;
		[JsonProperty("buy_tot_req")]
		public decimal? TotalBuyRequest;
		[JsonProperty("acc_trde_qty")]
		public decimal? AccumulatedTradeQuantity;
		[JsonProperty("acc_trde_prica")]
		public decimal? AccumulatedTradePriceAmount;
		[JsonProperty("tdy_close_pric")]
		public decimal? TodayClosingPrice;
		[JsonProperty("tdy_close_pric_flu_rt")]
		public decimal? TodayClosingPriceFluctuationRate;
	}

	public record KiwoomRankingInfoGetForeignInstitutionTradeUppers
	{
		[JsonProperty("frgnr_orgn_trde_upper")]
		public IEnumerable<KiwoomRankingInfoGetForeignInstitutionTradeUpperItem>? Items;
	}
	public record KiwoomRankingInfoGetForeignInstitutionTradeUpperItem
	{
		[JsonProperty("for_netslmt_stk_cd")]
		public string? ForeignNetSellStockCode;
		[JsonProperty("for_netslmt_stk_nm")]
		public string? ForeignNetSellStockName;
		[JsonProperty("for_netslmt_amt")]
		public decimal? ForeignNetSellAmount;
		[JsonProperty("for_netslmt_qty")]
		public decimal? ForeignNetSellQuantity;
		[JsonProperty("for_netprps_stk_cd")]
		public string? ForeignNetPurchaseStockCode;
		[JsonProperty("for_netprps_stk_nm")]
		public string? ForeignNetPurchaseStockName;
		[JsonProperty("for_netprps_amt")]
		public decimal? ForeignNetPurchaseAmount;
		[JsonProperty("for_netprps_qty")]
		public decimal? ForeignNetPurchaseQuantity;
		[JsonProperty("orgn_netslmt_stk_cd")]
		public string? InstitutionNetSellStockCode;
		[JsonProperty("orgn_netslmt_stk_nm")]
		public string? InstitutionNetSellStockName;
		[JsonProperty("orgn_netslmt_amt")]
		public decimal? InstitutionNetSellAmount;
		[JsonProperty("orgn_netslmt_qty")]
		public decimal? InstitutionNetSellQuantity;
		[JsonProperty("orgn_netprps_stk_cd")]
		public string? InstitutionNetPurchaseStockCode;
		[JsonProperty("orgn_netprps_stk_nm")]
		public string? InstitutionNetPurchaseStockName;
		[JsonProperty("orgn_netprps_amt")]
		public decimal? InstitutionNetPurchaseAmount;
		[JsonProperty("orgn_netprps_qty")]
		public decimal? InstitutionNetPurchaseQuantity;
	}

}
