using KiwoomRestApi.Net.Converters;

using Newtonsoft.Json;

namespace KiwoomRestApi.Net.Objects.Models.UsStock
{
	public record KiwoomUsStockOrderBuyOrder
	{
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 주문번호 (취소 혹은 정정 주문 시 사용)
		/// </summary>
		[JsonProperty("ord_no")]
		public string? OrderId;
		/// <summary>
		/// 외화예수금
		/// </summary>
		[JsonProperty("fc_entra")]
		public decimal? ForeignCurrencyDeposit;
		/// <summary>
		/// 금일재매수사용금액
		/// </summary>
		[JsonProperty("tdy_rebuy_useda")]
		public decimal? TodayRebuyUsedAmount;
		/// <summary>
		/// 전일재매수사용금액
		/// </summary>
		[JsonProperty("pred_rebuy_useda")]
		public decimal? PreviousDayRebuyUsedAmount;
		/// <summary>
		/// 사용증거금
		/// </summary>
		[JsonProperty("trst_prof_ch")]
		public decimal? UsedMargin;
	}

	public record KiwoomUsStockOrderSellOrder
	{
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 주문번호 (취소 혹은 정정 주문 시 사용)
		/// </summary>
		[JsonProperty("ord_no")]
		public string? OrderId;
		/// <summary>
		/// 보유수량
		/// </summary>
		[JsonProperty("poss_qty")]
		public decimal? PossessionQuantity;
		/// <summary>
		/// 금일재매도사용수량
		/// </summary>
		[JsonProperty("tdy_resel_usedq")]
		public decimal? TodayResellUsedQuantity;
		/// <summary>
		/// 전일재매도사용수량
		/// </summary>
		[JsonProperty("pred_resel_usedq")]
		public decimal? PreviousDayResellUsedQuantity;
	}

	public record KiwoomUsStockOrderModifyOrder
	{
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 주문번호 (취소 혹은 정정 주문 시 사용)
		/// </summary>
		[JsonProperty("ord_no")]
		public string? OrderId;
		/// <summary>
		/// 외화예수금
		/// </summary>
		[JsonProperty("fc_entra")]
		public decimal? ForeignCurrencyDeposit;
		/// <summary>
		/// 금일재매수사용금액
		/// </summary>
		[JsonProperty("tdy_rebuy_useda")]
		public decimal? TodayRebuyUsedAmount;
		/// <summary>
		/// 전일재매수사용금액
		/// </summary>
		[JsonProperty("pred_rebuy_useda")]
		public decimal? PreviousDayRebuyUsedAmount;
		/// <summary>
		/// 사용증거금
		/// </summary>
		[JsonProperty("trst_prof_ch")]
		public decimal? UsedMargin;
		/// <summary>
		/// 정정주문수량
		/// </summary>
		[JsonProperty("mdfy_ord_qty")]
		public decimal? ModifyOrderQuantity;
	}

	public record KiwoomUsStockOrderCancelOrder
	{
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 주문번호
		/// </summary>
		[JsonProperty("ord_no")]
		public string? OrderId;
		/// <summary>
		/// 취소주문수량
		/// </summary>
		[JsonProperty("cncl_ord_qty")]
		public decimal? CancelOrderQuantity;
	}

	public record KiwoomUsStockOrderAvailableQuantity
	{
		/// <summary>
		/// 종목증거금율
		/// </summary>
		[JsonProperty("stk_profa_rt")]
		[JsonConverter(typeof(KiwoomPercentConverter))]
		public decimal? StockMarginRate;
		/// <summary>
		/// 계좌증거금율
		/// </summary>
		[JsonProperty("profa_rt")]
		public string? AccountMarginRate;
		/// <summary>
		/// 적용증거금율
		/// </summary>
		[JsonProperty("aplc_rt")]
		[JsonConverter(typeof(KiwoomPercentConverter))]
		public decimal? AppliedMarginRate;
		/// <summary>
		/// 원화주문신청여부 (Y, N)
		/// </summary>
		[JsonProperty("krw_ord_rqst_yn")]
		public string? KrwOrderRequestYn;
		/// <summary>
		/// 증거금50%종목 원화주문가능금액
		/// </summary>
		[JsonProperty("krw_ord_alowa_50")]
		public decimal? KrwOrderAvailableAmount50;
		/// <summary>
		/// 증거금50%종목 원화주문가능수량
		/// </summary>
		[JsonProperty("krw_ord_alowq_50")]
		public decimal? KrwOrderAvailableQuantity50;
		/// <summary>
		/// 증거금50%종목 주문가능금액
		/// </summary>
		[JsonProperty("ord_alowa_50")]
		public decimal? OrderAvailableAmount50;
		/// <summary>
		/// 증거금50%종목 주문가능수량
		/// </summary>
		[JsonProperty("ord_alowq_50")]
		public decimal? OrderAvailableQuantity50;
		/// <summary>
		/// 증거금50%종목 전일재사용금액
		/// </summary>
		[JsonProperty("pred_rebuy_alowa_50")]
		public decimal? PreviousDayRebuyAvailableAmount50;
		/// <summary>
		/// 증거금50%종목 금일재사용금액
		/// </summary>
		[JsonProperty("tdy_rebuy_alowa_50")]
		public decimal? TodayRebuyAvailableAmount50;
		/// <summary>
		/// 증거금100%종목 원화주문가능금액
		/// </summary>
		[JsonProperty("krw_ord_alowa_100")]
		public decimal? KrwOrderAvailableAmount100;
		/// <summary>
		/// 증거금100%종목 원화주문가능수량
		/// </summary>
		[JsonProperty("krw_ord_alowq_100")]
		public decimal? KrwOrderAvailableQuantity100;
		/// <summary>
		/// 증거금100%종목 주문가능금액
		/// </summary>
		[JsonProperty("ord_alowa_100")]
		public decimal? OrderAvailableAmount100;
		/// <summary>
		/// 증거금100%종목 주문가능수량
		/// </summary>
		[JsonProperty("ord_alowq_100")]
		public decimal? OrderAvailableQuantity100;
		/// <summary>
		/// 증거금100%종목 전일재사용금액
		/// </summary>
		[JsonProperty("pred_rebuy_alowa_100")]
		public decimal? PreviousDayRebuyAvailableAmount100;
		/// <summary>
		/// 증거금100%종목 금일재사용금액
		/// </summary>
		[JsonProperty("tdy_rebuy_alowa_100")]
		public decimal? TodayRebuyAvailableAmount100;
		/// <summary>
		/// 미수불가 원화주문가능금액
		/// </summary>
		[JsonProperty("min_krw_ord_alowa")]
		public decimal? MinKrwOrderAvailableAmount;
		/// <summary>
		/// 미수불가 원화주문가능수량
		/// </summary>
		[JsonProperty("min_krw_ord_alowq")]
		public decimal? MinKrwOrderAvailableQuantity;
		/// <summary>
		/// 미수불가 주문가능금액
		/// </summary>
		[JsonProperty("min_ord_alowa")]
		public decimal? MinOrderAvailableAmount;
		/// <summary>
		/// 미수불가 주문가능수량
		/// </summary>
		[JsonProperty("min_ord_alowq")]
		public decimal? MinOrderAvailableQuantity;
		/// <summary>
		/// 미수불가 전일재사용금액
		/// </summary>
		[JsonProperty("min_pred_rebuy_alowa")]
		public decimal? MinPreviousDayRebuyAvailableAmount;
		/// <summary>
		/// 미수불가 금일재사용금액
		/// </summary>
		[JsonProperty("min_tdy_rebuy_alowa")]
		public decimal? MinTodayRebuyAvailableAmount;
		/// <summary>
		/// 원화예수금
		/// </summary>
		[JsonProperty("krw_entra")]
		public decimal? KrwDeposit;
		/// <summary>
		/// 외화예수금
		/// </summary>
		[JsonProperty("fc_entra")]
		public decimal? ForeignCurrencyDeposit;
		/// <summary>
		/// 외화미수금
		/// </summary>
		[JsonProperty("fc_uncl_amt")]
		public decimal? ForeignCurrencyUnclearedAmount;
		/// <summary>
		/// 주문가능현금
		/// </summary>
		[JsonProperty("ord_alowa")]
		public decimal? OrderAvailableCash;
		/// <summary>
		/// 해외원화주문설정금
		/// </summary>
		[JsonProperty("krw_ord_set_amt")]
		public decimal? OverseasKrwOrderSetAmount;
		/// <summary>
		/// 해외원화주문평가금
		/// </summary>
		[JsonProperty("krw_ord_evlt_amt")]
		public decimal? OverseasKrwOrderEvaluationAmount;
		/// <summary>
		/// 통화
		/// </summary>
		[JsonProperty("crnc_code")]
		public string? CurrencyCode;
	}
}
