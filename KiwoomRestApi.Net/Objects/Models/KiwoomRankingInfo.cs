using KiwoomRestApi.Net.Converters;
using KiwoomRestApi.Net.Objects.Commons;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models
{
	public record KiwoomRankingInfoGetBidRequestUppers
	{
		/// <summary>
		/// 매수대금 상위 목록
		/// </summary>
		[JsonProperty("bid_req_upper")]
		public IEnumerable<KiwoomRankingInfoGetBidRequestUpperItem>? Items;
	}
	public record KiwoomRankingInfoGetBidRequestUpperItem
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
		public decimal? PreviousDayChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDayChange;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? TradeQuantity;
		/// <summary>
		/// 총매도잔량
		/// </summary>
		[JsonProperty("tot_sel_req")]
		public decimal? TotalSellRequest;
		/// <summary>
		/// 총매수잔량
		/// </summary>
		[JsonProperty("tot_buy_req")]
		public decimal? TotalBuyRequest;
		/// <summary>
		/// 순매수잔량
		/// </summary>
		[JsonProperty("netprps_req")]
		public decimal? NetPurchaseRequest;
		/// <summary>
		/// 매수비율
		/// </summary>
		[JsonProperty("buy_rt")]
		public decimal? BuyRate;
	}

	public record KiwoomRankingInfoGetBidRequestSuddenIncreases
	{
		/// <summary>
		/// 매수대금 급증 목록
		/// </summary>
		[JsonProperty("bid_req_sdnin")]
		public IEnumerable<KiwoomRankingInfoGetBidRequestSuddenIncreaseItem>? Items;
	}
	public record KiwoomRankingInfoGetBidRequestSuddenIncreaseItem
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
		public string? PreviousDayChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDayChange;
		/// <summary>
		/// 기준비율
		/// </summary>
		[JsonProperty("int")]
		public decimal? StandardRate;
		/// <summary>
		/// 현재값
		/// </summary>
		[JsonProperty("now")]
		public decimal? CurrentValue;
		/// <summary>
		/// 급증량
		/// </summary>
		[JsonProperty("sdnin_qty")]
		public decimal? SuddenIncreaseQuantity;
		/// <summary>
		/// 급증비율
		/// </summary>
		[JsonProperty("sdnin_rt")]
		public decimal? SuddenIncreaseRate;
		/// <summary>
		/// 총매수량
		/// </summary>
		[JsonProperty("tot_buy_qty")]
		public decimal? TotalBuyQuantity;
	}

	public record KiwoomRankingInfoGetRequestRateSuddenIncreases
	{
		/// <summary>
		/// 매수비율 급증 목록
		/// </summary>
		[JsonProperty("req_rt_sdnin")]
		public IEnumerable<KiwoomRankingInfoGetRequestRateSuddenIncreaseItem>? Items;
	}
	public record KiwoomRankingInfoGetRequestRateSuddenIncreaseItem
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
		public string? PreviousDayChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDayChange;
		/// <summary>
		/// 기준비율
		/// </summary>
		[JsonProperty("int")]
		public decimal? StandardRate;
		/// <summary>
		/// 현재비율
		/// </summary>
		[JsonProperty("now_rt")]
		public decimal? CurrentRatio;
		/// <summary>
		/// 급증비율
		/// </summary>
		[JsonProperty("sdnin_rt")]
		public decimal? SuddenIncreaseRate;
		/// <summary>
		/// 총매도잔량
		/// </summary>
		[JsonProperty("tot_sel_req")]
		public decimal? TotalSellRequest;
		/// <summary>
		/// 총매수잔량
		/// </summary>
		[JsonProperty("tot_buy_req")]
		public decimal? TotalBuyRequest;
	}

	public record KiwoomRankingInfoGetTradedQuantitySuddenIncreases
	{
		/// <summary>
		/// 거래량 급증 목록
		/// </summary>
		[JsonProperty("trde_qty_sdnin")]
		public IEnumerable<KiwoomRankingInfoGetTradedQuantitySuddenIncreaseItem>? Items;
	}
	public record KiwoomRankingInfoGetTradedQuantitySuddenIncreaseItem
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
		public string? PreviousDayChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDayChange;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		/// <summary>
		/// 전일거래량
		/// </summary>
		[JsonProperty("prev_trde_qty")]
		public decimal? PreviousTradeQuantity;
		/// <summary>
		/// 현재거래량
		/// </summary>
		[JsonProperty("now_trde_qty")]
		public decimal? CurrentTradeQuantity;
		/// <summary>
		/// 급증량
		/// </summary>
		[JsonProperty("sdnin_qty")]
		public decimal? SuddenIncreaseQuantity;
		/// <summary>
		/// 급증비율
		/// </summary>
		[JsonProperty("sdnin_rt")]
		public decimal? SuddenIncreaseRate;
	}

	public record KiwoomRankingInfoGetPreviousDayFluctuationRateUppers
	{
		/// <summary>
		/// 전일대비 등락율 상위 목록
		/// </summary>
		[JsonProperty("pred_pre_flu_rt_upper")]
		public IEnumerable<KiwoomRankingInfoGetPreviousDayFluctuationRateUpperItem>? Items;
	}

	public record KiwoomRankingInfoGetPreviousDayFluctuationRateUpperItem
	{
		/// <summary>
		/// 종목분류
		/// </summary>
		[JsonProperty("stk_cls")]
		public string? StockClass;
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
		public string? PreviousDayChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDayChange;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		/// <summary>
		/// 매도잔량
		/// </summary>
		[JsonProperty("sel_req")]
		public decimal? SellRequest;
		/// <summary>
		/// 매수잔량
		/// </summary>
		[JsonProperty("buy_req")]
		public decimal? BuyRequest;
		/// <summary>
		/// 현재거래량
		/// </summary>
		[JsonProperty("now_trde_qty")]
		public decimal? CurrentTradeQuantity;
		/// <summary>
		/// 체결강도
		/// </summary>
		[JsonProperty("cntr_str")]
		public decimal? ContractStrength;
		/// <summary>
		/// 건수
		/// </summary>
		[JsonProperty("cnt")]
		public decimal? Count;
	}

	public record KiwoomRankingInfoGetExpectedContractFluctuationRateUppers
	{
		/// <summary>
		/// 예상체결 등락율 상위 목록
		/// </summary>
		[JsonProperty("exp_cntr_flu_rt_upper")]
		public IEnumerable<KiwoomRankingInfoGetExpectedContractFluctuationRateUpperItem>? Items;
	}
	public record KiwoomRankingInfoGetExpectedContractFluctuationRateUpperItem
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
		/// 예상체결가
		/// </summary>
		[JsonProperty("exp_cntr_pric")]
		public decimal? ExpectedContractPrice;
		/// <summary>
		/// 기준가
		/// </summary>
		[JsonProperty("base_pric")]
		public decimal? BasePrice;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? PreviousDayChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDayChange;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		/// <summary>
		/// 예상체결량
		/// </summary>
		[JsonProperty("exp_cntr_qty")]
		public decimal? ExpectedContractQuantity;
		/// <summary>
		/// 매도잔량
		/// </summary>
		[JsonProperty("sel_req")]
		public decimal? SellRequest;
		/// <summary>
		/// 매도호가
		/// </summary>
		[JsonProperty("sel_bid")]
		public decimal? SellBid;
		/// <summary>
		/// 매수호가
		/// </summary>
		[JsonProperty("buy_bid")]
		public decimal? BuyBid;
		/// <summary>
		/// 매수잔량
		/// </summary>
		[JsonProperty("buy_req")]
		public decimal? BuyRequest;
	}


	public record KiwoomRankingInfoGetTodayTradeQuantityUppers
	{
		/// <summary>
		/// 당일거래량상위
		/// </summary>
		[JsonProperty("tdy_trde_qty_upper")]
		public IEnumerable<KiwoomRankingInfoGetTodayTradeQuantityUpperItem>? Items;
	}
	public record KiwoomRankingInfoGetTodayTradeQuantityUpperItem
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
		public string? PreviousDayChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDayChange;
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
		/// 전일비
		/// </summary>
		[JsonProperty("pred_rt")]
		public decimal? PreviousDayRatio;
		/// <summary>
		/// 거래회전율
		/// </summary>
		[JsonProperty("trde_tern_rt")]
		public decimal? TradeTurnoverRate;
		/// <summary>
		/// 거래금액
		/// </summary>
		[JsonProperty("trde_amt")]
		public decimal? TradeAmount;
		/// <summary>
		/// 장중거래량
		/// </summary>
		[JsonProperty("opmr_trde_qty")]
		public decimal? IntradayTradeQuantity;
		/// <summary>
		/// 장중전일비
		/// </summary>
		[JsonProperty("opmr_pred_rt")]
		public decimal? IntradayPreviousDayRatio;
		/// <summary>
		/// 장중거래회전율
		/// </summary>
		[JsonProperty("opmr_trde_rt")]
		public decimal? IntradayTradeTurnoverRate;
		/// <summary>
		/// 장중거래금액
		/// </summary>
		[JsonProperty("opmr_trde_amt")]
		public decimal? IntradayTradeAmount;
		/// <summary>
		/// 장후거래량
		/// </summary>
		[JsonProperty("af_mkrt_trde_qty")]
		public decimal? AfterMarketTradeQuantity;
		/// <summary>
		/// 장후전일비
		/// </summary>
		[JsonProperty("af_mkrt_pred_rt")]
		public decimal? AfterMarketPreviousDayRatio;
		/// <summary>
		/// 장후거래회전율
		/// </summary>
		[JsonProperty("af_mkrt_trde_rt")]
		public decimal? AfterMarketTradeTurnoverRate;
		/// <summary>
		/// 장후거래금액
		/// </summary>
		[JsonProperty("af_mkrt_trde_amt")]
		public decimal? AfterMarketTradeAmount;
		/// <summary>
		/// 장전거래량
		/// </summary>
		[JsonProperty("bf_mkrt_trde_qty")]
		public decimal? BeforeMarketTradeQuantity;
		/// <summary>
		/// 장전전일비
		/// </summary>
		[JsonProperty("bf_mkrt_pred_rt")]
		public decimal? BeforeMarketPreviousDayRatio;
		/// <summary>
		/// 장전거래회전율
		/// </summary>
		[JsonProperty("bf_mkrt_trde_rt")]
		public decimal? BeforeMarketTradeTurnoverRate;
		/// <summary>
		/// 장전거래금액
		/// </summary>
		[JsonProperty("bf_mkrt_trde_amt")]
		public decimal? BeforeMarketTradeAmount;
	}

	public record KiwoomRankingInfoGetPreviousTradeQuantityUppers
	{
		/// <summary>
		/// 전일거래량상위
		/// </summary>
		[JsonProperty("pred_trde_qty_upper")]
		public IEnumerable<KiwoomRankingInfoGetPreviousTradeQuantityUpperItem>? Items;
	}
	public record KiwoomRankingInfoGetPreviousTradeQuantityUpperItem
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
		public string? PreviousDayChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDayChange;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? TradeQuantity;
	}

	public record KiwoomRankingInfoGetTradePriceUppers
	{
		/// <summary>
		/// 거래대금상위
		/// </summary>
		[JsonProperty("trde_prica_upper")]
		public IEnumerable<KiwoomRankingInfoGetTradePriceUpperItem>? Items;
	}
	public record KiwoomRankingInfoGetTradePriceUpperItem
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 현재순위
		/// </summary>
		[JsonProperty("now_rank")]
		public string? CurrentRank;
		/// <summary>
		/// 전일순위
		/// </summary>
		[JsonProperty("pred_rank")]
		public string? PreviousRank;
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
		public string? PreviousDayChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDayChange;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		/// <summary>
		/// 매도호가
		/// </summary>
		[JsonProperty("sel_bid")]
		public decimal? SellBid;
		/// <summary>
		/// 매수호가
		/// </summary>
		[JsonProperty("buy_bid")]
		public decimal? BuyBid;
		/// <summary>
		/// 현재거래량
		/// </summary>
		[JsonProperty("now_trde_qty")]
		public decimal? CurrentTradeQuantity;
		/// <summary>
		/// 전일거래량
		/// </summary>
		[JsonProperty("pred_trde_qty")]
		public decimal? PreviousTradeQuantity;
		/// <summary>
		/// 거래대금
		/// </summary>
		[JsonProperty("trde_prica")]
		public decimal? TradePriceAmount;
	}

	public record KiwoomRankingInfoGetCreditRateUppers
	{
		/// <summary>
		/// 신용비율상위
		/// </summary>
		[JsonProperty("crd_rt_upper")]
		public IEnumerable<KiwoomRankingInfoGetCreditRateUpperItem>? Items;
	}
	public record KiwoomRankingInfoGetCreditRateUpperItem
	{
		/// <summary>
		/// 종목정보
		/// </summary>
		[JsonProperty("stk_infr")]
		public string? StockInfo;
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
		public string? PreviousDayChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDayChange;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		/// <summary>
		/// 신용비율
		/// </summary>
		[JsonProperty("crd_rt")]
		public decimal? CreditRate;
		/// <summary>
		/// 매도잔량
		/// </summary>
		[JsonProperty("sel_req")]
		public decimal? SellRequest;
		/// <summary>
		/// 매수잔량
		/// </summary>
		[JsonProperty("buy_req")]
		public decimal? BuyRequest;
		/// <summary>
		/// 현재거래량
		/// </summary>
		[JsonProperty("now_trde_qty")]
		public decimal? CurrentTradeQuantity;
	}

	public record KiwoomRankingInfoGetForeignTradePerPeriodUppers
	{
		/// <summary>
		/// 외인기간별매매상위
		/// </summary>
		[JsonProperty("for_dt_trde_upper")]
		public IEnumerable<KiwoomRankingInfoGetForeignTradePerPeriodUpperItem>? Items;
	}
	public record KiwoomRankingInfoGetForeignTradePerPeriodUpperItem
	{
		/// <summary>
		/// 순위
		/// </summary>
		[JsonProperty("rank")]
		public decimal? Rank;
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
		public string? PreviousDayChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDayChange;
		/// <summary>
		/// 매도호가
		/// </summary>
		[JsonProperty("sel_bid")]
		public decimal? SellBid;
		/// <summary>
		/// 매수호가
		/// </summary>
		[JsonProperty("buy_bid")]
		public decimal? BuyBid;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? TradeQuantity;
		/// <summary>
		/// 순매수량
		/// </summary>
		[JsonProperty("netprps_qty")]
		public KiwoomDecimal? NetPurchaseQuantity;
		/// <summary>
		/// 취득가능주식수
		/// </summary>
		[JsonProperty("gain_pos_stkcnt")]
		public decimal? GainableStockCount;
	}

	public record KiwoomRankingInfoGetForeignContinuousNetTradeUppers
	{
		/// <summary>
		/// 외인연속순매매상위
		/// </summary>
		[JsonProperty("for_cont_nettrde_upper")]
		public IEnumerable<KiwoomRankingInfoGetForeignContinuousNetTradeUpperItem>? Items;
	}
	public record KiwoomRankingInfoGetForeignContinuousNetTradeUpperItem
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
		public string? PreviousDayChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDayChange;
		/// <summary>
		/// D-1
		/// </summary>
		[JsonProperty("dm1")]
		public decimal? DMinus1;
		/// <summary>
		/// D-2
		/// </summary>
		[JsonProperty("dm2")]
		public decimal? DMinus2;
		/// <summary>
		/// D-3
		/// </summary>
		[JsonProperty("dm3")]
		public decimal? DMinus3;
		/// <summary>
		/// 합계
		/// </summary>
		[JsonProperty("tot")]
		public decimal? Total;
		/// <summary>
		/// 한도소진율
		/// </summary>
		[JsonProperty("limit_exh_rt")]
		public decimal? LimitExhaustionRate;
		/// <summary>
		/// 전일대비1
		/// </summary>
		[JsonProperty("pred_pre_1")]
		public decimal? PreviousDayChange1;
		/// <summary>
		/// 전일대비2
		/// </summary>
		[JsonProperty("pred_pre_2")]
		public decimal? PreviousDayChange2;
		/// <summary>
		/// 전일대비3
		/// </summary>
		[JsonProperty("pred_pre_3")]
		public decimal? PreviousDayChange3;
	}

	public record KiwoomRankingInfoGetForeignLimitExhaustionRateIncreases
	{
		/// <summary>
		/// 외인한도소진율증가상위
		/// </summary>
		[JsonProperty("for_limit_exh_rt_incrs_upper")]
		public IEnumerable<KiwoomRankingInfoGetForeignLimitExhaustionRateIncreaseItem>? Items;
	}

	public record KiwoomRankingInfoGetForeignLimitExhaustionRateIncreaseItem
	{
		/// <summary>
		/// 순위
		/// </summary>
		[JsonProperty("rank")]
		public string? Rank;
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
		public string? PreviousDayChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDayChange;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? TradeQuantity;
		/// <summary>
		/// 보유주식수
		/// </summary>
		[JsonProperty("poss_stkcnt")]
		public decimal? PossessedStockCount;
		/// <summary>
		/// 취득가능주식수
		/// </summary>
		[JsonProperty("gain_pos_stkcnt")]
		public decimal? GainableStockCount;
		/// <summary>
		/// 기준한도소진율
		/// </summary>
		[JsonProperty("base_limit_exh_rt")]
		public decimal? BaseLimitExhaustionRate;
		/// <summary>
		/// 한도소진율
		/// </summary>
		[JsonProperty("limit_exh_rt")]
		public decimal? LimitExhaustionRate;
		/// <summary>
		/// 소진율증가
		/// </summary>
		[JsonProperty("exh_rt_incrs")]
		public decimal? ExhaustionRateIncrease;
	}

	public record KiwoomRankingInfoGetForeignWicketTradeUppers
	{
		/// <summary>
		/// 외국계창구매매상위
		/// </summary>
		[JsonProperty("frgn_wicket_trde_upper")]
		public IEnumerable<KiwoomRankingInfoGetForeignWicketTradeUpperItem>? Items;
	}

	public record KiwoomRankingInfoGetForeignWicketTradeUpperItem
	{
		/// <summary>
		/// 순위
		/// </summary>
		[JsonProperty("rank")]
		public string? Rank;
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
		public string? PreviousDayChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDayChange;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		/// <summary>
		/// 매도거래량
		/// </summary>
		[JsonProperty("sel_trde_qty")]
		public decimal? SellTradeQuantity;
		/// <summary>
		/// 매수거래량
		/// </summary>
		[JsonProperty("buy_trde_qty")]
		public decimal? BuyTradeQuantity;
		/// <summary>
		/// 순매수거래량
		/// </summary>
		[JsonProperty("netprps_trde_qty")]
		public decimal? NetPurchaseTradeQuantity;
		/// <summary>
		/// 순매수대금
		/// </summary>
		[JsonProperty("netprps_prica")]
		public decimal? NetPurchasePriceAmount;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? TradeQuantity;
		/// <summary>
		/// 거래대금
		/// </summary>
		[JsonProperty("trde_prica")]
		public decimal? TradePriceAmount;
	}

	public record KiwoomRankingInfoGetStockSecuritiesRanks
	{
		/// <summary>
		/// 순위1
		/// </summary>
		[JsonProperty("rank_1")]
		public string? Rank1;
		/// <summary>
		/// 순위2
		/// </summary>
		[JsonProperty("rank_2")]
		public string? Rank2;
		/// <summary>
		/// 순위3
		/// </summary>
		[JsonProperty("rank_3")]
		public string? Rank3;
		/// <summary>
		/// 기간중거래량
		/// </summary>
		[JsonProperty("prid_trde_qty")]
		public string? PeriodTradeQuantity;
		/// <summary>
		/// 종목별증권사순위
		/// </summary>
		[JsonProperty("stk_sec_rank")]
		public IEnumerable<KiwoomRankingInfoGetStockSecuritiesRankItem>? Items;
	}

	public record KiwoomRankingInfoGetStockSecuritiesRankItem
	{
		/// <summary>
		/// 순위
		/// </summary>
		[JsonProperty("rank")]
		public string? Rank;
		/// <summary>
		/// 회원사명
		/// </summary>
		[JsonProperty("mmcm_nm")]
		public string? MemberCompanyName;
		/// <summary>
		/// 매수수량
		/// </summary>
		[JsonProperty("buy_qty")]
		public string? BuyQuantity;
		/// <summary>
		/// 매도수량
		/// </summary>
		[JsonProperty("sell_qty")]
		public string? SellQuantity;
		/// <summary>
		/// 누적순매수수량
		/// </summary>
		[JsonProperty("acc_netprps_qty")]
		public string? AccumulatedNetPurchaseQuantity;
	}

	public record KiwoomRankingInfoGetSecuritiesTradeUppers
	{
		/// <summary>
		/// 증권사별매매상위
		/// </summary>
		[JsonProperty("sec_trde_upper")]
		public IEnumerable<KiwoomRankingInfoGetSecuritiesTradeUpperItem>? Items;
	}

	public record KiwoomRankingInfoGetSecuritiesTradeUpperItem
	{
		/// <summary>
		/// 순위
		/// </summary>
		[JsonProperty("rank")]
		public string? Rank;
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
		/// 기간중주가등락
		/// </summary>
		[JsonProperty("prid_stkpc_flu")]
		public string? PeriodStockPriceFluctuation;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		/// <summary>
		/// 기간중거래량
		/// </summary>
		[JsonProperty("prid_trde_qty")]
		public decimal? PeriodTradeQuantity;
		/// <summary>
		/// 순매수
		/// </summary>
		[JsonProperty("netprps")]
		public decimal? NetPurchase;
		/// <summary>
		/// 매수거래량
		/// </summary>
		[JsonProperty("buy_trde_qty")]
		public decimal? BuyTradeQuantity;
		/// <summary>
		/// 매도거래량
		/// </summary>
		[JsonProperty("sel_trde_qty")]
		public decimal? SellTradeQuantity;
	}

	public record KiwoomRankingInfoGetTodayMainTradeOrigins
	{
		/// <summary>
		/// 매도거래원별증감1
		/// </summary>
		[JsonProperty("sel_trde_ori_irds_1")]
		public string? SellTradeOriginChange1;
		/// <summary>
		/// 매도거래원수량1
		/// </summary>
		[JsonProperty("sel_trde_ori_qty_1")]
		public string? SellTradeOriginQuantity1;
		/// <summary>
		/// 매도거래원1
		/// </summary>
		[JsonProperty("sel_trde_ori_1")]
		public string? SellTradeOrigin1;
		/// <summary>
		/// 매도거래원코드1
		/// </summary>
		[JsonProperty("sel_trde_ori_cd_1")]
		public string? SellTradeOriginCode1;
		/// <summary>
		/// 매수거래원1
		/// </summary>
		[JsonProperty("buy_trde_ori_1")]
		public string? BuyTradeOrigin1;
		/// <summary>
		/// 매수거래원코드1
		/// </summary>
		[JsonProperty("buy_trde_ori_cd_1")]
		public string? BuyTradeOriginCode1;
		/// <summary>
		/// 매수거래원수량1
		/// </summary>
		[JsonProperty("buy_trde_ori_qty_1")]
		public string? BuyTradeOriginQuantity1;
		/// <summary>
		/// 매수거래원별증감1
		/// </summary>
		[JsonProperty("buy_trde_ori_irds_1")]
		public string? BuyTradeOriginChange1;
		/// <summary>
		/// 매도거래원별증감2
		/// </summary>
		[JsonProperty("sel_trde_ori_irds_2")]
		public string? SellTradeOriginChange2;
		/// <summary>
		/// 매도거래원수량2
		/// </summary>
		[JsonProperty("sel_trde_ori_qty_2")]
		public string? SellTradeOriginQuantity2;
		/// <summary>
		/// 매도거래원2
		/// </summary>
		[JsonProperty("sel_trde_ori_2")]
		public string? SellTradeOrigin2;
		/// <summary>
		/// 매도거래원코드2
		/// </summary>
		[JsonProperty("sel_trde_ori_cd_2")]
		public string? SellTradeOriginCode2;
		/// <summary>
		/// 매수거래원2
		/// </summary>
		[JsonProperty("buy_trde_ori_2")]
		public string? BuyTradeOrigin2;
		/// <summary>
		/// 매수거래원코드2
		/// </summary>
		[JsonProperty("buy_trde_ori_cd_2")]
		public string? BuyTradeOriginCode2;
		/// <summary>
		/// 매수거래원수량2
		/// </summary>
		[JsonProperty("buy_trde_ori_qty_2")]
		public string? BuyTradeOriginQuantity2;
		/// <summary>
		/// 매수거래원별증감2
		/// </summary>
		[JsonProperty("buy_trde_ori_irds_2")]
		public string? BuyTradeOriginChange2;
		/// <summary>
		/// 매도거래원별증감3
		/// </summary>
		[JsonProperty("sel_trde_ori_irds_3")]
		public string? SellTradeOriginChange3;
		/// <summary>
		/// 매도거래원수량3
		/// </summary>
		[JsonProperty("sel_trde_ori_qty_3")]
		public string? SellTradeOriginQuantity3;
		/// <summary>
		/// 매도거래원3
		/// </summary>
		[JsonProperty("sel_trde_ori_3")]
		public string? SellTradeOrigin3;
		/// <summary>
		/// 매도거래원코드3
		/// </summary>
		[JsonProperty("sel_trde_ori_cd_3")]
		public string? SellTradeOriginCode3;
		/// <summary>
		/// 매수거래원3
		/// </summary>
		[JsonProperty("buy_trde_ori_3")]
		public string? BuyTradeOrigin3;
		/// <summary>
		/// 매수거래원코드3
		/// </summary>
		[JsonProperty("buy_trde_ori_cd_3")]
		public string? BuyTradeOriginCode3;
		/// <summary>
		/// 매수거래원수량3
		/// </summary>
		[JsonProperty("buy_trde_ori_qty_3")]
		public string? BuyTradeOriginQuantity3;
		/// <summary>
		/// 매수거래원별증감3
		/// </summary>
		[JsonProperty("buy_trde_ori_irds_3")]
		public string? BuyTradeOriginChange3;
		/// <summary>
		/// 매도거래원별증감4
		/// </summary>
		[JsonProperty("sel_trde_ori_irds_4")]
		public string? SellTradeOriginChange4;
		/// <summary>
		/// 매도거래원수량4
		/// </summary>
		[JsonProperty("sel_trde_ori_qty_4")]
		public string? SellTradeOriginQuantity4;
		/// <summary>
		/// 매도거래원4
		/// </summary>
		[JsonProperty("sel_trde_ori_4")]
		public string? SellTradeOrigin4;
		/// <summary>
		/// 매도거래원코드4
		/// </summary>
		[JsonProperty("sel_trde_ori_cd_4")]
		public string? SellTradeOriginCode4;
		/// <summary>
		/// 매수거래원4
		/// </summary>
		[JsonProperty("buy_trde_ori_4")]
		public string? BuyTradeOrigin4;
		/// <summary>
		/// 매수거래원코드4
		/// </summary>
		[JsonProperty("buy_trde_ori_cd_4")]
		public string? BuyTradeOriginCode4;
		/// <summary>
		/// 매수거래원수량4
		/// </summary>
		[JsonProperty("buy_trde_ori_qty_4")]
		public string? BuyTradeOriginQuantity4;
		/// <summary>
		/// 매수거래원별증감4
		/// </summary>
		[JsonProperty("buy_trde_ori_irds_4")]
		public string? BuyTradeOriginChange4;
		/// <summary>
		/// 매도거래원별증감5
		/// </summary>
		[JsonProperty("sel_trde_ori_irds_5")]
		public string? SellTradeOriginChange5;
		/// <summary>
		/// 매도거래원수량5
		/// </summary>
		[JsonProperty("sel_trde_ori_qty_5")]
		public string? SellTradeOriginQuantity5;
		/// <summary>
		/// 매도거래원5
		/// </summary>
		[JsonProperty("sel_trde_ori_5")]
		public string? SellTradeOrigin5;
		/// <summary>
		/// 매도거래원코드5
		/// </summary>
		[JsonProperty("sel_trde_ori_cd_5")]
		public string? SellTradeOriginCode5;
		/// <summary>
		/// 매수거래원5
		/// </summary>
		[JsonProperty("buy_trde_ori_5")]
		public string? BuyTradeOrigin5;
		/// <summary>
		/// 매수거래원코드5
		/// </summary>
		[JsonProperty("buy_trde_ori_cd_5")]
		public string? BuyTradeOriginCode5;
		/// <summary>
		/// 매수거래원수량5
		/// </summary>
		[JsonProperty("buy_trde_ori_qty_5")]
		public string? BuyTradeOriginQuantity5;
		/// <summary>
		/// 매수거래원별증감5
		/// </summary>
		[JsonProperty("buy_trde_ori_irds_5")]
		public string? BuyTradeOriginChange5;
		/// <summary>
		/// 외국계매도추정합변동
		/// </summary>
		[JsonProperty("frgn_sel_prsm_sum_chang")]
		public string? ForeignSellEstimateSumChange;
		/// <summary>
		/// 외국계매도추정합
		/// </summary>
		[JsonProperty("frgn_sel_prsm_sum")]
		public string? ForeignSellEstimateSum;
		/// <summary>
		/// 외국계매수추정합
		/// </summary>
		[JsonProperty("frgn_buy_prsm_sum")]
		public string? ForeignBuyEstimateSum;
		/// <summary>
		/// 외국계매수추정합변동
		/// </summary>
		[JsonProperty("frgn_buy_prsm_sum_chang")]
		public string? ForeignBuyEstimateSumChange;
		/// <summary>
		/// 당일주요거래원
		/// </summary>
		[JsonProperty("tdy_main_trde_ori")]
		public IEnumerable<KiwoomRankingInfoGetTodayMainTradeOriginItem>? Items;
	}
	public record KiwoomRankingInfoGetTodayMainTradeOriginItem
	{
		/// <summary>
		/// 매도이탈시간
		/// </summary>
		[JsonProperty("sel_scesn_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? SellExitTime;
		/// <summary>
		/// 매도수량
		/// </summary>
		[JsonProperty("sell_qty")]
		public string? SellQuantity;
		/// <summary>
		/// 매도상위이탈원
		/// </summary>
		[JsonProperty("sel_upper_scesn_ori")]
		public string? SellTopExitOrigin;
		/// <summary>
		/// 매수이탈시간
		/// </summary>
		[JsonProperty("buy_scesn_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? BuyExitTime;
		/// <summary>
		/// 매수수량
		/// </summary>
		[JsonProperty("buy_qty")]
		public string? BuyQuantity;
		/// <summary>
		/// 매수상위이탈원
		/// </summary>
		[JsonProperty("buy_upper_scesn_ori")]
		public string? BuyTopExitOrigin;
		/// <summary>
		/// 조회일자
		/// </summary>
		[JsonProperty("qry_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? QueryDate;
		/// <summary>
		/// 조회시간
		/// </summary>
		[JsonProperty("qry_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? QueryTime;
	}

	public record KiwoomRankingInfoGetNetPurchaseTradeOriginRanks
	{
		/// <summary>
		/// 순매수거래원순위
		/// </summary>
		[JsonProperty("netprps_trde_ori_rank")]
		public IEnumerable<KiwoomRankingInfoGetNetPurchaseTradeOriginRankItem>? Items;
	}
	public record KiwoomRankingInfoGetNetPurchaseTradeOriginRankItem
	{
		/// <summary>
		/// 순위
		/// </summary>
		[JsonProperty("rank")]
		public string? Rank;
		/// <summary>
		/// 회원사코드
		/// </summary>
		[JsonProperty("mmcm_cd")]
		public string? MemberCode;
		/// <summary>
		/// 회원사명
		/// </summary>
		[JsonProperty("mmcm_nm")]
		public string? MemberName;
	}

	public record KiwoomRankingInfoGetTodayUpperSecessionOrigins
	{
		/// <summary>
		/// 당일상위이탈원
		/// </summary>
		[JsonProperty("tdy_upper_scesn_ori")]
		public IEnumerable<KiwoomRankingInfoGetTodayUpperSecessionOriginItem>? Items;
	}
	public record KiwoomRankingInfoGetTodayUpperSecessionOriginItem
	{
		/// <summary>
		/// 매도이탈시간
		/// </summary>
		[JsonProperty("sel_scesn_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? SellExitTime;
		/// <summary>
		/// 매도수량
		/// </summary>
		[JsonProperty("sell_qty")]
		public string? SellQuantity;
		/// <summary>
		/// 매도상위이탈원
		/// </summary>
		[JsonProperty("sel_upper_scesn_ori")]
		public string? SellUpperExitOrigin;
		/// <summary>
		/// 매수이탈시간
		/// </summary>
		[JsonProperty("buy_scesn_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? BuyExitTime;
		/// <summary>
		/// 매수수량
		/// </summary>
		[JsonProperty("buy_qty")]
		public string? BuyQuantity;
		/// <summary>
		/// 매수상위이탈원
		/// </summary>
		[JsonProperty("buy_upper_scesn_ori")]
		public string? BuyUpperExitOrigin;
		/// <summary>
		/// 조회일자
		/// </summary>
		[JsonProperty("qry_dt")]
		public string? QueryDate;
		/// <summary>
		/// 조회시간
		/// </summary>
		[JsonProperty("qry_tm")]
		public string? QueryTime;
	}

	public record KiwoomRankingInfoGetEqualNetTradeRanks
	{
		/// <summary>
		/// 동일순매매순위
		/// </summary>
		[JsonProperty("eql_nettrde_rank")]
		public IEnumerable<KiwoomRankingInfoGetEqualNetTradeRankItem>? Items;
	}
	public record KiwoomRankingInfoGetEqualNetTradeRankItem
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 순위
		/// </summary>
		[JsonProperty("rank")]
		public string? Rank;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 대비기호
		/// </summary>
		[JsonProperty("pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? PreviousDayChange;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? FluctuationRate;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? AccumulatedTradeQuantity;
		/// <summary>
		/// 기관순매매수량
		/// </summary>
		[JsonProperty("orgn_nettrde_qty")]
		public KiwoomDecimal? InstitutionNetTradeQuantity;
		/// <summary>
		/// 기관순매매금액
		/// </summary>
		[JsonProperty("orgn_nettrde_amt")]
		public KiwoomDecimal? InstitutionNetTradeAmount;
		/// <summary>
		/// 기관순매매평균가
		/// </summary>
		[JsonProperty("orgn_nettrde_avg_pric")]
		public decimal? InstitutionNetTradeAveragePrice;
		/// <summary>
		/// 외인순매매수량
		/// </summary>
		[JsonProperty("for_nettrde_qty")]
		public KiwoomDecimal? ForeignerNetTradeQuantity;
		/// <summary>
		/// 외인순매매금액
		/// </summary>
		[JsonProperty("for_nettrde_amt")]
		public KiwoomDecimal? ForeignerNetTradeAmount;
		/// <summary>
		/// 외인순매매평균가
		/// </summary>
		[JsonProperty("for_nettrde_avg_pric")]
		public decimal? ForeignerNetTradeAveragePrice;
		/// <summary>
		/// 순매매수량
		/// </summary>
		[JsonProperty("nettrde_qty")]
		public KiwoomDecimal? NetTradeQuantity;
		/// <summary>
		/// 순매매금액
		/// </summary>
		[JsonProperty("nettrde_amt")]
		public KiwoomDecimal? NetTradeAmount;
	}

	public record KiwoomRankingInfoGetOpenMarketInvestorTradeUppers
	{
		/// <summary>
		/// 장중투자자별매매상위
		/// </summary>
		[JsonProperty("opmr_invsr_trde_upper")]
		public IEnumerable<KiwoomRankingInfoGetOpenMarketInvestorTradeUpperItem>? Items;
	}
	public record KiwoomRankingInfoGetOpenMarketInvestorTradeUpperItem
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
		/// 매도량
		/// </summary>
		[JsonProperty("sel_qty")]
		public decimal? SellQuantity;
		/// <summary>
		/// 매수량
		/// </summary>
		[JsonProperty("buy_qty")]
		public decimal? BuyQuantity;
		/// <summary>
		/// 순매도
		/// </summary>
		[JsonProperty("netslmt")]
		public decimal? NetSell;
	}

	public record KiwoomRankingInfoGetOvertimeSinglePriceFluctuationRateRanks
	{
		/// <summary>
		/// 시간외단일가등락율순위
		/// </summary>
		[JsonProperty("ovt_sigpric_flu_rt_rank")]
		public IEnumerable<KiwoomRankingInfoGetOvertimeSinglePriceFluctuationRateRankItem>? Items;
	}
	public record KiwoomRankingInfoGetOvertimeSinglePriceFluctuationRateRankItem
	{
		/// <summary>
		/// 순위
		/// </summary>
		[JsonProperty("rank")]
		public string? Rank;
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
		public string? PreviousDayChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDayChange;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		/// <summary>
		/// 매도총잔량
		/// </summary>
		[JsonProperty("sel_tot_req")]
		public decimal? TotalSellRequest;
		/// <summary>
		/// 매수총잔량
		/// </summary>
		[JsonProperty("buy_tot_req")]
		public decimal? TotalBuyRequest;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? AccumulatedTradeQuantity;
		/// <summary>
		/// 누적거래대금
		/// </summary>
		[JsonProperty("acc_trde_prica")]
		public decimal? AccumulatedTradePriceAmount;
		/// <summary>
		/// 당일종가
		/// </summary>
		[JsonProperty("tdy_close_pric")]
		public decimal? TodayClosingPrice;
		/// <summary>
		/// 당일종가등락률
		/// </summary>
		[JsonProperty("tdy_close_pric_flu_rt")]
		public decimal? TodayClosingPriceFluctuationRate;
	}

	public record KiwoomRankingInfoGetForeignInstitutionTradeUppers
	{
		/// <summary>
		/// 외국인기관매매상위
		/// </summary>
		[JsonProperty("frgnr_orgn_trde_upper")]
		public IEnumerable<KiwoomRankingInfoGetForeignInstitutionTradeUpperItem>? Items;
	}
	public record KiwoomRankingInfoGetForeignInstitutionTradeUpperItem
	{
		/// <summary>
		/// 외인순매도종목코드
		/// </summary>
		[JsonProperty("for_netslmt_stk_cd")]
		public string? ForeignNetSellStockCode;
		/// <summary>
		/// 외인순매도종목명
		/// </summary>
		[JsonProperty("for_netslmt_stk_nm")]
		public string? ForeignNetSellStockName;
		/// <summary>
		/// 외인순매도금액
		/// </summary>
		[JsonProperty("for_netslmt_amt")]
		public decimal? ForeignNetSellAmount;
		/// <summary>
		/// 외인순매도수량
		/// </summary>
		[JsonProperty("for_netslmt_qty")]
		public decimal? ForeignNetSellQuantity;
		/// <summary>
		/// 외인순매수종목코드
		/// </summary>
		[JsonProperty("for_netprps_stk_cd")]
		public string? ForeignNetPurchaseStockCode;
		/// <summary>
		/// 외인순매수종목명
		/// </summary>
		[JsonProperty("for_netprps_stk_nm")]
		public string? ForeignNetPurchaseStockName;
		/// <summary>
		/// 외인순매수금액
		/// </summary>
		[JsonProperty("for_netprps_amt")]
		public decimal? ForeignNetPurchaseAmount;
		/// <summary>
		/// 외인순매수수량
		/// </summary>
		[JsonProperty("for_netprps_qty")]
		public decimal? ForeignNetPurchaseQuantity;
		/// <summary>
		/// 기관순매도종목코드
		/// </summary>
		[JsonProperty("orgn_netslmt_stk_cd")]
		public string? InstitutionNetSellStockCode;
		/// <summary>
		/// 기관순매도종목명
		/// </summary>
		[JsonProperty("orgn_netslmt_stk_nm")]
		public string? InstitutionNetSellStockName;
		/// <summary>
		/// 기관순매도금액
		/// </summary>
		[JsonProperty("orgn_netslmt_amt")]
		public decimal? InstitutionNetSellAmount;
		/// <summary>
		/// 기관순매도수량
		/// </summary>
		[JsonProperty("orgn_netslmt_qty")]
		public decimal? InstitutionNetSellQuantity;
		/// <summary>
		/// 기관순매수종목코드
		/// </summary>
		[JsonProperty("orgn_netprps_stk_cd")]
		public string? InstitutionNetPurchaseStockCode;
		/// <summary>
		/// 기관순매수종목명
		/// </summary>
		[JsonProperty("orgn_netprps_stk_nm")]
		public string? InstitutionNetPurchaseStockName;
		/// <summary>
		/// 기관순매수금액
		/// </summary>
		[JsonProperty("orgn_netprps_amt")]
		public decimal? InstitutionNetPurchaseAmount;
		/// <summary>
		/// 기관순매수수량
		/// </summary>
		[JsonProperty("orgn_netprps_qty")]
		public decimal? InstitutionNetPurchaseQuantity;
	}
}
