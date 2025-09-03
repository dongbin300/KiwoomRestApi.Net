using KiwoomRestApi.Net.Enums.SecuritiesLendingAndBorrowing;
using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models;

using System;
using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.DomesticStocks
{
	/// <summary>
	/// 대차거래 API 클라이언트
	/// 현재 4개
	/// </summary>
	/// <param name="client"></param>
	public class KiwoomRestApiClientDomesticStockSecuritiesLendingAndBorrowing(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = ApiEndpoint.DomesticStock.SecuritiesLendingAndBorrowing;

		/// <summary>
		/// | ka10068 | 대차거래추이요청
		/// </summary>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomSecuritiesLendingAndBorrowingGetBorrowedTrades>> GetBorrowedTradesAsync(DateTime? startDate = null, DateTime? endDate = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10068";
			var body = new HttpParameterMap()
				.AddField("all_tp", "1") // 전체표시
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate);

			return await _client.PostKiwoomRestApiAsync<KiwoomSecuritiesLendingAndBorrowingGetBorrowedTrades>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10069 | 대차거래상위10종목요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomSecuritiesLendingAndBorrowingGetBorrowedTradeTop10>> GetBorrowedTradeTop10Async(KiwoomSecuritiesLendingAndBorrowingMarketType marketType, DateTime startDate, DateTime? endDate = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10069";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate);

			return await _client.PostKiwoomRestApiAsync<KiwoomSecuritiesLendingAndBorrowingGetBorrowedTradeTop10>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka20068 | 대차거래추이요청(종목별)
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomSecuritiesLendingAndBorrowingGetBorrowedTradesByStock>> GetBorrowedTradesByStockAsync(string stockCode, DateTime? startDate = null, DateTime? endDate = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka20068";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("all_tp", "0") // 종목코드 입력종목만 표시
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate);

			return await _client.PostKiwoomRestApiAsync<KiwoomSecuritiesLendingAndBorrowingGetBorrowedTradesByStock>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka90012 | 대차거래내역요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="date"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomSecuritiesLendingAndBorrowingGetBorrowedTradeHistories>> GetBorrowedTradeHistoriesAsync(KiwoomSecuritiesLendingAndBorrowingMarketType marketType, DateTime date, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka90012";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("dt", date);

			return await _client.PostKiwoomRestApiAsync<KiwoomSecuritiesLendingAndBorrowingGetBorrowedTradeHistories>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}
	}
}
