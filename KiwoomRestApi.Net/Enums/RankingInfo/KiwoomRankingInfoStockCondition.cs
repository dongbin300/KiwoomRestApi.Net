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
		/// 정리매매종목제외
		/// </summary>
		ExcludeDelistingStock = 11,
		/// <summary>
		/// 증50만보기
		/// </summary>
		OnlyKospi50 = 12,
		/// <summary>
		/// 증60만보기
		/// </summary>
		OnlyKospi60 = 13,
		/// <summary>
		/// ETF제외
		/// </summary>
		ExcludeEtf = 14,
		/// <summary>
		/// 스팩제외
		/// </summary>
		ExcludeSpac = 15,
		/// <summary>
		/// ETF+ETN제외
		/// </summary>
		ExcludeEtfEtn = 16,
		/// <summary>
		/// ETN제외
		/// </summary>
		ExcludeEtn = 17,
		/// <summary>
		/// ETF+ETN제외
		/// </summary>
		ExcludeEtfEtn2 = 18,
		/// <summary>
		/// ETF+ETN+스팩제외
		/// </summary>
		ExcludeEtfEtNSpac = 20
	}
}
