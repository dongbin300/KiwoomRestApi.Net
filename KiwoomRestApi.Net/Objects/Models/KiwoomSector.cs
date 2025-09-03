using KiwoomRestApi.Net.Converters;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models
{
	public record KiwoomSectorGetStockProgramTradingInfo
	{
		/// <summary>
		/// 차익위탁매도수량
		/// </summary>
		[JsonProperty("dfrt_trst_sell_qty")]
		public decimal? ArbitrageTrustSellQuantity;
		/// <summary>
		/// 차익위탁매도금액
		/// </summary>
		[JsonProperty("dfrt_trst_sell_amt")]
		public decimal? ArbitrageTrustSellAmount;
		/// <summary>
		/// 차익위탁매수수량
		/// </summary>
		[JsonProperty("dfrt_trst_buy_qty")]
		public decimal? ArbitrageTrustBuyQuantity;
		/// <summary>
		/// 차익위탁매수금액
		/// </summary>
		[JsonProperty("dfrt_trst_buy_amt")]
		public decimal? ArbitrageTrustBuyAmount;
		/// <summary>
		/// 차익위탁순매수수량
		/// </summary>
		[JsonProperty("dfrt_trst_netprps_qty")]
		public decimal? ArbitrageTrustNetPurchaseQuantity;
		/// <summary>
		/// 차익위탁순매수금액
		/// </summary>
		[JsonProperty("dfrt_trst_netprps_amt")]
		public decimal? ArbitrageTrustNetPurchaseAmount;
		/// <summary>
		/// 비차익위탁매도수량
		/// </summary>
		[JsonProperty("ndiffpro_trst_sell_qty")]
		public decimal? NonArbitrageTrustSellQuantity;
		/// <summary>
		/// 비차익위탁매도금액
		/// </summary>
		[JsonProperty("ndiffpro_trst_sell_amt")]
		public decimal? NonArbitrageTrustSellAmount;
		/// <summary>
		/// 비차익위탁매수수량
		/// </summary>
		[JsonProperty("ndiffpro_trst_buy_qty")]
		public decimal? NonArbitrageTrustBuyQuantity;
		/// <summary>
		/// 비차익위탁매수금액
		/// </summary>
		[JsonProperty("ndiffpro_trst_buy_amt")]
		public decimal? NonArbitrageTrustBuyAmount;
		/// <summary>
		/// 비차익위탁순매수수량
		/// </summary>
		[JsonProperty("ndiffpro_trst_netprps_qty")]
		public decimal? NonArbitrageTrustNetPurchaseQuantity;
		/// <summary>
		/// 비차익위탁순매수금액
		/// </summary>
		[JsonProperty("ndiffpro_trst_netprps_amt")]
		public decimal? NonArbitrageTrustNetPurchaseAmount;
		/// <summary>
		/// 전체차익위탁매도수량
		/// </summary>
		[JsonProperty("all_dfrt_trst_sell_qty")]
		public decimal? TotalArbitrageTrustSellQuantity;
		/// <summary>
		/// 전체차익위탁매도금액
		/// </summary>
		[JsonProperty("all_dfrt_trst_sell_amt")]
		public decimal? TotalArbitrageTrustSellAmount;
		/// <summary>
		/// 전체차익위탁매수수량
		/// </summary>
		[JsonProperty("all_dfrt_trst_buy_qty")]
		public decimal? TotalArbitrageTrustBuyQuantity;
		/// <summary>
		/// 전체차익위탁매수금액
		/// </summary>
		[JsonProperty("all_dfrt_trst_buy_amt")]
		public decimal? TotalArbitrageTrustBuyAmount;
		/// <summary>
		/// 전체차익위탁순매수수량
		/// </summary>
		[JsonProperty("all_dfrt_trst_netprps_qty")]
		public decimal? TotalArbitrageTrustNetPurchaseQuantity;
		/// <summary>
		/// 전체차익위탁순매수금액
		/// </summary>
		[JsonProperty("all_dfrt_trst_netprps_amt")]
		public decimal? TotalArbitrageTrustNetPurchaseAmount;
	}

	public record KiwoomSectorGetIndustryNetPurchases
	{
		/// <summary>
		/// 업종별순매수
		/// </summary>
		[JsonProperty("inds_netprps")]
		public IEnumerable<KiwoomSectorGetIndustryNetPurchaseItem>? Items;
	}
	public record KiwoomSectorGetIndustryNetPurchaseItem
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
		public string? PrevSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PrevDiff;
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
		/// 증권순매수
		/// </summary>
		[JsonProperty("sc_netprps")]
		public decimal? SecuritiesNetPurchase;
		/// <summary>
		/// 보험순매수
		/// </summary>
		[JsonProperty("insrnc_netprps")]
		public decimal? InsuranceNetPurchase;
		/// <summary>
		/// 투신순매수
		/// </summary>
		[JsonProperty("invtrt_netprps")]
		public decimal? InvestmentTrustNetPurchase;
		/// <summary>
		/// 은행순매수
		/// </summary>
		[JsonProperty("bank_netprps")]
		public decimal? BankNetPurchase;
		/// <summary>
		/// 종신금순매수
		/// </summary>
		[JsonProperty("jnsinkm_netprps")]
		public decimal? PensionNetPurchase;
		/// <summary>
		/// 기금순매수
		/// </summary>
		[JsonProperty("endw_netprps")]
		public decimal? FundNetPurchase;
		/// <summary>
		/// 기타법인순매수
		/// </summary>
		[JsonProperty("etc_corp_netprps")]
		public decimal? OtherCorporationNetPurchase;
		/// <summary>
		/// 개인순매수
		/// </summary>
		[JsonProperty("ind_netprps")]
		public decimal? IndividualNetPurchase;
		/// <summary>
		/// 외국인순매수
		/// </summary>
		[JsonProperty("frgnr_netprps")]
		public decimal? ForeignNetPurchase;
		/// <summary>
		/// 내국인대우외국인순매수
		/// </summary>
		[JsonProperty("native_trmt_frgnr_netprps")]
		public decimal? DomesticTreatedForeignNetPurchase;
		/// <summary>
		/// 국가순매수
		/// </summary>
		[JsonProperty("natn_netprps")]
		public decimal? NationNetPurchase;
		/// <summary>
		/// 사모펀드순매수
		/// </summary>
		[JsonProperty("samo_fund_netprps")]
		public decimal? PrivateFundNetPurchase;
		/// <summary>
		/// 기관계순매수
		/// </summary>
		[JsonProperty("orgn_netprps")]
		public decimal? InstitutionNetPurchase;
	}

	public record KiwoomSectorGetIndustryCurrentPrices
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
		public string? PrevDiffSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PrevDiff;
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
		/// 거래대금
		/// </summary>
		[JsonProperty("trde_prica")]
		public decimal? TradeAmount;
		/// <summary>
		/// 거래형성종목수
		/// </summary>
		[JsonProperty("trde_frmatn_stk_num")]
		public decimal? TradeFormationStockCount;
		/// <summary>
		/// 거래형성비율
		/// </summary>
		[JsonProperty("trde_frmatn_rt")]
		public decimal? TradeFormationRate;
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
		/// 상한
		/// </summary>
		[JsonProperty("upl")]
		public decimal? UpperLimit;
		/// <summary>
		/// 상승
		/// </summary>
		[JsonProperty("rising")]
		public decimal? Rising;
		/// <summary>
		/// 보합
		/// </summary>
		[JsonProperty("stdns")]
		public decimal? Steady;
		/// <summary>
		/// 하락
		/// </summary>
		[JsonProperty("fall")]
		public decimal? Falling;
		/// <summary>
		/// 하한
		/// </summary>
		[JsonProperty("lst")]
		public decimal? LowerLimit;
		/// <summary>
		/// 52주최고가
		/// </summary>
		[JsonProperty("52wk_hgst_pric")]
		public decimal? _52WeekHighestPrice;
		/// <summary>
		/// 52주최고가일
		/// </summary>
		[JsonProperty("52wk_hgst_pric_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? _52WeekHighestPriceDate;
		/// <summary>
		/// 52주최고가대비율
		/// </summary>
		[JsonProperty("52wk_hgst_pric_pre_rt")]
		public decimal? _52WeekHighestPriceRate;
		/// <summary>
		/// 52주최저가
		/// </summary>
		[JsonProperty("52wk_lwst_pric")]
		public decimal? _52WeekLowestPrice;
		/// <summary>
		/// 52주최저가일
		/// </summary>
		[JsonProperty("52wk_lwst_pric_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? _52WeekLowestPriceDate;
		/// <summary>
		/// 52주최저가대비율
		/// </summary>
		[JsonProperty("52wk_lwst_pric_pre_rt")]
		public decimal? _52WeekLowestPriceRate;
		/// <summary>
		/// 업종현재가_시간별
		/// </summary>
		[JsonProperty("inds_cur_prc_tm")]
		public IEnumerable<KiwoomSectorGetIndustryCurrentPriceItem>? Items;
	}
	public record KiwoomSectorGetIndustryCurrentPriceItem
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
		public string? PrevDiffSign;
		/// <summary>
		/// 전일대비n
		/// </summary>
		[JsonProperty("pred_pre_n")]
		public decimal? PrevDiff;
		/// <summary>
		/// 등락률n
		/// </summary>
		[JsonProperty("flu_rt_n")]
		public decimal? FluctuationRate;
		/// <summary>
		/// 거래량n
		/// </summary>
		[JsonProperty("trde_qty_n")]
		public decimal? TradeQuantity;
		/// <summary>
		/// 누적거래량n
		/// </summary>
		[JsonProperty("acc_trde_qty_n")]
		public decimal? AccumulatedTradeQuantity;
	}

	public record KiwoomSectorGetIndustryStockPrices
	{
		/// <summary>
		/// 업종별주가
		/// </summary>
		[JsonProperty("inds_stkpc")]
		public IEnumerable<KiwoomSectorGetIndustryStockPriceItem>? Items;
	}
	public record KiwoomSectorGetIndustryStockPriceItem
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
		public string? PrevDiffSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PrevDiff;
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
		/// <summary>
		/// 매수호가
		/// </summary>
		[JsonProperty("buy_bid")]
		public decimal? BuyBid;
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
	}

	public record KiwoomSectorGetAllIndustryIndices
	{
		/// <summary>
		/// 전업종지수
		/// </summary>
		[JsonProperty("all_inds_idex")]
		public IEnumerable<KiwoomSectorGetAllIndustryIndexItem>? Items;
	}
	public record KiwoomSectorGetAllIndustryIndexItem
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
		public string? PrevSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PrevDiff;
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
		/// 비중
		/// </summary>
		[JsonProperty("wght")]
		public decimal? Weight;
		/// <summary>
		/// 거래대금
		/// </summary>
		[JsonProperty("trde_prica")]
		public decimal? TradeAmount;
		/// <summary>
		/// 상한
		/// </summary>
		[JsonProperty("upl")]
		public decimal? UpperLimit;
		/// <summary>
		/// 상승
		/// </summary>
		[JsonProperty("rising")]
		public decimal? Rising;
		/// <summary>
		/// 보합
		/// </summary>
		[JsonProperty("stdns")]
		public decimal? Steady;
		/// <summary>
		/// 하락
		/// </summary>
		[JsonProperty("fall")]
		public decimal? Falling;
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

	public record KiwoomSectorGetDailyIndustryPrices
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
		public string? PrevDiffSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PrevDiff;
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
		/// 거래대금
		/// </summary>
		[JsonProperty("trde_prica")]
		public decimal? TradeAmount;
		/// <summary>
		/// 거래형성종목수
		/// </summary>
		[JsonProperty("trde_frmatn_stk_num")]
		public decimal? TradeFormationStockCount;
		/// <summary>
		/// 거래형성비율
		/// </summary>
		[JsonProperty("trde_frmatn_rt")]
		public decimal? TradeFormationRate;
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
		/// 상한
		/// </summary>
		[JsonProperty("upl")]
		public decimal? UpperLimit;
		/// <summary>
		/// 상승
		/// </summary>
		[JsonProperty("rising")]
		public decimal? Rising;
		/// <summary>
		/// 보합
		/// </summary>
		[JsonProperty("stdns")]
		public decimal? Steady;
		/// <summary>
		/// 하락
		/// </summary>
		[JsonProperty("fall")]
		public decimal? Falling;
		/// <summary>
		/// 하한
		/// </summary>
		[JsonProperty("lst")]
		public decimal? LowerLimit;
		/// <summary>
		/// 52주최고가
		/// </summary>
		[JsonProperty("52wk_hgst_pric")]
		public decimal? _52WeekHighestPrice;
		/// <summary>
		/// 52주최고가일
		/// </summary>
		[JsonProperty("52wk_hgst_pric_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? _52WeekHighestPriceDate;
		/// <summary>
		/// 52주최고가대비율
		/// </summary>
		[JsonProperty("52wk_hgst_pric_pre_rt")]
		public decimal? _52WeekHighestPriceRate;
		/// <summary>
		/// 52주최저가
		/// </summary>
		[JsonProperty("52wk_lwst_pric")]
		public decimal? _52WeekLowestPrice;
		/// <summary>
		/// 52주최저가일
		/// </summary>
		[JsonProperty("52wk_lwst_pric_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? _52WeekLowestPriceDate;
		/// <summary>
		/// 52주최저가대비율
		/// </summary>
		[JsonProperty("52wk_lwst_pric_pre_rt")]
		public decimal? _52WeekLowestPriceRate;
		/// <summary>
		/// 업종현재가_일별반복
		/// </summary>
		[JsonProperty("inds_cur_prc_daly_rept")]
		public IEnumerable<KiwoomSectorGetDailyIndustryPriceItem>? Items;
	}
	public record KiwoomSectorGetDailyIndustryPriceItem
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
		public string? PrevDiffSign;
		/// <summary>
		/// 전일대비n
		/// </summary>
		[JsonProperty("pred_pre_n")]
		public decimal? PrevDiff;
		/// <summary>
		/// 등락률n
		/// </summary>
		[JsonProperty("flu_rt_n")]
		public decimal? FluctuationRate;
		/// <summary>
		/// 누적거래량n
		/// </summary>
		[JsonProperty("acc_trde_qty_n")]
		public decimal? AccumulatedTradeQuantity;
	}
}
