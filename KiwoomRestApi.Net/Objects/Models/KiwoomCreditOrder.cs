using Newtonsoft.Json;

namespace KiwoomRestApi.Net.Objects.Models
{
	public record KiwoomCreditOrderGetCreditOrder
	{
		[JsonProperty("ord_no")]
		public string OrderId = string.Empty;
		[JsonProperty("dmst_stex_tp")]
		public string DomesticExchangeType = string.Empty;
	}

	public record KiwoomCreditOrderGetCreditOrderModification
	{
		[JsonProperty("ord_no")]
		public string OrderId = string.Empty;
		[JsonProperty("base_orig_ord_no")]
		public string BaseOriginalOrderId = string.Empty;
		[JsonProperty("mdfy_qty")]
		public decimal? ModifyQuantity;
		[JsonProperty("dmst_stex_tp")]
		public string DomesticExchangeType = string.Empty;
	}

	public record KiwoomCreditOrderGetCreditOrderCancellation
	{
		[JsonProperty("ord_no")]
		public string OrderId = string.Empty;
		[JsonProperty("base_orig_ord_no")]
		public string BaseOriginalOrderId = string.Empty;
		[JsonProperty("cncl_qty")]
		public decimal? CancelQuantity;
	}
}
