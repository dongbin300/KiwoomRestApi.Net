using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.Account
{
	/// <summary>
	/// 시장거래구분
	/// </summary>
	public enum KiwoomAccountMarketDealType
	{
		/// <summary>
		/// 전체
		/// </summary>
		[EnumMember(Value = "%")]
		All,
		/// <summary>
		/// 코스피
		/// </summary>
		[EnumMember(Value = "1")]
		Kospi,
		/// <summary>
		/// 코스닥
		/// </summary>
		[EnumMember(Value = "0")]
		Kosdaq
	}
}
