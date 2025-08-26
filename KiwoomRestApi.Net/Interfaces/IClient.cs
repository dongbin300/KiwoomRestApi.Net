using KiwoomRestApi.Net.Clients;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Interfaces
{
	public interface IClient : IDisposable
	{
		HttpClient Client { get; }

		Task<HttpResponseWrapper<T>> GetAsync<T>(string endpoint, IDictionary<string, string>? headers = null, CancellationToken cancellationToken = default);

		Task<HttpResponseWrapper<T>> PostAsync<T>(string endpoint, IDictionary<string, string>? headers = null, IDictionary<string, string>? body = null, CancellationToken cancellationToken = default);
	}
}
