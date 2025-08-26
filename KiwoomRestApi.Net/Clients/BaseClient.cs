using KiwoomRestApi.Net.Interfaces;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients
{
	public record HttpResponseWrapper<T>
	{
		public T? Body { get; set; }
		public IDictionary<string, IEnumerable<string>> Headers { get; set; } = new Dictionary<string, IEnumerable<string>>();
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

		public async Task<HttpResponseWrapper<T>> GetAsync<T>(string endpoint, IDictionary<string, string>? headers = null, CancellationToken cancellationToken = default)
		{
			using var request = CreateRequest(HttpMethod.Get, endpoint, headers);
			using var response = await Client.SendAsync(request, cancellationToken).ConfigureAwait(false);
			return await CreateResponseWrapper<T>(response).ConfigureAwait(false);
		}

		public async Task<HttpResponseWrapper<T>> PostAsync<T>(string endpoint, IDictionary<string, string>? headers = null, IDictionary<string, string>? body = null, CancellationToken cancellationToken = default)
		{
			using var request = CreateRequest(HttpMethod.Post, endpoint, headers, body);
			using var response = await Client.SendAsync(request, cancellationToken).ConfigureAwait(false);
			return await CreateResponseWrapper<T>(response).ConfigureAwait(false);
		}

		private static HttpRequestMessage CreateRequest(HttpMethod method, string endpoint, IDictionary<string, string>? headers, IDictionary<string, string>? body = null)
		{
			var request = new HttpRequestMessage(method, endpoint);
			AddHeaders(request, headers);

			if (method == HttpMethod.Post && body != null && body.Count > 0)
			{
				string jsonBody = JsonConvert.SerializeObject(body);
				request.Content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
			}

			return request;
		}

		private static void AddHeaders(HttpRequestMessage request, IDictionary<string, string>? headers)
		{
			if (headers == null) return;
			foreach (var kvp in headers)
			{
				request.Headers.TryAddWithoutValidation(kvp.Key, kvp.Value);
			}
		}

		private static async Task<HttpResponseWrapper<T>> CreateResponseWrapper<T>(HttpResponseMessage response)
		{
			var wrapper = new HttpResponseWrapper<T>();

			foreach (var header in response.Headers)
				wrapper.Headers[header.Key] = header.Value;
			foreach (var header in response.Content.Headers)
				wrapper.Headers[header.Key] = header.Value;

			string respString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
			if (!string.IsNullOrWhiteSpace(respString))
			{
				try
				{
					wrapper.Body = JsonConvert.DeserializeObject<T>(respString);
				}
				catch
				{
					wrapper.Body = default;
				}
			}
			return wrapper;
		}
	}
}
