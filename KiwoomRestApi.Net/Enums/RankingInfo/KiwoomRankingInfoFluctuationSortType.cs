namespace KiwoomRestApi.Net.Enums.RankingInfo
{
	/// <summary>
	/// 정렬구분
	/// </summary>
	public enum KiwoomRankingInfoFluctuationSortType
	{
		/// <summary>
		/// 상승률
		/// </summary>
		IncreaseRate = 1,
		/// <summary>
		/// 상승폭
		/// </summary>
		IncreaseAmount = 2,
		/// <summary>
		/// 하락률
		/// </summary>
		DecreaseRate = 3,
		/// <summary>
		/// 하락폭
		/// </summary>
		DecreaseAmount = 4,
		/// <summary>
		/// 보합
		/// </summary>
		Steady = 5
	}
}
