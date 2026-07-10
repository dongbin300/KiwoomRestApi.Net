namespace KiwoomRestApi.Net.Enums.UsStock.RankingInfo
{
	/// <summary>
	/// 조회구분
	/// </summary>
	public enum KiwoomUsStockRankingInfoKiwoomQueryType
	{
		/// <summary>
		/// 매수상위
		/// </summary>
		Buy = 1,
		/// <summary>
		/// 매도상위
		/// </summary>
		Sell = 2,
		/// <summary>
		/// 순매수상위
		/// </summary>
		NetBuy = 3,
		/// <summary>
		/// 보유잔고상위
		/// </summary>
		Holding = 4,
		/// <summary>
		/// 보유고객상위
		/// </summary>
		HoldingCustomer = 5,
		/// <summary>
		/// 거래비중상위 (미국, 미국 ETF 분단위만 존재)
		/// </summary>
		TradeWeight = 6,
		/// <summary>
		/// 거래대금상위 (미국, 미국 ETF 분단위만 존재)
		/// </summary>
		TransactionAmount = 7
	}
}
