using System;

namespace KiwoomRestApi.Net.Enums.StockInfo
{
	/// <summary>
	/// 제외종목
	/// </summary>
	[Flags]
	public enum KiwoomStockInfoSkipStockType
	{
		/// <summary>
		/// 우선주
		/// </summary>
		Preferred = 1 << 0,
		/// <summary>
		/// 관리종목
		/// </summary>
		Management = 1 << 1,
		/// <summary>
		/// 투자경고/위험
		/// </summary>
		Warning = 1 << 2,
		/// <summary>
		/// 투자주의
		/// </summary>
		Caution = 1 << 3,
		/// <summary>
		/// 환기종목
		/// </summary>
		Alert = 1 << 4,
		/// <summary>
		/// 단기과열종목
		/// </summary>
		Overheat = 1 << 5,
		/// <summary>
		/// 증거금100%
		/// </summary>
		Margin100Percent = 1 << 6,
		/// <summary>
		/// ETF
		/// </summary>
		Etf = 1 << 7,
		/// <summary>
		/// ETN
		/// </summary>
		Etn = 1 << 8
	}
}
