namespace KiwoomRestApi.Net.Enums.UsStock.StockInfo
{
	/// <summary>
	/// 거래량조건 (단위: 1만주)
	/// </summary>
	public enum KiwoomUsStockInfoTradeVolumeCondition
	{
		/// <summary>
		/// 전체
		/// </summary>
		All = 0,
		/// <summary>
		/// 10만주 이상
		/// </summary>
		Over100K = 10,
		/// <summary>
		/// 15만주 이상
		/// </summary>
		Over150K = 15,
		/// <summary>
		/// 20만주 이상
		/// </summary>
		Over200K = 20,
		/// <summary>
		/// 30만주 이상
		/// </summary>
		Over300K = 30,
		/// <summary>
		/// 50만주 이상
		/// </summary>
		Over500K = 50,
		/// <summary>
		/// 100만주 이상
		/// </summary>
		Over1M = 100,
		/// <summary>
		/// 300만주 이상
		/// </summary>
		Over3M = 300,
		/// <summary>
		/// 500만주 이상
		/// </summary>
		Over5M = 500
	}
}
