using KiwoomRestApi.Net.Converters;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models
{
	public record KiwoomSecuritiesLendingAndBorrowingGetBorrowedTrades
	{
		[JsonProperty("dbrt_trde_trnsn")]
		public IEnumerable<KiwoomSecuritiesLendingAndBorrowingGetBorrowedTradeItem>? Items;
	}
	public record KiwoomSecuritiesLendingAndBorrowingGetBorrowedTradeItem
	{
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateConverter))]
		public DateTime Date;
		[JsonProperty("dbrt_trde_cntrcnt")]
		public decimal BorrowedTradeContracts;
		[JsonProperty("dbrt_trde_rpy")]
		public decimal BorrowedTradeRepayments;
		[JsonProperty("dbrt_trde_irds")]
		public decimal BorrowedTradeIncreaseDecrease;
		[JsonProperty("rmnd")]
		public decimal RemainderQuantity;
		[JsonProperty("remn_amt")]
		public decimal RemainderAmount;
	}

	public record KiwoomSecuritiesLendingAndBorrowingGetBorrowedTradeTop10
	{
		[JsonProperty("dbrt_trde_cntrcnt_sum")]
		public decimal BorrowedTradeContractsSum;
		[JsonProperty("dbrt_trde_rpy_sum")]
		public decimal BorrowedTradeRepaymentsSum;
		[JsonProperty("rmnd_sum")]
		public decimal RemainderQuantitySum;
		[JsonProperty("remn_amt_sum")]
		public decimal RemainderAmountSum;
		[JsonProperty("dbrt_trde_cntrcnt_rt")]
		public decimal BorrowedTradeContractsRate;
		[JsonProperty("dbrt_trde_rpy_rt")]
		public decimal BorrowedTradeRepaymentsRate;
		[JsonProperty("rmnd_rt")]
		public decimal RemainderQuantityRate;
		[JsonProperty("remn_amt_rt")]
		public decimal RemainderAmountRate;
		[JsonProperty("dbrt_trde_upper_10stk")]
		public IEnumerable<KiwoomSecuritiesLendingAndBorrowingGetBorrowedTradeTop10Item>? Items;
	}
	public record KiwoomSecuritiesLendingAndBorrowingGetBorrowedTradeTop10Item
	{
		[JsonProperty("stk_nm")]
		public string StockName = string.Empty;
		[JsonProperty("stk_cd")]
		public string StockCode = string.Empty;
		[JsonProperty("dbrt_trde_cntrcnt")]
		public decimal BorrowedTradeContracts;
		[JsonProperty("dbrt_trde_rpy")]
		public decimal BorrowedTradeRepayments;
		[JsonProperty("rmnd")]
		public decimal RemainderQuantity;
		[JsonProperty("remn_amt")]
		public decimal RemainderAmount;
	}

	public record KiwoomSecuritiesLendingAndBorrowingGetBorrowedTradesByStock
	{
		[JsonProperty("dbrt_trde_trnsn")]
		public IEnumerable<KiwoomSecuritiesLendingAndBorrowingGetBorrowedTradeItemByStock>? Items;
	}
	public record KiwoomSecuritiesLendingAndBorrowingGetBorrowedTradeItemByStock
	{
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateConverter))]
		public DateTime Date;
		[JsonProperty("dbrt_trde_cntrcnt")]
		public decimal BorrowedTradeContracts;
		[JsonProperty("dbrt_trde_rpy")]
		public decimal BorrowedTradeRepayments;
		[JsonProperty("dbrt_trde_irds")]
		public decimal BorrowedTradeIncreaseDecrease;
		[JsonProperty("rmnd")]
		public decimal RemainderQuantity;
		[JsonProperty("remn_amt")]
		public decimal RemainderAmount;
	}

	public record KiwoomSecuritiesLendingAndBorrowingGetBorrowedTradeHistories
	{
		[JsonProperty("dbrt_trde_prps")]
		public IEnumerable<KiwoomSecuritiesLendingAndBorrowingGetBorrowedTradeHistoryItem>? Items;
	}
	public record KiwoomSecuritiesLendingAndBorrowingGetBorrowedTradeHistoryItem
	{
		[JsonProperty("stk_nm")]
		public string StockName = string.Empty;
		[JsonProperty("stk_cd")]
		public string StockCode = string.Empty;
		[JsonProperty("dbrt_trde_cntrcnt")]
		public decimal BorrowedTradeContracts;
		[JsonProperty("dbrt_trde_rpy")]
		public decimal BorrowedTradeRepayments;
		[JsonProperty("rmnd")]
		public decimal RemainderQuantity;
		[JsonProperty("remn_amt")]
		public decimal RemainderAmount;
	}

}
