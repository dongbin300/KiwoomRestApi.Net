using KiwoomRestApi.Net.Clients.DomesticStocks;
using KiwoomRestApi.Net.Converters;
using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Commons;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients
{
	public class KiwoomRestApiClient : BaseClient
	{
		public string AppKey { get; private set; } = string.Empty;
		public string SecretKey { get; private set; } = string.Empty;
		public string? Authorization { get; set; }
		public string ContYn { get; set; } = string.Empty;
		public string NextKey { get; set; } = string.Empty;

		public string Token { get; set; } = string.Empty;

		public KiwoomRestApiClientOAuth OAuth { get; set; }
		public KiwoomRestApiClientDomesticStockAccount Account { get; set; }
		public KiwoomRestApiClientDomesticStockShortSale ShortSale { get; set; }
		public KiwoomRestApiClientDomesticStockForeignInstitution ForeignInstitution { get; set; }
		public KiwoomRestApiClientDomesticStockSecuritiesLendingAndBorrowing SLB { get; set; }
		public KiwoomRestApiClientDomesticStockRankingInfo Ranking { get; set; }
		public KiwoomRestApiClientDomesticStockMarketCondition MarketCondition { get; set; }
		public KiwoomRestApiClientDomesticStockCreditOrder CreditOrder { get; set; }
		public KiwoomRestApiClientDomesticStockSector Sector { get; set; }
		public KiwoomRestApiClientDomesticStockInfo StockInfo { get; set; }
		public KiwoomRestApiClientDomesticStockOrder Order { get; set; }
		public KiwoomRestApiClientDomesticStockChart Chart { get; set; }
		public KiwoomRestApiClientDomesticStockTheme Theme { get; set; }
		public KiwoomRestApiClientDomesticStockElw Elw { get; set; }
		public KiwoomRestApiClientDomesticStockEtf Etf { get; set; }

		public KiwoomRestApiClient(string appKey, string secretKey, bool isMock = false)
		: this(appKey, secretKey, null, isMock)
		{
		}

		public KiwoomRestApiClient(string appKey, string secretKey, string? token, bool isMock = false)
		{
			Client = new HttpClient
			{
				BaseAddress = new Uri(isMock ? KiwoomUrls.MockRestApiHost : KiwoomUrls.RestApiHost)
			};
			AppKey = appKey;
			SecretKey = secretKey;
			Authorization = token != null ? $"Bearer {token}" : null;
			Token = token ?? string.Empty;

			OAuth = new KiwoomRestApiClientOAuth(this);
			Account = new KiwoomRestApiClientDomesticStockAccount(this);
			ShortSale = new KiwoomRestApiClientDomesticStockShortSale(this);
			ForeignInstitution = new KiwoomRestApiClientDomesticStockForeignInstitution(this);
			SLB = new KiwoomRestApiClientDomesticStockSecuritiesLendingAndBorrowing(this);
			Ranking = new KiwoomRestApiClientDomesticStockRankingInfo(this);
			MarketCondition = new KiwoomRestApiClientDomesticStockMarketCondition(this);
			CreditOrder = new KiwoomRestApiClientDomesticStockCreditOrder(this);
			Sector = new KiwoomRestApiClientDomesticStockSector(this);
			StockInfo = new KiwoomRestApiClientDomesticStockInfo(this);
			Order = new KiwoomRestApiClientDomesticStockOrder(this);
			Chart = new KiwoomRestApiClientDomesticStockChart(this);
			Theme = new KiwoomRestApiClientDomesticStockTheme(this);
			Elw = new KiwoomRestApiClientDomesticStockElw(this);
			Etf = new KiwoomRestApiClientDomesticStockEtf(this);
		}

		public static KiwoomRestApiClient Create(string appKey, string secretKey, bool isMock = false)
		{
			var client = new KiwoomRestApiClient(appKey, secretKey, isMock);
			client.Initialize();
			return client;
		}

		public static async Task<KiwoomRestApiClient> CreateAsync(string appKey, string secretKey, bool isMock = false)
		{
			var client = new KiwoomRestApiClient(appKey, secretKey, isMock);
			await client.InitializeAsync();
			return client;
		}

		public void Initialize()
		{
			Token = OAuth.GetAccessTokenAsync().Result.Data?.Token ?? throw new InvalidOperationException("Token is null");
			Authorization = $"Bearer {Token}";
		}

		public async Task InitializeAsync()
		{
			var result = await OAuth.GetAccessTokenAsync();
			Token = result.Data?.Token ?? throw new InvalidOperationException("Token is null");
			Authorization = $"Bearer {Token}";
		}

		public async Task<KiwoomRestApiResponse<T>> PostKiwoomRestApiAsync<T>(string endpoint, string apiId, IDictionary<string, string>? body = null)
		{
			var headers = new HttpParameterMap()
				.AddField("api-id", apiId)
				.AddField("authorization", Authorization)
				.AddField("cont-yn", ContYn)
				.AddField("next-key", NextKey);

			var response = await PostAsync<JObject>(endpoint, headers, body).ConfigureAwait(false);

			if (response.Body == null)
				return new KiwoomRestApiResponse<T>();

			var jsonString = response.Body.ToString();

			var settings = new JsonSerializerSettings
			{
				Converters = { new KiwoomRestApiResponseConverter<T>() }
			};

			var result = JsonConvert.DeserializeObject<KiwoomRestApiResponse<T>>(jsonString, settings) ?? new KiwoomRestApiResponse<T>();

			AssignHeadersToResponse(result, response.Headers);

			return result;
		}

		private void AssignHeadersToResponse<T>(KiwoomRestApiResponse<T> response, IDictionary<string, IEnumerable<string>>? headers)
		{
			if (headers == null)
				return;

			if (headers.TryGetValue("api-id", out var apiIdValues))
				response.ApiId = apiIdValues.FirstOrDefault() ?? string.Empty;

			if (headers.TryGetValue("cont-yn", out var contYnValues))
				response.ContYn = contYnValues.FirstOrDefault() ?? string.Empty;

			if (headers.TryGetValue("next-key", out var nextKeyValues))
				response.NextKey = nextKeyValues.FirstOrDefault() ?? string.Empty;
		}
	}
}
