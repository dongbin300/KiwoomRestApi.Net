using KiwoomRestApi.Net.Enums.WebSocket;
using KiwoomRestApi.Net.Extensions;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models;

using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.DomesticStocks
{
	public class KiwoomRestApiClientDomesticStockWebSocket(KiwoomSocketClient client) : BaseClient
	{
		private readonly KiwoomSocketClient _client = client;

		public async Task SubscribeAsync(IEnumerable<KiwoomWebSocketServiceName> serviceNames, IEnumerable<string> parameters, string groupId = "1", CancellationToken cancellationToken = default)
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

			await _client.SendAsync(message, cancellationToken).ConfigureAwait(false);
		}

		public async Task GetConditionSearchListAsync(CancellationToken cancellationToken = default)
		{
			var body = new HttpParameterMap()
				.AddField("trnm", "CNSRLST");

			await _client.SendAsync(body, cancellationToken).ConfigureAwait(false);
		}

		public async Task GetConditionSearchRequestAsync(int id, string contYn = "", string nextKey = "", CancellationToken cancellationToken = default)
		{
			var body = new HttpParameterMap()
				.AddField("trnm", "CNSRREQ")
				.AddField("seq", id)
				.AddField("search_type", "0")
				.AddField("stex_tp", "K")
				.AddField("cont_yn", contYn)
				.AddField("next_key", nextKey);

			await _client.SendAsync(body, cancellationToken).ConfigureAwait(false);
		}

		public async Task GetConditionSearchRequestRealtimeAsync(int id, CancellationToken cancellationToken = default)
		{
			var body = new HttpParameterMap()
				.AddField("trnm", "CNSRREQ")
				.AddField("seq", id)
				.AddField("search_type", "1")
				.AddField("stex_tp", "K");

			await _client.SendAsync(body, cancellationToken).ConfigureAwait(false);
		}

		public async Task GetConditionSearchClearAsync(int id, CancellationToken cancellationToken = default)
		{
			var body = new HttpParameterMap()
				.AddField("trnm", "CNSRCLR")
				.AddField("seq", id);

			await _client.SendAsync(body, cancellationToken).ConfigureAwait(false);
		}

		public async Task UnsubscribeAsync(IEnumerable<KiwoomWebSocketServiceName> serviceNames, IEnumerable<string> parameters, string groupId = "1", CancellationToken cancellationToken = default)
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

			await _client.SendAsync(message, cancellationToken).ConfigureAwait(false);
		}

		public async Task UnsubscribeAllAsync(string groupId = "1", CancellationToken cancellationToken = default)
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

			await _client.SendAsync(message, cancellationToken).ConfigureAwait(false);
		}
	}
}
