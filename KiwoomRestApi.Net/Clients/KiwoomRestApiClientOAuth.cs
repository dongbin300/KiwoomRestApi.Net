using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients
{
	public class KiwoomRestApiClientOAuth(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;

		public async Task<KiwoomRestApiResponse<KiwoomOAuthGetAccessToken>> GetAccessTokenAsync()
		{
			const string endpoint = ApiEndpoint.OAuthGet;
			const string apiId = "au10001";
			var bodies = new Dictionary<string, string>
			{
				["grant_type"] = "client_credentials",
				["appkey"] = _client.AppKey,
				["secretkey"] = _client.SecretKey
			};

			return await _client.PostKiwoomRestApiAsync<KiwoomOAuthGetAccessToken>(endpoint, apiId, bodies).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomOAuthRevokeAccessToken>> RevokeAccessTokenAsync(string token)
		{
			const string endpoint = ApiEndpoint.OAuthRevoke;
			const string apiId = "au10002";
			var bodies = new Dictionary<string, string>
			{
				["appkey"] = _client.AppKey,
				["secretkey"] = _client.SecretKey,
				["token"] = token
			};

			return await _client.PostKiwoomRestApiAsync<KiwoomOAuthRevokeAccessToken>(endpoint, apiId, bodies).ConfigureAwait(false);
		}
	}
}
