using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums
{
	public enum KiwoomDomesticStockExchangeType
	{
		[EnumMember(Value = "%")]
		All,
		[EnumMember(Value = "KRX")]
		Krx,
		[EnumMember(Value = "NXT")]
		Nxt,
		[EnumMember(Value = "SOR")]
		Sor
	}
}
