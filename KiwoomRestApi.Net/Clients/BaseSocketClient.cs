using KiwoomRestApi.Net.Interfaces;

using Newtonsoft.Json;

using System;
using System.Diagnostics;
using System.IO;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients
{
	public class BaseSocketClient : ISocketClient
	{
		private readonly int _bufferSize = 4096;

		public ClientWebSocket ClientWebSocket { get; protected set; }
		public CancellationTokenSource CancellationTokenSource { get; protected set; }
		protected bool _isConnect = false;
		protected bool _isLoggedIn = false;

		public BaseSocketClient()
		{
			ClientWebSocket = new ClientWebSocket();
			CancellationTokenSource = new CancellationTokenSource();
		}

		#region Dispose
		private bool _disposed = false;

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (_disposed) return;

			if (disposing)
			{
				ClientWebSocket?.Dispose();
			}

			// unmanaged resource

			_disposed = true;
		}

		~BaseSocketClient()
		{
			Dispose(false);
		}
		#endregion

		public async Task SendAsync(object messageObject, CancellationToken cancellationToken = default)
		{
			if (!_isConnect)
			{
				return;
			}

			var messageJson = JsonConvert.SerializeObject(messageObject);
			var bytes = Encoding.UTF8.GetBytes(messageJson);
			var _cancellationToken = cancellationToken == default ? CancellationTokenSource.Token : cancellationToken;
			await ClientWebSocket.SendAsync(new ArraySegment<byte>(bytes), WebSocketMessageType.Text, true, _cancellationToken);

#if DEBUG
			Debug.WriteLine($"메시지 전송: {messageJson}");
#endif
		}

		public async Task ReceiveAsync(CancellationToken cancellationToken)
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
							await DisconnectAsync();
							return;
						}

						ms.Write(buffer, 0, result.Count);
					} while (!result.EndOfMessage);

					ms.Seek(0, SeekOrigin.Begin);

					using var reader = new StreamReader(ms, Encoding.UTF8);
					var message = await reader.ReadToEndAsync();
#if DEBUG
					Debug.WriteLine($"받은 메시지: {message}");
#endif
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

		public async Task DisconnectAsync()
		{
			if (_isConnect && ClientWebSocket.State == WebSocketState.Open)
			{
				CancellationTokenSource.Cancel();
				await ClientWebSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "클라이언트 종료", CancellationToken.None);
				_isConnect = false;

#if DEBUG
				Debug.WriteLine("서버와 연결 종료");
#endif
			}
		}
	}
}
