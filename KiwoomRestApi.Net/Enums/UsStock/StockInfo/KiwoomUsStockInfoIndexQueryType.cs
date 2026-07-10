using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.UsStock.StockInfo
{
	/// <summary>
	/// 업종지수구분
	/// </summary>
	public enum KiwoomUsStockInfoIndexQueryType
	{
		/// <summary>
		/// 전체
		/// </summary>
		[EnumMember(Value = "%")]
		All,
		/// <summary>
		/// 나스닥
		/// </summary>
		[EnumMember(Value = "NQ")]
		Nasdaq,
		/// <summary>
		/// S&amp;P500
		/// </summary>
		[EnumMember(Value = "NS")]
		SnP500,
		/// <summary>
		/// 다우
		/// </summary>
		[EnumMember(Value = "NW")]
		Dow
	}
}
