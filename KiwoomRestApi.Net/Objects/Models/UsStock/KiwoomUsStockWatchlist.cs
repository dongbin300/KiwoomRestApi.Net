using KiwoomRestApi.Net.Enums.DomesticStock.Watchlist;

using Newtonsoft.Json;

using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models.UsStock
{
	/// <summary>
	/// | usa20200 | 미국주식 관심종목 그룹 리스트 조회
	/// </summary>
	public record KiwoomUsStockWatchlistGetWatchlistGroups
	{
		/// <summary>
		/// 처리결과
		/// </summary>
		[JsonProperty("rtcd")]
		private string? RawResult { get; set; }
		public KiwoomWatchlistResult Result => RawResult switch
		{
			"S" => KiwoomWatchlistResult.Success,
			"F" => KiwoomWatchlistResult.Failure,
			_ => KiwoomWatchlistResult.Failure
		};
		/// <summary>
		/// 그룹갯수
		/// </summary>
		[JsonProperty("nofi")]
		public IEnumerable<KiwoomUsStockWatchlistGetWatchlistGroupItem>? Items;
	}

	public record KiwoomUsStockWatchlistGetWatchlistGroupItem
	{
		/// <summary>
		/// 그룹코드
		/// </summary>
		[JsonProperty("gcod")]
		public string? GroupCode;
		/// <summary>
		/// 그룹명
		/// </summary>
		[JsonProperty("name")]
		public string? GroupName;
	}

	/// <summary>
	/// | usa20201 | 미국주식 관심종목 그룹 상세 조회
	/// </summary>
	public record KiwoomUsStockWatchlistGetWatchlistGroupDetails
	{
		/// <summary>
		/// 처리결과
		/// </summary>
		[JsonProperty("rtcd")]
		private string? RawResult { get; set; }
		public KiwoomWatchlistResult Result => RawResult switch
		{
			"S" => KiwoomWatchlistResult.Success,
			"F" => KiwoomWatchlistResult.Failure,
			_ => KiwoomWatchlistResult.Failure
		};
		/// <summary>
		/// 종목갯수
		/// </summary>
		[JsonProperty("nofj")]
		public IEnumerable<KiwoomUsStockWatchlistGetWatchlistGroupDetailItem>? Items;
	}

	public record KiwoomUsStockWatchlistGetWatchlistGroupDetailItem
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("cod2")]
		public string? StockCode;
		/// <summary>
		/// 북마크 구분
		/// </summary>
		[JsonProperty("bgb")]
		public string? Bookmark;
		/// <summary>
		/// 북마크 컬러
		/// </summary>
		[JsonProperty("bgb_clr")]
		public string? BookmarkColor;
		/// <summary>
		/// 메모
		/// </summary>
		[JsonProperty("memo")]
		public string? Memo;
		/// <summary>
		/// 메모 옵션
		/// </summary>
		[JsonProperty("memo_opt")]
		public string? MemoOption;
		/// <summary>
		/// 거래소구분
		/// </summary>
		[JsonProperty("stex_tp")]
		public string? ExchangeType;
	}
}
