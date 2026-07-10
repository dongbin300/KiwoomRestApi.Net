using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.UsStock.StockInfo
{
	/// <summary>
	/// 구분 (ETF 카테고리 리스트 조회 대상)
	/// </summary>
	public enum KiwoomUsStockInfoEtfCategoryQueryType
	{
		/// <summary>
		/// 전체
		/// </summary>
		[EnumMember(Value = "%")]
		All,
		/// <summary>
		/// 카테고리1차
		/// </summary>
		[EnumMember(Value = "1")]
		Category1,
		/// <summary>
		/// 카테고리2차
		/// </summary>
		[EnumMember(Value = "2")]
		Category2
	}
}
