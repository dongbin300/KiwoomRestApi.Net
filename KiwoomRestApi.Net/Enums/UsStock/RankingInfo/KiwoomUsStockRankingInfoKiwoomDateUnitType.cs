namespace KiwoomRestApi.Net.Enums.UsStock.RankingInfo
{
	/// <summary>
	/// 일,주,월단위구분 (미국/미국ETF는 분단위도 지원)
	/// </summary>
	public enum KiwoomUsStockRankingInfoKiwoomDateUnitType
	{
		/// <summary>
		/// 일
		/// </summary>
		Day = 1,
		/// <summary>
		/// 주
		/// </summary>
		Week = 2,
		/// <summary>
		/// 월
		/// </summary>
		Month = 3,
		/// <summary>
		/// 년
		/// </summary>
		Year = 4,
		/// <summary>
		/// 10분
		/// </summary>
		Minutes10 = 5,
		/// <summary>
		/// 30분
		/// </summary>
		Minutes30 = 6,
		/// <summary>
		/// 60분
		/// </summary>
		Minutes60 = 7,
		/// <summary>
		/// 5분
		/// </summary>
		Minutes5 = 8
	}
}
