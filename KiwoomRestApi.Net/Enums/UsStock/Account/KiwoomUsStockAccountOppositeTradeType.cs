using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.UsStock.Account
{
	/// <summary>
	/// 반대매매구분
	/// </summary>
	public enum KiwoomUsStockAccountOppositeTradeType
	{
		/// <summary>
		/// 전체
		/// </summary>
		[EnumMember(Value = "%")]
		All,
		/// <summary>
		/// 일반
		/// </summary>
		[EnumMember(Value = "0")]
		Normal,
		/// <summary>
		/// 반대매매
		/// </summary>
		[EnumMember(Value = "1")]
		OppositeTrade
	}
}
