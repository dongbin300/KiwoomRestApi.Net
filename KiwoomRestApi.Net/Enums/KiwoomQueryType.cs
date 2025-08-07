namespace KiwoomRestApi.Net.Enums
{
	public enum KiwoomQueryType
	{
		All = 0,
		Stock = 1
	}

	public enum KiwoomQueryTypeDelisting
	{
		All = 0,
		ExcludeDelistedStocks = 1
	}

	public enum KiwoomQueryTypeDeposit
	{
		General = 2,
		Estimated = 3
	}

	public enum KiwoomQueryTypeOrder
	{
		OrderSequence = 1,
		ReverseOrder = 2,
		Unconfirmed = 3,
		ConfirmedOnly = 4
	}

	public enum KiwoomQueryTypeOrderContract
	{
		All = 0,
		Filled = 1
	}

	public enum KiwoomQueryTypeEvaluationBalance
	{
		Aggregate = 1,
		Individual = 2
	}

	public enum KiwoomQueryTypePeriod
	{
		RecentDay = 1,
		ThreeDays = 3,
		FiveDays = 5,
		TenDays = 10,
		TwentyDays = 20,
		OneHundredTwentyDays = 120,
		CustomRange = 0
	}

	public enum KiwoomQueryTypeAll
	{
		All = 1,
		StockCode = 0
	}
}
