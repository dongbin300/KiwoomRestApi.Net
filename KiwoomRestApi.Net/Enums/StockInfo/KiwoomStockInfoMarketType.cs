using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.StockInfo
{
	public enum KiwoomStockInfoMarketType
	{
		All = 0,
		KOSPI = 1,
		KOSDAQ = 101,
		KOSPI200 = 201
	}

	public enum KiwoomStockInfoMarketType2
	{
		All = 0,
		KOSPI = 1,
		KOSDAQ = 2,
		Stock = 3
	}

	public enum KiwoomStockInfoMarketType3
	{
		/// <summary>
		/// 코스피
		/// </summary>
		KOSPI = 0,
		/// <summary>
		/// ELW
		/// </summary>
		ELW = 3,
		/// <summary>
		/// 뮤추얼펀드
		/// </summary>
		MutualFund = 4,
		/// <summary>
		/// 신주인수권
		/// </summary>
		Warrants = 5,
		/// <summary>
		/// 리츠
		/// </summary>
		REITs = 6,
		/// <summary>
		/// ETF
		/// </summary>
		ETF = 8,
		/// <summary>
		/// 하이일드
		/// </summary>
		HighYield = 9,
		/// <summary>
		/// 코스닥
		/// </summary>
		KOSDAQ = 10,
		/// <summary>
		/// K-OTC
		/// </summary>
		KOTC = 30,
		/// <summary>
		/// 코넥스
		/// </summary>
		KONEX = 50
	}

	public enum KiwoomStockInfoMarketType4
	{
		/// <summary>
		/// 코스피(거래소)
		/// </summary>
		KOSPI = 0,
		/// <summary>
		/// 코스닥
		/// </summary>
		KOSDAQ = 1,
		/// <summary>
		/// KOSPI200
		/// </summary>
		KOSPI200 = 2,
		/// <summary>
		/// KOSPI100
		/// </summary>
		KOSPI100 = 4,
		/// <summary>
		/// KRX100(통합지수)
		/// </summary>
		KRX100 = 7
	}

	public enum KiwoomStockInfoMarketType5
	{
		[EnumMember(Value = "P00101")]
		KOSPI,
		[EnumMember(Value = "P10102")]
		KOSDAQ
	}
}
