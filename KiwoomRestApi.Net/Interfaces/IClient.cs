using KiwoomRestApi.Net.Clients;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Interfaces
{
	public interface IClient : IDisposable
	{
		HttpClient Client { get; }

		Task<HttpResponseWrapper<T>> GetAsync<T>(string endpoint, IDictionary<string, string>? headers = null);

		Task<HttpResponseWrapper<T>> PostAsync<T>(string endpoint, IDictionary<string, string>? headers = null, IDictionary<string, string>? body = null);
	}
}
