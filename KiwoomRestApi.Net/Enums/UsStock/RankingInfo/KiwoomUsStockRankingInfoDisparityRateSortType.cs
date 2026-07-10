namespace KiwoomRestApi.Net.Enums.UsStock.RankingInfo
{
	/// <summary>
	/// 정렬기준 구분
	/// </summary>
	public enum KiwoomUsStockRankingInfoDisparityRateSortType
	{
		/// <summary>
		/// 상승률
		/// </summary>
		RiseRate = 0,
		/// <summary>
		/// 상승폭
		/// </summary>
		RiseAmount = 1,
		/// <summary>
		/// 보합
		/// </summary>
		Flat = 2,
		/// <summary>
		/// 하락율
		/// </summary>
		FallRate = 3,
		/// <summary>
		/// 하락폭
		/// </summary>
		FallAmount = 4
	}
}
