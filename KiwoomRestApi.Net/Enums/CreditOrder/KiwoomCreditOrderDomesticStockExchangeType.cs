using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.CreditOrder
{
	public enum KiwoomCreditOrderDomesticStockExchangeType
	{
		[EnumMember(Value = "KRX")]
		KRX,
		[EnumMember(Value = "NXT")]
		NXT,
		[EnumMember(Value = "SOR")]
		SOR
	}
}
