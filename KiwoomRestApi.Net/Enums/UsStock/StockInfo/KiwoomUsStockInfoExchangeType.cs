using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.UsStock.StockInfo
{
	/// <summary>
	/// 거래소구분
	/// </summary>
	public enum KiwoomUsStockInfoExchangeType
	{
		/// <summary>
		/// 전체
		/// </summary>
		[EnumMember(Value = "%")]
		All,
		/// <summary>
		/// AMEX
		/// </summary>
		[EnumMember(Value = "NA")]
		Amex,
		/// <summary>
		/// NASDAQ
		/// </summary>
		[EnumMember(Value = "ND")]
		Nasdaq,
		/// <summary>
		/// NYSE
		/// </summary>
		[EnumMember(Value = "NY")]
		Nyse
	}
}
