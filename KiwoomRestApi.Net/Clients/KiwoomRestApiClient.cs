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
		public string Authorization { get; set; } = string.Empty;
		public string ContYn { get; set; } = string.Empty;
		public string NextKey { get; set; } = string.Empty;

		public KiwoomRestApiClientOAuth OAuth { get; set; }

		public KiwoomRestApiClient(string appKey, string secretKey)
		{
			Client = new HttpClient
			{
				BaseAddress = new Uri(KiwoomUrls.RestApiHost)
			};
			AppKey = appKey;
			SecretKey = secretKey;

			OAuth = new KiwoomRestApiClientOAuth(this);
		}

		public async Task<KiwoomRestApiResponse<T>> PostKiwoomRestApiAsync<T>(string endpoint, string apiId, IDictionary<string, string>? bodies = null)
		{
			var headers = new Dictionary<string, string>
			{
				["api-id"] = apiId,
				["authorization"] = Authorization,
				["cont-yn"] = ContYn,
				["next-key"] = NextKey
			};

			var response = await PostAsync<JObject>(endpoint, headers, bodies).ConfigureAwait(false);

			var settings = new JsonSerializerSettings
			{
				Converters = { new KiwoomRestApiResponseConverter<T>() }
			};

			var converted = response.Body?.ToString();
			var result = JsonConvert.DeserializeObject<KiwoomRestApiResponse<T>>(converted!, settings);

			return result ?? new KiwoomRestApiResponse<T>();
		}
	}
}
