namespace KiwoomRestApi.Net.Enums.RankingInfo
{
	/// <summary>
	/// 정렬구분
	/// </summary>
	public enum KiwoomRankingInfoTradeChangeSortType
	{
		/// <summary>
		/// 상승률
		/// </summary>
		UpRate = 1,
		/// <summary>
		/// 상승폭
		/// </summary>
		Up = 2,
		/// <summary>
		/// 보합
		/// </summary>
		Flat = 3,
		/// <summary>
		/// 하락률
		/// </summary>
		DownRate = 4,
		/// <summary>
		/// 하락폭
		/// </summary>
		Down = 5,
		/// <summary>
		/// 체결량
		/// </summary>
		Quantity = 6,
		/// <summary>
		/// 상한
		/// </summary>
		Upper = 7,
		/// <summary>
		/// 하한
		/// </summary>
		Lower = 8
	}
}
