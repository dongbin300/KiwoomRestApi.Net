namespace KiwoomRestApi.Net.Enums.StockInfo
{
	/// <summary>
	/// 발동구분
	/// </summary>
	public enum KiwoomStockInfoTriggerType
	{
		/// <summary>
		/// 전체
		/// </summary>
		All = 0,
		/// <summary>
		/// 정적VI
		/// </summary>
		StaticVI = 1,
		/// <summary>
		/// 동적VI
		/// </summary>
		DynamicVI = 2,
		/// <summary>
		/// 동적VI + 정적VI
		/// </summary>
		Both = 3
	}
}
