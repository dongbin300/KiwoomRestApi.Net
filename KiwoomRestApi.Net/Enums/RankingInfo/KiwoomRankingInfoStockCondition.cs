namespace KiwoomRestApi.Net.Enums.RankingInfo
{
	/// <summary>
	/// 종목조건
	/// </summary>
	public enum KiwoomRankingInfoStockCondition
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
		ExcludeManagedAndPreferred = 4,
		/// <summary>
		/// 증100제외
		/// </summary>
		ExcludeKOSPI100 = 5,
		/// <summary>
		/// 증100만보기
		/// </summary>
		OnlyKOSPI100 = 6,
		/// <summary>
		/// 증40만보기
		/// </summary>
		OnlyKOSPI40 = 7,
		/// <summary>
		/// 증30만보기
		/// </summary>
		OnlyKOSPI30 = 8,
		/// <summary>
		/// 증20만보기
		/// </summary>
		OnlyKOSPI20 = 9,
		/// <summary>
		/// 정리매매종목제외
		/// </summary>
		ExcludeDelistingTrade = 11,
		/// <summary>
		/// 증50만보기
		/// </summary>
		OnlyKOSPI50 = 12,
		/// <summary>
		/// 증60만보기
		/// </summary>
		OnlyKOSPI60 = 13,
		/// <summary>
		/// ETF제외
		/// </summary>
		ExcludeETF = 14,
		/// <summary>
		/// 스팩제외
		/// </summary>
		ExcludeSPAC = 15,
		/// <summary>
		/// ETF+ETN제외
		/// </summary>
		ExcludeETF_ETN = 16,
		/// <summary>
		/// ETN제외
		/// </summary>
		ExcludeETN = 17,
		/// <summary>
		/// ETF+ETN제외
		/// </summary>
		ExcludeETF_ETN2 = 18,
		/// <summary>
		/// ETF+ETN+스팩제외
		/// </summary>
		ExcludeETF_ETN_SPAC = 20
	}
}
