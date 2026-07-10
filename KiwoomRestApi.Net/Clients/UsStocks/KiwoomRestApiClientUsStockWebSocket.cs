using KiwoomRestApi.Net.Enums.UsStock.WebSocket;
using KiwoomRestApi.Net.Extensions;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models;

using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.UsStocks
{
	/// <summary>
	/// 미국주식 실시간시세 및 조건검색 API 클라이언트 (WebSocket)
	/// 현재 8개
	/// </summary>
	/// <param name="client"></param>
	public class KiwoomRestApiClientUsStockWebSocket(KiwoomUsStockSocketClient client) : BaseClient
	{
		private readonly KiwoomUsStockSocketClient _client = client;

		/// <summary>
		/// 실시간시세의 특정 서비스를 구독합니다.
		/// </summary>
		/// <param name="serviceNames"></param>
		/// <param name="parameters"></param>
		/// <param name="groupId"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task SubscribeAsync(IEnumerable<KiwoomUsStockWebSocketServiceName> serviceNames, IEnumerable<string> parameters, string groupId = "1", CancellationToken cancellationToken = default)
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

		/// <summary>
		/// 실시간시세의 특정 서비스를 구독 해제합니다.
		/// </summary>
		/// <param name="serviceNames"></param>
		/// <param name="parameters"></param>
		/// <param name="groupId"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task UnsubscribeAsync(IEnumerable<KiwoomUsStockWebSocketServiceName> serviceNames, IEnumerable<string> parameters, string groupId = "1", CancellationToken cancellationToken = default)
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

		/// <summary>
		/// 모든 구독을 해제합니다.
		/// </summary>
		/// <param name="groupId"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task UnsubscribeAllAsync(string groupId = "1", CancellationToken cancellationToken = default)
		{
			var message = new KiwoomWebSocketSendMessage()
			{
				ServiceName = "REG",
				GroupId = groupId,
				Refresh = "0",
			};

			await _client.SendAsync(message, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa20280 | 미국주식 조건검색 목록조회
		/// </summary>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task GetConditionSearchListAsync(CancellationToken cancellationToken = default)
		{
			var body = new HttpParameterMap()
				.AddField("trnm", "GCNSRLST");

			await _client.SendAsync(body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa20281 | 미국주식 조건검색 요청 일반
		/// </summary>
		/// <param name="id"></param>
		/// <param name="contYn"></param>
		/// <param name="nextKey"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task GetConditionSearchRequestAsync(int id, string contYn = "", string nextKey = "", CancellationToken cancellationToken = default)
		{
			var body = new HttpParameterMap()
				.AddField("trnm", "GCNSRREQ")
				.AddField("seq", id)
				.AddField("search_type", "0")
				.AddField("cont_yn", contYn)
				.AddField("next_key", nextKey);

			await _client.SendAsync(body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa20290 | 미국주식 조건검색 요청 실시간
		/// </summary>
		/// <param name="id"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task GetConditionSearchRequestRealtimeAsync(int id, CancellationToken cancellationToken = default)
		{
			var body = new HttpParameterMap()
				.AddField("trnm", "GCNSRREQ")
				.AddField("seq", id)
				.AddField("search_type", "1");

			await _client.SendAsync(body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa20291 | 미국주식 조건검색 실시간 해제
		/// </summary>
		/// <param name="id"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task GetConditionSearchClearAsync(int id, CancellationToken cancellationToken = default)
		{
			var body = new HttpParameterMap()
				.AddField("trnm", "GCNSRCLR")
				.AddField("seq", id);

			await _client.SendAsync(body, cancellationToken).ConfigureAwait(false);
		}
	}
}
