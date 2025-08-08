using KiwoomRestApi.Net.Converters;
using KiwoomRestApi.Net.Enums.Account;

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
		public string LoanDate = string.Empty;
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
		public string LoanDate = string.Empty;
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
		[JsonConverter(typeof(KiwoomNullableDateConverter))]
		public DateTime? Date;
		[JsonProperty("buy_amt")]
		public decimal? BuyAmount;
		[JsonProperty("sell_amt")]
		public decimal? SellAmount;
		[JsonProperty("tdy_sel_pl")]
		public decimal? TodaySellProfitLoss;
		[JsonProperty("tdy_trde_cmsn")]
		public decimal? TodayTradeCommission;
		[JsonProperty("tdy_trde_tax")]
		public decimal? TodayTradeTax;
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
		public KiwoomAccountStockExchangeType StockExchangeType;
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
		public KiwoomAccountStockExchangeType StockExchangeType;
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
		public KiwoomAccountStockExchangeType StockExchangeType;
		[JsonProperty("stex_tp_txt")]
		public string StockExchangeTypeText = string.Empty;
	}

	public record KiwoomAccountGetTodayTradeDiaries
	{
		[JsonProperty("tot_sell_amt")]
		public decimal? TotalSellAmount;
		[JsonProperty("tot_buy_amt")]
		public decimal? TotalBuyAmount;
		[JsonProperty("tot_cmsn_tax")]
		public decimal? TotalCommissionTax;
		[JsonProperty("tot_exct_amt")]
		public decimal? TotalSettlementAmount;
		[JsonProperty("tot_pl_amt")]
		public decimal? TotalProfitLossAmount;
		[JsonProperty("tot_prft_rt")]
		public decimal? TotalProfitRate;
		[JsonProperty("tdy_trde_diary")]
		public IEnumerable<KiwoomAccountGetTodayTradeDiaryItem>? Items;
	}
	public record KiwoomAccountGetTodayTradeDiaryItem
	{
		[JsonProperty("stk_nm")]
		public string StockName = string.Empty;
		[JsonProperty("buy_avg_pric")]
		public decimal? BuyAveragePrice;
		[JsonProperty("buy_qty")]
		public decimal? BuyQuantity;
		[JsonProperty("sel_avg_pric")]
		public decimal? SellAveragePrice;
		[JsonProperty("sell_qty")]
		public decimal? SellQuantity;
		[JsonProperty("cmsn_alm_tax")]
		public decimal? CommissionAmountTax;
		[JsonProperty("pl_amt")]
		public decimal? ProfitLossAmount;
		[JsonProperty("sell_amt")]
		public decimal? SellAmount;
		[JsonProperty("buy_amt")]
		public decimal? BuyAmount;
		[JsonProperty("prft_rt")]
		public decimal? ProfitRate;
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

	public record KiwoomAccountGetEstimatedDepositAsset
	{
		[JsonProperty("prsm_dpst_aset_amt")]
		public decimal EstimatedDepositAssetAmount;
	}

	public record KiwoomAccountGetEvaluations
	{
		[JsonProperty("acnt_nm")]
		public string AccountName = string.Empty;
		[JsonProperty("brch_nm")]
		public string BranchName = string.Empty;
		[JsonProperty("entr")]
		public decimal DepositAmount;
		[JsonProperty("d2_entra")]
		public decimal D2EstimatedDeposit;
		[JsonProperty("tot_est_amt")]
		public decimal TotalStockBalanceEvaluationAmount;
		[JsonProperty("aset_evlt_amt")]
		public decimal DepositAssetEvaluationAmount;
		[JsonProperty("tot_pur_amt")]
		public decimal TotalPurchaseAmount;
		[JsonProperty("prsm_dpst_aset_amt")]
		public decimal EstimatedDepositAssetAmount;
		[JsonProperty("tot_grnt_sella")]
		public decimal TotalSellCollateralLoanAmount;
		[JsonProperty("tdy_lspft_amt")]
		public decimal TodayInvestmentPrincipalAmount;
		[JsonProperty("invt_bsamt")]
		public decimal CurrentMonthInvestmentPrincipalAmount;
		[JsonProperty("lspft_amt")]
		public decimal CumulativeInvestmentPrincipalAmount;
		[JsonProperty("tdy_lspft")]
		public decimal TodayInvestmentProfitLoss;
		[JsonProperty("lspft2")]
		public decimal CurrentMonthInvestmentProfitLoss;
		[JsonProperty("lspft")]
		public decimal CumulativeInvestmentProfitLoss;
		[JsonProperty("tdy_lspft_rt")]
		public decimal TodayProfitLossRate;
		[JsonProperty("lspft_ratio")]
		public decimal CurrentMonthProfitLossRate;
		[JsonProperty("lspft_rt")]
		public decimal CumulativeProfitLossRate;
		[JsonProperty("stk_acnt_evlt_prst")]
		public IEnumerable<KiwoomAccountGetEvaluationItem>? Items;
	}
	public record KiwoomAccountGetEvaluationItem
	{
		[JsonProperty("stk_cd")]
		public string StockCode = string.Empty;
		[JsonProperty("stk_nm")]
		public string StockName = string.Empty;
		[JsonProperty("rmnd_qty")]
		public decimal RemainingQuantity;
		[JsonProperty("avg_prc")]
		public decimal AveragePrice;
		[JsonProperty("cur_prc")]
		public decimal CurrentPrice;
		[JsonProperty("evlt_amt")]
		public decimal EvaluationAmount;
		[JsonProperty("pl_amt")]
		public decimal ProfitLossAmount;
		[JsonProperty("pl_rt")]
		public decimal ProfitLossRate;
		[JsonProperty("loan_dt")]
		public string LoanDate = string.Empty;
		[JsonProperty("pur_amt")]
		public decimal PurchaseAmount;
		[JsonProperty("setl_remn")]
		public decimal SettlementBalance;
		[JsonProperty("pred_buyq")]
		public decimal PreviousDayBuyQuantity;
		[JsonProperty("pred_sellq")]
		public decimal PreviousDaySellQuantity;
		[JsonProperty("tdy_buyq")]
		public decimal TodayBuyQuantity;
		[JsonProperty("tdy_sellq")]
		public decimal TodaySellQuantity;
	}

	public record KiwoomAccountGetContractBalances
	{
		[JsonProperty("entr")]
		public decimal DepositAmount;
		[JsonProperty("entr_d1")]
		public decimal DepositAmountD1;
		[JsonProperty("entr_d2")]
		public decimal DepositAmountD2;
		[JsonProperty("pymn_alow_amt")]
		public decimal WithdrawalAllowedAmount;
		[JsonProperty("uncl_stk_amt")]
		public decimal UnsettledAmount;
		[JsonProperty("repl_amt")]
		public decimal ReplenishmentAmount;
		[JsonProperty("rght_repl_amt")]
		public decimal RightsReplenishmentAmount;
		[JsonProperty("ord_alowa")]
		public decimal CashOrderAllowedAmount;
		[JsonProperty("ch_uncla")]
		public decimal CashUnsettledAmount;
		[JsonProperty("crd_int_npay_gold")]
		public decimal CreditInterestUnpaidAmount;
		[JsonProperty("etc_loana")]
		public decimal OtherLoanAmount;
		[JsonProperty("nrpy_loan")]
		public decimal UnpaidLoanAmount;
		[JsonProperty("profa_ch")]
		public decimal MarginCash;
		[JsonProperty("repl_profa")]
		public decimal MarginReplenishment;
		[JsonProperty("stk_buy_tot_amt")]
		public decimal TotalStockPurchaseAmount;
		[JsonProperty("evlt_amt_tot")]
		public decimal TotalEvaluationAmount;
		[JsonProperty("tot_pl_tot")]
		public decimal TotalProfitLossAmount;
		[JsonProperty("tot_pl_rt")]
		public decimal TotalProfitLossRate;
		[JsonProperty("tot_re_buy_alowa")]
		public decimal TotalRebuyAllowedAmount;
		[JsonProperty("20ord_alow_amt")]
		public decimal OrderAllowedAmount20Percent;
		[JsonProperty("30ord_alow_amt")]
		public decimal OrderAllowedAmount30Percent;
		[JsonProperty("40ord_alow_amt")]
		public decimal OrderAllowedAmount40Percent;
		[JsonProperty("50ord_alow_amt")]
		public decimal OrderAllowedAmount50Percent;
		[JsonProperty("60ord_alow_amt")]
		public decimal OrderAllowedAmount60Percent;
		[JsonProperty("100ord_alow_amt")]
		public decimal OrderAllowedAmount100Percent;
		[JsonProperty("crd_loan_tot")]
		public decimal TotalCreditLoan;
		[JsonProperty("crd_loan_ls_tot")]
		public decimal TotalCreditLoanAndLoan;
		[JsonProperty("crd_grnt_rt")]
		public decimal CreditCollateralRatio;
		[JsonProperty("dpst_grnt_use_amt_amt")]
		public decimal DepositCollateralLoanAmount;
		[JsonProperty("grnt_loan_amt")]
		public decimal SellCollateralLoanAmount;
		[JsonProperty("stk_cntr_remn")]
		public IEnumerable<KiwoomAccountGetContractBalanceItem>? Items;
	}
	public record KiwoomAccountGetContractBalanceItem
	{
		[JsonProperty("crd_tp")]
		public string CreditType = string.Empty;
		[JsonProperty("loan_dt")]
		public string LoanDate = string.Empty;
		[JsonProperty("expr_dt")]
		public string ExpireDate = string.Empty;
		[JsonProperty("stk_cd")]
		public string StockCode = string.Empty;
		[JsonProperty("stk_nm")]
		public string StockName = string.Empty;
		[JsonProperty("setl_remn")]
		public decimal SettlementBalance;
		[JsonProperty("cur_qty")]
		public decimal CurrentQuantity;
		[JsonProperty("cur_prc")]
		public decimal CurrentPrice;
		[JsonProperty("buy_uv")]
		public decimal BuyUnitPrice;
		[JsonProperty("pur_amt")]
		public decimal PurchaseAmount;
		[JsonProperty("evlt_amt")]
		public decimal EvaluationAmount;
		[JsonProperty("evltv_prft")]
		public decimal EvaluationProfitLoss;
		[JsonProperty("pl_rt")]
		public decimal ProfitLossRate;
	}

	public record KiwoomAccountGetOrderContractDetails
	{
		[JsonProperty("acnt_ord_cntr_prps_dtl")]
		public IEnumerable<KiwoomAccountGetOrderContractDetailItem>? Items;
	}
	public record KiwoomAccountGetOrderContractDetailItem
	{
		[JsonProperty("ord_no")]
		public string OrderId = string.Empty;
		[JsonProperty("stk_cd")]
		public string StockCode = string.Empty;
		[JsonProperty("trde_tp")]
		public string TradeType = string.Empty;
		[JsonProperty("crd_tp")]
		public string CreditType = string.Empty;
		[JsonProperty("ord_qty")]
		public decimal OrderQuantity;
		[JsonProperty("ord_uv")]
		public decimal OrderUnitPrice;
		[JsonProperty("cnfm_qty")]
		public decimal ConfirmedQuantity;
		[JsonProperty("acpt_tp")]
		public string AcceptanceType = string.Empty;
		[JsonProperty("rsrv_tp")]
		public string ReservationType = string.Empty;
		[JsonProperty("ord_tm")]
		[JsonConverter(typeof(KiwoomTimeConverter))]
		public TimeSpan OrderTime;
		[JsonProperty("ori_ord")]
		public string OriginalOrder = string.Empty;
		[JsonProperty("stk_nm")]
		public string StockName = string.Empty;
		[JsonProperty("io_tp_nm")]
		public string OrderTypeName = string.Empty;
		[JsonProperty("loan_dt")]
		public string LoanDate = string.Empty;
		[JsonProperty("cntr_qty")]
		public decimal ContractQuantity;
		[JsonProperty("cntr_uv")]
		public decimal ContractUnitPrice;
		[JsonProperty("ord_remnq")]
		public decimal OrderRemainingQuantity;
		[JsonProperty("comm_ord_tp")]
		public string CommunicationOrderType = string.Empty;
		[JsonProperty("mdfy_cncl")]
		public string ModifyCancel = string.Empty;
		[JsonProperty("cnfm_tm")]
		[JsonConverter(typeof(KiwoomTimeConverter))]
		public TimeSpan ConfirmTime;
		[JsonProperty("dmst_stex_tp")]
		public string DomesticStockExchangeType = string.Empty;
		[JsonProperty("cond_uv")]
		public decimal ConditionUnitPrice;
	}

	public record KiwoomAccountGetNextDaySettlements
	{
		[JsonProperty("trde_dt")]
		[JsonConverter(typeof(KiwoomDateConverter))]
		public DateTime TradeDate;
		[JsonProperty("setl_dt")]
		[JsonConverter(typeof(KiwoomDateConverter))]
		public DateTime SettlementDate;
		[JsonProperty("sell_amt_sum")]
		public decimal SellSettlementSum;
		[JsonProperty("buy_amt_sum")]
		public decimal BuySettlementSum;
		[JsonProperty("acnt_nxdy_setl_frcs_array")]
		public IEnumerable<KiwoomAccountGetNextDaySettlementItem>? Items;
	}
	public record KiwoomAccountGetNextDaySettlementItem
	{
		[JsonProperty("seq")]
		public string SequenceId = string.Empty;
		[JsonProperty("stk_cd")]
		public string StockCode = string.Empty;
		[JsonProperty("loan_dt")]
		public string LoanDate = string.Empty;
		[JsonProperty("qty")]
		public decimal Quantity;
		[JsonProperty("engg_amt")]
		public decimal ContractAmount;
		[JsonProperty("cmsn")]
		public decimal Commission;
		[JsonProperty("incm_tax")]
		public decimal IncomeTax;
		[JsonProperty("rstx")]
		public decimal SpecialTax;
		[JsonProperty("stk_nm")]
		public string StockName = string.Empty;
		[JsonProperty("sell_tp")]
		public string SellType = string.Empty;
		[JsonProperty("unp")]
		public decimal UnitPrice;
		[JsonProperty("exct_amt")]
		public decimal SettlementAmount;
		[JsonProperty("trde_tax")]
		public decimal TradeTax;
		[JsonProperty("resi_tax")]
		public decimal ResidentTax;
		[JsonProperty("crd_tp")]
		public string CreditType = string.Empty;
	}

	public record KiwoomAccountGetOrderContracts
	{
		[JsonProperty("sell_grntl_engg_amt")]
		public decimal? SellContractAmount;
		[JsonProperty("buy_engg_amt")]
		public decimal? BuyContractAmount;
		[JsonProperty("engg_amt")]
		public decimal? ContractAmount;
		[JsonProperty("acnt_ord_cntr_prst_array")]
		public IEnumerable<KiwoomAccountGetOrderContractItem>? Items;
	}
	public record KiwoomAccountGetOrderContractItem
	{
		[JsonProperty("stk_bond_tp")]
		public string StockBondType = string.Empty;
		[JsonProperty("ord_no")]
		public string OrderId = string.Empty;
		[JsonProperty("stk_cd")]
		public string StockCode = string.Empty;
		[JsonProperty("trde_tp")]
		public string TradeType = string.Empty;
		[JsonProperty("io_tp_nm")]
		public string OrderTypeName = string.Empty;
		[JsonProperty("ord_qty")]
		public decimal OrderQuantity;
		[JsonProperty("ord_uv")]
		public decimal OrderUnitPrice;
		[JsonProperty("cnfm_qty")]
		public decimal ConfirmedQuantity;
		[JsonProperty("rsrv_oppo")]
		public string ReservationOpposite = string.Empty;
		[JsonProperty("cntr_no")]
		public string ContractId = string.Empty;
		[JsonProperty("acpt_tp")]
		public string AcceptanceType = string.Empty;
		[JsonProperty("orig_ord_no")]
		public string OriginalOrderId = string.Empty;
		[JsonProperty("stk_nm")]
		public string StockName = string.Empty;
		[JsonProperty("setl_tp")]
		public string SettlementType = string.Empty;
		[JsonProperty("crd_deal_tp")]
		public string CreditTransactionType = string.Empty;
		[JsonProperty("cntr_qty")]
		public decimal ContractQuantity;
		[JsonProperty("cntr_uv")]
		public decimal ContractUnitPrice;
		[JsonProperty("comm_ord_tp")]
		public string CommunicationOrderType = string.Empty;
		[JsonProperty("mdfy_cncl_tp")]
		public string ModifyCancelType = string.Empty;
		[JsonProperty("cntr_tm")]
		[JsonConverter(typeof(KiwoomTimeConverter))]
		public TimeSpan ContractTime;
		[JsonProperty("dmst_stex_tp")]
		public string DomesticStockExchangeType = string.Empty;
		[JsonProperty("cond_uv")]
		public decimal ConditionUnitPrice;
	}

	public record KiwoomAccountGetMarginOrderAmounts
	{
		[JsonProperty("profa_20ord_alow_amt")]
		public decimal MarginOrderAllowedAmount20Percent;
		[JsonProperty("profa_20ord_alowq")]
		public decimal MarginOrderAllowedQuantity20Percent;
		[JsonProperty("profa_30ord_alow_amt")]
		public decimal MarginOrderAllowedAmount30Percent;
		[JsonProperty("profa_30ord_alowq")]
		public decimal MarginOrderAllowedQuantity30Percent;
		[JsonProperty("profa_40ord_alow_amt")]
		public decimal MarginOrderAllowedAmount40Percent;
		[JsonProperty("profa_40ord_alowq")]
		public decimal MarginOrderAllowedQuantity40Percent;
		[JsonProperty("profa_50ord_alow_amt")]
		public decimal MarginOrderAllowedAmount50Percent;
		[JsonProperty("profa_50ord_alowq")]
		public decimal MarginOrderAllowedQuantity50Percent;
		[JsonProperty("profa_60ord_alow_amt")]
		public decimal MarginOrderAllowedAmount60Percent;
		[JsonProperty("profa_60ord_alowq")]
		public decimal MarginOrderAllowedQuantity60Percent;
		[JsonProperty("profa_rdex_60ord_alow_amt")]
		public decimal MarginReduced60OrderAllowedAmount;
		[JsonProperty("profa_rdex_60ord_alowq")]
		public decimal MarginReduced60OrderAllowedQuantity;
		[JsonProperty("profa_100ord_alow_amt")]
		public decimal MarginOrderAllowedAmount100Percent;
		[JsonProperty("profa_100ord_alowq")]
		public decimal MarginOrderAllowedQuantity100Percent;
		[JsonProperty("pred_reu_alowa")]
		public decimal PreviousDayReuseAllowedAmount;
		[JsonProperty("tdy_reu_alowa")]
		public decimal TodayReuseAllowedAmount;
		[JsonProperty("entr")]
		public decimal DepositAmount;
		[JsonProperty("repl_amt")]
		public decimal ReplenishmentAmount;
		[JsonProperty("uncla")]
		public decimal UnsettledAmount;
		[JsonProperty("ord_pos_repl")]
		public decimal OrderAllowedReplenishment;
		[JsonProperty("ord_alowa")]
		public decimal OrderAllowedCash;
		[JsonProperty("wthd_alowa")]
		public decimal WithdrawalAllowedAmount;
		[JsonProperty("nxdy_wthd_alowa")]
		public decimal NextDayWithdrawalAllowedAmount;
		[JsonProperty("pur_amt")]
		public decimal PurchaseAmount;
		[JsonProperty("cmsn")]
		public decimal Commission;
		[JsonProperty("pur_exct_amt")]
		public decimal PurchaseSettlementAmount;
		[JsonProperty("d2entra")]
		public decimal D2EstimatedDeposit;
		[JsonProperty("profa_rdex_aplc_tp")]
		public KiwoomAccountMarginReductionApplyType MarginReductionApplyType;
	}

	public record KiwoomAccountGetMarginOrders
	{
		[JsonProperty("stk_profa_rt")]
		[JsonConverter(typeof(KiwoomPercentConverter))]
		public decimal StockMarginRate;
		[JsonProperty("profa_rt")]
		[JsonConverter(typeof(KiwoomPercentConverter))]
		public decimal AccountMarginRate;
		[JsonProperty("aplc_rt")]
		[JsonConverter(typeof(KiwoomPercentConverter))]
		public decimal AppliedMarginRate;
		[JsonProperty("profa_20ord_alow_amt")]
		public decimal MarginOrderAllowedAmount20Percent;
		[JsonProperty("profa_20ord_alowq")]
		public decimal MarginOrderAllowedQuantity20Percent;
		[JsonProperty("profa_20pred_reu_amt")]
		public decimal MarginPreviousDayReuseAmount20Percent;
		[JsonProperty("profa_20tdy_reu_amt")]
		public decimal MarginTodayReuseAmount20Percent;
		[JsonProperty("profa_30ord_alow_amt")]
		public decimal MarginOrderAllowedAmount30Percent;
		[JsonProperty("profa_30ord_alowq")]
		public decimal MarginOrderAllowedQuantity30Percent;
		[JsonProperty("profa_30pred_reu_amt")]
		public decimal MarginPreviousDayReuseAmount30Percent;
		[JsonProperty("profa_30tdy_reu_amt")]
		public decimal MarginTodayReuseAmount30Percent;
		[JsonProperty("profa_40ord_alow_amt")]
		public decimal MarginOrderAllowedAmount40Percent;
		[JsonProperty("profa_40ord_alowq")]
		public decimal MarginOrderAllowedQuantity40Percent;
		[JsonProperty("profa_40pred_reu_amt")]
		public decimal MarginPreviousDayReuseAmount40Percent;
		[JsonProperty("profa_40tdy_reu_amt")]
		public decimal MarginTodayReuseAmount40Percent;
		[JsonProperty("profa_50ord_alow_amt")]
		public decimal MarginOrderAllowedAmount50Percent;
		[JsonProperty("profa_50ord_alowq")]
		public decimal MarginOrderAllowedQuantity50Percent;
		[JsonProperty("profa_50pred_reu_amt")]
		public decimal MarginPreviousDayReuseAmount50Percent;
		[JsonProperty("profa_50tdy_reu_amt")]
		public decimal MarginTodayReuseAmount50Percent;
		[JsonProperty("profa_60ord_alow_amt")]
		public decimal MarginOrderAllowedAmount60Percent;
		[JsonProperty("profa_60ord_alowq")]
		public decimal MarginOrderAllowedQuantity60Percent;
		[JsonProperty("profa_60pred_reu_amt")]
		public decimal MarginPreviousDayReuseAmount60Percent;
		[JsonProperty("profa_60tdy_reu_amt")]
		public decimal MarginTodayReuseAmount60Percent;
		[JsonProperty("profa_100ord_alow_amt")]
		public decimal MarginOrderAllowedAmount100Percent;
		[JsonProperty("profa_100ord_alowq")]
		public decimal MarginOrderAllowedQuantity100Percent;
		[JsonProperty("profa_100pred_reu_amt")]
		public decimal MarginPreviousDayReuseAmount100Percent;
		[JsonProperty("profa_100tdy_reu_amt")]
		public decimal MarginTodayReuseAmount100Percent;
		[JsonProperty("min_ord_alow_amt")]
		public decimal MinOrderAllowedAmount;
		[JsonProperty("min_ord_alowq")]
		public decimal MinOrderAllowedQuantity;
		[JsonProperty("min_pred_reu_amt")]
		public decimal MinPreviousDayReuseAmount;
		[JsonProperty("min_tdy_reu_amt")]
		public decimal MinTodayReuseAmount;
		[JsonProperty("entr")]
		public decimal DepositAmount;
		[JsonProperty("repl_amt")]
		public decimal ReplenishmentAmount;
		[JsonProperty("uncla")]
		public decimal UnsettledAmount;
		[JsonProperty("ord_pos_repl")]
		public decimal OrderAllowedReplenishment;
		[JsonProperty("ord_alowa")]
		public decimal OrderAllowedCash;
	}

	public record KiwoomAccountGetAssuranceMarginOrders
	{
		[JsonProperty("stk_assr_rt")]
		public decimal StockAssuranceRate;
		[JsonProperty("stk_assr_rt_nm")]
		public string StockAssuranceRateName = string.Empty;
		[JsonProperty("assr_30ord_alow_amt")]
		public decimal AssuranceOrderAllowedAmount30Percent;
		[JsonProperty("assr_30ord_alowq")]
		public decimal AssuranceOrderAllowedQuantity30Percent;
		[JsonProperty("assr_30pred_reu_amt")]
		public decimal AssurancePreviousDayReuseAmount30Percent;
		[JsonProperty("assr_30tdy_reu_amt")]
		public decimal AssuranceTodayReuseAmount30Percent;
		[JsonProperty("assr_40ord_alow_amt")]
		public decimal AssuranceOrderAllowedAmount40Percent;
		[JsonProperty("assr_40ord_alowq")]
		public decimal AssuranceOrderAllowedQuantity40Percent;
		[JsonProperty("assr_40pred_reu_amt")]
		public decimal AssurancePreviousDayReuseAmount40Percent;
		[JsonProperty("assr_40tdy_reu_amt")]
		public decimal AssuranceTodayReuseAmount40Percent;
		[JsonProperty("assr_50ord_alow_amt")]
		public decimal AssuranceOrderAllowedAmount50Percent;
		[JsonProperty("assr_50ord_alowq")]
		public decimal AssuranceOrderAllowedQuantity50Percent;
		[JsonProperty("assr_50pred_reu_amt")]
		public decimal AssurancePreviousDayReuseAmount50Percent;
		[JsonProperty("assr_50tdy_reu_amt")]
		public decimal AssuranceTodayReuseAmount50Percent;
		[JsonProperty("assr_60ord_alow_amt")]
		public decimal AssuranceOrderAllowedAmount60Percent;
		[JsonProperty("assr_60ord_alowq")]
		public decimal AssuranceOrderAllowedQuantity60Percent;
		[JsonProperty("assr_60pred_reu_amt")]
		public decimal AssurancePreviousDayReuseAmount60Percent;
		[JsonProperty("assr_60tdy_reu_amt")]
		public decimal AssuranceTodayReuseAmount60Percent;
		[JsonProperty("entr")]
		public decimal DepositAmount;
		[JsonProperty("repl_amt")]
		public decimal ReplenishmentAmount;
		[JsonProperty("uncla")]
		public decimal UnsettledAmount;
		[JsonProperty("ord_pos_repl")]
		public decimal OrderAllowedReplenishment;
		[JsonProperty("ord_alowa")]
		public decimal OrderAllowedCash;
		[JsonProperty("out_alowa")]
		public decimal UnsettledAllowedAmount;
		[JsonProperty("out_pos_qty")]
		public decimal UnsettledAllowedQuantity;
		[JsonProperty("min_amt")]
		public decimal MinimumAmountNotAllowedUnsettled;
		[JsonProperty("min_qty")]
		public decimal MinimumQuantityNotAllowedUnsettled;
	}

	public record KiwoomAccountGetMarginDetails
	{
		[JsonProperty("tdy_reu_objt_amt")]
		public decimal TodayReuseTargetAmount;
		[JsonProperty("tdy_reu_use_amt")]
		public decimal TodayReuseUsedAmount;
		[JsonProperty("tdy_reu_alowa")]
		public decimal TodayReuseAllowedAmount;
		[JsonProperty("tdy_reu_lmtt_amt")]
		public decimal TodayReuseLimitAmount;
		[JsonProperty("tdy_reu_alowa_fin")]
		public decimal TodayReuseAllowedFinalAmount;
		[JsonProperty("pred_reu_objt_amt")]
		public decimal PreviousDayReuseTargetAmount;
		[JsonProperty("pred_reu_use_amt")]
		public decimal PreviousDayReuseUsedAmount;
		[JsonProperty("pred_reu_alowa")]
		public decimal PreviousDayReuseAllowedAmount;
		[JsonProperty("pred_reu_lmtt_amt")]
		public decimal PreviousDayReuseLimitAmount;
		[JsonProperty("pred_reu_alowa_fin")]
		public decimal PreviousDayReuseAllowedFinalAmount;
		[JsonProperty("ch_amt")]
		public decimal CashAmount;
		[JsonProperty("ch_profa")]
		public decimal CashMargin;
		[JsonProperty("use_pos_ch")]
		public decimal CashUsableAmount;
		[JsonProperty("ch_use_lmtt_amt")]
		public decimal CashUseLimitAmount;
		[JsonProperty("use_pos_ch_fin")]
		public decimal CashUsableFinalAmount;
		[JsonProperty("repl_amt_amt")]
		public decimal ReplenishmentAmount;
		[JsonProperty("repl_profa")]
		public decimal ReplenishmentMargin;
		[JsonProperty("use_pos_repl")]
		public decimal ReplenishmentUsableAmount;
		[JsonProperty("repl_use_lmtt_amt")]
		public decimal ReplenishmentUseLimitAmount;
		[JsonProperty("use_pos_repl_fin")]
		public decimal ReplenishmentUsableFinalAmount;
		[JsonProperty("crd_grnta_ch")]
		public decimal CreditGuaranteeCash;
		[JsonProperty("crd_grnta_repl")]
		public decimal CreditGuaranteeReplenishment;
		[JsonProperty("crd_grnt_ch")]
		public decimal CreditCollateralCash;
		[JsonProperty("crd_grnt_repl")]
		public decimal CreditCollateralReplenishment;
		[JsonProperty("uncla")]
		public decimal UnsettledAmount;
		[JsonProperty("ls_grnt_reu_gold")]
		public decimal LoanCollateralReuseAmount;
		[JsonProperty("20ord_alow_amt")]
		public decimal OrderAllowedAmount20Percent;
		[JsonProperty("30ord_alow_amt")]
		public decimal OrderAllowedAmount30Percent;
		[JsonProperty("40ord_alow_amt")]
		public decimal OrderAllowedAmount40Percent;
		[JsonProperty("50ord_alow_amt")]
		public decimal OrderAllowedAmount50Percent;
		[JsonProperty("60ord_alow_amt")]
		public decimal OrderAllowedAmount60Percent;
		[JsonProperty("100ord_alow_amt")]
		public decimal OrderAllowedAmount100Percent;
		[JsonProperty("tdy_crd_rpya_loss_amt")]
		public decimal TodayCreditRepaymentLossAmount;
		[JsonProperty("pred_crd_rpya_loss_amt")]
		public decimal PreviousDayCreditRepaymentLossAmount;
		[JsonProperty("tdy_ls_rpya_loss_repl_profa")]
		public decimal TodayLoanRepaymentLossReplenishmentMargin;
		[JsonProperty("pred_ls_rpya_loss_repl_profa")]
		public decimal PreviousDayLoanRepaymentLossReplenishmentMargin;
		[JsonProperty("evlt_repl_amt_spg_use_skip")]
		public decimal EvaluationReplenishmentAmountExcludeSpotUse;
		[JsonProperty("evlt_repl_rt")]
		public decimal EvaluationReplenishmentRate;
		[JsonProperty("crd_repl_profa")]
		public decimal CreditReplenishmentMargin;
		[JsonProperty("ch_ord_repl_profa")]
		public decimal CashOrderReplenishmentMargin;
		[JsonProperty("crd_ord_repl_profa")]
		public decimal CreditOrderReplenishmentMargin;
		[JsonProperty("crd_repl_conv_gold")]
		public decimal CreditReplenishmentConvertedAmount;
		[JsonProperty("repl_alowa")]
		public decimal ReplenishmentAllowedAmountCashLimit;
		[JsonProperty("repl_alowa_2")]
		public decimal ReplenishmentAllowedAmountCreditLimit;
		[JsonProperty("ch_repl_lck_gold")]
		public decimal CashReplenishmentShortageAmount;
		[JsonProperty("crd_repl_lck_gold")]
		public decimal CreditReplenishmentShortageAmount;
		[JsonProperty("ch_ord_alow_repla")]
		public decimal CashOrderAllowedReplenishmentAmount;
		[JsonProperty("crd_ord_alow_repla")]
		public decimal CreditOrderAllowedReplenishmentAmount;
		[JsonProperty("d2vexct_entr")]
		public decimal D2EstimatedSettlementDeposit;
		[JsonProperty("d2ch_ord_alow_amt")]
		public decimal D2CashOrderAllowedAmount;
	}

	public record KiwoomAccountGetConsignmentTrades
	{
		[JsonProperty("trst_ovrl_trde_prps_array")]
		public IEnumerable<KiwoomAccountGetConsignmentTradeItem>? Items;
	}

	public record KiwoomAccountGetConsignmentTradeItem
	{
		[JsonProperty("trde_dt")]
		[JsonConverter(typeof(KiwoomDateConverter))]
		public DateTime TradeDate;
		[JsonProperty("trde_no")]
		public string TradeId = string.Empty;
		[JsonProperty("rmrk_nm")]
		public string RemarkName = string.Empty;
		[JsonProperty("crd_deal_tp_nm")]
		public string CreditDealTypeName = string.Empty;
		[JsonProperty("exct_amt")]
		public decimal SettlementAmount;
		[JsonProperty("loan_amt_rpya")]
		public decimal LoanRepaymentAmount;
		[JsonProperty("fc_trde_amt")]
		public decimal ForeignTradeAmount;
		[JsonProperty("fc_exct_amt")]
		public decimal ForeignSettlementAmount;
		[JsonProperty("entra_remn")]
		public decimal DepositBalance;
		[JsonProperty("crnc_cd")]
		public string CurrencyCode = string.Empty;
		[JsonProperty("trde_ocr_tp")]
		public KiwoomAccountTradeCategoryType TradeCategory;
		[JsonProperty("trde_kind_nm")]
		public string TradeCategoryName = string.Empty;
		[JsonProperty("stk_nm")]
		public string StockName = string.Empty;
		[JsonProperty("trde_amt")]
		public decimal TradeAmount;
		[JsonProperty("trde_agri_tax")]
		public decimal TradeAndSpecialTax;
		[JsonProperty("rpy_diffa")]
		public decimal RepaymentDifference;
		[JsonProperty("fc_trde_tax")]
		public decimal ForeignTradeTax;
		[JsonProperty("dly_sum")]
		public decimal OverdueSum;
		[JsonProperty("fc_entra")]
		public decimal ForeignDepositBalance;
		[JsonProperty("mdia_tp_nm")]
		public string MediaTypeName = string.Empty;
		[JsonProperty("io_tp")]
		public string InOutTypeCode = string.Empty;
		[JsonProperty("io_tp_nm")]
		public string InOutTypeName = string.Empty;
		[JsonProperty("orig_deal_no")]
		public string OriginalTradeId = string.Empty;
		[JsonProperty("stk_cd")]
		public string StockCode = string.Empty;
		[JsonProperty("trde_qty_jwa_cnt")]
		public decimal TradeQuantityOrShareCount;
		[JsonProperty("cmsn")]
		public decimal Commission;
		[JsonProperty("int_ls_usfe")]
		public decimal InterestOrLoanUsageFee;
		[JsonProperty("fc_cmsn")]
		public decimal ForeignCommission;
		[JsonProperty("fc_dly_sum")]
		public decimal ForeignOverdueSum;
		[JsonProperty("vlbl_nowrm")]
		public decimal MarketSecuritiesBalance;
		[JsonProperty("proc_tm")]
		[JsonConverter(typeof(KiwoomTimeConverter))]
		public TimeSpan ProcessingTime;
		[JsonProperty("isin_cd")]
		public string ISINCode = string.Empty;
		[JsonProperty("stex_cd")]
		public string StockExchangeCode = string.Empty;
		[JsonProperty("stex_nm")]
		public string StockExchangeName = string.Empty;
		[JsonProperty("trde_unit")]
		public decimal TradeUnitOrExchangeRate;
		[JsonProperty("incm_resi_tax")]
		public decimal IncomeResidentTax;
		[JsonProperty("loan_dt")]
		public string LoanDate = string.Empty;
		[JsonProperty("uncl_ocr")]
		public decimal UnsettledAmountOriginal;
		[JsonProperty("rpym_sum")]
		public decimal RepaymentSum;
		[JsonProperty("cntr_dt")]
		[JsonConverter(typeof(KiwoomDateConverter))]
		public DateTime ContractDate;
		[JsonProperty("rcpy_no")]
		public string ReceiptId = string.Empty;
		[JsonProperty("prcsr")]
		public string Processor = string.Empty;
		[JsonProperty("proc_brch")]
		public string ProcessingBranch = string.Empty;
		[JsonProperty("trde_stle")]
		public string TradeTypeDetail = string.Empty;
		[JsonProperty("txon_base_pric")]
		public decimal TaxBasePrice;
		[JsonProperty("tax_sum_cmsn")]
		public decimal TaxCommissionSum;
		[JsonProperty("frgn_pay_txam")]
		public decimal ForeignPaymentTaxAmount;
		[JsonProperty("fc_uncl_ocr")]
		public decimal ForeignUnsettledAmount;
		[JsonProperty("rpym_sum_fr")]
		public decimal RepaymentSumForeign;
		[JsonProperty("rcpmnyer")]
		public string Depositor = string.Empty;
		[JsonProperty("trde_prtc_tp")]
		public string TradeDetailType = string.Empty;
	}

	public record KiwoomAccountGetDailyProfitRateDetails
	{
		[JsonProperty("mang_empno")]
		public string ManagerEmployeeId = string.Empty;
		[JsonProperty("mngr_nm")]
		public string ManagerName = string.Empty;
		[JsonProperty("dept_nm")]
		public string ManagerBranch = string.Empty;
		[JsonProperty("entr_fr")]
		public decimal DepositAmountStart;
		[JsonProperty("entr_to")]
		public decimal DepositAmountEnd;
		[JsonProperty("scrt_evlt_amt_fr")]
		public decimal SecuritiesEvaluationAmountStart;
		[JsonProperty("scrt_evlt_amt_to")]
		public decimal SecuritiesEvaluationAmountEnd;
		[JsonProperty("ls_grnt_fr")]
		public decimal LoanCollateralStart;
		[JsonProperty("ls_grnt_to")]
		public decimal LoanCollateralEnd;
		[JsonProperty("crd_loan_fr")]
		public decimal CreditLoanAmountStart;
		[JsonProperty("crd_loan_to")]
		public decimal CreditLoanAmountEnd;
		[JsonProperty("ch_uncla_fr")]
		public decimal CashUnsettledAmountStart;
		[JsonProperty("ch_uncla_to")]
		public decimal CashUnsettledAmountEnd;
		[JsonProperty("krw_asgna_fr")]
		public decimal KRWSubstituteAmountStart;
		[JsonProperty("krw_asgna_to")]
		public decimal KRWSubstituteAmountEnd;
		[JsonProperty("ls_evlta_fr")]
		public decimal LoanEvaluationAmountStart;
		[JsonProperty("ls_evlta_to")]
		public decimal LoanEvaluationAmountEnd;
		[JsonProperty("rght_evlta_fr")]
		public decimal RightEvaluationAmountStart;
		[JsonProperty("rght_evlta_to")]
		public decimal RightEvaluationAmountEnd;
		[JsonProperty("loan_amt_fr")]
		public decimal LoanAmountStart;
		[JsonProperty("loan_amt_to")]
		public decimal LoanAmountEnd;
		[JsonProperty("etc_loana_fr")]
		public decimal OtherLoanAmountStart;
		[JsonProperty("etc_loana_to")]
		public decimal OtherLoanAmountEnd;
		[JsonProperty("crd_int_npay_gold_fr")]
		public decimal CreditInterestUnpaidAmountStart;
		[JsonProperty("crd_int_npay_gold_to")]
		public decimal CreditInterestUnpaidAmountEnd;
		[JsonProperty("crd_int_fr")]
		public decimal CreditInterestStart;
		[JsonProperty("crd_int_to")]
		public decimal CreditInterestEnd;
		[JsonProperty("tot_amt_fr")]
		public decimal TotalNetAssetAmountStart;
		[JsonProperty("tot_amt_to")]
		public decimal TotalNetAssetAmountEnd;
		[JsonProperty("invt_bsamt")]
		public decimal AverageInvestmentPrincipalAmount;
		[JsonProperty("evltv_prft")]
		public decimal EvaluationProfitLoss;
		[JsonProperty("prft_rt")]
		public decimal ProfitRate;
		[JsonProperty("tern_rt")]
		public decimal TurnoverRate;
		[JsonProperty("termin_tot_trns")]
		public decimal TotalDepositDuringPeriod;
		[JsonProperty("termin_tot_pymn")]
		public decimal TotalWithdrawalDuringPeriod;
		[JsonProperty("termin_tot_inq")]
		public decimal TotalInwardQuantityDuringPeriod;
		[JsonProperty("termin_tot_outq")]
		public decimal TotalOutwardQuantityDuringPeriod;
		[JsonProperty("futr_repl_sella")]
		public decimal FuturesSubstituteSellAmount;
		[JsonProperty("trst_repl_sella")]
		public decimal ConsignmentSubstituteSellAmount;
	}

	public record KiwoomAccountGetDailyStatus
	{
		[JsonProperty("d2_entra")]
		public decimal D2EstimatedDeposit;
		[JsonProperty("crd_int_npay_gold")]
		public decimal CreditInterestUnpaidAmount;
		[JsonProperty("etc_loana")]
		public decimal OtherLoans;
		[JsonProperty("gnrl_stk_evlt_amt_d2")]
		public decimal GeneralStockEvaluationAmountD2;
		[JsonProperty("dpst_grnt_use_amt_d2")]
		public decimal DepositCollateralLoanAmountD2;
		[JsonProperty("crd_stk_evlt_amt_d2")]
		public decimal CreditCollateralStockEvaluationAmountD2;
		[JsonProperty("crd_loan_d2")]
		public decimal CreditLoanD2;
		[JsonProperty("crd_loan_evlta_d2")]
		public decimal CreditLoanEvaluationD2;
		[JsonProperty("crd_ls_grnt_d2")]
		public decimal CreditLoanCollateralD2;
		[JsonProperty("crd_ls_evlta_d2")]
		public decimal CreditLoanEvaluationAmountD2;
		[JsonProperty("ina_amt")]
		public decimal DepositAmount;
		[JsonProperty("outa")]
		public decimal WithdrawalAmount;
		[JsonProperty("inq_amt")]
		public decimal IncomingAmount;
		[JsonProperty("outq_amt")]
		public decimal OutgoingAmount;
		[JsonProperty("sell_amt")]
		public decimal SellAmount;
		[JsonProperty("buy_amt")]
		public decimal BuyAmount;
		[JsonProperty("cmsn")]
		public decimal Commission;
		[JsonProperty("tax")]
		public decimal TaxAmount;
		[JsonProperty("stk_pur_cptal_loan_amt")]
		public decimal StockPurchaseCapitalLoanAmount;
		[JsonProperty("rp_evlt_amt")]
		public decimal RPAssessmentAmount;
		[JsonProperty("bd_evlt_amt")]
		public decimal BondAssessmentAmount;
		[JsonProperty("elsevlt_amt")]
		public decimal ELSAssessmentAmount;
		[JsonProperty("crd_int_amt")]
		public decimal CreditInterestAmount;
		[JsonProperty("sel_prica_grnt_loan_int_amt_amt")]
		public decimal SellProceedsCollateralLoanInterestAmount;
		[JsonProperty("dvida_amt")]
		public decimal DividendAmount;
	}

	public record KiwoomAccountGetEvaluationBalances
	{
		[JsonProperty("tot_pur_amt")]
		public decimal TotalPurchaseAmount;
		[JsonProperty("tot_evlt_amt")]
		public decimal TotalEvaluationAmount;
		[JsonProperty("tot_evlt_pl")]
		public decimal TotalEvaluationProfitLossAmount;
		[JsonProperty("tot_prft_rt")]
		public decimal TotalProfitRate;
		[JsonProperty("prsm_dpst_aset_amt")]
		public decimal EstimatedDepositAssetAmount;
		[JsonProperty("tot_loan_amt")]
		public decimal TotalLoanAmount;
		[JsonProperty("tot_crd_loan_amt")]
		public decimal TotalCreditLoanAmount;
		[JsonProperty("tot_crd_ls_amt")]
		public decimal TotalLoanCollateralAmount;
		[JsonProperty("acnt_evlt_remn_indv_tot")]
		public IEnumerable<KiwoomAccountGetEvaluationBalanceItem>? Items;
	}
	public record KiwoomAccountGetEvaluationBalanceItem
	{
		[JsonProperty("stk_cd")]
		public string StockCode = string.Empty;
		[JsonProperty("stk_nm")]
		public string StockName = string.Empty;
		[JsonProperty("evltv_prft")]
		public decimal EvaluationProfitLoss;
		[JsonProperty("prft_rt")]
		public decimal ProfitRate;
		[JsonProperty("pur_pric")]
		public decimal PurchasePrice;
		[JsonProperty("pred_close_pric")]
		public decimal PreviousClosePrice;
		[JsonProperty("rmnd_qty")]
		public decimal RemainingQuantity;
		[JsonProperty("trde_able_qty")]
		public decimal TradableQuantity;
		[JsonProperty("cur_prc")]
		public decimal CurrentPrice;
		[JsonProperty("pred_buyq")]
		public decimal PreviousDayBuyQuantity;
		[JsonProperty("pred_sellq")]
		public decimal PreviousDaySellQuantity;
		[JsonProperty("tdy_buyq")]
		public decimal TodayBuyQuantity;
		[JsonProperty("tdy_sellq")]
		public decimal TodaySellQuantity;
		[JsonProperty("pur_amt")]
		public decimal PurchaseAmount;
		[JsonProperty("pur_cmsn")]
		public decimal PurchaseCommission;
		[JsonProperty("evlt_amt")]
		public decimal EvaluationAmount;
		[JsonProperty("sell_cmsn")]
		public decimal EvaluationCommission;
		[JsonProperty("tax")]
		public decimal TaxAmount;
		[JsonProperty("sum_cmsn")]
		public decimal TotalCommission;
		[JsonProperty("poss_rt")]
		public decimal HoldingRatio;
		[JsonProperty("crd_tp")]
		public string CreditType = string.Empty;
		[JsonProperty("crd_tp_nm")]
		public string CreditTypeName = string.Empty;
		[JsonProperty("crd_loan_dt")]
		public string CreditLoanDate = string.Empty;
	}

}
