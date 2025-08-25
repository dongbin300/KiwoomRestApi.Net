using KiwoomRestApi.Net.Converters;
using KiwoomRestApi.Net.Enums.Chart;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models
{
	public record KiwoomChartGetInvestorInstitutionCharts
	{
		[JsonProperty("stk_invsr_orgn_chart")]
		public IEnumerable<KiwoomChartGetInvestorInstitutionChartItem>? Items;
	}
	public record KiwoomChartGetInvestorInstitutionChartItem
	{
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("pred_pre")]
		public decimal? PriceDifference;
		[JsonProperty("acc_trde_prica")]
		public decimal? AccumulatedTradeAmount;
		[JsonProperty("ind_invsr")]
		public decimal? IndividualInvestor;
		[JsonProperty("frgnr_invsr")]
		public decimal? ForeignerInvestor;
		[JsonProperty("orgn")]
		public decimal? Institution;
		[JsonProperty("fnnc_invt")]
		public decimal? FinancialInvestment;
		[JsonProperty("insrnc")]
		public decimal? Insurance;
		[JsonProperty("invtrt")]
		public decimal? InvestmentTrust;
		[JsonProperty("etc_fnnc")]
		public decimal? OtherFinancial;
		[JsonProperty("bank")]
		public decimal? Bank;
		[JsonProperty("penfnd_etc")]
		public decimal? PensionFundEtc;
		[JsonProperty("samo_fund")]
		public decimal? PrivateEquityFund;
		[JsonProperty("natn")]
		public decimal? Nation;
		[JsonProperty("etc_corp")]
		public decimal? OtherCorporation;
		[JsonProperty("natfor")]
		public decimal? DomesticForeign;
	}

	public record KiwoomChartGetIntradayInvestorTradeCharts
	{
		[JsonProperty("opmr_invsr_trde_chart")]
		public IEnumerable<KiwoomChartGetIntradayInvestorTradeChartItem>? Items;
	}
	public record KiwoomChartGetIntradayInvestorTradeChartItem
	{
		[JsonProperty("tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? Time;
		[JsonProperty("frgnr_invsr")]
		public decimal? ForeignerInvestor;
		[JsonProperty("orgn")]
		public decimal? Institution;
		[JsonProperty("invtrt")]
		public decimal? InvestmentTrust;
		[JsonProperty("insrnc")]
		public decimal? Insurance;
		[JsonProperty("bank")]
		public decimal? Bank;
		[JsonProperty("penfnd_etc")]
		public decimal? PensionFundEtc;
		[JsonProperty("etc_corp")]
		public decimal? OtherCorporation;
		[JsonProperty("natn")]
		public decimal? Nation;
	}

	public record KiwoomChartGetTickCharts
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("last_tic_cnt")]
		public decimal? LastTickCount;
		[JsonProperty("stk_tic_chart_qry")]
		public IEnumerable<KiwoomChartGetTickChartItem>? Items;
	}
	public record KiwoomChartGetMinuteCharts
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_min_pole_chart_qry")]
		public IEnumerable<KiwoomChartGetTickChartItem>? Items;
	}
	public record KiwoomChartGetTickChartItem
	{
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("trde_qty")]
		public decimal? TradeVolume;
		[JsonProperty("cntr_tm")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? ContractTime;
		[JsonProperty("open_pric")]
		public decimal? OpenPrice;
		[JsonProperty("high_pric")]
		public decimal? HighPrice;
		[JsonProperty("low_pric")]
		public decimal? LowPrice;
		[JsonProperty("upd_stkpc_tp")]
		[JsonConverter(typeof(KiwoomFlagsEnumConverter<KiwoomChartUpdateStockPriceType>))]
		public KiwoomChartUpdateStockPriceType AdjustedStockPriceType;
		[JsonProperty("upd_rt")]
		public decimal? AdjustmentRatio;
		[JsonProperty("bic_inds_tp")]
		public string? MajorIndustryType;
		[JsonProperty("sm_inds_tp")]
		public string? MinorIndustryType;
		[JsonProperty("stk_infr")]
		public string? StockInformation;
		[JsonProperty("upd_stkpc_event")]
		public string? AdjustedStockPriceEvent;
		[JsonProperty("pred_close_pric")]
		public decimal? PreviousClosePrice;
	}

	public record KiwoomChartGetDailyCharts
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_dt_pole_chart_qry")]
		public IEnumerable<KiwoomChartGetChartItem>? Items;
	}
	public record KiwoomChartGetWeeklyCharts
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_stk_pole_chart_qry")]
		public IEnumerable<KiwoomChartGetChartItem>? Items;
	}
	public record KiwoomChartGetMonthlyCharts
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_mth_pole_chart_qry")]
		public IEnumerable<KiwoomChartGetChartItem>? Items;
	}
	public record KiwoomChartGetYearlyCharts
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_yr_pole_chart_qry")]
		public IEnumerable<KiwoomChartGetChartItem>? Items;
	}
	public record KiwoomChartGetChartItem
	{
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("trde_qty")]
		public decimal? TradeVolume;
		[JsonProperty("trde_prica")]
		public decimal? TradeAmount;
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		[JsonProperty("open_pric")]
		public decimal? OpenPrice;
		[JsonProperty("high_pric")]
		public decimal? HighPrice;
		[JsonProperty("low_pric")]
		public decimal? LowPrice;
		[JsonProperty("upd_stkpc_tp")]
		[JsonConverter(typeof(KiwoomFlagsEnumConverter<KiwoomChartUpdateStockPriceType>))]
		public KiwoomChartUpdateStockPriceType AdjustedStockPriceType;
		[JsonProperty("upd_rt")]
		public decimal? AdjustmentRatio;
		[JsonProperty("bic_inds_tp")]
		public string? MajorIndustryType;
		[JsonProperty("sm_inds_tp")]
		public string? MinorIndustryType;
		[JsonProperty("stk_infr")]
		public string? StockInformation;
		[JsonProperty("upd_stkpc_event")]
		public string? AdjustedStockPriceEvent;
		[JsonProperty("pred_close_pric")]
		public decimal? PreviousClosePrice;
	}

	public record KiwoomChartGetIndustryTickCharts
	{
		[JsonProperty("inds_cd")]
		public string? IndustryCode;
		[JsonProperty("inds_tic_chart_qry")]
		public IEnumerable<KiwoomChartGetIndustryTickChartItem>? Items;
	}
	public record KiwoomChartGetIndustryMinuteCharts
	{
		[JsonProperty("inds_cd")]
		public string? IndustryCode;
		[JsonProperty("inds_min_pole_qry")]
		public IEnumerable<KiwoomChartGetIndustryTickChartItem>? Items;
	}
	public record KiwoomChartGetIndustryTickChartItem
	{
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("trde_qty")]
		public decimal? TradeVolume;
		[JsonProperty("cntr_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? ContractTime;
		[JsonProperty("open_pric")]
		public decimal? OpenPrice;
		[JsonProperty("high_pric")]
		public decimal? HighPrice;
		[JsonProperty("low_pric")]
		public decimal? LowPrice;
		[JsonProperty("bic_inds_tp")]
		public string? MajorIndustryType;
		[JsonProperty("sm_inds_tp")]
		public string? MinorIndustryType;
		[JsonProperty("stk_infr")]
		public string? StockInformation;
		[JsonProperty("pred_close_pric")]
		public decimal? PreviousClosePrice;
	}

	public record KiwoomChartGetIndustryDailyCharts
	{
		[JsonProperty("inds_cd")]
		public string? IndustryCode;
		[JsonProperty("inds_dt_pole_qry")]
		public IEnumerable<KiwoomChartGetIndustryChartItem>? Items;
	}
	public record KiwoomChartGetIndustryWeeklyCharts
	{
		[JsonProperty("inds_cd")]
		public string? IndustryCode;
		[JsonProperty("inds_stk_pole_qry")]
		public IEnumerable<KiwoomChartGetIndustryChartItem>? Items;
	}
	public record KiwoomChartGetIndustryMonthlyCharts
	{
		[JsonProperty("inds_cd")]
		public string? IndustryCode;
		[JsonProperty("inds_mth_pole_qry")]
		public IEnumerable<KiwoomChartGetIndustryChartItem>? Items;
	}
	public record KiwoomChartGetIndustryYearlyCharts
	{
		[JsonProperty("inds_cd")]
		public string? IndustryCode;
		[JsonProperty("inds_yr_pole_qry")]
		public IEnumerable<KiwoomChartGetIndustryChartItem>? Items;
	}
	public record KiwoomChartGetIndustryChartItem
	{
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("trde_qty")]
		public decimal? TradeVolume;
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		[JsonProperty("open_pric")]
		public decimal? OpenPrice;
		[JsonProperty("high_pric")]
		public decimal? HighPrice;
		[JsonProperty("low_pric")]
		public decimal? LowPrice;
		[JsonProperty("trde_prica")]
		public decimal? TradeAmount;
		[JsonProperty("bic_inds_tp")]
		public string? MajorIndustryType;
		[JsonProperty("sm_inds_tp")]
		public string? MinorIndustryType;
		[JsonProperty("stk_infr")]
		public string? StockInformation;
		[JsonProperty("pred_close_pric")]
		public decimal? PreviousClosePrice;
	}
}