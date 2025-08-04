using KiwoomRestApi.Net.Converters;
using KiwoomRestApi.Net.Enums;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models
{
	public record KiwoomAccountGetDateStockRealizedProfitLoss
	{
		[JsonProperty("dt_stk_div_rlzt_pl")]
		public IEnumerable<KiwoomAccountGetDateStockRealizedProfitLossItem>? Items;
	}
	public record KiwoomAccountGetDateStockRealizedProfitLossItem
	{
		[JsonProperty("stk_cd")]
		public string StockCode = string.Empty;
		[JsonProperty("stk_nm")]
		public string StockName = string.Empty;
		[JsonProperty("cntr_qty")]
		public decimal ContractQuantity;
		[JsonProperty("cntr_pric")]
		public decimal ContractPrice;
		[JsonProperty("buy_uv")]
		public decimal BuyUnitValue;
		[JsonProperty("tdy_sel_pl")]
		public decimal TodaySellProfitLoss;
		[JsonProperty("pl_rt")]
		public decimal ProfitLossRate;
		[JsonProperty("tdy_trde_cmsn")]
		public decimal TodayTradeCommission;
		[JsonProperty("tdy_trde_tax")]
		public decimal TodayTradeTax;
		[JsonProperty("wthd_alowa")]
		public decimal WithdrawalAllowable;
		[JsonProperty("loan_dt")]
		[JsonConverter(typeof(KiwoomDateConverter))]
		public DateTime LoanDate;
		[JsonProperty("crd_tp")]
		public string CreditType = string.Empty;
		[JsonProperty("stk_cd_1")]
		public string StockCode1 = string.Empty;
		[JsonProperty("tdy_sel_pl_1")]
		public decimal TodaySellProfitLoss1;
	}

	public record KiwoomAccountGetPeriodStockRealizedProfitLoss
	{
		[JsonProperty("dt_stk_rlzt_pl")]
		public IEnumerable<KiwoomAccountGetPeriodStockRealizedProfitLossItem>? Items;
	}
	public record KiwoomAccountGetPeriodStockRealizedProfitLossItem
	{
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateConverter))]
		public DateTime Date;
		[JsonProperty("tdy_htssel_cmsn")]
		public decimal TodayHtsSellCommission;
		[JsonProperty("stk_cd")]
		public string StockCode = string.Empty;
		[JsonProperty("stk_nm")]
		public string StockName = string.Empty;
		[JsonProperty("cntr_qty")]
		public decimal ContractQuantity;
		[JsonProperty("cntr_pric")]
		public decimal ContractPrice;
		[JsonProperty("buy_uv")]
		public decimal BuyUnitValue;
		[JsonProperty("tdy_sel_pl")]
		public decimal TodaySellProfitLoss;
		[JsonProperty("pl_rt")]
		public decimal ProfitLossRate;
		[JsonProperty("tdy_trde_cmsn")]
		public decimal TodayTradeCommission;
		[JsonProperty("tdy_trde_tax")]
		public decimal TodayTradeTax;
		[JsonProperty("wthd_alowa")]
		public decimal WithdrawalAllowable;
		[JsonProperty("loan_dt")]
		[JsonConverter(typeof(KiwoomDateConverter))]
		public DateTime LoanDate;
		[JsonProperty("crd_tp")]
		public string CreditType = string.Empty;
	}

	public record KiwoomAccountGetRealizedProfitLoss
	{
		[JsonProperty("tot_buy_amt")]
		public decimal TotalBuyAmount;
		[JsonProperty("tot_sell_amt")]
		public decimal TotalSellAmount;
		[JsonProperty("rlzt_pl")]
		public decimal RealizedProfitLoss;
		[JsonProperty("trde_cmsn")]
		public decimal TradeCommission;
		[JsonProperty("trde_tax")]
		public decimal TradeTax;
		[JsonProperty("dt_rlzt_pl")]
		public IEnumerable<KiwoomAccountGetRealizedProfitLossItem>? Items;
	}
	public record KiwoomAccountGetRealizedProfitLossItem
	{
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateConverter))]
		public DateTime Date;
		[JsonProperty("buy_amt")]
		public decimal BuyAmount;
		[JsonProperty("sell_amt")]
		public decimal SellAmount;
		[JsonProperty("tdy_sel_pl")]
		public decimal TodaySellProfitLoss;
		[JsonProperty("tdy_trde_cmsn")]
		public decimal TodayTradeCommission;
		[JsonProperty("tdy_trde_tax")]
		public decimal TodayTradeTax;
	}

	public record KiwoomAccountGetOutstandingOrders
	{
		[JsonProperty("oso")]
		public IEnumerable<KiwoomAccountGetOutstandingOrderItem>? Items;
	}
	public record KiwoomAccountGetOutstandingOrderItem
	{
		[JsonProperty("acnt_no")]
		public string AccountId = string.Empty;
		[JsonProperty("ord_no")]
		public string OrderId = string.Empty;
		[JsonProperty("mang_empno")]
		public string ManagerEmployeeId = string.Empty;
		[JsonProperty("stk_cd")]
		public string StockCode = string.Empty;
		[JsonProperty("tsk_tp")]
		public string TaskType = string.Empty;
		[JsonProperty("ord_stt")]
		public string OrderStatus = string.Empty;
		[JsonProperty("stk_nm")]
		public string StockName = string.Empty;
		[JsonProperty("ord_qty")]
		public decimal OrderQuantity;
		[JsonProperty("ord_pric")]
		public decimal OrderPrice;
		[JsonProperty("oso_qty")]
		public decimal OutstandingQuantity;
		[JsonProperty("cntr_tot_amt")]
		public decimal ContractTotalAmount;
		[JsonProperty("orig_ord_no")]
		public string OriginalOrderId = string.Empty;
		[JsonProperty("io_tp_nm")]
		public string OrderTypeName = string.Empty;
		[JsonProperty("trde_tp")]
		public string TradeType = string.Empty;
		[JsonProperty("tm")]
		[JsonConverter(typeof(KiwoomTimeConverter))]
		public TimeSpan Time;
		[JsonProperty("cntr_no")]
		public string ContractId = string.Empty;
		[JsonProperty("cntr_pric")]
		public decimal ContractPrice;
		[JsonProperty("cntr_qty")]
		public decimal ContractQuantity;
		[JsonProperty("cur_prc")]
		public decimal CurrentPrice;
		[JsonProperty("sel_bid")]
		public decimal SellBid;
		[JsonProperty("buy_bid")]
		public decimal BuyBid;
		[JsonProperty("unit_cntr_pric")]
		public decimal? UnitContractPrice;
		[JsonProperty("unit_cntr_qty")]
		public decimal? UnitContractQuantity;
		[JsonProperty("tdy_trde_cmsn")]
		public decimal TodayTradeCommission;
		[JsonProperty("tdy_trde_tax")]
		public decimal TodayTradeTax;
		[JsonProperty("ind_invsr")]
		public string IndividualInvestor = string.Empty;
		[JsonProperty("stex_tp")]
		public KiwoomStockExchangeType StockExchangeType;
		[JsonProperty("stex_tp_txt")]
		public string StockExchangeTypeText = string.Empty;
		[JsonProperty("sor_yn")]
		[JsonConverter(typeof(KiwoomBoolConverter))]
		public bool SorIndicator;
		[JsonProperty("stop_pric")]
		public decimal StopPrice;
	}

	public record KiwoomAccountGetContracts
	{
		[JsonProperty("cntr")]
		public IEnumerable<KiwoomAccountGetContractItem>? Items;
	}
	public record KiwoomAccountGetContractItem
	{
		[JsonProperty("ord_no")]
		public string OrderId = string.Empty;
		[JsonProperty("stk_nm")]
		public string StockName = string.Empty;
		[JsonProperty("io_tp_nm")]
		public string OrderTypeName = string.Empty;
		[JsonProperty("ord_pric")]
		public decimal OrderPrice;
		[JsonProperty("ord_qty")]
		public decimal OrderQuantity;
		[JsonProperty("cntr_pric")]
		public decimal ContractPrice;
		[JsonProperty("cntr_qty")]
		public decimal ContractQuantity;
		[JsonProperty("oso_qty")]
		public decimal OutstandingQuantity;
		[JsonProperty("tdy_trde_cmsn")]
		public decimal TodayTradeCommission;
		[JsonProperty("tdy_trde_tax")]
		public decimal TodayTradeTax;
		[JsonProperty("ord_stt")]
		public string OrderStatus = string.Empty;
		[JsonProperty("trde_tp")]
		public string TradeType = string.Empty;
		[JsonProperty("orig_ord_no")]
		public string OriginalOrderId = string.Empty;
		[JsonProperty("ord_tm")]
		[JsonConverter(typeof(KiwoomTimeConverter))]
		public TimeSpan OrderTime;
		[JsonProperty("stk_cd")]
		public string StockCode = string.Empty;
		[JsonProperty("stex_tp")]
		public KiwoomStockExchangeType StockExchangeType;
		[JsonProperty("stex_tp_txt")]
		public string StockExchangeTypeText = string.Empty;
		[JsonProperty("sor_yn")]
		[JsonConverter(typeof(KiwoomBoolConverter))]
		public bool SorIndicator;
		[JsonProperty("stop_pric")]
		public decimal StopPrice;
	}

}
