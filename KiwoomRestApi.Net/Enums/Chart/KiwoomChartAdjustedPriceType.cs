using System;

namespace KiwoomRestApi.Net.Enums.Chart
{
	/// <summary>
	/// 수정주가구분
	/// </summary>
	[Flags]
	public enum KiwoomChartAdjustedPriceType
	{
		/// <summary>
		/// 유상증자
		/// </summary>
		PaidInIncrease = 1 << 0,
		/// <summary>
		/// 무상증자
		/// </summary>
		BonusIssue = 1 << 1,
		/// <summary>
		/// 배당락
		/// </summary>
		ExDividend = 1 << 2,
		/// <summary>
		/// 액면분할
		/// </summary>
		StockSplit = 1 << 3,
		/// <summary>
		/// 액면병합
		/// </summary>
		ReverseStockSplit = 1 << 4,
		/// <summary>
		/// 기업합병
		/// </summary>
		Merger = 1 << 5,
		/// <summary>
		/// 감자
		/// </summary>
		CapitalReduction = 1 << 6,
		/// <summary>
		/// 권리락
		/// </summary>
		ExRights = 1 << 8
	}
}
