namespace KiwoomRestApi.Net.Enums.RankingInfo
{
	/// <summary>
	/// 조회구분
	/// </summary>
	public enum KiwoomRankingInfoPreviousDayVolumeQueryType
	{
		/// <summary>
		/// 전일거래량 상위100종목
		/// </summary>
		PreviousDayVolumeTop100 = 1,
		/// <summary>
		/// 전일거래대금 상위100종목
		/// </summary>
		PreviousDayTransactionAmountTop100 = 2
	}
}
