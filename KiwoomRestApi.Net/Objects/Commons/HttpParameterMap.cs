using KiwoomRestApi.Net.Extensions;

using System.Collections.Generic;
using System.Linq;

namespace KiwoomRestApi.Net.Objects.Commons
{
	/// <summary>
	/// HTTP 요청 파라미터를 관리하는 딕셔너리 클래스입니다.
	/// 키움증권 API 요청에 필요한 파라미터를 체인 방식으로 쉽게 추가할 수 있습니다.
	/// </summary>
	/// <remarks>
	/// 이 클래스는 Dictionary&lt;string, string&gt;을 상속받아 HTTP 요청 파라미터를 관리하며,
	/// Fluent API 스타일의 메서드 체이닝을 지원하여 가독성 있는 코드 작성을 돕습니다.
	/// 모든 값은 키움 API 형식에 맞게 자동으로 포맷팅됩니다.
	/// </remarks>
	/// <example>
	/// <code>
	/// var parameters = new HttpParameterMap()
	///     .AddField("stk_cd", "005930")
	///     .AddField("ord_qty", 100)
	///     .AddField("ord_uv", 75000.50m);
	/// 
	/// Console.WriteLine(parameters.ToString());
	/// // 출력: stk_cd: 005930, ord_qty: 100, ord_uv: 75000.50
	/// </code>
	/// </example>
	public class HttpParameterMap : Dictionary<string, string>
	{
		/// <summary>
		/// 지정된 키와 값을 파라미터 맵에 추가합니다.
		/// 값은 키움 API 형식에 맞게 자동으로 포맷팅됩니다.
		/// </summary>
		/// <param name="key">파라미터 키</param>
		/// <param name="value">파라미터 값 (null 허용, 자동 포맷팅됨)</param>
		/// <returns>메서드 체이닝을 위한 현재 HttpParameterMap 인스턴스</returns>
		/// <remarks>
		/// 이 메서드는 Fluent API 스타일을 지원하여 연속적인 메서드 호출이 가능합니다.
		/// 값은 ToFormattedString() 확장 메서드를 통해 키움 API에 적합한 형식으로 변환됩니다.
		/// null 값은 빈 문자열로 처리됩니다.
		/// </remarks>
		/// <example>
		/// <code>
		/// var map = new HttpParameterMap()
		///     .AddField("stock_code", "005930")
		///     .AddField("quantity", 100)
		///     .AddField("price", null); // null은 빈 문자열로 처리됨
		/// </code>
		/// </example>
		public HttpParameterMap AddField(string key, object? value)
		{
			base[key] = value.ToFormattedString();
			return this;
		}

		/// <summary>
		/// 파라미터 맵의 모든 키-값 쌍을 읽기 쉬운 문자열 형태로 반환합니다.
		/// </summary>
		/// <returns>쉼표로 구분된 "키: 값" 형태의 문자열</returns>
		/// <remarks>
		/// 이 메서드는 디버깅 및 로깅 목적으로 유용하며,
		/// 파라미터의 내용을 쉽게 확인할 수 있는 형태로 출력합니다.
		/// </remarks>
		/// <example>
		/// <code>
		/// var map = new HttpParameterMap()
		///     .AddField("stock_code", "005930")
		///     .AddField("quantity", 100);
		/// 
		/// Console.WriteLine(map.ToString());
		/// // 출력: stock_code: 005930, quantity: 100
		/// </code>
		/// </example>
		public override string ToString()
		{
			return string.Join(", ", this.Select(kv => $"{kv.Key}: {kv.Value}"));
		}
	}
}
