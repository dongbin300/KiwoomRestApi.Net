using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models;
using KiwoomRestApi.Net.Objects.Models.UsStock;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.UsStocks
{
	/// <summary>
	/// 키움증권 미국주식 WebSocket API 클라이언트입니다.
	/// 실시간 시세 수신, 조건검색 등의 기능을 제공합니다.
	/// <para><a href="https://openapi.kiwoom.com/guide/apiguide"/></para>
	/// </summary>
	public class KiwoomUsStockSocketClient : BaseSocketClient
	{
		/// <summary>
		/// WebSocket 연결 엔드포인트 경로
		/// </summary>
		private static readonly string _endpoint = ApiEndpoint.UsStock.Socket;

		/// <summary>
		/// WebSocket 수신 버퍼 크기 (바이트)
		/// </summary>
		private readonly int _bufferSize = 4096;

		/// <summary>
		/// 미국주식 WebSocket API 기능을 제공합니다.
		/// 실시간 데이터 구독/해제, 조건검색 등의 기능을 포함합니다.
		/// </summary>
		public KiwoomRestApiClientUsStockWebSocket WebSocket { get; }

		public event Action<KiwoomSocketMessage>? OnMessageReceived;
		public event Action<IEnumerable<KiwoomUsStockWebSocketRealtimeSubscription<KiwoomUsStockWebSocketRealtimeOrder>>>? OnRealtimeOrderReceived;
		public event Action<IEnumerable<KiwoomUsStockWebSocketRealtimeSubscription<KiwoomUsStockWebSocketRealtimeExecution>>>? OnRealtimeExecutionReceived;
		public event Action<IEnumerable<KiwoomUsStockWebSocketRealtimeSubscription<KiwoomUsStockWebSocketRealtimeTrade>>>? OnRealtimeTradeReceived;
		public event Action<IEnumerable<KiwoomUsStockWebSocketRealtimeSubscription<KiwoomUsStockWebSocketRealtimeOrderBook>>>? OnRealtimeOrderBookReceived;

		public event Action<IEnumerable<KiwoomWebSocketConditionSearchList>>? OnConditionSearchListReceived;
		public event Action<IEnumerable<KiwoomUsStockWebSocketConditionSearchRequest>>? OnConditionSearchRequestReceived;
		public event Action<IEnumerable<KiwoomWebSocketConditionSearchRequestRealtime>>? OnConditionSearchRequestRealtimeReceived;
		public event Action<IEnumerable<KiwoomWebSocketConditionSearchRequestRealtime2>>? OnConditionSearchRequestRealtime2Received;
		public event Action<IEnumerable<KiwoomWebSocketConditionSearchClear>>? OnConditionSearchClearReceived;

		/// <summary>
		/// KiwoomUsStockSocketClient의 새 인스턴스를 초기화합니다.
		/// </summary>
		public KiwoomUsStockSocketClient() : base()
		{
			WebSocket = new KiwoomRestApiClientUsStockWebSocket(this);
		}

		/// <summary>
		/// 키움 미국주식 WebSocket 클라이언트를 생성하고 연결을 설정합니다. (동기)
		/// </summary>
		/// <param name="token">OAuth 액세스 토큰</param>
		/// <param name="isMock">모의투자 여부 (기본값: false)</param>
		/// <returns>연결된 KiwoomUsStockSocketClient 인스턴스</returns>
		public static KiwoomUsStockSocketClient Create(string token, bool isMock = false)
		{
			var uri = isMock ?
				new Uri(KiwoomUrls.MockSocketHost + _endpoint) :
				new Uri(KiwoomUrls.SocketHost + _endpoint);

			var socketClient = new KiwoomUsStockSocketClient();
			socketClient.ClientWebSocket.ConnectAsync(uri, CancellationToken.None).GetAwaiter().GetResult();
			socketClient._isConnect = true;
#if DEBUG
			Debug.WriteLine("Socket Connected.");
#endif

			var loginPacket = new
			{
				trnm = "LOGIN",
				token
			};
			socketClient.SendAsync(loginPacket).GetAwaiter().GetResult();

			_ = socketClient.ReceiveAsync(CancellationToken.None);

			return socketClient;
		}

		/// <summary>
		/// 키움 미국주식 WebSocket 클라이언트를 생성하고 비동기로 연결을 설정합니다.
		/// </summary>
		/// <param name="token">OAuth 액세스 토큰</param>
		/// <param name="isMock">모의투자 여부 (기본값: false)</param>
		/// <returns>연결된 KiwoomUsStockSocketClient 인스턴스를 반환하는 Task</returns>
		public static async Task<KiwoomUsStockSocketClient> CreateAsync(string token, bool isMock = false)
		{
			var uri = isMock ?
				new Uri(KiwoomUrls.MockSocketHost + _endpoint) :
				new Uri(KiwoomUrls.SocketHost + _endpoint);

			var socketClient = new KiwoomUsStockSocketClient();
			await socketClient.ClientWebSocket.ConnectAsync(uri, CancellationToken.None).ConfigureAwait(false);
			socketClient._isConnect = true;
#if DEBUG
			Debug.WriteLine("Socket Connected.");
#endif

			var loginPacket = new
			{
				trnm = "LOGIN",
				token
			};
			await socketClient.SendAsync(loginPacket).ConfigureAwait(false);

			_ = socketClient.ReceiveAsync(CancellationToken.None);

			return socketClient;
		}

		/// <summary>
		/// WebSocket으로부터 메시지를 비동기로 수신하고 처리합니다.
		/// </summary>
		/// <param name="cancellationToken">작업 취소 토큰</param>
		/// <returns>메시지 수신 작업을 나타내는 Task</returns>
		public new async Task ReceiveAsync(CancellationToken cancellationToken)
		{
			var buffer = new byte[_bufferSize];
			try
			{
				while (ClientWebSocket.State == WebSocketState.Open && !cancellationToken.IsCancellationRequested)
				{
					using var ms = new MemoryStream();
					WebSocketReceiveResult result;
					do
					{
						result = await ClientWebSocket.ReceiveAsync(new ArraySegment<byte>(buffer), cancellationToken);

						if (result.MessageType == WebSocketMessageType.Close)
						{
#if DEBUG
							Debug.WriteLine("서버에서 연결 종료 요청");
#endif
							await DisconnectAsync();
							return;
						}

						ms.Write(buffer, 0, result.Count);
					} while (!result.EndOfMessage);

					ms.Seek(0, SeekOrigin.Begin);

					using var reader = new StreamReader(ms, Encoding.UTF8);
					var message = await reader.ReadToEndAsync();
					Debug.WriteLine($"{message}");

					var json = JsonConvert.DeserializeObject<KiwoomSocketMessage>(message);
					if (json == null) continue;

					switch (json.ServiceName)
					{
						case "PING":
							OnMessageReceived?.Invoke(json);
							await SendAsync(json, cancellationToken);
							break;

						case "LOGIN":
							OnMessageReceived?.Invoke(json);
							if (json.ReturnCode != 0)
							{
#if DEBUG
								Debug.WriteLine($"Login Failed: {json.ReturnMessage}");
#endif
								await DisconnectAsync();
							}
							else
							{
								_isLoggedIn = true;
							}
							break;

						case "SYSTEM":
							OnMessageReceived?.Invoke(json);
							break;

						case "REAL":
							InnerProcessForReceiveReal(message);
							break;

						case "GCNSRLST":
							{
								var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage2<List<string>>>(message)?.Data?.Select(x => new KiwoomWebSocketConditionSearchList
								{
									Id = int.Parse(x[0]),
									Name = x[1]
								}).ToList();

								if (data != null)
									OnConditionSearchListReceived?.Invoke(data);
							}
							break;

						case "GCNSRREQ":
							{
								var rawData = JsonConvert.DeserializeObject<JObject>(message);
								var dataNode = rawData?["data"];

								if (dataNode != null)
								{
									if (dataNode is JArray dataArray && dataArray.Count > 0)
									{
										var firstItem = dataArray[0] as JObject;

										if (firstItem?["trnm"] != null)
										{
											var data = dataNode.ToObject<IEnumerable<KiwoomWebSocketConditionSearchRequestRealtime2>>();
											if (data != null)
												OnConditionSearchRequestRealtime2Received?.Invoke(data);
										}
										else if (firstItem?["jmcode"] != null)
										{
											var data = dataNode.ToObject<IEnumerable<KiwoomWebSocketConditionSearchRequestRealtime>>();
											if (data != null)
												OnConditionSearchRequestRealtimeReceived?.Invoke(data);
										}
										else
										{
											var data = dataNode.ToObject<IEnumerable<KiwoomUsStockWebSocketConditionSearchRequest>>();
											if (data != null)
												OnConditionSearchRequestReceived?.Invoke(data);
										}
									}
								}
							}
							break;

						case "GCNSRCLR":
							{
								var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage2<KiwoomWebSocketConditionSearchClear>>(message)?.Data;

								if (data != null)
									OnConditionSearchClearReceived?.Invoke(data);
							}
							break;

						default:
							OnMessageReceived?.Invoke(json);
							break;
					}
				}
			}
			catch (OperationCanceledException)
			{
#if DEBUG
				Debug.WriteLine("수신 작업 취소됨.");
#endif
			}
			catch (Exception ex)
			{
#if DEBUG
				Debug.WriteLine($"수신 중 예외 발생: {ex.Message}");
#endif
			}
		}

		/// <summary>
		/// 실시간 데이터 메시지를 파싱하고 해당하는 이벤트를 발생시킵니다.
		/// </summary>
		/// <param name="message">수신된 JSON 메시지</param>
		/// <remarks>
		/// 지원되는 타입: 해외주식주문(F4), 해외주식체결(F5), 미국체결(FE), 미국10호가(FT)
		/// </remarks>
		private void InnerProcessForReceiveReal(string message)
		{
			var jsonReal = JsonConvert.DeserializeObject<KiwoomUsStockWebSocketReceiveMessage<object>>(message);
			if (jsonReal == null || jsonReal.Data == null)
			{
				return;
			}

			foreach (var d in jsonReal.Data)
			{
				switch (d.Type)
				{
					case "F4":
						{
							var data = JsonConvert.DeserializeObject<KiwoomUsStockWebSocketReceiveMessage<KiwoomUsStockWebSocketRealtimeOrder>>(message)?.Data;
							if (data != null)
								OnRealtimeOrderReceived?.Invoke(data);
						}
						break;

					case "F5":
						{
							var data = JsonConvert.DeserializeObject<KiwoomUsStockWebSocketReceiveMessage<KiwoomUsStockWebSocketRealtimeExecution>>(message)?.Data;
							if (data != null)
								OnRealtimeExecutionReceived?.Invoke(data);
						}
						break;

					case "FE":
						{
							var data = JsonConvert.DeserializeObject<KiwoomUsStockWebSocketReceiveMessage<KiwoomUsStockWebSocketRealtimeTrade>>(message)?.Data;
							if (data != null)
								OnRealtimeTradeReceived?.Invoke(data);
						}
						break;

					case "FT":
						{
							var data = JsonConvert.DeserializeObject<KiwoomUsStockWebSocketReceiveMessage<KiwoomUsStockWebSocketRealtimeOrderBook>>(message)?.Data;
							if (data != null)
								OnRealtimeOrderBookReceived?.Invoke(data);
						}
						break;

					default:
						break;
				}
			}
		}
	}
}
