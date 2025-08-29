namespace KiwoomRestApi.Net.Enums.RankingInfo
{
	/// <summary>
	/// 장운영구분
	/// </summary>
	public enum KiwoomRankingInfoMarketOpenType
	{
		/// <summary>
		/// 전체조회
		/// </summary>
		All = 0,
		/// <summary>
		/// 장중
		/// </summary>
		DuringMarket = 1,
		/// <summary>
		/// 장전시간외
		/// </summary>
		BeforeMarketExtra = 2,
		/// <summary>
		/// 장후시간외
		/// </summary>
		AfterMarketExtra = 3
	}
}
