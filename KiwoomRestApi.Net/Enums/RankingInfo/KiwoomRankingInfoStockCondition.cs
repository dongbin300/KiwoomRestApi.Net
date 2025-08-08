namespace KiwoomRestApi.Net.Enums.RankingInfo
{
	public enum KiwoomRankingInfoStockCondition
	{
		All = 0,
		ExcludeManaged = 1,
		ExcludePreferredStock = 3,
		ExcludeManagedAndPreferred = 4,
		ExcludeKOSPI100 = 5,
		OnlyKOSPI100 = 6,
		OnlyKOSPI40 = 7,
		OnlyKOSPI30 = 8,
		OnlyKOSPI20 = 9,
		ExcludeDelistingTrade = 11,
		OnlyKOSPI50 = 12,
		OnlyKOSPI60 = 13,
		ExcludeETF = 14,
		ExcludeSPAC = 15,
		ExcludeETF_ETN = 16,
		ExcludeETN = 17,
		ExcludeETF_ETN2 = 18,
		ExcludeETF_ETN_SPAC = 20
	}
}
