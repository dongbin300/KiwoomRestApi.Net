using KiwoomRestApi.Net.Objects.Commons;

using Newtonsoft.Json;

namespace KiwoomRestApi.Net.Objects.Models.UsStock
{
	/// <summary>
	/// | usa20101 | 미국주식 현재가 10호가
	/// </summary>
	public record KiwoomUsStockMarketConditionGetOrderBook
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
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
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
		/// 호가시간
		/// </summary>
		[JsonProperty("bid_tm")]
		public string? BidTime;
		/// <summary>
		/// 일자
		/// </summary>
		[JsonProperty("dt")]
		public string? Date;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 최우선매도호가
		/// </summary>
		[JsonProperty("fpr_sel_bid")]
		public KiwoomDecimal? BestSellQuote;
		/// <summary>
		/// 최우선매수호가
		/// </summary>
		[JsonProperty("fpr_buy_bid")]
		public KiwoomDecimal? BestBuyQuote;
		/// <summary>
		/// 전일거래대비
		/// </summary>
		[JsonProperty("pre_trde_rt")]
		public KiwoomDecimal? PreviousDayVolumeRate;
		/// <summary>
		/// 거래회전율
		/// </summary>
		[JsonProperty("trde_tern_rt")]
		public KiwoomDecimal? TurnoverRate;
		/// <summary>
		/// 매도1호가
		/// </summary>
		[JsonProperty("sel_1bid")]
		public KiwoomDecimal? SellPrice1;
		/// <summary>
		/// 매도2호가
		/// </summary>
		[JsonProperty("sel_2bid")]
		public KiwoomDecimal? SellPrice2;
		/// <summary>
		/// 매도3호가
		/// </summary>
		[JsonProperty("sel_3bid")]
		public KiwoomDecimal? SellPrice3;
		/// <summary>
		/// 매도4호가
		/// </summary>
		[JsonProperty("sel_4bid")]
		public KiwoomDecimal? SellPrice4;
		/// <summary>
		/// 매도5호가
		/// </summary>
		[JsonProperty("sel_5bid")]
		public KiwoomDecimal? SellPrice5;
		/// <summary>
		/// 매도6호가
		/// </summary>
		[JsonProperty("sel_6bid")]
		public KiwoomDecimal? SellPrice6;
		/// <summary>
		/// 매도7호가
		/// </summary>
		[JsonProperty("sel_7bid")]
		public KiwoomDecimal? SellPrice7;
		/// <summary>
		/// 매도8호가
		/// </summary>
		[JsonProperty("sel_8bid")]
		public KiwoomDecimal? SellPrice8;
		/// <summary>
		/// 매도9호가
		/// </summary>
		[JsonProperty("sel_9bid")]
		public KiwoomDecimal? SellPrice9;
		/// <summary>
		/// 매도10호가
		/// </summary>
		[JsonProperty("sel_10bid")]
		public KiwoomDecimal? SellPrice10;
		/// <summary>
		/// 매수1호가
		/// </summary>
		[JsonProperty("buy_1bid")]
		public KiwoomDecimal? BuyPrice1;
		/// <summary>
		/// 매수2호가
		/// </summary>
		[JsonProperty("buy_2bid")]
		public KiwoomDecimal? BuyPrice2;
		/// <summary>
		/// 매수3호가
		/// </summary>
		[JsonProperty("buy_3bid")]
		public KiwoomDecimal? BuyPrice3;
		/// <summary>
		/// 매수4호가
		/// </summary>
		[JsonProperty("buy_4bid")]
		public KiwoomDecimal? BuyPrice4;
		/// <summary>
		/// 매수5호가
		/// </summary>
		[JsonProperty("buy_5bid")]
		public KiwoomDecimal? BuyPrice5;
		/// <summary>
		/// 매수6호가
		/// </summary>
		[JsonProperty("buy_6bid")]
		public KiwoomDecimal? BuyPrice6;
		/// <summary>
		/// 매수7호가
		/// </summary>
		[JsonProperty("buy_7bid")]
		public KiwoomDecimal? BuyPrice7;
		/// <summary>
		/// 매수8호가
		/// </summary>
		[JsonProperty("buy_8bid")]
		public KiwoomDecimal? BuyPrice8;
		/// <summary>
		/// 매수9호가
		/// </summary>
		[JsonProperty("buy_9bid")]
		public KiwoomDecimal? BuyPrice9;
		/// <summary>
		/// 매수10호가
		/// </summary>
		[JsonProperty("buy_10bid")]
		public KiwoomDecimal? BuyPrice10;
		/// <summary>
		/// 매도1호가잔량
		/// </summary>
		[JsonProperty("sel_1bid_req")]
		public decimal? SellQuantity1;
		/// <summary>
		/// 매도2호가잔량
		/// </summary>
		[JsonProperty("sel_2bid_req")]
		public decimal? SellQuantity2;
		/// <summary>
		/// 매도3호가잔량
		/// </summary>
		[JsonProperty("sel_3bid_req")]
		public decimal? SellQuantity3;
		/// <summary>
		/// 매도4호가잔량
		/// </summary>
		[JsonProperty("sel_4bid_req")]
		public decimal? SellQuantity4;
		/// <summary>
		/// 매도5호가잔량
		/// </summary>
		[JsonProperty("sel_5bid_req")]
		public decimal? SellQuantity5;
		/// <summary>
		/// 매도6호가잔량
		/// </summary>
		[JsonProperty("sel_6bid_req")]
		public decimal? SellQuantity6;
		/// <summary>
		/// 매도7호가잔량
		/// </summary>
		[JsonProperty("sel_7bid_req")]
		public decimal? SellQuantity7;
		/// <summary>
		/// 매도8호가잔량
		/// </summary>
		[JsonProperty("sel_8bid_req")]
		public decimal? SellQuantity8;
		/// <summary>
		/// 매도9호가잔량
		/// </summary>
		[JsonProperty("sel_9bid_req")]
		public decimal? SellQuantity9;
		/// <summary>
		/// 매도10호가잔량
		/// </summary>
		[JsonProperty("sel_10bid_req")]
		public decimal? SellQuantity10;
		/// <summary>
		/// 매수1호가잔량
		/// </summary>
		[JsonProperty("buy_1bid_req")]
		public decimal? BuyQuantity1;
		/// <summary>
		/// 매수2호가잔량
		/// </summary>
		[JsonProperty("buy_2bid_req")]
		public decimal? BuyQuantity2;
		/// <summary>
		/// 매수3호가잔량
		/// </summary>
		[JsonProperty("buy_3bid_req")]
		public decimal? BuyQuantity3;
		/// <summary>
		/// 매수4호가잔량
		/// </summary>
		[JsonProperty("buy_4bid_req")]
		public decimal? BuyQuantity4;
		/// <summary>
		/// 매수5호가잔량
		/// </summary>
		[JsonProperty("buy_5bid_req")]
		public decimal? BuyQuantity5;
		/// <summary>
		/// 매수6호가잔량
		/// </summary>
		[JsonProperty("buy_6bid_req")]
		public decimal? BuyQuantity6;
		/// <summary>
		/// 매수7호가잔량
		/// </summary>
		[JsonProperty("buy_7bid_req")]
		public decimal? BuyQuantity7;
		/// <summary>
		/// 매수8호가잔량
		/// </summary>
		[JsonProperty("buy_8bid_req")]
		public decimal? BuyQuantity8;
		/// <summary>
		/// 매수9호가잔량
		/// </summary>
		[JsonProperty("buy_9bid_req")]
		public decimal? BuyQuantity9;
		/// <summary>
		/// 매수10호가잔량
		/// </summary>
		[JsonProperty("buy_10bid_req")]
		public decimal? BuyQuantity10;
		/// <summary>
		/// 매도1호가직전대비
		/// </summary>
		[JsonProperty("sel_1bid_jub_pre")]
		public decimal? SellPriceChange1;
		/// <summary>
		/// 매도2호가직전대비
		/// </summary>
		[JsonProperty("sel_2bid_jub_pre")]
		public decimal? SellPriceChange2;
		/// <summary>
		/// 매도3호가직전대비
		/// </summary>
		[JsonProperty("sel_3bid_jub_pre")]
		public decimal? SellPriceChange3;
		/// <summary>
		/// 매도4호가직전대비
		/// </summary>
		[JsonProperty("sel_4bid_jub_pre")]
		public decimal? SellPriceChange4;
		/// <summary>
		/// 매도5호가직전대비
		/// </summary>
		[JsonProperty("sel_5bid_jub_pre")]
		public decimal? SellPriceChange5;
		/// <summary>
		/// 매도6호가직전대비
		/// </summary>
		[JsonProperty("sel_6bid_jub_pre")]
		public decimal? SellPriceChange6;
		/// <summary>
		/// 매도7호가직전대비
		/// </summary>
		[JsonProperty("sel_7bid_jub_pre")]
		public decimal? SellPriceChange7;
		/// <summary>
		/// 매도8호가직전대비
		/// </summary>
		[JsonProperty("sel_8bid_jub_pre")]
		public decimal? SellPriceChange8;
		/// <summary>
		/// 매도9호가직전대비
		/// </summary>
		[JsonProperty("sel_9bid_jub_pre")]
		public decimal? SellPriceChange9;
		/// <summary>
		/// 매도10호가직전대비
		/// </summary>
		[JsonProperty("sel_10bid_jub_pre")]
		public decimal? SellPriceChange10;
		/// <summary>
		/// 매수1차선잔량대비
		/// </summary>
		[JsonProperty("buy_1th_pre_req_pre")]
		public decimal? BuyQuantityChange1;
		/// <summary>
		/// 매수1호가직전대비
		/// </summary>
		[JsonProperty("buy_1bid_jub_pre")]
		public decimal? BuyPriceChange1;
		/// <summary>
		/// 매수2호가직전대비
		/// </summary>
		[JsonProperty("buy_2bid_jub_pre")]
		public decimal? BuyPriceChange2;
		/// <summary>
		/// 매수3호가직전대비
		/// </summary>
		[JsonProperty("buy_3bid_jub_pre")]
		public decimal? BuyPriceChange3;
		/// <summary>
		/// 매수4호가직전대비
		/// </summary>
		[JsonProperty("buy_4bid_jub_pre")]
		public decimal? BuyPriceChange4;
		/// <summary>
		/// 매수5호가직전대비
		/// </summary>
		[JsonProperty("buy_5bid_jub_pre")]
		public decimal? BuyPriceChange5;
		/// <summary>
		/// 매수6호가직전대비
		/// </summary>
		[JsonProperty("buy_6bid_jub_pre")]
		public decimal? BuyPriceChange6;
		/// <summary>
		/// 매수7호가직전대비
		/// </summary>
		[JsonProperty("buy_7bid_jub_pre")]
		public decimal? BuyPriceChange7;
		/// <summary>
		/// 매수8호가직전대비
		/// </summary>
		[JsonProperty("buy_8bid_jub_pre")]
		public decimal? BuyPriceChange8;
		/// <summary>
		/// 매수9호가직전대비
		/// </summary>
		[JsonProperty("buy_9bid_jub_pre")]
		public decimal? BuyPriceChange9;
		/// <summary>
		/// 매수10호가직전대비
		/// </summary>
		[JsonProperty("buy_10bid_jub_pre")]
		public decimal? BuyPriceChange10;
		/// <summary>
		/// 매도1호가건수
		/// </summary>
		[JsonProperty("sel_1bid_cnt")]
		public decimal? SellCount1;
		/// <summary>
		/// 매도2호가건수
		/// </summary>
		[JsonProperty("sel_2bid_cnt")]
		public decimal? SellCount2;
		/// <summary>
		/// 매도3호가건수
		/// </summary>
		[JsonProperty("sel_3bid_cnt")]
		public decimal? SellCount3;
		/// <summary>
		/// 매도4호가건수
		/// </summary>
		[JsonProperty("sel_4bid_cnt")]
		public decimal? SellCount4;
		/// <summary>
		/// 매도5호가건수
		/// </summary>
		[JsonProperty("sel_5bid_cnt")]
		public decimal? SellCount5;
		/// <summary>
		/// 매도6호가건수
		/// </summary>
		[JsonProperty("sel_6bid_cnt")]
		public decimal? SellCount6;
		/// <summary>
		/// 매도7호가건수
		/// </summary>
		[JsonProperty("sel_7bid_cnt")]
		public decimal? SellCount7;
		/// <summary>
		/// 매도8호가건수
		/// </summary>
		[JsonProperty("sel_8bid_cnt")]
		public decimal? SellCount8;
		/// <summary>
		/// 매도9호가건수
		/// </summary>
		[JsonProperty("sel_9bid_cnt")]
		public decimal? SellCount9;
		/// <summary>
		/// 매도10호가건수
		/// </summary>
		[JsonProperty("sel_10bid_cnt")]
		public decimal? SellCount10;
		/// <summary>
		/// 매수1호가건수
		/// </summary>
		[JsonProperty("buy_1bid_cnt")]
		public decimal? BuyCount1;
		/// <summary>
		/// 매수2호가건수
		/// </summary>
		[JsonProperty("buy_2bid_cnt")]
		public decimal? BuyCount2;
		/// <summary>
		/// 매수3호가건수
		/// </summary>
		[JsonProperty("buy_3bid_cnt")]
		public decimal? BuyCount3;
		/// <summary>
		/// 매수4호가건수
		/// </summary>
		[JsonProperty("buy_4bid_cnt")]
		public decimal? BuyCount4;
		/// <summary>
		/// 매수5호가건수
		/// </summary>
		[JsonProperty("buy_5bid_cnt")]
		public decimal? BuyCount5;
		/// <summary>
		/// 매수6호가건수
		/// </summary>
		[JsonProperty("buy_6bid_cnt")]
		public decimal? BuyCount6;
		/// <summary>
		/// 매수7호가건수
		/// </summary>
		[JsonProperty("buy_7bid_cnt")]
		public decimal? BuyCount7;
		/// <summary>
		/// 매수8호가건수
		/// </summary>
		[JsonProperty("buy_8bid_cnt")]
		public decimal? BuyCount8;
		/// <summary>
		/// 매수9호가건수
		/// </summary>
		[JsonProperty("buy_9bid_cnt")]
		public decimal? BuyCount9;
		/// <summary>
		/// 매수10호가건수
		/// </summary>
		[JsonProperty("buy_10bid_cnt")]
		public decimal? BuyCount10;
		/// <summary>
		/// 총매도잔량
		/// </summary>
		[JsonProperty("tot_sel_req")]
		public decimal? TotalSellQuantity;
		/// <summary>
		/// 매도호가총잔량직전대비
		/// </summary>
		[JsonProperty("sel_bid_tot_req_jub_pre")]
		public decimal? TotalSellQuantityChange;
		/// <summary>
		/// 총매도호가건수
		/// </summary>
		[JsonProperty("tot_sel_cnt")]
		public decimal? TotalSellCount;
		/// <summary>
		/// 총매수잔량
		/// </summary>
		[JsonProperty("tot_buy_req")]
		public decimal? TotalBuyQuantity;
		/// <summary>
		/// 매수호가총잔량직전대비
		/// </summary>
		[JsonProperty("buy_bid_tot_req_jub_pre")]
		public decimal? TotalBuyQuantityChange;
		/// <summary>
		/// 총매수호가건수
		/// </summary>
		[JsonProperty("tot_buy_cnt")]
		public decimal? TotalBuyCount;
		/// <summary>
		/// 순매수잔량
		/// </summary>
		[JsonProperty("netprps_req")]
		public decimal? NetBuyQuantity;
		/// <summary>
		/// 순매도잔량
		/// </summary>
		[JsonProperty("netslmt_req")]
		public decimal? NetSellQuantity;
		/// <summary>
		/// 상한가
		/// </summary>
		[JsonProperty("upl_pric")]
		public decimal? UpperLimitPrice;
		/// <summary>
		/// 기준가
		/// </summary>
		[JsonProperty("base_pric")]
		public decimal? BasePrice;
	}
}
