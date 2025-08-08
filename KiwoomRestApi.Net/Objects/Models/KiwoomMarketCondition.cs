using KiwoomRestApi.Net.Converters;

using Newtonsoft.Json;

using System;

namespace KiwoomRestApi.Net.Objects.Models
{
	public record KiwoomMarketConditionGetOrderBook
	{
		[JsonProperty("bid_req_base_tm")]
		[JsonConverter(typeof(KiwoomTimeConverter))]
		public TimeSpan BidRequestBaseTime;

		[JsonProperty("sel_10th_pre_req_pre")]
		public decimal AskLevel10PrevDiff;
		[JsonProperty("sel_10th_pre_req")]
		public decimal AskLevel10Quantity;
		[JsonProperty("sel_10th_pre_bid")]
		public decimal AskLevel10Price;

		[JsonProperty("sel_9th_pre_req_pre")]
		public decimal AskLevel9PrevDiff;
		[JsonProperty("sel_9th_pre_req")]
		public decimal AskLevel9Quantity;
		[JsonProperty("sel_9th_pre_bid")]
		public decimal AskLevel9Price;

		[JsonProperty("sel_8th_pre_req_pre")]
		public decimal AskLevel8PrevDiff;
		[JsonProperty("sel_8th_pre_req")]
		public decimal AskLevel8Quantity;
		[JsonProperty("sel_8th_pre_bid")]
		public decimal AskLevel8Price;

		[JsonProperty("sel_7th_pre_req_pre")]
		public decimal AskLevel7PrevDiff;
		[JsonProperty("sel_7th_pre_req")]
		public decimal AskLevel7Quantity;
		[JsonProperty("sel_7th_pre_bid")]
		public decimal AskLevel7Price;

		[JsonProperty("sel_6th_pre_req_pre")]
		public decimal AskLevel6PrevDiff;
		[JsonProperty("sel_6th_pre_req")]
		public decimal AskLevel6Quantity;
		[JsonProperty("sel_6th_pre_bid")]
		public decimal AskLevel6Price;

		[JsonProperty("sel_5th_pre_req_pre")]
		public decimal AskLevel5PrevDiff;
		[JsonProperty("sel_5th_pre_req")]
		public decimal AskLevel5Quantity;
		[JsonProperty("sel_5th_pre_bid")]
		public decimal AskLevel5Price;

		[JsonProperty("sel_4th_pre_req_pre")]
		public decimal AskLevel4PrevDiff;
		[JsonProperty("sel_4th_pre_req")]
		public decimal AskLevel4Quantity;
		[JsonProperty("sel_4th_pre_bid")]
		public decimal AskLevel4Price;

		[JsonProperty("sel_3th_pre_req_pre")]
		public decimal AskLevel3PrevDiff;
		[JsonProperty("sel_3th_pre_req")]
		public decimal AskLevel3Quantity;
		[JsonProperty("sel_3th_pre_bid")]
		public decimal AskLevel3Price;

		[JsonProperty("sel_2th_pre_req_pre")]
		public decimal AskLevel2PrevDiff;
		[JsonProperty("sel_2th_pre_req")]
		public decimal AskLevel2Quantity;
		[JsonProperty("sel_2th_pre_bid")]
		public decimal AskLevel2Price;

		[JsonProperty("sel_1th_pre_req_pre")]
		public decimal AskLevel1PrevDiff;
		[JsonProperty("sel_fpr_req")]
		public decimal AskLevel1Quantity;
		[JsonProperty("sel_fpr_bid")]
		public decimal AskLevel1Price;

		[JsonProperty("buy_fpr_bid")]
		public decimal BidLevel1Price;
		[JsonProperty("buy_fpr_req")]
		public decimal BidLevel1Quantity;
		[JsonProperty("buy_1th_pre_req_pre")]
		public decimal BidLevel1PrevDiff;

		[JsonProperty("buy_2th_pre_bid")]
		public decimal BidLevel2Price;
		[JsonProperty("buy_2th_pre_req")]
		public decimal BidLevel2Quantity;
		[JsonProperty("buy_2th_pre_req_pre")]
		public decimal BidLevel2PrevDiff;

		[JsonProperty("buy_3th_pre_bid")]
		public decimal BidLevel3Price;
		[JsonProperty("buy_3th_pre_req")]
		public decimal BidLevel3Quantity;
		[JsonProperty("buy_3th_pre_req_pre")]
		public decimal BidLevel3PrevDiff;

		[JsonProperty("buy_4th_pre_bid")]
		public decimal BidLevel4Price;
		[JsonProperty("buy_4th_pre_req")]
		public decimal BidLevel4Quantity;
		[JsonProperty("buy_4th_pre_req_pre")]
		public decimal BidLevel4PrevDiff;

		[JsonProperty("buy_5th_pre_bid")]
		public decimal BidLevel5Price;
		[JsonProperty("buy_5th_pre_req")]
		public decimal BidLevel5Quantity;
		[JsonProperty("buy_5th_pre_req_pre")]
		public decimal BidLevel5PrevDiff;

		[JsonProperty("buy_6th_pre_bid")]
		public decimal BidLevel6Price;
		[JsonProperty("buy_6th_pre_req")]
		public decimal BidLevel6Quantity;
		[JsonProperty("buy_6th_pre_req_pre")]
		public decimal BidLevel6PrevDiff;

		[JsonProperty("buy_7th_pre_bid")]
		public decimal BidLevel7Price;
		[JsonProperty("buy_7th_pre_req")]
		public decimal BidLevel7Quantity;
		[JsonProperty("buy_7th_pre_req_pre")]
		public decimal BidLevel7PrevDiff;

		[JsonProperty("buy_8th_pre_bid")]
		public decimal BidLevel8Price;
		[JsonProperty("buy_8th_pre_req")]
		public decimal BidLevel8Quantity;
		[JsonProperty("buy_8th_pre_req_pre")]
		public decimal BidLevel8PrevDiff;

		[JsonProperty("buy_9th_pre_bid")]
		public decimal BidLevel9Price;
		[JsonProperty("buy_9th_pre_req")]
		public decimal BidLevel9Quantity;
		[JsonProperty("buy_9th_pre_req_pre")]
		public decimal BidLevel9PrevDiff;

		[JsonProperty("buy_10th_pre_bid")]
		public decimal BidLevel10Price;
		[JsonProperty("buy_10th_pre_req")]
		public decimal BidLevel10Quantity;
		[JsonProperty("buy_10th_pre_req_pre")]
		public decimal BidLevel10PrevDiff;

		[JsonProperty("tot_sel_req_jub_pre")]
		public decimal TotalAskQuantityPrevDiff;
		[JsonProperty("tot_sel_req")]
		public decimal TotalAskQuantity;
		[JsonProperty("tot_buy_req")]
		public decimal TotalBidQuantity;
		[JsonProperty("tot_buy_req_jub_pre")]
		public decimal TotalBidQuantityPrevDiff;

		[JsonProperty("ovt_sel_req_pre")]
		public decimal AfterHoursAskQuantityPrevDiff;
		[JsonProperty("ovt_sel_req")]
		public decimal AfterHoursAskQuantity;
		[JsonProperty("ovt_buy_req")]
		public decimal AfterHoursBidQuantity;
		[JsonProperty("ovt_buy_req_pre")]
		public decimal AfterHoursBidQuantityPrevDiff;
	}

	public record PriceVolumeDiff
	{
		public decimal Price;
		public decimal Quantity;
		public decimal PrevDiff;

		public PriceVolumeDiff(decimal price, decimal quantity, decimal prevDiff)
		{
			Price = price;
			Quantity = quantity;
			PrevDiff = prevDiff;
		}
	}

	public record KiwoomMarketConditionGetOrderBookList
	{
		public TimeSpan BidRequestBaseTime;
		public PriceVolumeDiff[] AskLevels;
		public PriceVolumeDiff[] BidLevels;
		public decimal TotalAskQuantityPrevDiff;
		public decimal TotalAskQuantity;
		public decimal TotalBidQuantity;
		public decimal TotalBidQuantityPrevDiff;
		public decimal AfterHoursAskQuantityPrevDiff;
		public decimal AfterHoursAskQuantity;
		public decimal AfterHoursBidQuantity;
		public decimal AfterHoursBidQuantityPrevDiff;

		public KiwoomMarketConditionGetOrderBookList(KiwoomMarketConditionGetOrderBook raw)
		{
			BidRequestBaseTime = raw.BidRequestBaseTime;

			AskLevels =
			[
				new(raw.AskLevel1Price, raw.AskLevel1Quantity, raw.AskLevel1PrevDiff),
				new(raw.AskLevel2Price, raw.AskLevel2Quantity, raw.AskLevel2PrevDiff),
				new(raw.AskLevel3Price, raw.AskLevel3Quantity, raw.AskLevel3PrevDiff),
				new(raw.AskLevel4Price, raw.AskLevel4Quantity, raw.AskLevel4PrevDiff),
				new(raw.AskLevel5Price, raw.AskLevel5Quantity, raw.AskLevel5PrevDiff),
				new(raw.AskLevel6Price, raw.AskLevel6Quantity, raw.AskLevel6PrevDiff),
				new(raw.AskLevel7Price, raw.AskLevel7Quantity, raw.AskLevel7PrevDiff),
				new(raw.AskLevel8Price, raw.AskLevel8Quantity, raw.AskLevel8PrevDiff),
				new(raw.AskLevel9Price, raw.AskLevel9Quantity, raw.AskLevel9PrevDiff),
				new(raw.AskLevel10Price, raw.AskLevel10Quantity, raw.AskLevel10PrevDiff)
			];

			BidLevels =
			[
				new(raw.BidLevel1Price, raw.BidLevel1Quantity, raw.BidLevel1PrevDiff),
				new(raw.BidLevel2Price, raw.BidLevel2Quantity, raw.BidLevel2PrevDiff),
				new(raw.BidLevel3Price, raw.BidLevel3Quantity, raw.BidLevel3PrevDiff),
				new(raw.BidLevel4Price, raw.BidLevel4Quantity, raw.BidLevel4PrevDiff),
				new(raw.BidLevel5Price, raw.BidLevel5Quantity, raw.BidLevel5PrevDiff),
				new(raw.BidLevel6Price, raw.BidLevel6Quantity, raw.BidLevel6PrevDiff),
				new(raw.BidLevel7Price, raw.BidLevel7Quantity, raw.BidLevel7PrevDiff),
				new(raw.BidLevel8Price, raw.BidLevel8Quantity, raw.BidLevel8PrevDiff),
				new(raw.BidLevel9Price, raw.BidLevel9Quantity, raw.BidLevel9PrevDiff),
				new(raw.BidLevel10Price, raw.BidLevel10Quantity, raw.BidLevel10PrevDiff)
			];

			TotalAskQuantityPrevDiff = raw.TotalAskQuantityPrevDiff;
			TotalAskQuantity = raw.TotalAskQuantity;
			TotalBidQuantity = raw.TotalBidQuantity;
			TotalBidQuantityPrevDiff = raw.TotalBidQuantityPrevDiff;
			AfterHoursAskQuantityPrevDiff = raw.AfterHoursAskQuantityPrevDiff;
			AfterHoursAskQuantity = raw.AfterHoursAskQuantity;
			AfterHoursBidQuantity = raw.AfterHoursBidQuantity;
			AfterHoursBidQuantityPrevDiff = raw.AfterHoursBidQuantityPrevDiff;
		}
	}
}
