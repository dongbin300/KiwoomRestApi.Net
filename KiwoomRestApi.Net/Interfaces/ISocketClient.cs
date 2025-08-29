using System;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Interfaces
{
	/// <summary>
	/// WebSocket 클라이언트의 기본 인터페이스를 정의합니다.
	/// 키움증권 WebSocket API와의 실시간 통신을 위한 메서드를 제공합니다.
	/// </summary>
	/// <remarks>
	/// 이 인터페이스는 키움증권 실시간 데이터 수신, 조건검색, 실시간 주식/계좌 정보 등
	/// WebSocket 기반 통신의 기반이 되며, 연결 관리 및 메시지 송수신 기능을 정의합니다.
	/// </remarks>
	/// <example>
	/// <code>
	/// using var socketClient = new KiwoomSocketClient(appKey, secretKey, true);
	/// await socketClient.SendAsync(new PingMessage(), cancellationToken);
	/// await socketClient.ReceiveAsync(cancellationToken);
	/// </code>
	/// </example>
	public interface ISocketClient : IDisposable
	{
		/// <summary>
		/// WebSocket 연결을 담당하는 ClientWebSocket 인스턴스를 가져옵니다.
		/// </summary>
		/// <value>실시간 통신을 담당하는 ClientWebSocket 객체</value>
		ClientWebSocket ClientWebSocket { get; }

		/// <summary>
		/// WebSocket 연결의 취소 토큰 소스를 가져옵니다.
		/// </summary>
		/// <value>연결 취소 및 정리를 위한 CancellationTokenSource 객체</value>
		CancellationTokenSource CancellationTokenSource { get; }

		/// <summary>
		/// 지정된 메시지 객체를 WebSocket을 통해 비동기로 전송합니다.
		/// </summary>
		/// <param name="messageObject">전송할 메시지 객체 (JSON으로 직렬화됨)</param>
		/// <param name="cancellationToken">작업 취소를 위한 토큰</param>
		/// <returns>메시지 전송 완료를 나타내는 Task</returns>
		/// <exception cref="WebSocketException">WebSocket 연결 오류 시</exception>
		/// <exception cref="InvalidOperationException">WebSocket이 연결되지 않은 상태에서 전송 시도할 때</exception>
		/// <exception cref="TaskCanceledException">작업이 취소된 경우</exception>
		Task SendAsync(object messageObject, CancellationToken cancellationToken);

		/// <summary>
		/// WebSocket으로부터 메시지를 비동기로 수신합니다.
		/// </summary>
		/// <param name="cancellationToken">작업 취소를 위한 토큰</param>
		/// <returns>메시지 수신 완료를 나타내는 Task</returns>
		/// <exception cref="WebSocketException">WebSocket 연결 오류 시</exception>
		/// <exception cref="InvalidOperationException">WebSocket이 연결되지 않은 상태에서 수신 시도할 때</exception>
		/// <exception cref="TaskCanceledException">작업이 취소된 경우</exception>
		/// <remarks>
		/// 이 메서드는 연속적으로 메시지를 수신하며, 연결이 유지되는 동안 계속 실행됩니다.
		/// 수신된 메시지는 내부적으로 처리되고 이벤트를 통해 전달됩니다.
		/// </remarks>
		Task ReceiveAsync(CancellationToken cancellationToken);

		/// <summary>
		/// WebSocket 연결을 안전하게 종료합니다.
		/// </summary>
		/// <returns>연결 종료 완료를 나타내는 Task</returns>
		/// <exception cref="WebSocketException">연결 종료 중 오류가 발생한 경우</exception>
		/// <remarks>
		/// 이 메서드는 정상적인 연결 종료 절차를 수행하며,
		/// 모든 리소스를 정리하고 연결을 안전하게 닫습니다.
		/// </remarks>
		Task DisconnectAsync();
	}
}
