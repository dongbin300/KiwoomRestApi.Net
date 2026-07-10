using KiwoomRestApi.Net.Converters;
using KiwoomRestApi.Net.Objects.Commons;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models.UsStock
{
	/// <summary>
	/// | usa01980 | 미국주식 실시간 종목 조회 순위
	/// </summary>
	public record KiwoomUsStockRankingInfoGetRealtimeQueryRanks
	{
		/// <summary>
		/// 기준날짜
		/// </summary>
		[JsonProperty("base_date")]
		public string? BaseDate;
		/// <summary>
		/// 기준시간
		/// </summary>
		[JsonProperty("base_time")]
		public string? BaseTime;
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockRankingInfoRealtimeQueryRankItem>? Items;
	}

	public record KiwoomUsStockRankingInfoRealtimeQueryRankItem
	{
		/// <summary>
		/// 종목순위
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
		/// 등락부호
		/// </summary>
		[JsonProperty("sign")]
		public string? Sign;
		/// <summary>
		/// 직전대비 순위변화값
		/// </summary>
		[JsonProperty("chg_val")]
		public int? RankChange;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("curr_pric")]
		public decimal? CurrentPrice;
		/// <summary>
		/// 기준가대비 부호
		/// </summary>
		[JsonProperty("sign_for_gjga")]
		public string? BasePriceChangeSign;
		/// <summary>
		/// 기준가대비 등락률
		/// </summary>
		[JsonProperty("diff_rate_for_gjga")]
		public decimal? BasePriceChangeRate;
		/// <summary>
		/// 직전기준대비 부호
		/// </summary>
		[JsonProperty("sign_for_prev")]
		public string? PreviousChangeSign;
		/// <summary>
		/// 직전기준대비 등락률
		/// </summary>
		[JsonProperty("diff_rate_for_prev")]
		public decimal? PreviousChangeRate;
		/// <summary>
		/// 거래소구분
		/// </summary>
		[JsonProperty("stex_tp")]
		public string? ExchangeType;
	}

	/// <summary>
	/// | usa01990 | 미국주식 관심종목 등록 상위
	/// </summary>
	public record KiwoomUsStockRankingInfoGetWatchlistRegistrationRanks
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockRankingInfoWatchlistRegistrationRankItem>? Items;
	}

	public record KiwoomUsStockRankingInfoWatchlistRegistrationRankItem
	{
		/// <summary>
		/// 순위
		/// </summary>
		[JsonProperty("rank")]
		public int? Rank;
		/// <summary>
		/// 순위등락부호
		/// </summary>
		[JsonProperty("rank_flu_sig")]
		public string? RankChangeSign;
		/// <summary>
		/// 순위등락폭
		/// </summary>
		[JsonProperty("rank_flu")]
		public int? RankChange;
		/// <summary>
		/// 거래소구분
		/// </summary>
		[JsonProperty("stex_tp")]
		public string? ExchangeType;
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
		/// 종목영문명
		/// </summary>
		[JsonProperty("stk_enm")]
		public string? StockEnglishName;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
	}

	/// <summary>
	/// | usa20510 | 미국주식 기간별 등락률상위(주식/업종)
	/// </summary>
	public record KiwoomUsStockRankingInfoGetPeriodChangeRateRanks
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockRankingInfoPeriodChangeRateRankItem>? Items;
	}

	public record KiwoomUsStockRankingInfoPeriodChangeRateRankItem
	{
		/// <summary>
		/// 순위
		/// </summary>
		[JsonProperty("rank")]
		public int? Rank;
		/// <summary>
		/// 거래소구분
		/// </summary>
		[JsonProperty("stex_tp")]
		public string? ExchangeType;
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
		/// 종목영문명
		/// </summary>
		[JsonProperty("stk_enm")]
		public string? StockEnglishName;
		/// <summary>
		/// 시작일기준가
		/// </summary>
		[JsonProperty("stdt_base_pric")]
		public KiwoomDecimal? StartDateBasePrice;
		/// <summary>
		/// 종료일기준가
		/// </summary>
		[JsonProperty("endt_base_pric")]
		public KiwoomDecimal? EndDateBasePrice;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 시작일거래량
		/// </summary>
		[JsonProperty("stdt_trde_qty")]
		public decimal? StartDateVolume;
		/// <summary>
		/// 종료일거래량
		/// </summary>
		[JsonProperty("endt_trde_qty")]
		public decimal? EndDateVolume;
	}

	/// <summary>
	/// | usa20530 | 미국주식 당일 거래량 상위(주식/업종)
	/// </summary>
	public record KiwoomUsStockRankingInfoGetVolumeRanks
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockRankingInfoVolumeRankItem>? Items;
	}

	public record KiwoomUsStockRankingInfoVolumeRankItem
	{
		/// <summary>
		/// 순위
		/// </summary>
		[JsonProperty("rank")]
		public int? Rank;
		/// <summary>
		/// 거래소구분
		/// </summary>
		[JsonProperty("stex_tp")]
		public string? ExchangeType;
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
		/// 종목영문명
		/// </summary>
		[JsonProperty("stk_enm")]
		public string? StockEnglishName;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 전일비
		/// </summary>
		[JsonProperty("pred_rt")]
		public KiwoomDecimal? PreviousDayRate;
		/// <summary>
		/// 거래대금
		/// </summary>
		[JsonProperty("trde_prica")]
		public decimal? TransactionAmount;
	}

	/// <summary>
	/// | usa20540 | 미국주식 당일 거래대금 상위(주식/업종)
	/// </summary>
	public record KiwoomUsStockRankingInfoGetTransactionAmountRanks
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockRankingInfoTransactionAmountRankItem>? Items;
	}

	public record KiwoomUsStockRankingInfoTransactionAmountRankItem
	{
		/// <summary>
		/// 순위
		/// </summary>
		[JsonProperty("rank")]
		public int? Rank;
		/// <summary>
		/// 거래소구분
		/// </summary>
		[JsonProperty("stex_tp")]
		public string? ExchangeType;
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
		/// 종목영문명
		/// </summary>
		[JsonProperty("stk_enm")]
		public string? StockEnglishName;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 전일거래량
		/// </summary>
		[JsonProperty("pred_trde_qty")]
		public decimal? PreviousDayVolume;
		/// <summary>
		/// 거래대금
		/// </summary>
		[JsonProperty("trde_prica")]
		public decimal? TransactionAmount;
	}

	/// <summary>
	/// | usa20550 | 미국주식 시가총액상위(주식/업종)
	/// </summary>
	public record KiwoomUsStockRankingInfoGetMarketCapRanks
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockRankingInfoMarketCapRankItem>? Items;
	}

	public record KiwoomUsStockRankingInfoMarketCapRankItem
	{
		/// <summary>
		/// 순위
		/// </summary>
		[JsonProperty("rank")]
		public int? Rank;
		/// <summary>
		/// 증거금률
		/// </summary>
		[JsonProperty("mgn_type")]
		public string? MarginType;
		/// <summary>
		/// 거래소구분
		/// </summary>
		[JsonProperty("stex_tp")]
		public string? ExchangeType;
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
		/// 종목영문명
		/// </summary>
		[JsonProperty("stk_enm")]
		public string? StockEnglishName;
		/// <summary>
		/// 시가총액
		/// </summary>
		[JsonProperty("mac")]
		public decimal? MarketCapitalization;
		/// <summary>
		/// 거래대비율
		/// </summary>
		[JsonProperty("trde_pre_rt")]
		public decimal? TradeCompareRate;
		/// <summary>
		/// 시가총액비
		/// </summary>
		[JsonProperty("mac_wght")]
		public decimal? MarketCapWeight;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? Volume;
	}

	/// <summary>
	/// | usa20880 | 키움 거래 상위 종목(미국주식)
	/// </summary>
	public record KiwoomUsStockRankingInfoGetKiwoomTradeRanks
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockRankingInfoKiwoomTradeRankItem>? Items;
	}

	public record KiwoomUsStockRankingInfoKiwoomTradeRankItem
	{
		/// <summary>
		/// 거래소구분
		/// </summary>
		[JsonProperty("stex_tp")]
		public string? ExchangeType;
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
		/// 종목영문명
		/// </summary>
		[JsonProperty("stk_enm")]
		public string? StockEnglishName;
		/// <summary>
		/// 키움상위순위
		/// </summary>
		[JsonProperty("kw_high_rank")]
		public int? KiwoomHighRank;
		/// <summary>
		/// 키움상위순위등락부호
		/// </summary>
		[JsonProperty("kw_high_rank_sig")]
		public string? KiwoomHighRankChangeSign;
		/// <summary>
		/// 키움상위 순위등락폭
		/// </summary>
		[JsonProperty("kw_high_rank_hl")]
		public int? KiwoomHighRankChange;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
	}

	/// <summary>
	/// | usa20910 | 미국주식 전일대비 등락률상위(주식/업종)
	/// </summary>
	public record KiwoomUsStockRankingInfoGetChangeRateRanks
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockRankingInfoChangeRateRankItem>? Items;
	}

	public record KiwoomUsStockRankingInfoChangeRateRankItem
	{
		/// <summary>
		/// 순위
		/// </summary>
		[JsonProperty("rank")]
		public int? Rank;
		/// <summary>
		/// 거래소구분
		/// </summary>
		[JsonProperty("stex_tp")]
		public string? ExchangeType;
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
		/// 종목영문명
		/// </summary>
		[JsonProperty("stk_enm")]
		public string? StockEnglishName;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 매도잔량
		/// </summary>
		[JsonProperty("sel_req")]
		public KiwoomDecimal? SellQuantity;
		/// <summary>
		/// 매수잔량
		/// </summary>
		[JsonProperty("buy_req")]
		public KiwoomDecimal? BuyQuantity;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public KiwoomDecimal? Volume;
		/// <summary>
		/// 횟수
		/// </summary>
		[JsonProperty("cnt")]
		public int? Count;
	}

	/// <summary>
	/// | usa20920 | 미국주식 시가대비 등락률상위(주식/업종)
	/// </summary>
	public record KiwoomUsStockRankingInfoGetOpenPriceChangeRateRanks
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockRankingInfoOpenPriceChangeRateRankItem>? Items;
	}

	public record KiwoomUsStockRankingInfoOpenPriceChangeRateRankItem
	{
		/// <summary>
		/// 순위
		/// </summary>
		[JsonProperty("rank")]
		public int? Rank;
		/// <summary>
		/// 거래소구분
		/// </summary>
		[JsonProperty("stex_tp")]
		public string? ExchangeType;
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
		/// 종목영문명
		/// </summary>
		[JsonProperty("stk_enm")]
		public string? StockEnglishName;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 고가
		/// </summary>
		[JsonProperty("high_pric")]
		public KiwoomDecimal? High;
		/// <summary>
		/// 저가
		/// </summary>
		[JsonProperty("low_pric")]
		public KiwoomDecimal? Low;
		/// <summary>
		/// 시가대비 등락률
		/// </summary>
		[JsonProperty("open_pric_pre")]
		public decimal? OpenPriceChangeRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 체결시간
		/// </summary>
		[JsonProperty("cntr_tm")]
		public string? TradeTime;
		/// <summary>
		/// 시가
		/// </summary>
		[JsonProperty("open_pric")]
		public KiwoomDecimal? Open;
	}

	/// <summary>
	/// | usa20940 | 미국주식 누적 등락률 상위(주식/업종)
	/// </summary>
	public record KiwoomUsStockRankingInfoGetCumulativeChangeRateRanks
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockRankingInfoCumulativeChangeRateRankItem>? Items;
	}

	public record KiwoomUsStockRankingInfoCumulativeChangeRateRankItem
	{
		/// <summary>
		/// 순위
		/// </summary>
		[JsonProperty("rank")]
		public int? Rank;
		/// <summary>
		/// 증거금률
		/// </summary>
		[JsonProperty("mgn_type")]
		public string? MarginType;
		/// <summary>
		/// 거래소구분
		/// </summary>
		[JsonProperty("stex_tp")]
		public string? ExchangeType;
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
		/// 종목영문명
		/// </summary>
		[JsonProperty("stk_enm")]
		public string? StockEnglishName;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 최고가
		/// </summary>
		[JsonProperty("hgst_pric")]
		public decimal? High;
		/// <summary>
		/// 종목최고일자
		/// </summary>
		[JsonProperty("stk_high_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? HighDate;
		/// <summary>
		/// 최저가
		/// </summary>
		[JsonProperty("lwst_pric")]
		public decimal? Low;
		/// <summary>
		/// 종목최저일자
		/// </summary>
		[JsonProperty("stk_low_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? LowDate;
		/// <summary>
		/// 누적등락률
		/// </summary>
		[JsonProperty("acc_flu_rt")]
		public decimal? CumulativeChangeRate;
		/// <summary>
		/// 누적등락폭
		/// </summary>
		[JsonProperty("acc_flu_amt")]
		public decimal? CumulativeChangeAmount;
		/// <summary>
		/// 업종명
		/// </summary>
		[JsonProperty("inds_cd")]
		public string? IndustryName;
	}

	/// <summary>
	/// | usa20960 | 미국주식 전일 거래상위(주식/업종)
	/// </summary>
	public record KiwoomUsStockRankingInfoGetPreviousDayTradeRanks
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockRankingInfoPreviousDayTradeRankItem>? Items;
	}

	public record KiwoomUsStockRankingInfoPreviousDayTradeRankItem
	{
		/// <summary>
		/// 순위
		/// </summary>
		[JsonProperty("rank")]
		public int? Rank;
		/// <summary>
		/// 거래소구분
		/// </summary>
		[JsonProperty("stex_tp")]
		public string? ExchangeType;
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
		/// 종목영문명
		/// </summary>
		[JsonProperty("stk_enm")]
		public string? StockEnglishName;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 전일거래량
		/// </summary>
		[JsonProperty("pred_trde_qty")]
		public decimal? PreviousDayVolume;
		/// <summary>
		/// 전일비
		/// </summary>
		[JsonProperty("pred_rt")]
		public decimal? PreviousDayRate;
		/// <summary>
		/// 당일거래량
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? Volume;
	}

	/// <summary>
	/// | usa24110 | 미국주식 최고최저가대비 상승하락(주식/업종)
	/// </summary>
	public record KiwoomUsStockRankingInfoGetHighLowChangeRanks
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockRankingInfoHighLowChangeRankItem>? Items;
	}

	public record KiwoomUsStockRankingInfoHighLowChangeRankItem
	{
		/// <summary>
		/// 순위
		/// </summary>
		[JsonProperty("rank")]
		public int? Rank;
		/// <summary>
		/// 증거금률
		/// </summary>
		[JsonProperty("mgn_type")]
		public string? MarginType;
		/// <summary>
		/// 거래소구분
		/// </summary>
		[JsonProperty("stex_tp")]
		public string? ExchangeType;
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
		/// 종목영문명
		/// </summary>
		[JsonProperty("stk_enm")]
		public string? StockEnglishName;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 연중최고가
		/// </summary>
		[JsonProperty("oyr_hgst")]
		public decimal? YearHigh;
		/// <summary>
		/// 연중최저가
		/// </summary>
		[JsonProperty("oyr_lwst")]
		public decimal? YearLow;
		/// <summary>
		/// 52주 최고가
		/// </summary>
		[JsonProperty("52wk_hgst_pric")]
		public KiwoomDecimal? FiftyTwoWeekHigh;
		/// <summary>
		/// 52주 최저가
		/// </summary>
		[JsonProperty("52wk_lwst_pric")]
		public KiwoomDecimal? FiftyTwoWeekLow;
		/// <summary>
		/// 최저가/최고가 대비기호
		/// </summary>
		[JsonProperty("hl_pre_sig")]
		public string? HighLowChangeSign;
		/// <summary>
		/// 최저가/최고가대비
		/// </summary>
		[JsonProperty("hl_pre")]
		public decimal? HighLowChange;
		/// <summary>
		/// 대비등락율
		/// </summary>
		[JsonProperty("pre_flu_rt")]
		public KiwoomDecimal? ChangeRateVsHighLow;
		/// <summary>
		/// 최고/최저일시
		/// </summary>
		[JsonProperty("base_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? BaseDate;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? Volume;
	}

	/// <summary>
	/// | usa24120 | 미국주식 특정일자 상승/하락(주식/업종)
	/// </summary>
	public record KiwoomUsStockRankingInfoGetSpecificDayChangeRanks
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockRankingInfoSpecificDayChangeRankItem>? Items;
	}

	public record KiwoomUsStockRankingInfoSpecificDayChangeRankItem
	{
		/// <summary>
		/// 순위
		/// </summary>
		[JsonProperty("rank")]
		public int? Rank;
		/// <summary>
		/// 거래소구분
		/// </summary>
		[JsonProperty("stex_tp")]
		public string? ExchangeType;
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
		/// 종목영문명
		/// </summary>
		[JsonProperty("stk_enm")]
		public string? StockEnglishName;
		/// <summary>
		/// 기준일자
		/// </summary>
		[JsonProperty("base_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? BaseDate;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 누적거래대금
		/// </summary>
		[JsonProperty("trde_prica")]
		public decimal? TransactionAmount;
		/// <summary>
		/// 시가
		/// </summary>
		[JsonProperty("open_pric")]
		public KiwoomDecimal? Open;
		/// <summary>
		/// 고가
		/// </summary>
		[JsonProperty("high_pric")]
		public KiwoomDecimal? High;
		/// <summary>
		/// 저가
		/// </summary>
		[JsonProperty("low_pric")]
		public KiwoomDecimal? Low;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
	}

	/// <summary>
	/// | usa24150 | 미국주식 회전율 상위(주식/업종)
	/// </summary>
	public record KiwoomUsStockRankingInfoGetTurnoverRateRanks
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockRankingInfoTurnoverRateRankItem>? Items;
	}

	public record KiwoomUsStockRankingInfoTurnoverRateRankItem
	{
		/// <summary>
		/// 순위
		/// </summary>
		[JsonProperty("rank")]
		public int? Rank;
		/// <summary>
		/// 증거금유형
		/// </summary>
		[JsonProperty("mgn_type")]
		public string? MarginType;
		/// <summary>
		/// 거래소구분
		/// </summary>
		[JsonProperty("stex_tp")]
		public string? ExchangeType;
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
		/// 종목영문명
		/// </summary>
		[JsonProperty("stk_enm")]
		public string? StockEnglishName;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 거래회전율
		/// </summary>
		[JsonProperty("trde_tern_rt")]
		public KiwoomDecimal? TurnoverRate;
		/// <summary>
		/// 2일평균거래회전율
		/// </summary>
		[JsonProperty("2d_avg_tern_rt")]
		public KiwoomDecimal? AverageTurnoverRate2Day;
		/// <summary>
		/// 10일평균거래회전율
		/// </summary>
		[JsonProperty("10d_avg_tern_rt")]
		public KiwoomDecimal? AverageTurnoverRate10Day;
		/// <summary>
		/// 20일평균거래회전율
		/// </summary>
		[JsonProperty("20d_avg_tern_rt")]
		public KiwoomDecimal? AverageTurnoverRate20Day;
	}

	/// <summary>
	/// | usa24160 | 미국주식 연속상승/하락 순위(주식/업종)
	/// </summary>
	public record KiwoomUsStockRankingInfoGetContinuousChangeRanks
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockRankingInfoContinuousChangeRankItem>? Items;
	}

	public record KiwoomUsStockRankingInfoContinuousChangeRankItem
	{
		/// <summary>
		/// 순위
		/// </summary>
		[JsonProperty("rank")]
		public int? Rank;
		/// <summary>
		/// 증거금유형
		/// </summary>
		[JsonProperty("mgn_type")]
		public string? MarginType;
		/// <summary>
		/// 거래소구분
		/// </summary>
		[JsonProperty("stex_tp")]
		public string? ExchangeType;
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
		/// 종목영문명
		/// </summary>
		[JsonProperty("stk_enm")]
		public string? StockEnglishName;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 기준종가
		/// </summary>
		[JsonProperty("base_close_pric")]
		public KiwoomDecimal? BaseClosePrice;
		/// <summary>
		/// 기준대비율
		/// </summary>
		[JsonProperty("base_pre_rt")]
		public KiwoomDecimal? BaseChangeRate;
		/// <summary>
		/// 연속일수
		/// </summary>
		[JsonProperty("conti_dt")]
		public int? ContinuousDays;
	}

	/// <summary>
	/// | usa24162 | 미국주식 연속상승/하락 순위(관심종목)
	/// </summary>
	public record KiwoomUsStockRankingInfoGetWatchlistContinuousChangeRanks
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockRankingInfoContinuousChangeRankItem>? Items;
	}

	/// <summary>
	/// | usa24200 | 미국주식 호가잔량상위(주식/업종)
	/// </summary>
	public record KiwoomUsStockRankingInfoGetOrderBookRanks
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockRankingInfoOrderBookRankItem>? Items;
	}

	public record KiwoomUsStockRankingInfoOrderBookRankItem
	{
		/// <summary>
		/// 순위
		/// </summary>
		[JsonProperty("rank")]
		public int? Rank;
		/// <summary>
		/// 증거금유형
		/// </summary>
		[JsonProperty("mgn_type")]
		public string? MarginType;
		/// <summary>
		/// 거래소구분
		/// </summary>
		[JsonProperty("stex_tp")]
		public string? ExchangeType;
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
		/// 종목영문명
		/// </summary>
		[JsonProperty("stk_enm")]
		public string? StockEnglishName;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 총매도잔량
		/// </summary>
		[JsonProperty("tot_sel_req")]
		public decimal? TotalSellRemainingQuantity;
		/// <summary>
		/// 총매수잔량
		/// </summary>
		[JsonProperty("tot_buy_req")]
		public decimal? TotalBuyRemainingQuantity;
		/// <summary>
		/// 매수잔량
		/// </summary>
		[JsonProperty("buy_req")]
		public decimal? BuyRemainingQuantity;
		/// <summary>
		/// 매수비율
		/// </summary>
		[JsonProperty("buy_rt")]
		public KiwoomDecimal? BuyRate;
		/// <summary>
		/// 매도잔량
		/// </summary>
		[JsonProperty("sel_req")]
		public decimal? SellRemainingQuantity;
		/// <summary>
		/// 매도비율
		/// </summary>
		[JsonProperty("sel_rt")]
		public KiwoomDecimal? SellRate;
		/// <summary>
		/// 체결시간
		/// </summary>
		[JsonProperty("cntr_tm")]
		public string? TradeTime;
	}

	/// <summary>
	/// | usa24290 | 미국주식 주간거래 괴리율 상위(주식/업종)
	/// </summary>
	public record KiwoomUsStockRankingInfoGetDisparityRateRanks
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockRankingInfoDisparityRateRankItem>? Items;
	}

	public record KiwoomUsStockRankingInfoDisparityRateRankItem
	{
		/// <summary>
		/// 순위
		/// </summary>
		[JsonProperty("rank")]
		public int? Rank;
		/// <summary>
		/// 증거금유형
		/// </summary>
		[JsonProperty("mgn_type")]
		public string? MarginType;
		/// <summary>
		/// 거래소구분
		/// </summary>
		[JsonProperty("stex_tp")]
		public string? ExchangeType;
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
		/// 종목영문명
		/// </summary>
		[JsonProperty("stk_enm")]
		public string? StockEnglishName;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 정규장종가
		/// </summary>
		[JsonProperty("reg_close_pric")]
		public KiwoomDecimal? RegularCloseClosePrice;
		/// <summary>
		/// 정규장전일대비기호
		/// </summary>
		[JsonProperty("reg_pre_sig")]
		public string? RegularChangeSign;
		/// <summary>
		/// 정규장전일대비
		/// </summary>
		[JsonProperty("reg_pre")]
		public KiwoomDecimal? RegularChange;
		/// <summary>
		/// 매도호가
		/// </summary>
		[JsonProperty("sel_bid")]
		public KiwoomDecimal? SellBid;
		/// <summary>
		/// 매수호가
		/// </summary>
		[JsonProperty("buy_bid")]
		public KiwoomDecimal? BuyBid;
		/// <summary>
		/// 괴리율
		/// </summary>
		[JsonProperty("dispty_rt")]
		public KiwoomDecimal? DisparityRate;
		/// <summary>
		/// 체결시간
		/// </summary>
		[JsonProperty("cntr_tm")]
		public string? TradeTime;
		/// <summary>
		/// 체결강도
		/// </summary>
		[JsonProperty("cntr_str")]
		public KiwoomDecimal? TradeStrength;
		/// <summary>
		/// 체결건수
		/// </summary>
		[JsonProperty("cnt")]
		public decimal? TradeCount;
		/// <summary>
		/// 매도잔량
		/// </summary>
		[JsonProperty("sel_req")]
		public decimal? SellRemainingQuantity;
		/// <summary>
		/// 매수잔량
		/// </summary>
		[JsonProperty("buy_req")]
		public decimal? BuyRemainingQuantity;
	}
}
