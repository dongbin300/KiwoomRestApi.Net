using KiwoomRestApi.Net.Converters;

using Newtonsoft.Json;

namespace KiwoomRestApi.Net.Objects.Commons
{
	/// <summary>
	/// 키움증권 API의 특수한 십진수 표현을 다루는 클래스입니다.
	/// 주가의 등락 방향(+/-)과 수치를 함께 표현할 수 있습니다.
	/// </summary>
	/// <remarks>
	/// 키움증권 API는 주가 변동량이나 등락률 같은 데이터를 방향성과 함께 제공합니다.
	/// 이 클래스는 그러한 데이터를 편리하게 처리하기 위해 설계되었으며,
	/// JSON 직렬화/역직렬화를 위한 커스텀 컨버터가 적용되어 있습니다.
	/// </remarks>
	/// <example>
	/// <code>
	/// // 상승 (+150원)
	/// var upPrice = new KiwoomDecimal(150, "+");
	/// Console.WriteLine(upPrice.ToString()); // "+150"
	/// 
	/// // 하락 (-50원)
	/// var downPrice = new KiwoomDecimal(50, "-");
	/// Console.WriteLine(downPrice.ToString()); // "-50"
	/// 
	/// // 일반 수치
	/// var price = new KiwoomDecimal(75000);
	/// decimal? actualValue = price; // 암시적 변환
	/// </code>
	/// </example>
	/// <param name="value">십진수 값 (선택적)</param>
	/// <param name="direction">방향 표시자 (예: "+", "-", 선택적)</param>
	[JsonConverter(typeof(KiwoomNormalizerConverter))]
	public class KiwoomDecimal(decimal? value = null, string? direction = null)
	{
		/// <summary>
		/// 수치의 방향을 나타내는 문자열을 가져옵니다.
		/// </summary>
		/// <value>방향 표시자 (예: "+", "-") 또는 null</value>
		/// <remarks>
		/// 일반적으로 주식 가격 변동에서 상승은 "+", 하락은 "-"로 표현됩니다.
		/// null인 경우 방향성이 없는 일반적인 수치를 의미합니다.
		/// </remarks>
		public string? Direction { get; private set; } = direction;

		/// <summary>
		/// 십진수 값을 가져옵니다.
		/// </summary>
		/// <value>십진수 값 또는 null</value>
		/// <remarks>
		/// 실제 수치 데이터를 나타내며, null인 경우 값이 없음을 의미합니다.
		/// </remarks>
		public decimal? Value { get; private set; } = value;

		/// <summary>
		/// KiwoomDecimal을 decimal?로 암시적 변환합니다.
		/// </summary>
		/// <param name="value">변환할 KiwoomDecimal 인스턴스</param>
		/// <returns>Value 속성의 값 또는 null</returns>
		/// <remarks>
		/// 이 변환 연산자를 통해 KiwoomDecimal을 일반적인 decimal? 타입처럼 사용할 수 있습니다.
		/// </remarks>
		/// <example>
		/// <code>
		/// var kiwoomDecimal = new KiwoomDecimal(150.5m);
		/// decimal? normalDecimal = kiwoomDecimal; // 암시적 변환
		/// </code>
		/// </example>
		public static implicit operator decimal?(KiwoomDecimal? value) => value?.Value;

		/// <summary>
		/// decimal?을 KiwoomDecimal로 암시적 변환합니다.
		/// </summary>
		/// <param name="value">변환할 decimal? 값</param>
		/// <returns>새로운 KiwoomDecimal 인스턴스</returns>
		/// <remarks>
		/// 이 변환 연산자를 통해 일반적인 decimal? 값을 KiwoomDecimal로 쉽게 변환할 수 있습니다.
		/// Direction은 null로 설정됩니다.
		/// </remarks>
		/// <example>
		/// <code>
		/// decimal? normalDecimal = 150.5m;
		/// KiwoomDecimal kiwoomDecimal = normalDecimal; // 암시적 변환
		/// </code>
		/// </example>
		public static implicit operator KiwoomDecimal(decimal? value) => new(value);

		/// <summary>
		/// 현재 인스턴스의 문자열 표현을 반환합니다.
		/// </summary>
		/// <returns>방향과 값이 결합된 문자열 또는 값만의 문자열</returns>
		/// <remarks>
		/// Direction이 있는 경우 "{Direction}{Value}" 형태로,
		/// Direction이 없는 경우 "{Value}" 형태로 반환됩니다.
		/// Value가 null인 경우 "null"을 반환합니다.
		/// </remarks>
		/// <example>
		/// <code>
		/// var upPrice = new KiwoomDecimal(150, "+");
		/// Console.WriteLine(upPrice.ToString()); // "+150"
		/// 
		/// var normalPrice = new KiwoomDecimal(75000);
		/// Console.WriteLine(normalPrice.ToString()); // "75000"
		/// 
		/// var nullPrice = new KiwoomDecimal();
		/// Console.WriteLine(nullPrice.ToString()); // "null"
		/// </code>
		/// </example>
		public override string ToString() => Direction != null ? $"{Direction}{Value}" : Value?.ToString() ?? "null";
	}
}
