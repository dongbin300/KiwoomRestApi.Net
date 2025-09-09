namespace KiwoomRestApi.Net.Enums.StockInfo
{
	/// <summary>
	/// 종목조건
	/// </summary>
	public enum KiwoomStockInfoStockCondition
	{
		/// <summary>
		/// 전체조회
		/// </summary>
		All = 0,
		/// <summary>
		/// 관리종목제외
		/// </summary>
		ExcludeManaged = 1,
		/// <summary>
		/// 우선주제외
		/// </summary>
		ExcludePreferredStock = 3,
		/// <summary>
		/// 관리종목,우선주제외
		/// </summary>
		ExcludeManagedPreferred = 4,
		/// <summary>
		/// 증100제외
		/// </summary>
		ExcludeKospi100 = 5,
		/// <summary>
		/// 증100만보기
		/// </summary>
		OnlyKospi100 = 6,
		/// <summary>
		/// 증40만보기
		/// </summary>
		OnlyKospi40 = 7,
		/// <summary>
		/// 증30만보기
		/// </summary>
		OnlyKospi30 = 8,
		/// <summary>
		/// 증20만보기
		/// </summary>
		OnlyKospi20 = 9,
		/// <summary>
		/// 우선주,관리종목,환기종목 제외
		/// </summary>
		ExcludeManagedPreferredCaution = 10
	}
}
