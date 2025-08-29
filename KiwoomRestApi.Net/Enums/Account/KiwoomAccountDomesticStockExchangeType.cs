using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.Account
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
		KRX,
		/// <summary>
		/// NXT
		/// </summary>
		[EnumMember(Value = "NXT")]
		NXT,
		/// <summary>
		/// SOR
		/// </summary>
		[EnumMember(Value = "SOR")]
		SOR
	}
}
