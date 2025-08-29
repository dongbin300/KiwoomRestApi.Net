using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.Sector
{
	/// <summary>
	/// 업종코드
	/// </summary>
	public enum KiwoomSectorIndustryCode
	{
		/// <summary>
		/// 종합(KOSPI)
		/// </summary>
		[EnumMember(Value = "001")]
		CompositeKOSPI,
		/// <summary>
		/// 대형주
		/// </summary>
		[EnumMember(Value = "002")]
		LargeCap,
		/// <summary>
		/// 중형주
		/// </summary>
		[EnumMember(Value = "003")]
		MidCap,
		/// <summary>
		/// 소형주
		/// </summary>
		[EnumMember(Value = "004")]
		SmallCap,
		/// <summary>
		/// 종합(KOSDAQ)
		/// </summary>
		[EnumMember(Value = "101")]
		CompositeKOSDAQ,
		/// <summary>
		/// KOSPI200
		/// </summary>
		[EnumMember(Value = "201")]
		KOSPI200,
		/// <summary>
		/// KOSTAR
		/// </summary>
		[EnumMember(Value = "302")]
		KOSTAR,
		/// <summary>
		/// KRX100
		/// </summary>
		[EnumMember(Value = "701")]
		KRX100,
		// TODO 업종코드
	}
}
