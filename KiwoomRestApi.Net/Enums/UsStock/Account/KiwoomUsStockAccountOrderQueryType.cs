namespace KiwoomRestApi.Net.Enums.UsStock.Account
{
	/// <summary>
	/// 조회구분
	/// </summary>
	public enum KiwoomUsStockAccountOrderQueryType
	{
		/// <summary>
		/// 주문순
		/// </summary>
		OrderAscending = 1,
		/// <summary>
		/// 주문역순
		/// </summary>
		OrderDescending = 2,
		/// <summary>
		/// 미체결주문순
		/// </summary>
		UnfilledAscending = 3,
		/// <summary>
		/// 미체결역순
		/// </summary>
		UnfilledDescending = 4,
		/// <summary>
		/// 체결주문순
		/// </summary>
		FilledAscending = 5,
		/// <summary>
		/// 체결역순
		/// </summary>
		FilledDescending = 6
	}
}
