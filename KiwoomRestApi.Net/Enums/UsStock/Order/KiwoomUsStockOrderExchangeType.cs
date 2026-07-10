using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.UsStock.Order
{
	/// <summary>
	/// 거래소구분
	/// </summary>
	public enum KiwoomUsStockOrderExchangeType
	{
		/// <summary>
		/// NA : AMEX
		/// </summary>
		[EnumMember(Value = "NA")]
		Amex,
		/// <summary>
		/// ND : NASDAQ
		/// </summary>
		[EnumMember(Value = "ND")]
		Nasdaq,
		/// <summary>
		/// NY : NYSE
		/// </summary>
		[EnumMember(Value = "NY")]
		Nyse
	}
}
