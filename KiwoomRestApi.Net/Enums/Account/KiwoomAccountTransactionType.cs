using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.Account
{
	/// <summary>
	/// 매매구분
	/// </summary>
	public enum KiwoomAccountTransactionType
	{
		/// <summary>
		/// 전체
		/// </summary>
		All = 0,
		/// <summary>
		/// 매도
		/// </summary>
		Sell = 1,
		/// <summary>
		/// 매수
		/// </summary>
		Buy = 2
	}

	/// <summary>
	/// 구분
	/// </summary>
	public enum KiwoomAccountTransactionType2
	{
		/// <summary>
		/// 전체
		/// </summary>
		[EnumMember(Value = "0")]
		All,
		/// <summary>
		/// 입출금
		/// </summary>
		[EnumMember(Value = "1")]
		DepositWithdrawal,
		/// <summary>
		/// 입출고
		/// </summary>
		[EnumMember(Value = "2")]
		IncomingOutgoing,
		/// <summary>
		/// 매매
		/// </summary>
		[EnumMember(Value = "3")]
		Transaction,
		/// <summary>
		/// 매수
		/// </summary>
		[EnumMember(Value = "4")]
		Buy,
		/// <summary>
		/// 매도
		/// </summary>
		[EnumMember(Value = "5")]
		Sell,
		/// <summary>
		/// 입금
		/// </summary>
		[EnumMember(Value = "6")]
		Deposit,
		/// <summary>
		/// 출금
		/// </summary>
		[EnumMember(Value = "7")]
		Withdrawal,
		/// <summary>
		/// 예탁담보대출입금
		/// </summary>
		[EnumMember(Value = "A")]
		CollateralLoanDeposit,
		/// <summary>
		/// 매도담보대출입금
		/// </summary>
		[EnumMember(Value = "B")]
		SellCollateralLoanDeposit,
		/// <summary>
		/// 현금상환(융자,담보상환)
		/// </summary>
		[EnumMember(Value = "C")]
		CashRepayment,
		/// <summary>
		/// 환전
		/// </summary>
		[EnumMember(Value = "F")]
		ForexExchange,
		/// <summary>
		/// 입출금+환전
		/// </summary>
		[EnumMember(Value = "M")]
		InOutAndForex,
		/// <summary>
		/// 외화매수
		/// </summary>
		[EnumMember(Value = "G")]
		ForexBuy,
		/// <summary>
		/// 외화매도
		/// </summary>
		[EnumMember(Value = "H")]
		ForexSell,
		/// <summary>
		/// 환전정산입금
		/// </summary>
		[EnumMember(Value = "I")]
		ForexSettlementIn,
		/// <summary>
		/// 환전정산출금
		/// </summary>
		[EnumMember(Value = "J")]
		ForexSettlementOut
	}
}
