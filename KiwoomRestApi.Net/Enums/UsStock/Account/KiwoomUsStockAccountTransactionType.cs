using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.UsStock.Account
{
	/// <summary>
	/// 구분
	/// </summary>
	public enum KiwoomUsStockAccountTransactionType
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
		/// 배당금입금
		/// </summary>
		[EnumMember(Value = "8")]
		DividendDeposit,
		/// <summary>
		/// 환전
		/// </summary>
		[EnumMember(Value = "F")]
		ForexExchange,
		/// <summary>
		/// 입출금+환전(매체전용)
		/// </summary>
		[EnumMember(Value = "M")]
		InOutAndForex,
		/// <summary>
		/// 환전매수
		/// </summary>
		[EnumMember(Value = "G")]
		ForexBuy,
		/// <summary>
		/// 환전매도
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
		ForexSettlementOut,
		/// <summary>
		/// 환전+환전정산입출금
		/// </summary>
		[EnumMember(Value = "K")]
		ForexAndForexSettlement
	}
}
