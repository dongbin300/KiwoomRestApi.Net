using Newtonsoft.Json;

namespace KiwoomRestApi.Net.Objects.Models.UsStock
{
	public record KiwoomUsStockExchangeGetExpectedAmount
	{
		/// <summary>
		/// 매도적용환율
		/// </summary>
		[JsonProperty("sell_aplc_exrt")]
		public decimal? SellAppliedExchangeRate;
		/// <summary>
		/// 매수적용환율
		/// </summary>
		[JsonProperty("buy_aplc_exrt")]
		public decimal? BuyAppliedExchangeRate;
		/// <summary>
		/// 적용환율
		/// </summary>
		[JsonProperty("aplc_exrt")]
		public decimal? AppliedExchangeRate;
		/// <summary>
		/// 매도통화예수금전잔
		/// </summary>
		[JsonProperty("sell_crnc_entra_prerm")]
		public decimal? SellCurrencyDepositPreviousBalance;
		/// <summary>
		/// 매도통화현금미수금전잔
		/// </summary>
		[JsonProperty("sell_crnc_ch_uncla_prerm")]
		public decimal? SellCurrencyCashUnclearedPreviousBalance;
		/// <summary>
		/// 매도통화기타대여금전잔
		/// </summary>
		[JsonProperty("sell_crnc_etc_loana_prerm")]
		public decimal? SellCurrencyOtherLoanPreviousBalance;
		/// <summary>
		/// 매도통화예수금금잔
		/// </summary>
		[JsonProperty("sell_crnc_entra_nowrm")]
		public decimal? SellCurrencyDepositCurrentBalance;
		/// <summary>
		/// 매도통화현금미수금금잔
		/// </summary>
		[JsonProperty("sell_crnc_ch_uncla_nowrm")]
		public decimal? SellCurrencyCashUnclearedCurrentBalance;
		/// <summary>
		/// 매도통화기타대여금금잔
		/// </summary>
		[JsonProperty("sell_crnc_etc_loana_nowrm")]
		public decimal? SellCurrencyOtherLoanCurrentBalance;
		/// <summary>
		/// 매도통화환전가능금액
		/// </summary>
		[JsonProperty("sell_crnc_exmn_alow_amt")]
		public decimal? SellCurrencyExchangeAvailableAmount;
		/// <summary>
		/// 매수통화예수금전잔
		/// </summary>
		[JsonProperty("buy_crnc_entra_prerm")]
		public decimal? BuyCurrencyDepositPreviousBalance;
		/// <summary>
		/// 매수통화현금미수금전잔
		/// </summary>
		[JsonProperty("buy_crnc_ch_uncla_prerm")]
		public decimal? BuyCurrencyCashUnclearedPreviousBalance;
		/// <summary>
		/// 매수통화기타대여금전잔
		/// </summary>
		[JsonProperty("buy_crnc_etc_loana_prerm")]
		public decimal? BuyCurrencyOtherLoanPreviousBalance;
		/// <summary>
		/// 매수통화예수금금잔
		/// </summary>
		[JsonProperty("buy_crnc_entra_nowrm")]
		public decimal? BuyCurrencyDepositCurrentBalance;
		/// <summary>
		/// 매수통화현금미수금금잔
		/// </summary>
		[JsonProperty("buy_crnc_ch_uncla_nowrm")]
		public decimal? BuyCurrencyCashUnclearedCurrentBalance;
		/// <summary>
		/// 매수통화기타대여금금잔
		/// </summary>
		[JsonProperty("buy_crnc_etc_loana_nowrm")]
		public decimal? BuyCurrencyOtherLoanCurrentBalance;
		/// <summary>
		/// 매수통화환전가능금액
		/// </summary>
		[JsonProperty("buy_crnc_exmn_alow_amt")]
		public decimal? BuyCurrencyExchangeAvailableAmount;
		/// <summary>
		/// 원화미수금액
		/// </summary>
		[JsonProperty("krw_uncl_amt")]
		public decimal? KrwUnclearedAmount;
		/// <summary>
		/// 매도예상금액
		/// </summary>
		[JsonProperty("sell_expc_amt")]
		public decimal? SellExpectedAmount;
		/// <summary>
		/// 매수예상금액
		/// </summary>
		[JsonProperty("buy_expc_amt")]
		public decimal? BuyExpectedAmount;
	}

	public record KiwoomUsStockExchangeGetExchangeRate
	{
		/// <summary>
		/// 매도적용환율
		/// </summary>
		[JsonProperty("sell_aplc_exrt")]
		public decimal? SellAppliedExchangeRate;
		/// <summary>
		/// 매수적용환율
		/// </summary>
		[JsonProperty("buy_aplc_exrt")]
		public decimal? BuyAppliedExchangeRate;
		/// <summary>
		/// 적용환율
		/// </summary>
		[JsonProperty("aplc_exrt")]
		public decimal? AppliedExchangeRate;
		/// <summary>
		/// 환율구분명
		/// </summary>
		[JsonProperty("exrt_tp_nm")]
		public string? ExchangeRateTypeName;
		/// <summary>
		/// 우대율 적용 전 환율
		/// </summary>
		[JsonProperty("spcl_bf_exrt")]
		public decimal? ExchangeRateBeforeDiscount;
		/// <summary>
		/// 환율우대율
		/// </summary>
		[JsonProperty("exrt_spcl_rt")]
		public decimal? ExchangeRateDiscountRate;
	}

	public record KiwoomUsStockExchangeApply
	{
		/// <summary>
		/// 매도적용환율
		/// </summary>
		[JsonProperty("sell_aplc_exrt")]
		public decimal? SellAppliedExchangeRate;
		/// <summary>
		/// 매수적용환율
		/// </summary>
		[JsonProperty("buy_aplc_exrt")]
		public decimal? BuyAppliedExchangeRate;
		/// <summary>
		/// 적용환율
		/// </summary>
		[JsonProperty("aplc_exrt")]
		public decimal? AppliedExchangeRate;
		/// <summary>
		/// 예수금전잔
		/// </summary>
		[JsonProperty("entra_prerm")]
		public decimal? DepositPreviousBalance;
		/// <summary>
		/// 현금미수금전잔
		/// </summary>
		[JsonProperty("ch_uncla_prerm")]
		public decimal? CashUnclearedPreviousBalance;
		/// <summary>
		/// 기타대여금전잔
		/// </summary>
		[JsonProperty("etc_loana_prerm")]
		public decimal? OtherLoanPreviousBalance;
		/// <summary>
		/// 예수금금잔
		/// </summary>
		[JsonProperty("entra_nowrm")]
		public decimal? DepositCurrentBalance;
		/// <summary>
		/// 현금미수금금잔
		/// </summary>
		[JsonProperty("ch_uncla_nowrm")]
		public decimal? CashUnclearedCurrentBalance;
		/// <summary>
		/// 기타대여금금잔
		/// </summary>
		[JsonProperty("etc_loana_nowrm")]
		public decimal? OtherLoanCurrentBalance;
		/// <summary>
		/// 원화환전가능금액
		/// </summary>
		[JsonProperty("krw_exmn_alow_amt")]
		public decimal? KrwExchangeAvailableAmount;
		/// <summary>
		/// 현금미수변제금
		/// </summary>
		[JsonProperty("ch_uncl_rpym_amt")]
		public decimal? CashUnclearedRepaymentAmount;
		/// <summary>
		/// 현금미수연체료
		/// </summary>
		[JsonProperty("ch_uncl_dlfe")]
		public decimal? CashUnclearedOverdueFee;
		/// <summary>
		/// 기타대여미납변제금
		/// </summary>
		[JsonProperty("etc_loan_npay_rpym_amt")]
		public decimal? OtherLoanUnpaidRepaymentAmount;
		/// <summary>
		/// 기타대여미납연체료
		/// </summary>
		[JsonProperty("etc_loan_npay_dlfe")]
		public decimal? OtherLoanUnpaidOverdueFee;
		/// <summary>
		/// 외화예수금전잔
		/// </summary>
		[JsonProperty("fc_entra_prerm")]
		public decimal? ForeignCurrencyDepositPreviousBalance;
		/// <summary>
		/// 외화현금미수금전잔
		/// </summary>
		[JsonProperty("fc_ch_uncla_prerm")]
		public decimal? ForeignCurrencyCashUnclearedPreviousBalance;
		/// <summary>
		/// 외화기타대여금전잔
		/// </summary>
		[JsonProperty("fc_etc_loana_prerm")]
		public decimal? ForeignCurrencyOtherLoanPreviousBalance;
		/// <summary>
		/// 외화예수금금잔
		/// </summary>
		[JsonProperty("fc_entra_nowrm")]
		public decimal? ForeignCurrencyDepositCurrentBalance;
		/// <summary>
		/// 외화현금미수금금잔
		/// </summary>
		[JsonProperty("fc_ch_uncla_nowrm")]
		public decimal? ForeignCurrencyCashUnclearedCurrentBalance;
		/// <summary>
		/// 외화기타대여금금잔
		/// </summary>
		[JsonProperty("fc_etc_loana_nowrm")]
		public decimal? ForeignCurrencyOtherLoanCurrentBalance;
		/// <summary>
		/// 외화환전가능금액
		/// </summary>
		[JsonProperty("fc_exmn_alow_amt")]
		public decimal? ForeignCurrencyExchangeAvailableAmount;
		/// <summary>
		/// 외화현금미수변제금
		/// </summary>
		[JsonProperty("fc_ch_uncl_rpym_amt")]
		public decimal? ForeignCurrencyCashUnclearedRepaymentAmount;
		/// <summary>
		/// 외화현금미수연체료
		/// </summary>
		[JsonProperty("fc_ch_uncl_dlfe")]
		public decimal? ForeignCurrencyCashUnclearedOverdueFee;
		/// <summary>
		/// 외화기타대여미납변제금
		/// </summary>
		[JsonProperty("fc_etc_loan_npay_rpym_amt")]
		public decimal? ForeignCurrencyOtherLoanUnpaidRepaymentAmount;
		/// <summary>
		/// 외화기타대여미납연체료
		/// </summary>
		[JsonProperty("fc_etc_loan_npay_dlfe")]
		public decimal? ForeignCurrencyOtherLoanUnpaidOverdueFee;
		/// <summary>
		/// 원화환전금액
		/// </summary>
		[JsonProperty("krw_exmn_amt")]
		public decimal? KrwExchangeAmount;
		/// <summary>
		/// 매도외화금액
		/// </summary>
		[JsonProperty("sell_fc_amt")]
		public decimal? SellForeignCurrencyAmount;
		/// <summary>
		/// 매수외화금액
		/// </summary>
		[JsonProperty("buy_fc_amt")]
		public decimal? BuyForeignCurrencyAmount;
	}
}
