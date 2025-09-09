using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.WebSocket
{
	/// <summary>
	/// 실시간시세 서비스
	/// </summary>
	public enum KiwoomWebSocketServiceName
	{
		/// <summary>
		/// 주문체결
		/// </summary>
		[EnumMember(Value = "00")]
		OrderTrade,
		/// <summary>
		/// 잔고
		/// </summary>
		[EnumMember(Value = "04")]
		Balance,
		/// <summary>
		/// 주식기세
		/// </summary>
		[EnumMember(Value = "0A")]
		StockTrend,
		/// <summary>
		/// 주식체결
		/// </summary>
		[EnumMember(Value = "0B")]
		StockTrade,
		/// <summary>
		/// 주식우선호가
		/// </summary>
		[EnumMember(Value = "0C")]
		BestQuote,
		/// <summary>
		/// 주식호가잔량
		/// </summary>
		[EnumMember(Value = "0D")]
		OrderBook,
		/// <summary>
		/// 주식시간외호가
		/// </summary>
		[EnumMember(Value = "0E")]
		AfterMarketQuote,
		/// <summary>
		/// 주식당일거래원
		/// </summary>
		[EnumMember(Value = "0F")]
		DailyBroker,
		/// <summary>
		/// ETF NAV
		/// </summary>
		[EnumMember(Value = "0G")]
		EtfNav,
		/// <summary>
		/// 주식예상체결
		/// </summary>
		[EnumMember(Value = "0H")]
		ExpectedTrade,
		/// <summary>
		/// 업종지수
		/// </summary>
		[EnumMember(Value = "0J")]
		IndustryIndex,
		/// <summary>
		/// 업종등락
		/// </summary>
		[EnumMember(Value = "0U")]
		IndustryChange,
		/// <summary>
		/// 주식종목정보
		/// </summary>
		[EnumMember(Value = "0g")]
		StockInfo,
		/// <summary>
		/// ELW 이론가
		/// </summary>
		[EnumMember(Value = "0m")]
		ElwTheoreticalPrice,
		/// <summary>
		/// 장시작시간
		/// </summary>
		[EnumMember(Value = "0s")]
		MarketOpenTime,
		/// <summary>
		/// ELW 지표
		/// </summary>
		[EnumMember(Value = "0u")]
		ElwIndicator,
		/// <summary>
		/// 종목프로그램매매
		/// </summary>
		[EnumMember(Value = "0w")]
		ProgramTransaction,
		/// <summary>
		/// VI발동/해제
		/// </summary>
		[EnumMember(Value = "1h")]
		ViEvent
	}
}
