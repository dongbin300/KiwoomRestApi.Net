namespace KiwoomRestApi.Net.Enums.UsStock.RankingInfo
{
	/// <summary>
	/// 정렬기준구분
	/// </summary>
	public enum KiwoomUsStockRankingInfoCumulativeSortType
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
		/// 하락률
		/// </summary>
		FallRate = 3,
		/// <summary>
		/// 하락폭
		/// </summary>
		FallAmount = 4
	}
}
