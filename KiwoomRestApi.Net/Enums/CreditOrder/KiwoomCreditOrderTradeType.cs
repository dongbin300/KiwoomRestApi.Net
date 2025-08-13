namespace KiwoomRestApi.Net.Enums.CreditOrder
{
	public enum KiwoomCreditOrderTradeType
	{
		Normal = 0,
		Market = 3,
		ConditionalLimit = 5,
		BestLimit = 6,
		HighestPriority = 7,
		NormalIOC = 10,
		MarketIOC = 13,
		BestIOC = 16,
		NormalFOK = 20,
		MarketFOK = 23,
		BestFOK = 26,
		StopLimit = 28,
		MidPrice = 29,
		MidPriceIOC = 30,
		MidPriceFOK = 31,
		BeforeOpen = 61,
		AfterHoursSinglePrice = 62,
		AfterHoursClosing = 81
	}
}
