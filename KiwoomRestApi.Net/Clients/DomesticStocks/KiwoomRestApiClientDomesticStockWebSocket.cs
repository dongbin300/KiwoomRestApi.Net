using KiwoomRestApi.Net.Enums.WebSocket;
using KiwoomRestApi.Net.Objects.Models;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.DomesticStocks
{
	public class KiwoomRestApiClientDomesticStockWebSocket(KiwoomSocketClient client) : BaseClient
	{
		private readonly KiwoomSocketClient _client = client;

		public async Task SubscribeAsync(IEnumerable<KiwoomWebSocketServiceName> serviceNames, IEnumerable<string> parameters, string groupId = "1")
		{
			var _serviceNames = serviceNames.Select(s => s.ToEnumString());

			var message = new KiwoomWebSocketSendMessage()
			{ 
				ServiceName = "REG",
				GroupId = groupId,
				Refresh = "1",
				Data =
				[
					new KiwoomWebSocketSendMessageItem()
					{
						Item = parameters,
						Type = _serviceNames
					}
				]
			};

			await _client.SendAsync(message).ConfigureAwait(false);
		}

		public async Task UnsubscribeAsync(IEnumerable<KiwoomWebSocketServiceName> serviceNames, IEnumerable<string> parameters, string groupId = "1")
		{
			var _serviceNames = serviceNames.Select(s => s.ToEnumString());

			var message = new KiwoomWebSocketSendMessage()
			{
				ServiceName = "REMOVE",
				GroupId = groupId,
				Refresh = "1",
				Data =
				[
					new KiwoomWebSocketSendMessageItem()
					{
						Item = parameters,
						Type = _serviceNames
					}
				]
			};

			await _client.SendAsync(message).ConfigureAwait(false);
		}

		public async Task UnsubscribeAllAsync(string groupId = "1")
		{
			var message = new KiwoomWebSocketSendMessage()
			{
				ServiceName = "REG",
				GroupId = groupId,
				Refresh = "0",
				//Data =
				//[
				//	new KiwoomWebSocketMessageItem()
				//	{
				//		Item = parameters,
				//		Type = _serviceNames
				//	}
				//]
			};

			await _client.SendAsync(message).ConfigureAwait(false);
		}
	}
}
