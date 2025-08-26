using System;
using System.Net.Http;

namespace KiwoomRestApi.Net.Configuration
{
	/// <summary>
	/// 키움 REST API 클라이언트의 구성 설정을 나타냅니다.
	/// </summary>
	public class KiwoomConfiguration
	{
		/// <summary>
		/// 키움증권에서 발급받은 앱 키를 가져오거나 설정합니다.
		/// </summary>
		public string AppKey { get; set; } = string.Empty;

		/// <summary>
		/// 키움증권에서 발급받은 시크릿 키를 가져오거나 설정합니다.
		/// </summary>
		public string SecretKey { get; set; } = string.Empty;

		/// <summary>
		/// OAuth 액세스 토큰을 가져오거나 설정합니다. (선택적)
		/// </summary>
		public string? Token { get; set; }

		/// <summary>
		/// 모의투자 여부를 가져오거나 설정합니다. 기본값은 false입니다.
		/// </summary>
		public bool IsMock { get; set; } = false;

		/// <summary>
		/// HTTP 요청 타임아웃을 가져오거나 설정합니다. 기본값은 30초입니다.
		/// </summary>
		public TimeSpan RequestTimeout { get; set; } = TimeSpan.FromSeconds(30);

		/// <summary>
		/// 사용자 지정 HttpClient를 가져오거나 설정합니다. (선택적)
		/// </summary>
		public HttpClient? HttpClient { get; set; }
	}
}