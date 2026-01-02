using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.Account
{
	/// <summary>
	/// 거래소구분
	/// </summary>
	public enum KiwoomAccountStockExchangeType
	{
		/// <summary>
		/// 통합
		/// </summary>
		Unified = 0,
		/// <summary>
		/// KRX
		/// </summary>
		Krx = 1,
		/// <summary>
		/// NXT
		/// </summary>
		Nxt = 2
	}

	/// <summary>
	/// 거래소구분
	/// </summary>
	public enum KiwoomAccountStockExchangeType2
	{
		/// <summary>
		/// KRX
		/// </summary>
		[EnumMember(Value = "KRX")]
		Krx,
		/// <summary>
		/// NXT
		/// </summary>
		[EnumMember(Value = "NXT")]
		Nxt
	}
}
