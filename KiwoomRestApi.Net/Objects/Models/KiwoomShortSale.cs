using KiwoomRestApi.Net.Converters;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models
{
	public record KiwoomShortSaleGetShortsTransactions
	{
		/// <summary>
		/// 공매도추이
		/// </summary>
		[JsonProperty("shrts_trnsn")]
		public IEnumerable<KiwoomShortSaleGetShortsTransactionItem>? Items;
	}

	public record KiwoomShortSaleGetShortsTransactionItem
	{
		/// <summary>
		/// 일자
		/// </summary>
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		/// <summary>
		/// 종가
		/// </summary>
		[JsonProperty("close_pric")]
		public decimal? Close;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? Change;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? ChangeRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 공매도량
		/// </summary>
		[JsonProperty("shrts_qty")]
		public decimal? ShortsQuantity;
		/// <summary>
		/// 누적공매도량 - 설정 기간의 공매도량 합산데이터
		/// </summary>
		[JsonProperty("ovr_shrts_qty")]
		public decimal? AccumulatedShortsQuantity;
		/// <summary>
		/// 매매비중
		/// </summary>
		[JsonProperty("trde_wght")]
		public decimal? TransactionWeight;
		/// <summary>
		/// 공매도거래대금
		/// </summary>
		[JsonProperty("shrts_trde_prica")]
		public decimal? ShortsTransactionAmount;
		/// <summary>
		/// 공매도평균가
		/// </summary>
		[JsonProperty("shrts_avg_pric")]
		public decimal? ShortsAveragePrice;
	}
}
