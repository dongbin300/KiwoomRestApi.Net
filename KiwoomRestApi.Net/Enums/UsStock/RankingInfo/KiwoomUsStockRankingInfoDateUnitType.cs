using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.UsStock.RankingInfo
{
	/// <summary>
	/// 일,주,월단위구분
	/// </summary>
	public enum KiwoomUsStockRankingInfoDateUnitType
	{
		/// <summary>
		/// 일
		/// </summary>
		[EnumMember(Value = "D")]
		Day,
		/// <summary>
		/// 주
		/// </summary>
		[EnumMember(Value = "W")]
		Week,
		/// <summary>
		/// 월
		/// </summary>
		[EnumMember(Value = "M")]
		Month
	}
}
