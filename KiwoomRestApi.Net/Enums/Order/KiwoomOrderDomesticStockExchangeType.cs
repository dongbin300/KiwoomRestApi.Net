using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.Order
{
	public enum KiwoomOrderDomesticStockExchangeType
	{
		[EnumMember(Value = "KRX")]
		KRX,
		[EnumMember(Value = "NXT")]
		NXT,
		[EnumMember(Value = "SOR")]
		SOR
	}
}
