using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.StockInfo
{
	/// <summary>
	/// 시장구분
	/// </summary>
	public enum KiwoomStockInfoMarketType
	{
		/// <summary>
		/// 전체
		/// </summary>
		All = 0,
		/// <summary>
		/// 코스피
		/// </summary>
		KOSPI = 1,
		/// <summary>
		/// 코스닥
		/// </summary>
		KOSDAQ = 101,
		/// <summary>
		/// 코스피200
		/// </summary>
		KOSPI200 = 201
	}

	/// <summary>
	/// 시장구분
	/// </summary>
	public enum KiwoomStockInfoMarketType2
	{
		/// <summary>
		/// 전체
		/// </summary>
		All = 0,
		/// <summary>
		/// 코스피
		/// </summary>
		KOSPI = 1,
		/// <summary>
		/// 코스닥
		/// </summary>
		KOSDAQ = 2,
		/// <summary>
		/// 종목
		/// </summary>
		Stock = 3
	}

	/// <summary>
	/// 시장구분
	/// </summary>
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

	/// <summary>
	/// 시장구분
	/// </summary>
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

	/// <summary>
	/// 시장구분
	/// </summary>
	public enum KiwoomStockInfoMarketType5
	{
		/// <summary>
		/// 코스피
		/// </summary>
		[EnumMember(Value = "P00101")]
		KOSPI,
		/// <summary>
		/// 코스닥
		/// </summary>
		[EnumMember(Value = "P10102")]
		KOSDAQ
	}
}
