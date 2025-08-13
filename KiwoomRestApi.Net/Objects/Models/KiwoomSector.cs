using KiwoomRestApi.Net.Converters;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models
{
	public record KiwoomSectorGetStockProgramTradingInfo
	{
		[JsonProperty("dfrt_trst_sell_qty")]
		public decimal ArbitrageTrustSellQuantity;
		[JsonProperty("dfrt_trst_sell_amt")]
		public decimal ArbitrageTrustSellAmount;
		[JsonProperty("dfrt_trst_buy_qty")]
		public decimal ArbitrageTrustBuyQuantity;
		[JsonProperty("dfrt_trst_buy_amt")]
		public decimal ArbitrageTrustBuyAmount;
		[JsonProperty("dfrt_trst_netprps_qty")]
		public decimal ArbitrageTrustNetPurchaseQuantity;
		[JsonProperty("dfrt_trst_netprps_amt")]
		public decimal ArbitrageTrustNetPurchaseAmount;
		[JsonProperty("ndiffpro_trst_sell_qty")]
		public decimal NonArbitrageTrustSellQuantity;
		[JsonProperty("ndiffpro_trst_sell_amt")]
		public decimal NonArbitrageTrustSellAmount;
		[JsonProperty("ndiffpro_trst_buy_qty")]
		public decimal NonArbitrageTrustBuyQuantity;
		[JsonProperty("ndiffpro_trst_buy_amt")]
		public decimal NonArbitrageTrustBuyAmount;
		[JsonProperty("ndiffpro_trst_netprps_qty")]
		public decimal NonArbitrageTrustNetPurchaseQuantity;
		[JsonProperty("ndiffpro_trst_netprps_amt")]
		public decimal NonArbitrageTrustNetPurchaseAmount;
		[JsonProperty("all_dfrt_trst_sell_qty")]
		public decimal TotalArbitrageTrustSellQuantity;
		[JsonProperty("all_dfrt_trst_sell_amt")]
		public decimal TotalArbitrageTrustSellAmount;
		[JsonProperty("all_dfrt_trst_buy_qty")]
		public decimal TotalArbitrageTrustBuyQuantity;
		[JsonProperty("all_dfrt_trst_buy_amt")]
		public decimal TotalArbitrageTrustBuyAmount;
		[JsonProperty("all_dfrt_trst_netprps_qty")]
		public decimal TotalArbitrageTrustNetPurchaseQuantity;
		[JsonProperty("all_dfrt_trst_netprps_amt")]
		public decimal TotalArbitrageTrustNetPurchaseAmount;
	}

	public record KiwoomSectorGetIndustryNetPurchases
	{
		[JsonProperty("inds_netprps")]
		public IEnumerable<KiwoomSectorGetIndustryNetPurchaseItem>? Items;
	}
	public record KiwoomSectorGetIndustryNetPurchaseItem
	{
		[JsonProperty("inds_cd")]
		public string IndustryCode = string.Empty;
		[JsonProperty("inds_nm")]
		public string IndustryName = string.Empty;
		[JsonProperty("cur_prc")]
		public decimal CurrentPrice;
		[JsonProperty("pre_smbol")]
		public string PrevSign = string.Empty;
		[JsonProperty("pred_pre")]
		public decimal PrevDiff;
		[JsonProperty("flu_rt")]
		public decimal FluctuationRate;
		[JsonProperty("trde_qty")]
		public decimal TradeQuantity;
		[JsonProperty("sc_netprps")]
		public decimal SecuritiesNetPurchase;
		[JsonProperty("insrnc_netprps")]
		public decimal InsuranceNetPurchase;
		[JsonProperty("invtrt_netprps")]
		public decimal InvestmentTrustNetPurchase;
		[JsonProperty("bank_netprps")]
		public decimal BankNetPurchase;
		[JsonProperty("jnsinkm_netprps")]
		public decimal PensionNetPurchase;
		[JsonProperty("endw_netprps")]
		public decimal FundNetPurchase;
		[JsonProperty("etc_corp_netprps")]
		public decimal OtherCorporationNetPurchase;
		[JsonProperty("ind_netprps")]
		public decimal IndividualNetPurchase;
		[JsonProperty("frgnr_netprps")]
		public decimal ForeignNetPurchase;
		[JsonProperty("native_trmt_frgnr_netprps")]
		public decimal DomesticTreatedForeignNetPurchase;
		[JsonProperty("natn_netprps")]
		public decimal NationNetPurchase;
		[JsonProperty("samo_fund_netprps")]
		public decimal PrivateFundNetPurchase;
		[JsonProperty("orgn_netprps")]
		public decimal InstitutionNetPurchase;
	}

	public record KiwoomSectorGetIndustryCurrentPrices
	{
		[JsonProperty("cur_prc")]
		public decimal CurrentPrice;
		[JsonProperty("pred_pre_sig")]
		public string PrevDiffSign = string.Empty;
		[JsonProperty("pred_pre")]
		public decimal PrevDiff;
		[JsonProperty("flu_rt")]
		public decimal FluctuationRate;
		[JsonProperty("trde_qty")]
		public decimal TradeQuantity;
		[JsonProperty("trde_prica")]
		public decimal TradeAmount;
		[JsonProperty("trde_frmatn_stk_num")]
		public decimal TradeFormationStockCount;
		[JsonProperty("trde_frmatn_rt")]
		public decimal TradeFormationRate;
		[JsonProperty("open_pric")]
		public decimal OpenPrice;
		[JsonProperty("high_pric")]
		public decimal HighPrice;
		[JsonProperty("low_pric")]
		public decimal LowPrice;
		[JsonProperty("upl")]
		public decimal UpperLimit;
		[JsonProperty("rising")]
		public decimal Rising;
		[JsonProperty("stdns")]
		public decimal Steady;
		[JsonProperty("fall")]
		public decimal Falling;
		[JsonProperty("lst")]
		public decimal LowerLimit;
		[JsonProperty("52wk_hgst_pric")]
		public decimal _52WeekHighestPrice;
		[JsonProperty("52wk_hgst_pric_dt")]
		[JsonConverter(typeof(KiwoomDateConverter))]
		public DateTime _52WeekHighestPriceDate;
		[JsonProperty("52wk_hgst_pric_pre_rt")]
		public decimal _52WeekHighestPriceRate;
		[JsonProperty("52wk_lwst_pric")]
		public decimal _52WeekLowestPrice;
		[JsonProperty("52wk_lwst_pric_dt")]
		[JsonConverter(typeof(KiwoomDateConverter))]
		public DateTime _52WeekLowestPriceDate;
		[JsonProperty("52wk_lwst_pric_pre_rt")]
		public decimal _52WeekLowestPriceRate;
		[JsonProperty("inds_cur_prc_tm")]
		public IEnumerable<KiwoomSectorGetIndustryCurrentPriceItem>? Items;
	}
	public record KiwoomSectorGetIndustryCurrentPriceItem
	{
		[JsonProperty("tm_n")]
		public string Time = string.Empty;
		[JsonProperty("cur_prc_n")]
		public decimal CurrentPrice;
		[JsonProperty("pred_pre_sig_n")]
		public string PrevDiffSign = string.Empty;
		[JsonProperty("pred_pre_n")]
		public decimal PrevDiff;
		[JsonProperty("flu_rt_n")]
		public decimal FluctuationRate;
		[JsonProperty("trde_qty_n")]
		public decimal TradeQuantity;
		[JsonProperty("acc_trde_qty_n")]
		public decimal AccumulatedTradeQuantity;
	}

	public record KiwoomSectorGetIndustryStockPrices
	{
		[JsonProperty("inds_stkpc")]
		public IEnumerable<KiwoomSectorGetIndustryStockPriceItem>? Items;
	}
	public record KiwoomSectorGetIndustryStockPriceItem
	{
		[JsonProperty("stk_cd")]
		public string StockCode = string.Empty;
		[JsonProperty("stk_nm")]
		public string StockName = string.Empty;
		[JsonProperty("cur_prc")]
		public decimal CurrentPrice;
		[JsonProperty("pred_pre_sig")]
		public string PrevDiffSign = string.Empty;
		[JsonProperty("pred_pre")]
		public decimal PrevDiff;
		[JsonProperty("flu_rt")]
		public decimal FluctuationRate;
		[JsonProperty("now_trde_qty")]
		public decimal CurrentTradeQuantity;
		[JsonProperty("sel_bid")]
		public decimal SellBid;
		[JsonProperty("buy_bid")]
		public decimal BuyBid;
		[JsonProperty("open_pric")]
		public decimal OpenPrice;
		[JsonProperty("high_pric")]
		public decimal HighPrice;
		[JsonProperty("low_pric")]
		public decimal LowPrice;
	}

	public record KiwoomSectorGetAllIndustryIndices
	{
		[JsonProperty("all_inds_idex")]
		public IEnumerable<KiwoomSectorGetAllIndustryIndexItem>? Items;
	}
	public record KiwoomSectorGetAllIndustryIndexItem
	{
		[JsonProperty("stk_cd")]
		public string StockCode = string.Empty;
		[JsonProperty("stk_nm")]
		public string StockName = string.Empty;
		[JsonProperty("cur_prc")]
		public decimal CurrentPrice;
		[JsonProperty("pre_sig")]
		public string PrevSign = string.Empty;
		[JsonProperty("pred_pre")]
		public decimal PrevDiff;
		[JsonProperty("flu_rt")]
		public decimal FluctuationRate;
		[JsonProperty("trde_qty")]
		public decimal TradeQuantity;
		[JsonProperty("wght")]
		public decimal Weight;
		[JsonProperty("trde_prica")]
		public decimal TradeAmount;
		[JsonProperty("upl")]
		public decimal UpperLimit;
		[JsonProperty("rising")]
		public decimal Rising;
		[JsonProperty("stdns")]
		public decimal Steady;
		[JsonProperty("fall")]
		public decimal Falling;
		[JsonProperty("lst")]
		public decimal LowerLimit;
		[JsonProperty("flo_stk_num")]
		public decimal ListedStockCount;
	}

	public record KiwoomSectorGetDailyIndustryPrices
	{
		[JsonProperty("cur_prc")]
		public decimal CurrentPrice;
		[JsonProperty("pred_pre_sig")]
		public string PrevDiffSign = string.Empty;
		[JsonProperty("pred_pre")]
		public decimal PrevDiff;
		[JsonProperty("flu_rt")]
		public decimal FluctuationRate;
		[JsonProperty("trde_qty")]
		public decimal TradeQuantity;
		[JsonProperty("trde_prica")]
		public decimal TradeAmount;
		[JsonProperty("trde_frmatn_stk_num")]
		public decimal TradeFormationStockCount;
		[JsonProperty("trde_frmatn_rt")]
		public decimal TradeFormationRate;
		[JsonProperty("open_pric")]
		public decimal OpenPrice;
		[JsonProperty("high_pric")]
		public decimal HighPrice;
		[JsonProperty("low_pric")]
		public decimal LowPrice;
		[JsonProperty("upl")]
		public decimal UpperLimit;
		[JsonProperty("rising")]
		public decimal Rising;
		[JsonProperty("stdns")]
		public decimal Steady;
		[JsonProperty("fall")]
		public decimal Falling;
		[JsonProperty("lst")]
		public decimal LowerLimit;
		[JsonProperty("52wk_hgst_pric")]
		public decimal _52WeekHighestPrice;
		[JsonProperty("52wk_hgst_pric_dt")]
		[JsonConverter(typeof(KiwoomDateConverter))]
		public DateTime _52WeekHighestPriceDate;
		[JsonProperty("52wk_hgst_pric_pre_rt")]
		public decimal _52WeekHighestPriceRate;
		[JsonProperty("52wk_lwst_pric")]
		public decimal _52WeekLowestPrice;
		[JsonProperty("52wk_lwst_pric_dt")]
		[JsonConverter(typeof(KiwoomDateConverter))]
		public DateTime _52WeekLowestPriceDate;
		[JsonProperty("52wk_lwst_pric_pre_rt")]
		public decimal _52WeekLowestPriceRate;
		[JsonProperty("inds_cur_prc_daly_rept")]
		public IEnumerable<KiwoomSectorGetDailyIndustryPriceItem>? Items;
	}
	public record KiwoomSectorGetDailyIndustryPriceItem
	{
		[JsonProperty("dt_n")]
		[JsonConverter(typeof(KiwoomDateConverter))]
		public DateTime Date;
		[JsonProperty("cur_prc_n")]
		public decimal CurrentPrice;
		[JsonProperty("pred_pre_sig_n")]
		public string PrevDiffSign = string.Empty;
		[JsonProperty("pred_pre_n")]
		public decimal PrevDiff;
		[JsonProperty("flu_rt_n")]
		public decimal FluctuationRate;
		[JsonProperty("acc_trde_qty_n")]
		public decimal AccumulatedTradeQuantity;
	}

}
