namespace KiwoomRestApi.Net.Enums.RankingInfo
{
	/// <summary>
	/// 조회기간구분
	/// </summary>
	public enum KiwoomRankingInfoTradeOriginRankQueryDateType
	{
		/// <summary>
		/// 기간으로 조회
		/// </summary>
		ByPeriod = 0,
		/// <summary>
		/// 시작일자, 종료일자로 조회
		/// </summary>
		ByStartAndEndDate = 1
	}
}
