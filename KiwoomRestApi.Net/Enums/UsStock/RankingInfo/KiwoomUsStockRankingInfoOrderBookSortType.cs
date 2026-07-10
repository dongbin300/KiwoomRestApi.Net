namespace KiwoomRestApi.Net.Enums.UsStock.RankingInfo
{
	/// <summary>
	/// 정렬기준
	/// </summary>
	public enum KiwoomUsStockRankingInfoOrderBookSortType
	{
		/// <summary>
		/// 순매수잔량순
		/// </summary>
		NetBuyRemainingQuantity = 1,
		/// <summary>
		/// 순매도잔량순
		/// </summary>
		NetSellRemainingQuantity = 2,
		/// <summary>
		/// 순매수비율순
		/// </summary>
		NetBuyRate = 3,
		/// <summary>
		/// 순매도비율순
		/// </summary>
		NetSellRate = 4
	}
}
