using Newtonsoft.Json;

namespace KiwoomRestApi.Net.Objects.Commons
{
	public record KiwoomRestApiResponse<T>
	{
		public T? Data { get; internal set; }
		[JsonProperty("return_msg")]
		public string ReturnMessage { get; internal set; } = string.Empty;
		[JsonProperty("return_code")]
		public int ReturnCode { get; internal set; }

		public string ApiId { get; internal set; } = string.Empty;
		public string ContYn { get; internal set; } = string.Empty;
		public string NextKey { get; internal set; } = string.Empty;
	}
}
