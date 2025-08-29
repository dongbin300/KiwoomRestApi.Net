namespace KiwoomRestApi.Net.Enums.RankingInfo
{
	/// <summary>
	/// 가격조건
	/// </summary>
	public enum KiwoomRankingInfoPriceCondition
	{
		/// <summary>
		/// 전체조회
		/// </summary>
		All = 0,
		/// <summary>
		/// 1천원미만
		/// </summary>
		Under1K = 1,
		/// <summary>
		/// 1천원~2천원
		/// </summary>
		Range1KTo2K = 2,
		/// <summary>
		/// 2천원~5천원
		/// </summary>
		Range2KTo5K = 3,
		/// <summary>
		/// 5천원~1만원
		/// </summary>
		Range5KTo10K = 4,
		/// <summary>
		/// 1만원이상
		/// </summary>
		Over10K = 5,
		/// <summary>
		/// 1천원이상
		/// </summary>
		Over1K = 8,
		/// <summary>
		/// 1만원미만
		/// </summary>
		Under10K = 10
	}

	/// <summary>
	/// 가격조건
	/// </summary>
	public enum KiwoomRankingInfoPriceCondition2
	{
		/// <summary>
		/// 전체조회
		/// </summary>
		All = 0,
		/// <summary>
		/// 1천원미만
		/// </summary>
		Under1K = 1,
		/// <summary>
		/// 1천원이상
		/// </summary>
		Over1K = 2,
		/// <summary>
		/// 1천원~2천원
		/// </summary>
		Range1KTo2K = 3,
		/// <summary>
		/// 2천원~5천원
		/// </summary>
		Range2KTo5K = 4,
		/// <summary>
		/// 5천원이상
		/// </summary>
		Over5K = 5,
		/// <summary>
		/// 5천원~1만원
		/// </summary>
		Range5KTo10K = 6,
		/// <summary>
		/// 1만원이상
		/// </summary>
		Over10K = 7,
		/// <summary>
		/// 5만원이상
		/// </summary>
		Over50K = 8,
		/// <summary>
		/// 10만원이상
		/// </summary>
		Over100K = 9,
		/// <summary>
		/// 1만원미만
		/// </summary>
		Under10K = 10
	}
}
