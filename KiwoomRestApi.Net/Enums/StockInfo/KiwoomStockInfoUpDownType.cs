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
		Upper = 1,
		/// <summary>
		/// 상승
		/// </summary>
		Up = 2,
		/// <summary>
		/// 보합
		/// </summary>
		Flat = 3,
		/// <summary>
		/// 하한
		/// </summary>
		Lower = 4,
		/// <summary>
		/// 하락
		/// </summary>
		Down = 5,
		/// <summary>
		/// 전일상한
		/// </summary>
		PreviousDayUpper = 6,
		/// <summary>
		/// 전일하한
		/// </summary>
		PreviousDayLower = 7
	}
}
