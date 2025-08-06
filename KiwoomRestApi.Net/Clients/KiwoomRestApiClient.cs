using KiwoomRestApi.Net.Clients.DomesticStocks;
using KiwoomRestApi.Net.Converters;
using KiwoomRestApi.Net.Objects;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients
{
	public class KiwoomRestApiClient : BaseClient
	{
		public string AppKey { get; private set; } = string.Empty;
		public string SecretKey { get; private set; } = string.Empty;
		public string? Authorization { get; set; } = string.Empty;
		public string ContYn { get; set; } = string.Empty;
		public string NextKey { get; set; } = string.Empty;

		public KiwoomRestApiClientOAuth OAuth { get; set; }
		public KiwoomRestApiClientDomesticStockAccount Account { get; set; }
		public KiwoomRestApiClientDomesticStockShortSale ShortSale { get; set; }

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

			OAuth = new KiwoomRestApiClientOAuth(this);
			Account = new KiwoomRestApiClientDomesticStockAccount(this);
			ShortSale = new KiwoomRestApiClientDomesticStockShortSale(this);
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
			var token = OAuth.GetAccessToken().Result.Data?.Token ?? throw new InvalidOperationException("Token is null");
			Authorization = $"Bearer {token}";
		}

		public async Task InitializeAsync()
		{
			var result = await OAuth.GetAccessToken();
			var token = result.Data?.Token ?? throw new InvalidOperationException("Token is null");
			Authorization = $"Bearer {token}";
		}

		public async Task<KiwoomRestApiResponse<T>> PostKiwoomRestApiAsync<T>(string endpoint, string apiId, IDictionary<string, string>? body = null)
		{
			var headers = new HttpParameterMap()
			.AddField("api-id", apiId)
			.AddField("authorization", Authorization)
			.AddField("cont-yn", ContYn)
			.AddField("next-key", NextKey);

			var response = await PostAsync<JObject>(endpoint, headers, body).ConfigureAwait(false);

			var settings = new JsonSerializerSettings
			{
				Converters = { new KiwoomRestApiResponseConverter<T>() }
			};

			var result = JsonConvert.DeserializeObject<KiwoomRestApiResponse<T>>(response.Body?.ToString()!, settings);
			return result ?? new KiwoomRestApiResponse<T>();
		}
	}
}
