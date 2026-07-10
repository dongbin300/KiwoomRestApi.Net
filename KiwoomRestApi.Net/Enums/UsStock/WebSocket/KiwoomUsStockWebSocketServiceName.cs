using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.UsStock.WebSocket
{
	/// <summary>
	/// 미국주식 실시간시세 서비스
	/// </summary>
	public enum KiwoomUsStockWebSocketServiceName
	{
		/// <summary>
		/// 해외주식주문
		/// </summary>
		[EnumMember(Value = "F4")]
		Order,
		/// <summary>
		/// 해외주식체결
		/// </summary>
		[EnumMember(Value = "F5")]
		Execution,
		/// <summary>
		/// 미국체결
		/// </summary>
		[EnumMember(Value = "FE")]
		Trade,
		/// <summary>
		/// 미국10호가
		/// </summary>
		[EnumMember(Value = "FT")]
		OrderBook
	}
}
