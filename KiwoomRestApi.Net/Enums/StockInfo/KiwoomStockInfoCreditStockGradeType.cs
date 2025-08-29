using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.StockInfo
{
	/// <summary>
	/// 신용종목등급구분
	/// </summary>
	public enum KiwoomStockInfoCreditStockGradeType
	{
		/// <summary>
		/// 전체
		/// </summary>
		[EnumMember(Value = "%")]
		All,
		/// <summary>
		/// A군
		/// </summary>
		[EnumMember(Value = "A")]
		A,
		/// <summary>
		/// B군
		/// </summary>
		[EnumMember(Value = "B")]
		B,
		/// <summary>
		/// C군
		/// </summary>
		[EnumMember(Value = "C")]
		C,
		/// <summary>
		/// D군
		/// </summary>
		[EnumMember(Value = "D")]
		D,
		/// <summary>
		/// E군
		/// </summary>
		[EnumMember(Value = "E")]
		E
	}
}
