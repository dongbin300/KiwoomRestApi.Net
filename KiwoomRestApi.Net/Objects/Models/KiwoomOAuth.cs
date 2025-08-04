using Newtonsoft.Json;

namespace KiwoomRestApi.Net.Objects.Models
{
	public record KiwoomOAuthGetAccessToken
	{
		[JsonProperty("expires_dt")]
		public string ExpiresDate = string.Empty;
		[JsonProperty("token_type")]
		public string TokenType = string.Empty;
		[JsonProperty("token")]
		public string Token = string.Empty;
	}

	public record KiwoomOAuthRevokeAccessToken
	{
	}
}
