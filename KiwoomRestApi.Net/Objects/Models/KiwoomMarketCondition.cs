using KiwoomRestApi.Net.Converters;
using KiwoomRestApi.Net.Objects.Commons;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models
{
	public record KiwoomMarketConditionGetOrderBook
	{
		/// <summary>
		/// 호가잔량기준시간
		/// </summary>
		[JsonProperty("bid_req_base_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? BidRequestBaseTime;
		/// <summary>
		/// 매도10차선잔량대비
		/// </summary>
		[JsonProperty("sel_10th_pre_req_pre")]
		public decimal? AskLevel10PrevDiff;
		/// <summary>
		/// 매도10차선잔량
		/// </summary>
		[JsonProperty("sel_10th_pre_req")]
		public decimal? AskLevel10Quantity;
		/// <summary>
		/// 매도10차선호가
		/// </summary>
		[JsonProperty("sel_10th_pre_bid")]
		public decimal? AskLevel10Price;
		/// <summary>
		/// 매도9차선잔량대비
		/// </summary>
		[JsonProperty("sel_9th_pre_req_pre")]
		public decimal? AskLevel9PrevDiff;
		/// <summary>
		/// 매도9차선잔량
		/// </summary>
		[JsonProperty("sel_9th_pre_req")]
		public decimal? AskLevel9Quantity;
		/// <summary>
		/// 매도9차선호가
		/// </summary>
		[JsonProperty("sel_9th_pre_bid")]
		public decimal? AskLevel9Price;
		/// <summary>
		/// 매도8차선잔량대비
		/// </summary>
		[JsonProperty("sel_8th_pre_req_pre")]
		public decimal? AskLevel8PrevDiff;
		/// <summary>
		/// 매도8차선잔량
		/// </summary>
		[JsonProperty("sel_8th_pre_req")]
		public decimal? AskLevel8Quantity;
		/// <summary>
		/// 매도8차선호가
		/// </summary>
		[JsonProperty("sel_8th_pre_bid")]
		public decimal? AskLevel8Price;
		/// <summary>
		/// 매도7차선잔량대비
		/// </summary>
		[JsonProperty("sel_7th_pre_req_pre")]
		public decimal? AskLevel7PrevDiff;
		/// <summary>
		/// 매도7차선잔량
		/// </summary>
		[JsonProperty("sel_7th_pre_req")]
		public decimal? AskLevel7Quantity;
		/// <summary>
		/// 매도7차선호가
		/// </summary>
		[JsonProperty("sel_7th_pre_bid")]
		public decimal? AskLevel7Price;
		/// <summary>
		/// 매도6차선잔량대비
		/// </summary>
		[JsonProperty("sel_6th_pre_req_pre")]
		public decimal? AskLevel6PrevDiff;
		/// <summary>
		/// 매도6차선잔량
		/// </summary>
		[JsonProperty("sel_6th_pre_req")]
		public decimal? AskLevel6Quantity;
		/// <summary>
		/// 매도6차선호가
		/// </summary>
		[JsonProperty("sel_6th_pre_bid")]
		public decimal? AskLevel6Price;
		/// <summary>
		/// 매도5차선잔량대비
		/// </summary>
		[JsonProperty("sel_5th_pre_req_pre")]
		public decimal? AskLevel5PrevDiff;
		/// <summary>
		/// 매도5차선잔량
		/// </summary>
		[JsonProperty("sel_5th_pre_req")]
		public decimal? AskLevel5Quantity;
		/// <summary>
		/// 매도5차선호가
		/// </summary>
		[JsonProperty("sel_5th_pre_bid")]
		public decimal? AskLevel5Price;
		/// <summary>
		/// 매도4차선잔량대비
		/// </summary>
		[JsonProperty("sel_4th_pre_req_pre")]
		public decimal? AskLevel4PrevDiff;
		/// <summary>
		/// 매도4차선잔량
		/// </summary>
		[JsonProperty("sel_4th_pre_req")]
		public decimal? AskLevel4Quantity;
		/// <summary>
		/// 매도4차선호가
		/// </summary>
		[JsonProperty("sel_4th_pre_bid")]
		public decimal? AskLevel4Price;
		/// <summary>
		/// 매도3차선잔량대비
		/// </summary>
		[JsonProperty("sel_3th_pre_req_pre")]
		public decimal? AskLevel3PrevDiff;
		/// <summary>
		/// 매도3차선잔량
		/// </summary>
		[JsonProperty("sel_3th_pre_req")]
		public decimal? AskLevel3Quantity;
		/// <summary>
		/// 매도3차선호가
		/// </summary>
		[JsonProperty("sel_3th_pre_bid")]
		public decimal? AskLevel3Price;
		/// <summary>
		/// 매도2차선잔량대비
		/// </summary>
		[JsonProperty("sel_2th_pre_req_pre")]
		public decimal? AskLevel2PrevDiff;
		/// <summary>
		/// 매도2차선잔량
		/// </summary>
		[JsonProperty("sel_2th_pre_req")]
		public decimal? AskLevel2Quantity;
		/// <summary>
		/// 매도2차선호가
		/// </summary>
		[JsonProperty("sel_2th_pre_bid")]
		public decimal? AskLevel2Price;
		/// <summary>
		/// 매도1차선잔량대비
		/// </summary>
		[JsonProperty("sel_1th_pre_req_pre")]
		public decimal? AskLevel1PrevDiff;
		/// <summary>
		/// 매도최우선잔량
		/// </summary>
		[JsonProperty("sel_fpr_req")]
		public decimal? AskLevel1Quantity;
		/// <summary>
		/// 매도최우선호가
		/// </summary>
		[JsonProperty("sel_fpr_bid")]
		public decimal? AskLevel1Price;
		/// <summary>
		/// 매수최우선호가
		/// </summary>
		[JsonProperty("buy_fpr_bid")]
		public decimal? BidLevel1Price;
		/// <summary>
		/// 매수최우선잔량
		/// </summary>
		[JsonProperty("buy_fpr_req")]
		public decimal? BidLevel1Quantity;
		/// <summary>
		/// 매수1차선잔량대비
		/// </summary>
		[JsonProperty("buy_1th_pre_req_pre")]
		public KiwoomDecimal? BidLevel1PrevDiff;
		/// <summary>
		/// 매수2차선호가
		/// </summary>
		[JsonProperty("buy_2th_pre_bid")]
		public decimal? BidLevel2Price;
		/// <summary>
		/// 매수2차선잔량
		/// </summary>
		[JsonProperty("buy_2th_pre_req")]
		public decimal? BidLevel2Quantity;
		/// <summary>
		/// 매수2차선잔량대비
		/// </summary>
		[JsonProperty("buy_2th_pre_req_pre")]
		public KiwoomDecimal? BidLevel2PrevDiff;
		/// <summary>
		/// 매수3차선호가
		/// </summary>
		[JsonProperty("buy_3th_pre_bid")]
		public decimal? BidLevel3Price;
		/// <summary>
		/// 매수3차선잔량
		/// </summary>
		[JsonProperty("buy_3th_pre_req")]
		public decimal? BidLevel3Quantity;
		/// <summary>
		/// 매수3차선잔량대비
		/// </summary>
		[JsonProperty("buy_3th_pre_req_pre")]
		public KiwoomDecimal? BidLevel3PrevDiff;
		/// <summary>
		/// 매수4차선호가
		/// </summary>
		[JsonProperty("buy_4th_pre_bid")]
		public decimal? BidLevel4Price;
		/// <summary>
		/// 매수4차선잔량
		/// </summary>
		[JsonProperty("buy_4th_pre_req")]
		public decimal? BidLevel4Quantity;
		/// <summary>
		/// 매수4차선잔량대비
		/// </summary>
		[JsonProperty("buy_4th_pre_req_pre")]
		public KiwoomDecimal? BidLevel4PrevDiff;
		/// <summary>
		/// 매수5차선호가
		/// </summary>
		[JsonProperty("buy_5th_pre_bid")]
		public decimal? BidLevel5Price;
		/// <summary>
		/// 매수5차선잔량
		/// </summary>
		[JsonProperty("buy_5th_pre_req")]
		public decimal? BidLevel5Quantity;
		/// <summary>
		/// 매수5차선잔량대비
		/// </summary>
		[JsonProperty("buy_5th_pre_req_pre")]
		public KiwoomDecimal? BidLevel5PrevDiff;
		/// <summary>
		/// 매수6차선호가
		/// </summary>
		[JsonProperty("buy_6th_pre_bid")]
		public decimal? BidLevel6Price;
		/// <summary>
		/// 매수6차선잔량
		/// </summary>
		[JsonProperty("buy_6th_pre_req")]
		public decimal? BidLevel6Quantity;
		/// <summary>
		/// 매수6차선잔량대비
		/// </summary>
		[JsonProperty("buy_6th_pre_req_pre")]
		public KiwoomDecimal? BidLevel6PrevDiff;
		/// <summary>
		/// 매수7차선호가
		/// </summary>
		[JsonProperty("buy_7th_pre_bid")]
		public decimal? BidLevel7Price;
		/// <summary>
		/// 매수7차선잔량
		/// </summary>
		[JsonProperty("buy_7th_pre_req")]
		public decimal? BidLevel7Quantity;
		/// <summary>
		/// 매수7차선잔량대비
		/// </summary>
		[JsonProperty("buy_7th_pre_req_pre")]
		public KiwoomDecimal? BidLevel7PrevDiff;
		/// <summary>
		/// 매수8차선호가
		/// </summary>
		[JsonProperty("buy_8th_pre_bid")]
		public decimal? BidLevel8Price;
		/// <summary>
		/// 매수8차선잔량
		/// </summary>
		[JsonProperty("buy_8th_pre_req")]
		public decimal? BidLevel8Quantity;
		/// <summary>
		/// 매수8차선잔량대비
		/// </summary>
		[JsonProperty("buy_8th_pre_req_pre")]
		public KiwoomDecimal? BidLevel8PrevDiff;
		/// <summary>
		/// 매수9차선호가
		/// </summary>
		[JsonProperty("buy_9th_pre_bid")]
		public decimal? BidLevel9Price;
		/// <summary>
		/// 매수9차선잔량
		/// </summary>
		[JsonProperty("buy_9th_pre_req")]
		public decimal? BidLevel9Quantity;
		/// <summary>
		/// 매수9차선잔량대비
		/// </summary>
		[JsonProperty("buy_9th_pre_req_pre")]
		public KiwoomDecimal? BidLevel9PrevDiff;
		/// <summary>
		/// 매수10차선호가
		/// </summary>
		[JsonProperty("buy_10th_pre_bid")]
		public decimal? BidLevel10Price;
		/// <summary>
		/// 매수10차선잔량
		/// </summary>
		[JsonProperty("buy_10th_pre_req")]
		public decimal? BidLevel10Quantity;
		/// <summary>
		/// 매수10차선잔량대비
		/// </summary>
		[JsonProperty("buy_10th_pre_req_pre")]
		public KiwoomDecimal? BidLevel10PrevDiff;
		/// <summary>
		/// 총매도잔량직전대비
		/// </summary>
		[JsonProperty("tot_sel_req_jub_pre")]
		public decimal? TotalAskQuantityPrevDiff;
		/// <summary>
		/// 총매도잔량
		/// </summary>
		[JsonProperty("tot_sel_req")]
		public decimal? TotalAskQuantity;
		/// <summary>
		/// 총매수잔량
		/// </summary>
		[JsonProperty("tot_buy_req")]
		public decimal? TotalBidQuantity;
		/// <summary>
		/// 총매수잔량직전대비
		/// </summary>
		[JsonProperty("tot_buy_req_jub_pre")]
		public KiwoomDecimal? TotalBidQuantityPrevDiff;
		/// <summary>
		/// 시간외매도잔량대비
		/// </summary>
		[JsonProperty("ovt_sel_req_pre")]
		public decimal? AfterHoursAskQuantityPrevDiff;
		/// <summary>
		/// 시간외매도잔량
		/// </summary>
		[JsonProperty("ovt_sel_req")]
		public decimal? AfterHoursAskQuantity;
		/// <summary>
		/// 시간외매수잔량
		/// </summary>
		[JsonProperty("ovt_buy_req")]
		public decimal? AfterHoursBidQuantity;
		/// <summary>
		/// 시간외매수잔량대비
		/// </summary>
		[JsonProperty("ovt_buy_req_pre")]
		public KiwoomDecimal? AfterHoursBidQuantityPrevDiff;
	}

	public record PriceVolumeDiff
	{
		/// <summary>
		/// 가격
		/// </summary>
		public decimal? Price;
		/// <summary>
		/// 수량
		/// </summary>
		public decimal? Quantity;
		/// <summary>
		/// 전일대비 차이
		/// </summary>
		public decimal? PrevDiff;

		public PriceVolumeDiff(decimal? price, decimal? quantity, decimal? prevDiff)
		{
			Price = price;
			Quantity = quantity;
			PrevDiff = prevDiff;
		}
	}

	public record KiwoomMarketConditionGetOrderBookList
	{
		/// <summary>
		/// 호가잔량기준시간
		/// </summary>
		public TimeSpan? BidRequestBaseTime;
		/// <summary>
		/// 매도호가
		/// </summary>
		public PriceVolumeDiff[] AskLevels;
		/// <summary>
		/// 매수호가
		/// </summary>
		public PriceVolumeDiff[] BidLevels;
		/// <summary>
		/// 총매도잔량직전대비
		/// </summary>
		public decimal? TotalAskQuantityPrevDiff;
		/// <summary>
		/// 총매도잔량
		/// </summary>
		public decimal? TotalAskQuantity;
		/// <summary>
		/// 총매수잔량
		/// </summary>
		public decimal? TotalBidQuantity;
		/// <summary>
		/// 총매수잔량직전대비
		/// </summary>
		public decimal? TotalBidQuantityPrevDiff;
		/// <summary>
		/// 시간외매도잔량대비
		/// </summary>
		public decimal? AfterHoursAskQuantityPrevDiff;
		/// <summary>
		/// 시간외매도잔량
		/// </summary>
		public decimal? AfterHoursAskQuantity;
		/// <summary>
		/// 시간외매수잔량
		/// </summary>
		public decimal? AfterHoursBidQuantity;
		/// <summary>
		/// 시간외매수잔량대비
		/// </summary>
		public decimal? AfterHoursBidQuantityPrevDiff;

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
		/// <summary>
		/// 날짜
		/// </summary>
		[JsonProperty("date")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		/// <summary>
		/// 시가
		/// </summary>
		[JsonProperty("open_pric")]
		public decimal? OpenPrice;
		/// <summary>
		/// 고가
		/// </summary>
		[JsonProperty("high_pric")]
		public decimal? HighPrice;
		/// <summary>
		/// 저가
		/// </summary>
		[JsonProperty("low_pric")]
		public decimal? LowPrice;
		/// <summary>
		/// 종가
		/// </summary>
		[JsonProperty("close_pric")]
		public decimal? ClosePrice;
		/// <summary>
		/// 대비
		/// </summary>
		[JsonProperty("pre")]
		public decimal? PrevDiff;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? TradeQuantity;
		/// <summary>
		/// 거래대금
		/// </summary>
		[JsonProperty("trde_prica")]
		public decimal? TradeAmount;
		/// <summary>
		/// 외인보유
		/// </summary>
		[JsonProperty("for_poss")]
		public decimal? ForeignPossession;
		/// <summary>
		/// 외인비중
		/// </summary>
		[JsonProperty("for_wght")]
		public decimal? ForeignWeight;
		/// <summary>
		/// 외인순매수
		/// </summary>
		[JsonProperty("for_netprps")]
		public decimal? ForeignNetPurchase;
		/// <summary>
		/// 기관순매수
		/// </summary>
		[JsonProperty("orgn_netprps")]
		public decimal? InstitutionNetPurchase;
		/// <summary>
		/// 개인순매수
		/// </summary>
		[JsonProperty("ind_netprps")]
		public decimal? IndividualNetPurchase;
		/// <summary>
		/// 신용잔고율
		/// </summary>
		[JsonProperty("crd_remn_rt")]
		public decimal? CreditRemainingRate;
		/// <summary>
		/// 외국계
		/// </summary>
		[JsonProperty("frgn")]
		public decimal? ForeignBrokerage;
		/// <summary>
		/// 프로그램
		/// </summary>
		[JsonProperty("prm")]
		public decimal? ProgramTrading;
	}

	public record KiwoomMarketConditionGetHourMinute
	{
		/// <summary>
		/// 날짜
		/// </summary>
		[JsonProperty("date")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		/// <summary>
		/// 시가
		/// </summary>
		[JsonProperty("open_pric")]
		public decimal? OpenPrice;
		/// <summary>
		/// 고가
		/// </summary>
		[JsonProperty("high_pric")]
		public decimal? HighPrice;
		/// <summary>
		/// 저가
		/// </summary>
		[JsonProperty("low_pric")]
		public decimal? LowPrice;
		/// <summary>
		/// 종가
		/// </summary>
		[JsonProperty("close_pric")]
		public decimal? ClosePrice;
		/// <summary>
		/// 대비
		/// </summary>
		[JsonProperty("pre")]
		public decimal? PrevDiff;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? TradeQuantity;
		/// <summary>
		/// 거래대금
		/// </summary>
		[JsonProperty("trde_prica")]
		public decimal? TradeAmount;
		/// <summary>
		/// 체결강도
		/// </summary>
		[JsonProperty("cntr_str")]
		public decimal? ContractStrength;
	}

	public record KiwoomMarketConditionGetQuote
	{
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 날짜
		/// </summary>
		[JsonProperty("date")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		/// <summary>
		/// 시간
		/// </summary>
		[JsonProperty("tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? Time;
		/// <summary>
		/// 전일종가
		/// </summary>
		[JsonProperty("pred_close_pric")]
		public decimal? PrevClosePrice;
		/// <summary>
		/// 전일거래량
		/// </summary>
		[JsonProperty("pred_trde_qty")]
		public decimal? PrevTradeQuantity;
		/// <summary>
		/// 상한가
		/// </summary>
		[JsonProperty("upl_pric")]
		public decimal? UpperPrice;
		/// <summary>
		/// 하한가
		/// </summary>
		[JsonProperty("lst_pric")]
		public decimal? LowerPrice;
		/// <summary>
		/// 전일거래대금
		/// </summary>
		[JsonProperty("pred_trde_prica")]
		public decimal? PrevTradeAmount;
		/// <summary>
		/// 상장주식수
		/// </summary>
		[JsonProperty("flo_stkcnt")]
		public decimal? ListedShares;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		/// <summary>
		/// 부호
		/// </summary>
		[JsonProperty("smbol")]
		public string? Sign;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		/// <summary>
		/// 전일비
		/// </summary>
		[JsonProperty("pred_rt")]
		public decimal? PrevRate;
		/// <summary>
		/// 시가
		/// </summary>
		[JsonProperty("open_pric")]
		public decimal? OpenPrice;
		/// <summary>
		/// 고가
		/// </summary>
		[JsonProperty("high_pric")]
		public decimal? HighPrice;
		/// <summary>
		/// 저가
		/// </summary>
		[JsonProperty("low_pric")]
		public decimal? LowPrice;
		/// <summary>
		/// 체결량
		/// </summary>
		[JsonProperty("cntr_qty")]
		public decimal? ContractQuantity;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? TradeQuantity;
		/// <summary>
		/// 거래대금
		/// </summary>
		[JsonProperty("trde_prica")]
		public decimal? TradeAmount;
		/// <summary>
		/// 예상체결가
		/// </summary>
		[JsonProperty("exp_cntr_pric")]
		public decimal? ExpectedContractPrice;
		/// <summary>
		/// 예상체결량
		/// </summary>
		[JsonProperty("exp_cntr_qty")]
		public decimal? ExpectedContractQuantity;
		/// <summary>
		/// 예상매도우선호가
		/// </summary>
		[JsonProperty("exp_sel_pri_bid")]
		public decimal? ExpectedSellPriorityBid;
		/// <summary>
		/// 예상매수우선호가
		/// </summary>
		[JsonProperty("exp_buy_pri_bid")]
		public decimal? ExpectedBuyPriorityBid;
		/// <summary>
		/// 거래시작일
		/// </summary>
		[JsonProperty("trde_strt_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? TradeStartDate;
		/// <summary>
		/// 행사가격
		/// </summary>
		[JsonProperty("exec_pric")]
		public decimal? ExercisePrice;
		/// <summary>
		/// 최고가
		/// </summary>
		[JsonProperty("hgst_pric")]
		public decimal? HighestPrice;
		/// <summary>
		/// 최저가
		/// </summary>
		[JsonProperty("lwst_pric")]
		public decimal? LowestPrice;
		/// <summary>
		/// 최고가일
		/// </summary>
		[JsonProperty("hgst_pric_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? HighestPriceDate;
		/// <summary>
		/// 최저가일
		/// </summary>
		[JsonProperty("lwst_pric_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? LowestPriceDate;
		/// <summary>
		/// 매도1호가
		/// </summary>
		[JsonProperty("sel_1bid")]
		public decimal? Sell1Price;
		/// <summary>
		/// 매도2호가
		/// </summary>
		[JsonProperty("sel_2bid")]
		public decimal? Sell2Price;
		/// <summary>
		/// 매도3호가
		/// </summary>
		[JsonProperty("sel_3bid")]
		public decimal? Sell3Price;
		/// <summary>
		/// 매도4호가
		/// </summary>
		[JsonProperty("sel_4bid")]
		public decimal? Sell4Price;
		/// <summary>
		/// 매도5호가
		/// </summary>
		[JsonProperty("sel_5bid")]
		public decimal? Sell5Price;
		/// <summary>
		/// 매도6호가
		/// </summary>
		[JsonProperty("sel_6bid")]
		public decimal? Sell6Price;
		/// <summary>
		/// 매도7호가
		/// </summary>
		[JsonProperty("sel_7bid")]
		public decimal? Sell7Price;
		/// <summary>
		/// 매도8호가
		/// </summary>
		[JsonProperty("sel_8bid")]
		public decimal? Sell8Price;
		/// <summary>
		/// 매도9호가
		/// </summary>
		[JsonProperty("sel_9bid")]
		public decimal? Sell9Price;
		/// <summary>
		/// 매도10호가
		/// </summary>
		[JsonProperty("sel_10bid")]
		public decimal? Sell10Price;
		/// <summary>
		/// 매수1호가
		/// </summary>
		[JsonProperty("buy_1bid")]
		public decimal? Buy1Price;
		/// <summary>
		/// 매수2호가
		/// </summary>
		[JsonProperty("buy_2bid")]
		public decimal? Buy2Price;
		/// <summary>
		/// 매수3호가
		/// </summary>
		[JsonProperty("buy_3bid")]
		public decimal? Buy3Price;
		/// <summary>
		/// 매수4호가
		/// </summary>
		[JsonProperty("buy_4bid")]
		public decimal? Buy4Price;
		/// <summary>
		/// 매수5호가
		/// </summary>
		[JsonProperty("buy_5bid")]
		public decimal? Buy5Price;
		/// <summary>
		/// 매수6호가
		/// </summary>
		[JsonProperty("buy_6bid")]
		public decimal? Buy6Price;
		/// <summary>
		/// 매수7호가
		/// </summary>
		[JsonProperty("buy_7bid")]
		public decimal? Buy7Price;
		/// <summary>
		/// 매수8호가
		/// </summary>
		[JsonProperty("buy_8bid")]
		public decimal? Buy8Price;
		/// <summary>
		/// 매수9호가
		/// </summary>
		[JsonProperty("buy_9bid")]
		public decimal? Buy9Price;
		/// <summary>
		/// 매수10호가
		/// </summary>
		[JsonProperty("buy_10bid")]
		public decimal? Buy10Price;
		/// <summary>
		/// 매도1호가잔량
		/// </summary>
		[JsonProperty("sel_1bid_req")]
		public decimal? Sell1Quantity;
		/// <summary>
		/// 매도2호가잔량
		/// </summary>
		[JsonProperty("sel_2bid_req")]
		public decimal? Sell2Quantity;
		/// <summary>
		/// 매도3호가잔량
		/// </summary>
		[JsonProperty("sel_3bid_req")]
		public decimal? Sell3Quantity;
		/// <summary>
		/// 매도4호가잔량
		/// </summary>
		[JsonProperty("sel_4bid_req")]
		public decimal? Sell4Quantity;
		/// <summary>
		/// 매도5호가잔량
		/// </summary>
		[JsonProperty("sel_5bid_req")]
		public decimal? Sell5Quantity;
		/// <summary>
		/// 매도6호가잔량
		/// </summary>
		[JsonProperty("sel_6bid_req")]
		public decimal? Sell6Quantity;
		/// <summary>
		/// 매도7호가잔량
		/// </summary>
		[JsonProperty("sel_7bid_req")]
		public decimal? Sell7Quantity;
		/// <summary>
		/// 매도8호가잔량
		/// </summary>
		[JsonProperty("sel_8bid_req")]
		public decimal? Sell8Quantity;
		/// <summary>
		/// 매도9호가잔량
		/// </summary>
		[JsonProperty("sel_9bid_req")]
		public decimal? Sell9Quantity;
		/// <summary>
		/// 매도10호가잔량
		/// </summary>
		[JsonProperty("sel_10bid_req")]
		public decimal? Sell10Quantity;
		/// <summary>
		/// 매수1호가잔량
		/// </summary>
		[JsonProperty("buy_1bid_req")]
		public decimal? Buy1Quantity;
		/// <summary>
		/// 매수2호가잔량
		/// </summary>
		[JsonProperty("buy_2bid_req")]
		public decimal? Buy2Quantity;
		/// <summary>
		/// 매수3호가잔량
		/// </summary>
		[JsonProperty("buy_3bid_req")]
		public decimal? Buy3Quantity;
		/// <summary>
		/// 매수4호가잔량
		/// </summary>
		[JsonProperty("buy_4bid_req")]
		public decimal? Buy4Quantity;
		/// <summary>
		/// 매수5호가잔량
		/// </summary>
		[JsonProperty("buy_5bid_req")]
		public decimal? Buy5Quantity;
		/// <summary>
		/// 매수6호가잔량
		/// </summary>
		[JsonProperty("buy_6bid_req")]
		public decimal? Buy6Quantity;
		/// <summary>
		/// 매수7호가잔량
		/// </summary>
		[JsonProperty("buy_7bid_req")]
		public decimal? Buy7Quantity;
		/// <summary>
		/// 매수8호가잔량
		/// </summary>
		[JsonProperty("buy_8bid_req")]
		public decimal? Buy8Quantity;
		/// <summary>
		/// 매수9호가잔량
		/// </summary>
		[JsonProperty("buy_9bid_req")]
		public decimal? Buy9Quantity;
		/// <summary>
		/// 매수10호가잔량
		/// </summary>
		[JsonProperty("buy_10bid_req")]
		public decimal? Buy10Quantity;
		/// <summary>
		/// 매도1호가직전대비
		/// </summary>
		[JsonProperty("sel_1bid_jub_pre")]
		public KiwoomDecimal? Sell1PrevDiff;
		/// <summary>
		/// 매도2호가직전대비
		/// </summary>
		[JsonProperty("sel_2bid_jub_pre")]
		public KiwoomDecimal? Sell2PrevDiff;
		/// <summary>
		/// 매도3호가직전대비
		/// </summary>
		[JsonProperty("sel_3bid_jub_pre")]
		public KiwoomDecimal? Sell3PrevDiff;
		/// <summary>
		/// 매도4호가직전대비
		/// </summary>
		[JsonProperty("sel_4bid_jub_pre")]
		public KiwoomDecimal? Sell4PrevDiff;
		/// <summary>
		/// 매도5호가직전대비
		/// </summary>
		[JsonProperty("sel_5bid_jub_pre")]
		public KiwoomDecimal? Sell5PrevDiff;
		/// <summary>
		/// 매도6호가직전대비
		/// </summary>
		[JsonProperty("sel_6bid_jub_pre")]
		public KiwoomDecimal? Sell6PrevDiff;
		/// <summary>
		/// 매도7호가직전대비
		/// </summary>
		[JsonProperty("sel_7bid_jub_pre")]
		public KiwoomDecimal? Sell7PrevDiff;
		/// <summary>
		/// 매도8호가직전대비
		/// </summary>
		[JsonProperty("sel_8bid_jub_pre")]
		public KiwoomDecimal? Sell8PrevDiff;
		/// <summary>
		/// 매도9호가직전대비
		/// </summary>
		[JsonProperty("sel_9bid_jub_pre")]
		public KiwoomDecimal? Sell9PrevDiff;
		/// <summary>
		/// 매도10호가직전대비
		/// </summary>
		[JsonProperty("sel_10bid_jub_pre")]
		public KiwoomDecimal? Sell10PrevDiff;
		/// <summary>
		/// 매수1호가직전대비
		/// </summary>
		[JsonProperty("buy_1bid_jub_pre")]
		public KiwoomDecimal? Buy1PrevDiff;
		/// <summary>
		/// 매수2호가직전대비
		/// </summary>
		[JsonProperty("buy_2bid_jub_pre")]
		public KiwoomDecimal? Buy2PrevDiff;
		/// <summary>
		/// 매수3호가직전대비
		/// </summary>
		[JsonProperty("buy_3bid_jub_pre")]
		public KiwoomDecimal? Buy3PrevDiff;
		/// <summary>
		/// 매수4호가직전대비
		/// </summary>
		[JsonProperty("buy_4bid_jub_pre")]
		public KiwoomDecimal? Buy4PrevDiff;
		/// <summary>
		/// 매수5호가직전대비
		/// </summary>
		[JsonProperty("buy_5bid_jub_pre")]
		public KiwoomDecimal? Buy5PrevDiff;
		/// <summary>
		/// 매수6호가직전대비
		/// </summary>
		[JsonProperty("buy_6bid_jub_pre")]
		public KiwoomDecimal? Buy6PrevDiff;
		/// <summary>
		/// 매수7호가직전대비
		/// </summary>
		[JsonProperty("buy_7bid_jub_pre")]
		public KiwoomDecimal? Buy7PrevDiff;
		/// <summary>
		/// 매수8호가직전대비
		/// </summary>
		[JsonProperty("buy_8bid_jub_pre")]
		public KiwoomDecimal? Buy8PrevDiff;
		/// <summary>
		/// 매수9호가직전대비
		/// </summary>
		[JsonProperty("buy_9bid_jub_pre")]
		public KiwoomDecimal? Buy9PrevDiff;
		/// <summary>
		/// 매수10호가직전대비
		/// </summary>
		[JsonProperty("buy_10bid_jub_pre")]
		public KiwoomDecimal? Buy10PrevDiff;
		/// <summary>
		/// 매도1호가건수
		/// </summary>
		[JsonProperty("sel_1bid_cnt")]
		public decimal? Sell1Count;
		/// <summary>
		/// 매도2호가건수
		/// </summary>
		[JsonProperty("sel_2bid_cnt")]
		public decimal? Sell2Count;
		/// <summary>
		/// 매도3호가건수
		/// </summary>
		[JsonProperty("sel_3bid_cnt")]
		public decimal? Sell3Count;
		/// <summary>
		/// 매도4호가건수
		/// </summary>
		[JsonProperty("sel_4bid_cnt")]
		public decimal? Sell4Count;
		/// <summary>
		/// 매도5호가건수
		/// </summary>
		[JsonProperty("sel_5bid_cnt")]
		public decimal? Sell5Count;
		/// <summary>
		/// 매수1호가건수
		/// </summary>
		[JsonProperty("buy_1bid_cnt")]
		public decimal? Buy1Count;
		/// <summary>
		/// 매수2호가건수
		/// </summary>
		[JsonProperty("buy_2bid_cnt")]
		public decimal? Buy2Count;
		/// <summary>
		/// 매수3호가건수
		/// </summary>
		[JsonProperty("buy_3bid_cnt")]
		public decimal? Buy3Count;
		/// <summary>
		/// 매수4호가건수
		/// </summary>
		[JsonProperty("buy_4bid_cnt")]
		public decimal? Buy4Count;
		/// <summary>
		/// 매수5호가건수
		/// </summary>
		[JsonProperty("buy_5bid_cnt")]
		public decimal? Buy5Count;
		/// <summary>
		/// LP매도1호가잔량
		/// </summary>
		[JsonProperty("lpsel_1bid_req")]
		public decimal? LpSell1Quantity;
		/// <summary>
		/// LP매도2호가잔량
		/// </summary>
		[JsonProperty("lpsel_2bid_req")]
		public decimal? LpSell2Quantity;
		/// <summary>
		/// LP매도3호가잔량
		/// </summary>
		[JsonProperty("lpsel_3bid_req")]
		public decimal? LpSell3Quantity;
		/// <summary>
		/// LP매도4호가잔량
		/// </summary>
		[JsonProperty("lpsel_4bid_req")]
		public decimal? LpSell4Quantity;
		/// <summary>
		/// LP매도5호가잔량
		/// </summary>
		[JsonProperty("lpsel_5bid_req")]
		public decimal? LpSell5Quantity;
		/// <summary>
		/// LP매도6호가잔량
		/// </summary>
		[JsonProperty("lpsel_6bid_req")]
		public decimal? LpSell6Quantity;
		/// <summary>
		/// LP매도7호가잔량
		/// </summary>
		[JsonProperty("lpsel_7bid_req")]
		public decimal? LpSell7Quantity;
		/// <summary>
		/// LP매도8호가잔량
		/// </summary>
		[JsonProperty("lpsel_8bid_req")]
		public decimal? LpSell8Quantity;
		/// <summary>
		/// LP매도9호가잔량
		/// </summary>
		[JsonProperty("lpsel_9bid_req")]
		public decimal? LpSell9Quantity;
		/// <summary>
		/// LP매도10호가잔량
		/// </summary>
		[JsonProperty("lpsel_10bid_req")]
		public decimal? LpSell10Quantity;
		/// <summary>
		/// LP매수1호가잔량
		/// </summary>
		[JsonProperty("lpbuy_1bid_req")]
		public decimal? LpBuy1Quantity;
		/// <summary>
		/// LP매수2호가잔량
		/// </summary>
		[JsonProperty("lpbuy_2bid_req")]
		public decimal? LpBuy2Quantity;
		/// <summary>
		/// LP매수3호가잔량
		/// </summary>
		[JsonProperty("lpbuy_3bid_req")]
		public decimal? LpBuy3Quantity;
		/// <summary>
		/// LP매수4호가잔량
		/// </summary>
		[JsonProperty("lpbuy_4bid_req")]
		public decimal? LpBuy4Quantity;
		/// <summary>
		/// LP매수5호가잔량
		/// </summary>
		[JsonProperty("lpbuy_5bid_req")]
		public decimal? LpBuy5Quantity;
		/// <summary>
		/// LP매수6호가잔량
		/// </summary>
		[JsonProperty("lpbuy_6bid_req")]
		public decimal? LpBuy6Quantity;
		/// <summary>
		/// LP매수7호가잔량
		/// </summary>
		[JsonProperty("lpbuy_7bid_req")]
		public decimal? LpBuy7Quantity;
		/// <summary>
		/// LP매수8호가잔량
		/// </summary>
		[JsonProperty("lpbuy_8bid_req")]
		public decimal? LpBuy8Quantity;
		/// <summary>
		/// LP매수9호가잔량
		/// </summary>
		[JsonProperty("lpbuy_9bid_req")]
		public decimal? LpBuy9Quantity;
		/// <summary>
		/// LP매수10호가잔량
		/// </summary>
		[JsonProperty("lpbuy_10bid_req")]
		public decimal? LpBuy10Quantity;
		/// <summary>
		/// 총매수잔량
		/// </summary>
		[JsonProperty("tot_buy_req")]
		public decimal? TotalBuyQuantity;
		/// <summary>
		/// 총매도잔량
		/// </summary>
		[JsonProperty("tot_sel_req")]
		public decimal? TotalSellQuantity;
		/// <summary>
		/// 총매수건수
		/// </summary>
		[JsonProperty("tot_buy_cnt")]
		public decimal? TotalBuyCount;
		/// <summary>
		/// 총매도건수
		/// </summary>
		[JsonProperty("tot_sel_cnt")]
		public decimal? TotalSellCount;
	}

	public record KiwoomMarketConditionGetQuoteList
	{
		/// <summary>
		/// 종목명
		/// </summary>
		public string? StockName;
		/// <summary>
		/// 종목코드
		/// </summary>
		public string? StockCode;
		/// <summary>
		/// 날짜
		/// </summary>
		public DateTime? Date;
		/// <summary>
		/// 시간
		/// </summary>
		public TimeSpan? Time;
		/// <summary>
		/// 전일종가
		/// </summary>
		public decimal? PrevClosePrice;
		/// <summary>
		/// 전일거래량
		/// </summary>
		public decimal? PrevTradeQuantity;
		/// <summary>
		/// 상한가
		/// </summary>
		public decimal? UpperPrice;
		/// <summary>
		/// 하한가
		/// </summary>
		public decimal? LowerPrice;
		/// <summary>
		/// 전일거래대금
		/// </summary>
		public decimal? PrevTradeAmount;
		/// <summary>
		/// 상장주식수
		/// </summary>
		public decimal? ListedShares;
		/// <summary>
		/// 현재가
		/// </summary>
		public decimal? CurrentPrice;
		/// <summary>
		/// 부호
		/// </summary>
		public string? Sign;
		/// <summary>
		/// 등락률
		/// </summary>
		public decimal? FluctuationRate;
		/// <summary>
		/// 전일비
		/// </summary>
		public decimal? PrevRate;
		/// <summary>
		/// 시가
		/// </summary>
		public decimal? OpenPrice;
		/// <summary>
		/// 고가
		/// </summary>
		public decimal? HighPrice;
		/// <summary>
		/// 저가
		/// </summary>
		public decimal? LowPrice;
		/// <summary>
		/// 체결량
		/// </summary>
		public decimal? ContractQuantity;
		/// <summary>
		/// 거래량
		/// </summary>
		public decimal? TradeQuantity;
		/// <summary>
		/// 거래대금
		/// </summary>
		public decimal? TradeAmount;
		/// <summary>
		/// 예상체결가
		/// </summary>
		public decimal? ExpectedContractPrice;
		/// <summary>
		/// 예상체결량
		/// </summary>
		public decimal? ExpectedContractQuantity;
		/// <summary>
		/// 예상매도우선호가
		/// </summary>
		public decimal? ExpectedSellPriorityBid;
		/// <summary>
		/// 예상매수우선호가
		/// </summary>
		public decimal? ExpectedBuyPriorityBid;
		/// <summary>
		/// 거래시작일
		/// </summary>
		public DateTime? TradeStartDate;
		/// <summary>
		/// 행사가격
		/// </summary>
		public decimal? ExercisePrice;
		/// <summary>
		/// 최고가
		/// </summary>
		public decimal? HighestPrice;
		/// <summary>
		/// 최저가
		/// </summary>
		public decimal? LowestPrice;
		/// <summary>
		/// 최고가일
		/// </summary>
		public DateTime? HighestPriceDate;
		/// <summary>
		/// 최저가일
		/// </summary>
		public DateTime? LowestPriceDate;

		/// <summary>
		/// 매도호가
		/// </summary>
		public decimal?[] SellPrices;
		/// <summary>
		/// 매수호가
		/// </summary>
		public decimal?[] BuyPrices;
		/// <summary>
		/// 매도잔량
		/// </summary>
		public decimal?[] SellQuantities;
		/// <summary>
		/// 매수잔량
		/// </summary>
		public decimal?[] BuyQuantities;
		/// <summary>
		/// 매도호가직전대비
		/// </summary>
		public decimal?[] SellPrevDiffs;
		/// <summary>
		/// 매수호가직전대비
		/// </summary>
		public decimal?[] BuyPrevDiffs;
		/// <summary>
		/// 매도호가건수
		/// </summary>
		public decimal?[] SellCounts;
		/// <summary>
		/// 매수호가건수
		/// </summary>
		public decimal?[] BuyCounts;
		/// <summary>
		/// LP매도호가잔량
		/// </summary>
		public decimal?[] LpSellQuantities;
		/// <summary>
		/// LP매수호가잔량
		/// </summary>
		public decimal?[] LpBuyQuantities;

		/// <summary>
		/// 총매수잔량
		/// </summary>
		public decimal? TotalBuyQuantity;
		/// <summary>
		/// 총매도잔량
		/// </summary>
		public decimal? TotalSellQuantity;
		/// <summary>
		/// 총매수건수
		/// </summary>
		public decimal? TotalBuyCount;
		/// <summary>
		/// 총매도건수
		/// </summary>
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
		/// <summary>
		/// 신주인수권시세
		/// </summary>
		[JsonProperty("newstk_recvrht_mrpr")]
		public IEnumerable<KiwoomMarketConditionGetAllMarketQuoteForRightsOfferingItem>? Items;
	}
	public record KiwoomMarketConditionGetAllMarketQuoteForRightsOfferingItem
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? PrevDiffSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PrevDiff;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		/// <summary>
		/// 최우선매도호가
		/// </summary>
		[JsonProperty("fpr_sel_bid")]
		public decimal? FirstPrioritySellBid;
		/// <summary>
		/// 최우선매수호가
		/// </summary>
		[JsonProperty("fpr_buy_bid")]
		public decimal? FirstPriorityBuyBid;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? AccumulatedTradeQuantity;
		/// <summary>
		/// 시가
		/// </summary>
		[JsonProperty("open_pric")]
		public decimal? OpenPrice;
		/// <summary>
		/// 고가
		/// </summary>
		[JsonProperty("high_pric")]
		public decimal? HighPrice;
		/// <summary>
		/// 저가
		/// </summary>
		[JsonProperty("low_pric")]
		public decimal? LowPrice;
	}

	public record KiwoomMarketConditionGetDailyInstitutionTradingStocks
	{
		/// <summary>
		/// 일별기관매매종목
		/// </summary>
		[JsonProperty("daly_orgn_trde_stk")]
		public IEnumerable<KiwoomMarketConditionGetDailyInstitutionTradingStockItem>? Items;
	}
	public record KiwoomMarketConditionGetDailyInstitutionTradingStockItem
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 순매수수량
		/// </summary>
		[JsonProperty("netprps_qty")]
		public decimal? NetPurchaseQuantity;
		/// <summary>
		/// 순매수금액
		/// </summary>
		[JsonProperty("netprps_amt")]
		public decimal? NetPurchaseAmount;
	}

	public record KiwoomMarketConditionGetStockOriginTradeTrends
	{
		/// <summary>
		/// 기관추정평균가
		/// </summary>
		[JsonProperty("orgn_prsm_avg_pric")]
		public decimal? InstitutionEstimatedAvgPrice;
		/// <summary>
		/// 외인추정평균가
		/// </summary>
		[JsonProperty("for_prsm_avg_pric")]
		public decimal? ForeignEstimatedAvgPrice;
		/// <summary>
		/// 종목별기관매매추이
		/// </summary>
		[JsonProperty("stk_orgn_trde_trnsn")]
		public IEnumerable<KiwoomMarketConditionGetStockOriginTradeTrendItem>? Items;
	}
	public record KiwoomMarketConditionGetStockOriginTradeTrendItem
	{
		/// <summary>
		/// 일자
		/// </summary>
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		/// <summary>
		/// 종가
		/// </summary>
		[JsonProperty("close_pric")]
		public decimal? ClosePrice;
		/// <summary>
		/// 대비기호
		/// </summary>
		[JsonProperty("pre_sig")]
		public string? PrevDiffSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PrevDiff;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? TradeQuantity;
		/// <summary>
		/// 기관기간누적
		/// </summary>
		[JsonProperty("orgn_dt_acc")]
		public decimal? InstitutionPeriodAccumulation;
		/// <summary>
		/// 기관일별순매매수량
		/// </summary>
		[JsonProperty("orgn_daly_nettrde_qty")]
		public decimal? InstitutionDailyNetTradeQuantity;
		/// <summary>
		/// 외인기간누적
		/// </summary>
		[JsonProperty("for_dt_acc")]
		public decimal? ForeignPeriodAccumulation;
		/// <summary>
		/// 외인일별순매매수량
		/// </summary>
		[JsonProperty("for_daly_nettrde_qty")]
		public decimal? ForeignDailyNetTradeQuantity;
		/// <summary>
		/// 한도소진율
		/// </summary>
		[JsonProperty("limit_exh_rt")]
		public decimal? LimitExhaustionRate;
	}

	public record KiwoomMarketConditionGetHourlyContractStrengths
	{
		/// <summary>
		/// 체결강도시간별
		/// </summary>
		[JsonProperty("cntr_str_tm")]
		public IEnumerable<KiwoomMarketConditionGetHourlyContractStrengthItem>? Items;
	}
	public record KiwoomMarketConditionGetHourlyContractStrengthItem
	{
		/// <summary>
		/// 체결시간
		/// </summary>
		[JsonProperty("cntr_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? ContractTime;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PrevDiff;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? PrevDiffSign;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? TradeQuantity;
		/// <summary>
		/// 누적거래대금
		/// </summary>
		[JsonProperty("acc_trde_prica")]
		public decimal? AccumulatedTradeAmount;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? AccumulatedTradeQuantity;
		/// <summary>
		/// 체결강도
		/// </summary>
		[JsonProperty("cntr_str")]
		public decimal? ContractStrength;
		/// <summary>
		/// 체결강도5분
		/// </summary>
		[JsonProperty("cntr_str_5min")]
		public decimal? ContractStrength5Min;
		/// <summary>
		/// 체결강도20분
		/// </summary>
		[JsonProperty("cntr_str_20min")]
		public decimal? ContractStrength20Min;
		/// <summary>
		/// 체결강도60분
		/// </summary>
		[JsonProperty("cntr_str_60min")]
		public decimal? ContractStrength60Min;
		/// <summary>
		/// 거래소구분
		/// </summary>
		[JsonProperty("stex_tp")]
		public string? ExchangeType;
	}

	public record KiwoomMarketConditionGetDailyContractStrengths
	{
		/// <summary>
		/// 체결강도일별
		/// </summary>
		[JsonProperty("cntr_str_daly")]
		public IEnumerable<KiwoomMarketConditionGetDailyContractStrengthItem>? Items;
	}
	public record KiwoomMarketConditionGetDailyContractStrengthItem
	{
		/// <summary>
		/// 일자
		/// </summary>
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PrevDiff;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? PrevDiffSign;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? TradeQuantity;
		/// <summary>
		/// 누적거래대금
		/// </summary>
		[JsonProperty("acc_trde_prica")]
		public decimal? AccumulatedTradeAmount;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? AccumulatedTradeQuantity;
		/// <summary>
		/// 체결강도
		/// </summary>
		[JsonProperty("cntr_str")]
		public decimal? ContractStrength;
		/// <summary>
		/// 체결강도5일
		/// </summary>
		[JsonProperty("cntr_str_5min")]
		public decimal? ContractStrength5Days;
		/// <summary>
		/// 체결강도20일
		/// </summary>
		[JsonProperty("cntr_str_20min")]
		public decimal? ContractStrength20Days;
		/// <summary>
		/// 체결강도60일
		/// </summary>
		[JsonProperty("cntr_str_60min")]
		public decimal? ContractStrength60Days;
	}

	public record KiwoomMarketConditionGetIntradayInvestorTradings
	{
		/// <summary>
		/// 장중투자자별매매
		/// </summary>
		[JsonProperty("opmr_invsr_trde")]
		public IEnumerable<KiwoomMarketConditionGetIntradayInvestorTradingItem>? Items;
	}
	public record KiwoomMarketConditionGetIntradayInvestorTradingItem
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		/// <summary>
		/// 대비기호
		/// </summary>
		[JsonProperty("pre_sig")]
		public string? PrevDiffSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PrevDiff;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? AccumulatedTradeQuantity;
		/// <summary>
		/// 순매수수량
		/// </summary>
		[JsonProperty("netprps_qty")]
		public KiwoomDecimal? NetPurchaseQuantity;
		/// <summary>
		/// 이전시점순매수수량
		/// </summary>
		[JsonProperty("prev_pot_netprps_qty")]
		public KiwoomDecimal? PreviousPointNetPurchaseQuantity;
		/// <summary>
		/// 순매수증감
		/// </summary>
		[JsonProperty("netprps_irds")]
		public KiwoomDecimal? NetPurchaseIncreaseDecrease;
		/// <summary>
		/// 매수수량
		/// </summary>
		[JsonProperty("buy_qty")]
		public KiwoomDecimal? BuyQuantity;
		/// <summary>
		/// 매수수량증감
		/// </summary>
		[JsonProperty("buy_qty_irds")]
		public decimal? BuyQuantityIncreaseDecrease;
		/// <summary>
		/// 매도수량
		/// </summary>
		[JsonProperty("sell_qty")]
		public KiwoomDecimal? SellQuantity;
		/// <summary>
		/// 매도수량증감
		/// </summary>
		[JsonProperty("sell_qty_irds")]
		public decimal? SellQuantityIncreaseDecrease;
	}

	public record KiwoomMarketConditionGetIntradayInvestorTradeCharts
	{
		/// <summary>
		/// 장중투자자별매매차트
		/// </summary>
		[JsonProperty("opaf_invsr_trde")]
		public IEnumerable<KiwoomMarketConditionGetIntradayInvestorTradeChartItem>? Items;
	}
	public record KiwoomMarketConditionGetIntradayInvestorTradeChartItem
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		/// <summary>
		/// 대비기호
		/// </summary>
		[JsonProperty("pre_sig")]
		public string? PrevDiffSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PrevDiff;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? TradeQuantity;
		/// <summary>
		/// 개인투자자
		/// </summary>
		[JsonProperty("ind_invsr")]
		public decimal? IndividualInvestor;
		/// <summary>
		/// 외국인투자자
		/// </summary>
		[JsonProperty("frgnr_invsr")]
		public decimal? ForeignInvestor;
		/// <summary>
		/// 기관계
		/// </summary>
		[JsonProperty("orgn")]
		public decimal? Institution;
		/// <summary>
		/// 금융투자
		/// </summary>
		[JsonProperty("fnnc_invt")]
		public decimal? FinancialInvestment;
		/// <summary>
		/// 보험
		/// </summary>
		[JsonProperty("insrnc")]
		public decimal? Insurance;
		/// <summary>
		/// 투신
		/// </summary>
		[JsonProperty("invtrt")]
		public decimal? InvestmentTrust;
		/// <summary>
		/// 기타금융
		/// </summary>
		[JsonProperty("etc_fnnc")]
		public decimal? OtherFinancials;
		/// <summary>
		/// 은행
		/// </summary>
		[JsonProperty("bank")]
		public decimal? Bank;
		/// <summary>
		/// 연기금등
		/// </summary>
		[JsonProperty("penfnd_etc")]
		public decimal? PensionEtc;
		/// <summary>
		/// 사모펀드
		/// </summary>
		[JsonProperty("samo_fund")]
		public decimal? PrivateFund;
		/// <summary>
		/// 국가
		/// </summary>
		[JsonProperty("natn")]
		public decimal? Nation;
		/// <summary>
		/// 기타법인
		/// </summary>
		[JsonProperty("etc_corp")]
		public decimal? OtherCorporation;
	}

	public record KiwoomMarketConditionGetSecurityFirmStockTradeTrends
	{
		/// <summary>
		/// 증권사별종목매매동향
		/// </summary>
		[JsonProperty("sec_stk_trde_trend")]
		public IEnumerable<KiwoomMarketConditionGetSecurityFirmStockTradeTrendItem>? Items;
	}
	public record KiwoomMarketConditionGetSecurityFirmStockTradeTrendItem
	{
		/// <summary>
		/// 일자
		/// </summary>
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		/// <summary>
		/// 대비기호
		/// </summary>
		[JsonProperty("pre_sig")]
		public string? PrevDiffSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PrevDiff;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? AccumulatedTradeQuantity;
		/// <summary>
		/// 순매수수량
		/// </summary>
		[JsonProperty("netprps_qty")]
		public decimal? NetPurchaseQuantity;
		/// <summary>
		/// 매수수량
		/// </summary>
		[JsonProperty("buy_qty")]
		public decimal? BuyQuantity;
		/// <summary>
		/// 매도수량
		/// </summary>
		[JsonProperty("sell_qty")]
		public decimal? SellQuantity;
	}

	public record KiwoomMarketConditionGetDailyStockPrices
	{
		/// <summary>
		/// 일별주가
		/// </summary>
		[JsonProperty("daly_stkpc")]
		public IEnumerable<KiwoomMarketConditionGetDailyStockPriceItem>? Items;
	}
	public record KiwoomMarketConditionGetDailyStockPriceItem
	{
		/// <summary>
		/// 날짜
		/// </summary>
		[JsonProperty("date")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		/// <summary>
		/// 시가
		/// </summary>
		[JsonProperty("open_pric")]
		public decimal? OpenPrice;
		/// <summary>
		/// 고가
		/// </summary>
		[JsonProperty("high_pric")]
		public decimal? HighPrice;
		/// <summary>
		/// 저가
		/// </summary>
		[JsonProperty("low_pric")]
		public decimal? LowPrice;
		/// <summary>
		/// 종가
		/// </summary>
		[JsonProperty("close_pric")]
		public decimal? ClosePrice;
		/// <summary>
		/// 전일비
		/// </summary>
		[JsonProperty("pred_rt")]
		public decimal? PreviousRate;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? TradeQuantity;
		/// <summary>
		/// 금액(백만)
		/// </summary>
		[JsonProperty("amt_mn")]
		public decimal? AmountMillion;
		/// <summary>
		/// 신용비
		/// </summary>
		[JsonProperty("crd_rt")]
		public decimal? CreditRate;
		/// <summary>
		/// 개인
		/// </summary>
		[JsonProperty("ind")]
		public KiwoomDecimal? Individual;
		/// <summary>
		/// 기관
		/// </summary>
		[JsonProperty("orgn")]
		public KiwoomDecimal? Institution;
		/// <summary>
		/// 외인수량
		/// </summary>
		[JsonProperty("for_qty")]
		public KiwoomDecimal? ForeignQuantity;
		/// <summary>
		/// 외국계
		/// </summary>
		[JsonProperty("frgn")]
		public KiwoomDecimal? ForeignBrokerage;
		/// <summary>
		/// 프로그램
		/// </summary>
		[JsonProperty("prm")]
		public KiwoomDecimal? Program;
		/// <summary>
		/// 외인비
		/// </summary>
		[JsonProperty("for_rt")]
		public decimal? ForeignRate;
		/// <summary>
		/// 외인보유
		/// </summary>
		[JsonProperty("for_poss")]
		public decimal? ForeignPossession;
		/// <summary>
		/// 외인비중
		/// </summary>
		[JsonProperty("for_wght")]
		public decimal? ForeignWeight;
		/// <summary>
		/// 외인순매수
		/// </summary>
		[JsonProperty("for_netprps")]
		public KiwoomDecimal? ForeignNetPurchase;
		/// <summary>
		/// 기관순매수
		/// </summary>
		[JsonProperty("orgn_netprps")]
		public KiwoomDecimal? InstitutionNetPurchase;
		/// <summary>
		/// 개인순매수
		/// </summary>
		[JsonProperty("ind_netprps")]
		public KiwoomDecimal? IndividualNetPurchase;
		/// <summary>
		/// 신용잔고율
		/// </summary>
		[JsonProperty("crd_remn_rt")]
		public decimal? CreditRemainingRate;
	}

	public record KiwoomMarketConditionGetAfterHoursSinglePriceOrderBook
	{
		/// <summary>
		/// 호가잔량기준시간
		/// </summary>
		[JsonProperty("bid_req_base_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? BidRequestBaseTime;
		/// <summary>
		/// 시간외단일가 매도호가직전대비5
		/// </summary>
		[JsonProperty("ovt_sigpric_sel_bid_jub_pre_5")]
		public decimal? AfterHoursSinglePriceSellPrevDiff5;
		/// <summary>
		/// 시간외단일가 매도호가직전대비4
		/// </summary>
		[JsonProperty("ovt_sigpric_sel_bid_jub_pre_4")]
		public decimal? AfterHoursSinglePriceSellPrevDiff4;
		/// <summary>
		/// 시간외단일가 매도호가직전대비3
		/// </summary>
		[JsonProperty("ovt_sigpric_sel_bid_jub_pre_3")]
		public decimal? AfterHoursSinglePriceSellPrevDiff3;
		/// <summary>
		/// 시간외단일가 매도호가직전대비2
		/// </summary>
		[JsonProperty("ovt_sigpric_sel_bid_jub_pre_2")]
		public decimal? AfterHoursSinglePriceSellPrevDiff2;
		/// <summary>
		/// 시간외단일가 매도호가직전대비1
		/// </summary>
		[JsonProperty("ovt_sigpric_sel_bid_jub_pre_1")]
		public decimal? AfterHoursSinglePriceSellPrevDiff1;
		/// <summary>
		/// 시간외단일가 매도호가수량5
		/// </summary>
		[JsonProperty("ovt_sigpric_sel_bid_qty_5")]
		public decimal? AfterHoursSinglePriceSellQuantity5;
		/// <summary>
		/// 시간외단일가 매도호가수량4
		/// </summary>
		[JsonProperty("ovt_sigpric_sel_bid_qty_4")]
		public decimal? AfterHoursSinglePriceSellQuantity4;
		/// <summary>
		/// 시간외단일가 매도호가수량3
		/// </summary>
		[JsonProperty("ovt_sigpric_sel_bid_qty_3")]
		public decimal? AfterHoursSinglePriceSellQuantity3;
		/// <summary>
		/// 시간외단일가 매도호가수량2
		/// </summary>
		[JsonProperty("ovt_sigpric_sel_bid_qty_2")]
		public decimal? AfterHoursSinglePriceSellQuantity2;
		/// <summary>
		/// 시간외단일가 매도호가수량1
		/// </summary>
		[JsonProperty("ovt_sigpric_sel_bid_qty_1")]
		public decimal? AfterHoursSinglePriceSellQuantity1;
		/// <summary>
		/// 시간외단일가 매도호가5
		/// </summary>
		[JsonProperty("ovt_sigpric_sel_bid_5")]
		public decimal? AfterHoursSinglePriceSellPrice5;
		/// <summary>
		/// 시간외단일가 매도호가4
		/// </summary>
		[JsonProperty("ovt_sigpric_sel_bid_4")]
		public decimal? AfterHoursSinglePriceSellPrice4;
		/// <summary>
		/// 시간외단일가 매도호가3
		/// </summary>
		[JsonProperty("ovt_sigpric_sel_bid_3")]
		public decimal? AfterHoursSinglePriceSellPrice3;
		/// <summary>
		/// 시간외단일가 매도호가2
		/// </summary>
		[JsonProperty("ovt_sigpric_sel_bid_2")]
		public decimal? AfterHoursSinglePriceSellPrice2;
		/// <summary>
		/// 시간외단일가 매도호가1
		/// </summary>
		[JsonProperty("ovt_sigpric_sel_bid_1")]
		public decimal? AfterHoursSinglePriceSellPrice1;
		/// <summary>
		/// 시간외단일가 매수호가1
		/// </summary>
		[JsonProperty("ovt_sigpric_buy_bid_1")]
		public decimal? AfterHoursSinglePriceBuyPrice1;
		/// <summary>
		/// 시간외단일가 매수호가2
		/// </summary>
		[JsonProperty("ovt_sigpric_buy_bid_2")]
		public decimal? AfterHoursSinglePriceBuyPrice2;
		/// <summary>
		/// 시간외단일가 매수호가3
		/// </summary>
		[JsonProperty("ovt_sigpric_buy_bid_3")]
		public decimal? AfterHoursSinglePriceBuyPrice3;
		/// <summary>
		/// 시간외단일가 매수호가4
		/// </summary>
		[JsonProperty("ovt_sigpric_buy_bid_4")]
		public decimal? AfterHoursSinglePriceBuyPrice4;
		/// <summary>
		/// 시간외단일가 매수호가5
		/// </summary>
		[JsonProperty("ovt_sigpric_buy_bid_5")]
		public decimal? AfterHoursSinglePriceBuyPrice5;
		/// <summary>
		/// 시간외단일가 매수호가수량1
		/// </summary>
		[JsonProperty("ovt_sigpric_buy_bid_qty_1")]
		public decimal? AfterHoursSinglePriceBuyQuantity1;
		/// <summary>
		/// 시간외단일가 매수호가수량2
		/// </summary>
		[JsonProperty("ovt_sigpric_buy_bid_qty_2")]
		public decimal? AfterHoursSinglePriceBuyQuantity2;
		/// <summary>
		/// 시간외단일가 매수호가수량3
		/// </summary>
		[JsonProperty("ovt_sigpric_buy_bid_qty_3")]
		public decimal? AfterHoursSinglePriceBuyQuantity3;
		/// <summary>
		/// 시간외단일가 매수호가수량4
		/// </summary>
		[JsonProperty("ovt_sigpric_buy_bid_qty_4")]
		public decimal? AfterHoursSinglePriceBuyQuantity4;
		/// <summary>
		/// 시간외단일가 매수호가수량5
		/// </summary>
		[JsonProperty("ovt_sigpric_buy_bid_qty_5")]
		public decimal? AfterHoursSinglePriceBuyQuantity5;
		/// <summary>
		/// 시간외단일가 매수호가직전대비1
		/// </summary>
		[JsonProperty("ovt_sigpric_buy_bid_jub_pre_1")]
		public decimal? AfterHoursSinglePriceBuyPrevDiff1;
		/// <summary>
		/// 시간외단일가 매수호가직전대비2
		/// </summary>
		[JsonProperty("ovt_sigpric_buy_bid_jub_pre_2")]
		public decimal? AfterHoursSinglePriceBuyPrevDiff2;
		/// <summary>
		/// 시간외단일가 매수호가직전대비3
		/// </summary>
		[JsonProperty("ovt_sigpric_buy_bid_jub_pre_3")]
		public decimal? AfterHoursSinglePriceBuyPrevDiff3;
		/// <summary>
		/// 시간외단일가 매수호가직전대비4
		/// </summary>
		[JsonProperty("ovt_sigpric_buy_bid_jub_pre_4")]
		public decimal? AfterHoursSinglePriceBuyPrevDiff4;
		/// <summary>
		/// 시간외단일가 매수호가직전대비5
		/// </summary>
		[JsonProperty("ovt_sigpric_buy_bid_jub_pre_5")]
		public decimal? AfterHoursSinglePriceBuyPrevDiff5;
		/// <summary>
		/// 시간외단일가 매도호가총잔량
		/// </summary>
		[JsonProperty("ovt_sigpric_sel_bid_tot_req")]
		public decimal? AfterHoursSinglePriceSellTotalQuantity;
		/// <summary>
		/// 시간외단일가 매수호가총잔량
		/// </summary>
		[JsonProperty("ovt_sigpric_buy_bid_tot_req")]
		public decimal? AfterHoursSinglePriceBuyTotalQuantity;
		/// <summary>
		/// 매도호가총잔량직전대비
		/// </summary>
		[JsonProperty("sel_bid_tot_req_jub_pre")]
		public decimal? SellTotalQuantityPrevDiff;
		/// <summary>
		/// 매도호가총잔량
		/// </summary>
		[JsonProperty("sel_bid_tot_req")]
		public decimal? SellTotalQuantity;
		/// <summary>
		/// 매수호가총잔량
		/// </summary>
		[JsonProperty("buy_bid_tot_req")]
		public decimal? BuyTotalQuantity;
		/// <summary>
		/// 매수호가총잔량직전대비
		/// </summary>
		[JsonProperty("buy_bid_tot_req_jub_pre")]
		public KiwoomDecimal? BuyTotalQuantityPrevDiff;
		/// <summary>
		/// 시간외매도호가총잔량직전대비
		/// </summary>
		[JsonProperty("ovt_sel_bid_tot_req_jub_pre")]
		public decimal? AfterHoursSellTotalQuantityPrevDiff;
		/// <summary>
		/// 시간외매도호가총잔량
		/// </summary>
		[JsonProperty("ovt_sel_bid_tot_req")]
		public decimal? AfterHoursSellTotalQuantity;
		/// <summary>
		/// 시간외매수호가총잔량
		/// </summary>
		[JsonProperty("ovt_buy_bid_tot_req")]
		public decimal? AfterHoursBuyTotalQuantity;
		/// <summary>
		/// 시간외매수호가총잔량직전대비
		/// </summary>
		[JsonProperty("ovt_buy_bid_tot_req_jub_pre")]
		public decimal? AfterHoursBuyTotalQuantityPrevDiff;
		/// <summary>
		/// 시간외단일가 현재가
		/// </summary>
		[JsonProperty("ovt_sigpric_cur_prc")]
		public decimal? AfterHoursSinglePriceCurrentPrice;
		/// <summary>
		/// 시간외단일가 전일대비기호
		/// </summary>
		[JsonProperty("ovt_sigpric_pred_pre_sig")]
		public string? AfterHoursSinglePricePrevDiffSign;
		/// <summary>
		/// 시간외단일가 전일대비
		/// </summary>
		[JsonProperty("ovt_sigpric_pred_pre")]
		public decimal? AfterHoursSinglePricePrevDiff;
		/// <summary>
		/// 시간외단일가 등락률
		/// </summary>
		[JsonProperty("ovt_sigpric_flu_rt")]
		public decimal? AfterHoursSinglePriceFluctuationRate;
		/// <summary>
		/// 시간외단일가 누적거래량
		/// </summary>
		[JsonProperty("ovt_sigpric_acc_trde_qty")]
		public decimal? AfterHoursSinglePriceAccumulatedTradeQuantity;
	}

	public record KiwoomMarketConditionGetAfterHoursSinglePriceOrderBookList
	{
		/// <summary>
		/// 호가잔량기준시간
		/// </summary>
		public TimeSpan? BidRequestBaseTime;
		/// <summary>
		/// 시간외단일가 매도호가직전대비
		/// </summary>
		public decimal?[] AfterHoursSinglePriceSellPrevDiffs;
		/// <summary>
		/// 시간외단일가 매도호가수량
		/// </summary>
		public decimal?[] AfterHoursSinglePriceSellQuantities;
		/// <summary>
		/// 시간외단일가 매도호가
		/// </summary>
		public decimal?[] AfterHoursSinglePriceSellPrices;
		/// <summary>
		/// 시간외단일가 매수호가
		/// </summary>
		public decimal?[] AfterHoursSinglePriceBuyPrices;
		/// <summary>
		/// 시간외단일가 매수호가수량
		/// </summary>
		public decimal?[] AfterHoursSinglePriceBuyQuantities;
		/// <summary>
		/// 시간외단일가 매수호가직전대비
		/// </summary>
		public decimal?[] AfterHoursSinglePriceBuyPrevDiffs;
		/// <summary>
		/// 시간외단일가 매도호가총잔량
		/// </summary>
		public decimal? AfterHoursSinglePriceSellTotalQuantity;
		/// <summary>
		/// 시간외단일가 매수호가총잔량
		/// </summary>
		public decimal? AfterHoursSinglePriceBuyTotalQuantity;
		/// <summary>
		/// 매도호가총잔량직전대비
		/// </summary>
		public decimal? SellTotalQuantityPrevDiff;
		/// <summary>
		/// 매도호가총잔량
		/// </summary>
		public decimal? SellTotalQuantity;
		/// <summary>
		/// 매수호가총잔량
		/// </summary>
		public decimal? BuyTotalQuantity;
		/// <summary>
		/// 매수호가총잔량직전대비
		/// </summary>
		public decimal? BuyTotalQuantityPrevDiff;
		/// <summary>
		/// 시간외매도호가총잔량직전대비
		/// </summary>
		public decimal? AfterHoursSellTotalQuantityPrevDiff;
		/// <summary>
		/// 시간외매도호가총잔량
		/// </summary>
		public decimal? AfterHoursSellTotalQuantity;
		/// <summary>
		/// 시간외매수호가총잔량
		/// </summary>
		public decimal? AfterHoursBuyTotalQuantity;
		/// <summary>
		/// 시간외매수호가총잔량직전대비
		/// </summary>
		public decimal? AfterHoursBuyTotalQuantityPrevDiff;
		/// <summary>
		/// 시간외단일가 현재가
		/// </summary>
		public decimal? AfterHoursSinglePriceCurrentPrice;
		/// <summary>
		/// 시간외단일가 전일대비기호
		/// </summary>
		public string? AfterHoursSinglePricePrevDiffSign;
		/// <summary>
		/// 시간외단일가 전일대비
		/// </summary>
		public decimal? AfterHoursSinglePricePrevDiff;
		/// <summary>
		/// 시간외단일가 등락률
		/// </summary>
		public decimal? AfterHoursSinglePriceFluctuationRate;
		/// <summary>
		/// 시간외단일가 누적거래량
		/// </summary>
		public decimal? AfterHoursSinglePriceAccumulatedTradeQuantity;

		public KiwoomMarketConditionGetAfterHoursSinglePriceOrderBookList(KiwoomMarketConditionGetAfterHoursSinglePriceOrderBook raw)
		{
			BidRequestBaseTime = raw.BidRequestBaseTime;
			AfterHoursSinglePriceSellPrevDiffs =
			[
				raw.AfterHoursSinglePriceSellPrevDiff5, raw.AfterHoursSinglePriceSellPrevDiff4,
				raw.AfterHoursSinglePriceSellPrevDiff3, raw.AfterHoursSinglePriceSellPrevDiff2,
				raw.AfterHoursSinglePriceSellPrevDiff1
			];
			AfterHoursSinglePriceSellQuantities =
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
		/// <summary>
		/// 프로그램매매추이
		/// </summary>
		[JsonProperty("prm_trde_trnsn")]
		public IEnumerable<KiwoomMarketConditionGetHourlyProgramTradeTrendItem>? Items;
	}
	public record KiwoomMarketConditionGetHourlyProgramTradeTrendItem
	{
		/// <summary>
		/// 체결시간
		/// </summary>
		[JsonProperty("cntr_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? ContractTime;
		/// <summary>
		/// 차익거래매도
		/// </summary>
		[JsonProperty("dfrt_trde_sel")]
		public decimal? ArbitrageTradeSell;
		/// <summary>
		/// 차익거래매수
		/// </summary>
		[JsonProperty("dfrt_trde_buy")]
		public decimal? ArbitrageTradeBuy;
		/// <summary>
		/// 차익거래순매수
		/// </summary>
		[JsonProperty("dfrt_trde_netprps")]
		public KiwoomDecimal? ArbitrageTradeNetPurchase;
		/// <summary>
		/// 비차익거래매도
		/// </summary>
		[JsonProperty("ndiffpro_trde_sel")]
		public decimal? NonArbitrageTradeSell;
		/// <summary>
		/// 비차익거래매수
		/// </summary>
		[JsonProperty("ndiffpro_trde_buy")]
		public decimal? NonArbitrageTradeBuy;
		/// <summary>
		/// 비차익거래순매수
		/// </summary>
		[JsonProperty("ndiffpro_trde_netprps")]
		public KiwoomDecimal? NonArbitrageTradeNetPurchase;
		/// <summary>
		/// 차익거래매도수량
		/// </summary>
		[JsonProperty("dfrt_trde_sell_qty")]
		public decimal? ArbitrageTradeSellQuantity;
		/// <summary>
		/// 차익거래매수수량
		/// </summary>
		[JsonProperty("dfrt_trde_buy_qty")]
		public decimal? ArbitrageTradeBuyQuantity;
		/// <summary>
		/// 차익거래순매수수량
		/// </summary>
		[JsonProperty("dfrt_trde_netprps_qty")]
		public KiwoomDecimal? ArbitrageTradeNetPurchaseQuantity;
		/// <summary>
		/// 비차익거래매도수량
		/// </summary>
		[JsonProperty("ndiffpro_trde_sell_qty")]
		public decimal? NonArbitrageTradeSellQuantity;
		/// <summary>
		/// 비차익거래매수수량
		/// </summary>
		[JsonProperty("ndiffpro_trde_buy_qty")]
		public decimal? NonArbitrageTradeBuyQuantity;
		/// <summary>
		/// 비차익거래순매수수량
		/// </summary>
		[JsonProperty("ndiffpro_trde_netprps_qty")]
		public KiwoomDecimal? NonArbitrageTradeNetPurchaseQuantity;
		/// <summary>
		/// 전체매도
		/// </summary>
		[JsonProperty("all_sel")]
		public decimal? TotalSell;
		/// <summary>
		/// 전체매수
		/// </summary>
		[JsonProperty("all_buy")]
		public decimal? TotalBuy;
		/// <summary>
		/// 전체순매수
		/// </summary>
		[JsonProperty("all_netprps")]
		public KiwoomDecimal? TotalNetPurchase;
		/// <summary>
		/// KOSPI200
		/// </summary>
		[JsonProperty("kospi200")]
		public decimal? Kospi200;
		/// <summary>
		/// BASIS
		/// </summary>
		[JsonProperty("basis")]
		public decimal? Basis;
	}

	public record KiwoomMarketConditionGetProgramArbitrageBalanceTrends
	{
		/// <summary>
		/// 프로그램매매차익잔고추이
		/// </summary>
		[JsonProperty("prm_trde_dfrt_remn_trnsn")]
		public IEnumerable<KiwoomMarketConditionGetProgramArbitrageBalanceTrendItem>? Items;
	}
	public record KiwoomMarketConditionGetProgramArbitrageBalanceTrendItem
	{
		/// <summary>
		/// 일자
		/// </summary>
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		/// <summary>
		/// 매수차익거래수량
		/// </summary>
		[JsonProperty("buy_dfrt_trde_qty")]
		public decimal? BuyArbitrageTradeQuantity;
		/// <summary>
		/// 매수차익거래금액
		/// </summary>
		[JsonProperty("buy_dfrt_trde_amt")]
		public decimal? BuyArbitrageTradeAmount;
		/// <summary>
		/// 매수차익거래증감액
		/// </summary>
		[JsonProperty("buy_dfrt_trde_irds_amt")]
		public decimal? BuyArbitrageTradeIncreaseDecreaseAmount;
		/// <summary>
		/// 매도차익거래수량
		/// </summary>
		[JsonProperty("sel_dfrt_trde_qty")]
		public decimal? SellArbitrageTradeQuantity;
		/// <summary>
		/// 매도차익거래금액
		/// </summary>
		[JsonProperty("sel_dfrt_trde_amt")]
		public decimal? SellArbitrageTradeAmount;
		/// <summary>
		/// 매도차익거래증감액
		/// </summary>
		[JsonProperty("sel_dfrt_trde_irds_amt")]
		public decimal? SellArbitrageTradeIncreaseDecreaseAmount;
	}

	public record KiwoomMarketConditionGetProgramTradeAccumulatedTrends
	{
		/// <summary>
		/// 프로그램매매누적추이
		/// </summary>
		[JsonProperty("prm_trde_acc_trnsn")]
		public IEnumerable<KiwoomMarketConditionGetProgramTradeAccumulatedTrendItem>? Items;
	}
	public record KiwoomMarketConditionGetProgramTradeAccumulatedTrendItem
	{
		/// <summary>
		/// 일자
		/// </summary>
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		/// <summary>
		/// KOSPI200
		/// </summary>
		[JsonProperty("kospi200")]
		public decimal? Kospi200;
		/// <summary>
		/// BASIS
		/// </summary>
		[JsonProperty("basis")]
		public decimal? Basis;
		/// <summary>
		/// 차익거래당일
		/// </summary>
		[JsonProperty("dfrt_trde_tdy")]
		public KiwoomDecimal? ArbitrageTradeToday;
		/// <summary>
		/// 차익거래누적
		/// </summary>
		[JsonProperty("dfrt_trde_acc")]
		public KiwoomDecimal? ArbitrageTradeAccumulated;
		/// <summary>
		/// 비차익거래당일
		/// </summary>
		[JsonProperty("ndiffpro_trde_tdy")]
		public KiwoomDecimal? NonArbitrageTradeToday;
		/// <summary>
		/// 비차익거래누적
		/// </summary>
		[JsonProperty("ndiffpro_trde_acc")]
		public KiwoomDecimal? NonArbitrageTradeAccumulated;
		/// <summary>
		/// 전체당일
		/// </summary>
		[JsonProperty("all_tdy")]
		public KiwoomDecimal? TotalToday;
		/// <summary>
		/// 전체누적
		/// </summary>
		[JsonProperty("all_acc")]
		public KiwoomDecimal? TotalAccumulated;
	}

	public record KiwoomMarketConditionGetStockTimeProgramTradeTrends
	{
		/// <summary>
		/// 종목시간별프로그램매매추이
		/// </summary>
		[JsonProperty("stk_tm_prm_trde_trnsn")]
		public IEnumerable<KiwoomMarketConditionGetStockTimeProgramTradeTrendItem>? Items;
	}
	public record KiwoomMarketConditionGetStockTimeProgramTradeTrendItem
	{
		/// <summary>
		/// 시간
		/// </summary>
		[JsonProperty("tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? Time;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		/// <summary>
		/// 대비기호
		/// </summary>
		[JsonProperty("pre_sig")]
		public string? PrevDiffSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PrevDiff;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? TradeQuantity;
		/// <summary>
		/// 프로그램매도금액
		/// </summary>
		[JsonProperty("prm_sell_amt")]
		public decimal? ProgramSellAmount;
		/// <summary>
		/// 프로그램매수금액
		/// </summary>
		[JsonProperty("prm_buy_amt")]
		public decimal? ProgramBuyAmount;
		/// <summary>
		/// 프로그램순매수금액
		/// </summary>
		[JsonProperty("prm_netprps_amt")]
		public KiwoomDecimal? ProgramNetPurchaseAmount;
		/// <summary>
		/// 프로그램순매수금액증감
		/// </summary>
		[JsonProperty("prm_netprps_amt_irds")]
		public KiwoomDecimal? ProgramNetPurchaseAmountChange;
		/// <summary>
		/// 프로그램매도수량
		/// </summary>
		[JsonProperty("prm_sell_qty")]
		public decimal? ProgramSellQuantity;
		/// <summary>
		/// 프로그램매수수량
		/// </summary>
		[JsonProperty("prm_buy_qty")]
		public decimal? ProgramBuyQuantity;
		/// <summary>
		/// 프로그램순매수수량
		/// </summary>
		[JsonProperty("prm_netprps_qty")]
		public KiwoomDecimal? ProgramNetPurchaseQuantity;
		/// <summary>
		/// 프로그램순매수수량증감
		/// </summary>
		[JsonProperty("prm_netprps_qty_irds")]
		public KiwoomDecimal? ProgramNetPurchaseQuantityChange;
		/// <summary>
		/// 기준가시간
		/// </summary>
		[JsonProperty("base_pric_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? BasePriceTime;
		/// <summary>
		/// 대차거래상환주수합
		/// </summary>
		[JsonProperty("dbrt_trde_rpy_sum")]
		public decimal? StockLoanRepaymentSum;
		/// <summary>
		/// 잔고수주합
		/// </summary>
		[JsonProperty("remn_rcvord_sum")]
		public decimal? RemainingOrderSum;
		/// <summary>
		/// 거래소구분 - KRX, NXT, 통합
		/// </summary>
		[JsonProperty("stex_tp")]
		public string? ExchangeType;
	}

	public record KiwoomMarketConditionGetDailyProgramTradeTrends
	{
		/// <summary>
		/// 프로그램매매추이
		/// </summary>
		[JsonProperty("prm_trde_trnsn")]
		public IEnumerable<KiwoomMarketConditionGetDailyProgramTradeTrendItem>? Items;
	}
	public record KiwoomMarketConditionGetDailyProgramTradeTrendItem
	{
		/// <summary>
		/// 체결시간
		/// </summary>
		[JsonProperty("cntr_tm")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? ContractTime;
		/// <summary>
		/// 차익거래매도
		/// </summary>
		[JsonProperty("dfrt_trde_sel")]
		public decimal? ArbitrageTradeSell;
		/// <summary>
		/// 차익거래매수
		/// </summary>
		[JsonProperty("dfrt_trde_buy")]
		public decimal? ArbitrageTradeBuy;
		/// <summary>
		/// 차익거래순매수
		/// </summary>
		[JsonProperty("dfrt_trde_netprps")]
		public decimal? ArbitrageTradeNetPurchase;
		/// <summary>
		/// 비차익거래매도
		/// </summary>
		[JsonProperty("ndiffpro_trde_sel")]
		public decimal? NonArbitrageTradeSell;
		/// <summary>
		/// 비차익거래매수
		/// </summary>
		[JsonProperty("ndiffpro_trde_buy")]
		public decimal? NonArbitrageTradeBuy;
		/// <summary>
		/// 비차익거래순매수
		/// </summary>
		[JsonProperty("ndiffpro_trde_netprps")]
		public decimal? NonArbitrageTradeNetPurchase;
		/// <summary>
		/// 차익거래매도수량
		/// </summary>
		[JsonProperty("dfrt_trde_sell_qty")]
		public decimal? ArbitrageTradeSellQuantity;
		/// <summary>
		/// 차익거래매수수량
		/// </summary>
		[JsonProperty("dfrt_trde_buy_qty")]
		public decimal? ArbitrageTradeBuyQuantity;
		/// <summary>
		/// 차익거래순매수수량
		/// </summary>
		[JsonProperty("dfrt_trde_netprps_qty")]
		public decimal? ArbitrageTradeNetPurchaseQuantity;
		/// <summary>
		/// 비차익거래매도수량
		/// </summary>
		[JsonProperty("ndiffpro_trde_sell_qty")]
		public decimal? NonArbitrageTradeSellQuantity;
		/// <summary>
		/// 비차익거래매수수량
		/// </summary>
		[JsonProperty("ndiffpro_trde_buy_qty")]
		public decimal? NonArbitrageTradeBuyQuantity;
		/// <summary>
		/// 비차익거래순매수수량
		/// </summary>
		[JsonProperty("ndiffpro_trde_netprps_qty")]
		public decimal? NonArbitrageTradeNetPurchaseQuantity;
		/// <summary>
		/// 전체매도
		/// </summary>
		[JsonProperty("all_sel")]
		public decimal? TotalSell;
		/// <summary>
		/// 전체매수
		/// </summary>
		[JsonProperty("all_buy")]
		public decimal? TotalBuy;
		/// <summary>
		/// 전체순매수
		/// </summary>
		[JsonProperty("all_netprps")]
		public decimal? TotalNetPurchase;
		/// <summary>
		/// KOSPI200
		/// </summary>
		[JsonProperty("kospi200")]
		public decimal? Kospi200;
		/// <summary>
		/// BASIS
		/// </summary>
		[JsonProperty("basis")]
		public decimal? Basis;
	}

	public record KiwoomMarketConditionGetStockDailyProgramTradeTrends
	{
		/// <summary>
		/// 종목일별프로그램매매추이
		/// </summary>
		[JsonProperty("stk_daly_prm_trde_trnsn")]
		public IEnumerable<KiwoomMarketConditionGetStockDailyProgramTradeTrendItem>? Items;
	}
	public record KiwoomMarketConditionGetStockDailyProgramTradeTrendItem
	{
		/// <summary>
		/// 일자
		/// </summary>
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		/// <summary>
		/// 대비기호
		/// </summary>
		[JsonProperty("pre_sig")]
		public string? PrevDiffSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PrevDiff;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? TradeQuantity;
		/// <summary>
		/// 프로그램매도금액
		/// </summary>
		[JsonProperty("prm_sell_amt")]
		public decimal? ProgramSellAmount;
		/// <summary>
		/// 프로그램매수금액
		/// </summary>
		[JsonProperty("prm_buy_amt")]
		public decimal? ProgramBuyAmount;
		/// <summary>
		/// 프로그램순매수금액
		/// </summary>
		[JsonProperty("prm_netprps_amt")]
		public KiwoomDecimal? ProgramNetPurchaseAmount;
		/// <summary>
		/// 프로그램순매수금액증감
		/// </summary>
		[JsonProperty("prm_netprps_amt_irds")]
		public KiwoomDecimal? ProgramNetPurchaseAmountChange;
		/// <summary>
		/// 프로그램매도수량
		/// </summary>
		[JsonProperty("prm_sell_qty")]
		public decimal? ProgramSellQuantity;
		/// <summary>
		/// 프로그램매수수량
		/// </summary>
		[JsonProperty("prm_buy_qty")]
		public decimal? ProgramBuyQuantity;
		/// <summary>
		/// 프로그램순매수수량
		/// </summary>
		[JsonProperty("prm_netprps_qty")]
		public KiwoomDecimal? ProgramNetPurchaseQuantity;
		/// <summary>
		/// 프로그램순매수수량증감
		/// </summary>
		[JsonProperty("prm_netprps_qty_irds")]
		public KiwoomDecimal? ProgramNetPurchaseQuantityChange;
		/// <summary>
		/// 기준가시간
		/// </summary>
		[JsonProperty("base_pric_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? BasePriceTime;
		/// <summary>
		/// 대차거래상환주수합
		/// </summary>
		[JsonProperty("dbrt_trde_rpy_sum")]
		public decimal? StockLoanRepaymentSum;
		/// <summary>
		/// 잔고수주합
		/// </summary>
		[JsonProperty("remn_rcvord_sum")]
		public decimal? RemainingOrderSum;
		/// <summary>
		/// 거래소구분 - KRX, NXT, 통합
		/// </summary>
		[JsonProperty("stex_tp")]
		public string? ExchangeType;
	}
}
