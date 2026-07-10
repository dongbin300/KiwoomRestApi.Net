namespace KiwoomRestApi.Net.Enums.UsStock.Account
{
	/// <summary>
	/// 환율구분
	/// </summary>
	public enum KiwoomUsStockAccountExchangeRateType
	{
		/// <summary>
		/// 기준환율
		/// </summary>
		BaseExchangeRate = 0,
		/// <summary>
		/// 계좌적용환율
		/// </summary>
		AccountAppliedExchangeRate = 1,
		/// <summary>
		/// 전일최종환율
		/// </summary>
		PreviousDayFinalExchangeRate = 2
	}
}
