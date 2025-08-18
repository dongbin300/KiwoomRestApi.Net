using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models
{
	public record KiwoomRealtimeQuoteRequests
	{
		[JsonProperty("trnm")]
		public string ServiceName = string.Empty;
		[JsonProperty("grp_no")]
		public string GroupNumber = string.Empty;
		[JsonProperty("refresh")]
		public string Refresh = string.Empty;
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
		public string ReturnMessage = string.Empty;
		[JsonProperty("trnm")]
		public string ServiceName = string.Empty;
		[JsonProperty("data")]
		public IEnumerable<KiwoomRealtimeQuoteRegistrationItem>? Data;
	}

	public record KiwoomRealtimeQuoteRegistrationItem
	{
		[JsonProperty("type")]
		public string Type = string.Empty;
		[JsonProperty("name")]
		public string Name = string.Empty;
		[JsonProperty("item")]
		public string ItemCode = string.Empty;
		[JsonProperty("values")]
		public IEnumerable<KiwoomRealtimeQuoteValue>? Values;
	}

	public record KiwoomRealtimeQuoteValue
	{
		[JsonProperty("9201")]
		public string AccountNumber = string.Empty;
		[JsonProperty("9001")]
		public string StockOrIndustryCode = string.Empty;
		[JsonProperty("917")]
		public string CreditType = string.Empty;
		[JsonProperty("916")]
		public string LoanDate = string.Empty;
		[JsonProperty("302")]
		public string StockName = string.Empty;
		[JsonProperty("10")]
		public decimal CurrentPrice;
		[JsonProperty("930")]
		public decimal HoldingQuantity;
		[JsonProperty("931")]
		public decimal PurchasePrice;
		[JsonProperty("932")]
		public decimal TotalPurchaseAmount;
		[JsonProperty("933")]
		public decimal OrderableQuantity;
		[JsonProperty("945")]
		public decimal TodayNetBuyQuantity;
		[JsonProperty("946")]
		public string TradeType = string.Empty;
		[JsonProperty("950")]
		public decimal TodayTotalSellProfitLoss;
		[JsonProperty("951")]
		public string ExtraItem1 = string.Empty;
		[JsonProperty("27")]
		public decimal BestSellOfferPrice;
		[JsonProperty("28")]
		public decimal BestBuyOfferPrice;
		[JsonProperty("307")]
		public decimal BasePrice;
		[JsonProperty("8019")]
		public decimal ProfitLossRate;
		[JsonProperty("957")]
		public decimal CreditAmount;
		[JsonProperty("958")]
		public decimal CreditInterest;
		[JsonProperty("918")]
		public string MaturityDate = string.Empty;
		[JsonProperty("990")]
		public decimal TodayRealizedProfitLossCash;
		[JsonProperty("991")]
		public decimal TodayRealizedProfitLossRateCash;
		[JsonProperty("992")]
		public decimal TodayRealizedProfitLossCredit;
		[JsonProperty("993")]
		public decimal TodayRealizedProfitLossRateCredit;
		[JsonProperty("959")]
		public decimal CollateralLoanQuantity;
		[JsonProperty("924")]
		public string ExtraItem2 = string.Empty;
	}

}
