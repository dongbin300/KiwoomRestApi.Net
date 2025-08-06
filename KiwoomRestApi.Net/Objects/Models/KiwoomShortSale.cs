using KiwoomRestApi.Net.Converters;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models
{
	public record KiwoomShortSaleGetShortsTransactions
	{
		[JsonProperty("shrts_trnsn")]
		public IEnumerable<KiwoomShortSaleGetShortsTransactionItem>? Items;
	}
	public record KiwoomShortSaleGetShortsTransactionItem
	{
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateConverter))]
		public DateTime Date;
		[JsonProperty("close_pric")]
		public decimal ClosePrice;
		[JsonProperty("pred_pre_sig")]
		public string PreviousDayChangeSign = string.Empty;
		[JsonProperty("pred_pre")]
		public decimal PreviousDayChange;
		[JsonProperty("flu_rt")]
		public decimal FluctuationRate;
		[JsonProperty("trde_qty")]
		public decimal TradeQuantity;
		[JsonProperty("shrts_qty")]
		public decimal ShortsQuantity;
		[JsonProperty("ovr_shrts_qty")]
		public decimal AccumulatedShortsQuantity;
		[JsonProperty("trde_wght")]
		public decimal TradeWeight;
		[JsonProperty("shrts_trde_prica")]
		public decimal ShortsTradeAmount;
		[JsonProperty("shrts_avg_pric")]
		public decimal ShortsAveragePrice;
	}
}
