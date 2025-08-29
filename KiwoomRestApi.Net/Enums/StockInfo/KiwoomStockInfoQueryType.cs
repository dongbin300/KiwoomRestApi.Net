namespace KiwoomRestApi.Net.Enums.StockInfo
{
	/// <summary>
	/// 구분
	/// </summary>
	public enum KiwoomStockInfoQueryType
	{
		/// <summary>
		/// 1분
		/// </summary>
		OneMinute = 1,
		/// <summary>
		/// 10분
		/// </summary>
		TenMinutes = 2,
		/// <summary>
		/// 1시간
		/// </summary>
		OneHour = 3,
		/// <summary>
		/// 당일 누적
		/// </summary>
		DailyTotal = 4,
		/// <summary>
		/// 30초
		/// </summary>
		ThirtySeconds = 5
	}
}
