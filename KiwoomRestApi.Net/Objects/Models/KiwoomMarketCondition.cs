using KiwoomRestApi.Net.Converters;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models
{
	public record KiwoomMarketConditionGetOrderBook
	{
		[JsonProperty("bid_req_base_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
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

	public record KiwoomMarketConditionGetDailyWeeklyMonthly
	{
		[JsonProperty("date")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		[JsonProperty("open_pric")]
		public decimal OpenPrice;
		[JsonProperty("high_pric")]
		public decimal HighPrice;
		[JsonProperty("low_pric")]
		public decimal LowPrice;
		[JsonProperty("close_pric")]
		public decimal ClosePrice;
		[JsonProperty("pre")]
		public decimal PrevDiff;
		[JsonProperty("flu_rt")]
		public decimal FluctuationRate;
		[JsonProperty("trde_qty")]
		public decimal TradeQuantity;
		[JsonProperty("trde_prica")]
		public decimal TradeAmount;
		[JsonProperty("for_poss")]
		public decimal ForeignPossession;
		[JsonProperty("for_wght")]
		public decimal ForeignWeight;
		[JsonProperty("for_netprps")]
		public decimal ForeignNetPurchase;
		[JsonProperty("orgn_netprps")]
		public decimal InstitutionNetPurchase;
		[JsonProperty("ind_netprps")]
		public decimal IndividualNetPurchase;
		[JsonProperty("crd_remn_rt")]
		public decimal CreditRemainingRate;
		[JsonProperty("frgn")]
		public decimal ForeignBrokerage;
		[JsonProperty("prm")]
		public decimal ProgramTrading;
	}

	public record KiwoomMarketConditionGetHourMinute
	{
		[JsonProperty("date")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		[JsonProperty("open_pric")]
		public decimal OpenPrice;
		[JsonProperty("high_pric")]
		public decimal HighPrice;
		[JsonProperty("low_pric")]
		public decimal LowPrice;
		[JsonProperty("close_pric")]
		public decimal ClosePrice;
		[JsonProperty("pre")]
		public decimal PrevDiff;
		[JsonProperty("flu_rt")]
		public decimal FluctuationRate;
		[JsonProperty("trde_qty")]
		public decimal TradeQuantity;
		[JsonProperty("trde_prica")]
		public decimal TradeAmount;
		[JsonProperty("cntr_str")]
		public decimal ContractStrength;
	}

	public record KiwoomMarketConditionGetQuote
	{
		[JsonProperty("stk_nm")]
		public string StockName = string.Empty;
		[JsonProperty("stk_cd")]
		public string StockCode = string.Empty;
		[JsonProperty("date")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		[JsonProperty("tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan Time;
		[JsonProperty("pred_close_pric")]
		public decimal? PrevClosePrice;
		[JsonProperty("pred_trde_qty")]
		public decimal? PrevTradeQuantity;
		[JsonProperty("upl_pric")]
		public decimal? UpperPrice;
		[JsonProperty("lst_pric")]
		public decimal? LowerPrice;
		[JsonProperty("pred_trde_prica")]
		public decimal? PrevTradeAmount;
		[JsonProperty("flo_stkcnt")]
		public decimal? ListedShares;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("smbol")]
		public string Sign = string.Empty;
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		[JsonProperty("pred_rt")]
		public decimal? PrevRate;
		[JsonProperty("open_pric")]
		public decimal? OpenPrice;
		[JsonProperty("high_pric")]
		public decimal? HighPrice;
		[JsonProperty("low_pric")]
		public decimal? LowPrice;
		[JsonProperty("cntr_qty")]
		public decimal? ContractQuantity;
		[JsonProperty("trde_qty")]
		public decimal? TradeQuantity;
		[JsonProperty("trde_prica")]
		public decimal? TradeAmount;
		[JsonProperty("exp_cntr_pric")]
		public decimal? ExpectedContractPrice;
		[JsonProperty("exp_cntr_qty")]
		public decimal? ExpectedContractQuantity;
		[JsonProperty("exp_sel_pri_bid")]
		public decimal? ExpectedSellPriorityBid;
		[JsonProperty("exp_buy_pri_bid")]
		public decimal? ExpectedBuyPriorityBid;
		[JsonProperty("trde_strt_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? TradeStartDate;
		[JsonProperty("exec_pric")]
		public decimal? ExercisePrice;
		[JsonProperty("hgst_pric")]
		public decimal? HighestPrice;
		[JsonProperty("lwst_pric")]
		public decimal? LowestPrice;
		[JsonProperty("hgst_pric_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? HighestPriceDate;
		[JsonProperty("lwst_pric_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? LowestPriceDate;

		[JsonProperty("sel_1bid")]
		public decimal? Sell1Price;
		[JsonProperty("sel_2bid")]
		public decimal? Sell2Price;
		[JsonProperty("sel_3bid")]
		public decimal? Sell3Price;
		[JsonProperty("sel_4bid")]
		public decimal? Sell4Price;
		[JsonProperty("sel_5bid")]
		public decimal? Sell5Price;
		[JsonProperty("sel_6bid")]
		public decimal? Sell6Price;
		[JsonProperty("sel_7bid")]
		public decimal? Sell7Price;
		[JsonProperty("sel_8bid")]
		public decimal? Sell8Price;
		[JsonProperty("sel_9bid")]
		public decimal? Sell9Price;
		[JsonProperty("sel_10bid")]
		public decimal? Sell10Price;

		[JsonProperty("buy_1bid")]
		public decimal? Buy1Price;
		[JsonProperty("buy_2bid")]
		public decimal? Buy2Price;
		[JsonProperty("buy_3bid")]
		public decimal? Buy3Price;
		[JsonProperty("buy_4bid")]
		public decimal? Buy4Price;
		[JsonProperty("buy_5bid")]
		public decimal? Buy5Price;
		[JsonProperty("buy_6bid")]
		public decimal? Buy6Price;
		[JsonProperty("buy_7bid")]
		public decimal? Buy7Price;
		[JsonProperty("buy_8bid")]
		public decimal? Buy8Price;
		[JsonProperty("buy_9bid")]
		public decimal? Buy9Price;
		[JsonProperty("buy_10bid")]
		public decimal? Buy10Price;

		[JsonProperty("sel_1bid_req")]
		public decimal? Sell1Quantity;
		[JsonProperty("sel_2bid_req")]
		public decimal? Sell2Quantity;
		[JsonProperty("sel_3bid_req")]
		public decimal? Sell3Quantity;
		[JsonProperty("sel_4bid_req")]
		public decimal? Sell4Quantity;
		[JsonProperty("sel_5bid_req")]
		public decimal? Sell5Quantity;
		[JsonProperty("sel_6bid_req")]
		public decimal? Sell6Quantity;
		[JsonProperty("sel_7bid_req")]
		public decimal? Sell7Quantity;
		[JsonProperty("sel_8bid_req")]
		public decimal? Sell8Quantity;
		[JsonProperty("sel_9bid_req")]
		public decimal? Sell9Quantity;
		[JsonProperty("sel_10bid_req")]
		public decimal? Sell10Quantity;

		[JsonProperty("buy_1bid_req")]
		public decimal? Buy1Quantity;
		[JsonProperty("buy_2bid_req")]
		public decimal? Buy2Quantity;
		[JsonProperty("buy_3bid_req")]
		public decimal? Buy3Quantity;
		[JsonProperty("buy_4bid_req")]
		public decimal? Buy4Quantity;
		[JsonProperty("buy_5bid_req")]
		public decimal? Buy5Quantity;
		[JsonProperty("buy_6bid_req")]
		public decimal? Buy6Quantity;
		[JsonProperty("buy_7bid_req")]
		public decimal? Buy7Quantity;
		[JsonProperty("buy_8bid_req")]
		public decimal? Buy8Quantity;
		[JsonProperty("buy_9bid_req")]
		public decimal? Buy9Quantity;
		[JsonProperty("buy_10bid_req")]
		public decimal? Buy10Quantity;

		[JsonProperty("sel_1bid_jub_pre")]
		public decimal? Sell1PrevDiff;
		[JsonProperty("sel_2bid_jub_pre")]
		public decimal? Sell2PrevDiff;
		[JsonProperty("sel_3bid_jub_pre")]
		public decimal? Sell3PrevDiff;
		[JsonProperty("sel_4bid_jub_pre")]
		public decimal? Sell4PrevDiff;
		[JsonProperty("sel_5bid_jub_pre")]
		public decimal? Sell5PrevDiff;
		[JsonProperty("sel_6bid_jub_pre")]
		public decimal? Sell6PrevDiff;
		[JsonProperty("sel_7bid_jub_pre")]
		public decimal? Sell7PrevDiff;
		[JsonProperty("sel_8bid_jub_pre")]
		public decimal? Sell8PrevDiff;
		[JsonProperty("sel_9bid_jub_pre")]
		public decimal? Sell9PrevDiff;
		[JsonProperty("sel_10bid_jub_pre")]
		public decimal? Sell10PrevDiff;

		[JsonProperty("buy_1bid_jub_pre")]
		public decimal? Buy1PrevDiff;
		[JsonProperty("buy_2bid_jub_pre")]
		public decimal? Buy2PrevDiff;
		[JsonProperty("buy_3bid_jub_pre")]
		public decimal? Buy3PrevDiff;
		[JsonProperty("buy_4bid_jub_pre")]
		public decimal? Buy4PrevDiff;
		[JsonProperty("buy_5bid_jub_pre")]
		public decimal? Buy5PrevDiff;
		[JsonProperty("buy_6bid_jub_pre")]
		public decimal? Buy6PrevDiff;
		[JsonProperty("buy_7bid_jub_pre")]
		public decimal? Buy7PrevDiff;
		[JsonProperty("buy_8bid_jub_pre")]
		public decimal? Buy8PrevDiff;
		[JsonProperty("buy_9bid_jub_pre")]
		public decimal? Buy9PrevDiff;
		[JsonProperty("buy_10bid_jub_pre")]
		public decimal? Buy10PrevDiff;

		[JsonProperty("sel_1bid_cnt")]
		public decimal? Sell1Count;
		[JsonProperty("sel_2bid_cnt")]
		public decimal? Sell2Count;
		[JsonProperty("sel_3bid_cnt")]
		public decimal? Sell3Count;
		[JsonProperty("sel_4bid_cnt")]
		public decimal? Sell4Count;
		[JsonProperty("sel_5bid_cnt")]
		public decimal? Sell5Count;

		[JsonProperty("buy_1bid_cnt")]
		public decimal? Buy1Count;
		[JsonProperty("buy_2bid_cnt")]
		public decimal? Buy2Count;
		[JsonProperty("buy_3bid_cnt")]
		public decimal? Buy3Count;
		[JsonProperty("buy_4bid_cnt")]
		public decimal? Buy4Count;
		[JsonProperty("buy_5bid_cnt")]
		public decimal? Buy5Count;

		[JsonProperty("lpsel_1bid_req")]
		public decimal? LpSell1Quantity;
		[JsonProperty("lpsel_2bid_req")]
		public decimal? LpSell2Quantity;
		[JsonProperty("lpsel_3bid_req")]
		public decimal? LpSell3Quantity;
		[JsonProperty("lpsel_4bid_req")]
		public decimal? LpSell4Quantity;
		[JsonProperty("lpsel_5bid_req")]
		public decimal? LpSell5Quantity;
		[JsonProperty("lpsel_6bid_req")]
		public decimal? LpSell6Quantity;
		[JsonProperty("lpsel_7bid_req")]
		public decimal? LpSell7Quantity;
		[JsonProperty("lpsel_8bid_req")]
		public decimal? LpSell8Quantity;
		[JsonProperty("lpsel_9bid_req")]
		public decimal? LpSell9Quantity;
		[JsonProperty("lpsel_10bid_req")]
		public decimal? LpSell10Quantity;

		[JsonProperty("lpbuy_1bid_req")]
		public decimal? LpBuy1Quantity;
		[JsonProperty("lpbuy_2bid_req")]
		public decimal? LpBuy2Quantity;
		[JsonProperty("lpbuy_3bid_req")]
		public decimal? LpBuy3Quantity;
		[JsonProperty("lpbuy_4bid_req")]
		public decimal? LpBuy4Quantity;
		[JsonProperty("lpbuy_5bid_req")]
		public decimal? LpBuy5Quantity;
		[JsonProperty("lpbuy_6bid_req")]
		public decimal? LpBuy6Quantity;
		[JsonProperty("lpbuy_7bid_req")]
		public decimal? LpBuy7Quantity;
		[JsonProperty("lpbuy_8bid_req")]
		public decimal? LpBuy8Quantity;
		[JsonProperty("lpbuy_9bid_req")]
		public decimal? LpBuy9Quantity;
		[JsonProperty("lpbuy_10bid_req")]
		public decimal? LpBuy10Quantity;

		[JsonProperty("tot_buy_req")]
		public decimal? TotalBuyQuantity;
		[JsonProperty("tot_sel_req")]
		public decimal? TotalSellQuantity;
		[JsonProperty("tot_buy_cnt")]
		public decimal? TotalBuyCount;
		[JsonProperty("tot_sel_cnt")]
		public decimal? TotalSellCount;
	}

	public record KiwoomMarketConditionGetQuoteList
	{
		public string StockName = string.Empty;
		public string StockCode = string.Empty;
		public DateTime? Date;
		public TimeSpan Time;
		public decimal? PrevClosePrice;
		public decimal? PrevTradeQuantity;
		public decimal? UpperPrice;
		public decimal? LowerPrice;
		public decimal? PrevTradeAmount;
		public decimal? ListedShares;
		public decimal? CurrentPrice;
		public string Sign = string.Empty;
		public decimal? FluctuationRate;
		public decimal? PrevRate;
		public decimal? OpenPrice;
		public decimal? HighPrice;
		public decimal? LowPrice;
		public decimal? ContractQuantity;
		public decimal? TradeQuantity;
		public decimal? TradeAmount;
		public decimal? ExpectedContractPrice;
		public decimal? ExpectedContractQuantity;
		public decimal? ExpectedSellPriorityBid;
		public decimal? ExpectedBuyPriorityBid;
		public DateTime? TradeStartDate;
		public decimal? ExercisePrice;
		public decimal? HighestPrice;
		public decimal? LowestPrice;
		public DateTime? HighestPriceDate;
		public DateTime? LowestPriceDate;

		public decimal?[] SellPrices;
		public decimal?[] BuyPrices;
		public decimal?[] SellQuantities;
		public decimal?[] BuyQuantities;
		public decimal?[] SellPrevDiffs;
		public decimal?[] BuyPrevDiffs;
		public decimal?[] SellCounts;
		public decimal?[] BuyCounts;
		public decimal?[] LpSellQuantities;
		public decimal?[] LpBuyQuantities;

		public decimal? TotalBuyQuantity;
		public decimal? TotalSellQuantity;
		public decimal? TotalBuyCount;
		public decimal? TotalSellCount;

		public KiwoomMarketConditionGetQuoteList(KiwoomMarketConditionGetQuote raw)
		{
			StockName = raw.StockName;
			StockCode = raw.StockCode;
			Date = raw.Date;
			Time = raw.Time;
			PrevClosePrice = raw.PrevClosePrice;
			PrevTradeQuantity = raw.PrevTradeQuantity;
			UpperPrice = raw.UpperPrice;
			LowerPrice = raw.LowerPrice;
			PrevTradeAmount = raw.PrevTradeAmount;
			ListedShares = raw.ListedShares;
			CurrentPrice = raw.CurrentPrice;
			Sign = raw.Sign;
			FluctuationRate = raw.FluctuationRate;
			PrevRate = raw.PrevRate;
			OpenPrice = raw.OpenPrice;
			HighPrice = raw.HighPrice;
			LowPrice = raw.LowPrice;
			ContractQuantity = raw.ContractQuantity;
			TradeQuantity = raw.TradeQuantity;
			TradeAmount = raw.TradeAmount;
			ExpectedContractPrice = raw.ExpectedContractPrice;
			ExpectedContractQuantity = raw.ExpectedContractQuantity;
			ExpectedSellPriorityBid = raw.ExpectedSellPriorityBid;
			ExpectedBuyPriorityBid = raw.ExpectedBuyPriorityBid;
			TradeStartDate = raw.TradeStartDate;
			ExercisePrice = raw.ExercisePrice;
			HighestPrice = raw.HighestPrice;
			LowestPrice = raw.LowestPrice;
			HighestPriceDate = raw.HighestPriceDate;
			LowestPriceDate = raw.LowestPriceDate;
			SellPrices =
			[
				raw.Sell1Price, raw.Sell2Price, raw.Sell3Price, raw.Sell4Price, raw.Sell5Price,
				raw.Sell6Price, raw.Sell7Price, raw.Sell8Price, raw.Sell9Price, raw.Sell10Price
			];
			BuyPrices =
			[
				raw.Buy1Price, raw.Buy2Price, raw.Buy3Price, raw.Buy4Price, raw.Buy5Price,
				raw.Buy6Price, raw.Buy7Price, raw.Buy8Price, raw.Buy9Price, raw.Buy10Price
			];
			SellQuantities =
			[
				raw.Sell1Quantity, raw.Sell2Quantity, raw.Sell3Quantity, raw.Sell4Quantity, raw.Sell5Quantity,
				raw.Sell6Quantity, raw.Sell7Quantity, raw.Sell8Quantity, raw.Sell9Quantity, raw.Sell10Quantity
			];
			BuyQuantities =
			[
				raw.Buy1Quantity, raw.Buy2Quantity, raw.Buy3Quantity, raw.Buy4Quantity, raw.Buy5Quantity,
				raw.Buy6Quantity, raw.Buy7Quantity, raw.Buy8Quantity, raw.Buy9Quantity, raw.Buy10Quantity
			];
			SellPrevDiffs =
			[
				raw.Sell1PrevDiff, raw.Sell2PrevDiff, raw.Sell3PrevDiff, raw.Sell4PrevDiff, raw.Sell5PrevDiff,
				raw.Sell6PrevDiff, raw.Sell7PrevDiff, raw.Sell8PrevDiff, raw.Sell9PrevDiff, raw.Sell10PrevDiff
			];
			BuyPrevDiffs =
			[
				raw.Buy1PrevDiff, raw.Buy2PrevDiff, raw.Buy3PrevDiff, raw.Buy4PrevDiff, raw.Buy5PrevDiff,
				raw.Buy6PrevDiff, raw.Buy7PrevDiff, raw.Buy8PrevDiff, raw.Buy9PrevDiff, raw.Buy10PrevDiff
			];
			SellCounts =
			[
				raw.Sell1Count, raw.Sell2Count, raw.Sell3Count, raw.Sell4Count, raw.Sell5Count
			];
			BuyCounts =
			[
				raw.Buy1Count, raw.Buy2Count, raw.Buy3Count, raw.Buy4Count, raw.Buy5Count
			];
			LpSellQuantities =
			[
				raw.LpSell1Quantity, raw.LpSell2Quantity, raw.LpSell3Quantity, raw.LpSell4Quantity, raw.LpSell5Quantity,
				raw.LpSell6Quantity, raw.LpSell7Quantity, raw.LpSell8Quantity, raw.LpSell9Quantity, raw.LpSell10Quantity
			];
			LpBuyQuantities =
			[
				raw.LpBuy1Quantity, raw.LpBuy2Quantity, raw.LpBuy3Quantity, raw.LpBuy4Quantity, raw.LpBuy5Quantity,
				raw.LpBuy6Quantity, raw.LpBuy7Quantity, raw.LpBuy8Quantity, raw.LpBuy9Quantity, raw.LpBuy10Quantity
			];
			TotalBuyQuantity = raw.TotalBuyQuantity;
			TotalSellQuantity = raw.TotalSellQuantity;
			TotalBuyCount = raw.TotalBuyCount;
			TotalSellCount = raw.TotalSellCount;
		}
	}

	public record KiwoomMarketConditionGetAllMarketQuoteForRightsOfferings
	{
		[JsonProperty("newstk_recvrht_mrpr")]
		public IEnumerable<KiwoomMarketConditionGetAllMarketQuoteForRightsOfferingItem>? Items;
	}
	public record KiwoomMarketConditionGetAllMarketQuoteForRightsOfferingItem
	{
		[JsonProperty("stk_cd")]
		public string StockCode = string.Empty;
		[JsonProperty("stk_nm")]
		public string StockName = string.Empty;
		[JsonProperty("cur_prc")]
		public decimal CurrentPrice;
		[JsonProperty("pred_pre_sig")]
		public string PrevDiffSign = string.Empty;
		[JsonProperty("pred_pre")]
		public decimal PrevDiff;
		[JsonProperty("flu_rt")]
		public decimal FluctuationRate;
		[JsonProperty("fpr_sel_bid")]
		public decimal FirstPrioritySellBid;
		[JsonProperty("fpr_buy_bid")]
		public decimal FirstPriorityBuyBid;
		[JsonProperty("acc_trde_qty")]
		public decimal AccumulatedTradeQuantity;
		[JsonProperty("open_pric")]
		public decimal OpenPrice;
		[JsonProperty("high_pric")]
		public decimal HighPrice;
		[JsonProperty("low_pric")]
		public decimal LowPrice;
	}

	public record KiwoomMarketConditionGetDailyInstitutionTradingStocks
	{
		[JsonProperty("daly_orgn_trde_stk")]
		public IEnumerable<KiwoomMarketConditionGetDailyInstitutionTradingStockItem>? Items;
	}
	public record KiwoomMarketConditionGetDailyInstitutionTradingStockItem
	{
		[JsonProperty("stk_cd")]
		public string StockCode = string.Empty;
		[JsonProperty("stk_nm")]
		public string StockName = string.Empty;
		[JsonProperty("netprps_qty")]
		public decimal NetPurchaseQuantity;
		[JsonProperty("netprps_amt")]
		public decimal NetPurchaseAmount;
	}

	public record KiwoomMarketConditionGetStockOriginTradeTrends
	{
		[JsonProperty("orgn_prsm_avg_pric")]
		public decimal InstitutionEstimatedAvgPrice;
		[JsonProperty("for_prsm_avg_pric")]
		public decimal ForeignEstimatedAvgPrice;
		[JsonProperty("stk_orgn_trde_trnsn")]
		public IEnumerable<KiwoomMarketConditionGetStockOriginTradeTrendItem>? Items;
	}
	public record KiwoomMarketConditionGetStockOriginTradeTrendItem
	{
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		[JsonProperty("close_pric")]
		public decimal ClosePrice;
		[JsonProperty("pre_sig")]
		public string PrevDiffSign = string.Empty;
		[JsonProperty("pred_pre")]
		public decimal PrevDiff;
		[JsonProperty("flu_rt")]
		public decimal FluctuationRate;
		[JsonProperty("trde_qty")]
		public decimal TradeQuantity;
		[JsonProperty("orgn_dt_acc")]
		public decimal InstitutionPeriodAccumulation;
		[JsonProperty("orgn_daly_nettrde_qty")]
		public decimal InstitutionDailyNetTradeQuantity;
		[JsonProperty("for_dt_acc")]
		public decimal ForeignPeriodAccumulation;
		[JsonProperty("for_daly_nettrde_qty")]
		public decimal ForeignDailyNetTradeQuantity;
		[JsonProperty("limit_exh_rt")]
		public decimal LimitExhaustionRate;
	}

	public record KiwoomMarketConditionGetHourlyContractStrengths
	{
		[JsonProperty("cntr_str_tm")]
		public IEnumerable<KiwoomMarketConditionGetHourlyContractStrengthItem>? Items;
	}
	public record KiwoomMarketConditionGetHourlyContractStrengthItem
	{
		[JsonProperty("cntr_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan ContractTime;
		[JsonProperty("cur_prc")]
		public decimal CurrentPrice;
		[JsonProperty("pred_pre")]
		public decimal PrevDiff;
		[JsonProperty("pred_pre_sig")]
		public string PrevDiffSign = string.Empty;
		[JsonProperty("flu_rt")]
		public decimal FluctuationRate;
		[JsonProperty("trde_qty")]
		public decimal TradeQuantity;
		[JsonProperty("acc_trde_prica")]
		public decimal AccumulatedTradeAmount;
		[JsonProperty("acc_trde_qty")]
		public decimal AccumulatedTradeQuantity;
		[JsonProperty("cntr_str")]
		public decimal ContractStrength;
		[JsonProperty("cntr_str_5min")]
		public decimal ContractStrength5Min;
		[JsonProperty("cntr_str_20min")]
		public decimal ContractStrength20Min;
		[JsonProperty("cntr_str_60min")]
		public decimal ContractStrength60Min;
		[JsonProperty("stex_tp")]
		public string ExchangeType = string.Empty;
	}

	public record KiwoomMarketConditionGetDailyContractStrengths
	{
		[JsonProperty("cntr_str_daly")]
		public IEnumerable<KiwoomMarketConditionGetDailyContractStrengthItem>? Items;
	}
	public record KiwoomMarketConditionGetDailyContractStrengthItem
	{
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		[JsonProperty("cur_prc")]
		public decimal CurrentPrice;
		[JsonProperty("pred_pre")]
		public decimal PrevDiff;
		[JsonProperty("pred_pre_sig")]
		public string PrevDiffSign = string.Empty;
		[JsonProperty("flu_rt")]
		public decimal FluctuationRate;
		[JsonProperty("trde_qty")]
		public decimal TradeQuantity;
		[JsonProperty("acc_trde_prica")]
		public decimal AccumulatedTradeAmount;
		[JsonProperty("acc_trde_qty")]
		public decimal AccumulatedTradeQuantity;
		[JsonProperty("cntr_str")]
		public decimal ContractStrength;
		[JsonProperty("cntr_str_5min")]
		public decimal ContractStrength5Days;
		[JsonProperty("cntr_str_20min")]
		public decimal ContractStrength20Days;
		[JsonProperty("cntr_str_60min")]
		public decimal ContractStrength60Days;
	}

	public record KiwoomMarketConditionGetIntradayInvestorTradings
	{
		[JsonProperty("opmr_invsr_trde")]
		public IEnumerable<KiwoomMarketConditionGetIntradayInvestorTradingItem>? Items;
	}
	public record KiwoomMarketConditionGetIntradayInvestorTradingItem
	{
		[JsonProperty("stk_cd")]
		public string StockCode = string.Empty;
		[JsonProperty("stk_nm")]
		public string StockName = string.Empty;
		[JsonProperty("cur_prc")]
		public decimal CurrentPrice;
		[JsonProperty("pre_sig")]
		public string PrevDiffSign = string.Empty;
		[JsonProperty("pred_pre")]
		public decimal PrevDiff;
		[JsonProperty("flu_rt")]
		public decimal FluctuationRate;
		[JsonProperty("acc_trde_qty")]
		public decimal AccumulatedTradeQuantity;
		[JsonProperty("netprps_qty")]
		public decimal NetPurchaseQuantity;
		[JsonProperty("prev_pot_netprps_qty")]
		public decimal PreviousPointNetPurchaseQuantity;
		[JsonProperty("netprps_irds")]
		public decimal NetPurchaseIncreaseDecrease;
		[JsonProperty("buy_qty")]
		public decimal BuyQuantity;
		[JsonProperty("buy_qty_irds")]
		public decimal BuyQuantityIncreaseDecrease;
		[JsonProperty("sell_qty")]
		public decimal SellQuantity;
		[JsonProperty("sell_qty_irds")]
		public decimal SellQuantityIncreaseDecrease;
	}

	public record KiwoomMarketConditionGetIntradayInvestorTradeCharts
	{
		[JsonProperty("opaf_invsr_trde")]
		public IEnumerable<KiwoomMarketConditionGetIntradayInvestorTradeChartItem>? Items;
	}
	public record KiwoomMarketConditionGetIntradayInvestorTradeChartItem
	{
		[JsonProperty("stk_cd")]
		public string StockCode = string.Empty;
		[JsonProperty("stk_nm")]
		public string StockName = string.Empty;
		[JsonProperty("cur_prc")]
		public decimal CurrentPrice;
		[JsonProperty("pre_sig")]
		public string PrevDiffSign = string.Empty;
		[JsonProperty("pred_pre")]
		public decimal PrevDiff;
		[JsonProperty("flu_rt")]
		public decimal FluctuationRate;
		[JsonProperty("trde_qty")]
		public decimal TradeQuantity;
		[JsonProperty("ind_invsr")]
		public decimal IndividualInvestor;
		[JsonProperty("frgnr_invsr")]
		public decimal ForeignInvestor;
		[JsonProperty("orgn")]
		public decimal Institution;
		[JsonProperty("fnnc_invt")]
		public decimal FinancialInvestment;
		[JsonProperty("insrnc")]
		public decimal Insurance;
		[JsonProperty("invtrt")]
		public decimal InvestmentTrust;
		[JsonProperty("etc_fnnc")]
		public decimal OtherFinancials;
		[JsonProperty("bank")]
		public decimal Bank;
		[JsonProperty("penfnd_etc")]
		public decimal PensionEtc;
		[JsonProperty("samo_fund")]
		public decimal PrivateFund;
		[JsonProperty("natn")]
		public decimal Nation;
		[JsonProperty("etc_corp")]
		public decimal OtherCorporation;
	}

	public record KiwoomMarketConditionGetSecurityFirmStockTradeTrends
	{
		[JsonProperty("sec_stk_trde_trend")]
		public IEnumerable<KiwoomMarketConditionGetSecurityFirmStockTradeTrendItem>? Items;
	}
	public record KiwoomMarketConditionGetSecurityFirmStockTradeTrendItem
	{
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		[JsonProperty("cur_prc")]
		public decimal CurrentPrice;
		[JsonProperty("pre_sig")]
		public string PrevDiffSign = string.Empty;
		[JsonProperty("pred_pre")]
		public decimal PrevDiff;
		[JsonProperty("flu_rt")]
		public decimal FluctuationRate;
		[JsonProperty("acc_trde_qty")]
		public decimal AccumulatedTradeQuantity;
		[JsonProperty("netprps_qty")]
		public decimal NetPurchaseQuantity;
		[JsonProperty("buy_qty")]
		public decimal BuyQuantity;
		[JsonProperty("sell_qty")]
		public decimal SellQuantity;
	}

	public record KiwoomMarketConditionGetDailyStockPrices
	{
		[JsonProperty("daly_stkpc")]
		public IEnumerable<KiwoomMarketConditionGetDailyStockPriceItem>? Items;
	}
	public record KiwoomMarketConditionGetDailyStockPriceItem
	{
		[JsonProperty("date")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		[JsonProperty("open_pric")]
		public decimal OpenPrice;
		[JsonProperty("high_pric")]
		public decimal HighPrice;
		[JsonProperty("low_pric")]
		public decimal LowPrice;
		[JsonProperty("close_pric")]
		public decimal ClosePrice;
		[JsonProperty("pred_rt")]
		public decimal PreviousRate;
		[JsonProperty("flu_rt")]
		public decimal FluctuationRate;
		[JsonProperty("trde_qty")]
		public decimal TradeQuantity;
		[JsonProperty("amt_mn")]
		public decimal AmountMillion;
		[JsonProperty("crd_rt")]
		public decimal CreditRate;
		[JsonProperty("ind")]
		public decimal Individual;
		[JsonProperty("orgn")]
		public decimal Institution;
		[JsonProperty("for_qty")]
		public decimal ForeignQuantity;
		[JsonProperty("frgn")]
		public decimal ForeignBrokerage;
		[JsonProperty("prm")]
		public decimal Program;
		[JsonProperty("for_rt")]
		public decimal ForeignRate;
		[JsonProperty("for_poss")]
		public decimal ForeignPossession;
		[JsonProperty("for_wght")]
		public decimal ForeignWeight;
		[JsonProperty("for_netprps")]
		public decimal ForeignNetPurchase;
		[JsonProperty("orgn_netprps")]
		public decimal InstitutionNetPurchase;
		[JsonProperty("ind_netprps")]
		public decimal IndividualNetPurchase;
		[JsonProperty("crd_remn_rt")]
		public decimal CreditRemainingRate;
	}

	public record KiwoomMarketConditionGetAfterHoursSinglePriceOrderBook
	{
		[JsonProperty("bid_req_base_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan BidRequestBaseTime;
		[JsonProperty("ovt_sigpric_sel_bid_jub_pre_5")]
		public decimal AfterHoursSinglePriceSellPrevDiff5;
		[JsonProperty("ovt_sigpric_sel_bid_jub_pre_4")]
		public decimal AfterHoursSinglePriceSellPrevDiff4;
		[JsonProperty("ovt_sigpric_sel_bid_jub_pre_3")]
		public decimal AfterHoursSinglePriceSellPrevDiff3;
		[JsonProperty("ovt_sigpric_sel_bid_jub_pre_2")]
		public decimal AfterHoursSinglePriceSellPrevDiff2;
		[JsonProperty("ovt_sigpric_sel_bid_jub_pre_1")]
		public decimal AfterHoursSinglePriceSellPrevDiff1;
		[JsonProperty("ovt_sigpric_sel_bid_qty_5")]
		public decimal AfterHoursSinglePriceSellQuantity5;
		[JsonProperty("ovt_sigpric_sel_bid_qty_4")]
		public decimal AfterHoursSinglePriceSellQuantity4;
		[JsonProperty("ovt_sigpric_sel_bid_qty_3")]
		public decimal AfterHoursSinglePriceSellQuantity3;
		[JsonProperty("ovt_sigpric_sel_bid_qty_2")]
		public decimal AfterHoursSinglePriceSellQuantity2;
		[JsonProperty("ovt_sigpric_sel_bid_qty_1")]
		public decimal AfterHoursSinglePriceSellQuantity1;
		[JsonProperty("ovt_sigpric_sel_bid_5")]
		public decimal AfterHoursSinglePriceSellPrice5;
		[JsonProperty("ovt_sigpric_sel_bid_4")]
		public decimal AfterHoursSinglePriceSellPrice4;
		[JsonProperty("ovt_sigpric_sel_bid_3")]
		public decimal AfterHoursSinglePriceSellPrice3;
		[JsonProperty("ovt_sigpric_sel_bid_2")]
		public decimal AfterHoursSinglePriceSellPrice2;
		[JsonProperty("ovt_sigpric_sel_bid_1")]
		public decimal AfterHoursSinglePriceSellPrice1;
		[JsonProperty("ovt_sigpric_buy_bid_1")]
		public decimal AfterHoursSinglePriceBuyPrice1;
		[JsonProperty("ovt_sigpric_buy_bid_2")]
		public decimal AfterHoursSinglePriceBuyPrice2;
		[JsonProperty("ovt_sigpric_buy_bid_3")]
		public decimal AfterHoursSinglePriceBuyPrice3;
		[JsonProperty("ovt_sigpric_buy_bid_4")]
		public decimal AfterHoursSinglePriceBuyPrice4;
		[JsonProperty("ovt_sigpric_buy_bid_5")]
		public decimal AfterHoursSinglePriceBuyPrice5;
		[JsonProperty("ovt_sigpric_buy_bid_qty_1")]
		public decimal AfterHoursSinglePriceBuyQuantity1;
		[JsonProperty("ovt_sigpric_buy_bid_qty_2")]
		public decimal AfterHoursSinglePriceBuyQuantity2;
		[JsonProperty("ovt_sigpric_buy_bid_qty_3")]
		public decimal AfterHoursSinglePriceBuyQuantity3;
		[JsonProperty("ovt_sigpric_buy_bid_qty_4")]
		public decimal AfterHoursSinglePriceBuyQuantity4;
		[JsonProperty("ovt_sigpric_buy_bid_qty_5")]
		public decimal AfterHoursSinglePriceBuyQuantity5;
		[JsonProperty("ovt_sigpric_buy_bid_jub_pre_1")]
		public decimal AfterHoursSinglePriceBuyPrevDiff1;
		[JsonProperty("ovt_sigpric_buy_bid_jub_pre_2")]
		public decimal AfterHoursSinglePriceBuyPrevDiff2;
		[JsonProperty("ovt_sigpric_buy_bid_jub_pre_3")]
		public decimal AfterHoursSinglePriceBuyPrevDiff3;
		[JsonProperty("ovt_sigpric_buy_bid_jub_pre_4")]
		public decimal AfterHoursSinglePriceBuyPrevDiff4;
		[JsonProperty("ovt_sigpric_buy_bid_jub_pre_5")]
		public decimal AfterHoursSinglePriceBuyPrevDiff5;
		[JsonProperty("ovt_sigpric_sel_bid_tot_req")]
		public decimal AfterHoursSinglePriceSellTotalQuantity;
		[JsonProperty("ovt_sigpric_buy_bid_tot_req")]
		public decimal AfterHoursSinglePriceBuyTotalQuantity;
		[JsonProperty("sel_bid_tot_req_jub_pre")]
		public decimal SellTotalQuantityPrevDiff;
		[JsonProperty("sel_bid_tot_req")]
		public decimal SellTotalQuantity;
		[JsonProperty("buy_bid_tot_req")]
		public decimal BuyTotalQuantity;
		[JsonProperty("buy_bid_tot_req_jub_pre")]
		public decimal BuyTotalQuantityPrevDiff;
		[JsonProperty("ovt_sel_bid_tot_req_jub_pre")]
		public decimal AfterHoursSellTotalQuantityPrevDiff;
		[JsonProperty("ovt_sel_bid_tot_req")]
		public decimal AfterHoursSellTotalQuantity;
		[JsonProperty("ovt_buy_bid_tot_req")]
		public decimal AfterHoursBuyTotalQuantity;
		[JsonProperty("ovt_buy_bid_tot_req_jub_pre")]
		public decimal AfterHoursBuyTotalQuantityPrevDiff;
		[JsonProperty("ovt_sigpric_cur_prc")]
		public decimal AfterHoursSinglePriceCurrentPrice;
		[JsonProperty("ovt_sigpric_pred_pre_sig")]
		public string AfterHoursSinglePricePrevDiffSign = string.Empty;
		[JsonProperty("ovt_sigpric_pred_pre")]
		public decimal AfterHoursSinglePricePrevDiff;
		[JsonProperty("ovt_sigpric_flu_rt")]
		public decimal AfterHoursSinglePriceFluctuationRate;
		[JsonProperty("ovt_sigpric_acc_trde_qty")]
		public decimal AfterHoursSinglePriceAccumulatedTradeQuantity;
	}

	public record KiwoomMarketConditionGetAfterHoursSinglePriceOrderBookList
	{
		public TimeSpan BidRequestBaseTime;
		public decimal[] AfterHoursSinglePriceSellPrevDiffs;
		public decimal[] AfterHoursSinglePriceSellQuantitys;
		public decimal[] AfterHoursSinglePriceSellPrices;
		public decimal[] AfterHoursSinglePriceBuyPrices;
		public decimal[] AfterHoursSinglePriceBuyQuantities;
		public decimal[] AfterHoursSinglePriceBuyPrevDiffs;
		public decimal AfterHoursSinglePriceSellTotalQuantity;
		public decimal AfterHoursSinglePriceBuyTotalQuantity;
		public decimal SellTotalQuantityPrevDiff;
		public decimal SellTotalQuantity;
		public decimal BuyTotalQuantity;
		public decimal BuyTotalQuantityPrevDiff;
		public decimal AfterHoursSellTotalQuantityPrevDiff;
		public decimal AfterHoursSellTotalQuantity;
		public decimal AfterHoursBuyTotalQuantity;
		public decimal AfterHoursBuyTotalQuantityPrevDiff;
		public decimal AfterHoursSinglePriceCurrentPrice;
		public string AfterHoursSinglePricePrevDiffSign = string.Empty;
		public decimal AfterHoursSinglePricePrevDiff;
		public decimal AfterHoursSinglePriceFluctuationRate;
		public decimal AfterHoursSinglePriceAccumulatedTradeQuantity;

		public KiwoomMarketConditionGetAfterHoursSinglePriceOrderBookList(KiwoomMarketConditionGetAfterHoursSinglePriceOrderBook raw)
		{
			BidRequestBaseTime = raw.BidRequestBaseTime;
			AfterHoursSinglePriceSellPrevDiffs =
			[
				raw.AfterHoursSinglePriceSellPrevDiff5, raw.AfterHoursSinglePriceSellPrevDiff4,
				raw.AfterHoursSinglePriceSellPrevDiff3, raw.AfterHoursSinglePriceSellPrevDiff2,
				raw.AfterHoursSinglePriceSellPrevDiff1
			];
			AfterHoursSinglePriceSellQuantitys =
			[
				raw.AfterHoursSinglePriceSellQuantity5, raw.AfterHoursSinglePriceSellQuantity4,
				raw.AfterHoursSinglePriceSellQuantity3, raw.AfterHoursSinglePriceSellQuantity2,
				raw.AfterHoursSinglePriceSellQuantity1
			];
			AfterHoursSinglePriceSellPrices =
			[
				raw.AfterHoursSinglePriceSellPrice5, raw.AfterHoursSinglePriceSellPrice4,
				raw.AfterHoursSinglePriceSellPrice3, raw.AfterHoursSinglePriceSellPrice2,
				raw.AfterHoursSinglePriceSellPrice1
			];
			AfterHoursSinglePriceBuyPrices =
			[
				raw.AfterHoursSinglePriceBuyPrice1, raw.AfterHoursSinglePriceBuyPrice2,
				raw.AfterHoursSinglePriceBuyPrice3, raw.AfterHoursSinglePriceBuyPrice4,
				raw.AfterHoursSinglePriceBuyPrice5
			];
			AfterHoursSinglePriceBuyQuantities =
			[
				raw.AfterHoursSinglePriceBuyQuantity1, raw.AfterHoursSinglePriceBuyQuantity2,
				raw.AfterHoursSinglePriceBuyQuantity3, raw.AfterHoursSinglePriceBuyQuantity4,
				raw.AfterHoursSinglePriceBuyQuantity5
			];
			AfterHoursSinglePriceBuyPrevDiffs =
			[
				raw.AfterHoursSinglePriceBuyPrevDiff1, raw.AfterHoursSinglePriceBuyPrevDiff2,
				raw.AfterHoursSinglePriceBuyPrevDiff3, raw.AfterHoursSinglePriceBuyPrevDiff4,
				raw.AfterHoursSinglePriceBuyPrevDiff5
			];
			AfterHoursSinglePriceSellTotalQuantity = raw.AfterHoursSinglePriceSellTotalQuantity;
			AfterHoursSinglePriceBuyTotalQuantity = raw.AfterHoursSinglePriceBuyTotalQuantity;
			SellTotalQuantityPrevDiff = raw.SellTotalQuantityPrevDiff;
			SellTotalQuantity = raw.SellTotalQuantity;
			BuyTotalQuantity = raw.BuyTotalQuantity;
			BuyTotalQuantityPrevDiff = raw.BuyTotalQuantityPrevDiff;
			AfterHoursSellTotalQuantityPrevDiff = raw.AfterHoursSellTotalQuantityPrevDiff;
			AfterHoursSellTotalQuantity = raw.AfterHoursSellTotalQuantity;
			AfterHoursBuyTotalQuantity = raw.AfterHoursBuyTotalQuantity;
			AfterHoursBuyTotalQuantityPrevDiff = raw.AfterHoursBuyTotalQuantityPrevDiff;
			AfterHoursSinglePriceCurrentPrice = raw.AfterHoursSinglePriceCurrentPrice;
			AfterHoursSinglePricePrevDiffSign = raw.AfterHoursSinglePricePrevDiffSign;
			AfterHoursSinglePricePrevDiff = raw.AfterHoursSinglePricePrevDiff;
			AfterHoursSinglePriceFluctuationRate = raw.AfterHoursSinglePriceFluctuationRate;
			AfterHoursSinglePriceAccumulatedTradeQuantity = raw.AfterHoursSinglePriceAccumulatedTradeQuantity;
		}
	}

	public record KiwoomMarketConditionGetHourlyProgramTradeTrends
	{
		[JsonProperty("prm_trde_trnsn")]
		public IEnumerable<KiwoomMarketConditionGetHourlyProgramTradeTrendItem>? Items;
	}
	public record KiwoomMarketConditionGetHourlyProgramTradeTrendItem
	{
		[JsonProperty("cntr_tm")]
		public string ContractTime = string.Empty;
		[JsonProperty("dfrt_trde_sel")]
		public decimal ArbitrageTradeSell;
		[JsonProperty("dfrt_trde_buy")]
		public decimal ArbitrageTradeBuy;
		[JsonProperty("dfrt_trde_netprps")]
		public decimal ArbitrageTradeNetPurchase;
		[JsonProperty("ndiffpro_trde_sel")]
		public decimal NonArbitrageTradeSell;
		[JsonProperty("ndiffpro_trde_buy")]
		public decimal NonArbitrageTradeBuy;
		[JsonProperty("ndiffpro_trde_netprps")]
		public decimal NonArbitrageTradeNetPurchase;
		[JsonProperty("dfrt_trde_sell_qty")]
		public decimal ArbitrageTradeSellQuantity;
		[JsonProperty("dfrt_trde_buy_qty")]
		public decimal ArbitrageTradeBuyQuantity;
		[JsonProperty("dfrt_trde_netprps_qty")]
		public decimal ArbitrageTradeNetPurchaseQuantity;
		[JsonProperty("ndiffpro_trde_sell_qty")]
		public decimal NonArbitrageTradeSellQuantity;
		[JsonProperty("ndiffpro_trde_buy_qty")]
		public decimal NonArbitrageTradeBuyQuantity;
		[JsonProperty("ndiffpro_trde_netprps_qty")]
		public decimal NonArbitrageTradeNetPurchaseQuantity;
		[JsonProperty("all_sel")]
		public decimal TotalSell;
		[JsonProperty("all_buy")]
		public decimal TotalBuy;
		[JsonProperty("all_netprps")]
		public decimal TotalNetPurchase;
		[JsonProperty("kospi200")]
		public decimal Kospi200;
		[JsonProperty("basis")]
		public decimal Basis;
	}

	public record KiwoomMarketConditionGetProgramArbitrageBalanceTrends
	{
		[JsonProperty("prm_trde_dfrt_remn_trnsn")]
		public IEnumerable<KiwoomMarketConditionGetProgramArbitrageBalanceTrendItem>? Items;
	}
	public record KiwoomMarketConditionGetProgramArbitrageBalanceTrendItem
	{
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		[JsonProperty("buy_dfrt_trde_qty")]
		public decimal BuyArbitrageTradeQuantity;
		[JsonProperty("buy_dfrt_trde_amt")]
		public decimal BuyArbitrageTradeAmount;
		[JsonProperty("buy_dfrt_trde_irds_amt")]
		public decimal BuyArbitrageTradeIncreaseDecreaseAmount;
		[JsonProperty("sel_dfrt_trde_qty")]
		public decimal SellArbitrageTradeQuantity;
		[JsonProperty("sel_dfrt_trde_amt")]
		public decimal SellArbitrageTradeAmount;
		[JsonProperty("sel_dfrt_trde_irds_amt")]
		public decimal SellArbitrageTradeIncreaseDecreaseAmount;
	}

	public record KiwoomMarketConditionGetProgramTradeAccumulatedTrends
	{
		[JsonProperty("prm_trde_acc_trnsn")]
		public IEnumerable<KiwoomMarketConditionGetProgramTradeAccumulatedTrendItem>? Items;
	}
	public record KiwoomMarketConditionGetProgramTradeAccumulatedTrendItem
	{
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		[JsonProperty("kospi200")]
		public decimal Kospi200;
		[JsonProperty("basis")]
		public decimal Basis;
		[JsonProperty("dfrt_trde_tdy")]
		public decimal ArbitrageTradeToday;
		[JsonProperty("dfrt_trde_acc")]
		public decimal ArbitrageTradeAccumulated;
		[JsonProperty("ndiffpro_trde_tdy")]
		public decimal NonArbitrageTradeToday;
		[JsonProperty("ndiffpro_trde_acc")]
		public decimal NonArbitrageTradeAccumulated;
		[JsonProperty("all_tdy")]
		public decimal TotalToday;
		[JsonProperty("all_acc")]
		public decimal TotalAccumulated;
	}

	public record KiwoomMarketConditionGetStockTimeProgramTradeTrends
	{
		[JsonProperty("stk_tm_prm_trde_trnsn")]
		public IEnumerable<KiwoomMarketConditionGetStockTimeProgramTradeTrendItem>? Items;
	}
	public record KiwoomMarketConditionGetStockTimeProgramTradeTrendItem
	{
		[JsonProperty("tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan Time;
		[JsonProperty("cur_prc")]
		public decimal CurrentPrice;
		[JsonProperty("pre_sig")]
		public string PrevDiffSign = string.Empty;
		[JsonProperty("pred_pre")]
		public decimal PrevDiff;
		[JsonProperty("flu_rt")]
		public decimal FluctuationRate;
		[JsonProperty("trde_qty")]
		public decimal TradeQuantity;
		[JsonProperty("prm_sell_amt")]
		public decimal ProgramSellAmount;
		[JsonProperty("prm_buy_amt")]
		public decimal ProgramBuyAmount;
		[JsonProperty("prm_netprps_amt")]
		public decimal ProgramNetPurchaseAmount;
		[JsonProperty("prm_netprps_amt_irds")]
		public decimal ProgramNetPurchaseAmountChange;
		[JsonProperty("prm_sell_qty")]
		public decimal ProgramSellQuantity;
		[JsonProperty("prm_buy_qty")]
		public decimal ProgramBuyQuantity;
		[JsonProperty("prm_netprps_qty")]
		public decimal ProgramNetPurchaseQuantity;
		[JsonProperty("prm_netprps_qty_irds")]
		public decimal ProgramNetPurchaseQuantityChange;
		[JsonProperty("base_pric_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan BasePriceTime;
		[JsonProperty("dbrt_trde_rpy_sum")]
		public decimal StockLoanRepaymentSum;
		[JsonProperty("remn_rcvord_sum")]
		public decimal RemainingOrderSum;
		[JsonProperty("stex_tp")]
		public string ExchangeType = string.Empty;
	}

	public record KiwoomMarketConditionGetDailyProgramTradeTrends
	{
		[JsonProperty("prm_trde_trnsn")]
		public IEnumerable<KiwoomMarketConditionGetDailyProgramTradeTrendItem>? Items;
	}
	public record KiwoomMarketConditionGetDailyProgramTradeTrendItem
	{
		[JsonProperty("cntr_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan ContractTime;
		[JsonProperty("dfrt_trde_sel")]
		public decimal ArbitrageTradeSell;
		[JsonProperty("dfrt_trde_buy")]
		public decimal ArbitrageTradeBuy;
		[JsonProperty("dfrt_trde_netprps")]
		public decimal ArbitrageTradeNetPurchase;
		[JsonProperty("ndiffpro_trde_sel")]
		public decimal NonArbitrageTradeSell;
		[JsonProperty("ndiffpro_trde_buy")]
		public decimal NonArbitrageTradeBuy;
		[JsonProperty("ndiffpro_trde_netprps")]
		public decimal NonArbitrageTradeNetPurchase;
		[JsonProperty("dfrt_trde_sell_qty")]
		public decimal ArbitrageTradeSellQuantity;
		[JsonProperty("dfrt_trde_buy_qty")]
		public decimal ArbitrageTradeBuyQuantity;
		[JsonProperty("dfrt_trde_netprps_qty")]
		public decimal ArbitrageTradeNetPurchaseQuantity;
		[JsonProperty("ndiffpro_trde_sell_qty")]
		public decimal NonArbitrageTradeSellQuantity;
		[JsonProperty("ndiffpro_trde_buy_qty")]
		public decimal NonArbitrageTradeBuyQuantity;
		[JsonProperty("ndiffpro_trde_netprps_qty")]
		public decimal NonArbitrageTradeNetPurchaseQuantity;
		[JsonProperty("all_sel")]
		public decimal TotalSell;
		[JsonProperty("all_buy")]
		public decimal TotalBuy;
		[JsonProperty("all_netprps")]
		public decimal TotalNetPurchase;
		[JsonProperty("kospi200")]
		public decimal Kospi200;
		[JsonProperty("basis")]
		public decimal Basis;
	}

	public record KiwoomMarketConditionGetStockDailyProgramTradeTrends
	{
		[JsonProperty("stk_daly_prm_trde_trnsn")]
		public IEnumerable<KiwoomMarketConditionGetStockDailyProgramTradeTrendItem>? Items;
	}
	public record KiwoomMarketConditionGetStockDailyProgramTradeTrendItem
	{
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		[JsonProperty("cur_prc")]
		public decimal CurrentPrice;
		[JsonProperty("pre_sig")]
		public string PrevDiffSign = string.Empty;
		[JsonProperty("pred_pre")]
		public decimal PrevDiff;
		[JsonProperty("flu_rt")]
		public decimal FluctuationRate;
		[JsonProperty("trde_qty")]
		public decimal TradeQuantity;
		[JsonProperty("prm_sell_amt")]
		public decimal ProgramSellAmount;
		[JsonProperty("prm_buy_amt")]
		public decimal ProgramBuyAmount;
		[JsonProperty("prm_netprps_amt")]
		public decimal ProgramNetPurchaseAmount;
		[JsonProperty("prm_netprps_amt_irds")]
		public decimal ProgramNetPurchaseAmountChange;
		[JsonProperty("prm_sell_qty")]
		public decimal ProgramSellQuantity;
		[JsonProperty("prm_buy_qty")]
		public decimal ProgramBuyQuantity;
		[JsonProperty("prm_netprps_qty")]
		public decimal ProgramNetPurchaseQuantity;
		[JsonProperty("prm_netprps_qty_irds")]
		public decimal ProgramNetPurchaseQuantityChange;
		[JsonProperty("base_pric_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan BasePriceTime;
		[JsonProperty("dbrt_trde_rpy_sum")]
		public decimal StockLoanRepaymentSum;
		[JsonProperty("remn_rcvord_sum")]
		public decimal RemainingOrderSum;
		[JsonProperty("stex_tp")]
		public string ExchangeType = string.Empty;
	}

}
