namespace KiwoomRestApi.Net.Enums.Account
{
	/// <summary>
	/// 거래종류구분
	/// </summary>
	public enum KiwoomAccountTradeCategoryType
	{
		/// <summary>
		/// 입출금
		/// </summary>
		DepositWithdrawal = 1,
		/// <summary>
		/// 펀드
		/// </summary>
		Fund = 2,
		/// <summary>
		/// ELS
		/// </summary>
		ELS = 3,
		/// <summary>
		/// 채권
		/// </summary>
		Bond = 4,
		/// <summary>
		/// 해외채권
		/// </summary>
		OverseasBond = 5,
		/// <summary>
		/// 외화RP
		/// </summary>
		ForeignCurrencyRP = 6,
		/// <summary>
		/// 외화발행어음
		/// </summary>
		ForeignCurrencyPromissoryNote = 7
	}
}
