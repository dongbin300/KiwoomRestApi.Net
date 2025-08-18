using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.WebSocket
{
	public enum KiwoomWebSocketServiceName
	{
		[EnumMember(Value = "00")]
		OrderExecution,
		[EnumMember(Value = "04")]
		Balance,
		[EnumMember(Value = "0A")]
		StockTrend,
		[EnumMember(Value = "0B")]
		StockExecution,
		[EnumMember(Value = "0C")]
		StockPriorAsk,
		[EnumMember(Value = "0D")]
		StockAskBid,
		[EnumMember(Value = "0E")]
		StockAfterHoursAsk,
		[EnumMember(Value = "0F")]
		StockDailyTrader,
		[EnumMember(Value = "0G")]
		EtfNav,
		[EnumMember(Value = "0H")]
		StockExpectedExecution,
		[EnumMember(Value = "0J")]
		SectorIndex,
		[EnumMember(Value = "0U")]
		SectorFluctuation,
		[EnumMember(Value = "0g")]
		StockInfo,
		[EnumMember(Value = "0m")]
		ElwTheoreticalPrice,
		[EnumMember(Value = "0s")]
		MarketOpenTime,
		[EnumMember(Value = "0u")]
		ElwIndicator,
		[EnumMember(Value = "0w")]
		ProgramTrading,
		[EnumMember(Value = "1h")]
		ViTriggeredReleased
	}
}
