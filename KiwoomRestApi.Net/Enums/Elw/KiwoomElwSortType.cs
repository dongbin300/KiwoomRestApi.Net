namespace KiwoomRestApi.Net.Enums.Elw
{
	public enum KiwoomElwSortType
	{
		/// <summary>
		/// 정렬없음
		/// </summary>
		None = 0,
		/// <summary>
		/// 상승율순
		/// </summary>
		AscendingRate = 1,
		/// <summary>
		/// 상승폭순
		/// </summary>
		AscendingDelta = 2,
		/// <summary>
		/// 하락율순
		/// </summary>
		DescendingRate = 3,
		/// <summary>
		/// 하락폭순
		/// </summary>
		DescendingDelta = 4,
		/// <summary>
		/// 거래량순
		/// </summary>
		Volume = 5,
		/// <summary>
		/// 거래대금순
		/// </summary>
		TradeAmount = 6,
		/// <summary>
		/// 잔존일순
		/// </summary>
		RemainingDays = 7,
	}

	public enum KiwoomElwSortType2
	{
		/// <summary>
		/// 순매수 잔량 상위
		/// </summary>
		NetBuyTop = 1,
		/// <summary>
		/// 순매도 잔량 상위
		/// </summary>
		NetSellTop = 2
	}
}
