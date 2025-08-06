using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums
{
	public enum KiwoomDomesticStockExchangeType
	{
		[EnumMember(Value = "%")]
		All,
		[EnumMember(Value = "KRX")]
		KRX,
		[EnumMember(Value = "NXT")]
		NXT,
		[EnumMember(Value = "SOR")]
		SOR
	}
}
