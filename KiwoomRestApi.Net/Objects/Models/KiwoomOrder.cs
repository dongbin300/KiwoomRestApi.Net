using Newtonsoft.Json;

namespace KiwoomRestApi.Net.Objects.Models
{
	public record KiwoomOrderPlaceOrder
	{
		[JsonProperty("ord_no")]
		public string? OrderId;
		[JsonProperty("dmst_stex_tp")]
		public string? DomesticExchangeType;
	}

	public record KiwoomOrderModifyOrder
	{
		[JsonProperty("ord_no")]
		public string? OrderId;
		[JsonProperty("base_orig_ord_no")]
		public string? OriginalOrderId;
		[JsonProperty("mdfy_qty")]
		public decimal? ModifyQuantity;
		[JsonProperty("dmst_stex_tp")]
		public string? DomesticExchangeType;
	}

	public record KiwoomOrderCancelOrder
	{
		[JsonProperty("ord_no")]
		public string? OrderId;
		[JsonProperty("base_orig_ord_no")]
		public string? OriginalOrderId;
		[JsonProperty("cncl_qty")]
		public decimal? CancelQuantity;
	}
}
