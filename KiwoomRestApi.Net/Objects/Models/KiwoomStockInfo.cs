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
		public string? PreviousPrice;
		/// <summary>
		/// 기준가 대비 부호
		/// </summary>
		[JsonProperty("base_comp_sign")]
		public string? BaseChangeSign;
		/// <summary>
		/// 기준가 대비 등락율
		/// </summary>
		[JsonProperty("base_comp_chgr")]
		public string? BaseChangeRate;
		/// <summary>
		/// 직전 기준 대비 부호
		/// </summary>
		[JsonProperty("prev_base_sign")]
		public string? ChangeSign;
		/// <summary>
		/// 직전 기준 대비 등락율
		/// </summary>
		[JsonProperty("prev_base_chgr")]
		public string? ChangeRate;
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
		public decimal? ParValue;
		/// <summary>
		/// 자본금
		/// </summary>
		[JsonProperty("cap")]
		public decimal? Capital;
		/// <summary>
		/// 상장주식
		/// </summary>
		[JsonProperty("flo_stk")]
		public decimal? ListedQuantity;
		/// <summary>
		/// 신용비율
		/// </summary>
		[JsonProperty("crd_rt")]
		public decimal? CreditRate;
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
		public decimal? MarketCapitalization;
		/// <summary>
		/// 시가총액비중
		/// </summary>
		[JsonProperty("mac_wght")]
		public decimal? MarketCapitalizationWeight;
		/// <summary>
		/// 외인소진률
		/// </summary>
		[JsonProperty("for_exh_rt")]
		public decimal? ForeignUsageRate;
		/// <summary>
		/// 대용가
		/// </summary>
		[JsonProperty("repl_pric")]
		public decimal? SubstitutePrice;
		/// <summary>
		/// PER [ 주의 ] PER, ROE 값들은 외부벤더사에서 제공되는 데이터이며 일주일에 한번 또는 실적발표 시즌에 업데이트 됨
		/// </summary>
		[JsonProperty("per")]
		public decimal? Per;
		/// <summary>
		/// EPS
		/// </summary>
		[JsonProperty("eps")]
		public decimal? Eps;
		/// <summary>
		/// ROE [ 주의 ] PER, ROE 값들은 외부벤더사에서 제공되는 데이터이며 일주일에 한번 또는 실적발표 시즌에 업데이트 됨
		/// </summary>
		[JsonProperty("roe")]
		public decimal? Roe;
		/// <summary>
		/// PBR
		/// </summary>
		[JsonProperty("pbr")]
		public decimal? Pbr;
		/// <summary>
		/// EV
		/// </summary>
		[JsonProperty("ev")]
		public decimal? Ev;
		/// <summary>
		/// BPS
		/// </summary>
		[JsonProperty("bps")]
		public decimal? Bps;
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
		public decimal? High;
		/// <summary>
		/// 시가
		/// </summary>
		[JsonProperty("open_pric")]
		public decimal? Open;
		/// <summary>
		/// 저가
		/// </summary>
		[JsonProperty("low_pric")]
		public decimal? Low;
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
		/// 기준가
		/// </summary>
		[JsonProperty("base_pric")]
		public decimal? BasePrice;
		/// <summary>
		/// 예상체결가
		/// </summary>
		[JsonProperty("exp_cntr_pric")]
		public decimal? ExpectedTradePrice;
		/// <summary>
		/// 예상체결수량
		/// </summary>
		[JsonProperty("exp_cntr_qty")]
		public decimal? ExpectedTradeQuantity;
		/// <summary>
		/// 250최고가일
		/// </summary>
		[JsonProperty("250hgst_pric_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? High250Date;
		/// <summary>
		/// 250최고가대비율
		/// </summary>
		[JsonProperty("250hgst_pric_pre_rt")]
		public decimal? High250ChangeRate;
		/// <summary>
		/// 250최저가일
		/// </summary>
		[JsonProperty("250lwst_pric_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Low250Date;
		/// <summary>
		/// 250최저가대비율
		/// </summary>
		[JsonProperty("250lwst_pric_pre_rt")]
		public decimal? Low250ChangeRate;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		/// <summary>
		/// 대비기호
		/// </summary>
		[JsonProperty("pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? Change;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? ChangeRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 거래대비
		/// </summary>
		[JsonProperty("trde_pre")]
		public decimal? TransactionChange;
		/// <summary>
		/// 액면가단위
		/// </summary>
		[JsonProperty("fav_unit")]
		public string? ParValueUnit;
		/// <summary>
		/// 유통주식
		/// </summary>
		[JsonProperty("dstr_stk")]
		public decimal? OutstandingShares;
		/// <summary>
		/// 유통비율
		/// </summary>
		[JsonProperty("dstr_rt")]
		public decimal? OutstandingRate;
	}

	public record KiwoomStockInfoGetBrokerInfo
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
		public string? ChangeSign;
		/// <summary>
		/// 기준가
		/// </summary>
		[JsonProperty("base_pric")]
		public decimal? BasePrice;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? Change;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? ChangeRate;
		/// <summary>
		/// 매도거래원명1
		/// </summary>
		[JsonProperty("sel_trde_ori_nm_1")]
		public string? SellBrokerName1;
		/// <summary>
		/// 매도거래원1
		/// </summary>
		[JsonProperty("sel_trde_ori_1")]
		public string? SellBroker1;
		/// <summary>
		/// 매도거래량1
		/// </summary>
		[JsonProperty("sel_trde_qty_1")]
		public decimal? SellBrokerVolume1;
		/// <summary>
		/// 매수거래원명1
		/// </summary>
		[JsonProperty("buy_trde_ori_nm_1")]
		public string? BuyBrokerName1;
		/// <summary>
		/// 매수거래원1
		/// </summary>
		[JsonProperty("buy_trde_ori_1")]
		public string? BuyBroker1;
		/// <summary>
		/// 매수거래량1
		/// </summary>
		[JsonProperty("buy_trde_qty_1")]
		public decimal? BuyBrokerVolume1;
		/// <summary>
		/// 매도거래원명2
		/// </summary>
		[JsonProperty("sel_trde_ori_nm_2")]
		public string? SellBrokerName2;
		/// <summary>
		/// 매도거래원2
		/// </summary>
		[JsonProperty("sel_trde_ori_2")]
		public string? SellBroker2;
		/// <summary>
		/// 매도거래량2
		/// </summary>
		[JsonProperty("sel_trde_qty_2")]
		public decimal? SellBrokerVolume2;
		/// <summary>
		/// 매수거래원명2
		/// </summary>
		[JsonProperty("buy_trde_ori_nm_2")]
		public string? BuyBrokerName2;
		/// <summary>
		/// 매수거래원2
		/// </summary>
		[JsonProperty("buy_trde_ori_2")]
		public string? BuyBroker2;
		/// <summary>
		/// 매수거래량2
		/// </summary>
		[JsonProperty("buy_trde_qty_2")]
		public decimal? BuyBrokerVolume2;
		/// <summary>
		/// 매도거래원명3
		/// </summary>
		[JsonProperty("sel_trde_ori_nm_3")]
		public string? SellBrokerName3;
		/// <summary>
		/// 매도거래원3
		/// </summary>
		[JsonProperty("sel_trde_ori_3")]
		public string? SellBroker3;
		/// <summary>
		/// 매도거래량3
		/// </summary>
		[JsonProperty("sel_trde_qty_3")]
		public decimal? SellBrokerVolume3;
		/// <summary>
		/// 매수거래원명3
		/// </summary>
		[JsonProperty("buy_trde_ori_nm_3")]
		public string? BuyBrokerName3;
		/// <summary>
		/// 매수거래원3
		/// </summary>
		[JsonProperty("buy_trde_ori_3")]
		public string? BuyBroker3;
		/// <summary>
		/// 매수거래량3
		/// </summary>
		[JsonProperty("buy_trde_qty_3")]
		public decimal? BuyBrokerVolume3;
		/// <summary>
		/// 매도거래원명4
		/// </summary>
		[JsonProperty("sel_trde_ori_nm_4")]
		public string? SellBrokerName4;
		/// <summary>
		/// 매도거래원4
		/// </summary>
		[JsonProperty("sel_trde_ori_4")]
		public string? SellBroker4;
		/// <summary>
		/// 매도거래량4
		/// </summary>
		[JsonProperty("sel_trde_qty_4")]
		public decimal? SellBrokerVolume4;
		/// <summary>
		/// 매수거래원명4
		/// </summary>
		[JsonProperty("buy_trde_ori_nm_4")]
		public string? BuyBrokerName4;
		/// <summary>
		/// 매수거래원4
		/// </summary>
		[JsonProperty("buy_trde_ori_4")]
		public string? BuyBroker4;
		/// <summary>
		/// 매수거래량4
		/// </summary>
		[JsonProperty("buy_trde_qty_4")]
		public decimal? BuyBrokerVolume4;
		/// <summary>
		/// 매도거래원명5
		/// </summary>
		[JsonProperty("sel_trde_ori_nm_5")]
		public string? SellBrokerName5;
		/// <summary>
		/// 매도거래원5
		/// </summary>
		[JsonProperty("sel_trde_ori_5")]
		public string? SellBroker5;
		/// <summary>
		/// 매도거래량5
		/// </summary>
		[JsonProperty("sel_trde_qty_5")]
		public decimal? SellBrokerVolume5;
		/// <summary>
		/// 매수거래원명5
		/// </summary>
		[JsonProperty("buy_trde_ori_nm_5")]
		public string? BuyBrokerName5;
		/// <summary>
		/// 매수거래원5
		/// </summary>
		[JsonProperty("buy_trde_ori_5")]
		public string? BuyBroker5;
		/// <summary>
		/// 매수거래량5
		/// </summary>
		[JsonProperty("buy_trde_qty_5")]
		public decimal? BuyBrokerVolume5;
	}

	public record KiwoomStockInfoGetTrades
	{
		/// <summary>
		/// 체결정보 리스트
		/// </summary>
		[JsonProperty("cntr_infr")]
		public IEnumerable<KiwoomStockInfoGetTradeItem>? Items;
	}
	public record KiwoomStockInfoGetTradeItem
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
		public decimal? Change;
		/// <summary>
		/// 대비율
		/// </summary>
		[JsonProperty("pre_rt")]
		public decimal? ChangeRate;
		/// <summary>
		/// 우선매도호가단위
		/// </summary>
		[JsonProperty("pri_sel_bid_unit")]
		public decimal? BestSellQuoteUnit;
		/// <summary>
		/// 우선매수호가단위
		/// </summary>
		[JsonProperty("pri_buy_bid_unit")]
		public decimal? BestBuyQuoteUnit;
		/// <summary>
		/// 체결거래량
		/// </summary>
		[JsonProperty("cntr_trde_qty")]
		public decimal? TradeVolume;
		/// <summary>
		/// sign
		/// </summary>
		[JsonProperty("sign")]
		public string? Sign;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? AccumulatedVolume;
		/// <summary>
		/// 누적거래대금
		/// </summary>
		[JsonProperty("acc_trde_prica")]
		public decimal? AccumulatedTransactionAmount;
		/// <summary>
		/// 체결강도
		/// </summary>
		[JsonProperty("cntr_str")]
		public decimal? TradeMomentum;
		/// <summary>
		/// 거래소구분 - KRX, NXT, 통합
		/// </summary>
		[JsonProperty("stex_tp")]
		public string? ExchangeType;
	}

	public record KiwoomStockInfoGetCreditTransactionTrends
	{
		/// <summary>
		/// 신용매매동향 리스트
		/// </summary>
		[JsonProperty("crd_trde_trend")]
		public IEnumerable<KiwoomStockInfoGetCreditTransactionTrendItem>? Items;
	}
	public record KiwoomStockInfoGetCreditTransactionTrendItem
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
		public decimal? Volume;
		/// <summary>
		/// 신규
		/// </summary>
		[JsonProperty("new")]
		public decimal? New;
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
		public decimal? Change;
		/// <summary>
		/// 공여율
		/// </summary>
		[JsonProperty("shr_rt")]
		public decimal? ContributionRate;
		/// <summary>
		/// 잔고율
		/// </summary>
		[JsonProperty("remn_rt")]
		public decimal? BalanceRate;
	}

	public record KiwoomStockInfoGetDailyTransactionDetails
	{
		/// <summary>
		/// 일별거래상세 리스트
		/// </summary>
		[JsonProperty("daly_trde_dtl")]
		public IEnumerable<KiwoomStockInfoGetDailyTransactionDetailItem>? Items;
	}
	public record KiwoomStockInfoGetDailyTransactionDetailItem
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
		public decimal? Close;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? Change;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? ChangeRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 거래대금
		/// </summary>
		[JsonProperty("trde_prica")]
		public decimal? TransactionAmount;
		/// <summary>
		/// 장전거래량
		/// </summary>
		[JsonProperty("bf_mkrt_trde_qty")]
		public decimal? BeforeMarketVolume;
		/// <summary>
		/// 장전거래비중
		/// </summary>
		[JsonProperty("bf_mkrt_trde_wght")]
		public decimal? BeforeMarketTransactionWeight;
		/// <summary>
		/// 장중거래량
		/// </summary>
		[JsonProperty("opmr_trde_qty")]
		public decimal? OpenMarketVolume;
		/// <summary>
		/// 장중거래비중
		/// </summary>
		[JsonProperty("opmr_trde_wght")]
		public decimal? OpenMarketTransactionWeight;
		/// <summary>
		/// 장후거래량
		/// </summary>
		[JsonProperty("af_mkrt_trde_qty")]
		public decimal? AfterMarketVolume;
		/// <summary>
		/// 장후거래비중
		/// </summary>
		[JsonProperty("af_mkrt_trde_wght")]
		public decimal? AfterMarketTransactionWeight;
		/// <summary>
		/// 합계3
		/// </summary>
		[JsonProperty("tot_3")]
		public decimal? Total3;
		/// <summary>
		/// 기간중거래량
		/// </summary>
		[JsonProperty("prid_trde_qty")]
		public decimal? PeriodVolume;
		/// <summary>
		/// 체결강도
		/// </summary>
		[JsonProperty("cntr_str")]
		public decimal? TradeMomentum;
		/// <summary>
		/// 외인보유
		/// </summary>
		[JsonProperty("for_poss")]
		public decimal? ForeignHolding;
		/// <summary>
		/// 외인비중
		/// </summary>
		[JsonProperty("for_wght")]
		public decimal? ForeignWeight;
		/// <summary>
		/// 외인순매수
		/// </summary>
		[JsonProperty("for_netprps")]
		public decimal? ForeignNetBuy;
		/// <summary>
		/// 기관순매수
		/// </summary>
		[JsonProperty("orgn_netprps")]
		public decimal? InstitutionNetBuy;
		/// <summary>
		/// 개인순매수
		/// </summary>
		[JsonProperty("ind_netprps")]
		public decimal? RetailNetBuy;
		/// <summary>
		/// 외국계
		/// </summary>
		[JsonProperty("frgn")]
		public decimal? Foreign;
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
		public decimal? BeforeMarketTransactionAmount;
		/// <summary>
		/// 장전거래대금비중
		/// </summary>
		[JsonProperty("bf_mkrt_trde_prica_wght")]
		public decimal? BeforeMarketTransactionAmountWeight;
		/// <summary>
		/// 장중거래대금
		/// </summary>
		[JsonProperty("opmr_trde_prica")]
		public decimal? OpenMarketTransactionAmount;
		/// <summary>
		/// 장중거래대금비중
		/// </summary>
		[JsonProperty("opmr_trde_prica_wght")]
		public decimal? OpenMarketTransactionAmountWeight;
		/// <summary>
		/// 장후거래대금
		/// </summary>
		[JsonProperty("af_mkrt_trde_prica")]
		public decimal? AfterMarketTransactionAmount;
		/// <summary>
		/// 장후거래대금비중
		/// </summary>
		[JsonProperty("af_mkrt_trde_prica_wght")]
		public decimal? AfterMarketTransactionAmountWeight;
	}

	public record KiwoomStockInfoGetNewHighLows
	{
		/// <summary>
		/// 신고저가 리스트
		/// </summary>
		[JsonProperty("ntl_pric")]
		public IEnumerable<KiwoomStockInfoGetNewHighLowItem>? Items;
	}

	public record KiwoomStockInfoGetNewHighLowItem
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
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? Change;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? ChangeRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 전일거래량대비율
		/// </summary>
		[JsonProperty("pred_trde_qty_pre_rt")]
		public decimal? VolumeChangeRate;
		/// <summary>
		/// 매도호가
		/// </summary>
		[JsonProperty("sel_bid")]
		public decimal? SellQuote;
		/// <summary>
		/// 매수호가
		/// </summary>
		[JsonProperty("buy_bid")]
		public decimal? BuyQuote;
		/// <summary>
		/// 고가
		/// </summary>
		[JsonProperty("high_pric")]
		public decimal? High;
		/// <summary>
		/// 저가
		/// </summary>
		[JsonProperty("low_pric")]
		public decimal? Low;
	}

	public record KiwoomStockInfoGetUpperLowers
	{
		/// <summary>
		/// 상하한가 리스트
		/// </summary>
		[JsonProperty("updown_pric")]
		public IEnumerable<KiwoomStockInfoGetUpperLowerItem>? Items;
	}

	public record KiwoomStockInfoGetUpperLowerItem
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
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? Change;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? ChangeRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 전일거래량
		/// </summary>
		[JsonProperty("pred_trde_qty")]
		public decimal? PreviousDayVolume;
		/// <summary>
		/// 매도잔량
		/// </summary>
		[JsonProperty("sel_req")]
		public decimal? SellRemainQuantity;
		/// <summary>
		/// 매도호가
		/// </summary>
		[JsonProperty("sel_bid")]
		public decimal? SellQuote;
		/// <summary>
		/// 매수호가
		/// </summary>
		[JsonProperty("buy_bid")]
		public decimal? BuyQuote;
		/// <summary>
		/// 매수잔량
		/// </summary>
		[JsonProperty("buy_req")]
		public decimal? BuyRemainQuantity;
		/// <summary>
		/// 횟수
		/// </summary>
		[JsonProperty("cnt")]
		public decimal? Count;
	}

	public record KiwoomStockInfoGetHighLowProximities
	{
		/// <summary>
		/// 고저가근접 리스트
		/// </summary>
		[JsonProperty("high_low_pric_alacc")]
		public IEnumerable<KiwoomStockInfoGetHighLowProximityItem>? Items;
	}
	public record KiwoomStockInfoGetHighLowProximityItem
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
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? Change;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? ChangeRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 매도호가
		/// </summary>
		[JsonProperty("sel_bid")]
		public decimal? SellQuote;
		/// <summary>
		/// 매수호가
		/// </summary>
		[JsonProperty("buy_bid")]
		public decimal? BuyQuote;
		/// <summary>
		/// 당일고가
		/// </summary>
		[JsonProperty("tdy_high_pric")]
		public decimal? TodayHigh;
		/// <summary>
		/// 당일저가
		/// </summary>
		[JsonProperty("tdy_low_pric")]
		public decimal? TodayLow;
	}

	public record KiwoomStockInfoGetPriceVolatilities
	{
		/// <summary>
		/// 가격급등락 리스트
		/// </summary>
		[JsonProperty("pric_jmpflu")]
		public IEnumerable<KiwoomStockInfoGetPriceVolatilityItem>? Items;
	}
	public record KiwoomStockInfoGetPriceVolatilityItem
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
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? Change;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? ChangeRate;
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
		public decimal? BaseChange;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 급등률
		/// </summary>
		[JsonProperty("jmp_rt")]
		public decimal? SurgeRate;
	}

	public record KiwoomStockInfoGetVolumeUpdates
	{
		/// <summary>
		/// 거래량갱신 리스트
		/// </summary>
		[JsonProperty("trde_qty_updt")]
		public IEnumerable<KiwoomStockInfoGetVolumeUpdateItem>? Items;
	}
	public record KiwoomStockInfoGetVolumeUpdateItem
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
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? Change;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? ChangeRate;
		/// <summary>
		/// 이전거래량
		/// </summary>
		[JsonProperty("prev_trde_qty")]
		public decimal? PreviousDayVolume;
		/// <summary>
		/// 현재거래량
		/// </summary>
		[JsonProperty("now_trde_qty")]
		public decimal? CurrentVolume;
		/// <summary>
		/// 매도호가
		/// </summary>
		[JsonProperty("sel_bid")]
		public decimal? SellQuote;
		/// <summary>
		/// 매수호가
		/// </summary>
		[JsonProperty("buy_bid")]
		public decimal? BuyQuote;
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
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? Change;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? ChangeRate;
		/// <summary>
		/// 현재거래량
		/// </summary>
		[JsonProperty("now_trde_qty")]
		public decimal? CurrentVolume;
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
		public decimal? PriceRate;
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
		public decimal? Per;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? Change;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? ChangeRate;
		/// <summary>
		/// 현재거래량
		/// </summary>
		[JsonProperty("now_trde_qty")]
		public decimal? CurrentVolume;
		/// <summary>
		/// 매도호가
		/// </summary>
		[JsonProperty("sel_bid")]
		public decimal? SellQuote;
	}

	public record KiwoomStockInfoGetOpenChangeRates
	{
		/// <summary>
		/// 시가대비등락률 리스트
		/// </summary>
		[JsonProperty("open_pric_pre_flu_rt")]
		public IEnumerable<KiwoomStockInfoGetOpenChangeRateItem>? Items;
	}
	public record KiwoomStockInfoGetOpenChangeRateItem
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
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? Change;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? ChangeRate;
		/// <summary>
		/// 시가
		/// </summary>
		[JsonProperty("open_pric")]
		public decimal? Open;
		/// <summary>
		/// 고가
		/// </summary>
		[JsonProperty("high_pric")]
		public decimal? High;
		/// <summary>
		/// 저가
		/// </summary>
		[JsonProperty("low_pric")]
		public decimal? Low;
		/// <summary>
		/// 시가대비
		/// </summary>
		[JsonProperty("open_pric_pre")]
		public string? OpenChange;
		/// <summary>
		/// 현재거래량
		/// </summary>
		[JsonProperty("now_trde_qty")]
		public decimal? CurrentVolume;
		/// <summary>
		/// 체결강도
		/// </summary>
		[JsonProperty("cntr_str")]
		public decimal? TradeMomentum;
	}

	public record KiwoomStockInfoGetBrokerPriceAnalyses
	{
		/// <summary>
		/// 거래원매물대분석 리스트
		/// </summary>
		[JsonProperty("trde_ori_prps_anly")]
		public IEnumerable<KiwoomStockInfoGetBrokerPriceAnalysisItem>? Items;
	}
	public record KiwoomStockInfoGetBrokerPriceAnalysisItem
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
		public decimal? Close;
		/// <summary>
		/// 대비기호
		/// </summary>
		[JsonProperty("pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
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
		public KiwoomDecimal? NetBuyQuantity;
		/// <summary>
		/// 거래량합
		/// </summary>
		[JsonProperty("trde_qty_sum")]
		public decimal? TotalVolume;
		/// <summary>
		/// 거래비중
		/// </summary>
		[JsonProperty("trde_wght")]
		public decimal? TransactionWeight;
	}

	public record KiwoomStockInfoGetBrokerInstantVolumes
	{
		/// <summary>
		/// 거래원순간거래량 리스트
		/// </summary>
		[JsonProperty("trde_ori_mont_trde_qty")]
		public IEnumerable<KiwoomStockInfoGetBrokerInstantVolumeItem>? Items;
	}
	public record KiwoomStockInfoGetBrokerInstantVolumeItem
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
		public string? BrokerName;
		/// <summary>
		/// 구분
		/// </summary>
		[JsonProperty("tp")]
		public string? Type;
		/// <summary>
		/// 순간거래량
		/// </summary>
		[JsonProperty("mont_trde_qty")]
		public decimal? InstantVolume;
		/// <summary>
		/// 누적순매수
		/// </summary>
		[JsonProperty("acc_netprps")]
		public decimal? AccumulatedNetBuy;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? Change;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? ChangeRate;
	}

	public record KiwoomStockInfoGetViStrikeStocks
	{
		/// <summary>
		/// 발동종목 리스트
		/// </summary>
		[JsonProperty("motn_stk")]
		public IEnumerable<KiwoomStockInfoGetViStrikeStockItem>? Items;
	}
	public record KiwoomStockInfoGetViStrikeStockItem
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
		public decimal? AccumulatedVolume;
		/// <summary>
		/// 발동가격
		/// </summary>
		[JsonProperty("motn_pric")]
		public decimal? StrikePrice;
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
		public TimeSpan? TradeProcessTime;
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
		public decimal? OpenChangeRate;
		/// <summary>
		/// VI발동횟수
		/// </summary>
		[JsonProperty("vimotn_cnt")]
		public decimal? ViStrikeCount;
		/// <summary>
		/// 거래소구분
		/// </summary>
		[JsonProperty("stex_tp")]
		public string? ExchangeType;
	}

	public record KiwoomStockInfoGetTodayPreviousDayTradeQuantities
	{
		/// <summary>
		/// 당일전일체결량 리스트
		/// </summary>
		[JsonProperty("tdy_pred_cntr_qty")]
		public IEnumerable<KiwoomStockInfoGetTodayPreviousDayVolumeItem>? Items;
	}
	public record KiwoomStockInfoGetTodayPreviousDayVolumeItem
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
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? Change;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? ChangeRate;
		/// <summary>
		/// 체결량
		/// </summary>
		[JsonProperty("cntr_qty")]
		public decimal? Volume;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? AccumulatedVolume;
		/// <summary>
		/// 누적거래대금
		/// </summary>
		[JsonProperty("acc_trde_prica")]
		public decimal? AccumulatedTransactionAmount;
	}

	public record KiwoomStockInfoGetInvestorDailyTransactionStocks
	{
		/// <summary>
		/// 투자자별일별매매종목 리스트
		/// </summary>
		[JsonProperty("invsr_daly_trde_stk")]
		public IEnumerable<KiwoomStockInfoGetInvestorDailyTransactionStockItem>? Items;
	}
	public record KiwoomStockInfoGetInvestorDailyTransactionStockItem
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
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? Change;
		/// <summary>
		/// 평균가대비
		/// </summary>
		[JsonProperty("avg_pric_pre")]
		public KiwoomDecimal? AveragePriceChange;
		/// <summary>
		/// 대비율
		/// </summary>
		[JsonProperty("pre_rt")]
		public decimal? ChangeRate;
		/// <summary>
		/// 기간거래량
		/// </summary>
		[JsonProperty("dt_trde_qty")]
		public decimal? PeriodVolume;
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
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? Change;
		/// <summary>
		/// 등락율 (우측 2자리 소수점자리수)
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? ChangeRate;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? AccumulatedVolume;
		/// <summary>
		/// 누적거래대금
		/// </summary>
		[JsonProperty("acc_trde_prica")]
		public decimal? AccumulatedTransactionAmount;
		/// <summary>
		/// 개인투자자
		/// </summary>
		[JsonProperty("ind_invsr")]
		public string? RetailInvestor;
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
		public string? OtherFinancials;
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
		public string? OtherCorporations;
		/// <summary>
		/// 내외국인
		/// </summary>
		[JsonProperty("natfor")]
		public string? DomesticForeign;
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
		public KiwoomDecimal? RetailInvestors;
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
		public decimal? OtherCorporationss;
		/// <summary>
		/// 내외국인
		/// </summary>
		[JsonProperty("natfor")]
		public decimal? DomesticForeign;
	}

	public record KiwoomStockInfoGetTodayPreviousDayTrades
	{
		/// <summary>
		/// 당일전일체결 리스트
		/// </summary>
		[JsonProperty("tdy_pred_cntr")]
		public IEnumerable<KiwoomStockInfoGetTodayPreviousDayTradeItem>? Items;
	}
	public record KiwoomStockInfoGetTodayPreviousDayTradeItem
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
		public decimal? Change;
		/// <summary>
		/// 대비율
		/// </summary>
		[JsonProperty("pre_rt")]
		public decimal? ChangeRate;
		/// <summary>
		/// 우선매도호가단위
		/// </summary>
		[JsonProperty("pri_sel_bid_unit")]
		public decimal? BestSellQuoteUnit;
		/// <summary>
		/// 우선매수호가단위
		/// </summary>
		[JsonProperty("pri_buy_bid_unit")]
		public decimal? BestBuyQuoteUnit;
		/// <summary>
		/// 체결거래량
		/// </summary>
		[JsonProperty("cntr_trde_qty")]
		public decimal? TradeVolume;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("sign")]
		public string? ChangeSign;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? AccumulatedVolume;
		/// <summary>
		/// 누적거래대금
		/// </summary>
		[JsonProperty("acc_trde_prica")]
		public decimal? AccumulatedTransactionAmount;
		/// <summary>
		/// 체결강도
		/// </summary>
		[JsonProperty("cntr_str")]
		public decimal? TradeMomentum;
		/// <summary>
		/// 거래소구분 - KRX, NXT, 통합
		/// </summary>
		[JsonProperty("stex_tp")]
		public string? ExchangeType;
	}

	public record KiwoomStockInfoGetFavoriteStocks
	{
		/// <summary>
		/// 관심종목정보 리스트
		/// </summary>
		[JsonProperty("atn_stk_infr")]
		public IEnumerable<KiwoomStockInfoGetFavoriteStockItem>? Items;
	}
	public record KiwoomStockInfoGetFavoriteStockItem
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
		public decimal? Change;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? ChangeRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 거래대금
		/// </summary>
		[JsonProperty("trde_prica")]
		public decimal? TransactionAmount;
		/// <summary>
		/// 체결량
		/// </summary>
		[JsonProperty("cntr_qty")]
		public decimal? TradeQuantity;
		/// <summary>
		/// 체결강도
		/// </summary>
		[JsonProperty("cntr_str")]
		public decimal? TradeMomentum;
		/// <summary>
		/// 전일거래량대비
		/// </summary>
		[JsonProperty("pred_trde_qty_pre")]
		public decimal? VolumeChange;
		/// <summary>
		/// 매도호가
		/// </summary>
		[JsonProperty("sel_bid")]
		public decimal? SellQuote;
		/// <summary>
		/// 매수호가
		/// </summary>
		[JsonProperty("buy_bid")]
		public decimal? BuyQuote;
		/// <summary>
		/// 매도1차호가
		/// </summary>
		[JsonProperty("sel_1th_bid")]
		public decimal? SellQuote1;
		/// <summary>
		/// 매도2차호가
		/// </summary>
		[JsonProperty("sel_2th_bid")]
		public decimal? SellQuote2;
		/// <summary>
		/// 매도3차호가
		/// </summary>
		[JsonProperty("sel_3th_bid")]
		public decimal? SellQuote3;
		/// <summary>
		/// 매도4차호가
		/// </summary>
		[JsonProperty("sel_4th_bid")]
		public decimal? SellQuote4;
		/// <summary>
		/// 매도5차호가
		/// </summary>
		[JsonProperty("sel_5th_bid")]
		public decimal? SellQuote5;
		/// <summary>
		/// 매수1차호가
		/// </summary>
		[JsonProperty("buy_1th_bid")]
		public decimal? BuyQuote1;
		/// <summary>
		/// 매수2차호가
		/// </summary>
		[JsonProperty("buy_2th_bid")]
		public decimal? BuyQuote2;
		/// <summary>
		/// 매수3차호가
		/// </summary>
		[JsonProperty("buy_3th_bid")]
		public decimal? BuyQuote3;
		/// <summary>
		/// 매수4차호가
		/// </summary>
		[JsonProperty("buy_4th_bid")]
		public decimal? BuyQuote4;
		/// <summary>
		/// 매수5차호가
		/// </summary>
		[JsonProperty("buy_5th_bid")]
		public decimal? BuyQuote5;
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
		/// 시가
		/// </summary>
		[JsonProperty("open_pric")]
		public decimal? Open;
		/// <summary>
		/// 고가
		/// </summary>
		[JsonProperty("high_pric")]
		public decimal? High;
		/// <summary>
		/// 저가
		/// </summary>
		[JsonProperty("low_pric")]
		public decimal? Low;
		/// <summary>
		/// 종가
		/// </summary>
		[JsonProperty("close_pric")]
		public decimal? Close;
		/// <summary>
		/// 체결시간
		/// </summary>
		[JsonProperty("cntr_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? TradeTime;
		/// <summary>
		/// 예상체결가
		/// </summary>
		[JsonProperty("exp_cntr_pric")]
		public decimal? ExpectedTradePrice;
		/// <summary>
		/// 예상체결량
		/// </summary>
		[JsonProperty("exp_cntr_qty")]
		public decimal? ExpectedTradeQuantity;
		/// <summary>
		/// 자본금
		/// </summary>
		[JsonProperty("cap")]
		public decimal? Capital;
		/// <summary>
		/// 액면가
		/// </summary>
		[JsonProperty("fav")]
		public decimal? ParValue;
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
		public TimeSpan? QuoteTime;
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
		public decimal? BestSellRemainQuantity;
		/// <summary>
		/// 우선매수잔량
		/// </summary>
		[JsonProperty("pri_buy_req")]
		public decimal? BestBuyRemainQuantity;
		/// <summary>
		/// 우선매도건수
		/// </summary>
		[JsonProperty("pri_sel_cnt")]
		public decimal? BestSellCount;
		/// <summary>
		/// 우선매수건수
		/// </summary>
		[JsonProperty("pri_buy_cnt")]
		public decimal? BestBuyCount;
		/// <summary>
		/// 총매도잔량
		/// </summary>
		[JsonProperty("tot_sel_req")]
		public decimal? TotalSellRemainQuantity;
		/// <summary>
		/// 총매수잔량
		/// </summary>
		[JsonProperty("tot_buy_req")]
		public decimal? TotalBuyRemainQuantity;
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
		public decimal? ElwExercisePrice;
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
		public DateTime? ElwExpirationDate;
		/// <summary>
		/// 미결제약정
		/// </summary>
		[JsonProperty("cntr_engg")]
		public decimal? OpenInterest;
		/// <summary>
		/// 미결제전일대비
		/// </summary>
		[JsonProperty("cntr_pred_pre")]
		public decimal? OpenInterestChange;
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
		public decimal? ListedQuantity;
		/// <summary>
		/// 감리구분
		/// </summary>
		[JsonProperty("auditInfo")]
		public string? AuditType;
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
		public decimal? PreviousDayClose;
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
		public string? CompanySizeType;
		/// <summary>
		/// 회사분류 (코스닥만 존재함)
		/// </summary>
		[JsonProperty("companyClassName")]
		public string? CompanyType;
		/// <summary>
		/// 투자유의종목여부 (0: 해당없음, 2: 정리매매, 3: 단기과열, 4: 투자위험, 5: 투자경과, 1: ETF투자주의요망(ETF인 경우만 전달))
		/// </summary>
		[JsonProperty("orderWarning")]
		public string? InvestmentCaution;
		/// <summary>
		/// NXT가능여부 (Y: 가능)
		/// </summary>
		[JsonProperty("nxtEnable")]
		public string? NxtEnable;
	}

	public record KiwoomStockInfoGetIndustryCodes
	{
		/// <summary>
		/// 업종코드리스트
		/// </summary>
		[JsonProperty("marketCode")]
		public IEnumerable<KiwoomStockInfoGetIndustryCodeItem>? Items;
	}
	public record KiwoomStockInfoGetIndustryCodeItem
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

	public record KiwoomStockInfoGetMemberCompanys
	{
		/// <summary>
		/// 회원사코드리스트
		/// </summary>
		[JsonProperty("list")]
		public IEnumerable<KiwoomStockInfoGetMemberCompanyItem>? Items;
	}
	public record KiwoomStockInfoGetMemberCompanyItem
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
		public string? Type;
	}

	public record KiwoomStockInfoGetProgramNetBuyTop50
	{
		/// <summary>
		/// 프로그램순매수상위50 리스트
		/// </summary>
		[JsonProperty("prm_netprps_upper_50")]
		public IEnumerable<KiwoomStockInfoGetProgramNetBuyTop50Item>? Items;
	}
	public record KiwoomStockInfoGetProgramNetBuyTop50Item
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
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? Change;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? ChangeRate;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? AccumulatedVolume;
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
		public decimal? ProgramNetBuyAmount;
	}

	public record KiwoomStockInfoGetStockProgramTransactionStatus
	{
		/// <summary>
		/// 매수체결수량합계
		/// </summary>
		[JsonProperty("tot_1")]
		public decimal? TotalBuyTradeQuantity;
		/// <summary>
		/// 매수체결금액합계
		/// </summary>
		[JsonProperty("tot_2")]
		public decimal? TotalBuyTradeAmount;
		/// <summary>
		/// 매도체결수량합계
		/// </summary>
		[JsonProperty("tot_3")]
		public decimal? TotalSellTradeQuantity;
		/// <summary>
		/// 매도체결금액합계
		/// </summary>
		[JsonProperty("tot_4")]
		public decimal? TotalSellTradeAmount;
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
		public IEnumerable<KiwoomStockInfoGetStockProgramTransactionStatusItem>? Items;
	}
	public record KiwoomStockInfoGetStockProgramTransactionStatusItem
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
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? Change;
		/// <summary>
		/// 매수체결수량
		/// </summary>
		[JsonProperty("buy_cntr_qty")]
		public decimal? BuyTradeQuantity;
		/// <summary>
		/// 매수체결금액
		/// </summary>
		[JsonProperty("buy_cntr_amt")]
		public decimal? BuyTradeAmount;
		/// <summary>
		/// 매도체결수량
		/// </summary>
		[JsonProperty("sel_cntr_qty")]
		public decimal? SellTradeQuantity;
		/// <summary>
		/// 매도체결금액
		/// </summary>
		[JsonProperty("sel_cntr_amt")]
		public decimal? SellTradeAmount;
		/// <summary>
		/// 순매수대금
		/// </summary>
		[JsonProperty("netprps_prica")]
		public decimal? NetBuyAmount;
		/// <summary>
		/// 전체거래비율
		/// </summary>
		[JsonProperty("all_trde_rt")]
		public decimal? TotalTransactionRate;
	}

	public record KiwoomStockInfoGetCreditLoanAvailableStocks
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
		public IEnumerable<KiwoomStockInfoGetCreditLoanAvailableStockItem>? Items;
	}
	public record KiwoomStockInfoGetCreditLoanAvailableStockItem
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
		public decimal? CreditDepositRate;
		/// <summary>
		/// 대용가
		/// </summary>
		[JsonProperty("repl_pric")]
		public decimal? SubstitutePrice;
		/// <summary>
		/// 전일종가
		/// </summary>
		[JsonProperty("pred_close_pric")]
		public decimal? PreviousDayClose;
		/// <summary>
		/// 신용한도초과여부
		/// </summary>
		[JsonProperty("crd_limit_over_yn")]
		public string? CreditLimitExceeded;
		/// <summary>
		/// 신용한도초과 - N:공란,Y:회사한도 초과
		/// </summary>
		[JsonProperty("crd_limit_over_txt")]
		public string? CreditLimitExceededText;
	}

	public record KiwoomStockInfoGetCreditLoanAvailable
	{
		/// <summary>
		/// 신용가능여부
		/// </summary>
		[JsonProperty("crd_alow_yn")]
		public string? CreditAvailable;
	}
}
