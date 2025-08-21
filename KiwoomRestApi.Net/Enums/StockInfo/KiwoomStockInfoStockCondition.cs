namespace KiwoomRestApi.Net.Enums.StockInfo
{
	public enum KiwoomStockInfoStockCondition
	{
		All = 0,
		ExcludeManaged = 1,
		ExcludePreferredStock = 3,
		ExcludeManagedAndPreferred = 4,
		ExcludeKOSPI100 = 5,
		OnlyKOSPI100 = 6,
		OnlyKOSPI40 = 7,
		OnlyKOSPI30 = 8,
		OnlyKOSPI20 = 9
	}
}
