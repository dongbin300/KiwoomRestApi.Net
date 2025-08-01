using KiwoomRestApi.Net.Interfaces;

using Newtonsoft.Json;

using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients
{
	public record HttpResponseWrapper<T>
	{
		public T? Body { get; set; }
		public IDictionary<string, IEnumerable<string>> Headers { get; set; } = new Dictionary<string, IEnumerable<string>>();
	}

	public class BaseClient() : IClient
	{
		public HttpClient Client { get; set; } = default!;

		~BaseClient()
		{
			Client.Dispose();
		}

		protected async Task<HttpResponseWrapper<T>> GetAsync<T>(string endpoint, IDictionary<string, string>? headers = null)
		{
			using var request = new HttpRequestMessage(HttpMethod.Get, endpoint);
			AddHeaders(request, headers);

			using var response = await Client.SendAsync(request).ConfigureAwait(false);
			return await CreateResponseWrapper<T>(response).ConfigureAwait(false);
		}

		protected async Task<HttpResponseWrapper<T>> PostAsync<T>(string endpoint, IDictionary<string, string>? headers = null, IDictionary<string, string>? bodies = null)
		{
			using var request = new HttpRequestMessage(HttpMethod.Post, endpoint);
			AddHeaders(request, headers);

			if (bodies != null && bodies.Count > 0)
			{
				string jsonBody = JsonConvert.SerializeObject(bodies);
				request.Content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
			}

			using var response = await Client.SendAsync(request).ConfigureAwait(false);
			return await CreateResponseWrapper<T>(response).ConfigureAwait(false);
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
