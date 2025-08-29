using Newtonsoft.Json;

namespace KiwoomRestApi.Net.Objects.Commons
{
	/// <summary>
	/// 키움증권 REST API의 표준 응답 형식을 나타내는 레코드 클래스입니다.
	/// 모든 키움 API 호출 결과는 이 형식으로 반환됩니다.
	/// </summary>
	/// <typeparam name="T">응답 데이터의 구체적인 타입</typeparam>
	/// <remarks>
	/// 키움증권 API는 일관된 응답 구조를 가지고 있으며, 이 클래스는 그 구조를 표준화합니다.
	/// 성공/실패 여부, 응답 메시지, 실제 데이터, 연속 조회를 위한 정보 등을 포함합니다.
	/// record 타입으로 구현되어 불변성과 값 기반 비교를 제공합니다.
	/// </remarks>
	/// <example>
	/// <code>
	/// // API 호출 및 응답 처리
	/// var response = await client.StockInfo.GetStockInfoAsync("005930", DateTime.Today, KiwoomStockInfoMarginLoanType.Loan);
	/// 
	/// if (response.IsSuccess)
	/// {
	///     Console.WriteLine($"삼성전자 현재가: {response.Data.CurrentPrice}원");
	/// }
	/// else
	/// {
	///     Console.WriteLine($"오류: {response.ReturnMessage} (코드: {response.ReturnCode})");
	/// }
	/// 
	/// // 연속 조회 처리
	/// if (response.ContYn == "Y")
	/// {
	///     // NextKey를 사용하여 다음 페이지 조회
	///     var nextResponse = await client.SomeApi.GetNextPageAsync(response.NextKey);
	/// }
	/// </code>
	/// </example>
	public record KiwoomRestApiResponse<T>
	{
		/// <summary>
		/// API 호출의 실제 응답 데이터를 가져오거나 설정합니다.
		/// </summary>
		/// <value>API별 구체적인 응답 데이터 또는 null</value>
		/// <remarks>
		/// 이 속성은 각 API의 실제 비즈니스 데이터를 포함합니다.
		/// 예를 들어, 주식 정보 조회 시에는 주식 상세 정보가, 주문 처리 시에는 주문 결과가 담깁니다.
		/// API 호출이 실패한 경우 null일 수 있습니다.
		/// </remarks>
		public T? Data { get; internal set; }

		/// <summary>
		/// API 서버로부터 반환된 메시지를 가져오거나 설정합니다.
		/// </summary>
		/// <value>서버 응답 메시지</value>
		/// <remarks>
		/// 성공 시에는 빈 문자열이거나 성공 메시지가,
		/// 실패 시에는 오류의 구체적인 내용이 포함됩니다.
		/// 디버깅 및 사용자 피드백에 유용합니다.
		/// </remarks>
		[JsonProperty("return_msg")]
		public string ReturnMessage { get; internal set; } = string.Empty;

		/// <summary>
		/// API 호출 결과를 나타내는 코드를 가져오거나 설정합니다.
		/// </summary>
		/// <value>응답 코드 (0: 성공, 0이 아닌 값: 오류)</value>
		/// <remarks>
		/// 키움증권 API는 0을 성공으로, 0이 아닌 값을 오류로 정의합니다.
		/// 구체적인 오류 코드에 따라 오류의 종류를 판단할 수 있습니다.
		/// </remarks>
		[JsonProperty("return_code")]
		public int ReturnCode { get; internal set; }

		/// <summary>
		/// API 호출이 성공했는지 여부를 나타냅니다.
		/// </summary>
		/// <value>성공 시 true, 실패 시 false</value>
		/// <remarks>
		/// ReturnCode가 0인 경우에만 true를 반환하는 편의 속성입니다.
		/// 조건문에서 응답 성공 여부를 쉽게 확인할 수 있습니다.
		/// </remarks>
		public bool IsSuccess => ReturnCode == 0;

		/// <summary>
		/// 호출된 API의 식별자를 가져오거나 설정합니다.
		/// </summary>
		/// <value>API ID (예: "kt10001", "ka10001")</value>
		/// <remarks>
		/// 키움증권의 각 API는 고유한 ID를 가지고 있으며,
		/// 이 값을 통해 어떤 API가 호출되었는지 확인할 수 있습니다.
		/// 주로 디버깅 및 로깅 목적으로 사용됩니다.
		/// </remarks>
		public string ApiId { get; internal set; } = string.Empty;

		/// <summary>
		/// 연속 조회 가능 여부를 나타냅니다.
		/// </summary>
		/// <value>"Y": 연속 조회 가능, "N": 연속 조회 불가</value>
		/// <remarks>
		/// 일부 API는 대용량 데이터를 페이징으로 제공합니다.
		/// "Y"인 경우 NextKey를 사용하여 다음 페이지를 조회할 수 있습니다.
		/// </remarks>
		public string ContYn { get; internal set; } = string.Empty;

		/// <summary>
		/// 다음 페이지 조회를 위한 키 값을 가져오거나 설정합니다.
		/// </summary>
		/// <value>다음 조회에 사용할 키 값</value>
		/// <remarks>
		/// ContYn이 "Y"인 경우, 이 값을 다음 API 호출에 전달하여
		/// 연속된 데이터를 조회할 수 있습니다.
		/// 마지막 페이지에 도달하면 빈 문자열이 됩니다.
		/// </remarks>
		public string NextKey { get; internal set; } = string.Empty;
	}
}
