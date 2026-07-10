namespace KiwoomRestApi.Net.Enums.UsStock.StockInfo
{
	/// <summary>
	/// 분전, 전일 구분
	/// </summary>
	public enum KiwoomUsStockInfoTimeBasisType
	{
		/// <summary>
		/// 분전
		/// </summary>
		MinutesAgo = 1,
		/// <summary>
		/// 일전
		/// </summary>
		DaysAgo = 2,
		/// <summary>
		/// 지정일
		/// </summary>
		SpecifiedDate = 3
	}
}
