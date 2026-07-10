using KiwoomRestApi.Net.Objects.Commons;

using Newtonsoft.Json;

using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models.UsStock
{
	public record KiwoomUsStockInvestmentInfoGetResearches
	{
		/// <summary>
		/// 미국주식 리서치 리스트
		/// </summary>
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockInvestmentInfoGetResearchItem>? Items;
	}

	public record KiwoomUsStockInvestmentInfoGetResearchItem
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
		public decimal? AccumulatedVolume;
	}
}
