using KiwoomRestApi.Net.Clients;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Interfaces
{
	/// <summary>
	/// HTTP 클라이언트의 기본 인터페이스를 정의합니다.
	/// GET 및 POST 요청을 처리하는 기본 메서드를 제공합니다.
	/// </summary>
	/// <remarks>
	/// 이 인터페이스는 키움증권 REST API 통신의 기반이 되며,
	/// HttpClient를 래핑하여 표준화된 HTTP 요청/응답 처리를 제공합니다.
	/// </remarks>
	public interface IClient : IDisposable
	{
		/// <summary>
		/// HTTP 요청을 처리하는 HttpClient 인스턴스를 가져옵니다.
		/// </summary>
		/// <value>HTTP 통신을 담당하는 HttpClient 객체</value>
		HttpClient Client { get; }

		/// <summary>
		/// 지정된 엔드포인트로 HTTP GET 요청을 비동기로 전송합니다.
		/// </summary>
		/// <typeparam name="T">응답 데이터의 타입</typeparam>
		/// <param name="endpoint">요청할 API 엔드포인트 경로</param>
		/// <param name="headers">추가할 HTTP 헤더 (선택적)</param>
		/// <param name="cancellationToken">작업 취소를 위한 토큰</param>
		/// <returns>HTTP 응답을 래핑한 HttpResponseWrapper 객체를 반환하는 Task</returns>
		/// <exception cref="HttpRequestException">HTTP 요청 실패 시</exception>
		/// <exception cref="TaskCanceledException">요청이 취소된 경우</exception>
		Task<HttpResponseWrapper<T>> GetAsync<T>(string endpoint, IDictionary<string, string>? headers = null, CancellationToken cancellationToken = default);

		/// <summary>
		/// 지정된 엔드포인트로 HTTP POST 요청을 비동기로 전송합니다.
		/// </summary>
		/// <typeparam name="T">응답 데이터의 타입</typeparam>
		/// <param name="endpoint">요청할 API 엔드포인트 경로</param>
		/// <param name="headers">추가할 HTTP 헤더 (선택적)</param>
		/// <param name="body">요청 본문에 포함할 데이터 (키-값 쌍, 선택적)</param>
		/// <param name="cancellationToken">작업 취소를 위한 토큰</param>
		/// <returns>HTTP 응답을 래핑한 HttpResponseWrapper 객체를 반환하는 Task</returns>
		/// <exception cref="HttpRequestException">HTTP 요청 실패 시</exception>
		/// <exception cref="TaskCanceledException">요청이 취소된 경우</exception>
		Task<HttpResponseWrapper<T>> PostAsync<T>(string endpoint, IDictionary<string, string>? headers = null, IDictionary<string, string>? body = null, CancellationToken cancellationToken = default);
	}
}
