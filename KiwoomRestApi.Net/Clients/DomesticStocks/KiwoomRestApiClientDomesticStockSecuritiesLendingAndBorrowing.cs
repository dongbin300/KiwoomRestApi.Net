using KiwoomRestApi.Net.Enums.SecuritiesLendingAndBorrowing;
using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models;

using System;
using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.DomesticStocks
{
	public class KiwoomRestApiClientDomesticStockSecuritiesLendingAndBorrowing(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = ApiEndpoint.DomesticStock.SecuritiesLendingAndBorrowing;

		public async Task<KiwoomRestApiResponse<KiwoomSecuritiesLendingAndBorrowingGetBorrowedTrades>> GetBorrowedTradesAsync(KiwoomSecuritiesLendingAndBorrowingQueryType queryType, DateTime? startDate = null, DateTime? endDate = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10068";
			var body = new HttpParameterMap()
				.AddField("all_tp", queryType)
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate);

			return await _client.PostKiwoomRestApiAsync<KiwoomSecuritiesLendingAndBorrowingGetBorrowedTrades>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomSecuritiesLendingAndBorrowingGetBorrowedTradeTop10>> GetBorrowedTradeTop10Async(KiwoomSecuritiesLendingAndBorrowingMarketType marketType, DateTime startDate, DateTime? endDate = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10069";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate);

			return await _client.PostKiwoomRestApiAsync<KiwoomSecuritiesLendingAndBorrowingGetBorrowedTradeTop10>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomSecuritiesLendingAndBorrowingGetBorrowedTradesByStock>> GetBorrowedTradesByStockAsync(string stockCode, KiwoomSecuritiesLendingAndBorrowingQueryType queryType = KiwoomSecuritiesLendingAndBorrowingQueryType.StockCode, DateTime? startDate = null, DateTime? endDate = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka20068";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("all_tp", queryType)
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate);

			return await _client.PostKiwoomRestApiAsync<KiwoomSecuritiesLendingAndBorrowingGetBorrowedTradesByStock>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

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
