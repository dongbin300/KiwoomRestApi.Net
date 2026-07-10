namespace KiwoomRestApi.Net.Enums.UsStock.RankingInfo
{
	/// <summary>
	/// 정렬기준
	/// </summary>
	public enum KiwoomUsStockRankingInfoContinuousSortType
	{
		/// <summary>
		/// 연속일수상승
		/// </summary>
		ConsecutiveDaysRise = 0,
		/// <summary>
		/// 연속일수보합
		/// </summary>
		ConsecutiveDaysFlat = 1,
		/// <summary>
		/// 연속일수하락
		/// </summary>
		ConsecutiveDaysFall = 2,
		/// <summary>
		/// 기준일대비상승
		/// </summary>
		BaseDateRise = 3,
		/// <summary>
		/// 기준일대비보합
		/// </summary>
		BaseDateFlat = 4,
		/// <summary>
		/// 기준일대비하락
		/// </summary>
		BaseDateFall = 5
	}
}
