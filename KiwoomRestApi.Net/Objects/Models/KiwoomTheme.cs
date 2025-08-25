using Newtonsoft.Json;

using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models
{
	public record KiwoomThemeGetGroups
	{
		[JsonProperty("thema_grp")]
		public IEnumerable<KiwoomThemeGetGroupItem>? Items;
	}
	public record KiwoomThemeGetGroupItem
	{
		[JsonProperty("thema_grp_cd")]
		public string? ThemeGroupCode;
		[JsonProperty("thema_nm")]
		public string? ThemeName;
		[JsonProperty("stk_num")]
		public int? StockCount;
		[JsonProperty("flu_sig")]
		public string? FluSign;
		[JsonProperty("flu_rt")]
		public decimal? FluRate;
		[JsonProperty("rising_stk_num")]
		public int? RisingStockCount;
		[JsonProperty("fall_stk_num")]
		public int? FallingStockCount;
		[JsonProperty("dt_prft_rt")]
		public decimal? PeriodProfitRate;
		[JsonProperty("main_stk")]
		public string? MainStock;
	}

	public record KiwoomThemeGetComponentStocks
	{
		[JsonProperty("thema_comp_stk")]
		public IEnumerable<KiwoomThemeGetComponentStockItem>? Items;
	}
	public record KiwoomThemeGetComponentStockItem
	{
		[JsonProperty("stk_cd")]
		public string? StockCode;
		[JsonProperty("stk_nm")]
		public string? StockName;
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		[JsonProperty("flu_sig")]
		public string? FluSign;
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		[JsonProperty("flu_rt")]
		public decimal? FluRate;
		[JsonProperty("acc_trde_qty")]
		public decimal? AccumulatedTradeVolume;
		[JsonProperty("sel_bid")]
		public decimal? SellingBidPrice;
		[JsonProperty("sel_req")]
		public decimal? SellingRequestVolume;
		[JsonProperty("buy_bid")]
		public decimal? BuyingBidPrice;
		[JsonProperty("buy_req")]
		public decimal? BuyingRequestVolume;
		[JsonProperty("dt_prft_rt_n")]
		public decimal? PeriodProfitRateN;
	}
}
