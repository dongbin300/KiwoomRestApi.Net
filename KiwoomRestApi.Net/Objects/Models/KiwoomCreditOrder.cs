using Newtonsoft.Json;

namespace KiwoomRestApi.Net.Objects.Models
{
	public record KiwoomCreditOrderGetCreditOrder
	{
		[JsonProperty("ord_no")]
		public string? OrderId;
		[JsonProperty("dmst_stex_tp")]
		public string? DomesticExchangeType;
	}

	public record KiwoomCreditOrderGetCreditOrderModification
	{
		[JsonProperty("ord_no")]
		public string? OrderId;
		public string? BaseOriginalOrderId;
		[JsonProperty("mdfy_qty")]
		public decimal? ModifyQuantity;
		[JsonProperty("dmst_stex_tp")]
		public string? DomesticExchangeType;
	}

	public record KiwoomCreditOrderGetCreditOrderCancellation
	{
		[JsonProperty("ord_no")]
		public string? OrderId;
		[JsonProperty("base_orig_ord_no")]
		public string? BaseOriginalOrderId;
		[JsonProperty("cncl_qty")]
		public decimal? CancelQuantity;
	}
}
