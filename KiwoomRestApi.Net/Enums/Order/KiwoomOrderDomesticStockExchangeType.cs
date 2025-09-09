using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.Order
{
	/// <summary>
	/// 국내거래소구분
	/// </summary>
	public enum KiwoomOrderDomesticStockExchangeType
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
		Nxt,
		/// <summary>
		/// SOR
		/// </summary>
		[EnumMember(Value = "SOR")]
		Sor
	}
}
