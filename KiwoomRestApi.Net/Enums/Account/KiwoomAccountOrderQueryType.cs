namespace KiwoomRestApi.Net.Enums.Account
{
	/// <summary>
	/// 조회구분
	/// </summary>
	public enum KiwoomAccountOrderQueryType
	{
		/// <summary>
		/// 주문순
		/// </summary>
		OrderSequence = 1,
		/// <summary>
		/// 역순
		/// </summary>
		ReverseOrder = 2,
		/// <summary>
		/// 미체결
		/// </summary>
		Unconfirmed = 3,
		/// <summary>
		/// 체결내역만
		/// </summary>
		ConfirmedOnly = 4
	}
}
