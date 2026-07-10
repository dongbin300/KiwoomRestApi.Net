namespace KiwoomRestApi.Net.Enums.UsStock.RankingInfo
{
	/// <summary>
	/// 정렬기준
	/// </summary>
	public enum KiwoomUsStockRankingInfoChangeSortType
	{
		/// <summary>
		/// 전일대비 상승률
		/// </summary>
		RiseRate = 1,
		/// <summary>
		/// 전일대비 상승폭
		/// </summary>
		RiseAmount = 2,
		/// <summary>
		/// 보합
		/// </summary>
		Flat = 3,
		/// <summary>
		/// 전일대비 하락률
		/// </summary>
		FallRate = 4,
		/// <summary>
		/// 전일대비 하락폭
		/// </summary>
		FallAmount = 5
	}
}
