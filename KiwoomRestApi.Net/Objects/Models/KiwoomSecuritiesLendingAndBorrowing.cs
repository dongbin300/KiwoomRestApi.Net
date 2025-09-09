using KiwoomRestApi.Net.Converters;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models
{
	public record KiwoomSecuritiesLendingGetBorrowedTrades
	{
		/// <summary>
		/// 대차거래추이
		/// </summary>
		[JsonProperty("dbrt_trde_trnsn")]
		public IEnumerable<KiwoomSecuritiesLendingGetBorrowedTradeItem>? Items;
	}
	public record KiwoomSecuritiesLendingGetBorrowedTradeItem
	{
		/// <summary>
		/// 일자
		/// </summary>
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		/// <summary>
		/// 대차거래체결주수
		/// </summary>
		[JsonProperty("dbrt_trde_cntrcnt")]
		public decimal SecuritiesLendingTradeQuantity;
		/// <summary>
		/// 대차거래상환주수
		/// </summary>
		[JsonProperty("dbrt_trde_rpy")]
		public decimal SecuritiesLendingRepaymentQuantity;
		/// <summary>
		/// 대차거래증감
		/// </summary>
		[JsonProperty("dbrt_trde_irds")]
		public decimal SecuritiesLendingChange;
		/// <summary>
		/// 잔고주수
		/// </summary>
		[JsonProperty("rmnd")]
		public decimal BalanceQuantity;
		/// <summary>
		/// 잔고금액
		/// </summary>
		[JsonProperty("remn_amt")]
		public decimal BalanceAmount;
	}

	public record KiwoomSecuritiesLendingGetBorrowedTradeTop10
	{
		/// <summary>
		/// 대차거래체결주수합
		/// </summary>
		[JsonProperty("dbrt_trde_cntrcnt_sum")]
		public decimal TotalSecuritiesLendingTradeQuantity;
		/// <summary>
		/// 대차거래상환주수합
		/// </summary>
		[JsonProperty("dbrt_trde_rpy_sum")]
		public decimal TotalSecuritiesLendingRepaymentQuantity;
		/// <summary>
		/// 잔고주수합
		/// </summary>
		[JsonProperty("rmnd_sum")]
		public decimal TotalBalanceQuantity;
		/// <summary>
		/// 잔고금액합
		/// </summary>
		[JsonProperty("remn_amt_sum")]
		public decimal TotalBalanceAmount;
		/// <summary>
		/// 대차거래체결주수비율
		/// </summary>
		[JsonProperty("dbrt_trde_cntrcnt_rt")]
		public decimal SecuritiesLendingTradeQuantityRate;
		/// <summary>
		/// 대차거래상환주수비율
		/// </summary>
		[JsonProperty("dbrt_trde_rpy_rt")]
		public decimal SecuritiesLendingRepaymentQuantityRate;
		/// <summary>
		/// 잔고주수비율
		/// </summary>
		[JsonProperty("rmnd_rt")]
		public decimal BalanceQuantityRate;
		/// <summary>
		/// 잔고금액비율
		/// </summary>
		[JsonProperty("remn_amt_rt")]
		public decimal BalanceAmountRate;
		/// <summary>
		/// 대차거래상위10종목
		/// </summary>
		[JsonProperty("dbrt_trde_upper_10stk")]
		public IEnumerable<KiwoomSecuritiesLendingGetBorrowedTradeTop10Item>? Items;
	}
	public record KiwoomSecuritiesLendingGetBorrowedTradeTop10Item
	{
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 대차거래체결주수
		/// </summary>
		[JsonProperty("dbrt_trde_cntrcnt")]
		public decimal SecuritiesLendingTradeQuantity;
		/// <summary>
		/// 대차거래상환주수
		/// </summary>
		[JsonProperty("dbrt_trde_rpy")]
		public decimal SecuritiesLendingRepaymentQuantity;
		/// <summary>
		/// 잔고주수
		/// </summary>
		[JsonProperty("rmnd")]
		public decimal BalanceQuantity;
		/// <summary>
		/// 잔고금액
		/// </summary>
		[JsonProperty("remn_amt")]
		public decimal BalanceAmount;
	}

	public record KiwoomSecuritiesLendingGetStockBorrowedTrades
	{
		/// <summary>
		/// 대차거래추이
		/// </summary>
		[JsonProperty("dbrt_trde_trnsn")]
		public IEnumerable<KiwoomSecuritiesLendingGetStockBorrowedTradeItem>? Items;
	}
	public record KiwoomSecuritiesLendingGetStockBorrowedTradeItem
	{
		/// <summary>
		/// 일자
		/// </summary>
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		/// <summary>
		/// 대차거래체결주수
		/// </summary>
		[JsonProperty("dbrt_trde_cntrcnt")]
		public decimal SecuritiesLendingTradeQuantity;
		/// <summary>
		/// 대차거래상환주수
		/// </summary>
		[JsonProperty("dbrt_trde_rpy")]
		public decimal SecuritiesLendingRepaymentQuantity;
		/// <summary>
		/// 대차거래증감
		/// </summary>
		[JsonProperty("dbrt_trde_irds")]
		public decimal SecuritiesLendingChange;
		/// <summary>
		/// 잔고주수
		/// </summary>
		[JsonProperty("rmnd")]
		public decimal BalanceQuantity;
		/// <summary>
		/// 잔고금액
		/// </summary>
		[JsonProperty("remn_amt")]
		public decimal BalanceAmount;
	}

	public record KiwoomSecuritiesLendingGetBorrowedTradeHistories
	{
		/// <summary>
		/// 대차거래내역
		/// </summary>
		[JsonProperty("dbrt_trde_prps")]
		public IEnumerable<KiwoomSecuritiesLendingGetBorrowedTradeHistoryItem>? Items;
	}
	public record KiwoomSecuritiesLendingGetBorrowedTradeHistoryItem
	{
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 대차거래체결주수
		/// </summary>
		[JsonProperty("dbrt_trde_cntrcnt")]
		public decimal SecuritiesLendingTradeQuantity;
		/// <summary>
		/// 대차거래상환주수
		/// </summary>
		[JsonProperty("dbrt_trde_rpy")]
		public decimal SecuritiesLendingRepaymentQuantity;
		/// <summary>
		/// 잔고주수
		/// </summary>
		[JsonProperty("rmnd")]
		public decimal BalanceQuantity;
		/// <summary>
		/// 잔고금액
		/// </summary>
		[JsonProperty("remn_amt")]
		public decimal BalanceAmount;
	}

}
