namespace KiwoomRestApi.Net.Enums.Theme
{
	/// <summary>
	/// 등락수익구분
	/// </summary>
	public enum KiwoomThemeChangeProfitType
	{
		/// <summary>
		/// 상위기간수익률
		/// </summary>
		TopPeriodProfitRate = 1,
		/// <summary>
		/// 하위기간수익률
		/// </summary>
		BottomPeriodProfitRate = 2,
		/// <summary>
		/// 상위등락률
		/// </summary>
		TopChangeRate = 3,
		/// <summary>
		/// 하위등락률
		/// </summary>
		BottomChangeRate = 4,
	}

}
