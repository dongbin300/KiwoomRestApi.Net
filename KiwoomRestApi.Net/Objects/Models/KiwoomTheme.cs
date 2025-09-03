using Newtonsoft.Json;

using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models
{
	public record KiwoomThemeGetGroups
	{
		/// <summary>
		/// 테마그룹별
		/// </summary>
		[JsonProperty("thema_grp")]
		public IEnumerable<KiwoomThemeGetGroupItem>? Items;
	}
	public record KiwoomThemeGetGroupItem
	{
		/// <summary>
		/// 테마그룹코드
		/// </summary>
		[JsonProperty("thema_grp_cd")]
		public string? ThemeGroupCode;
		/// <summary>
		/// 테마명
		/// </summary>
		[JsonProperty("thema_nm")]
		public string? ThemeName;
		/// <summary>
		/// 종목수
		/// </summary>
		[JsonProperty("stk_num")]
		public int? StockCount;
		/// <summary>
		/// 등락기호
		/// </summary>
		[JsonProperty("flu_sig")]
		public string? FluSign;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluRate;
		/// <summary>
		/// 상승종목수
		/// </summary>
		[JsonProperty("rising_stk_num")]
		public int? RisingStockCount;
		/// <summary>
		/// 하락종목수
		/// </summary>
		[JsonProperty("fall_stk_num")]
		public int? FallingStockCount;
		/// <summary>
		/// 기간수익률
		/// </summary>
		[JsonProperty("dt_prft_rt")]
		public decimal? PeriodProfitRate;
		/// <summary>
		/// 주요종목
		/// </summary>
		[JsonProperty("main_stk")]
		public string? MainStock;
	}

	public record KiwoomThemeGetComponentStocks
	{
		/// <summary>
		/// 테마구성종목
		/// </summary>
		[JsonProperty("thema_comp_stk")]
		public IEnumerable<KiwoomThemeGetComponentStockItem>? Items;
	}
	public record KiwoomThemeGetComponentStockItem
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
		public string? FluSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluRate;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? AccumulatedTradeVolume;
		/// <summary>
		/// 매도호가
		/// </summary>
		[JsonProperty("sel_bid")]
		public decimal? SellingBidPrice;
		/// <summary>
		/// 매도잔량
		/// </summary>
		[JsonProperty("sel_req")]
		public decimal? SellingRequestVolume;
		/// <summary>
		/// 매수호가
		/// </summary>
		[JsonProperty("buy_bid")]
		public decimal? BuyingBidPrice;
		/// <summary>
		/// 매수잔량
		/// </summary>
		[JsonProperty("buy_req")]
		public decimal? BuyingRequestVolume;
		/// <summary>
		/// 기간수익률n
		/// </summary>
		[JsonProperty("dt_prft_rt_n")]
		public decimal? PeriodProfitRateN;
	}
}
