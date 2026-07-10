using KiwoomRestApi.Net.Converters;
using KiwoomRestApi.Net.Objects.Commons;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models.UsStock
{
	/// <summary>
	/// | usa20100 | 미국주식 현재가 종목정보
	/// </summary>
	public record KiwoomUsStockMarketConditionGetStockInfo
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
		/// 52주 최고가
		/// </summary>
		[JsonProperty("52wk_hgst_pric")]
		public KiwoomDecimal? FiftyTwoWeekHigh;
		/// <summary>
		/// 52주 최고가 대비율
		/// </summary>
		[JsonProperty("52wk_hgst_pric_pre_rt")]
		public KiwoomDecimal? FiftyTwoWeekHighChangeRate;
		/// <summary>
		/// 52주 최고가일
		/// </summary>
		[JsonProperty("52wk_hgst_pric_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? FiftyTwoWeekHighDate;
		/// <summary>
		/// 52주 최저가
		/// </summary>
		[JsonProperty("52wk_lwst_pric")]
		public KiwoomDecimal? FiftyTwoWeekLow;
		/// <summary>
		/// 52주 최저가 대비율
		/// </summary>
		[JsonProperty("52wk_lwst_pric_pre_rt")]
		public KiwoomDecimal? FiftyTwoWeekLowChangeRate;
		/// <summary>
		/// 52주 최저가일
		/// </summary>
		[JsonProperty("52wk_lwst_pric_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? FiftyTwoWeekLowDate;
		/// <summary>
		/// 주식수
		/// </summary>
		[JsonProperty("stk_cnt")]
		public decimal? StockCount;
		/// <summary>
		/// 시가총액 (단위: 천USD)
		/// </summary>
		[JsonProperty("mac")]
		public decimal? MarketCapitalization;
		/// <summary>
		/// 결산월
		/// </summary>
		[JsonProperty("setl_mm")]
		public string? SettlementMonth;
		/// <summary>
		/// 대업종구분
		/// </summary>
		[JsonProperty("lg_inds_cd")]
		public string? LargeIndustryCode;
		/// <summary>
		/// 소업종구분
		/// </summary>
		[JsonProperty("sm_inds_cd")]
		public string? SmallIndustryCode;
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
		/// 연중최고가
		/// </summary>
		[JsonProperty("oyr_hgst")]
		public KiwoomDecimal? YearHigh;
		/// <summary>
		/// 연중최고가일
		/// </summary>
		[JsonProperty("oyr_hgst_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? YearHighDate;
		/// <summary>
		/// 연중최고가 대비율
		/// </summary>
		[JsonProperty("oyr_hgst_pre_rt")]
		public KiwoomDecimal? YearHighChangeRate;
		/// <summary>
		/// 연중최저가
		/// </summary>
		[JsonProperty("oyr_lwst")]
		public KiwoomDecimal? YearLow;
		/// <summary>
		/// 연중최저가일
		/// </summary>
		[JsonProperty("oyr_lwst_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? YearLowDate;
		/// <summary>
		/// 연중최저가 대비율
		/// </summary>
		[JsonProperty("oyr_lwst_pre_rt")]
		public KiwoomDecimal? YearLowChangeRate;
		/// <summary>
		/// 전일시가
		/// </summary>
		[JsonProperty("pre_open_pric")]
		public decimal? PreviousOpen;
		/// <summary>
		/// 전일고가
		/// </summary>
		[JsonProperty("pre_high_pric")]
		public decimal? PreviousHigh;
		/// <summary>
		/// 전일저가
		/// </summary>
		[JsonProperty("pre_low_pric")]
		public decimal? PreviousLow;
		/// <summary>
		/// 전일종가
		/// </summary>
		[JsonProperty("base_close_pric")]
		public decimal? PreviousClose;
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
		/// 매매수량단위
		/// </summary>
		[JsonProperty("trde_qty_unit")]
		public string? TradeQuantityUnit;
		/// <summary>
		/// 불확실성
		/// </summary>
		[JsonProperty("uncert_lv")]
		public string? UncertaintyLevel;
		/// <summary>
		/// 경쟁우위
		/// </summary>
		[JsonProperty("comp_adv_tp")]
		public string? CompetitiveAdvantageType;
		/// <summary>
		/// 통화단위
		/// </summary>
		[JsonProperty("curr_unit")]
		public string? CurrencyUnit;
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
		/// 재무건전성
		/// </summary>
		[JsonProperty("fnc_health_lv")]
		public string? FinancialHealthLevel;
		/// <summary>
		/// 거래정지여부
		/// </summary>
		[JsonProperty("trd_susp_tp")]
		public string? TradeSuspensionType;
		/// <summary>
		/// 환율
		/// </summary>
		[JsonProperty("base_exrt")]
		public decimal? BaseExchangeRate;
	}

	/// <summary>
	/// | usa20150 | 미국주식 상세 체결내역
	/// </summary>
	public record KiwoomUsStockMarketConditionGetDetailedTrades
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockMarketConditionDetailedTradeItem>? Items;
	}

	public record KiwoomUsStockMarketConditionDetailedTradeItem
	{
		/// <summary>
		/// 현재가, 종가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
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
		[JsonProperty("trde_qty")]
		public KiwoomDecimal? Volume;
		/// <summary>
		/// 체결시간
		/// </summary>
		[JsonProperty("cntr_tm")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? TradeTime;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? ChangeSign;
	}

	/// <summary>
	/// | usa20151 | 미국주식 일별 체결내역
	/// </summary>
	public record KiwoomUsStockMarketConditionGetDailyTrades
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockMarketConditionDailyTradeItem>? Items;
	}

	public record KiwoomUsStockMarketConditionDailyTradeItem
	{
		/// <summary>
		/// 일자
		/// </summary>
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		/// <summary>
		/// 현재가, 종가
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
	}

	/// <summary>
	/// | usa20590 | 미국주식 일별주가
	/// </summary>
	public record KiwoomUsStockMarketConditionGetDailyPrices
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockMarketConditionDailyPriceItem>? Items;
	}

	public record KiwoomUsStockMarketConditionDailyPriceItem
	{
		/// <summary>
		/// 일자
		/// </summary>
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		/// <summary>
		/// 현재가(종가)
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
		/// 누적금액
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
		/// 기준가
		/// </summary>
		[JsonProperty("base_pric")]
		public decimal? BasePrice;
		/// <summary>
		/// 기준가대비 시가등락율
		/// </summary>
		[JsonProperty("base_open_flu_rt")]
		public KiwoomDecimal? BaseOpenChangeRate;
		/// <summary>
		/// 기준가대비 고가등락율
		/// </summary>
		[JsonProperty("base_high_flu_rt")]
		public KiwoomDecimal? BaseHighChangeRate;
		/// <summary>
		/// 기준가대비 저가등락율
		/// </summary>
		[JsonProperty("base_low_flu_rt")]
		public KiwoomDecimal? BaseLowChangeRate;
	}
}
