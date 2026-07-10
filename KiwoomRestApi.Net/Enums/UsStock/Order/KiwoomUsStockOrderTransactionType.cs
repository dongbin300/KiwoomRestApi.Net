using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.UsStock.Order
{
	/// <summary>
	/// 해외매매구분
	/// </summary>
	public enum KiwoomUsStockOrderTransactionType
	{
		/// <summary>
		/// 00 : 지정가
		/// </summary>
		[EnumMember(Value = "00")]
		Limit,
		/// <summary>
		/// 03 : 시장가
		/// </summary>
		[EnumMember(Value = "03")]
		Market,
		/// <summary>
		/// 26 : VWAP지정가
		/// </summary>
		[EnumMember(Value = "26")]
		VwapLimit,
		/// <summary>
		/// 27 : TWAP지정가
		/// </summary>
		[EnumMember(Value = "27")]
		TwapLimit,
		/// <summary>
		/// 30 : LOC
		/// </summary>
		[EnumMember(Value = "30")]
		Loc,
		/// <summary>
		/// 33 : MOC
		/// </summary>
		[EnumMember(Value = "33")]
		Moc,
		/// <summary>
		/// 34 : STOP LIMIT
		/// </summary>
		[EnumMember(Value = "34")]
		StopLimit,
		/// <summary>
		/// 35 : STOP
		/// </summary>
		[EnumMember(Value = "35")]
		Stop,
		/// <summary>
		/// 36 : VWAP시장가
		/// </summary>
		[EnumMember(Value = "36")]
		VwapMarket,
		/// <summary>
		/// 37 : TWAP시장가
		/// </summary>
		[EnumMember(Value = "37")]
		TwapMarket
	}
}
