using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.Account
{
	public enum KiwoomAccountTransactionType
	{
		[EnumMember(Value = "0")]
		All,

		[EnumMember(Value = "1")]
		InOut,

		[EnumMember(Value = "2")]
		DepositWithdraw,

		[EnumMember(Value = "3")]
		Trade,

		[EnumMember(Value = "4")]
		Buy,

		[EnumMember(Value = "5")]
		Sell,

		[EnumMember(Value = "6")]
		Deposit,

		[EnumMember(Value = "7")]
		Withdrawal,

		[EnumMember(Value = "A")]
		CollateralLoanDeposit,

		[EnumMember(Value = "B")]
		SellCollateralLoanDeposit,

		[EnumMember(Value = "C")]
		CashRepayment,

		[EnumMember(Value = "F")]
		ForexExchange,

		[EnumMember(Value = "M")]
		InOutAndForex,

		[EnumMember(Value = "G")]
		ForexBuy,

		[EnumMember(Value = "H")]
		ForexSell,

		[EnumMember(Value = "I")]
		ForexSettlementIn,

		[EnumMember(Value = "J")]
		ForexSettlementOut
	}
}
