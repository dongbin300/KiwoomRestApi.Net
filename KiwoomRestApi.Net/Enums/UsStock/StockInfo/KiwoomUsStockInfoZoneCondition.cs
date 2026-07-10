namespace KiwoomRestApi.Net.Enums.UsStock.StockInfo
{
	/// <summary>
	/// 조건 (매물대 기준 현재가 위치)
	/// </summary>
	public enum KiwoomUsStockInfoZoneCondition
	{
		/// <summary>
		/// 전체
		/// </summary>
		All = 0,
		/// <summary>
		/// 현재가 매물대 진입
		/// </summary>
		EnteringZone = 1,
		/// <summary>
		/// 현재가 매물대 위
		/// </summary>
		AboveZone = 2,
		/// <summary>
		/// 현재가 매물대 아래
		/// </summary>
		BelowZone = 3
	}
}
