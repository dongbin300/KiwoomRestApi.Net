using KiwoomRestApi.Net.Enums.Watchlist;

using Newtonsoft.Json;

using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models
{
	public record KiwoomWatchlistGetWatchlistGroups
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
		public IEnumerable<KiwoomWatchlistGetWatchlistGroupItem>? Items;
	}
	public record KiwoomWatchlistGetWatchlistGroupItem
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

	public record KiwoomWatchlistGetWatchlistGroupDetails
	{
		/// <summary>
		/// 처리 결과
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
		/// 종목 갯수
		/// </summary>
		[JsonProperty("nofj")]
		public IEnumerable<KiwoomWatchlistGetWatchlistGroupDetailItem>? Items;
	}
	public record KiwoomWatchlistGetWatchlistGroupDetailItem
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
	}
}
