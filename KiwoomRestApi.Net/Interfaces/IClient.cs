using System.Net.Http;

namespace KiwoomRestApi.Net.Interfaces
{
	public interface IClient
	{
		HttpClient Client { get; }
	}
}
