using Newtonsoft.Json;

namespace KiwoomRestApi.Net.Objects.Models
{
	public record KiwoomCreditOrderPlaceOrder
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[JsonProperty("ord_no")]
		public string? OrderId;
		/// <summary>
		/// 국내거래소구분
		/// </summary>
		[JsonProperty("dmst_stex_tp")]
		public string? DomesticExchangeType;
	}

	public record KiwoomCreditOrderModifyOrder
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[JsonProperty("ord_no")]
		public string? OrderId;
		/// <summary>
		/// 모주문번호
		/// </summary>
		[JsonProperty("base_orig_ord_no")]
		public string? OriginalOrderId;
		/// <summary>
		/// 정정수량
		/// </summary>
		[JsonProperty("mdfy_qty")]
		public decimal? ModifyQuantity;
		/// <summary>
		/// 국내거래소구분
		/// </summary>
		[JsonProperty("dmst_stex_tp")]
		public string? DomesticExchangeType;
	}

	public record KiwoomCreditOrderCancelOrder
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[JsonProperty("ord_no")]
		public string? OrderId;
		/// <summary>
		/// 모주문번호
		/// </summary>
		[JsonProperty("base_orig_ord_no")]
		public string? OriginalOrderId;
		/// <summary>
		/// 취소수량
		/// </summary>
		[JsonProperty("cncl_qty")]
		public decimal? CancelQuantity;
	}
}
