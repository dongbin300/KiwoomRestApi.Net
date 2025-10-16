namespace KiwoomRestApi.Net.Enums.Order
{
	/// <summary>
	/// 금현물 매매구분
	/// </summary>
	public enum KiwoomOrderGoldSpotTransactionType
	{
		/// <summary>
		/// 보통
		/// </summary>
		Normal = 0,
		/// <summary>
		/// 보통(IOC)
		/// </summary>
		NormalIoc = 10,
		/// <summary>
		/// 보통(FOK)
		/// </summary>
		NormalFok = 20,
	}
}
