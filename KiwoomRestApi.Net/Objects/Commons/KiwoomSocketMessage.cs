using KiwoomRestApi.Net.Converters;

using Newtonsoft.Json;

namespace KiwoomRestApi.Net.Objects.Commons
{
	/// <summary>
	/// 키움증권 WebSocket API의 메시지 형식을 나타내는 클래스입니다.
	/// LOGIN, PING, SYSTEM 메시지 등 다양한 WebSocket 메시지 타입을 처리합니다.
	/// </summary>
	/// <remarks>
	/// 키움증권 WebSocket API는 다양한 종류의 메시지를 주고받으며, 이 클래스는 그 표준 형식을 정의합니다.
	/// 주요 메시지 타입:
	/// <list type="number">
	/// <item>
	/// <term>LOGIN</term>
	/// <description>로그인 성공/실패 메시지: {"trnm": "LOGIN", "return_code": 0, "return_msg": "", "sor_yn": "Y"}</description>
	/// </item>
	/// <item>
	/// <term>PING</term>
	/// <description>연결 유지를 위한 핑 메시지: {"trnm": "PING"}</description>
	/// </item>
	/// <item>
	/// <term>SYSTEM</term>
	/// <description>시스템 메시지 (연결 종료 등): {"trnm": "SYSTEM", "code": "R10002", "message": "사용자 프로그램으로부터 Heartbeat(연결유지) 메시지가 오지않아서 접속을 종료합니다"}</description>
	/// </item>
	/// </list>
	/// </remarks>
	/// <example>
	/// <code>
	/// // 수신된 메시지 처리
	/// var message = JsonConvert.DeserializeObject&lt;KiwoomSocketMessage&gt;(jsonString);
	/// 
	/// switch (message.ServiceName)
	/// {
	///     case "LOGIN":
	///         if (message.ReturnCode == 0)
	///             Console.WriteLine("로그인 성공");
	///         else
	///             Console.WriteLine($"로그인 실패: {message.ReturnMessage}");
	///         break;
	///         
	///     case "PING":
	///         // PING 메시지에 대한 PONG 응답 처리
	///         break;
	///         
	///     case "SYSTEM":
	///         Console.WriteLine($"시스템 메시지: {message.Message} (코드: {message.Code})");
	///         break;
	/// }
	/// </code>
	/// </example>
	public class KiwoomSocketMessage
	{
		/// <summary>
		/// 서버로부터 반환된 메시지를 가져오거나 설정합니다.
		/// </summary>
		/// <value>서버 응답 메시지</value>
		/// <remarks>
		/// LOGIN 메시지의 경우 성공 시 빈 문자열, 실패 시 오류 메시지가 포함됩니다.
		/// 다른 메시지 타입에서는 구체적인 상황 정보를 포함할 수 있습니다.
		/// </remarks>
		[JsonProperty("return_msg")]
		public string ReturnMessage { get; internal set; } = string.Empty;

		/// <summary>
		/// 메시지 처리 결과를 나타내는 코드를 가져오거나 설정합니다.
		/// </summary>
		/// <value>처리 결과 코드 (0: 성공, 0이 아닌 값: 오류)</value>
		/// <remarks>
		/// LOGIN 메시지에서 주로 사용되며, 0은 성공, 0이 아닌 값은 오류를 나타냅니다.
		/// PING이나 일부 SYSTEM 메시지에서는 사용되지 않을 수 있습니다.
		/// </remarks>
		[JsonProperty("return_code")]
		public int ReturnCode { get; internal set; }

		/// <summary>
		/// WebSocket 메시지의 서비스 타입을 가져오거나 설정합니다.
		/// </summary>
		/// <value>서비스 타입 ("LOGIN", "PING", "SYSTEM" 등)</value>
		/// <remarks>
		/// 이 속성을 통해 수신된 메시지의 종류를 판단하고 적절한 처리 로직을 수행할 수 있습니다.
		/// 주요 값: LOGIN (로그인 관련), PING (연결 유지), SYSTEM (시스템 알림)
		/// </remarks>
		[JsonProperty("trnm")]
		public string ServiceName { get; internal set; } = string.Empty;

		/// <summary>
		/// 정렬 여부를 나타내는 불린 값을 가져오거나 설정합니다.
		/// </summary>
		/// <value>정렬 여부 (true 또는 false)</value>
		/// <remarks>
		/// 키움 API의 "Y"/"N" 문자열을 불린 값으로 자동 변환하여 처리합니다.
		/// LOGIN 메시지에서 주로 사용되며, 데이터 정렬 상태를 나타낼 수 있습니다.
		/// </remarks>
		[JsonProperty("sor_yn")]
		[JsonConverter(typeof(KiwoomBoolConverter))]
		public bool SorYn { get; internal set; }

		/// <summary>
		/// 시스템 메시지의 코드를 가져오거나 설정합니다.
		/// </summary>
		/// <value>시스템 메시지 코드 (예: "R10002")</value>
		/// <remarks>
		/// SYSTEM 메시지에서 사용되며, 구체적인 시스템 상황을 나타내는 코드입니다.
		/// 예: "R10002" - Heartbeat 메시지 누락으로 인한 연결 종료
		/// </remarks>
		[JsonProperty("code")]
		public string Code { get; internal set; } = string.Empty;

		/// <summary>
		/// 시스템 메시지의 상세 내용을 가져오거나 설정합니다.
		/// </summary>
		/// <value>시스템 메시지 상세 내용</value>
		/// <remarks>
		/// SYSTEM 메시지에서 사용되며, 사용자에게 표시할 구체적인 메시지 내용입니다.
		/// 주로 연결 종료 사유, 시스템 점검 알림 등의 정보를 포함합니다.
		/// </remarks>
		[JsonProperty("message")]
		public string Message { get; internal set; } = string.Empty;
	}
}
