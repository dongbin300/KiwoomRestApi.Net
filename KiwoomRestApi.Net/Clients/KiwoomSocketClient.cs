using KiwoomRestApi.Net.Clients.DomesticStocks;
using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients
{
	public class KiwoomSocketClient : BaseSocketClient
	{
		private readonly static string _endpoint = "/api/dostk/websocket";
		private readonly int _bufferSize = 4096;

		public KiwoomRestApiClientDomesticStockWebSocket WebSocket { get; set; }

		public event Action<KiwoomSocketMessage>? OnMessageReceived;
		public event Action<IEnumerable<KiwoomWebSocketRealtimeSubscription<KiwoomWebSocketRealtimeOrderExecution>>>? OnRealtimeOrderExecutionReceived;
		public event Action<IEnumerable<KiwoomWebSocketRealtimeSubscription<KiwoomWebSocketRealtimeBalance>>>? OnRealtimeBalanceReceived;
		public event Action<IEnumerable<KiwoomWebSocketRealtimeSubscription<KiwoomWebSocketRealtimeStockTrend>>>? OnRealtimeStockTrendReceived;
		public event Action<IEnumerable<KiwoomWebSocketRealtimeSubscription<KiwoomWebSocketRealtimeStockExecution>>>? OnRealtimeStockExecutionReceived;
		public event Action<IEnumerable<KiwoomWebSocketRealtimeSubscription<KiwoomWebSocketRealtimeStockPriorAsk>>>? OnRealtimeStockPriorAskReceived;
		public event Action<IEnumerable<KiwoomWebSocketRealtimeSubscription<KiwoomWebSocketRealtimeStockAskBid>>>? OnRealtimeStockAskBidReceived;
		public event Action<IEnumerable<KiwoomWebSocketRealtimeSubscription<KiwoomWebSocketRealtimeStockAfterHoursAsk>>>? OnRealtimeStockAfterHoursAskReceived;
		public event Action<IEnumerable<KiwoomWebSocketRealtimeSubscription<KiwoomWebSocketRealtimeStockDailyTrader>>>? OnRealtimeStockDailyTraderReceived;
		public event Action<IEnumerable<KiwoomWebSocketRealtimeSubscription<KiwoomWebSocketRealtimeEtfNav>>>? OnRealtimeEtfNavReceived;
		public event Action<IEnumerable<KiwoomWebSocketRealtimeSubscription<KiwoomWebSocketRealtimeStockExpectedExecution>>>? OnRealtimeStockExpectedExecutionReceived;
		public event Action<IEnumerable<KiwoomWebSocketRealtimeSubscription<KiwoomWebSocketRealtimeSectorIndex>>>? OnRealtimeSectorIndexReceived;
		public event Action<IEnumerable<KiwoomWebSocketRealtimeSubscription<KiwoomWebSocketRealtimeSectorFluctuation>>>? OnRealtimeSectorFluctuationReceived;
		public event Action<IEnumerable<KiwoomWebSocketRealtimeSubscription<KiwoomWebSocketRealtimeStockInfo>>>? OnRealtimeStockInfoReceived;
		public event Action<IEnumerable<KiwoomWebSocketRealtimeSubscription<KiwoomWebSocketRealtimeElwTheoreticalPrice>>>? OnRealtimeElwTheoreticalPriceReceived;
		public event Action<IEnumerable<KiwoomWebSocketRealtimeSubscription<KiwoomWebSocketRealtimeMarketOpenTime>>>? OnRealtimeMarketOpenTimeReceived;
		public event Action<IEnumerable<KiwoomWebSocketRealtimeSubscription<KiwoomWebSocketRealtimeElwIndicator>>>? OnRealtimeElwIndicatorReceived;
		public event Action<IEnumerable<KiwoomWebSocketRealtimeSubscription<KiwoomWebSocketRealtimeProgramTrading>>>? OnRealtimeProgramTradingReceived;
		public event Action<IEnumerable<KiwoomWebSocketRealtimeSubscription<KiwoomWebSocketRealtimeViTriggeredReleased>>>? OnRealtimeViTriggeredReleasedReceived;

		public KiwoomSocketClient() : base()
		{
			WebSocket = new KiwoomRestApiClientDomesticStockWebSocket(this);
		}

		public static KiwoomSocketClient Create(string token, bool isMock = false)
		{
			var uri = isMock ?
				new Uri(KiwoomUrls.MockSocketHost + _endpoint) :
				new Uri(KiwoomUrls.SocketHost + _endpoint);

			var socketClient = new KiwoomSocketClient();
			socketClient.ClientWebSocket.ConnectAsync(uri, CancellationToken.None).GetAwaiter().GetResult();
			socketClient._isConnect = true;
			Debug.WriteLine("Socket Connected.");

			var loginPacket = new
			{
				trnm = "LOGIN",
				token
			};
			socketClient.SendAsync(loginPacket).GetAwaiter().GetResult();

			_ = socketClient.ReceiveAsync(CancellationToken.None);

			return socketClient;
		}

		public static async Task<KiwoomSocketClient> CreateAsync(string token, bool isMock = false)
		{
			var uri = isMock ?
				new Uri(KiwoomUrls.MockSocketHost + _endpoint) :
				new Uri(KiwoomUrls.SocketHost + _endpoint);

			var socketClient = new KiwoomSocketClient();
			await socketClient.ClientWebSocket.ConnectAsync(uri, CancellationToken.None).ConfigureAwait(false);
			socketClient._isConnect = true;
			Debug.WriteLine("Socket Connected.");

			var loginPacket = new
			{
				trnm = "LOGIN",
				token
			};
			await socketClient.SendAsync(loginPacket).ConfigureAwait(false);

			_ = socketClient.ReceiveAsync(CancellationToken.None);

			return socketClient;
		}

		public new async Task ReceiveAsync(CancellationToken cancellationToken)
		{
			var buffer = new byte[_bufferSize];
			try
			{
				while (ClientWebSocket.State == WebSocketState.Open && !cancellationToken.IsCancellationRequested)
				{
					var result = await ClientWebSocket.ReceiveAsync(new ArraySegment<byte>(buffer), cancellationToken);

					// 서버에서 연결 종료 요청
					if (result.MessageType == WebSocketMessageType.Close)
					{
						Debug.WriteLine("서버에서 연결 종료 요청");
						await DisconnectAsync();
						break;
					}

					var message = Encoding.UTF8.GetString(buffer, 0, result.Count);

					var json = JsonConvert.DeserializeObject<KiwoomSocketMessage>(message);

					if (json == null)
					{
						continue;
					}

					switch (json.ServiceName)
					{
						// PING/PONG
						case "PING":
							//Debug.WriteLine($"{message}");
							OnMessageReceived?.Invoke(json);
							await SendAsync(json);
							break;

						case "LOGIN":
							//Debug.WriteLine($"{message}");
							OnMessageReceived?.Invoke(json);
							if (json.ReturnCode != 0)
							{
								Debug.WriteLine($"Login Failed: {json.ReturnMessage}");
								await DisconnectAsync();
							}
							else
							{
								_isLoggedIn = true;
							}
							break;

						case "SYSTEM":
							//Debug.WriteLine($"{message}");
							OnMessageReceived?.Invoke(json);
							//await DisconnectAsync();
							break;

						case "REAL":
							//Debug.WriteLine($"{message}");
							InnerProcessForReceive(message);
							break;

						default:
							//Debug.WriteLine($"{message}");
							OnMessageReceived?.Invoke(json);
							break;
					}
				}
			}
			catch (OperationCanceledException)
			{
				Debug.WriteLine("수신 작업 취소됨.");
			}
			catch (Exception ex)
			{
				Debug.WriteLine($"수신 중 예외 발생: {ex.Message}");
			}
		}

		private void InnerProcessForReceive(string message)
		{
			var jsonReal = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage<object>>(message);
			if (jsonReal == null || jsonReal.Data == null)
			{
				return;
			}

			foreach (var d in jsonReal.Data)
			{
				switch (d.Type)
				{
					case "00":
						{
							var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage<KiwoomWebSocketRealtimeOrderExecution>>(message)?.Data;
							if (data != null)
								OnRealtimeOrderExecutionReceived?.Invoke(data);
						}
						break;

					case "04":
						{
							var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage<KiwoomWebSocketRealtimeBalance>>(message)?.Data;
							if (data != null)
								OnRealtimeBalanceReceived?.Invoke(data);
						}
						break;

					case "0A":
						{
							var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage<KiwoomWebSocketRealtimeStockTrend>>(message)?.Data;
							if (data != null)
								OnRealtimeStockTrendReceived?.Invoke(data);
						}
						break;

					case "0B":
						{
							var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage<KiwoomWebSocketRealtimeStockExecution>>(message)?.Data;
							if (data != null)
								OnRealtimeStockExecutionReceived?.Invoke(data);
						}
						break;

					case "0C":
						{
							var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage<KiwoomWebSocketRealtimeStockPriorAsk>>(message)?.Data;
							if (data != null)
								OnRealtimeStockPriorAskReceived?.Invoke(data);
						}
						break;

					case "0D":
						{
							var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage<KiwoomWebSocketRealtimeStockAskBid>>(message)?.Data;
							if (data != null)
								OnRealtimeStockAskBidReceived?.Invoke(data);
						}
						break;

					case "0E":
						{
							var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage<KiwoomWebSocketRealtimeStockAfterHoursAsk>>(message)?.Data;
							if (data != null)
								OnRealtimeStockAfterHoursAskReceived?.Invoke(data);
						}
						break;

					case "0F":
						{
							var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage<KiwoomWebSocketRealtimeStockDailyTrader>>(message)?.Data;
							if (data != null)
								OnRealtimeStockDailyTraderReceived?.Invoke(data);
						}
						break;

					case "0G":
						{
							var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage<KiwoomWebSocketRealtimeEtfNav>>(message)?.Data;
							if (data != null)
								OnRealtimeEtfNavReceived?.Invoke(data);
						}
						break;

					case "0H":
						{
							var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage<KiwoomWebSocketRealtimeStockExpectedExecution>>(message)?.Data;
							if (data != null)
								OnRealtimeStockExpectedExecutionReceived?.Invoke(data);
						}
						break;

					case "0J":
						{
							var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage<KiwoomWebSocketRealtimeSectorIndex>>(message)?.Data;
							if (data != null)
								OnRealtimeSectorIndexReceived?.Invoke(data);
						}
						break;

					case "0U":
						{
							var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage<KiwoomWebSocketRealtimeSectorFluctuation>>(message)?.Data;
							if (data != null)
								OnRealtimeSectorFluctuationReceived?.Invoke(data);
						}
						break;

					case "0g":
						{
							var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage<KiwoomWebSocketRealtimeStockInfo>>(message)?.Data;
							if (data != null)
								OnRealtimeStockInfoReceived?.Invoke(data);
						}
						break;

					case "0m":
						{
							var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage<KiwoomWebSocketRealtimeElwTheoreticalPrice>>(message)?.Data;
							if (data != null)
								OnRealtimeElwTheoreticalPriceReceived?.Invoke(data);
						}
						break;

					case "0s":
						{
							var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage<KiwoomWebSocketRealtimeMarketOpenTime>>(message)?.Data;
							if (data != null)
								OnRealtimeMarketOpenTimeReceived?.Invoke(data);
						}
						break;

					case "0u":
						{
							var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage<KiwoomWebSocketRealtimeElwIndicator>>(message)?.Data;
							if (data != null)
								OnRealtimeElwIndicatorReceived?.Invoke(data);
						}
						break;

					case "0w":
						{
							var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage<KiwoomWebSocketRealtimeProgramTrading>>(message)?.Data;
							if (data != null)
								OnRealtimeProgramTradingReceived?.Invoke(data);
						}
						break;

					case "1h":
						{
							var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage<KiwoomWebSocketRealtimeViTriggeredReleased>>(message)?.Data;
							if (data != null)
								OnRealtimeViTriggeredReleasedReceived?.Invoke(data);
						}
						break;

					default:
						break;
				}
			}
		}
	}
}
