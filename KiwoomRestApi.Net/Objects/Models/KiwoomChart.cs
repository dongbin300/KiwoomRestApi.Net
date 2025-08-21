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

}
