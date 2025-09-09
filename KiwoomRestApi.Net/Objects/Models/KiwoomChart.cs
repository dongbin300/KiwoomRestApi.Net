using KiwoomRestApi.Net.Converters;
using KiwoomRestApi.Net.Enums.Chart;
using KiwoomRestApi.Net.Objects.Commons;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models
{
	public record KiwoomChartGetInvestorInstitutionCharts
	{
		/// <summary>
		/// 종목별투자자기관별차트 리스트
		/// </summary>
		[JsonProperty("stk_invsr_orgn_chart")]
		public IEnumerable<KiwoomChartGetInvestorInstitutionChartItem>? Items;
	}
	public record KiwoomChartGetInvestorInstitutionChartItem
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
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 누적거래대금
		/// </summary>
		[JsonProperty("acc_trde_prica")]
		public decimal? AccumulatedTransactionAmount;
		/// <summary>
		/// 개인투자자
		/// </summary>
		[JsonProperty("ind_invsr")]
		public KiwoomDecimal? RetailInvestor;
		/// <summary>
		/// 외국인투자자
		/// </summary>
		[JsonProperty("frgnr_invsr")]
		public KiwoomDecimal? ForeignInvestor;
		/// <summary>
		/// 기관계
		/// </summary>
		[JsonProperty("orgn")]
		public KiwoomDecimal? Institution;
		/// <summary>
		/// 금융투자
		/// </summary>
		[JsonProperty("fnnc_invt")]
		public KiwoomDecimal? FinancialInvestment;
		/// <summary>
		/// 보험
		/// </summary>
		[JsonProperty("insrnc")]
		public KiwoomDecimal? Insurance;
		/// <summary>
		/// 투신
		/// </summary>
		[JsonProperty("invtrt")]
		public KiwoomDecimal? InvestmentTrust;
		/// <summary>
		/// 기타금융
		/// </summary>
		[JsonProperty("etc_fnnc")]
		public KiwoomDecimal? OtherFinancials;
		/// <summary>
		/// 은행
		/// </summary>
		[JsonProperty("bank")]
		public KiwoomDecimal? Bank;
		/// <summary>
		/// 연기금등
		/// </summary>
		[JsonProperty("penfnd_etc")]
		public KiwoomDecimal? PensionFundEtc;
		/// <summary>
		/// 사모펀드
		/// </summary>
		[JsonProperty("samo_fund")]
		public KiwoomDecimal? PrivateFund;
		/// <summary>
		/// 국가
		/// </summary>
		[JsonProperty("natn")]
		public KiwoomDecimal? Nation;
		/// <summary>
		/// 기타법인
		/// </summary>
		[JsonProperty("etc_corp")]
		public KiwoomDecimal? OtherCorporations;
		/// <summary>
		/// 내외국인
		/// </summary>
		[JsonProperty("natfor")]
		public KiwoomDecimal? DomesticForeign;
	}

	public record KiwoomChartGetIntradayInvestorTradeCharts
	{
		/// <summary>
		/// 장중투자자별매매차트 리스트
		/// </summary>
		[JsonProperty("opmr_invsr_trde_chart")]
		public IEnumerable<KiwoomChartGetIntradayInvestorTradeChartItem>? Items;
	}
	public record KiwoomChartGetIntradayInvestorTradeChartItem
	{
		/// <summary>
		/// 시간
		/// </summary>
		[JsonProperty("tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? Time;
		/// <summary>
		/// 외국인투자자
		/// </summary>
		[JsonProperty("frgnr_invsr")]
		public KiwoomDecimal? ForeignInvestor;
		/// <summary>
		/// 기관계
		/// </summary>
		[JsonProperty("orgn")]
		public KiwoomDecimal? Institution;
		/// <summary>
		/// 투신
		/// </summary>
		[JsonProperty("invtrt")]
		public KiwoomDecimal? InvestmentTrust;
		/// <summary>
		/// 보험
		/// </summary>
		[JsonProperty("insrnc")]
		public KiwoomDecimal? Insurance;
		/// <summary>
		/// 은행
		/// </summary>
		[JsonProperty("bank")]
		public KiwoomDecimal? Bank;
		/// <summary>
		/// 연기금등
		/// </summary>
		[JsonProperty("penfnd_etc")]
		public KiwoomDecimal? PensionFundEtc;
		/// <summary>
		/// 기타법인
		/// </summary>
		[JsonProperty("etc_corp")]
		public KiwoomDecimal? OtherCorporations;
		/// <summary>
		/// 국가
		/// </summary>
		[JsonProperty("natn")]
		public KiwoomDecimal? Nation;
	}

	public record KiwoomChartGetTickCharts
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 마지막틱갯수
		/// </summary>
		[JsonProperty("last_tic_cnt")]
		public decimal? LastTickCount;
		/// <summary>
		/// 주식틱차트조회 리스트
		/// </summary>
		[JsonProperty("stk_tic_chart_qry")]
		public IEnumerable<KiwoomChartGetTickChartItem>? Items;
	}
	public record KiwoomChartGetMinuteCharts
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 주식분봉차트조회 리스트
		/// </summary>
		[JsonProperty("stk_min_pole_chart_qry")]
		public IEnumerable<KiwoomChartGetTickChartItem>? Items;
	}
	public record KiwoomChartGetTickChartItem
	{
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 체결시간
		/// </summary>
		[JsonProperty("cntr_tm")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? TradeTime;
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
		/// 수정주가구분 - 1:유상증자, 2:무상증자, 4:배당락, 8:액면분할, 16:액면병합, 32:기업합병, 64:감자, 256:권리락
		/// </summary>
		[JsonProperty("upd_stkpc_tp")]
		[JsonConverter(typeof(KiwoomFlagsEnumConverter<KiwoomChartAdjustedPriceType>))]
		public KiwoomChartAdjustedPriceType AdjustedPriceType;
		/// <summary>
		/// 수정비율
		/// </summary>
		[JsonProperty("upd_rt")]
		public KiwoomDecimal? AdjustmentRate;
		/// <summary>
		/// 대업종구분
		/// </summary>
		[JsonProperty("bic_inds_tp")]
		public string? MajorIndustryType;
		/// <summary>
		/// 소업종구분
		/// </summary>
		[JsonProperty("sm_inds_tp")]
		public string? MinorIndustryType;
		/// <summary>
		/// 종목정보
		/// </summary>
		[JsonProperty("stk_infr")]
		public string? StockInfo;
		/// <summary>
		/// 수정주가이벤트
		/// </summary>
		[JsonProperty("upd_stkpc_event")]
		public string? AdjustedPriceEvent;
		/// <summary>
		/// 전일종가
		/// </summary>
		[JsonProperty("pred_close_pric")]
		public decimal? PreviousDayClose;
	}

	public record KiwoomChartGetDailyCharts
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 주식일봉차트조회 리스트
		/// </summary>
		[JsonProperty("stk_dt_pole_chart_qry")]
		public IEnumerable<KiwoomChartGetChartItem>? Items;
	}
	public record KiwoomChartGetWeeklyCharts
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 주식주봉차트조회 리스트
		/// </summary>
		[JsonProperty("stk_stk_pole_chart_qry")]
		public IEnumerable<KiwoomChartGetChartItem>? Items;
	}
	public record KiwoomChartGetMonthlyCharts
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 주식월봉차트조회 리스트
		/// </summary>
		[JsonProperty("stk_mth_pole_chart_qry")]
		public IEnumerable<KiwoomChartGetChartItem>? Items;
	}
	public record KiwoomChartGetYearlyCharts
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 주식년봉차트조회 리스트
		/// </summary>
		[JsonProperty("stk_yr_pole_chart_qry")]
		public IEnumerable<KiwoomChartGetChartItem>? Items;
	}
	public record KiwoomChartGetChartItem
	{
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
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
		/// 일자
		/// </summary>
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
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
		/// 수정주가구분 - 1:유상증자, 2:무상증자, 4:배당락, 8:액면분할, 16:액면병합, 32:기업합병, 64:감자, 256:권리락
		/// </summary>
		[JsonProperty("upd_stkpc_tp")]
		[JsonConverter(typeof(KiwoomFlagsEnumConverter<KiwoomChartAdjustedPriceType>))]
		public KiwoomChartAdjustedPriceType AdjustedPriceType;
		/// <summary>
		/// 수정비율
		/// </summary>
		[JsonProperty("upd_rt")]
		public KiwoomDecimal? AdjustmentRate;
		/// <summary>
		/// 대업종구분
		/// </summary>
		[JsonProperty("bic_inds_tp")]
		public string? MajorIndustryType;
		/// <summary>
		/// 소업종구분
		/// </summary>
		[JsonProperty("sm_inds_tp")]
		public string? MinorIndustryType;
		/// <summary>
		/// 종목정보
		/// </summary>
		[JsonProperty("stk_infr")]
		public string? StockInfo;
		/// <summary>
		/// 수정주가이벤트
		/// </summary>
		[JsonProperty("upd_stkpc_event")]
		public string? AdjustedPriceEvent;
		/// <summary>
		/// 전일종가
		/// </summary>
		[JsonProperty("pred_close_pric")]
		public decimal? PreviousDayClose;
	}

	public record KiwoomChartGetIndustryTickCharts
	{
		/// <summary>
		/// 업종코드
		/// </summary>
		[JsonProperty("inds_cd")]
		public string? IndustryCode;
		/// <summary>
		/// 업종틱차트조회 리스트
		/// </summary>
		[JsonProperty("inds_tic_chart_qry")]
		public IEnumerable<KiwoomChartGetIndustryTickChartItem>? Items;
	}
	public record KiwoomChartGetIndustryMinuteCharts
	{
		/// <summary>
		/// 업종코드
		/// </summary>
		[JsonProperty("inds_cd")]
		public string? IndustryCode;
		/// <summary>
		/// 업종분봉조회 리스트
		/// </summary>
		[JsonProperty("inds_min_pole_qry")]
		public IEnumerable<KiwoomChartGetIndustryTickChartItem>? Items;
	}
	public record KiwoomChartGetIndustryTickChartItem
	{
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 체결시간
		/// </summary>
		[JsonProperty("cntr_tm")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? TradeTime;
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
		/// 대업종구분
		/// </summary>
		[JsonProperty("bic_inds_tp")]
		public string? MajorIndustryType;
		/// <summary>
		/// 소업종구분
		/// </summary>
		[JsonProperty("sm_inds_tp")]
		public string? MinorIndustryType;
		/// <summary>
		/// 종목정보
		/// </summary>
		[JsonProperty("stk_infr")]
		public string? StockInfo;
		/// <summary>
		/// 전일종가
		/// </summary>
		[JsonProperty("pred_close_pric")]
		public decimal? PreviousDayClose;
	}

	public record KiwoomChartGetIndustryDailyCharts
	{
		/// <summary>
		/// 업종코드
		/// </summary>
		[JsonProperty("inds_cd")]
		public string? IndustryCode;
		/// <summary>
		/// 업종일봉조회 리스트
		/// </summary>
		[JsonProperty("inds_dt_pole_qry")]
		public IEnumerable<KiwoomChartGetIndustryChartItem>? Items;
	}
	public record KiwoomChartGetIndustryWeeklyCharts
	{
		/// <summary>
		/// 업종코드
		/// </summary>
		[JsonProperty("inds_cd")]
		public string? IndustryCode;
		/// <summary>
		/// 업종주봉조회 리스트
		/// </summary>
		[JsonProperty("inds_stk_pole_qry")]
		public IEnumerable<KiwoomChartGetIndustryChartItem>? Items;
	}
	public record KiwoomChartGetIndustryMonthlyCharts
	{
		/// <summary>
		/// 업종코드
		/// </summary>
		[JsonProperty("inds_cd")]
		public string? IndustryCode;
		/// <summary>
		/// 업종월봉조회 리스트
		/// </summary>
		[JsonProperty("inds_mth_pole_qry")]
		public IEnumerable<KiwoomChartGetIndustryChartItem>? Items;
	}
	public record KiwoomChartGetIndustryYearlyCharts
	{
		/// <summary>
		/// 업종코드
		/// </summary>
		[JsonProperty("inds_cd")]
		public string? IndustryCode;
		/// <summary>
		/// 업종년봉조회 리스트
		/// </summary>
		[JsonProperty("inds_yr_pole_qry")]
		public IEnumerable<KiwoomChartGetIndustryChartItem>? Items;
	}
	public record KiwoomChartGetIndustryChartItem
	{
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 일자
		/// </summary>
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
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
		/// 거래대금
		/// </summary>
		[JsonProperty("trde_prica")]
		public decimal? TransactionAmount;
		/// <summary>
		/// 대업종구분
		/// </summary>
		[JsonProperty("bic_inds_tp")]
		public string? MajorIndustryType;
		/// <summary>
		/// 소업종구분
		/// </summary>
		[JsonProperty("sm_inds_tp")]
		public string? MinorIndustryType;
		/// <summary>
		/// 종목정보
		/// </summary>
		[JsonProperty("stk_infr")]
		public string? StockInfo;
		/// <summary>
		/// 전일종가
		/// </summary>
		[JsonProperty("pred_close_pric")]
		public decimal? PreviousDayClose;
	}
}