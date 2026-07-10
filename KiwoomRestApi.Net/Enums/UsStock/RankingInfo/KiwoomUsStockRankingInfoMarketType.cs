using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.UsStock.RankingInfo
{
	/// <summary>
	/// 시장구분
	/// </summary>
	public enum KiwoomUsStockRankingInfoMarketType
	{
		/// <summary>
		/// 전체
		/// </summary>
		[EnumMember(Value = "A")]
		All,
		/// <summary>
		/// 주식
		/// </summary>
		[EnumMember(Value = "S")]
		Stock,
		/// <summary>
		/// ETF
		/// </summary>
		[EnumMember(Value = "E")]
		Etf
	}
}
