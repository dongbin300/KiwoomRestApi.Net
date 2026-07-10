using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.UsStock.StockInfo
{
	/// <summary>
	/// 구분 (업종리스트 조회 대상)
	/// </summary>
	public enum KiwoomUsStockInfoIndustryQueryType
	{
		/// <summary>
		/// 전체
		/// </summary>
		[EnumMember(Value = "%")]
		All,
		/// <summary>
		/// 미국
		/// </summary>
		[EnumMember(Value = "1")]
		UsStock
	}
}
