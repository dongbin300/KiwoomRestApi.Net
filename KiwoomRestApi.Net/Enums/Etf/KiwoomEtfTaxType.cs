namespace KiwoomRestApi.Net.Enums.Etf
{
	public enum KiwoomEtfTaxType
	{
		/// <summary>
		/// 전체
		/// </summary>
		All = 0,
		/// <summary>
		/// 비과세
		/// </summary>
		NonTaxable = 1,
		/// <summary>
		/// 보유기간과세
		/// </summary>
		HoldingPeriodTax = 2,
		/// <summary>
		/// 회사형
		/// </summary>
		CompanyType = 3,
		/// <summary>
		/// 외국
		/// </summary>
		Foreign = 4,
		/// <summary>
		/// 비과세해외(보유기간관세)
		/// </summary>
		NonTaxableOverseas = 5
	}
}
