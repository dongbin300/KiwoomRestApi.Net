using KiwoomRestApi.Net.Interfaces;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients
{
	public record HttpResponseWrapper<T>
	{
		public T? Body { get; }
		public IReadOnlyDictionary<string, IEnumerable<string>> Headers { get; }

		public HttpResponseWrapper(T? body, IReadOnlyDictionary<string, IEnumerable<string>> headers)
		{
			Body = body;
			Headers = headers;
		}
	}

	public class BaseClient : IClient
	{	
		public HttpClient Client { get; set; } = default!;

		#region Dispose
		private bool _disposed = false;

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (_disposed) return;

			if (disposing)
			{
				Client?.Dispose();
			}

			// unmanaged resource

			_disposed = true;
		}

		~BaseClient()
		{
			Dispose(false);
		}
		#endregion

		public async Task<HttpResponseWrapper<T>> GetAsync<T>(string endpoint, IEnumerable<KeyValuePair<string, string>>? headers = null, CancellationToken cancellationToken = default)
		{
			using var request = CreateRequest(HttpMethod.Get, endpoint, headers);
			using var response = await Client.SendAsync(request, cancellationToken).ConfigureAwait(false);
			return await CreateResponseWrapper<T>(response).ConfigureAwait(false);
		}

		public async Task<HttpResponseWrapper<T>> PostAsync<T>(string endpoint, IEnumerable<KeyValuePair<string, string>>? headers = null, IEnumerable<KeyValuePair<string, string>>? body = null, CancellationToken cancellationToken = default)
		{
			using var request = CreateRequest(HttpMethod.Post, endpoint, headers, body);

#if DEBUG
			Debug.WriteLine(">>> Request");
			Debug.WriteLine(request);
#endif

			using var response = await Client.SendAsync(request, cancellationToken).ConfigureAwait(false);
            return await CreateResponseWrapper<T>(response).ConfigureAwait(false);
		}

		private static HttpRequestMessage CreateRequest(HttpMethod method, string endpoint, IEnumerable<KeyValuePair<string, string>>? headers, IEnumerable<KeyValuePair<string, string>>? body = null)
		{
			var request = new HttpRequestMessage(method, endpoint);
			AddHeaders(request, headers);

			if (method == HttpMethod.Post && body != null)
			{
				// 배열/객체 형태의 파라미터(예: 관심종목 리스트)는 JSON 배열/객체 문자열을 그대로 담아두었다가
				// 여기서 원본 JSON 토큰으로 복원하여 이중 인코딩(문자열 안에 문자열)을 방지합니다.
				var jsonObject = new JObject();
				foreach (var kvp in body)
				{
					var trimmed = kvp.Value?.TrimStart();
					if (trimmed is not null && trimmed.Length > 0 && (trimmed[0] == '[' || trimmed[0] == '{'))
					{
						jsonObject[kvp.Key] = JToken.Parse(kvp.Value!);
					}
					else
					{
						jsonObject[kvp.Key] = kvp.Value;
					}
				}

				string jsonBody = jsonObject.ToString(Formatting.None);
				request.Content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
			}

			return request;
		}

		private static void AddHeaders(HttpRequestMessage request, IEnumerable<KeyValuePair<string, string>>? headers)
		{
			if (headers == null) return;
			foreach (var kvp in headers)
			{
				request.Headers.TryAddWithoutValidation(kvp.Key, kvp.Value);
			}
		}

		private static async Task<HttpResponseWrapper<T>> CreateResponseWrapper<T>(HttpResponseMessage response)
		{
			var headerDict = new Dictionary<string, IEnumerable<string>>();
			foreach (var h in response.Headers)
				headerDict[h.Key] = h.Value;
			foreach (var h in response.Content.Headers)
				headerDict[h.Key] = h.Value;

			T? body = default;

			string responseString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

			if (!string.IsNullOrWhiteSpace(responseString))
			{
				try
				{
					body = JsonConvert.DeserializeObject<T>(responseString);
				}
				catch
				{
					body = default;
				}
			}

#if DEBUG
			Debug.WriteLine(">>> Response");
			Debug.WriteLine(body);
#endif

			return new HttpResponseWrapper<T>(body, headerDict);
		}
	}
}
