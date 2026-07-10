namespace KiwoomRestApi.Net.Enums.UsStock.StockInfo
{
	/// <summary>
	/// 가격조건
	/// </summary>
	public enum KiwoomUsStockInfoPriceCondition
	{
		/// <summary>
		/// 전체
		/// </summary>
		All = 0,
		/// <summary>
		/// 5달러 미만
		/// </summary>
		Under5 = 1,
		/// <summary>
		/// 10달러 미만
		/// </summary>
		Under10 = 2,
		/// <summary>
		/// 10달러 이상
		/// </summary>
		Over10 = 3,
		/// <summary>
		/// 10~20달러
		/// </summary>
		From10To20 = 4,
		/// <summary>
		/// 20~50달러
		/// </summary>
		From20To50 = 5,
		/// <summary>
		/// 50달러 이상
		/// </summary>
		Over50 = 6,
		/// <summary>
		/// 50~100달러
		/// </summary>
		From50To100 = 7,
		/// <summary>
		/// 100달러 미만
		/// </summary>
		Under100 = 8,
		/// <summary>
		/// 100달러 이상
		/// </summary>
		Over100 = 9,
		/// <summary>
		/// 500달러 이상
		/// </summary>
		Over500 = 10
	}
}
