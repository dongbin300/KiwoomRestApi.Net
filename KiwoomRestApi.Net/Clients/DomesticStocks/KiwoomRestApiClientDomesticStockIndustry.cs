using KiwoomRestApi.Net.Enums.Industry;
using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models;

using System;
using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.DomesticStocks
{
	/// <summary>
	/// 업종 API 클라이언트
	/// 현재 6개
	/// </summary>
	/// <param name="client"></param>
	public class KiwoomRestApiClientDomesticStockIndustry(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = ApiEndpoint.DomesticStock.Industry;

		/// <summary>
		/// | ka10010 | 업종프로그램요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomIndustryGetProgramTransactionInfo>> GetProgramTransactionInfoAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10010";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomIndustryGetProgramTransactionInfo>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10051 | 업종별투자자순매수요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="amountQuantityType"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="date"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomIndustryGetInvestorNetBuys>> GetInvestorNetBuysAsync(KiwoomIndustryMarketType marketType, KiwoomIndustryAmountQuantityType amountQuantityType, KiwoomIndustryStockExchangeType stockExchangeType, DateTime? date = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10051";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("amt_qty_tp", amountQuantityType)
				.AddField("base_dt", date)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomIndustryGetInvestorNetBuys>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka20001 | 업종현재가요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="industryCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomIndustryGetCurrentPrices>> GetCurrentPricesAsync(KiwoomIndustryMarketType marketType, KiwoomIndustryCode industryCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka20001";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("inds_cd", industryCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomIndustryGetCurrentPrices>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka20002 | 업종별주가요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="industryCode"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomIndustryGetPrices>> GetPricesAsync(KiwoomIndustryMarketType marketType, KiwoomIndustryCode industryCode, KiwoomIndustryStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka20002";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("inds_cd", industryCode)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomIndustryGetPrices>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka20003 | 전업종지수요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomIndustryGetAllIndustryIndices>> GetAllIndustryIndicesAsync(KiwoomIndustryMarketType2 marketType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka20003";
			var body = new HttpParameterMap()
				.AddField("inds_cd", marketType);

			return await _client.PostKiwoomRestApiAsync<KiwoomIndustryGetAllIndustryIndices>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka20009 | 업종현재가일별요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="industryCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomIndustryGetDailyPrices>> GetDailyPricesAsync(KiwoomIndustryMarketType marketType, KiwoomIndustryCode industryCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka20009";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("inds_cd", industryCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomIndustryGetDailyPrices>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}
	}
}
