using KiwoomRestApi.Net.Converters;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models
{
	public record KiwoomSecuritiesLendingAndBorrowingGetBorrowedTrades
	{
		/// <summary>
		/// 대차거래추이
		/// </summary>
		[JsonProperty("dbrt_trde_trnsn")]
		public IEnumerable<KiwoomSecuritiesLendingAndBorrowingGetBorrowedTradeItem>? Items;
	}
	public record KiwoomSecuritiesLendingAndBorrowingGetBorrowedTradeItem
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
		public decimal BorrowedTradeContracts;
		/// <summary>
		/// 대차거래상환주수
		/// </summary>
		[JsonProperty("dbrt_trde_rpy")]
		public decimal BorrowedTradeRepayments;
		/// <summary>
		/// 대차거래증감
		/// </summary>
		[JsonProperty("dbrt_trde_irds")]
		public decimal BorrowedTradeIncreaseDecrease;
		/// <summary>
		/// 잔고주수
		/// </summary>
		[JsonProperty("rmnd")]
		public decimal RemainderQuantity;
		/// <summary>
		/// 잔고금액
		/// </summary>
		[JsonProperty("remn_amt")]
		public decimal RemainderAmount;
	}

	public record KiwoomSecuritiesLendingAndBorrowingGetBorrowedTradeTop10
	{
		/// <summary>
		/// 대차거래체결주수합
		/// </summary>
		[JsonProperty("dbrt_trde_cntrcnt_sum")]
		public decimal BorrowedTradeContractsSum;
		/// <summary>
		/// 대차거래상환주수합
		/// </summary>
		[JsonProperty("dbrt_trde_rpy_sum")]
		public decimal BorrowedTradeRepaymentsSum;
		/// <summary>
		/// 잔고주수합
		/// </summary>
		[JsonProperty("rmnd_sum")]
		public decimal RemainderQuantitySum;
		/// <summary>
		/// 잔고금액합
		/// </summary>
		[JsonProperty("remn_amt_sum")]
		public decimal RemainderAmountSum;
		/// <summary>
		/// 대차거래체결주수비율
		/// </summary>
		[JsonProperty("dbrt_trde_cntrcnt_rt")]
		public decimal BorrowedTradeContractsRate;
		/// <summary>
		/// 대차거래상환주수비율
		/// </summary>
		[JsonProperty("dbrt_trde_rpy_rt")]
		public decimal BorrowedTradeRepaymentsRate;
		/// <summary>
		/// 잔고주수비율
		/// </summary>
		[JsonProperty("rmnd_rt")]
		public decimal RemainderQuantityRate;
		/// <summary>
		/// 잔고금액비율
		/// </summary>
		[JsonProperty("remn_amt_rt")]
		public decimal RemainderAmountRate;
		/// <summary>
		/// 대차거래상위10종목
		/// </summary>
		[JsonProperty("dbrt_trde_upper_10stk")]
		public IEnumerable<KiwoomSecuritiesLendingAndBorrowingGetBorrowedTradeTop10Item>? Items;
	}
	public record KiwoomSecuritiesLendingAndBorrowingGetBorrowedTradeTop10Item
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
		public decimal BorrowedTradeContracts;
		/// <summary>
		/// 대차거래상환주수
		/// </summary>
		[JsonProperty("dbrt_trde_rpy")]
		public decimal BorrowedTradeRepayments;
		/// <summary>
		/// 잔고주수
		/// </summary>
		[JsonProperty("rmnd")]
		public decimal RemainderQuantity;
		/// <summary>
		/// 잔고금액
		/// </summary>
		[JsonProperty("remn_amt")]
		public decimal RemainderAmount;
	}

	public record KiwoomSecuritiesLendingAndBorrowingGetBorrowedTradesByStock
	{
		/// <summary>
		/// 대차거래추이
		/// </summary>
		[JsonProperty("dbrt_trde_trnsn")]
		public IEnumerable<KiwoomSecuritiesLendingAndBorrowingGetBorrowedTradeItemByStock>? Items;
	}
	public record KiwoomSecuritiesLendingAndBorrowingGetBorrowedTradeItemByStock
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
		public decimal BorrowedTradeContracts;
		/// <summary>
		/// 대차거래상환주수
		/// </summary>
		[JsonProperty("dbrt_trde_rpy")]
		public decimal BorrowedTradeRepayments;
		/// <summary>
		/// 대차거래증감
		/// </summary>
		[JsonProperty("dbrt_trde_irds")]
		public decimal BorrowedTradeIncreaseDecrease;
		/// <summary>
		/// 잔고주수
		/// </summary>
		[JsonProperty("rmnd")]
		public decimal RemainderQuantity;
		/// <summary>
		/// 잔고금액
		/// </summary>
		[JsonProperty("remn_amt")]
		public decimal RemainderAmount;
	}

	public record KiwoomSecuritiesLendingAndBorrowingGetBorrowedTradeHistories
	{
		/// <summary>
		/// 대차거래내역
		/// </summary>
		[JsonProperty("dbrt_trde_prps")]
		public IEnumerable<KiwoomSecuritiesLendingAndBorrowingGetBorrowedTradeHistoryItem>? Items;
	}
	public record KiwoomSecuritiesLendingAndBorrowingGetBorrowedTradeHistoryItem
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
		public decimal BorrowedTradeContracts;
		/// <summary>
		/// 대차거래상환주수
		/// </summary>
		[JsonProperty("dbrt_trde_rpy")]
		public decimal BorrowedTradeRepayments;
		/// <summary>
		/// 잔고주수
		/// </summary>
		[JsonProperty("rmnd")]
		public decimal RemainderQuantity;
		/// <summary>
		/// 잔고금액
		/// </summary>
		[JsonProperty("remn_amt")]
		public decimal RemainderAmount;
	}

}
