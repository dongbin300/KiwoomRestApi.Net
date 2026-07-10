using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.UsStock.MarketCondition
{
	/// <summary>
	/// 거래소구분
	/// </summary>
	public enum KiwoomUsStockMarketConditionExchangeType
	{
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
