using KiwoomRestApi.Net.Converters;

using Newtonsoft.Json;

using System;

namespace KiwoomRestApi.Net.Objects.Models
{
	public record KiwoomOAuthGetAccessToken
	{
		[JsonProperty("expires_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? ExpiresDate;
		[JsonProperty("token_type")]
		public string? TokenType;
		[JsonProperty("token")]
		public string? Token;
	}

	public record KiwoomOAuthRevokeAccessToken
	{
	}
}
