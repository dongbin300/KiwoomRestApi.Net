namespace KiwoomRestApi.Net.Enums.UsStock.RankingInfo
{
	/// <summary>
	/// 정렬기준 구분
	/// </summary>
	public enum KiwoomUsStockRankingInfoSortType
	{
		/// <summary>
		/// 거래량상위
		/// </summary>
		Volume = 0,
		/// <summary>
		/// 거래대금상위
		/// </summary>
		TransactionAmount = 1,
		/// <summary>
		/// 거래회전율상위
		/// </summary>
		TurnoverRate = 2
	}
}
