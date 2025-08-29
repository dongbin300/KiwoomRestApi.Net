namespace KiwoomRestApi.Net.Enums.Etf
{
	/// <summary>
	/// NAV대비
	/// </summary>
	public enum KiwoomEtfNavComparison
	{
		/// <summary>
		/// 전체
		/// </summary>
		All = 0,
		/// <summary>
		/// NAV > 전일종가
		/// </summary>
		NavGreaterThanPreviousClose = 1,
		/// <summary>
		/// 전일종가 > NAV
		/// </summary>
		NavLessThanPreviousClose = 2
	}
}
