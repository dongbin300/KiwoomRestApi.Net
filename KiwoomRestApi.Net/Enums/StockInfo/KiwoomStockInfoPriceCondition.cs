namespace KiwoomRestApi.Net.Enums.StockInfo
{
	/// <summary>
	/// 매매금구분
	/// </summary>
	public enum KiwoomStockInfoPriceCondition
	{
		/// <summary>
		/// 전체조회
		/// </summary>
		All = 0,
		/// <summary>
		/// 1천원미만
		/// </summary>
		Under1KWon = 1,
		/// <summary>
		/// 1천원~2천원
		/// </summary>
		From1KTo2KWon = 2,
		/// <summary>
		/// 2천원~3천원
		/// </summary>
		From2KTo3KWon = 3,
		/// <summary>
		/// 5천원~1만원
		/// </summary>
		From5KTo10KWon = 4,
		/// <summary>
		/// 1만원이상
		/// </summary>
		Over10KWon = 5,
		/// <summary>
		/// 1천원이상
		/// </summary>
		Over1KWon = 8
	}
}
