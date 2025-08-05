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

	public record KiwoomAccountGetTodayRealizedProfitLoss
	{
		[JsonProperty("tdy_rlzt_pl")]
		public decimal TodayRealizedProfitLoss;
		[JsonProperty("tdy_rlzt_pl_dtl")]
		public IEnumerable<KiwoomAccountGetTodayRealizedProfitLossItem>? Items;
	}
	public record KiwoomAccountGetTodayRealizedProfitLossItem
	{
		[JsonProperty("stk_nm")]
		public string StockName = string.Empty;
		[JsonProperty("cntr_qty")]
		public decimal? ContractQuantity;
		[JsonProperty("buy_uv")]
		public decimal? BuyUnitPrice;
		[JsonProperty("cntr_pric")]
		public decimal? ContractPrice;
		[JsonProperty("tdy_sel_pl")]
		public decimal? TodaySellProfitLoss;
		[JsonProperty("pl_rt")]
		public decimal? ProfitLossRate;
		[JsonProperty("tdy_trde_cmsn")]
		public decimal? TodayTradeCommission;
		[JsonProperty("tdy_trde_tax")]
		public decimal? TodayTradeTax;
		[JsonProperty("stk_cd")]
		public string StockCode = string.Empty;
	}

	public record KiwoomAccountGetProfitRate
	{
		[JsonProperty("acnt_prft_rt")]
		public IEnumerable<KiwoomAccountGetProfitRateItem>? Items;
	}
	public record KiwoomAccountGetProfitRateItem
	{
		[JsonProperty("dt")]
		public string Date = string.Empty;
		[JsonProperty("stk_cd")]
		public string StockCode = string.Empty;
		[JsonProperty("stk_nm")]
		public string StockName = string.Empty;
		[JsonProperty("cur_prc")]
		public decimal CurrentPrice;
		[JsonProperty("pur_pric")]
		public decimal PurchasePrice;
		[JsonProperty("pur_amt")]
		public decimal PurchaseAmount;
		[JsonProperty("rmnd_qty")]
		public decimal RemainQuantity;
		[JsonProperty("tdy_sel_pl")]
		public decimal TodaySellProfitLoss;
		[JsonProperty("tdy_trde_cmsn")]
		public decimal TodayTradeCommission;
		[JsonProperty("tdy_trde_tax")]
		public decimal TodayTradeTax;
		[JsonProperty("crd_tp")]
		public string CreditType = string.Empty;
		[JsonProperty("loan_dt")]
		public string LoanDate = string.Empty;
		[JsonProperty("setl_remn")]
		public decimal SettlementRemain;
		[JsonProperty("clrn_alow_qty")]
		public decimal ClearanceAllowQuantity;
		[JsonProperty("crd_amt")]
		public decimal CreditAmount;
		[JsonProperty("crd_int")]
		public decimal CreditInterest;
		[JsonProperty("expr_dt")]
		public string ExpireDate = string.Empty;
	}

	public record KiwoomAccountGetOutstandingPartialOrders
	{
		[JsonProperty("osop")]
		public IEnumerable<KiwoomAccountGetOutstandingPartialOrderItem>? Items;
	}
	public record KiwoomAccountGetOutstandingPartialOrderItem
	{
		[JsonProperty("stk_cd")]
		public string StockCode = string.Empty;
		[JsonProperty("stk_nm")]
		public string StockName = string.Empty;
		[JsonProperty("ord_no")]
		public string OrderId = string.Empty;
		[JsonProperty("ord_qty")]
		public decimal OrderQuantity;
		[JsonProperty("ord_pric")]
		public decimal OrderPrice;
		[JsonProperty("osop_qty")]
		public decimal OutstandingQuantity;
		[JsonProperty("io_tp_nm")]
		public string OrderTypeName = string.Empty;
		[JsonProperty("trde_tp")]
		public string TradeType = string.Empty;
		[JsonProperty("sell_tp")]
		public string SellType = string.Empty;
		[JsonProperty("cntr_qty")]
		public decimal ContractQuantity;
		[JsonProperty("ord_stt")]
		public string OrderStatus = string.Empty;
		[JsonProperty("cur_prc")]
		public decimal CurrentPrice;
		[JsonProperty("stex_tp")]
		public KiwoomStockExchangeType StockExchangeType;
		[JsonProperty("stex_tp_txt")]
		public string StockExchangeTypeText = string.Empty;
	}

	public record KiwoomAccountGetTodayTradeDiaries
	{
		[JsonProperty("tot_sell_amt")]
		public decimal TotalSellAmount;
		[JsonProperty("tot_buy_amt")]
		public decimal TotalBuyAmount;
		[JsonProperty("tot_cmsn_tax")]
		public decimal TotalCommissionTax;
		[JsonProperty("tot_exct_amt")]
		public decimal TotalSettlementAmount;
		[JsonProperty("tot_pl_amt")]
		public decimal TotalProfitLossAmount;
		[JsonProperty("tot_prft_rt")]
		public decimal TotalProfitRate;
		[JsonProperty("tdy_trde_diary")]
		public IEnumerable<KiwoomAccountGetTodayTradeDiaryItem>? Items;
	}
	public record KiwoomAccountGetTodayTradeDiaryItem
	{
		[JsonProperty("stk_nm")]
		public string StockName = string.Empty;
		[JsonProperty("buy_avg_pric")]
		public decimal BuyAveragePrice;
		[JsonProperty("buy_qty")]
		public decimal BuyQuantity;
		[JsonProperty("sel_avg_pric")]
		public decimal SellAveragePrice;
		[JsonProperty("sell_qty")]
		public decimal SellQuantity;
		[JsonProperty("cmsn_alm_tax")]
		public decimal CommissionAmountTax;
		[JsonProperty("pl_amt")]
		public decimal ProfitLossAmount;
		[JsonProperty("sell_amt")]
		public decimal SellAmount;
		[JsonProperty("buy_amt")]
		public decimal BuyAmount;
		[JsonProperty("prft_rt")]
		public decimal ProfitRate;
		[JsonProperty("stk_cd")]
		public string StockCode = string.Empty;
	}

	public record KiwoomAccountGetDeposits
	{
		[JsonProperty("entr")]
		public decimal DepositAmount;
		[JsonProperty("profa_ch")]
		public decimal StockMarginCash;
		[JsonProperty("bncr_profa_ch")]
		public decimal BeneficiaryMarginCash;
		[JsonProperty("nxdy_bncr_sell_exct")]
		public decimal NextDayBeneficiarySellSettlementAmount;
		[JsonProperty("fc_stk_krw_repl_set_amt")]
		public decimal OverseasStockKRWReplenishmentAmount;
		[JsonProperty("crd_grnta_ch")]
		public decimal CreditGuaranteeCash;
		[JsonProperty("crd_grnt_ch")]
		public decimal CreditCollateralCash;
		[JsonProperty("add_grnt_ch")]
		public decimal AdditionalCollateralCash;
		[JsonProperty("etc_profa")]
		public decimal OtherMargin;
		[JsonProperty("uncl_stk_amt")]
		public decimal UnsettledAmount;
		[JsonProperty("shrts_prica")]
		public decimal ShortSaleAmount;
		[JsonProperty("crd_set_grnta")]
		public decimal CreditSettlementGuaranteeAmount;
		[JsonProperty("chck_ina_amt")]
		public decimal CheckDepositAmount;
		[JsonProperty("etc_chck_ina_amt")]
		public decimal OtherCheckDepositAmount;
		[JsonProperty("crd_grnt_ruse")]
		public decimal CreditCollateralReuse;
		[JsonProperty("knx_asset_evltv")]
		public decimal KONEXBasicDeposit;
		[JsonProperty("elwdpst_evlta")]
		public decimal ELWDepositEvaluation;
		[JsonProperty("crd_ls_rght_frcs_amt")]
		public decimal CreditLoanRightsExpectedAmount;
		[JsonProperty("lvlh_join_amt")]
		public decimal LivelihoodTypeJoinAmount;
		[JsonProperty("lvlh_trns_alowa")]
		public decimal LivelihoodTypeWithdrawalAllowedAmount;
		[JsonProperty("repl_amt")]
		public decimal ReplenishmentEvaluationAmount;
		[JsonProperty("remn_repl_evlta")]
		public decimal RemainingReplenishmentEvaluationAmount;
		[JsonProperty("trst_remn_repl_evlta")]
		public decimal EntrustedRemainingReplenishmentEvaluationAmount;
		[JsonProperty("bncr_remn_repl_evlta")]
		public decimal BeneficiaryRemainingReplenishmentEvaluationAmount;
		[JsonProperty("profa_repl")]
		public decimal EntrustedMarginReplenishment;
		[JsonProperty("crd_grnta_repl")]
		public decimal CreditGuaranteeReplenishment;
		[JsonProperty("crd_grnt_repl")]
		public decimal CreditCollateralReplenishment;
		[JsonProperty("add_grnt_repl")]
		public decimal AdditionalCollateralReplenishment;
		[JsonProperty("rght_repl_amt")]
		public decimal RightsReplenishmentAmount;
		[JsonProperty("pymn_alow_amt")]
		public decimal WithdrawalAllowedAmount;
		[JsonProperty("wrap_pymn_alow_amt")]
		public decimal WrapWithdrawalAllowedAmount;
		[JsonProperty("ord_alow_amt")]
		public decimal OrderAllowedAmount;
		[JsonProperty("bncr_buy_alowa")]
		public decimal BeneficiaryBuyAllowedAmount;
		[JsonProperty("20stk_ord_alow_amt")]
		public decimal OrderAllowedAmount20Percent;
		[JsonProperty("30stk_ord_alow_amt")]
		public decimal OrderAllowedAmount30Percent;
		[JsonProperty("40stk_ord_alow_amt")]
		public decimal OrderAllowedAmount40Percent;
		[JsonProperty("100stk_ord_alow_amt")]
		public decimal OrderAllowedAmount100Percent;
		[JsonProperty("ch_uncla")]
		public decimal CashUnsettledAmount;
		[JsonProperty("ch_uncla_dlfe")]
		public decimal CashUnsettledLateFee;
		[JsonProperty("ch_uncla_tot")]
		public decimal CashUnsettledTotal;
		[JsonProperty("crd_int_npay")]
		public decimal CreditInterestUnpaid;
		[JsonProperty("int_npay_amt_dlfe")]
		public decimal CreditInterestUnpaidLateFee;
		[JsonProperty("int_npay_amt_tot")]
		public decimal CreditInterestUnpaidTotal;
		[JsonProperty("etc_loana")]
		public decimal OtherLoanAmount;
		[JsonProperty("etc_loana_dlfe")]
		public decimal OtherLoanLateFee;
		[JsonProperty("etc_loan_tot")]
		public decimal OtherLoanTotal;
		[JsonProperty("nrpy_loan")]
		public decimal UnpaidLoanAmount;
		[JsonProperty("loan_sum")]
		public decimal LoanTotalAmount;
		[JsonProperty("ls_sum")]
		public decimal LoanSum;
		[JsonProperty("crd_grnt_rt")]
		public decimal CreditCollateralRate;
		[JsonProperty("mdstrm_usfe")]
		public decimal MidtermUsageFee;
		[JsonProperty("min_ord_alow_yn")]
		public string MinOrderAllowedYn = string.Empty;
		[JsonProperty("loan_remn_evlt_amt")]
		public decimal LoanRemainingEvaluationAmount;
		[JsonProperty("dpst_grntl_remn")]
		public decimal DepositCollateralLoanBalance;
		[JsonProperty("sell_grntl_remn")]
		public decimal SellCollateralLoanBalance;
		[JsonProperty("d1_entra")]
		public decimal D1EstimatedDeposit;
		[JsonProperty("d1_slby_exct_amt")]
		public decimal D1SellBuySettlementAmount;
		[JsonProperty("d1_buy_exct_amt")]
		public decimal D1BuySettlementAmount;
		[JsonProperty("d1_out_rep_mor")]
		public decimal D1UnpaidRepaymentRequiredAmount;
		[JsonProperty("d1_sel_exct_amt")]
		public decimal D1SellSettlementAmount;
		[JsonProperty("d1_pymn_alow_amt")]
		public decimal D1WithdrawalAllowedAmount;
		[JsonProperty("d2_entra")]
		public decimal D2EstimatedDeposit;
		[JsonProperty("d2_slby_exct_amt")]
		public decimal D2SellBuySettlementAmount;
		[JsonProperty("d2_buy_exct_amt")]
		public decimal D2BuySettlementAmount;
		[JsonProperty("d2_out_rep_mor")]
		public decimal D2UnpaidRepaymentRequiredAmount;
		[JsonProperty("d2_sel_exct_amt")]
		public decimal D2SellSettlementAmount;
		[JsonProperty("d2_pymn_alow_amt")]
		public decimal D2WithdrawalAllowedAmount;
		[JsonProperty("50stk_ord_alow_amt")]
		public decimal OrderAllowedAmount50Percent;
		[JsonProperty("60stk_ord_alow_amt")]
		public decimal OrderAllowedAmount60Percent;
		[JsonProperty("stk_entr_prst")]
		public IEnumerable<KiwoomAccountGetDepositItem>? StockDepositItems;
	}
	public record KiwoomAccountGetDepositItem
	{
		[JsonProperty("crnc_cd")]
		public string CurrencyCode = string.Empty;
		[JsonProperty("fx_entr")]
		public decimal ForeignCurrencyDeposit;
		[JsonProperty("fc_krw_repl_evlta")]
		public decimal KRWReplenishmentEvaluationAmount;
		[JsonProperty("fc_trst_profa")]
		public decimal OverseasStockMargin;
		[JsonProperty("pymn_alow_amt")]
		public decimal WithdrawalAllowedAmount;
		[JsonProperty("pymn_alow_amt_entr")]
		public decimal WithdrawalAllowedAmountDeposit;
		[JsonProperty("ord_alow_amt_entr")]
		public decimal OrderAllowedAmountDeposit;
		[JsonProperty("fc_uncla")]
		public decimal ForeignCurrencyUnpaidTotal;
		[JsonProperty("fc_ch_uncla")]
		public decimal ForeignCurrencyCashUnpaid;
		[JsonProperty("dly_amt")]
		public decimal DelinquencyAmount;
		[JsonProperty("d1_fx_entr")]
		public decimal D1ForeignCurrencyDeposit;
		[JsonProperty("d2_fx_entr")]
		public decimal D2ForeignCurrencyDeposit;
		[JsonProperty("d3_fx_entr")]
		public decimal D3ForeignCurrencyDeposit;
		[JsonProperty("d4_fx_entr")]
		public decimal D4ForeignCurrencyDeposit;
	}

	public record KiwoomAccountGetDailyEstimatedDepositAssets
	{
		[JsonProperty("daly_prsm_dpst_aset_amt_prst")]
		public IEnumerable<KiwoomAccountGetDailyEstimatedDepositAssetItem>? Items;
	}
	public record KiwoomAccountGetDailyEstimatedDepositAssetItem
	{
		[JsonProperty("dt")]
		public string Date = string.Empty;
		[JsonProperty("entr")]
		public decimal DepositAmount;
		[JsonProperty("grnt_use_amt")]
		public decimal CollateralLoanAmount;
		[JsonProperty("crd_loan")]
		public decimal CreditLoanAmount;
		[JsonProperty("ls_grnt")]
		public decimal LoanCollateralAmount;
		[JsonProperty("repl_amt")]
		public decimal ReplenishmentAmount;
		[JsonProperty("prsm_dpst_aset_amt")]
		public decimal EstimatedDepositAssetAmount;
		[JsonProperty("prsm_dpst_aset_amt_bncr_skip")]
		public decimal EstimatedDepositAssetAmountExcludingBeneficiarySecurities;
	}

}
