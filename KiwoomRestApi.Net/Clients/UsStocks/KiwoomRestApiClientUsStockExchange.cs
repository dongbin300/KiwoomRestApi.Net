using KiwoomRestApi.Net.Enums.UsStock.Exchange;
using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models.UsStock;

using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.UsStocks
{
	/// <summary>
	/// 미국주식 환전 API 클라이언트
	/// 현재 3개
	/// </summary>
	/// <param name="client"></param>
	public class KiwoomRestApiClientUsStockExchange(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = ApiEndpoint.UsStock.Exchange;

		/// <summary>
		/// 환전금액은 소수점을 포함하므로 공용 포매터의 F0 변환을 피하기 위해
		/// 소수점을 보존한 문자열로 직접 변환합니다. null은 그대로 전달합니다.
		/// </summary>
		private static string? FormatAmount(decimal? value) => value?.ToString(CultureInfo.InvariantCulture);

		/// <summary>
		/// | ust31300 | 환전 예상 금액 조회
		/// </summary>
		/// <param name="exchangeType">환전구분</param>
		/// <param name="exchangeAmount">매도통화기준 환전금액</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockExchangeGetExpectedAmount>> GetExpectedAmountAsync(KiwoomUsStockExchangeType exchangeType, decimal? exchangeAmount = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ust31300";
			var body = new HttpParameterMap()
				.AddField("exch_tp", exchangeType)
				.AddField("fc_exmn_amt", FormatAmount(exchangeAmount));

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockExchangeGetExpectedAmount>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ust31301 | 환율 조회
		/// </summary>
		/// <param name="exchangeType">환전구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockExchangeGetExchangeRate>> GetExchangeRateAsync(KiwoomUsStockExchangeType exchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ust31301";
			var body = new HttpParameterMap()
				.AddField("exch_tp", exchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockExchangeGetExchangeRate>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ust31302 | 환전 신청
		/// </summary>
		/// <param name="exchangeType">환전구분</param>
		/// <param name="exchangeAmount">매도통화기준 환전금액</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockExchangeApply>> ApplyExchangeAsync(KiwoomUsStockExchangeType exchangeType, decimal exchangeAmount, CancellationToken cancellationToken = default)
		{
			const string apiId = "ust31302";
			var body = new HttpParameterMap()
				.AddField("exch_tp", exchangeType)
				.AddField("fc_exmn_amt", FormatAmount(exchangeAmount));

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockExchangeApply>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}
	}
}
