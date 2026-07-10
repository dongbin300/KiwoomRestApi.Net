using KiwoomRestApi.Net.Converters;
using KiwoomRestApi.Net.Objects.Commons;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models.UsStock
{
	/// <summary>
	/// | usa21670 | 미국주식 일별계좌수익률현황
	/// </summary>
	public record KiwoomUsStockAccountGetDailyAccountProfitRates
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockAccountDailyAccountProfitRateItem>? Items;
	}

	public record KiwoomUsStockAccountDailyAccountProfitRateItem
	{
		/// <summary>
		/// 기준일자
		/// </summary>
		[JsonProperty("base_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? BaseDate;
		/// <summary>
		/// 주식평가금액
		/// </summary>
		[JsonProperty("stk_evlta")]
		public decimal? StockEvaluationAmount;
		/// <summary>
		/// 손익금액
		/// </summary>
		[JsonProperty("pl_amt")]
		public decimal? ProfitLossAmount;
		/// <summary>
		/// 배당금액
		/// </summary>
		[JsonProperty("dvid_amt")]
		public decimal? DividendAmount;
		/// <summary>
		/// 수수료및세금
		/// </summary>
		[JsonProperty("cmsn_tax")]
		public decimal? CommissionTax;
		/// <summary>
		/// 누적손익금액
		/// </summary>
		[JsonProperty("acum_pl_amt")]
		public decimal? AccumulatedProfitLossAmount;
		/// <summary>
		/// 지급금액
		/// </summary>
		[JsonProperty("pymn_amt")]
		public decimal? PaymentAmount;
		/// <summary>
		/// 예수금
		/// </summary>
		[JsonProperty("dast")]
		public decimal? Deposit;
		/// <summary>
		/// 입출금액
		/// </summary>
		[JsonProperty("dly_amt")]
		public decimal? DepositWithdrawalAmount;
		/// <summary>
		/// 매도금액
		/// </summary>
		[JsonProperty("sell_amt")]
		public decimal? SellAmount;
		/// <summary>
		/// 매수금액
		/// </summary>
		[JsonProperty("buy_amt")]
		public decimal? BuyAmount;
		/// <summary>
		/// 수익률
		/// </summary>
		[JsonProperty("prft_rt")]
		public KiwoomDecimal? ProfitRate;
		/// <summary>
		/// 외화증권출고금액
		/// </summary>
		[JsonProperty("frgn_stk_outq_amt")]
		public decimal? ForeignStockOutgoingAmount;
		/// <summary>
		/// 외화증권입고금액
		/// </summary>
		[JsonProperty("frgn_stk_inq_amt")]
		public decimal? ForeignStockIncomingAmount;
		/// <summary>
		/// 대체입금액
		/// </summary>
		[JsonProperty("ina_amt")]
		public decimal? TransferAmount;
		/// <summary>
		/// 환율
		/// </summary>
		[JsonProperty("exrt")]
		public KiwoomDecimal? ExchangeRate;
	}

	/// <summary>
	/// | usa21680 | 미국주식 월별계좌수익률현황
	/// </summary>
	public record KiwoomUsStockAccountGetMonthlyAccountProfitRates
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockAccountMonthlyAccountProfitRateItem>? Items;
	}

	public record KiwoomUsStockAccountMonthlyAccountProfitRateItem
	{
		/// <summary>
		/// 기준년월
		/// </summary>
		[JsonProperty("base_dt")]
		public string? BaseYearMonth;
		/// <summary>
		/// 주식평가금액
		/// </summary>
		[JsonProperty("stk_evlta")]
		public decimal? StockEvaluationAmount;
		/// <summary>
		/// 손익금액
		/// </summary>
		[JsonProperty("pl_amt")]
		public decimal? ProfitLossAmount;
		/// <summary>
		/// 배당금액
		/// </summary>
		[JsonProperty("dvid_amt")]
		public decimal? DividendAmount;
		/// <summary>
		/// 수수료및세금
		/// </summary>
		[JsonProperty("cmsn_tax")]
		public decimal? CommissionTax;
		/// <summary>
		/// 누적손익금액
		/// </summary>
		[JsonProperty("acum_pl_amt")]
		public decimal? AccumulatedProfitLossAmount;
		/// <summary>
		/// 지급금액
		/// </summary>
		[JsonProperty("pymn_amt")]
		public decimal? PaymentAmount;
		/// <summary>
		/// 예수금
		/// </summary>
		[JsonProperty("dast")]
		public decimal? Deposit;
		/// <summary>
		/// 입출금액
		/// </summary>
		[JsonProperty("dly_amt")]
		public decimal? DepositWithdrawalAmount;
		/// <summary>
		/// 매도금액
		/// </summary>
		[JsonProperty("sell_amt")]
		public decimal? SellAmount;
		/// <summary>
		/// 매수금액
		/// </summary>
		[JsonProperty("buy_amt")]
		public decimal? BuyAmount;
		/// <summary>
		/// 수익률
		/// </summary>
		[JsonProperty("prft_rt")]
		public KiwoomDecimal? ProfitRate;
		/// <summary>
		/// 외화증권출고금액
		/// </summary>
		[JsonProperty("frgn_stk_outq_amt")]
		public decimal? ForeignStockOutgoingAmount;
		/// <summary>
		/// 외화증권입고금액
		/// </summary>
		[JsonProperty("frgn_stk_inq_amt")]
		public decimal? ForeignStockIncomingAmount;
		/// <summary>
		/// 대체입금액
		/// </summary>
		[JsonProperty("ina_amt")]
		public decimal? TransferAmount;
		/// <summary>
		/// 환율
		/// </summary>
		[JsonProperty("exrt")]
		public KiwoomDecimal? ExchangeRate;
	}

	/// <summary>
	/// | usa21690 | 미국주식 연도별계좌수익률현황
	/// </summary>
	public record KiwoomUsStockAccountGetYearlyAccountProfitRates
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockAccountYearlyAccountProfitRateItem>? Items;
	}

	public record KiwoomUsStockAccountYearlyAccountProfitRateItem
	{
		/// <summary>
		/// 기준년도
		/// </summary>
		[JsonProperty("base_dt")]
		public string? BaseYear;
		/// <summary>
		/// 주식평가금액
		/// </summary>
		[JsonProperty("stk_evlta")]
		public decimal? StockEvaluationAmount;
		/// <summary>
		/// 손익금액
		/// </summary>
		[JsonProperty("pl_amt")]
		public decimal? ProfitLossAmount;
		/// <summary>
		/// 배당금액
		/// </summary>
		[JsonProperty("dvid_amt")]
		public decimal? DividendAmount;
		/// <summary>
		/// 수수료및세금
		/// </summary>
		[JsonProperty("cmsn_tax")]
		public decimal? CommissionTax;
		/// <summary>
		/// 누적손익금액
		/// </summary>
		[JsonProperty("acum_pl_amt")]
		public decimal? AccumulatedProfitLossAmount;
		/// <summary>
		/// 지급금액
		/// </summary>
		[JsonProperty("pymn_amt")]
		public decimal? PaymentAmount;
		/// <summary>
		/// 예수금
		/// </summary>
		[JsonProperty("dast")]
		public decimal? Deposit;
		/// <summary>
		/// 입출금액
		/// </summary>
		[JsonProperty("dly_amt")]
		public decimal? DepositWithdrawalAmount;
		/// <summary>
		/// 매도금액
		/// </summary>
		[JsonProperty("sell_amt")]
		public decimal? SellAmount;
		/// <summary>
		/// 매수금액
		/// </summary>
		[JsonProperty("buy_amt")]
		public decimal? BuyAmount;
		/// <summary>
		/// 수익률
		/// </summary>
		[JsonProperty("prft_rt")]
		public KiwoomDecimal? ProfitRate;
		/// <summary>
		/// 외화증권출고금액
		/// </summary>
		[JsonProperty("frgn_stk_outq_amt")]
		public decimal? ForeignStockOutgoingAmount;
		/// <summary>
		/// 외화증권입고금액
		/// </summary>
		[JsonProperty("frgn_stk_inq_amt")]
		public decimal? ForeignStockIncomingAmount;
		/// <summary>
		/// 대체입금액
		/// </summary>
		[JsonProperty("ina_amt")]
		public decimal? TransferAmount;
		/// <summary>
		/// 환율
		/// </summary>
		[JsonProperty("exrt")]
		public KiwoomDecimal? ExchangeRate;
	}

	/// <summary>
	/// | usa21730 | 미국주식 일별종목수익률현황
	/// </summary>
	public record KiwoomUsStockAccountGetDailyStockProfitRates
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockAccountDailyStockProfitRateItem>? Items;
	}

	public record KiwoomUsStockAccountDailyStockProfitRateItem
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 최초기준일자
		/// </summary>
		[JsonProperty("frst_base_dt")]
		public string? FirstBaseDate;
		/// <summary>
		/// 최종기준일자
		/// </summary>
		[JsonProperty("last_base_dt")]
		public string? LastBaseDate;
		/// <summary>
		/// 손익금액
		/// </summary>
		[JsonProperty("pl_amt")]
		public decimal? ProfitLossAmount;
		/// <summary>
		/// 수익률
		/// </summary>
		[JsonProperty("prft_rt")]
		public KiwoomDecimal? ProfitRate;
		/// <summary>
		/// 최초주식평가금액
		/// </summary>
		[JsonProperty("frst_stk_evlta")]
		public decimal? FirstStockEvaluationAmount;
		/// <summary>
		/// 최종주식평가금액
		/// </summary>
		[JsonProperty("last_stk_evlta")]
		public decimal? LastStockEvaluationAmount;
		/// <summary>
		/// 최초보유수량
		/// </summary>
		[JsonProperty("frst_qty")]
		public decimal? FirstQuantity;
		/// <summary>
		/// 최종보유수량
		/// </summary>
		[JsonProperty("last_qty")]
		public decimal? LastQuantity;
		/// <summary>
		/// 매수수량
		/// </summary>
		[JsonProperty("buy_qty")]
		public decimal? BuyQuantity;
		/// <summary>
		/// 매도수량
		/// </summary>
		[JsonProperty("sell_qty")]
		public decimal? SellQuantity;
		/// <summary>
		/// 매수금액
		/// </summary>
		[JsonProperty("buy_amt")]
		public decimal? BuyAmount;
		/// <summary>
		/// 매도금액
		/// </summary>
		[JsonProperty("sell_amt")]
		public decimal? SellAmount;
		/// <summary>
		/// 외화증권입고금액
		/// </summary>
		[JsonProperty("frgn_stk_inq_amt")]
		public decimal? ForeignStockIncomingAmount;
		/// <summary>
		/// 외화증권출고금액
		/// </summary>
		[JsonProperty("frgn_stk_outq_amt")]
		public decimal? ForeignStockOutgoingAmount;
		/// <summary>
		/// 수수료및세금
		/// </summary>
		[JsonProperty("cmsn_tax")]
		public decimal? CommissionTax;
		/// <summary>
		/// 배당금액
		/// </summary>
		[JsonProperty("dvid_amt")]
		public decimal? DividendAmount;
		/// <summary>
		/// 통화코드
		/// </summary>
		[JsonProperty("crnc_code")]
		public string? CurrencyCode;
	}

	/// <summary>
	/// | ust21050 | 미국주식 원장 미체결
	/// </summary>
	public record KiwoomUsStockAccountGetUnfilledOrders
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockAccountUnfilledOrderItem>? Items;
	}

	public record KiwoomUsStockAccountUnfilledOrderItem
	{
		/// <summary>
		/// 주문체결구분
		/// </summary>
		[JsonProperty("ord_cntr_tp")]
		public string? OrderExecutionType;
		/// <summary>
		/// 주문번호
		/// </summary>
		[JsonProperty("ord_no")]
		public string? OrderNumber;
		/// <summary>
		/// 원주문번호
		/// </summary>
		[JsonProperty("orig_ord_no")]
		public string? OriginalOrderNumber;
		/// <summary>
		/// 해외주문ID
		/// </summary>
		[JsonProperty("frgn_ord_id")]
		public string? ForeignOrderId;
		/// <summary>
		/// 거래소명
		/// </summary>
		[JsonProperty("stex_nm")]
		public string? ExchangeName;
		/// <summary>
		/// 통화코드
		/// </summary>
		[JsonProperty("crnc_code")]
		public string? CurrencyCode;
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 해외종목명
		/// </summary>
		[JsonProperty("frgn_stk_nm")]
		public string? ForeignStockName;
		/// <summary>
		/// 해외거래구분
		/// </summary>
		[JsonProperty("frgn_trde_tp")]
		public string? ForeignTradeType;
		/// <summary>
		/// 해외거래구분명
		/// </summary>
		[JsonProperty("frgn_trde_nm")]
		public string? ForeignTradeTypeName;
		/// <summary>
		/// 매도매수구분
		/// </summary>
		[JsonProperty("slby_tp")]
		public string? SellBuyType;
		/// <summary>
		/// 매도매수구분명
		/// </summary>
		[JsonProperty("slby_tp_nm")]
		public string? SellBuyTypeName;
		/// <summary>
		/// 주문수량
		/// </summary>
		[JsonProperty("ord_qty")]
		public decimal? OrderQuantity;
		/// <summary>
		/// 주문단가
		/// </summary>
		[JsonProperty("ord_uv")]
		public decimal? OrderUnitPrice;
		/// <summary>
		/// 스톱가
		/// </summary>
		[JsonProperty("stop_pric")]
		public decimal? StopPrice;
		/// <summary>
		/// 체결수량
		/// </summary>
		[JsonProperty("cntr_qty")]
		public decimal? TradeQuantity;
		/// <summary>
		/// 체결단가
		/// </summary>
		[JsonProperty("cntr_uv")]
		public decimal? TradeUnitPrice;
		/// <summary>
		/// 정정수량
		/// </summary>
		[JsonProperty("mdfy_qty")]
		public decimal? ModifyQuantity;
		/// <summary>
		/// 정정단가
		/// </summary>
		[JsonProperty("mdfy_uv")]
		public decimal? ModifyUnitPrice;
		/// <summary>
		/// 취소수량
		/// </summary>
		[JsonProperty("cncl_qty")]
		public decimal? CancelQuantity;
		/// <summary>
		/// 주문잔량
		/// </summary>
		[JsonProperty("ord_remnq")]
		public decimal? OrderRemainingQuantity;
		/// <summary>
		/// 주문시간
		/// </summary>
		[JsonProperty("ord_time")]
		public string? OrderTime;
		/// <summary>
		/// 주문응답시간
		/// </summary>
		[JsonProperty("ord_resp_time")]
		public string? OrderResponseTime;
		/// <summary>
		/// 주문상태
		/// </summary>
		[JsonProperty("ord_stat")]
		public string? OrderStatus;
		/// <summary>
		/// 예약구분
		/// </summary>
		[JsonProperty("rsrv_tp")]
		public string? ReservationType;
		/// <summary>
		/// 국가명
		/// </summary>
		[JsonProperty("natn_nm")]
		public string? CountryName;
	}

	/// <summary>
	/// | ust21070 | 미국주식 원장잔고확인
	/// </summary>
	public record KiwoomUsStockAccountGetBalance
	{
		/// <summary>
		/// 거래소구분
		/// </summary>
		[JsonProperty("stex_tp")]
		public string? ExchangeType;
		/// <summary>
		/// 통화코드
		/// </summary>
		[JsonProperty("crnc_code")]
		public string? CurrencyCode;
		/// <summary>
		/// 총평가금액
		/// </summary>
		[JsonProperty("tot_evlt_amt")]
		public decimal? TotalEvaluationAmount;
		/// <summary>
		/// 총매입금액
		/// </summary>
		[JsonProperty("tot_prch_amt")]
		public decimal? TotalPurchaseAmount;
		/// <summary>
		/// 총손익금액
		/// </summary>
		[JsonProperty("tot_pl_amt")]
		public decimal? TotalProfitLossAmount;
		/// <summary>
		/// 총손익률
		/// </summary>
		[JsonProperty("tot_pl_rt")]
		public KiwoomDecimal? TotalProfitLossRate;
		/// <summary>
		/// 당일장부금액
		/// </summary>
		[JsonProperty("tdy_book_amt")]
		public decimal? TodayBookAmount;
		/// <summary>
		/// 당일손익금액
		/// </summary>
		[JsonProperty("tdy_pl_amt")]
		public decimal? TodayProfitLossAmount;
		/// <summary>
		/// 당일손익률
		/// </summary>
		[JsonProperty("tdy_pl_rt")]
		public KiwoomDecimal? TodayProfitLossRate;
		/// <summary>
		/// 총평가금액(원화)
		/// </summary>
		[JsonProperty("tot_evlt_amt_krw")]
		public decimal? TotalEvaluationAmountKrw;
		/// <summary>
		/// 총매입금액(원화)
		/// </summary>
		[JsonProperty("tot_prch_amt_krw")]
		public decimal? TotalPurchaseAmountKrw;
		/// <summary>
		/// 총손익금액(원화)
		/// </summary>
		[JsonProperty("tot_pl_amt_krw")]
		public decimal? TotalProfitLossAmountKrw;
		/// <summary>
		/// 당일장부금액(원화)
		/// </summary>
		[JsonProperty("tdy_book_amt_krw")]
		public decimal? TodayBookAmountKrw;
		/// <summary>
		/// 당일손익금액(원화)
		/// </summary>
		[JsonProperty("tdy_pl_amt_krw")]
		public decimal? TodayProfitLossAmountKrw;
		/// <summary>
		/// 종목별잔고리스트
		/// </summary>
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockAccountBalanceItem>? Items;
	}

	public record KiwoomUsStockAccountBalanceItem
	{
		/// <summary>
		/// 거래소명
		/// </summary>
		[JsonProperty("stex_nm")]
		public string? ExchangeName;
		/// <summary>
		/// 통화코드
		/// </summary>
		[JsonProperty("crnc_code")]
		public string? CurrencyCode;
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 해외종목명
		/// </summary>
		[JsonProperty("frgn_stk_nm")]
		public string? ForeignStockName;
		/// <summary>
		/// 보유수량
		/// </summary>
		[JsonProperty("qty")]
		public decimal? Quantity;
		/// <summary>
		/// 소지수량
		/// </summary>
		[JsonProperty("poss_qty")]
		public decimal? PossessionQuantity;
		/// <summary>
		/// 매도가능수량
		/// </summary>
		[JsonProperty("sell_alowq")]
		public decimal? SellAllowedQuantity;
		/// <summary>
		/// 전일체결매도수량
		/// </summary>
		[JsonProperty("pred_cntr_sellq")]
		public decimal? PreviousDayTradeSellQuantity;
		/// <summary>
		/// 전일체결매수수량
		/// </summary>
		[JsonProperty("pred_cntr_buyq")]
		public decimal? PreviousDayTradeBuyQuantity;
		/// <summary>
		/// 당일체결매도수량
		/// </summary>
		[JsonProperty("tdy_cntr_sellq")]
		public decimal? TodayTradeSellQuantity;
		/// <summary>
		/// 당일체결매수수량
		/// </summary>
		[JsonProperty("tdy_cntr_buyq")]
		public decimal? TodayTradeBuyQuantity;
		/// <summary>
		/// 해외종목장부단가
		/// </summary>
		[JsonProperty("frgn_stk_book_uv")]
		public KiwoomDecimal? ForeignStockBookUnitPrice;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("now_pric")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 평가금액
		/// </summary>
		[JsonProperty("evlt_amt")]
		public decimal? EvaluationAmount;
		/// <summary>
		/// 손익금액
		/// </summary>
		[JsonProperty("pl_amt")]
		public decimal? ProfitLossAmount;
		/// <summary>
		/// 손익률
		/// </summary>
		[JsonProperty("pl_rt")]
		public KiwoomDecimal? ProfitLossRate;
		/// <summary>
		/// 평가금액(원화)
		/// </summary>
		[JsonProperty("evlt_amt_krw")]
		public decimal? EvaluationAmountKrw;
		/// <summary>
		/// 손익금액(원화)
		/// </summary>
		[JsonProperty("pl_amt_krw")]
		public decimal? ProfitLossAmountKrw;
		/// <summary>
		/// 국가명
		/// </summary>
		[JsonProperty("natn_nm")]
		public string? CountryName;
		/// <summary>
		/// 환율
		/// </summary>
		[JsonProperty("exch_rate")]
		public KiwoomDecimal? ExchangeRate;
		/// <summary>
		/// 해외종목장부단가(원화)
		/// </summary>
		[JsonProperty("frgn_stk_book_uv_krw")]
		public decimal? ForeignStockBookUnitPriceKrw;
		/// <summary>
		/// 현재가(원화)
		/// </summary>
		[JsonProperty("now_pric_krw")]
		public decimal? CurrentPriceKrw;
		/// <summary>
		/// 해외종목장부금액
		/// </summary>
		[JsonProperty("frgn_stk_book_amt")]
		public decimal? ForeignStockBookAmount;
		/// <summary>
		/// 해외종목장부금액(원화)
		/// </summary>
		[JsonProperty("frgn_stk_book_amt_krw")]
		public decimal? ForeignStockBookAmountKrw;
	}

	/// <summary>
	/// | ust21100 | 미국주식 거래내역
	/// </summary>
	public record KiwoomUsStockAccountGetTransactionHistory
	{
		/// <summary>
		/// 계좌표시
		/// </summary>
		[JsonProperty("acnt_print")]
		public string? AccountDisplay;
		/// <summary>
		/// 매도합계
		/// </summary>
		[JsonProperty("sell_sum")]
		public decimal? SellSum;
		/// <summary>
		/// 매수합계
		/// </summary>
		[JsonProperty("buy_sum")]
		public decimal? BuySum;
		/// <summary>
		/// 거래내역리스트
		/// </summary>
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockAccountTransactionHistoryItem>? Items;
	}

	public record KiwoomUsStockAccountTransactionHistoryItem
	{
		/// <summary>
		/// 거래일자
		/// </summary>
		[JsonProperty("deal_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? DealDate;
		/// <summary>
		/// 거래종류명
		/// </summary>
		[JsonProperty("deal_kind_nm")]
		public string? DealKindName;
		/// <summary>
		/// 비고명
		/// </summary>
		[JsonProperty("rmrk_nm")]
		public string? RemarkName;
		/// <summary>
		/// 거래금액
		/// </summary>
		[JsonProperty("deal_amt")]
		public decimal? DealAmount;
		/// <summary>
		/// 제세금합계금액
		/// </summary>
		[JsonProperty("tax_tot_amt")]
		public decimal? TaxTotalAmount;
		/// <summary>
		/// 정산금액
		/// </summary>
		[JsonProperty("exct_amt")]
		public decimal? SettlementAmount;
		/// <summary>
		/// 미청산잔고
		/// </summary>
		[JsonProperty("uncl_ocr")]
		public decimal? UnclearedBalance;
		/// <summary>
		/// 외화미청산잔고
		/// </summary>
		[JsonProperty("fc_uncl_ocr")]
		public decimal? ForeignCurrencyUnclearedBalance;
		/// <summary>
		/// 위탁잔고
		/// </summary>
		[JsonProperty("entra_remn")]
		public decimal? ConsignmentBalance;
		/// <summary>
		/// 거래번호
		/// </summary>
		[JsonProperty("deal_no")]
		public string? DealNumber;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 거래수량
		/// </summary>
		[JsonProperty("deal_qty")]
		public decimal? DealQuantity;
		/// <summary>
		/// 외화거래세금
		/// </summary>
		[JsonProperty("fc_deal_tax")]
		public decimal? ForeignCurrencyDealTax;
		/// <summary>
		/// 해외지급세금
		/// </summary>
		[JsonProperty("frgn_pay_txam")]
		public decimal? ForeignPayTax;
		/// <summary>
		/// 상환합계
		/// </summary>
		[JsonProperty("rpym_sum")]
		public decimal? RepaymentSum;
		/// <summary>
		/// 외화상환합계
		/// </summary>
		[JsonProperty("fc_rpym_sum")]
		public decimal? ForeignCurrencyRepaymentSum;
		/// <summary>
		/// 외화예수금
		/// </summary>
		[JsonProperty("fc_entra")]
		public decimal? ForeignCurrencyDeposit;
		/// <summary>
		/// 매체명
		/// </summary>
		[JsonProperty("mdia_nm")]
		public string? MediaName;
		/// <summary>
		/// 원거래번호
		/// </summary>
		[JsonProperty("orig_deal_no")]
		public string? OriginalDealNumber;
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 적용환율
		/// </summary>
		[JsonProperty("uv_exrt")]
		public KiwoomDecimal? UnitExchangeRate;
		/// <summary>
		/// 외화수수료
		/// </summary>
		[JsonProperty("fc_cmsn")]
		public decimal? ForeignCurrencyCommission;
		/// <summary>
		/// 외화정산금액
		/// </summary>
		[JsonProperty("fc_exct_amt")]
		public decimal? ForeignCurrencySettlementAmount;
		/// <summary>
		/// 입출금합계
		/// </summary>
		[JsonProperty("dly_sum")]
		public decimal? DepositWithdrawalSum;
		/// <summary>
		/// 외화입출금합계
		/// </summary>
		[JsonProperty("fc_dly_sum")]
		public decimal? ForeignCurrencyDepositWithdrawalSum;
		/// <summary>
		/// 실물현재잔고
		/// </summary>
		[JsonProperty("vlbl_nowrm")]
		public decimal? PhysicalCurrentBalance;
		/// <summary>
		/// ISIN코드
		/// </summary>
		[JsonProperty("isin_code")]
		public string? IsinCode;
		/// <summary>
		/// 거래소명
		/// </summary>
		[JsonProperty("stex_nm")]
		public string? ExchangeName;
		/// <summary>
		/// 외화거래금액
		/// </summary>
		[JsonProperty("fc_deal_amt")]
		public decimal? ForeignCurrencyDealAmount;
		/// <summary>
		/// 처리자ID
		/// </summary>
		[JsonProperty("wrkr_id")]
		public string? WorkerId;
		/// <summary>
		/// 처리지점
		/// </summary>
		[JsonProperty("proc_brch")]
		public string? ProcessBranch;
		/// <summary>
		/// 처리시간
		/// </summary>
		[JsonProperty("proc_time")]
		public string? ProcessTime;
		/// <summary>
		/// 통화코드
		/// </summary>
		[JsonProperty("crnc_code")]
		public string? CurrencyCode;
	}

	/// <summary>
	/// | ust21110 | 해외주식 예수금
	/// </summary>
	public record KiwoomUsStockAccountGetDeposit
	{
		/// <summary>
		/// 원화예수금
		/// </summary>
		[JsonProperty("krw_entra")]
		public decimal? KrwDeposit;
		/// <summary>
		/// 환전미청산금
		/// </summary>
		[JsonProperty("ch_uncla")]
		public decimal? ExchangeUnclearedAmount;
		/// <summary>
		/// 기타대출금
		/// </summary>
		[JsonProperty("etc_loana")]
		public decimal? OtherLoanAmount;
		/// <summary>
		/// 통화별예수금리스트
		/// </summary>
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockAccountDepositItem>? Items;
	}

	public record KiwoomUsStockAccountDepositItem
	{
		/// <summary>
		/// 통화코드
		/// </summary>
		[JsonProperty("crnc_code")]
		public string? CurrencyCode;
		/// <summary>
		/// 통화명
		/// </summary>
		[JsonProperty("crnc_nm")]
		public string? CurrencyName;
		/// <summary>
		/// 외화예수금
		/// </summary>
		[JsonProperty("fc_entra")]
		public decimal? ForeignCurrencyDeposit;
		/// <summary>
		/// 외화지급가능금액
		/// </summary>
		[JsonProperty("fc_pymn_alowa")]
		public decimal? ForeignCurrencyPaymentAllowedAmount;
		/// <summary>
		/// 미래대용증거금
		/// </summary>
		[JsonProperty("futr_repl_profa")]
		public decimal? FutureReplacementMargin;
		/// <summary>
		/// 외화장부금액
		/// </summary>
		[JsonProperty("fc_booka")]
		public decimal? ForeignCurrencyBookAmount;
		/// <summary>
		/// 외화주문가능금액
		/// </summary>
		[JsonProperty("fc_ord_alowa")]
		public decimal? ForeignCurrencyOrderAllowedAmount;
		/// <summary>
		/// 미래증거금장부금액
		/// </summary>
		[JsonProperty("futr_profa_booka")]
		public decimal? FutureMarginBookAmount;
		/// <summary>
		/// 외화환전미청산금
		/// </summary>
		[JsonProperty("fc_ch_uncla")]
		public decimal? ForeignCurrencyExchangeUnclearedAmount;
		/// <summary>
		/// 외화기타대출금
		/// </summary>
		[JsonProperty("fc_etc_loana")]
		public decimal? ForeignCurrencyOtherLoanAmount;
	}

	/// <summary>
	/// | ust21111 | 원화출금가능 금액 조회(원화대용 포함)
	/// </summary>
	public record KiwoomUsStockAccountGetKrwWithdrawableAmount
	{
		/// <summary>
		/// 신용거부구분
		/// </summary>
		[JsonProperty("rgst_abnd_tp")]
		public string? CreditAbandonType;
		/// <summary>
		/// 원화지급가능금액
		/// </summary>
		[JsonProperty("krw_pymn_alow_amt")]
		public decimal? KrwPaymentAllowedAmount;
		/// <summary>
		/// 원화대용거부금액
		/// </summary>
		[JsonProperty("krw_repl_abnd_amt")]
		public decimal? KrwReplacementAbandonedAmount;
	}

	/// <summary>
	/// | ust21120 | 통화별 예수금 및 증권 평가금현황
	/// </summary>
	public record KiwoomUsStockAccountGetCurrencyDepositEvaluation
	{
		/// <summary>
		/// 원화예수금
		/// </summary>
		[JsonProperty("won_entr")]
		public decimal? WonDeposit;
		/// <summary>
		/// 자산평가금액
		/// </summary>
		[JsonProperty("aset_evlt_amt")]
		public decimal? AssetEvaluationAmount;
		/// <summary>
		/// 통화별평가리스트
		/// </summary>
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockAccountCurrencyDepositEvaluationItem>? Items;
	}

	public record KiwoomUsStockAccountCurrencyDepositEvaluationItem
	{
		/// <summary>
		/// 통화코드
		/// </summary>
		[JsonProperty("crnc_code")]
		public string? CurrencyCode;
		/// <summary>
		/// 외화예수금
		/// </summary>
		[JsonProperty("fx_entr")]
		public decimal? ForeignCurrencyDeposit;
		/// <summary>
		/// 평가금액
		/// </summary>
		[JsonProperty("evlt_amt")]
		public decimal? EvaluationAmount;
		/// <summary>
		/// 통화환율
		/// </summary>
		[JsonProperty("crnc_rt")]
		public KiwoomDecimal? CurrencyExchangeRate;
		/// <summary>
		/// 환산예수금
		/// </summary>
		[JsonProperty("chg_entr")]
		public decimal? ConvertedDeposit;
		/// <summary>
		/// 환산평가금액
		/// </summary>
		[JsonProperty("chg_evlt_amt")]
		public decimal? ConvertedEvaluationAmount;
		/// <summary>
		/// 평가금액비중
		/// </summary>
		[JsonProperty("evlt_amt_wght")]
		public KiwoomDecimal? EvaluationAmountWeight;
	}

	/// <summary>
	/// | ust21121 | 해외증권 원장 평가금액현황
	/// </summary>
	public record KiwoomUsStockAccountGetLedgerEvaluationAmount
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockAccountLedgerEvaluationAmountItem>? Items;
	}

	public record KiwoomUsStockAccountLedgerEvaluationAmountItem
	{
		/// <summary>
		/// 국가명
		/// </summary>
		[JsonProperty("natn_nm")]
		public string? CountryName;
		/// <summary>
		/// 거래소명
		/// </summary>
		[JsonProperty("stex_nm")]
		public string? ExchangeName;
		/// <summary>
		/// 통화코드
		/// </summary>
		[JsonProperty("crnc_code")]
		public string? CurrencyCode;
		/// <summary>
		/// 통화명
		/// </summary>
		[JsonProperty("crnc_nm")]
		public string? CurrencyName;
		/// <summary>
		/// 평가금액
		/// </summary>
		[JsonProperty("evlt_amt")]
		public decimal? EvaluationAmount;
		/// <summary>
		/// 환산평가금액
		/// </summary>
		[JsonProperty("chg_evlt_amt")]
		public decimal? ConvertedEvaluationAmount;
		/// <summary>
		/// 손익률
		/// </summary>
		[JsonProperty("pl_rt")]
		public KiwoomDecimal? ProfitLossRate;
		/// <summary>
		/// 손익금액
		/// </summary>
		[JsonProperty("pl_amt")]
		public decimal? ProfitLossAmount;
		/// <summary>
		/// 환산손익금액
		/// </summary>
		[JsonProperty("chg_profit_amt")]
		public decimal? ConvertedProfitAmount;
		/// <summary>
		/// 평가금액비중
		/// </summary>
		[JsonProperty("evlt_amt_wght")]
		public KiwoomDecimal? EvaluationAmountWeight;
	}

	/// <summary>
	/// | ust21131 | 해외증권 특정일 평가금액
	/// </summary>
	public record KiwoomUsStockAccountGetSpecificDateEvaluationAmount
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockAccountLedgerEvaluationAmountItem>? Items;
	}

	/// <summary>
	/// | ust21132 | 특정일 통화별 예수금 및 증권 평가금
	/// </summary>
	public record KiwoomUsStockAccountGetSpecificDateCurrencyDepositEvaluation
	{
		/// <summary>
		/// 원화예수금
		/// </summary>
		[JsonProperty("won_entr")]
		public decimal? WonDeposit;
		/// <summary>
		/// 총평가금액
		/// </summary>
		[JsonProperty("tot_evlt_amt")]
		public decimal? TotalEvaluationAmount;
		/// <summary>
		/// 장부금액
		/// </summary>
		[JsonProperty("book_amt")]
		public decimal? BookAmount;
		/// <summary>
		/// 총손익
		/// </summary>
		[JsonProperty("tot_pl")]
		public decimal? TotalProfitLoss;
		/// <summary>
		/// 총손익률
		/// </summary>
		[JsonProperty("tot_pl_rt")]
		public KiwoomDecimal? TotalProfitLossRate;
		/// <summary>
		/// 자산평가금액
		/// </summary>
		[JsonProperty("aset_evlt_amt")]
		public decimal? AssetEvaluationAmount;
		/// <summary>
		/// 통화별평가리스트
		/// </summary>
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockAccountCurrencyDepositEvaluationItem>? Items;
	}

	/// <summary>
	/// | ust21150 | 미국주식 일별 주문체결내역
	/// </summary>
	public record KiwoomUsStockAccountGetDailyOrderExecutions
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockAccountDailyOrderExecutionItem>? Items;
	}

	public record KiwoomUsStockAccountDailyOrderExecutionItem
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[JsonProperty("ord_no")]
		public string? OrderNumber;
		/// <summary>
		/// 통화코드
		/// </summary>
		[JsonProperty("crnc_code")]
		public string? CurrencyCode;
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// ISIN코드
		/// </summary>
		[JsonProperty("isin_code")]
		public string? IsinCode;
		/// <summary>
		/// 해외거래구분
		/// </summary>
		[JsonProperty("frgn_trde_tp")]
		public string? ForeignTradeType;
		/// <summary>
		/// 주문수량
		/// </summary>
		[JsonProperty("ord_qty")]
		public decimal? OrderQuantity;
		/// <summary>
		/// 체결수량
		/// </summary>
		[JsonProperty("cntr_qty")]
		public decimal? TradeQuantity;
		/// <summary>
		/// 정정수량
		/// </summary>
		[JsonProperty("mdfy_qty")]
		public decimal? ModifyQuantity;
		/// <summary>
		/// 취소수량
		/// </summary>
		[JsonProperty("cncl_qty")]
		public decimal? CancelQuantity;
		/// <summary>
		/// 해외메시지코드
		/// </summary>
		[JsonProperty("frgn_msg_code")]
		public string? ForeignMessageCode;
		/// <summary>
		/// 예약구분
		/// </summary>
		[JsonProperty("rsrv_tp")]
		public string? ReservationType;
		/// <summary>
		/// 반대매매구분명
		/// </summary>
		[JsonProperty("oppo_trde_tp_nm")]
		public string? OppositeTradeTypeName;
		/// <summary>
		/// 공통주문구분명
		/// </summary>
		[JsonProperty("comm_ord_tp_nm")]
		public string? CommonOrderTypeName;
		/// <summary>
		/// 주문시간
		/// </summary>
		[JsonProperty("ord_time")]
		public string? OrderTime;
		/// <summary>
		/// 통화명
		/// </summary>
		[JsonProperty("crnc_nm")]
		public string? CurrencyName;
		/// <summary>
		/// 거래소명
		/// </summary>
		[JsonProperty("stex_nm")]
		public string? ExchangeName;
		/// <summary>
		/// 해외종목명
		/// </summary>
		[JsonProperty("frgn_stk_nm")]
		public string? ForeignStockName;
		/// <summary>
		/// 매도수구분명
		/// </summary>
		[JsonProperty("slby_tp_nm")]
		public string? SellBuyTypeName;
		/// <summary>
		/// 주문단가
		/// </summary>
		[JsonProperty("ord_uv")]
		public decimal? OrderUnitPrice;
		/// <summary>
		/// 스톱가
		/// </summary>
		[JsonProperty("stop_pric")]
		public decimal? StopPrice;
		/// <summary>
		/// 체결단가
		/// </summary>
		[JsonProperty("cntr_uv")]
		public decimal? TradeUnitPrice;
		/// <summary>
		/// 정정단가
		/// </summary>
		[JsonProperty("mdfy_uv")]
		public decimal? ModifyUnitPrice;
		/// <summary>
		/// 주문잔량
		/// </summary>
		[JsonProperty("ord_remnq")]
		public decimal? OrderRemainingQuantity;
		/// <summary>
		/// 주문상태명
		/// </summary>
		[JsonProperty("ord_stat_nm")]
		public string? OrderStatusName;
		/// <summary>
		/// 텍스트1
		/// </summary>
		[JsonProperty("text1")]
		public string? Text1;
		/// <summary>
		/// 입력채널구분
		/// </summary>
		[JsonProperty("inpt_chnl_tp")]
		public string? InputChannelType;
		/// <summary>
		/// 주문응답시간
		/// </summary>
		[JsonProperty("ord_resp_time")]
		public string? OrderResponseTime;
		/// <summary>
		/// 체결시간
		/// </summary>
		[JsonProperty("cntr_time")]
		public string? TradeTime;
	}

	/// <summary>
	/// | ust21160 | 미국주식 예수금 상세
	/// </summary>
	public record KiwoomUsStockAccountGetDepositDetails
	{
		/// <summary>
		/// 원화예수금
		/// </summary>
		[JsonProperty("won_entr")]
		public decimal? WonDeposit;
		/// <summary>
		/// 원화이연금액
		/// </summary>
		[JsonProperty("won_dfr_amt")]
		public decimal? WonDeferredAmount;
		/// <summary>
		/// 원화기타대출금
		/// </summary>
		[JsonProperty("won_etc_loana")]
		public decimal? WonOtherLoanAmount;
		/// <summary>
		/// 원화주문설정금액
		/// </summary>
		[JsonProperty("krw_ord_set_amt")]
		public decimal? KrwOrderSetAmount;
		/// <summary>
		/// 달러환율
		/// </summary>
		[JsonProperty("usd_exch_rate")]
		public KiwoomDecimal? UsdExchangeRate;
		/// <summary>
		/// D0결제일자
		/// </summary>
		[JsonProperty("d0_setl_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? D0SettlementDate;
		/// <summary>
		/// D0원화환산가능금액
		/// </summary>
		[JsonProperty("d0_won_conv_alow_ch")]
		public decimal? D0WonConversionAllowedAmount;
		/// <summary>
		/// D0달러외화예수금
		/// </summary>
		[JsonProperty("d0_usd_fx_entr")]
		public decimal? D0UsdForeignCurrencyDeposit;
		/// <summary>
		/// D1결제일자
		/// </summary>
		[JsonProperty("d1_setl_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? D1SettlementDate;
		/// <summary>
		/// D1원화환산가능금액
		/// </summary>
		[JsonProperty("d1_won_conv_alow_ch")]
		public decimal? D1WonConversionAllowedAmount;
		/// <summary>
		/// D1달러외화예수금
		/// </summary>
		[JsonProperty("d1_usd_fx_entr")]
		public decimal? D1UsdForeignCurrencyDeposit;
		/// <summary>
		/// D1달러정산금액
		/// </summary>
		[JsonProperty("d1_usd_exct_amt")]
		public decimal? D1UsdSettlementAmount;
		/// <summary>
		/// D1달러매수정산금액
		/// </summary>
		[JsonProperty("d1_usd_buy_excta")]
		public decimal? D1UsdBuySettlementAmount;
		/// <summary>
		/// D1달러매도정산금액
		/// </summary>
		[JsonProperty("d1_usd_sell_excta")]
		public decimal? D1UsdSellSettlementAmount;
		/// <summary>
		/// D2결제일자
		/// </summary>
		[JsonProperty("d2_setl_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? D2SettlementDate;
		/// <summary>
		/// D2원화환산가능금액
		/// </summary>
		[JsonProperty("d2_won_conv_alow_ch")]
		public decimal? D2WonConversionAllowedAmount;
		/// <summary>
		/// D2달러외화예수금
		/// </summary>
		[JsonProperty("d2_usd_fx_entr")]
		public decimal? D2UsdForeignCurrencyDeposit;
		/// <summary>
		/// D2달러정산금액
		/// </summary>
		[JsonProperty("d2_usd_exct_amt")]
		public decimal? D2UsdSettlementAmount;
		/// <summary>
		/// D2달러매수정산금액
		/// </summary>
		[JsonProperty("d2_usd_buy_excta")]
		public decimal? D2UsdBuySettlementAmount;
		/// <summary>
		/// D2달러매도정산금액
		/// </summary>
		[JsonProperty("d2_usd_sell_excta")]
		public decimal? D2UsdSellSettlementAmount;
		/// <summary>
		/// D3결제일자
		/// </summary>
		[JsonProperty("d3_setl_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? D3SettlementDate;
		/// <summary>
		/// D3원화환산가능금액
		/// </summary>
		[JsonProperty("d3_won_conv_alow_ch")]
		public decimal? D3WonConversionAllowedAmount;
		/// <summary>
		/// D3달러외화예수금
		/// </summary>
		[JsonProperty("d3_usd_fx_entr")]
		public decimal? D3UsdForeignCurrencyDeposit;
		/// <summary>
		/// D3달러정산금액
		/// </summary>
		[JsonProperty("d3_usd_exct_amt")]
		public decimal? D3UsdSettlementAmount;
		/// <summary>
		/// D3달러매수정산금액
		/// </summary>
		[JsonProperty("d3_usd_buy_excta")]
		public decimal? D3UsdBuySettlementAmount;
		/// <summary>
		/// D3달러매도정산금액
		/// </summary>
		[JsonProperty("d3_usd_sell_excta")]
		public decimal? D3UsdSellSettlementAmount;
		/// <summary>
		/// D4결제일자
		/// </summary>
		[JsonProperty("d4_setl_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? D4SettlementDate;
		/// <summary>
		/// D4원화환산가능금액
		/// </summary>
		[JsonProperty("d4_won_conv_alow_ch")]
		public decimal? D4WonConversionAllowedAmount;
		/// <summary>
		/// D4달러외화예수금
		/// </summary>
		[JsonProperty("d4_usd_fx_entr")]
		public decimal? D4UsdForeignCurrencyDeposit;
		/// <summary>
		/// D4달러정산금액
		/// </summary>
		[JsonProperty("d4_usd_exct_amt")]
		public decimal? D4UsdSettlementAmount;
		/// <summary>
		/// D4달러매수정산금액
		/// </summary>
		[JsonProperty("d4_usd_buy_excta")]
		public decimal? D4UsdBuySettlementAmount;
		/// <summary>
		/// D4달러매도정산금액
		/// </summary>
		[JsonProperty("d4_usd_sell_excta")]
		public decimal? D4UsdSellSettlementAmount;
	}

	/// <summary>
	/// | ust21170 | 미국주식 당일 종목별 실현손익
	/// </summary>
	public record KiwoomUsStockAccountGetTodayStockRealizedProfitLosses
	{
		/// <summary>
		/// 통화코드
		/// </summary>
		[JsonProperty("crnc_code")]
		public string? CurrencyCode;
		/// <summary>
		/// 총평가금액
		/// </summary>
		[JsonProperty("tot_evlt_amt")]
		public decimal? TotalEvaluationAmount;
		/// <summary>
		/// 총매입금액
		/// </summary>
		[JsonProperty("tot_prch_amt")]
		public decimal? TotalPurchaseAmount;
		/// <summary>
		/// 총손익금액
		/// </summary>
		[JsonProperty("tot_pl_amt")]
		public decimal? TotalProfitLossAmount;
		/// <summary>
		/// 총손익률
		/// </summary>
		[JsonProperty("tot_pl_rt")]
		public KiwoomDecimal? TotalProfitLossRate;
		/// <summary>
		/// 당일손익금액
		/// </summary>
		[JsonProperty("tdy_pl_amt")]
		public decimal? TodayProfitLossAmount;
		/// <summary>
		/// 추정자산(원화)
		/// </summary>
		[JsonProperty("prsm_aseta_krw")]
		public decimal? PresumedAssetAmountKrw;
		/// <summary>
		/// 종목별손익리스트
		/// </summary>
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockAccountTodayStockRealizedProfitLossItem>? Items;
	}

	public record KiwoomUsStockAccountTodayStockRealizedProfitLossItem
	{
		/// <summary>
		/// 거래소명
		/// </summary>
		[JsonProperty("stex_nm")]
		public string? ExchangeName;
		/// <summary>
		/// 통화코드
		/// </summary>
		[JsonProperty("crnc_code")]
		public string? CurrencyCode;
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 해외종목명
		/// </summary>
		[JsonProperty("frgn_stk_nm")]
		public string? ForeignStockName;
		/// <summary>
		/// 당일손익금액
		/// </summary>
		[JsonProperty("tdy_pl_amt")]
		public decimal? TodayProfitLossAmount;
		/// <summary>
		/// 평가손익금액
		/// </summary>
		[JsonProperty("evlt_pl_amt")]
		public decimal? EvaluationProfitLossAmount;
		/// <summary>
		/// 평가손익률
		/// </summary>
		[JsonProperty("evlt_pl_rt")]
		public KiwoomDecimal? EvaluationProfitLossRate;
		/// <summary>
		/// 매입단가
		/// </summary>
		[JsonProperty("prch_uv")]
		public decimal? PurchaseUnitPrice;
		/// <summary>
		/// 소지수량
		/// </summary>
		[JsonProperty("poss_qty")]
		public decimal? PossessionQuantity;
		/// <summary>
		/// 매도가능수량
		/// </summary>
		[JsonProperty("sell_alowq")]
		public decimal? SellAllowedQuantity;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("now_pric")]
		public decimal? CurrentPrice;
		/// <summary>
		/// 매입금액
		/// </summary>
		[JsonProperty("prch_amt")]
		public decimal? PurchaseAmount;
		/// <summary>
		/// 평가금액
		/// </summary>
		[JsonProperty("evlt_amt")]
		public decimal? EvaluationAmount;
		/// <summary>
		/// 매입환율
		/// </summary>
		[JsonProperty("prch_exrt")]
		public KiwoomDecimal? PurchaseExchangeRate;
		/// <summary>
		/// 매도환율
		/// </summary>
		[JsonProperty("sell_exrt")]
		public KiwoomDecimal? SellExchangeRate;
		/// <summary>
		/// 원화환산차손익금액
		/// </summary>
		[JsonProperty("krw_chg_dfrn_pl_amt")]
		public decimal? KrwConvertedDifferenceProfitLossAmount;
		/// <summary>
		/// 원화환산손익금액
		/// </summary>
		[JsonProperty("krw_chg_pl_amt")]
		public decimal? KrwConvertedProfitLossAmount;
		/// <summary>
		/// 평가금액수수료
		/// </summary>
		[JsonProperty("evlt_amt_cmsn")]
		public decimal? EvaluationAmountCommission;
		/// <summary>
		/// 평가금액세금
		/// </summary>
		[JsonProperty("evlt_amt_tax")]
		public decimal? EvaluationAmountTax;
		/// <summary>
		/// 국가명
		/// </summary>
		[JsonProperty("natn_nm")]
		public string? CountryName;
	}

	/// <summary>
	/// | ust21180 | 미국주식 기간별 주문내역
	/// </summary>
	public record KiwoomUsStockAccountGetOrderHistory
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockAccountOrderHistoryItem>? Items;
	}

	public record KiwoomUsStockAccountOrderHistoryItem
	{
		/// <summary>
		/// 주문일자
		/// </summary>
		[JsonProperty("ord_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? OrderDate;
		/// <summary>
		/// 주문번호
		/// </summary>
		[JsonProperty("ord_no")]
		public string? OrderNumber;
		/// <summary>
		/// 통화코드
		/// </summary>
		[JsonProperty("crnc_code")]
		public string? CurrencyCode;
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 거래구분
		/// </summary>
		[JsonProperty("trde_tp")]
		public string? TradeType;
		/// <summary>
		/// 주문수량
		/// </summary>
		[JsonProperty("ord_qty")]
		public decimal? OrderQuantity;
		/// <summary>
		/// 체결수량
		/// </summary>
		[JsonProperty("cntr_qty")]
		public decimal? TradeQuantity;
		/// <summary>
		/// 정정수량
		/// </summary>
		[JsonProperty("mdfy_qty")]
		public decimal? ModifyQuantity;
		/// <summary>
		/// 취소수량
		/// </summary>
		[JsonProperty("cncl_qty")]
		public decimal? CancelQuantity;
		/// <summary>
		/// 예약구분
		/// </summary>
		[JsonProperty("rsrv_tp")]
		public string? ReservationType;
		/// <summary>
		/// 반대매매구분명
		/// </summary>
		[JsonProperty("oppo_trde_tp_nm")]
		public string? OppositeTradeTypeName;
		/// <summary>
		/// 입력채널구분명
		/// </summary>
		[JsonProperty("inpt_chnl_tp_nm")]
		public string? InputChannelTypeName;
		/// <summary>
		/// 주문시간
		/// </summary>
		[JsonProperty("ord_time")]
		public string? OrderTime;
		/// <summary>
		/// 통화명
		/// </summary>
		[JsonProperty("crnc_nm")]
		public string? CurrencyName;
		/// <summary>
		/// 거래소명
		/// </summary>
		[JsonProperty("stex_nm")]
		public string? ExchangeName;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 매도수구분명
		/// </summary>
		[JsonProperty("slby_tp_nm")]
		public string? SellBuyTypeName;
		/// <summary>
		/// 주문단가
		/// </summary>
		[JsonProperty("ord_uv")]
		public decimal? OrderUnitPrice;
		/// <summary>
		/// 스톱가
		/// </summary>
		[JsonProperty("stop_pric")]
		public decimal? StopPrice;
		/// <summary>
		/// 체결단가
		/// </summary>
		[JsonProperty("cntr_uv")]
		public decimal? TradeUnitPrice;
		/// <summary>
		/// 정정단가
		/// </summary>
		[JsonProperty("mdfy_uv")]
		public decimal? ModifyUnitPrice;
		/// <summary>
		/// 주문잔량
		/// </summary>
		[JsonProperty("ord_remnq")]
		public decimal? OrderRemainingQuantity;
		/// <summary>
		/// 체결금액
		/// </summary>
		[JsonProperty("cntr_amt")]
		public decimal? TradeAmount;
		/// <summary>
		/// 공통주문구분명
		/// </summary>
		[JsonProperty("comm_ord_tp_nm")]
		public string? CommonOrderTypeName;
	}

	/// <summary>
	/// | ust21510 | 미국주식 당일 주문체결 확인
	/// </summary>
	public record KiwoomUsStockAccountGetTodayOrderExecutions
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockAccountTodayOrderExecutionItem>? Items;
	}

	public record KiwoomUsStockAccountTodayOrderExecutionItem
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[JsonProperty("ord_no")]
		public string? OrderNumber;
		/// <summary>
		/// 원주문번호
		/// </summary>
		[JsonProperty("orig_ord_no")]
		public string? OriginalOrderNumber;
		/// <summary>
		/// 거래소명
		/// </summary>
		[JsonProperty("stex_nm")]
		public string? ExchangeName;
		/// <summary>
		/// 통화코드
		/// </summary>
		[JsonProperty("crnc_code")]
		public string? CurrencyCode;
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 해외종목명
		/// </summary>
		[JsonProperty("frgn_stk_nm")]
		public string? ForeignStockName;
		/// <summary>
		/// 해외거래구분
		/// </summary>
		[JsonProperty("frgn_trde_tp")]
		public string? ForeignTradeType;
		/// <summary>
		/// 해외거래구분명
		/// </summary>
		[JsonProperty("frgn_trde_nm")]
		public string? ForeignTradeTypeName;
		/// <summary>
		/// 매도매수구분
		/// </summary>
		[JsonProperty("slby_tp")]
		public string? SellBuyType;
		/// <summary>
		/// 매도매수구분명
		/// </summary>
		[JsonProperty("slby_tp_nm")]
		public string? SellBuyTypeName;
		/// <summary>
		/// 주문수량
		/// </summary>
		[JsonProperty("ord_qty")]
		public decimal? OrderQuantity;
		/// <summary>
		/// 주문단가
		/// </summary>
		[JsonProperty("ord_uv")]
		public decimal? OrderUnitPrice;
		/// <summary>
		/// 스톱가
		/// </summary>
		[JsonProperty("stop_pric")]
		public decimal? StopPrice;
		/// <summary>
		/// 체결수량
		/// </summary>
		[JsonProperty("cntr_qty")]
		public decimal? TradeQuantity;
		/// <summary>
		/// 체결단가
		/// </summary>
		[JsonProperty("cntr_uv")]
		public decimal? TradeUnitPrice;
		/// <summary>
		/// 확인수량
		/// </summary>
		[JsonProperty("cnfm_qty")]
		public decimal? ConfirmedQuantity;
		/// <summary>
		/// 주문잔량
		/// </summary>
		[JsonProperty("ord_remnq")]
		public decimal? OrderRemainingQuantity;
		/// <summary>
		/// 주문시간
		/// </summary>
		[JsonProperty("ord_time")]
		public string? OrderTime;
		/// <summary>
		/// 주문응답시간
		/// </summary>
		[JsonProperty("ord_resp_time")]
		public string? OrderResponseTime;
		/// <summary>
		/// 주문상태
		/// </summary>
		[JsonProperty("ord_stat")]
		public string? OrderStatus;
		/// <summary>
		/// 예약구분
		/// </summary>
		[JsonProperty("rsrv_tp")]
		public string? ReservationType;
		/// <summary>
		/// 국가명
		/// </summary>
		[JsonProperty("natn_nm")]
		public string? CountryName;
		/// <summary>
		/// 체결시간
		/// </summary>
		[JsonProperty("cntr_time")]
		public string? TradeTime;
	}

	/// <summary>
	/// | ust21530 | 미국주식 실현손익
	/// </summary>
	public record KiwoomUsStockAccountGetRealizedProfitLosses
	{
		/// <summary>
		/// 총매도금액
		/// </summary>
		[JsonProperty("tot_sell_amt")]
		public decimal? TotalSellAmount;
		/// <summary>
		/// 총매수금액
		/// </summary>
		[JsonProperty("tot_buy_amt")]
		public decimal? TotalBuyAmount;
		/// <summary>
		/// 총수수료및세금
		/// </summary>
		[JsonProperty("tot_cmsn_tax")]
		public decimal? TotalCommissionTax;
		/// <summary>
		/// 총정산금액
		/// </summary>
		[JsonProperty("tot_exct_amt")]
		public decimal? TotalSettlementAmount;
		/// <summary>
		/// 총손익금액
		/// </summary>
		[JsonProperty("tot_pl_amt")]
		public decimal? TotalProfitLossAmount;
		/// <summary>
		/// 총손익률
		/// </summary>
		[JsonProperty("tot_pl_rt")]
		public KiwoomDecimal? TotalProfitLossRate;
		/// <summary>
		/// 실현손익리스트
		/// </summary>
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockAccountRealizedProfitLossItem>? Items;
	}

	public record KiwoomUsStockAccountRealizedProfitLossItem
	{
		/// <summary>
		/// 매도일자
		/// </summary>
		[JsonProperty("sell_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? SellDate;
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 해외종목명
		/// </summary>
		[JsonProperty("frgn_stk_nm")]
		public string? ForeignStockName;
		/// <summary>
		/// 매도수량
		/// </summary>
		[JsonProperty("sell_qty")]
		public decimal? SellQuantity;
		/// <summary>
		/// 평균매수단가
		/// </summary>
		[JsonProperty("avg_buy_uv")]
		public decimal? AverageBuyUnitPrice;
		/// <summary>
		/// 매수금액
		/// </summary>
		[JsonProperty("buy_amt")]
		public decimal? BuyAmount;
		/// <summary>
		/// 평균매도단가
		/// </summary>
		[JsonProperty("avg_sell_uv")]
		public decimal? AverageSellUnitPrice;
		/// <summary>
		/// 매도금액
		/// </summary>
		[JsonProperty("sell_amt")]
		public decimal? SellAmount;
		/// <summary>
		/// 수수료및세금
		/// </summary>
		[JsonProperty("cmsn_tax")]
		public decimal? CommissionTax;
		/// <summary>
		/// 손익금액
		/// </summary>
		[JsonProperty("pl_amt")]
		public decimal? ProfitLossAmount;
		/// <summary>
		/// 손익률
		/// </summary>
		[JsonProperty("pl_rt")]
		public KiwoomDecimal? ProfitLossRate;
		/// <summary>
		/// 매입환율
		/// </summary>
		[JsonProperty("prch_exrt")]
		public KiwoomDecimal? PurchaseExchangeRate;
		/// <summary>
		/// 매도환율
		/// </summary>
		[JsonProperty("sell_exrt")]
		public KiwoomDecimal? SellExchangeRate;
		/// <summary>
		/// 원화환산차손익금액
		/// </summary>
		[JsonProperty("krw_chg_dfrn_pl_amt")]
		public decimal? KrwConvertedDifferenceProfitLossAmount;
		/// <summary>
		/// 원화환산손익금액
		/// </summary>
		[JsonProperty("krw_chg_pl_amt")]
		public decimal? KrwConvertedProfitLossAmount;
		/// <summary>
		/// 공통주문구분
		/// </summary>
		[JsonProperty("comm_ord_tp")]
		public string? CommonOrderType;
		/// <summary>
		/// 거래소명
		/// </summary>
		[JsonProperty("stex_nm")]
		public string? ExchangeName;
		/// <summary>
		/// 국가명
		/// </summary>
		[JsonProperty("natn_nm")]
		public string? CountryName;
	}

	/// <summary>
	/// | ust21610 | 미국주식 당일매매
	/// </summary>
	public record KiwoomUsStockAccountGetTodayTrades
	{
		/// <summary>
		/// 총매도금액
		/// </summary>
		[JsonProperty("tot_sell_amt")]
		public decimal? TotalSellAmount;
		/// <summary>
		/// 총매수금액
		/// </summary>
		[JsonProperty("tot_buy_amt")]
		public decimal? TotalBuyAmount;
		/// <summary>
		/// 총수수료및세금
		/// </summary>
		[JsonProperty("tot_cmsn_altx")]
		public decimal? TotalCommissionTax;
		/// <summary>
		/// 총정산금액
		/// </summary>
		[JsonProperty("tot_exct_amt")]
		public decimal? TotalSettlementAmount;
		/// <summary>
		/// 총손익금액
		/// </summary>
		[JsonProperty("tot_pl_amt")]
		public decimal? TotalProfitLossAmount;
		/// <summary>
		/// 총손익률
		/// </summary>
		[JsonProperty("tot_pl_rt")]
		public KiwoomDecimal? TotalProfitLossRate;
		/// <summary>
		/// 환율
		/// </summary>
		[JsonProperty("exch_rate")]
		public KiwoomDecimal? ExchangeRate;
		/// <summary>
		/// 당일매매리스트
		/// </summary>
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockAccountTodayTradeItem>? Items;
	}

	public record KiwoomUsStockAccountTodayTradeItem
	{
		/// <summary>
		/// 거래소명
		/// </summary>
		[JsonProperty("stex_nm")]
		public string? ExchangeName;
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 당일평균매수단가
		/// </summary>
		[JsonProperty("tdy_avg_buy_uv")]
		public decimal? TodayAverageBuyUnitPrice;
		/// <summary>
		/// 당일매수수량
		/// </summary>
		[JsonProperty("tdy_buyq")]
		public decimal? TodayBuyQuantity;
		/// <summary>
		/// 당일매수금액
		/// </summary>
		[JsonProperty("tdy_buy_amt")]
		public decimal? TodayBuyAmount;
		/// <summary>
		/// 당일평균매도단가
		/// </summary>
		[JsonProperty("tdy_avg_sell_uv")]
		public decimal? TodayAverageSellUnitPrice;
		/// <summary>
		/// 당일매도수량
		/// </summary>
		[JsonProperty("tdy_sellq")]
		public decimal? TodaySellQuantity;
		/// <summary>
		/// 당일매도금액
		/// </summary>
		[JsonProperty("tdy_sell_amt")]
		public decimal? TodaySellAmount;
		/// <summary>
		/// 수수료및세금
		/// </summary>
		[JsonProperty("cmsn_altx")]
		public decimal? CommissionTax;
		/// <summary>
		/// 손익금액
		/// </summary>
		[JsonProperty("pl_amt")]
		public decimal? ProfitLossAmount;
		/// <summary>
		/// 손익률
		/// </summary>
		[JsonProperty("pl_rt")]
		public KiwoomDecimal? ProfitLossRate;
		/// <summary>
		/// 전일매입단가
		/// </summary>
		[JsonProperty("bf_prch_uv")]
		public decimal? PreviousDayPurchaseUnitPrice;
		/// <summary>
		/// 환율
		/// </summary>
		[JsonProperty("exch_rate")]
		public KiwoomDecimal? ExchangeRate;
	}

	/// <summary>
	/// | ust21620 | 미국주식 당일매매정리
	/// </summary>
	public record KiwoomUsStockAccountGetTodayTradeSummary
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockAccountTodayTradeSummaryItem>? Items;
	}

	public record KiwoomUsStockAccountTodayTradeSummaryItem
	{
		/// <summary>
		/// 거래소명
		/// </summary>
		[JsonProperty("stex_nm")]
		public string? ExchangeName;
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 매도수구분명
		/// </summary>
		[JsonProperty("slby_tp_nm")]
		public string? SellBuyTypeName;
		/// <summary>
		/// 통화코드
		/// </summary>
		[JsonProperty("crnc_code")]
		public string? CurrencyCode;
		/// <summary>
		/// 체결단가
		/// </summary>
		[JsonProperty("cntr_uv")]
		public decimal? TradeUnitPrice;
		/// <summary>
		/// 체결수량
		/// </summary>
		[JsonProperty("cntr_qty")]
		public decimal? TradeQuantity;
		/// <summary>
		/// 약정금액
		/// </summary>
		[JsonProperty("engg_amt")]
		public decimal? ContractAmount;
		/// <summary>
		/// 수수료
		/// </summary>
		[JsonProperty("cmsn")]
		public decimal? Commission;
		/// <summary>
		/// 제세금
		/// </summary>
		[JsonProperty("altx")]
		public decimal? Tax;
		/// <summary>
		/// 정산금액
		/// </summary>
		[JsonProperty("exct_amt")]
		public decimal? SettlementAmount;
		/// <summary>
		/// 환율
		/// </summary>
		[JsonProperty("exch_rate")]
		public KiwoomDecimal? ExchangeRate;
		/// <summary>
		/// 국가명
		/// </summary>
		[JsonProperty("natn_nm")]
		public string? CountryName;
	}

	/// <summary>
	/// | ust21630 | 미국주식 당일 실현손익
	/// </summary>
	public record KiwoomUsStockAccountGetTodayRealizedProfitLosses
	{
		/// <summary>
		/// 총당일손익금액
		/// </summary>
		[JsonProperty("tot_tdy_pl_amt")]
		public decimal? TotalTodayProfitLossAmount;
		/// <summary>
		/// 총당일손익금액(원화)
		/// </summary>
		[JsonProperty("tot_tdy_pl_amt_krw")]
		public decimal? TotalTodayProfitLossAmountKrw;
		/// <summary>
		/// 당일실현손익리스트
		/// </summary>
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockAccountTodayRealizedProfitLossItem>? Items;
	}

	public record KiwoomUsStockAccountTodayRealizedProfitLossItem
	{
		/// <summary>
		/// 거래소명
		/// </summary>
		[JsonProperty("stex_nm")]
		public string? ExchangeName;
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 통화코드
		/// </summary>
		[JsonProperty("crnc_code")]
		public string? CurrencyCode;
		/// <summary>
		/// 체결매도수량
		/// </summary>
		[JsonProperty("cntr_sellq")]
		public decimal? TradeSellQuantity;
		/// <summary>
		/// 평균매수단가
		/// </summary>
		[JsonProperty("avg_buy_uv")]
		public decimal? AverageBuyUnitPrice;
		/// <summary>
		/// 체결매도금액
		/// </summary>
		[JsonProperty("cntr_sella")]
		public decimal? TradeSellAmount;
		/// <summary>
		/// 당일손익금액
		/// </summary>
		[JsonProperty("tdy_pl_amt")]
		public decimal? TodayProfitLossAmount;
		/// <summary>
		/// 손익률
		/// </summary>
		[JsonProperty("pl_rt")]
		public KiwoomDecimal? ProfitLossRate;
		/// <summary>
		/// 수수료
		/// </summary>
		[JsonProperty("cmsn")]
		public decimal? Commission;
		/// <summary>
		/// 제세금
		/// </summary>
		[JsonProperty("altx")]
		public decimal? Tax;
		/// <summary>
		/// 환율
		/// </summary>
		[JsonProperty("exch_rate")]
		public KiwoomDecimal? ExchangeRate;
		/// <summary>
		/// 국가명
		/// </summary>
		[JsonProperty("natn_nm")]
		public string? CountryName;
	}

	/// <summary>
	/// | ust21640 | 미국주식 일별 종목별 실현손익
	/// </summary>
	public record KiwoomUsStockAccountGetDailyStockRealizedProfitLosses
	{
		/// <summary>
		/// 총손익금액
		/// </summary>
		[JsonProperty("tot_pl_amt")]
		public decimal? TotalProfitLossAmount;
		/// <summary>
		/// 총손익금액(원화)
		/// </summary>
		[JsonProperty("tot_pl_amt_krw")]
		public decimal? TotalProfitLossAmountKrw;
		/// <summary>
		/// 일별종목별손익리스트
		/// </summary>
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockAccountDailyStockRealizedProfitLossItem>? Items;
	}

	public record KiwoomUsStockAccountDailyStockRealizedProfitLossItem
	{
		/// <summary>
		/// 거래소명
		/// </summary>
		[JsonProperty("stex_nm")]
		public string? ExchangeName;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 통화코드
		/// </summary>
		[JsonProperty("crnc_code")]
		public string? CurrencyCode;
		/// <summary>
		/// 체결매도수량
		/// </summary>
		[JsonProperty("cntr_sellq")]
		public decimal? TradeSellQuantity;
		/// <summary>
		/// 평균매수단가
		/// </summary>
		[JsonProperty("avg_buy_uv")]
		public decimal? AverageBuyUnitPrice;
		/// <summary>
		/// 체결매도금액
		/// </summary>
		[JsonProperty("cntr_sella")]
		public decimal? TradeSellAmount;
		/// <summary>
		/// 손익금액
		/// </summary>
		[JsonProperty("pl_amt")]
		public decimal? ProfitLossAmount;
		/// <summary>
		/// 손익률
		/// </summary>
		[JsonProperty("pl_rt")]
		public KiwoomDecimal? ProfitLossRate;
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 수수료
		/// </summary>
		[JsonProperty("cmsn")]
		public decimal? Commission;
		/// <summary>
		/// 제세금
		/// </summary>
		[JsonProperty("altx")]
		public decimal? Tax;
		/// <summary>
		/// 환율
		/// </summary>
		[JsonProperty("exch_rate")]
		public KiwoomDecimal? ExchangeRate;
		/// <summary>
		/// 국가명
		/// </summary>
		[JsonProperty("natn_nm")]
		public string? CountryName;
	}

	/// <summary>
	/// | ust21650 | 미국주식 기간별 수익률 현황
	/// </summary>
	public record KiwoomUsStockAccountGetPeriodProfitRates
	{
		/// <summary>
		/// 시작원화예수금
		/// </summary>
		[JsonProperty("fr_entr")]
		public decimal? FromWonDeposit;
		/// <summary>
		/// 시작원화이연금액
		/// </summary>
		[JsonProperty("fr_dfr_amt")]
		public decimal? FromWonDeferredAmount;
		/// <summary>
		/// 시작원화기타대출금
		/// </summary>
		[JsonProperty("fr_etc_loana")]
		public decimal? FromWonOtherLoanAmount;
		/// <summary>
		/// 시작외화예수금
		/// </summary>
		[JsonProperty("fr_fc_entr")]
		public decimal? FromForeignCurrencyDeposit;
		/// <summary>
		/// 시작외화이연금액
		/// </summary>
		[JsonProperty("fr_fc_dfr_amt")]
		public decimal? FromForeignCurrencyDeferredAmount;
		/// <summary>
		/// 시작외화기타대출금
		/// </summary>
		[JsonProperty("fr_fc_etc_loana")]
		public decimal? FromForeignCurrencyOtherLoanAmount;
		/// <summary>
		/// 시작해외증권평가금액
		/// </summary>
		[JsonProperty("fr_frgn_stk_evltv")]
		public decimal? FromForeignStockEvaluationAmount;
		/// <summary>
		/// 시작총평가금액
		/// </summary>
		[JsonProperty("fr_tot_evltv")]
		public decimal? FromTotalEvaluationAmount;
		/// <summary>
		/// 종료원화예수금
		/// </summary>
		[JsonProperty("to_entr")]
		public decimal? ToWonDeposit;
		/// <summary>
		/// 종료원화이연금액
		/// </summary>
		[JsonProperty("to_dfr_amt")]
		public decimal? ToWonDeferredAmount;
		/// <summary>
		/// 종료원화기타대출금
		/// </summary>
		[JsonProperty("to_etc_loana")]
		public decimal? ToWonOtherLoanAmount;
		/// <summary>
		/// 종료외화예수금
		/// </summary>
		[JsonProperty("to_fc_entr")]
		public decimal? ToForeignCurrencyDeposit;
		/// <summary>
		/// 종료외화이연금액
		/// </summary>
		[JsonProperty("to_fc_dfr_amt")]
		public decimal? ToForeignCurrencyDeferredAmount;
		/// <summary>
		/// 종료외화기타대출금
		/// </summary>
		[JsonProperty("to_fc_etc_loana")]
		public decimal? ToForeignCurrencyOtherLoanAmount;
		/// <summary>
		/// 종료해외증권평가금액
		/// </summary>
		[JsonProperty("to_frgn_stk_evltv")]
		public decimal? ToForeignStockEvaluationAmount;
		/// <summary>
		/// 종료총평가금액
		/// </summary>
		[JsonProperty("to_tot_evltv")]
		public decimal? ToTotalEvaluationAmount;
		/// <summary>
		/// 외화입금액
		/// </summary>
		[JsonProperty("fc_rcpta")]
		public decimal? ForeignCurrencyReceiptAmount;
		/// <summary>
		/// 외화출금액
		/// </summary>
		[JsonProperty("fc_payma")]
		public decimal? ForeignCurrencyPaymentAmount;
		/// <summary>
		/// 환산입금액
		/// </summary>
		[JsonProperty("chg_rcpta")]
		public decimal? ConvertedReceiptAmount;
		/// <summary>
		/// 환산출금액
		/// </summary>
		[JsonProperty("chg_payma")]
		public decimal? ConvertedPaymentAmount;
		/// <summary>
		/// 외화증권입고금액
		/// </summary>
		[JsonProperty("frgn_stk_inqa")]
		public decimal? ForeignStockIncomingAmount;
		/// <summary>
		/// 외화증권출고금액
		/// </summary>
		[JsonProperty("frgn_stk_outqa")]
		public decimal? ForeignStockOutgoingAmount;
		/// <summary>
		/// 투자기준금액
		/// </summary>
		[JsonProperty("invt_bsamt")]
		public decimal? InvestmentBaseAmount;
		/// <summary>
		/// 평가손익
		/// </summary>
		[JsonProperty("evlt_profit")]
		public decimal? EvaluationProfit;
		/// <summary>
		/// 수익률
		/// </summary>
		[JsonProperty("profit_rate")]
		public KiwoomDecimal? ProfitRate;
		/// <summary>
		/// 입출금기준금액
		/// </summary>
		[JsonProperty("io_bsamt")]
		public decimal? DepositWithdrawalBaseAmount;
		/// <summary>
		/// 회전율
		/// </summary>
		[JsonProperty("tern_rt")]
		public KiwoomDecimal? TurnoverRate;
	}

	/// <summary>
	/// | ust21660 | 미국주식 일별 실현손익
	/// </summary>
	public record KiwoomUsStockAccountGetDailyRealizedProfitLosses
	{
		/// <summary>
		/// 총매수금액
		/// </summary>
		[JsonProperty("tot_buy_amt")]
		public decimal? TotalBuyAmount;
		/// <summary>
		/// 총매도금액
		/// </summary>
		[JsonProperty("tot_sell_amt")]
		public decimal? TotalSellAmount;
		/// <summary>
		/// 총손익금액
		/// </summary>
		[JsonProperty("tot_pl_amt")]
		public decimal? TotalProfitLossAmount;
		/// <summary>
		/// 총수수료
		/// </summary>
		[JsonProperty("tot_cmsn")]
		public decimal? TotalCommission;
		/// <summary>
		/// 총세금
		/// </summary>
		[JsonProperty("tot_tax")]
		public decimal? TotalTax;
		/// <summary>
		/// 일별손익리스트
		/// </summary>
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockAccountDailyRealizedProfitLossItem>? Items;
	}

	public record KiwoomUsStockAccountDailyRealizedProfitLossItem
	{
		/// <summary>
		/// 거래일자
		/// </summary>
		[JsonProperty("trde_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? TradeDate;
		/// <summary>
		/// 매수금액
		/// </summary>
		[JsonProperty("buy_amt")]
		public decimal? BuyAmount;
		/// <summary>
		/// 매도금액
		/// </summary>
		[JsonProperty("sell_amt")]
		public decimal? SellAmount;
		/// <summary>
		/// 손익금액
		/// </summary>
		[JsonProperty("pl_amt")]
		public decimal? ProfitLossAmount;
		/// <summary>
		/// 수수료
		/// </summary>
		[JsonProperty("cmsn")]
		public decimal? Commission;
		/// <summary>
		/// 세금
		/// </summary>
		[JsonProperty("tax")]
		public decimal? Tax;
	}

	/// <summary>
	/// | ust21661 | 미국주식 월별 실현손익
	/// </summary>
	public record KiwoomUsStockAccountGetMonthlyRealizedProfitLosses
	{
		/// <summary>
		/// 총매수금액
		/// </summary>
		[JsonProperty("tot_buy_amt")]
		public decimal? TotalBuyAmount;
		/// <summary>
		/// 총매도금액
		/// </summary>
		[JsonProperty("tot_sell_amt")]
		public decimal? TotalSellAmount;
		/// <summary>
		/// 총손익금액
		/// </summary>
		[JsonProperty("tot_pl_amt")]
		public decimal? TotalProfitLossAmount;
		/// <summary>
		/// 총수수료
		/// </summary>
		[JsonProperty("tot_cmsn")]
		public decimal? TotalCommission;
		/// <summary>
		/// 총세금
		/// </summary>
		[JsonProperty("tot_tax")]
		public decimal? TotalTax;
		/// <summary>
		/// 월별손익리스트
		/// </summary>
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockAccountMonthlyRealizedProfitLossItem>? Items;
	}

	public record KiwoomUsStockAccountMonthlyRealizedProfitLossItem
	{
		/// <summary>
		/// 거래년월
		/// </summary>
		[JsonProperty("trde_dt")]
		public string? TradeYearMonth;
		/// <summary>
		/// 매수금액
		/// </summary>
		[JsonProperty("buy_amt")]
		public decimal? BuyAmount;
		/// <summary>
		/// 매도금액
		/// </summary>
		[JsonProperty("sell_amt")]
		public decimal? SellAmount;
		/// <summary>
		/// 손익금액
		/// </summary>
		[JsonProperty("pl_amt")]
		public decimal? ProfitLossAmount;
		/// <summary>
		/// 수수료
		/// </summary>
		[JsonProperty("cmsn")]
		public decimal? Commission;
		/// <summary>
		/// 세금
		/// </summary>
		[JsonProperty("tax")]
		public decimal? Tax;
	}
}
