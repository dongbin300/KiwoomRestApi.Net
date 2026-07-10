namespace KiwoomRestApi.Net.Enums.UsStock.StockInfo
{
	/// <summary>
	/// 거래대금조건 (단위: USD, 1만달러 단위)
	/// </summary>
	public enum KiwoomUsStockInfoTradeAmountCondition
	{
		/// <summary>
		/// 전체
		/// </summary>
		All = 0,
		/// <summary>
		/// 1만달러 이상
		/// </summary>
		Over10K = 1,
		/// <summary>
		/// 3만달러 이상
		/// </summary>
		Over30K = 3,
		/// <summary>
		/// 5만달러 이상
		/// </summary>
		Over50K = 5,
		/// <summary>
		/// 10만달러 이상
		/// </summary>
		Over100K = 10,
		/// <summary>
		/// 30만달러 이상
		/// </summary>
		Over300K = 30,
		/// <summary>
		/// 50만달러 이상
		/// </summary>
		Over500K = 50,
		/// <summary>
		/// 100만달러 이상
		/// </summary>
		Over1M = 100,
		/// <summary>
		/// 300만달러 이상
		/// </summary>
		Over3M = 300,
		/// <summary>
		/// 500만달러 이상
		/// </summary>
		Over5M = 500,
		/// <summary>
		/// 1000만달러 이상
		/// </summary>
		Over10M = 1000,
		/// <summary>
		/// 3000만달러 이상
		/// </summary>
		Over30M = 3000,
		/// <summary>
		/// 5000만달러 이상
		/// </summary>
		Over50M = 5000
	}
}
