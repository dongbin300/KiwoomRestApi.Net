namespace KiwoomRestApi.Net.Enums.CreditOrder
{
	/// <summary>
	/// 매매구분
	/// </summary>
	public enum KiwoomCreditOrderTransactionType
	{
		/// <summary>
		/// 보통
		/// </summary>
		Normal = 0,
		/// <summary>
		/// 시장가
		/// </summary>
		Market = 3,
		/// <summary>
		/// 조건부지정가 
		/// </summary>
		ConditionalLimit = 5,
		/// <summary>
		/// 최유리지정가 
		/// </summary>
		BestLimit = 6,
		/// <summary>
		/// 최우선지정가 
		/// </summary>
		HighestPriority = 7,
		/// <summary>
		/// 보통(IOC) 
		/// </summary>
		NormalIOC = 10,
		/// <summary>
		/// 시장가(IOC)
		/// </summary>
		MarketIOC = 13,
		/// <summary>
		/// 최유리(IOC) 
		/// </summary>
		BestIOC = 16,
		/// <summary>
		/// 보통(FOK)
		/// </summary>
		NormalFOK = 20,
		/// <summary>
		/// 시장가(FOK)
		/// </summary>
		MarketFOK = 23,
		/// <summary>
		/// 최유리(FOK)
		/// </summary>
		BestFOK = 26,
		/// <summary>
		/// 스톱지정가
		/// </summary>
		StopLimit = 28,
		/// <summary>
		/// 중간가
		/// </summary>
		MidPrice = 29,
		/// <summary>
		/// 중간가(IOC)
		/// </summary>
		MidPriceIOC = 30,
		/// <summary>
		/// 중간가(FOK)
		/// </summary>
		MidPriceFOK = 31,
		/// <summary>
		/// 장시작전시간외
		/// </summary>
		BeforeOpen = 61,
		/// <summary>
		/// 시간외단일가 
		/// </summary>
		AfterMarketSinglePrice = 62,
		/// <summary>
		/// 장마감후시간외
		/// </summary>
		AfterMarketClosing = 81
	}
}
