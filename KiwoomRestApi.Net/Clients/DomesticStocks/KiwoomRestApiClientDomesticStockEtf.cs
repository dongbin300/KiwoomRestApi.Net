using KiwoomRestApi.Net.Enums.Etf;
using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models;

using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.DomesticStocks
{
	/// <summary>
	/// ETF API 클라이언트
	/// 현재 9개
	/// </summary>
	/// <param name="client"></param>
	public class KiwoomRestApiClientDomesticStockEtf(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = ApiEndpoint.DomesticStock.Etf;

		/// <summary>
		/// | ka40001 | ETF수익율요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="etfObjectIndexCode"></param>
		/// <param name="periodType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomEtfGetProfitRates>> GetProfitRatesAsync(string stockCode, string etfObjectIndexCode, KiwoomEtfPeriodType periodType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka40001";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("etfobjt_idex_cd", etfObjectIndexCode)
				.AddField("dt", periodType);

			return await _client.PostKiwoomRestApiAsync<KiwoomEtfGetProfitRates>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka40002 | ETF종목정보요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomEtfGetInfo>> GetInfoAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka40002";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomEtfGetInfo>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka40003 | ETF일별추이요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomEtfGetDailyTransactions>> GetDailyTransactionsAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka40003";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomEtfGetDailyTransactions>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka40004 | ETF전체시세요청
		/// </summary>
		/// <param name="taxType"></param>
		/// <param name="navComparison"></param>
		/// <param name="managementCompany"></param>
		/// <param name="taxationType"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomEtfGetAllMarketPrices>> GetAllMarketPricesAsync(KiwoomEtfTaxType taxType, KiwoomEtfNavComparison navComparison, KiwoomEtfManagementCompany managementCompany, KiwoomEtfTaxationType taxationType, KiwoomEtfStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka40004";
			var body = new HttpParameterMap()
				.AddField("txon_type", taxType)
				.AddField("navpre", navComparison)
				.AddField("mngmcomp", managementCompany)
				.AddField("txon_yn", taxationType)
				.AddField("trace_idex", "0")
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomEtfGetAllMarketPrices>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka40006 | ETF시간대별추이요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomEtfGetTimeIntervalTransitions>> GetTimeIntervalTransitionsAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka40006";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomEtfGetTimeIntervalTransitions>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka40007 | ETF시간대별체결요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomEtfGetTimeIntervalContracts>> GetTimeIntervalContractsAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka40007";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomEtfGetTimeIntervalContracts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka40008 | ETF일자별체결요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomEtfGetNetPurchaseQuantities>> GetNetPurchaseQuantitiesAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka40008";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomEtfGetNetPurchaseQuantities>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka40009 | ETF시간대별체결요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomEtfGetNavs>> GetNavsAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka40009";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomEtfGetNavs>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka40010 | ETF시간대별추이요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomEtfGetTimeIntervalTransitions2>> GetTimeIntervalTransitions2Async(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka40010";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomEtfGetTimeIntervalTransitions2>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}
	}
}
