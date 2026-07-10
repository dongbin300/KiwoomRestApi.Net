using KiwoomRestApi.Net.Converters;
using KiwoomRestApi.Net.Objects.Commons;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models.UsStock
{
	public record KiwoomUsStockChartGetTickCharts
	{
		/// <summary>
		/// 미국주식 틱 차트 리스트
		/// </summary>
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockChartGetTickChartItem>? Items;
	}

	public record KiwoomUsStockChartGetMinuteCharts
	{
		/// <summary>
		/// 미국주식 분 차트 리스트
		/// </summary>
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockChartGetTickChartItem>? Items;
	}

	public record KiwoomUsStockChartGetTickChartItem
	{
		/// <summary>
		/// 현재가(종가)
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? Volume;
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
		/// 체결시간
		/// </summary>
		[JsonProperty("cntr_tm")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? TradeTime;
		/// <summary>
		/// 영업일자
		/// </summary>
		[JsonProperty("bus_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? BusinessDate;
		/// <summary>
		/// 수정주가구분
		/// </summary>
		[JsonProperty("upd_stkpc_tp")]
		public string? UpdatedStockPriceType;
		/// <summary>
		/// 수정비율
		/// </summary>
		[JsonProperty("upd_rt")]
		public string? UpdateRate;
	}

	public record KiwoomUsStockChartGetDailyCharts
	{
		/// <summary>
		/// 미국주식 일 차트 리스트
		/// </summary>
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockChartGetDailyChartItem>? Items;
	}

	public record KiwoomUsStockChartGetDailyChartItem
	{
		/// <summary>
		/// 현재가(종가)
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
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
		/// 일자
		/// </summary>
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		/// <summary>
		/// 수정주가구분
		/// </summary>
		[JsonProperty("upd_stkpc_tp")]
		public string? UpdatedStockPriceType;
		/// <summary>
		/// 수정비율
		/// </summary>
		[JsonProperty("upd_rt")]
		public string? UpdateRate;
	}

	public record KiwoomUsStockChartGetWeeklyCharts
	{
		/// <summary>
		/// 미국주식 주 차트 리스트
		/// </summary>
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockChartGetChartItem>? Items;
	}

	public record KiwoomUsStockChartGetMonthlyCharts
	{
		/// <summary>
		/// 미국주식 월 차트 리스트
		/// </summary>
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockChartGetChartItem>? Items;
	}

	public record KiwoomUsStockChartGetYearlyCharts
	{
		/// <summary>
		/// 미국주식 년 차트 리스트
		/// </summary>
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockChartGetChartItem>? Items;
	}

	public record KiwoomUsStockChartGetQuarterlyCharts
	{
		/// <summary>
		/// 미국주식 분기 차트 리스트
		/// </summary>
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockChartGetChartItem>? Items;
	}

	public record KiwoomUsStockChartGetChartItem
	{
		/// <summary>
		/// 현재가(종가)
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
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
		/// 일자
		/// </summary>
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		/// <summary>
		/// 수정주가구분
		/// </summary>
		[JsonProperty("upd_stkpc_tp")]
		public string? UpdatedStockPriceType;
		/// <summary>
		/// 수정비율
		/// </summary>
		[JsonProperty("upd_rt")]
		public string? UpdateRate;
	}
}
