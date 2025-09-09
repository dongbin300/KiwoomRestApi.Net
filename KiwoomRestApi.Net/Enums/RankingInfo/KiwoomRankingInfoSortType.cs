namespace KiwoomRestApi.Net.Enums.RankingInfo
{
	/// <summary>
	/// 정렬구분
	/// </summary>
	public enum KiwoomRankingInfoSortType
	{
		/// <summary>
		/// 순매수잔량순
		/// </summary>
		NetBuyQuantity = 1,
		/// <summary>
		/// 순매도잔량순
		/// </summary>
		NetSellQuantity = 2,
		/// <summary>
		/// 매수비율순
		/// </summary>
		BuyRate = 3,
		/// <summary>
		/// 매도비율순
		/// </summary>
		SellRate = 4
	}
}
