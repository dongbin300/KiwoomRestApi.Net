namespace KiwoomRestApi.Net.Enums.RankingInfo
{
	/// <summary>
	/// 정렬구분
	/// </summary>
	public enum KiwoomRankingInfoContractFluctuationSortType
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
		/// 보합
		/// </summary>
		Steady = 3,
		/// <summary>
		/// 하락률
		/// </summary>
		DecreaseRate = 4,
		/// <summary>
		/// 하락폭
		/// </summary>
		DecreaseAmount = 5,
		/// <summary>
		/// 체결량
		/// </summary>
		TradingVolume = 6,
		/// <summary>
		/// 상한
		/// </summary>
		UpperLimit = 7,
		/// <summary>
		/// 하한
		/// </summary>
		LowerLimit = 8
	}
}
