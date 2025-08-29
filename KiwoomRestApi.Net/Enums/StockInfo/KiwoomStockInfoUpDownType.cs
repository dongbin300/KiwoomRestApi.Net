namespace KiwoomRestApi.Net.Enums.StockInfo
{
	/// <summary>
	/// 상하한구분
	/// </summary>
	public enum KiwoomStockInfoUpDownType
	{
		/// <summary>
		/// 상한
		/// </summary>
		UpperLimit = 1,
		/// <summary>
		/// 상승
		/// </summary>
		Rise = 2,
		/// <summary>
		/// 보합
		/// </summary>
		Steady = 3,
		/// <summary>
		/// 하한
		/// </summary>
		LowerLimit = 4,
		/// <summary>
		/// 하락
		/// </summary>
		Fall = 5,
		/// <summary>
		/// 전일상한
		/// </summary>
		PreviousDayUpperLimit = 6,
		/// <summary>
		/// 전일하한
		/// </summary>
		PreviousDayLowerLimit = 7
	}
}
