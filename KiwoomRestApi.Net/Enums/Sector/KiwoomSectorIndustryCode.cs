using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.Sector
{
	public enum KiwoomSectorIndustryCode
	{
		[EnumMember(Value = "001")]
		CompositeKOSPI,
		[EnumMember(Value = "002")]
		LargeCap,
		[EnumMember(Value = "003")]
		MidCap,
		[EnumMember(Value = "004")]
		SmallCap,
		[EnumMember(Value = "101")]
		CompositeKOSDAQ,
		[EnumMember(Value = "201")]
		KOSPI200,
		[EnumMember(Value = "302")]
		KOSTAR,
		[EnumMember(Value = "701")]
		KRX100,
		// TODO 업종코드
	}
}
