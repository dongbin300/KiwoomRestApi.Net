using KiwoomRestApi.Net.Objects;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients
{
	public class KiwoomRestApiClient : BaseClient
	{
		protected string AppKey { get; private set; } = string.Empty;
		protected string SecretKey { get; private set; } = string.Empty;

		public KiwoomRestApiClient(string appKey, string secretKey)
		{
			Client = new HttpClient
			{
				BaseAddress = new Uri(KiwoomUrls.RestApiHost)
			};
			AppKey = appKey;
			SecretKey = secretKey;
		}

		protected async Task<HttpResponseWrapper<T>> PostKiwoomRestApiAsync<T>(string endpoint, string apiId, string authorization, string contYn, string nextKey, IDictionary<string, string>? bodies)
		{
			Dictionary<string, string> headers = [];
			headers.Add("api-id", apiId);
			headers.Add("authorization", authorization);
			headers.Add("cont-yn", contYn);
			headers.Add("next-key", nextKey);

			return await PostAsync<T>(endpoint, headers, bodies).ConfigureAwait(false);
		}
	}
}
