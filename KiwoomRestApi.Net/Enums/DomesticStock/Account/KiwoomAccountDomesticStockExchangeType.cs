using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.DomesticStock.Account
{
	/// <summary>
	/// 국내거래소구분
	/// </summary>
	public enum KiwoomAccountDomesticStockExchangeType
	{
		/// <summary>
		/// 전체
		/// </summary>
		[EnumMember(Value = "%")]
		All,
		/// <summary>
		/// KRX
		/// </summary>
		[EnumMember(Value = "KRX")]
		Krx,
		/// <summary>
		/// NXT
		/// </summary>
		[EnumMember(Value = "NXT")]
		Nxt,
		/// <summary>
		/// SOR
		/// </summary>
		[EnumMember(Value = "SOR")]
		Sor
	}

	/// <summary>
	/// 국내거래소구분
	/// </summary>
	public enum KiwoomAccountDomesticStockExchangeType2
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
