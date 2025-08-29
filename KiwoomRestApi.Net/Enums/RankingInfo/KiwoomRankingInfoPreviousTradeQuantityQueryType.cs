namespace KiwoomRestApi.Net.Enums.RankingInfo
{
	/// <summary>
	/// 조회구분
	/// </summary>
	public enum KiwoomRankingInfoPreviousTradeQuantityQueryType
	{
		/// <summary>
		/// 전일거래량 상위100종목
		/// </summary>
		Top100ByYesterdayVolume = 1,
		/// <summary>
		/// 전일거래대금 상위100종목
		/// </summary>
		Top100ByYesterdayTransactionAmount = 2
	}
}
