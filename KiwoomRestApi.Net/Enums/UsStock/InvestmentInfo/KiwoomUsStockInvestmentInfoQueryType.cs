using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.UsStock.InvestmentInfo
{
	/// <summary>
	/// 주식/ETF 구분
	/// </summary>
	public enum KiwoomUsStockInvestmentInfoQueryType
	{
		/// <summary>
		/// 미국주식
		/// </summary>
		[EnumMember(Value = "0")]
		UsStock,
		/// <summary>
		/// 글로벌ETF
		/// </summary>
		[EnumMember(Value = "1")]
		GlobalEtf
	}
}
