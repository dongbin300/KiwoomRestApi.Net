using KiwoomRestApi.Net.Converters;
using KiwoomRestApi.Net.Objects.Commons;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models
{
	public record KiwoomStockInfoGetRealtimeStockRanks
	{
		/// <summary>
		/// 실시간종목조회순위
		/// </summary>
		[JsonProperty("item_inq_rank")]
		public IEnumerable<KiwoomStockInfoGetRealtimeStockRankItem>? Items;
	}
	public record KiwoomStockInfoGetRealtimeStockRankItem
	{
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 빅데이터 순위
		/// </summary>
		[JsonProperty("bigd_rank")]
		public string? BigDataRank;
		/// <summary>
		/// 순위 등락
		/// </summary>
		[JsonProperty("rank_chg")]
		public string? RankChange;
		/// <summary>
		/// 순위 등락 부호
		/// </summary>
		[JsonProperty("rank_chg_sign")]
		public string? RankChangeSign;
		/// <summary>
		/// 과거 현재가
		/// </summary>
		[JsonProperty("past_curr_prc")]
		public string? PastCurrentPrice;
		/// <summary>
		/// 기준가 대비 부호
		/// </summary>
		[JsonProperty("base_comp_sign")]
		public string? BaseCompareSign;
		/// <summary>
		/// 기준가 대비 등락율
		/// </summary>
		[JsonProperty("base_comp_chgr")]
		public string? BaseCompareChangeRate;
		/// <summary>
		/// 직전 기준 대비 부호
		/// </summary>
		[JsonProperty("prev_base_sign")]
		public string? PrevBaseSign;
		/// <summary>
		/// 직전 기준 대비 등락율
		/// </summary>
		[JsonProperty("prev_base_chgr")]
		public string? PrevBaseChangeRate;
		/// <summary>
		/// 일자
		/// </summary>
		[JsonProperty("dt")]
		public string? Date;
		/// <summary>
		/// 시간
		/// </summary>
		[JsonProperty("tm")]
		public string? Time;
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
	}

	public record KiwoomStockInfoGetStockInfo
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
		/// 결산월
		/// </summary>
		[JsonProperty("setl_mm")]
		public decimal? SettlementMonth;
		/// <summary>
		/// 액면가
		/// </summary>
		[JsonProperty("fav")]
		public decimal? FaceValue;
		/// <summary>
		/// 자본금
		/// </summary>
		[JsonProperty("cap")]
		public decimal? Capital;
		/// <summary>
		/// 상장주식
		/// </summary>
		[JsonProperty("flo_stk")]
		public decimal? ListedStocks;
		/// <summary>
		/// 신용비율
		/// </summary>
		[JsonProperty("crd_rt")]
		public decimal? CreditRatio;
		/// <summary>
		/// 연중최고
		/// </summary>
		[JsonProperty("oyr_hgst")]
		public decimal? YearHigh;
		/// <summary>
		/// 연중최저
		/// </summary>
		[JsonProperty("oyr_lwst")]
		public decimal? YearLow;
		/// <summary>
		/// 시가총액
		/// </summary>
		[JsonProperty("mac")]
		public decimal? MarketCap;
		/// <summary>
		/// 시가총액비중
		/// </summary>
		[JsonProperty("mac_wght")]
		public decimal? MarketCapWeight;
		/// <summary>
		/// 외인소진률
		/// </summary>
		[JsonProperty("for_exh_rt")]
		public decimal? ForeignOwnershipRate;
		/// <summary>
		/// 대용가
		/// </summary>
		[JsonProperty("repl_pric")]
		public decimal? SubstitutePrice;
		/// <summary>
		/// PER [ 주의 ] PER, ROE 값들은 외부벤더사에서 제공되는 데이터이며 일주일에 한번 또는 실적발표 시즌에 업데이트 됨
		/// </summary>
		[JsonProperty("per")]
		public decimal? PER;
		/// <summary>
		/// EPS
		/// </summary>
		[JsonProperty("eps")]
		public decimal? EPS;
		/// <summary>
		/// ROE [ 주의 ] PER, ROE 값들은 외부벤더사에서 제공되는 데이터이며 일주일에 한번 또는 실적발표 시즌에 업데이트 됨
		/// </summary>
		[JsonProperty("roe")]
		public decimal? ROE;
		/// <summary>
		/// PBR
		/// </summary>
		[JsonProperty("pbr")]
		public decimal? PBR;
		/// <summary>
		/// EV
		/// </summary>
		[JsonProperty("ev")]
		public decimal? EV;
		/// <summary>
		/// BPS
		/// </summary>
		[JsonProperty("bps")]
		public decimal? BPS;
		/// <summary>
		/// 매출액
		/// </summary>
		[JsonProperty("sale_amt")]
		public decimal? SalesAmount;
		/// <summary>
		/// 영업이익
		/// </summary>
		[JsonProperty("bus_pro")]
		public decimal? OperatingProfit;
		/// <summary>
		/// 당기순이익
		/// </summary>
		[JsonProperty("cup_nga")]
		public decimal? NetIncome;
		/// <summary>
		/// 250최고
		/// </summary>
		[JsonProperty("250hgst")]
		public decimal? High250;
		/// <summary>
		/// 250최저
		/// </summary>
		[JsonProperty("250lwst")]
		public decimal? Low250;
		/// <summary>
		/// 고가
		/// </summary>
		[JsonProperty("high_pric")]
		public decimal? HighPrice;
		/// <summary>
		/// 시가
		/// </summary>
		[JsonProperty("open_pric")]
		public decimal? OpenPrice;
		/// <summary>
		/// 저가
		/// </summary>
		[JsonProperty("low_pric")]
		public decimal? LowPrice;
		/// <summary>
		/// 상한가
		/// </summary>
		[JsonProperty("upl_pric")]
		public decimal? UpperLimitPrice;
		/// <summary>
		/// 하한가
		/// </summary>
		[JsonProperty("lst_pric")]
		public decimal? LowerLimitPrice;
		/// <summary>
		/// 기준가
		/// </summary>
		[JsonProperty("base_pric")]
		public decimal? BasePrice;
		/// <summary>
		/// 예상체결가
		/// </summary>
		[JsonProperty("exp_cntr_pric")]
		public decimal? ExpectedContractPrice;
		/// <summary>
		/// 예상체결수량
		/// </summary>
		[JsonProperty("exp_cntr_qty")]
		public decimal? ExpectedContractQuantity;
		/// <summary>
		/// 250최고가일
		/// </summary>
		[JsonProperty("250hgst_pric_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? DateHigh250;
		/// <summary>
		/// 250최고가대비율
		/// </summary>
		[JsonProperty("250hgst_pric_pre_rt")]
		public decimal? RateComparedToHigh250;
		/// <summary>
		/// 250최저가일
		/// </summary>
		[JsonProperty("250lwst_pric_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? DateLow250;
		/// <summary>
		/// 250최저가대비율
		/// </summary>
		[JsonProperty("250lwst_pric_pre_rt")]
		public decimal? RateComparedToLow250;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		/// <summary>
		/// 대비기호
		/// </summary>
		[JsonProperty("pre_sig")]
		public string? PriceDiffSymbol;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PriceDiffAmount;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? TradeVolume;
		/// <summary>
		/// 거래대비
		/// </summary>
		[JsonProperty("trde_pre")]
		public decimal? TradeComparison;
		/// <summary>
		/// 액면가단위
		/// </summary>
		[JsonProperty("fav_unit")]
		public string? FaceValueUnit;
		/// <summary>
		/// 유통주식
		/// </summary>
		[JsonProperty("dstr_stk")]
		public decimal? DistributionStocks;
		/// <summary>
		/// 유통비율
		/// </summary>
		[JsonProperty("dstr_rt")]
		public decimal? DistributionRate;
	}

	public record KiwoomStockInfoGetTradeInfo
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
		/// 등락부호
		/// </summary>
		[JsonProperty("flu_smbol")]
		public string? FluctuationSymbol;
		/// <summary>
		/// 기준가
		/// </summary>
		[JsonProperty("base_pric")]
		public decimal? BasePrice;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		/// <summary>
		/// 매도거래원명1
		/// </summary>
		[JsonProperty("sel_trde_ori_nm_1")]
		public string? SellTraderName1;
		/// <summary>
		/// 매도거래원1
		/// </summary>
		[JsonProperty("sel_trde_ori_1")]
		public string? SellTrader1;
		/// <summary>
		/// 매도거래량1
		/// </summary>
		[JsonProperty("sel_trde_qty_1")]
		public decimal? SellTradeQty1;
		/// <summary>
		/// 매수거래원명1
		/// </summary>
		[JsonProperty("buy_trde_ori_nm_1")]
		public string? BuyTraderName1;
		/// <summary>
		/// 매수거래원1
		/// </summary>
		[JsonProperty("buy_trde_ori_1")]
		public string? BuyTrader1;
		/// <summary>
		/// 매수거래량1
		/// </summary>
		[JsonProperty("buy_trde_qty_1")]
		public decimal? BuyTradeQty1;
		/// <summary>
		/// 매도거래원명2
		/// </summary>
		[JsonProperty("sel_trde_ori_nm_2")]
		public string? SellTraderName2;
		/// <summary>
		/// 매도거래원2
		/// </summary>
		[JsonProperty("sel_trde_ori_2")]
		public string? SellTrader2;
		/// <summary>
		/// 매도거래량2
		/// </summary>
		[JsonProperty("sel_trde_qty_2")]
		public decimal? SellTradeQty2;
		/// <summary>
		/// 매수거래원명2
		/// </summary>
		[JsonProperty("buy_trde_ori_nm_2")]
		public string? BuyTraderName2;
		/// <summary>
		/// 매수거래원2
		/// </summary>
		[JsonProperty("buy_trde_ori_2")]
		public string? BuyTrader2;
		/// <summary>
		/// 매수거래량2
		/// </summary>
		[JsonProperty("buy_trde_qty_2")]
		public decimal? BuyTradeQty2;
		/// <summary>
		/// 매도거래원명3
		/// </summary>
		[JsonProperty("sel_trde_ori_nm_3")]
		public string? SellTraderName3;
		/// <summary>
		/// 매도거래원3
		/// </summary>
		[JsonProperty("sel_trde_ori_3")]
		public string? SellTrader3;
		/// <summary>
		/// 매도거래량3
		/// </summary>
		[JsonProperty("sel_trde_qty_3")]
		public decimal? SellTradeQty3;
		/// <summary>
		/// 매수거래원명3
		/// </summary>
		[JsonProperty("buy_trde_ori_nm_3")]
		public string? BuyTraderName3;
		/// <summary>
		/// 매수거래원3
		/// </summary>
		[JsonProperty("buy_trde_ori_3")]
		public string? BuyTrader3;
		/// <summary>
		/// 매수거래량3
		/// </summary>
		[JsonProperty("buy_trde_qty_3")]
		public decimal? BuyTradeQty3;
		/// <summary>
		/// 매도거래원명4
		/// </summary>
		[JsonProperty("sel_trde_ori_nm_4")]
		public string? SellTraderName4;
		/// <summary>
		/// 매도거래원4
		/// </summary>
		[JsonProperty("sel_trde_ori_4")]
		public string? SellTrader4;
		/// <summary>
		/// 매도거래량4
		/// </summary>
		[JsonProperty("sel_trde_qty_4")]
		public decimal? SellTradeQty4;
		/// <summary>
		/// 매수거래원명4
		/// </summary>
		[JsonProperty("buy_trde_ori_nm_4")]
		public string? BuyTraderName4;
		/// <summary>
		/// 매수거래원4
		/// </summary>
		[JsonProperty("buy_trde_ori_4")]
		public string? BuyTrader4;
		/// <summary>
		/// 매수거래량4
		/// </summary>
		[JsonProperty("buy_trde_qty_4")]
		public decimal? BuyTradeQty4;
		/// <summary>
		/// 매도거래원명5
		/// </summary>
		[JsonProperty("sel_trde_ori_nm_5")]
		public string? SellTraderName5;
		/// <summary>
		/// 매도거래원5
		/// </summary>
		[JsonProperty("sel_trde_ori_5")]
		public string? SellTrader5;
		/// <summary>
		/// 매도거래량5
		/// </summary>
		[JsonProperty("sel_trde_qty_5")]
		public decimal? SellTradeQty5;
		/// <summary>
		/// 매수거래원명5
		/// </summary>
		[JsonProperty("buy_trde_ori_nm_5")]
		public string? BuyTraderName5;
		/// <summary>
		/// 매수거래원5
		/// </summary>
		[JsonProperty("buy_trde_ori_5")]
		public string? BuyTrader5;
		/// <summary>
		/// 매수거래량5
		/// </summary>
		[JsonProperty("buy_trde_qty_5")]
		public decimal? BuyTradeQty5;
	}

	public record KiwoomStockInfoGetContracts
	{
		/// <summary>
		/// 체결정보 리스트
		/// </summary>
		[JsonProperty("cntr_infr")]
		public IEnumerable<KiwoomStockInfoGetContractItem>? Items;
	}
	public record KiwoomStockInfoGetContractItem
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
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		/// <summary>
		/// 대비율
		/// </summary>
		[JsonProperty("pre_rt")]
		public decimal? DifferenceRate;
		/// <summary>
		/// 우선매도호가단위
		/// </summary>
		[JsonProperty("pri_sel_bid_unit")]
		public decimal? PrioritySellBidUnit;
		/// <summary>
		/// 우선매수호가단위
		/// </summary>
		[JsonProperty("pri_buy_bid_unit")]
		public decimal? PriorityBuyBidUnit;
		/// <summary>
		/// 체결거래량
		/// </summary>
		[JsonProperty("cntr_trde_qty")]
		public decimal? TradeQuantity;
		/// <summary>
		/// sign
		/// </summary>
		[JsonProperty("sign")]
		public string? Sign;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? AccumulatedTradeQuantity;
		/// <summary>
		/// 누적거래대금
		/// </summary>
		[JsonProperty("acc_trde_prica")]
		public decimal? AccumulatedTradeAmount;
		/// <summary>
		/// 체결강도
		/// </summary>
		[JsonProperty("cntr_str")]
		public decimal? TradeStrength;
		/// <summary>
		/// 거래소구분 - KRX, NXT, 통합
		/// </summary>
		[JsonProperty("stex_tp")]
		public string? ExchangeType;
	}

	public record KiwoomStockInfoGetCreditTradeTrends
	{
		/// <summary>
		/// 신용매매동향 리스트
		/// </summary>
		[JsonProperty("crd_trde_trend")]
		public IEnumerable<KiwoomStockInfoGetCreditTradeTrendItem>? Items;
	}
	public record KiwoomStockInfoGetCreditTradeTrendItem
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
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? PreviousDifferenceSymbol;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? TradeQuantity;
		/// <summary>
		/// 신규
		/// </summary>
		[JsonProperty("new")]
		public decimal? NewCount;
		/// <summary>
		/// 상환
		/// </summary>
		[JsonProperty("rpya")]
		public decimal? Repayment;
		/// <summary>
		/// 잔고
		/// </summary>
		[JsonProperty("remn")]
		public decimal? Balance;
		/// <summary>
		/// 금액
		/// </summary>
		[JsonProperty("amt")]
		public decimal? Amount;
		/// <summary>
		/// 대비
		/// </summary>
		[JsonProperty("pre")]
		public decimal? Difference;
		/// <summary>
		/// 공여율
		/// </summary>
		[JsonProperty("shr_rt")]
		public decimal? LoanRate;
		/// <summary>
		/// 잔고율
		/// </summary>
		[JsonProperty("remn_rt")]
		public decimal? BalanceRate;
	}

	public record KiwoomStockInfoGetDailyTradeDetails
	{
		/// <summary>
		/// 일별거래상세 리스트
		/// </summary>
		[JsonProperty("daly_trde_dtl")]
		public IEnumerable<KiwoomStockInfoGetDailyTradeDetailItem>? Items;
	}
	public record KiwoomStockInfoGetDailyTradeDetailItem
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
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? PreviousDifferenceSymbol;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
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
		/// 거래대금
		/// </summary>
		[JsonProperty("trde_prica")]
		public decimal? TradeAmount;
		/// <summary>
		/// 장전거래량
		/// </summary>
		[JsonProperty("bf_mkrt_trde_qty")]
		public decimal? BeforeMarketTradeQuantity;
		/// <summary>
		/// 장전거래비중
		/// </summary>
		[JsonProperty("bf_mkrt_trde_wght")]
		public decimal? BeforeMarketTradeWeight;
		/// <summary>
		/// 장중거래량
		/// </summary>
		[JsonProperty("opmr_trde_qty")]
		public decimal? OpenMarketTradeQuantity;
		/// <summary>
		/// 장중거래비중
		/// </summary>
		[JsonProperty("opmr_trde_wght")]
		public decimal? OpenMarketTradeWeight;
		/// <summary>
		/// 장후거래량
		/// </summary>
		[JsonProperty("af_mkrt_trde_qty")]
		public decimal? AfterMarketTradeQuantity;
		/// <summary>
		/// 장후거래비중
		/// </summary>
		[JsonProperty("af_mkrt_trde_wght")]
		public decimal? AfterMarketTradeWeight;
		/// <summary>
		/// 합계3
		/// </summary>
		[JsonProperty("tot_3")]
		public decimal? Total3;
		/// <summary>
		/// 기간중거래량
		/// </summary>
		[JsonProperty("prid_trde_qty")]
		public decimal? PeriodTradeQuantity;
		/// <summary>
		/// 체결강도
		/// </summary>
		[JsonProperty("cntr_str")]
		public decimal? ContractStrength;
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
		/// 외국계
		/// </summary>
		[JsonProperty("frgn")]
		public decimal? ForeignType;
		/// <summary>
		/// 신용잔고율
		/// </summary>
		[JsonProperty("crd_remn_rt")]
		public decimal? CreditBalanceRate;
		/// <summary>
		/// 프로그램
		/// </summary>
		[JsonProperty("prm")]
		public decimal? Program;
		/// <summary>
		/// 장전거래대금
		/// </summary>
		[JsonProperty("bf_mkrt_trde_prica")]
		public decimal? BeforeMarketTradeAmount;
		/// <summary>
		/// 장전거래대금비중
		/// </summary>
		[JsonProperty("bf_mkrt_trde_prica_wght")]
		public decimal? BeforeMarketTradeAmountWeight;
		/// <summary>
		/// 장중거래대금
		/// </summary>
		[JsonProperty("opmr_trde_prica")]
		public decimal? OpenMarketTradeAmount;
		/// <summary>
		/// 장중거래대금비중
		/// </summary>
		[JsonProperty("opmr_trde_prica_wght")]
		public decimal? OpenMarketTradeAmountWeight;
		/// <summary>
		/// 장후거래대금
		/// </summary>
		[JsonProperty("af_mkrt_trde_prica")]
		public decimal? AfterMarketTradeAmount;
		/// <summary>
		/// 장후거래대금비중
		/// </summary>
		[JsonProperty("af_mkrt_trde_prica_wght")]
		public decimal? AfterMarketTradeAmountWeight;
	}

	public record KiwoomStockInfoGetLowPrices
	{
		/// <summary>
		/// 신고저가 리스트
		/// </summary>
		[JsonProperty("ntl_pric")]
		public IEnumerable<KiwoomStockInfoGetLowPriceItem>? Items;
	}

	public record KiwoomStockInfoGetLowPriceItem
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
		public string? PreviousDifferenceSymbol;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
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
		/// 전일거래량대비율
		/// </summary>
		[JsonProperty("pred_trde_qty_pre_rt")]
		public decimal? PreviousTradeQtyRate;
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

	public record KiwoomStockInfoGetUpdownPrices
	{
		/// <summary>
		/// 상하한가 리스트
		/// </summary>
		[JsonProperty("updown_pric")]
		public IEnumerable<KiwoomStockInfoGetUpdownPriceItem>? Items;
	}

	public record KiwoomStockInfoGetUpdownPriceItem
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 종목정보
		/// </summary>
		[JsonProperty("stk_infr")]
		public string? StockInfo;
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
		public string? PreviousDifferenceSymbol;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
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
		/// 전일거래량
		/// </summary>
		[JsonProperty("pred_trde_qty")]
		public decimal? PreviousTradeQuantity;
		/// <summary>
		/// 매도잔량
		/// </summary>
		[JsonProperty("sel_req")]
		public decimal? SellRemainingQuantity;
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
		public decimal? BuyRemainingQuantity;
		/// <summary>
		/// 횟수
		/// </summary>
		[JsonProperty("cnt")]
		public decimal? Count;
	}

	public record KiwoomStockInfoGetHighLowPriceProximities
	{
		/// <summary>
		/// 고저가근접 리스트
		/// </summary>
		[JsonProperty("high_low_pric_alacc")]
		public IEnumerable<KiwoomStockInfoGetHighLowPriceProximityItem>? Items;
	}
	public record KiwoomStockInfoGetHighLowPriceProximityItem
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
		public string? PreviousDifferenceSymbol;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
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
		/// 당일고가
		/// </summary>
		[JsonProperty("tdy_high_pric")]
		public decimal? TodayHighPrice;
		/// <summary>
		/// 당일저가
		/// </summary>
		[JsonProperty("tdy_low_pric")]
		public decimal? TodayLowPrice;
	}

	public record KiwoomStockInfoGetPriceJumpFluctuations
	{
		/// <summary>
		/// 가격급등락 리스트
		/// </summary>
		[JsonProperty("pric_jmpflu")]
		public IEnumerable<KiwoomStockInfoGetPriceJumpFluctuationItem>? Items;
	}
	public record KiwoomStockInfoGetPriceJumpFluctuationItem
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 종목분류
		/// </summary>
		[JsonProperty("stk_cls")]
		public string? StockClass;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? PreviousDifferenceSymbol;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		/// <summary>
		/// 기준가
		/// </summary>
		[JsonProperty("base_pric")]
		public decimal? BasePrice;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		/// <summary>
		/// 기준대비
		/// </summary>
		[JsonProperty("base_pre")]
		public decimal? BaseDifference;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? TradeQuantity;
		/// <summary>
		/// 급등률
		/// </summary>
		[JsonProperty("jmp_rt")]
		public decimal? JumpRate;
	}

	public record KiwoomStockInfoGetTradeVolumeUpdates
	{
		/// <summary>
		/// 거래량갱신 리스트
		/// </summary>
		[JsonProperty("trde_qty_updt")]
		public IEnumerable<KiwoomStockInfoGetTradeVolumeUpdateItem>? Items;
	}
	public record KiwoomStockInfoGetTradeVolumeUpdateItem
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
		public string? PreviousDifferenceSymbol;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		/// <summary>
		/// 이전거래량
		/// </summary>
		[JsonProperty("prev_trde_qty")]
		public decimal? PreviousTradeQuantity;
		/// <summary>
		/// 현재거래량
		/// </summary>
		[JsonProperty("now_trde_qty")]
		public decimal? CurrentTradeQuantity;
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
	}

	public record KiwoomStockInfoGetPriceConcentrations
	{
		/// <summary>
		/// 매물대집중 리스트
		/// </summary>
		[JsonProperty("prps_cnctr")]
		public IEnumerable<KiwoomStockInfoGetPriceConcentrationItem>? Items;
	}
	public record KiwoomStockInfoGetPriceConcentrationItem
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
		public string? PreviousDifferenceSymbol;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		/// <summary>
		/// 현재거래량
		/// </summary>
		[JsonProperty("now_trde_qty")]
		public decimal? CurrentTradeQuantity;
		/// <summary>
		/// 가격대시작
		/// </summary>
		[JsonProperty("pric_strt")]
		public decimal? PriceStart;
		/// <summary>
		/// 가격대끝
		/// </summary>
		[JsonProperty("pric_end")]
		public decimal? PriceEnd;
		/// <summary>
		/// 매물량
		/// </summary>
		[JsonProperty("prps_qty")]
		public decimal? PriceQuantity;
		/// <summary>
		/// 매물비
		/// </summary>
		[JsonProperty("prps_rt")]
		public decimal? PriceRatio;
	}

	public record KiwoomStockInfoGetHighLowPers
	{
		/// <summary>
		/// 고저PER 리스트
		/// </summary>
		[JsonProperty("high_low_per")]
		public IEnumerable<KiwoomStockInfoGetHighLowPerItem>? Items;
	}
	public record KiwoomStockInfoGetHighLowPerItem
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
		/// PER
		/// </summary>
		[JsonProperty("per")]
		public decimal? PER;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? PreviousDifferenceSymbol;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		/// <summary>
		/// 현재거래량
		/// </summary>
		[JsonProperty("now_trde_qty")]
		public decimal? CurrentTradeQuantity;
		/// <summary>
		/// 매도호가
		/// </summary>
		[JsonProperty("sel_bid")]
		public decimal? SellBid;
	}

	public record KiwoomStockInfoGetOpenPriceCompareFluctuations
	{
		/// <summary>
		/// 시가대비등락률 리스트
		/// </summary>
		[JsonProperty("open_pric_pre_flu_rt")]
		public IEnumerable<KiwoomStockInfoGetOpenPriceCompareFluctuationItem>? Items;
	}
	public record KiwoomStockInfoGetOpenPriceCompareFluctuationItem
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
		public string? PreviousDifferenceSymbol;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
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
		/// 시가대비
		/// </summary>
		[JsonProperty("open_pric_pre")]
		public string? OpenPriceCompared;
		/// <summary>
		/// 현재거래량
		/// </summary>
		[JsonProperty("now_trde_qty")]
		public decimal? CurrentTradeQuantity;
		/// <summary>
		/// 체결강도
		/// </summary>
		[JsonProperty("cntr_str")]
		public decimal? TradeStrength;
	}

	public record KiwoomStockInfoGetTradeOriginPriceAnalyses
	{
		/// <summary>
		/// 거래원매물대분석 리스트
		/// </summary>
		[JsonProperty("trde_ori_prps_anly")]
		public IEnumerable<KiwoomStockInfoGetTradeOriginPriceAnalysisItem>? Items;
	}
	public record KiwoomStockInfoGetTradeOriginPriceAnalysisItem
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
		public string? DifferenceSymbol;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? PreviousDifference;
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
		/// 순매수수량
		/// </summary>
		[JsonProperty("netprps_qty")]
		public KiwoomDecimal? NetPurchaseQuantity;
		/// <summary>
		/// 거래량합
		/// </summary>
		[JsonProperty("trde_qty_sum")]
		public decimal? TotalTradeQuantity;
		/// <summary>
		/// 거래비중
		/// </summary>
		[JsonProperty("trde_wght")]
		public decimal? TradeWeight;
	}

	public record KiwoomStockInfoGetTradeOriginMomentTradeVolumes
	{
		/// <summary>
		/// 거래원순간거래량 리스트
		/// </summary>
		[JsonProperty("trde_ori_mont_trde_qty")]
		public IEnumerable<KiwoomStockInfoGetTradeOriginMomentTradeVolumeItem>? Items;
	}
	public record KiwoomStockInfoGetTradeOriginMomentTradeVolumeItem
	{
		/// <summary>
		/// 시간
		/// </summary>
		[JsonProperty("tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? Time;
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
		/// 거래원명
		/// </summary>
		[JsonProperty("trde_ori_nm")]
		public string? TradeOriginName;
		/// <summary>
		/// 구분
		/// </summary>
		[JsonProperty("tp")]
		public string? Type;
		/// <summary>
		/// 순간거래량
		/// </summary>
		[JsonProperty("mont_trde_qty")]
		public decimal? MomentTradeQuantity;
		/// <summary>
		/// 누적순매수
		/// </summary>
		[JsonProperty("acc_netprps")]
		public decimal? AccumulatedNetPurchase;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? PreviousDifferenceSymbol;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
	}

	public record KiwoomStockInfoGetMotionStocks
	{
		/// <summary>
		/// 발동종목 리스트
		/// </summary>
		[JsonProperty("motn_stk")]
		public IEnumerable<KiwoomStockInfoGetMotionStockItem>? Items;
	}
	public record KiwoomStockInfoGetMotionStockItem
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
		/// 누적거래량
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? AccumulatedTradeQuantity;
		/// <summary>
		/// 발동가격
		/// </summary>
		[JsonProperty("motn_pric")]
		public decimal? MotionPrice;
		/// <summary>
		/// 동적괴리율
		/// </summary>
		[JsonProperty("dynm_dispty_rt")]
		public decimal? DynamicDisparityRate;
		/// <summary>
		/// 매매체결처리시각
		/// </summary>
		[JsonProperty("trde_cntr_proc_time")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? TradeContractProcessTime;
		/// <summary>
		/// VI해제시각
		/// </summary>
		[JsonProperty("virelis_time")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? ViReleaseTime;
		/// <summary>
		/// VI적용구분
		/// </summary>
		[JsonProperty("viaplc_tp")]
		public string? ViApplyType;
		/// <summary>
		/// 동적기준가격
		/// </summary>
		[JsonProperty("dynm_stdpc")]
		public decimal? DynamicStandardPrice;
		/// <summary>
		/// 정적기준가격
		/// </summary>
		[JsonProperty("static_stdpc")]
		public decimal? StaticStandardPrice;
		/// <summary>
		/// 정적괴리율
		/// </summary>
		[JsonProperty("static_dispty_rt")]
		public decimal? StaticDisparityRate;
		/// <summary>
		/// 시가대비등락률
		/// </summary>
		[JsonProperty("open_pric_pre_flu_rt")]
		public decimal? OpenPriceComparedFluctuationRate;
		/// <summary>
		/// VI발동횟수
		/// </summary>
		[JsonProperty("vimotn_cnt")]
		public decimal? ViMotionCount;
		/// <summary>
		/// 거래소구분
		/// </summary>
		[JsonProperty("stex_tp")]
		public string? ExchangeType;
	}

	public record KiwoomStockInfoGetTodayPreviousTradeQuantities
	{
		/// <summary>
		/// 당일전일체결량 리스트
		/// </summary>
		[JsonProperty("tdy_pred_cntr_qty")]
		public IEnumerable<KiwoomStockInfoGetTodayPreviousTradeQuantityItem>? Items;
	}
	public record KiwoomStockInfoGetTodayPreviousTradeQuantityItem
	{
		/// <summary>
		/// 체결시간
		/// </summary>
		[JsonProperty("cntr_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? TradeTime;
		/// <summary>
		/// 체결가
		/// </summary>
		[JsonProperty("cntr_pric")]
		public decimal? TradePrice;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? PreviousDifferenceSymbol;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		/// <summary>
		/// 체결량
		/// </summary>
		[JsonProperty("cntr_qty")]
		public decimal? TradeQuantity;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? AccumulatedTradeQuantity;
		/// <summary>
		/// 누적거래대금
		/// </summary>
		[JsonProperty("acc_trde_prica")]
		public decimal? AccumulatedTradeAmount;
	}

	public record KiwoomStockInfoGetInvestorDailyTradeStocks
	{
		/// <summary>
		/// 투자자별일별매매종목 리스트
		/// </summary>
		[JsonProperty("invsr_daly_trde_stk")]
		public IEnumerable<KiwoomStockInfoGetInvestorDailyTradeStockItem>? Items;
	}
	public record KiwoomStockInfoGetInvestorDailyTradeStockItem
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
		/// 순매도수량
		/// </summary>
		[JsonProperty("netslmt_qty")]
		public decimal? NetSellQuantity;
		/// <summary>
		/// 순매도금액
		/// </summary>
		[JsonProperty("netslmt_amt")]
		public decimal? NetSellAmount;
		/// <summary>
		/// 추정평균가
		/// </summary>
		[JsonProperty("prsm_avg_pric")]
		public decimal? EstimatedAveragePrice;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		/// <summary>
		/// 대비기호
		/// </summary>
		[JsonProperty("pre_sig")]
		public string? DifferenceSymbol;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		/// <summary>
		/// 평균가대비
		/// </summary>
		[JsonProperty("avg_pric_pre")]
		public KiwoomDecimal? AveragePriceDifference;
		/// <summary>
		/// 대비율
		/// </summary>
		[JsonProperty("pre_rt")]
		public decimal? DifferenceRate;
		/// <summary>
		/// 기간거래량
		/// </summary>
		[JsonProperty("dt_trde_qty")]
		public decimal? PeriodTradeQuantity;
	}

	public record KiwoomStockInfoGetStockInvestorInstitutions
	{
		/// <summary>
		/// 종목별투자자기관별 리스트
		/// </summary>
		[JsonProperty("stk_invsr_orgn")]
		public IEnumerable<KiwoomStockInfoGetStockInvestorInstitutionItem>? Items;
	}
	public record KiwoomStockInfoGetStockInvestorInstitutionItem
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
		public string? DifferenceSymbol;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		/// <summary>
		/// 등락율 (우측 2자리 소수점자리수)
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? AccumulatedTradeQuantity;
		/// <summary>
		/// 누적거래대금
		/// </summary>
		[JsonProperty("acc_trde_prica")]
		public decimal? AccumulatedTradeAmount;
		/// <summary>
		/// 개인투자자
		/// </summary>
		[JsonProperty("ind_invsr")]
		public string? IndividualInvestor;
		/// <summary>
		/// 외국인투자자
		/// </summary>
		[JsonProperty("frgnr_invsr")]
		public string? ForeignInvestor;
		/// <summary>
		/// 기관계
		/// </summary>
		[JsonProperty("orgn")]
		public string? Institution;
		/// <summary>
		/// 금융투자
		/// </summary>
		[JsonProperty("fnnc_invt")]
		public string? FinancialInvestment;
		/// <summary>
		/// 보험
		/// </summary>
		[JsonProperty("insrnc")]
		public string? Insurance;
		/// <summary>
		/// 투신
		/// </summary>
		[JsonProperty("invtrt")]
		public string? InvestmentTrust;
		/// <summary>
		/// 기타금융
		/// </summary>
		[JsonProperty("etc_fnnc")]
		public string? OtherFinancial;
		/// <summary>
		/// 은행
		/// </summary>
		[JsonProperty("bank")]
		public string? Bank;
		/// <summary>
		/// 연기금등
		/// </summary>
		[JsonProperty("penfnd_etc")]
		public string? PensionEtc;
		/// <summary>
		/// 사모펀드
		/// </summary>
		[JsonProperty("samo_fund")]
		public string? PrivateFund;
		/// <summary>
		/// 국가
		/// </summary>
		[JsonProperty("natn")]
		public string? Nation;
		/// <summary>
		/// 기타법인
		/// </summary>
		[JsonProperty("etc_corp")]
		public string? OtherCorporation;
		/// <summary>
		/// 내외국인
		/// </summary>
		[JsonProperty("natfor")]
		public string? DomesticAndForeign;
	}

	public record KiwoomStockInfoGetStockInvestorInstitutionTotals
	{
		/// <summary>
		/// 종목별투자자기관별합계 리스트
		/// </summary>
		[JsonProperty("stk_invsr_orgn_tot")]
		public IEnumerable<KiwoomStockInfoGetStockInvestorInstitutionTotalItem>? Items;
	}
	public record KiwoomStockInfoGetStockInvestorInstitutionTotalItem
	{
		/// <summary>
		/// 개인투자자
		/// </summary>
		[JsonProperty("ind_invsr")]
		public KiwoomDecimal? IndividualInvestors;
		/// <summary>
		/// 외국인투자자
		/// </summary>
		[JsonProperty("frgnr_invsr")]
		public KiwoomDecimal? ForeignInvestors;
		/// <summary>
		/// 기관계
		/// </summary>
		[JsonProperty("orgn")]
		public KiwoomDecimal? Institutions;
		/// <summary>
		/// 금융투자
		/// </summary>
		[JsonProperty("fnnc_invt")]
		public decimal? FinancialInvestments;
		/// <summary>
		/// 보험
		/// </summary>
		[JsonProperty("insrnc")]
		public KiwoomDecimal? Insurances;
		/// <summary>
		/// 투신
		/// </summary>
		[JsonProperty("invtrt")]
		public KiwoomDecimal? InvestmentTrusts;
		/// <summary>
		/// 기타금융
		/// </summary>
		[JsonProperty("etc_fnnc")]
		public KiwoomDecimal? OtherFinancials;
		/// <summary>
		/// 은행
		/// </summary>
		[JsonProperty("bank")]
		public KiwoomDecimal? Banks;
		/// <summary>
		/// 연기금등
		/// </summary>
		[JsonProperty("penfnd_etc")]
		public decimal? PensionEtcs;
		/// <summary>
		/// 사모펀드
		/// </summary>
		[JsonProperty("samo_fund")]
		public KiwoomDecimal? PrivateFunds;
		/// <summary>
		/// 국가
		/// </summary>
		[JsonProperty("natn")]
		public decimal? Nations;
		/// <summary>
		/// 기타법인
		/// </summary>
		[JsonProperty("etc_corp")]
		public decimal? OtherCorporations;
		/// <summary>
		/// 내외국인
		/// </summary>
		[JsonProperty("natfor")]
		public decimal? DomesticAndForeign;
	}

	public record KiwoomStockInfoGetTodayPreviousContracts
	{
		/// <summary>
		/// 당일전일체결 리스트
		/// </summary>
		[JsonProperty("tdy_pred_cntr")]
		public IEnumerable<KiwoomStockInfoGetTodayPreviousContractItem>? Items;
	}
	public record KiwoomStockInfoGetTodayPreviousContractItem
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
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		/// <summary>
		/// 대비율
		/// </summary>
		[JsonProperty("pre_rt")]
		public decimal? DifferenceRate;
		/// <summary>
		/// 우선매도호가단위
		/// </summary>
		[JsonProperty("pri_sel_bid_unit")]
		public decimal? PrioritySellBidUnit;
		/// <summary>
		/// 우선매수호가단위
		/// </summary>
		[JsonProperty("pri_buy_bid_unit")]
		public decimal? PriorityBuyBidUnit;
		/// <summary>
		/// 체결거래량
		/// </summary>
		[JsonProperty("cntr_trde_qty")]
		public decimal? ContractTradeQuantity;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("sign")]
		public string? PreviousDifferenceSymbol;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? AccumulatedTradeQuantity;
		/// <summary>
		/// 누적거래대금
		/// </summary>
		[JsonProperty("acc_trde_prica")]
		public decimal? AccumulatedTradeAmount;
		/// <summary>
		/// 체결강도
		/// </summary>
		[JsonProperty("cntr_str")]
		public decimal? ContractStrength;
		/// <summary>
		/// 거래소구분 - KRX, NXT, 통합
		/// </summary>
		[JsonProperty("stex_tp")]
		public string? ExchangeType;
	}

	public record KiwoomStockInfoGetAttentionStocks
	{
		/// <summary>
		/// 관심종목정보 리스트
		/// </summary>
		[JsonProperty("atn_stk_infr")]
		public IEnumerable<KiwoomStockInfoGetAttentionStockItem>? Items;
	}
	public record KiwoomStockInfoGetAttentionStockItem
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
		/// 기준가
		/// </summary>
		[JsonProperty("base_pric")]
		public decimal? BasePrice;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? PreviousDifferenceSymbol;
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
		/// 거래대금
		/// </summary>
		[JsonProperty("trde_prica")]
		public decimal? TradeAmount;
		/// <summary>
		/// 체결량
		/// </summary>
		[JsonProperty("cntr_qty")]
		public decimal? ContractQuantity;
		/// <summary>
		/// 체결강도
		/// </summary>
		[JsonProperty("cntr_str")]
		public decimal? ContractStrength;
		/// <summary>
		/// 전일거래량대비
		/// </summary>
		[JsonProperty("pred_trde_qty_pre")]
		public decimal? PreviousTradeQuantityDifference;
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
		/// 매도1차호가
		/// </summary>
		[JsonProperty("sel_1th_bid")]
		public decimal? SellFirstBid;
		/// <summary>
		/// 매도2차호가
		/// </summary>
		[JsonProperty("sel_2th_bid")]
		public decimal? SellSecondBid;
		/// <summary>
		/// 매도3차호가
		/// </summary>
		[JsonProperty("sel_3th_bid")]
		public decimal? SellThirdBid;
		/// <summary>
		/// 매도4차호가
		/// </summary>
		[JsonProperty("sel_4th_bid")]
		public decimal? SellFourthBid;
		/// <summary>
		/// 매도5차호가
		/// </summary>
		[JsonProperty("sel_5th_bid")]
		public decimal? SellFifthBid;
		/// <summary>
		/// 매수1차호가
		/// </summary>
		[JsonProperty("buy_1th_bid")]
		public decimal? BuyFirstBid;
		/// <summary>
		/// 매수2차호가
		/// </summary>
		[JsonProperty("buy_2th_bid")]
		public decimal? BuySecondBid;
		/// <summary>
		/// 매수3차호가
		/// </summary>
		[JsonProperty("buy_3th_bid")]
		public decimal? BuyThirdBid;
		/// <summary>
		/// 매수4차호가
		/// </summary>
		[JsonProperty("buy_4th_bid")]
		public decimal? BuyFourthBid;
		/// <summary>
		/// 매수5차호가
		/// </summary>
		[JsonProperty("buy_5th_bid")]
		public decimal? BuyFifthBid;
		/// <summary>
		/// 상한가
		/// </summary>
		[JsonProperty("upl_pric")]
		public decimal? UpperPriceLimit;
		/// <summary>
		/// 하한가
		/// </summary>
		[JsonProperty("lst_pric")]
		public decimal? LowerPriceLimit;
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
		/// 체결시간
		/// </summary>
		[JsonProperty("cntr_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? ContractTime;
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
		/// 자본금
		/// </summary>
		[JsonProperty("cap")]
		public decimal? Capital;
		/// <summary>
		/// 액면가
		/// </summary>
		[JsonProperty("fav")]
		public decimal? FaceValue;
		/// <summary>
		/// 시가총액
		/// </summary>
		[JsonProperty("mac")]
		public decimal? MarketCapitalization;
		/// <summary>
		/// 주식수
		/// </summary>
		[JsonProperty("stkcnt")]
		public decimal? StockCount;
		/// <summary>
		/// 호가시간
		/// </summary>
		[JsonProperty("bid_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? BidTime;
		/// <summary>
		/// 일자
		/// </summary>
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		/// <summary>
		/// 우선매도잔량
		/// </summary>
		[JsonProperty("pri_sel_req")]
		public decimal? PrioritySellRequest;
		/// <summary>
		/// 우선매수잔량
		/// </summary>
		[JsonProperty("pri_buy_req")]
		public decimal? PriorityBuyRequest;
		/// <summary>
		/// 우선매도건수
		/// </summary>
		[JsonProperty("pri_sel_cnt")]
		public decimal? PrioritySellCount;
		/// <summary>
		/// 우선매수건수
		/// </summary>
		[JsonProperty("pri_buy_cnt")]
		public decimal? PriorityBuyCount;
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
		/// 총매도건수
		/// </summary>
		[JsonProperty("tot_sel_cnt")]
		public decimal? TotalSellCount;
		/// <summary>
		/// 총매수건수
		/// </summary>
		[JsonProperty("tot_buy_cnt")]
		public decimal? TotalBuyCount;
		/// <summary>
		/// 패리티
		/// </summary>
		[JsonProperty("prty")]
		public decimal? Parity;
		/// <summary>
		/// 기어링
		/// </summary>
		[JsonProperty("gear")]
		public decimal? Gearing;
		/// <summary>
		/// 손익분기
		/// </summary>
		[JsonProperty("pl_qutr")]
		public decimal? BreakEvenPoint;
		/// <summary>
		/// 자본지지
		/// </summary>
		[JsonProperty("cap_support")]
		public decimal? CapitalSupport;
		/// <summary>
		/// ELW행사가
		/// </summary>
		[JsonProperty("elwexec_pric")]
		public decimal? ELWExercisePrice;
		/// <summary>
		/// 전환비율
		/// </summary>
		[JsonProperty("cnvt_rt")]
		public decimal? ConversionRate;
		/// <summary>
		/// ELW만기일
		/// </summary>
		[JsonProperty("elwexpr_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? ELWExpirationDate;
		/// <summary>
		/// 미결제약정
		/// </summary>
		[JsonProperty("cntr_engg")]
		public decimal? OutstandingContracts;
		/// <summary>
		/// 미결제전일대비
		/// </summary>
		[JsonProperty("cntr_pred_pre")]
		public decimal? OutstandingPreviousDifference;
		/// <summary>
		/// 이론가
		/// </summary>
		[JsonProperty("theory_pric")]
		public decimal? TheoreticalPrice;
		/// <summary>
		/// 내재변동성
		/// </summary>
		[JsonProperty("innr_vltl")]
		public decimal? ImpliedVolatility;
		/// <summary>
		/// 델타
		/// </summary>
		[JsonProperty("delta")]
		public decimal? Delta;
		/// <summary>
		/// 감마
		/// </summary>
		[JsonProperty("gam")]
		public decimal? Gamma;
		/// <summary>
		/// 쎄타
		/// </summary>
		[JsonProperty("theta")]
		public decimal? Theta;
		/// <summary>
		/// 베가
		/// </summary>
		[JsonProperty("vega")]
		public decimal? Vega;
		/// <summary>
		/// 로
		/// </summary>
		[JsonProperty("law")]
		public decimal? Law;
	}

	public record KiwoomStockInfoGetLists
	{
		/// <summary>
		/// 종목리스트
		/// </summary>
		[JsonProperty("list")]
		public IEnumerable<KiwoomStockInfoGetListItem>? Items;
	}
	public record KiwoomStockInfoGetListItem
	{
		/// <summary>
		/// 종목코드 (단축코드)
		/// </summary>
		[JsonProperty("code")]
		public string? StockCode;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("name")]
		public string? StockName;
		/// <summary>
		/// 상장주식수
		/// </summary>
		[JsonProperty("listCount")]
		public decimal? ListedShareCount;
		/// <summary>
		/// 감리구분
		/// </summary>
		[JsonProperty("auditInfo")]
		public string? AuditInfo;
		/// <summary>
		/// 상장일
		/// </summary>
		[JsonProperty("regDay")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? ListingDate;
		/// <summary>
		/// 전일종가
		/// </summary>
		[JsonProperty("lastPrice")]
		public decimal? PreviousClosePrice;
		/// <summary>
		/// 종목상태
		/// </summary>
		[JsonProperty("state")]
		public string? StockState;
		/// <summary>
		/// 시장구분코드
		/// </summary>
		[JsonProperty("marketCode")]
		public string? MarketCode;
		/// <summary>
		/// 시장명
		/// </summary>
		[JsonProperty("marketName")]
		public string? MarketName;
		/// <summary>
		/// 업종명
		/// </summary>
		[JsonProperty("upName")]
		public string? IndustryName;
		/// <summary>
		/// 회사크기분류
		/// </summary>
		[JsonProperty("upSizeName")]
		public string? CompanySizeCategory;
		/// <summary>
		/// 회사분류 (코스닥만 존재함)
		/// </summary>
		[JsonProperty("companyClassName")]
		public string? CompanyClassName;
		/// <summary>
		/// 투자유의종목여부 (0: 해당없음, 2: 정리매매, 3: 단기과열, 4: 투자위험, 5: 투자경과, 1: ETF투자주의요망(ETF인 경우만 전달))
		/// </summary>
		[JsonProperty("orderWarning")]
		public string? OrderWarningFlag;
		/// <summary>
		/// NXT가능여부 (Y: 가능)
		/// </summary>
		[JsonProperty("nxtEnable")]
		public string? NxtEnabled;
	}

	public record KiwoomStockInfoGetMarketCodes
	{
		/// <summary>
		/// 업종코드리스트
		/// </summary>
		[JsonProperty("marketCode")]
		public IEnumerable<KiwoomStockInfoGetMarketCodeItem>? Items;
	}
	public record KiwoomStockInfoGetMarketCodeItem
	{
		/// <summary>
		/// 코드
		/// </summary>
		[JsonProperty("code")]
		public string? Code;
		/// <summary>
		/// 업종명
		/// </summary>
		[JsonProperty("name")]
		public string? IndustryName;
		/// <summary>
		/// 그룹
		/// </summary>
		[JsonProperty("group")]
		public string? Group;
	}

	public record KiwoomStockInfoGetMemberCodes
	{
		/// <summary>
		/// 회원사코드리스트
		/// </summary>
		[JsonProperty("list")]
		public IEnumerable<KiwoomStockInfoGetMemberCodeItem>? Items;
	}
	public record KiwoomStockInfoGetMemberCodeItem
	{
		/// <summary>
		/// 코드
		/// </summary>
		[JsonProperty("code")]
		public string? Code;
		/// <summary>
		/// 업종명
		/// </summary>
		[JsonProperty("name")]
		public string? IndustryName;
		/// <summary>
		/// 구분
		/// </summary>
		[JsonProperty("gb")]
		public string? Category;
	}

	public record KiwoomStockInfoGetProgramNetPurchaseUpper50
	{
		/// <summary>
		/// 프로그램순매수상위50 리스트
		/// </summary>
		[JsonProperty("prm_netprps_upper_50")]
		public IEnumerable<KiwoomStockInfoGetProgramNetPurchaseUpper50Item>? Items;
	}
	public record KiwoomStockInfoGetProgramNetPurchaseUpper50Item
	{
		/// <summary>
		/// 순위
		/// </summary>
		[JsonProperty("rank")]
		public int? Rank;
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
		/// 등락기호
		/// </summary>
		[JsonProperty("flu_sig")]
		public string? FluctuationSymbol;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
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
		public decimal? ProgramNetPurchaseAmount;
	}

	public record KiwoomStockInfoGetProgramTradeStatus
	{
		/// <summary>
		/// 매수체결수량합계
		/// </summary>
		[JsonProperty("tot_1")]
		public decimal? TotalBuyContractQuantity;
		/// <summary>
		/// 매수체결금액합계
		/// </summary>
		[JsonProperty("tot_2")]
		public decimal? TotalBuyContractAmount;
		/// <summary>
		/// 매도체결수량합계
		/// </summary>
		[JsonProperty("tot_3")]
		public decimal? TotalSellContractQuantity;
		/// <summary>
		/// 매도체결금액합계
		/// </summary>
		[JsonProperty("tot_4")]
		public decimal? TotalSellContractAmount;
		/// <summary>
		/// 순매수대금합계
		/// </summary>
		[JsonProperty("tot_5")]
		public decimal? TotalNetBuyAmount;
		/// <summary>
		/// 합계6
		/// </summary>
		[JsonProperty("tot_6")]
		public decimal? Total6;
		/// <summary>
		/// 종목별프로그램매매현황 리스트
		/// </summary>
		[JsonProperty("stk_prm_trde_prst")]
		public IEnumerable<KiwoomStockInfoGetStockProgramTradeStatusItem>? Items;
	}
	public record KiwoomStockInfoGetStockProgramTradeStatusItem
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
		/// 등락기호
		/// </summary>
		[JsonProperty("flu_sig")]
		public string? FluctuationSymbol;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		/// <summary>
		/// 매수체결수량
		/// </summary>
		[JsonProperty("buy_cntr_qty")]
		public decimal? BuyContractQuantity;
		/// <summary>
		/// 매수체결금액
		/// </summary>
		[JsonProperty("buy_cntr_amt")]
		public decimal? BuyContractAmount;
		/// <summary>
		/// 매도체결수량
		/// </summary>
		[JsonProperty("sel_cntr_qty")]
		public decimal? SellContractQuantity;
		/// <summary>
		/// 매도체결금액
		/// </summary>
		[JsonProperty("sel_cntr_amt")]
		public decimal? SellContractAmount;
		/// <summary>
		/// 순매수대금
		/// </summary>
		[JsonProperty("netprps_prica")]
		public decimal? NetBuyAmount;
		/// <summary>
		/// 전체거래비율
		/// </summary>
		[JsonProperty("all_trde_rt")]
		public decimal? TotalTradeRate;
	}

	public record KiwoomStockInfoGetCreditLoanPossibleStocks
	{
		/// <summary>
		/// 신용융자가능여부
		/// </summary>
		[JsonProperty("crd_loan_able")]
		public string? CreditLoanable;
		/// <summary>
		/// 신용융자가능종목 리스트
		/// </summary>
		[JsonProperty("crd_loan_pos_stk")]
		public IEnumerable<KiwoomStockInfoGetCreditLoanPossibleStockItem>? Items;
	}
	public record KiwoomStockInfoGetCreditLoanPossibleStockItem
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
		/// 신용보증금율
		/// </summary>
		[JsonProperty("crd_assr_rt")]
		public decimal? CreditAssuranceRate;
		/// <summary>
		/// 대용가
		/// </summary>
		[JsonProperty("repl_pric")]
		public decimal? ReplacementPrice;
		/// <summary>
		/// 전일종가
		/// </summary>
		[JsonProperty("pred_close_pric")]
		public decimal? PreviousClosePrice;
		/// <summary>
		/// 신용한도초과여부
		/// </summary>
		[JsonProperty("crd_limit_over_yn")]
		public string? CreditLimitOverFlag;
		/// <summary>
		/// 신용한도초과 - N:공란,Y:회사한도 초과
		/// </summary>
		[JsonProperty("crd_limit_over_txt")]
		public string? CreditLimitOverText;
	}

	public record KiwoomStockInfoGetCreditAllowYn
	{
		/// <summary>
		/// 신용가능여부
		/// </summary>
		[JsonProperty("crd_alow_yn")]
		public string? CreditAllowYn;
	}
}
