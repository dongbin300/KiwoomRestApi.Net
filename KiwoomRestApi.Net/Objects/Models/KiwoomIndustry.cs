using KiwoomRestApi.Net.Converters;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models
{
	public record KiwoomIndustryGetProgramTransactionInfo
	{
		/// <summary>
		/// 차익위탁매도수량
		/// </summary>
		[JsonProperty("dfrt_trst_sell_qty")]
		public decimal? ArbitrageConsignmentSellQuantity;
		/// <summary>
		/// 차익위탁매도금액
		/// </summary>
		[JsonProperty("dfrt_trst_sell_amt")]
		public decimal? ArbitrageConsignmentSellAmount;
		/// <summary>
		/// 차익위탁매수수량
		/// </summary>
		[JsonProperty("dfrt_trst_buy_qty")]
		public decimal? ArbitrageConsignmentBuyQuantity;
		/// <summary>
		/// 차익위탁매수금액
		/// </summary>
		[JsonProperty("dfrt_trst_buy_amt")]
		public decimal? ArbitrageConsignmentBuyAmount;
		/// <summary>
		/// 차익위탁순매수수량
		/// </summary>
		[JsonProperty("dfrt_trst_netprps_qty")]
		public decimal? ArbitrageConsignmentNetBuyQuantity;
		/// <summary>
		/// 차익위탁순매수금액
		/// </summary>
		[JsonProperty("dfrt_trst_netprps_amt")]
		public decimal? ArbitrageConsignmentNetBuyAmount;
		/// <summary>
		/// 비차익위탁매도수량
		/// </summary>
		[JsonProperty("ndiffpro_trst_sell_qty")]
		public decimal? NonArbitrageConsignmentSellQuantity;
		/// <summary>
		/// 비차익위탁매도금액
		/// </summary>
		[JsonProperty("ndiffpro_trst_sell_amt")]
		public decimal? NonArbitrageConsignmentSellAmount;
		/// <summary>
		/// 비차익위탁매수수량
		/// </summary>
		[JsonProperty("ndiffpro_trst_buy_qty")]
		public decimal? NonArbitrageConsignmentBuyQuantity;
		/// <summary>
		/// 비차익위탁매수금액
		/// </summary>
		[JsonProperty("ndiffpro_trst_buy_amt")]
		public decimal? NonArbitrageConsignmentBuyAmount;
		/// <summary>
		/// 비차익위탁순매수수량
		/// </summary>
		[JsonProperty("ndiffpro_trst_netprps_qty")]
		public decimal? NonArbitrageConsignmentNetBuyQuantity;
		/// <summary>
		/// 비차익위탁순매수금액
		/// </summary>
		[JsonProperty("ndiffpro_trst_netprps_amt")]
		public decimal? NonArbitrageConsignmentNetBuyAmount;
		/// <summary>
		/// 전체차익위탁매도수량
		/// </summary>
		[JsonProperty("all_dfrt_trst_sell_qty")]
		public decimal? TotalArbitrageConsignmentSellQuantity;
		/// <summary>
		/// 전체차익위탁매도금액
		/// </summary>
		[JsonProperty("all_dfrt_trst_sell_amt")]
		public decimal? TotalArbitrageConsignmentSellAmount;
		/// <summary>
		/// 전체차익위탁매수수량
		/// </summary>
		[JsonProperty("all_dfrt_trst_buy_qty")]
		public decimal? TotalArbitrageConsignmentBuyQuantity;
		/// <summary>
		/// 전체차익위탁매수금액
		/// </summary>
		[JsonProperty("all_dfrt_trst_buy_amt")]
		public decimal? TotalArbitrageConsignmentBuyAmount;
		/// <summary>
		/// 전체차익위탁순매수수량
		/// </summary>
		[JsonProperty("all_dfrt_trst_netprps_qty")]
		public decimal? TotalArbitrageConsignmentNetBuyQuantity;
		/// <summary>
		/// 전체차익위탁순매수금액
		/// </summary>
		[JsonProperty("all_dfrt_trst_netprps_amt")]
		public decimal? TotalArbitrageConsignmentNetBuyAmount;
	}

	public record KiwoomIndustryGetInvestorNetBuys
	{
		/// <summary>
		/// 업종별순매수
		/// </summary>
		[JsonProperty("inds_netprps")]
		public IEnumerable<KiwoomIndustryGetInvestorNetBuyItem>? Items;
	}
	public record KiwoomIndustryGetInvestorNetBuyItem
	{
		/// <summary>
		/// 업종코드
		/// </summary>
		[JsonProperty("inds_cd")]
		public string? IndustryCode;
		/// <summary>
		/// 업종명
		/// </summary>
		[JsonProperty("inds_nm")]
		public string? IndustryName;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		/// <summary>
		/// 대비부호
		/// </summary>
		[JsonProperty("pre_smbol")]
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
		/// 증권순매수
		/// </summary>
		[JsonProperty("sc_netprps")]
		public decimal? SecuritiesNetBuy;
		/// <summary>
		/// 보험순매수
		/// </summary>
		[JsonProperty("insrnc_netprps")]
		public decimal? InsuranceNetBuy;
		/// <summary>
		/// 투신순매수
		/// </summary>
		[JsonProperty("invtrt_netprps")]
		public decimal? InvestmentTrustNetBuy;
		/// <summary>
		/// 은행순매수
		/// </summary>
		[JsonProperty("bank_netprps")]
		public decimal? BankNetBuy;
		/// <summary>
		/// 종신금순매수
		/// </summary>
		[JsonProperty("jnsinkm_netprps")]
		public decimal? PensionNetBuy;
		/// <summary>
		/// 기금순매수
		/// </summary>
		[JsonProperty("endw_netprps")]
		public decimal? FundNetBuy;
		/// <summary>
		/// 기타법인순매수
		/// </summary>
		[JsonProperty("etc_corp_netprps")]
		public decimal? OtherCorporationsNetBuy;
		/// <summary>
		/// 개인순매수
		/// </summary>
		[JsonProperty("ind_netprps")]
		public decimal? RetailNetBuy;
		/// <summary>
		/// 외국인순매수
		/// </summary>
		[JsonProperty("frgnr_netprps")]
		public decimal? ForeignNetBuy;
		/// <summary>
		/// 내국인대우외국인순매수
		/// </summary>
		[JsonProperty("native_trmt_frgnr_netprps")]
		public decimal? DomesticTreatedForeignNetBuy;
		/// <summary>
		/// 국가순매수
		/// </summary>
		[JsonProperty("natn_netprps")]
		public decimal? NationNetBuy;
		/// <summary>
		/// 사모펀드순매수
		/// </summary>
		[JsonProperty("samo_fund_netprps")]
		public decimal? PrivateFundNetBuy;
		/// <summary>
		/// 기관계순매수
		/// </summary>
		[JsonProperty("orgn_netprps")]
		public decimal? InstitutionNetBuy;
	}

	public record KiwoomIndustryGetCurrentPrices
	{
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
		/// 거래대금
		/// </summary>
		[JsonProperty("trde_prica")]
		public decimal? TransactionAmount;
		/// <summary>
		/// 거래형성종목수
		/// </summary>
		[JsonProperty("trde_frmatn_stk_num")]
		public decimal? ActiveTradingStockCount;
		/// <summary>
		/// 거래형성비율
		/// </summary>
		[JsonProperty("trde_frmatn_rt")]
		public decimal? ActiveTradingRate;
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
		/// 상한
		/// </summary>
		[JsonProperty("upl")]
		public decimal? UpperLimit;
		/// <summary>
		/// 상승
		/// </summary>
		[JsonProperty("rising")]
		public decimal? Up;
		/// <summary>
		/// 보합
		/// </summary>
		[JsonProperty("stdns")]
		public decimal? Flat;
		/// <summary>
		/// 하락
		/// </summary>
		[JsonProperty("fall")]
		public decimal? Down;
		/// <summary>
		/// 하한
		/// </summary>
		[JsonProperty("lst")]
		public decimal? LowerLimit;
		/// <summary>
		/// 52주최고가
		/// </summary>
		[JsonProperty("52wk_hgst_pric")]
		public decimal? FiftyTwoWeekHigh;
		/// <summary>
		/// 52주최고가일
		/// </summary>
		[JsonProperty("52wk_hgst_pric_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? FiftyTwoWeekHighDate;
		/// <summary>
		/// 52주최고가대비율
		/// </summary>
		[JsonProperty("52wk_hgst_pric_pre_rt")]
		public decimal? FiftyTwoWeekHighRate;
		/// <summary>
		/// 52주최저가
		/// </summary>
		[JsonProperty("52wk_lwst_pric")]
		public decimal? FiftyTwoWeekLow;
		/// <summary>
		/// 52주최저가일
		/// </summary>
		[JsonProperty("52wk_lwst_pric_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? FiftyTwoWeekLowDate;
		/// <summary>
		/// 52주최저가대비율
		/// </summary>
		[JsonProperty("52wk_lwst_pric_pre_rt")]
		public decimal? FiftyTwoWeekLowRate;
		/// <summary>
		/// 업종현재가_시간별
		/// </summary>
		[JsonProperty("inds_cur_prc_tm")]
		public IEnumerable<KiwoomIndustryGetCurrentPriceItem>? Items;
	}
	public record KiwoomIndustryGetCurrentPriceItem
	{
		/// <summary>
		/// 시간n
		/// </summary>
		[JsonProperty("tm_n")]
		public string? Time;
		/// <summary>
		/// 현재가n
		/// </summary>
		[JsonProperty("cur_prc_n")]
		public decimal? CurrentPrice;
		/// <summary>
		/// 전일대비기호n
		/// </summary>
		[JsonProperty("pred_pre_sig_n")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비n
		/// </summary>
		[JsonProperty("pred_pre_n")]
		public decimal? Change;
		/// <summary>
		/// 등락률n
		/// </summary>
		[JsonProperty("flu_rt_n")]
		public decimal? ChangeRate;
		/// <summary>
		/// 거래량n
		/// </summary>
		[JsonProperty("trde_qty_n")]
		public decimal? Volume;
		/// <summary>
		/// 누적거래량n
		/// </summary>
		[JsonProperty("acc_trde_qty_n")]
		public decimal? AccumulatedVolume;
	}

	public record KiwoomIndustryGetPrices
	{
		/// <summary>
		/// 업종별주가
		/// </summary>
		[JsonProperty("inds_stkpc")]
		public IEnumerable<KiwoomIndustryGetPriceItem>? Items;
	}
	public record KiwoomIndustryGetPriceItem
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
	}

	public record KiwoomIndustryGetAllIndustryIndices
	{
		/// <summary>
		/// 전업종지수
		/// </summary>
		[JsonProperty("all_inds_idex")]
		public IEnumerable<KiwoomIndustryGetAllIndustryIndexItem>? Items;
	}
	public record KiwoomIndustryGetAllIndustryIndexItem
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
		/// 비중
		/// </summary>
		[JsonProperty("wght")]
		public decimal? Weight;
		/// <summary>
		/// 거래대금
		/// </summary>
		[JsonProperty("trde_prica")]
		public decimal? TransactionAmount;
		/// <summary>
		/// 상한
		/// </summary>
		[JsonProperty("upl")]
		public decimal? UpperLimit;
		/// <summary>
		/// 상승
		/// </summary>
		[JsonProperty("rising")]
		public decimal? Up;
		/// <summary>
		/// 보합
		/// </summary>
		[JsonProperty("stdns")]
		public decimal? Flat;
		/// <summary>
		/// 하락
		/// </summary>
		[JsonProperty("fall")]
		public decimal? Down;
		/// <summary>
		/// 하한
		/// </summary>
		[JsonProperty("lst")]
		public decimal? LowerLimit;
		/// <summary>
		/// 상장종목수
		/// </summary>
		[JsonProperty("flo_stk_num")]
		public decimal? ListedStockCount;
	}

	public record KiwoomIndustryGetDailyPrices
	{
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
		/// 거래대금
		/// </summary>
		[JsonProperty("trde_prica")]
		public decimal? TransactionAmount;
		/// <summary>
		/// 거래형성종목수
		/// </summary>
		[JsonProperty("trde_frmatn_stk_num")]
		public decimal? ActiveTradingStockCount;
		/// <summary>
		/// 거래형성비율
		/// </summary>
		[JsonProperty("trde_frmatn_rt")]
		public decimal? ActiveTradingRate;
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
		/// 상한
		/// </summary>
		[JsonProperty("upl")]
		public decimal? UpperLimit;
		/// <summary>
		/// 상승
		/// </summary>
		[JsonProperty("rising")]
		public decimal? Up;
		/// <summary>
		/// 보합
		/// </summary>
		[JsonProperty("stdns")]
		public decimal? Flat;
		/// <summary>
		/// 하락
		/// </summary>
		[JsonProperty("fall")]
		public decimal? Down;
		/// <summary>
		/// 하한
		/// </summary>
		[JsonProperty("lst")]
		public decimal? LowerLimit;
		/// <summary>
		/// 52주최고가
		/// </summary>
		[JsonProperty("52wk_hgst_pric")]
		public decimal? FiftyTwoWeekHigh;
		/// <summary>
		/// 52주최고가일
		/// </summary>
		[JsonProperty("52wk_hgst_pric_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? FiftyTwoWeekHighDate;
		/// <summary>
		/// 52주최고가대비율
		/// </summary>
		[JsonProperty("52wk_hgst_pric_pre_rt")]
		public decimal? FiftyTwoWeekHighRate;
		/// <summary>
		/// 52주최저가
		/// </summary>
		[JsonProperty("52wk_lwst_pric")]
		public decimal? FiftyTwoWeekLow;
		/// <summary>
		/// 52주최저가일
		/// </summary>
		[JsonProperty("52wk_lwst_pric_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? FiftyTwoWeekLowDate;
		/// <summary>
		/// 52주최저가대비율
		/// </summary>
		[JsonProperty("52wk_lwst_pric_pre_rt")]
		public decimal? FiftyTwoWeekLowRate;
		/// <summary>
		/// 업종현재가_일별반복
		/// </summary>
		[JsonProperty("inds_cur_prc_daly_rept")]
		public IEnumerable<KiwoomIndustryGetDailyPriceItem>? Items;
	}
	public record KiwoomIndustryGetDailyPriceItem
	{
		/// <summary>
		/// 일자n
		/// </summary>
		[JsonProperty("dt_n")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		/// <summary>
		/// 현재가n
		/// </summary>
		[JsonProperty("cur_prc_n")]
		public decimal? CurrentPrice;
		/// <summary>
		/// 전일대비기호n
		/// </summary>
		[JsonProperty("pred_pre_sig_n")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비n
		/// </summary>
		[JsonProperty("pred_pre_n")]
		public decimal? Change;
		/// <summary>
		/// 등락률n
		/// </summary>
		[JsonProperty("flu_rt_n")]
		public decimal? ChangeRate;
		/// <summary>
		/// 누적거래량n
		/// </summary>
		[JsonProperty("acc_trde_qty_n")]
		public decimal? AccumulatedVolume;
	}
}
