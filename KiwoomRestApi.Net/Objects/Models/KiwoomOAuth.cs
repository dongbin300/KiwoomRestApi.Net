using KiwoomRestApi.Net.Converters;

using Newtonsoft.Json;

using System;

namespace KiwoomRestApi.Net.Objects.Models
{
	public record KiwoomOAuthGetAccessToken
	{
		/// <summary>
		/// 만료일
		/// </summary>
		[JsonProperty("expires_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? ExpireDate;
		/// <summary>
		/// 토큰타입
		/// </summary>
		[JsonProperty("token_type")]
		public string? TokenType;
		/// <summary>
		/// 접근토큰
		/// </summary>
		[JsonProperty("token")]
		public string? Token;
	}

	public record KiwoomOAuthRevokeAccessToken
	{
	}
}
