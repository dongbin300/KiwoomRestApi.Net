using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.CreditOrder
{
	/// <summary>
	/// 국내거래소구분
	/// </summary>
	public enum KiwoomCreditOrderDomesticStockExchangeType
	{
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
