using KiwoomRestApi.Net.Converters;

using Newtonsoft.Json;

namespace KiwoomRestApi.Net.Objects.Commons
{
	/// <summary>
	///	1. LOGIN
	///	{{  "trnm": "LOGIN",  "return_code": 0,  "return_msg": "",  "sor_yn": "Y"}}
	///	
	/// 2. PING
	/// {{  "trnm": "PING"}}
	/// 
	/// 3. DISCONNECT
	/// {{  "trnm": "SYSTEM",  "code": "R10002",  "message": "사용자 프로그램으로부터 Heartbeat(연결유지) 메시지가 오지않아서 접속을 종료합니다"}}
	/// </summary>
	public class KiwoomSocketMessage
	{
		[JsonProperty("return_msg")]
		public string ReturnMessage { get; internal set; } = string.Empty;

		[JsonProperty("return_code")]
		public int ReturnCode { get; internal set; }

		[JsonProperty("trnm")]
		public string ServiceName { get; internal set; } = string.Empty;

		[JsonProperty("sor_yn")]
		[JsonConverter(typeof(KiwoomBoolConverter))]
		public bool SorYn { get; internal set; }

		[JsonProperty("code")]
		public string Code { get; internal set; } = string.Empty;

		[JsonProperty("message")]
		public string Message { get; internal set; } = string.Empty;
	}
}
