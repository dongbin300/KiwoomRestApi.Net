using System;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Interfaces
{
	public interface ISocketClient : IDisposable
	{
		ClientWebSocket ClientWebSocket { get; }
		CancellationTokenSource CancellationTokenSource { get; }

		Task SendAsync(object messageObject);
		Task ReceiveAsync(CancellationToken cancellationToken);
		Task DisconnectAsync();

	}
}
