using KiwoomRestApi.Net.Converters;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models
{
	public record KiwoomRealtimeQuoteRequests
	{
		[JsonProperty("trnm")]
		public string? ServiceName;
		[JsonProperty("grp_no")]
		public string? GroupNumber;
		[JsonProperty("refresh")]
		public string? Refresh;
		[JsonProperty("data")]
		public IEnumerable<KiwoomRealtimeQuoteRequestItem>? Data;
	}

	public record KiwoomRealtimeQuoteRequestItem
	{
		[JsonProperty("item")]
		public IEnumerable<string> Items = [];
		[JsonProperty("type")]
		public IEnumerable<string> Types = [];
	}

	public record KiwoomRealtimeQuoteRegistrations
	{
		[JsonProperty("return_code")]
		public int ReturnCode;
		[JsonProperty("return_msg")]
		public string? ReturnMessage;
		[JsonProperty("trnm")]
		public string? ServiceName;
		[JsonProperty("data")]
		public IEnumerable<KiwoomRealtimeQuoteRegistrationItem>? Data;
	}

	public record KiwoomRealtimeQuoteRegistrationItem
	{
		[JsonProperty("type")]
		public string? Type;
		[JsonProperty("name")]
		public string? Name;
		[JsonProperty("item")]
		public string? ItemCode;
		[JsonProperty("values")]
		public IEnumerable<KiwoomRealtimeQuoteValue>? Values;
	}

	public record KiwoomRealtimeQuoteValue
	{
		[JsonProperty("9201")]
		public string? AccountNumber;
		[JsonProperty("9001")]
		public string? StockOrIndustryCode;
		[JsonProperty("917")]
		public string? CreditType;
		[JsonProperty("916")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? LoanDate;
		[JsonProperty("302")]
		public string? StockName;
		[JsonProperty("10")]
		public decimal? CurrentPrice;
		[JsonProperty("930")]
		public decimal? HoldingQuantity;
		[JsonProperty("931")]
		public decimal? PurchasePrice;
		[JsonProperty("932")]
		public decimal? TotalPurchaseAmount;
		[JsonProperty("933")]
		public decimal? OrderableQuantity;
		[JsonProperty("945")]
		public decimal? TodayNetBuyQuantity;
		[JsonProperty("946")]
		public string? TradeType;
		[JsonProperty("950")]
		public decimal? TodayTotalSellProfitLoss;
		[JsonProperty("951")]
		public string? ExtraItem1;
		[JsonProperty("27")]
		public decimal? BestSellOfferPrice;
		[JsonProperty("28")]
		public decimal? BestBuyOfferPrice;
		[JsonProperty("307")]
		public decimal? BasePrice;
		[JsonProperty("8019")]
		public decimal? ProfitLossRate;
		[JsonProperty("957")]
		public decimal? CreditAmount;
		[JsonProperty("958")]
		public decimal? CreditInterest;
		[JsonProperty("918")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? MaturityDate;
		[JsonProperty("990")]
		public decimal? TodayRealizedProfitLossCash;
		[JsonProperty("991")]
		public decimal? TodayRealizedProfitLossRateCash;
		[JsonProperty("992")]
		public decimal? TodayRealizedProfitLossCredit;
		[JsonProperty("993")]
		public decimal? TodayRealizedProfitLossRateCredit;
		[JsonProperty("959")]
		public decimal? CollateralLoanQuantity;
		[JsonProperty("924")]
		public string? ExtraItem2;
	}

}
