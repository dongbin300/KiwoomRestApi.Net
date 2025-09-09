namespace KiwoomRestApi.Net.Enums.Etf
{
	/// <summary>
	/// NAV대비
	/// </summary>
	public enum KiwoomEtfNavChange
	{
		/// <summary>
		/// 전체
		/// </summary>
		All = 0,
		/// <summary>
		/// NAV > 전일종가
		/// </summary>
		NavGreaterThanPreviousDayClose = 1,
		/// <summary>
		/// 전일종가 > NAV
		/// </summary>
		NavLessThanPreviousDayClose = 2
	}
}
