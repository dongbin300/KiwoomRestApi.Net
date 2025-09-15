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
    /// var upPrice = new KiwoomInt(150, "+");
    /// Console.WriteLine(upPrice.ToString()); // "+150"
    /// 
    /// // 하락 (-50원)
    /// var downPrice = new KiwoomInt(50, "-");
    /// Console.WriteLine(downPrice.ToString()); // "-50"
    /// 
    /// // 일반 수치
    /// var price = new KiwoomInt(75000);
    /// int? actualValue = price; // 암시적 변환
    /// </code>
    /// </example>
    /// <param name="value">십진수 값 (선택적)</param>
    /// <param name="direction">방향 표시자 (예: "+", "-", 선택적)</param>
    [JsonConverter(typeof(KiwoomNormalizerConverter))]
	public class KiwoomInt(int? value = null, string? direction = null)
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
		public int? Value { get; private set; } = value;

        /// <summary>
        /// KiwoomInt을 int?로 암시적 변환합니다.
        /// </summary>
        /// <param name="value">변환할 KiwoomInt 인스턴스</param>
        /// <returns>Value 속성의 값 또는 null</returns>
        /// <remarks>
        /// 이 변환 연산자를 통해 KiwoomInt을 일반적인 int? 타입처럼 사용할 수 있습니다.
        /// </remarks>
        /// <example>
        /// <code>
        /// var kiwoomInt = new KiwoomInt(150.5m);
        /// int? normalInt = kiwoomInt; // 암시적 변환
        /// </code>
        /// </example>
        public static implicit operator int?(KiwoomInt? value) => value?.Value;

        /// <summary>
        /// int?을 KiwoomInt로 암시적 변환합니다.
        /// </summary>
        /// <param name="value">변환할 int? 값</param>
        /// <returns>새로운 KiwoomInt 인스턴스</returns>
        /// <remarks>
        /// 이 변환 연산자를 통해 일반적인 int? 값을 KiwoomInt로 쉽게 변환할 수 있습니다.
        /// Direction은 null로 설정됩니다.
        /// </remarks>
        /// <example>
        /// <code>
        /// int? normalInt = 150.5m;
        /// KiwoomInt kiwoomInt = normalInt; // 암시적 변환
        /// </code>
        /// </example>
        public static implicit operator KiwoomInt(int? value) => new(value);

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
		/// var upPrice = new KiwoomInt(150, "+");
		/// Console.WriteLine(upPrice.ToString()); // "+150"
		/// 
		/// var normalPrice = new KiwoomInt(75000);
		/// Console.WriteLine(normalPrice.ToString()); // "75000"
		/// 
		/// var nullPrice = new KiwoomInt();
		/// Console.WriteLine(nullPrice.ToString()); // "null"
		/// </code>
		/// </example>
		public override string ToString() => Direction != null ? $"{Direction}{Value}" : Value?.ToString() ?? "null";
	}
}
