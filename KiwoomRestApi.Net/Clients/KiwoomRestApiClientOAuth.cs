using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models;

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients
{
	/// <summary>
	/// OAuth 인증 API 클라이언트
	/// </summary>
	/// <param name="client"></param>
	public class KiwoomRestApiClientOAuth(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;

		/// <summary>
		/// | au10001 | 접근토큰 발급
		/// </summary>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomOAuthGetAccessToken>> GetAccessTokenAsync(CancellationToken cancellationToken = default)
		{
			const string endpoint = ApiEndpoint.OAuthGet;
			const string apiId = "au10001";
			var bodies = new Dictionary<string, string>
			{
				["grant_type"] = "client_credentials",
				["appkey"] = _client.AppKey,
				["secretkey"] = _client.SecretKey
			};

			return await _client.PostKiwoomRestApiAsync<KiwoomOAuthGetAccessToken>(endpoint, apiId, bodies, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | au10002 | 접근토큰폐기
		/// </summary>
		/// <param name="token"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomOAuthRevokeAccessToken>> RevokeAccessTokenAsync(string token, CancellationToken cancellationToken = default)
		{
			const string endpoint = ApiEndpoint.OAuthRevoke;
			const string apiId = "au10002";
			var bodies = new Dictionary<string, string>
			{
				["appkey"] = _client.AppKey,
				["secretkey"] = _client.SecretKey,
				["token"] = token
			};

			return await _client.PostKiwoomRestApiAsync<KiwoomOAuthRevokeAccessToken>(endpoint, apiId, bodies, cancellationToken).ConfigureAwait(false);
		}
	}
}
