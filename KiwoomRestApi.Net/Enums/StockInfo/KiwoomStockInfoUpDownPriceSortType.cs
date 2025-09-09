namespace KiwoomRestApi.Net.Enums.StockInfo
{
	/// <summary>
	/// 정렬구분
	/// </summary>
	public enum KiwoomStockInfoUpDownPriceSortType
	{
		/// <summary>
		/// 종목코드순
		/// </summary>
		StockCode = 1,
		/// <summary>
		/// 연속횟수순(상위100개)
		/// </summary>
		ConsecutiveCount = 2,
		/// <summary>
		/// 등락률순
		/// </summary>
		ChangeRate = 3
	}
}
