using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.Industry
{
	/// <summary>
	/// 업종코드
	/// </summary>
	public enum KiwoomIndustryCode
	{
		/// <summary>
		/// 종합(KOSPI)
		/// </summary>
		[EnumMember(Value = "001")]
		KospiComposite,
		/// <summary>
		/// 대형주
		/// </summary>
		[EnumMember(Value = "002")]
		KospiLargeCap,
		/// <summary>
		/// 중형주
		/// </summary>
		[EnumMember(Value = "003")]
		KospiMidCap,
		/// <summary>
		/// 소형주
		/// </summary>
		[EnumMember(Value = "004")]
		KospiSmallCap,
		/// <summary>
		/// 종합(KOSDAQ)
		/// </summary>
		[EnumMember(Value = "101")]
		KosdaqComposite,
		/// <summary>
		/// KOSPI200
		/// </summary>
		[EnumMember(Value = "201")]
		Kospi200,
		/// <summary>
		/// KOSTAR
		/// </summary>
		[EnumMember(Value = "302")]
		Kostar,
		/// <summary>
		/// KRX100
		/// </summary>
		[EnumMember(Value = "701")]
		Krx100,
		// TODO 업종코드
	}
}
