using System;
using System.Net.Http;

namespace KiwoomRestApi.Net.Configuration
{
	public class KiwoomConfiguration
	{
		public string AppKey { get; set; } = string.Empty;
		public string SecretKey { get; set; } = string.Empty;
		public string? Token { get; set; }
		public bool IsMock { get; set; } = false;
		public TimeSpan RequestTimeout { get; set; } = TimeSpan.FromSeconds(30);
		public HttpClient? HttpClient { get; set; }
	}
}