using KiwoomRestApi.Net.Converters;

using Newtonsoft.Json;

namespace KiwoomRestApi.Net.Objects.Commons
{
	/// <summary>
	/// 키움증권 API의 특수한 문자열 표현을 다루는 클래스입니다.
	/// 문자열의 상태나 분류(+/-)와 텍스트를 함께 표현할 수 있습니다.
	/// </summary>
	/// <remarks>
	/// 키움증권 API는 종목명, 상태코드, 등락 구분 같은 데이터를 방향성이나 분류와 함께 제공합니다.
	/// 이 클래스는 그러한 데이터를 편리하게 처리하기 위해 설계되었으며,
	/// JSON 직렬화/역직렬화를 위한 커스텀 컨버터가 적용되어 있습니다.
	/// </remarks>
	/// <example>
	/// <code>
	/// // 상승 종목 (+삼성전자)
	/// var upStock = new KiwoomString("삼성전자", "+");
	/// Console.WriteLine(upStock.ToString()); // "+삼성전자"
	/// 
	/// // 하락 종목 (-LG화학)
	/// var downStock = new KiwoomString("LG화학", "-");
	/// Console.WriteLine(downStock.ToString()); // "-LG화학"
	/// 
	/// // 일반 문자열
	/// var stockName = new KiwoomString("현대차");
	/// string? actualValue = stockName; // 암시적 변환
	/// </code>
	/// </example>
	/// <param name="value">문자열 값 (선택적)</param>
	/// <param name="direction">방향 표시자 (예: "+", "-", 선택적)</param>
	[JsonConverter(typeof(KiwoomNormalizerConverter))]
	public class KiwoomString(string? value = null, string? direction = null)
	{
		/// <summary>
		/// 문자열의 방향이나 분류를 나타내는 문자열을 가져옵니다.
		/// </summary>
		/// <value>방향 표시자 (예: "+", "-") 또는 null</value>
		/// <remarks>
		/// 양의 빨간색은 "+", 음의 파란색은 "-"로 표현됩니다.
		/// null인 경우 방향성이나 분류가 없는 일반적인 문자열을 의미합니다.
		/// </remarks>
		public string? Direction { get; private set; } = direction;

		/// <summary>
		/// 문자열 값을 가져옵니다.
		/// </summary>
		/// <value>문자열 값 또는 null</value>
		/// <remarks>
		/// 실제 텍스트 데이터를 나타내며, null인 경우 값이 없음을 의미합니다.
		/// </remarks>
		public string? Value { get; private set; } = value;

		/// <summary>
		/// KiwoomString을 string?로 암시적 변환합니다.
		/// </summary>
		/// <param name="value">변환할 KiwoomString 인스턴스</param>
		/// <returns>Value 속성의 값 또는 null</returns>
		/// <remarks>
		/// 이 변환 연산자를 통해 KiwoomString을 일반적인 string? 타입처럼 사용할 수 있습니다.
		/// </remarks>
		/// <example>
		/// <code>
		/// var kiwoomString = new KiwoomString("삼성전자");
		/// string? normalString = kiwoomString; // 암시적 변환
		/// </code>
		/// </example>
		public static implicit operator string?(KiwoomString? value) => value?.Value;

		/// <summary>
		/// string?을 KiwoomString로 암시적 변환합니다.
		/// </summary>
		/// <param name="value">변환할 string? 값</param>
		/// <returns>새로운 KiwoomString 인스턴스</returns>
		/// <remarks>
		/// 이 변환 연산자를 통해 일반적인 string? 값을 KiwoomString로 쉽게 변환할 수 있습니다.
		/// Direction은 null로 설정됩니다.
		/// </remarks>
		/// <example>
		/// <code>
		/// string? normalString = "삼성전자";
		/// KiwoomString kiwoomString = normalString; // 암시적 변환
		/// </code>
		/// </example>
		public static implicit operator KiwoomString(string? value) => new(value);

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
		/// var upStock = new KiwoomString("삼성전자", "+");
		/// Console.WriteLine(upStock.ToString()); // "+삼성전자"
		/// 
		/// var normalStock = new KiwoomString("현대차");
		/// Console.WriteLine(normalStock.ToString()); // "현대차"
		/// 
		/// var nullStock = new KiwoomString();
		/// Console.WriteLine(nullStock.ToString()); // "null"
		/// </code>
		/// </example>
		public override string ToString() => Direction != null ? $"{Direction}{Value}" : Value ?? "null";

		/// <summary>
		/// 두 KiwoomString 인스턴스가 같은지 비교합니다.
		/// </summary>
		/// <param name="obj">비교할 객체</param>
		/// <returns>같으면 true, 다르면 false</returns>
		/// <remarks>
		/// Value와 Direction이 모두 같아야 true를 반환합니다.
		/// </remarks>
		public override bool Equals(object? obj)
		{
			if (obj is KiwoomString other)
			{
				return Value == other.Value && Direction == other.Direction;
			}
			return false;
		}

		/// <summary>
		/// 해시코드를 얻습니다.
		/// </summary>
		/// <returns>해시코드</returns>
		public override int GetHashCode() => base.GetHashCode();

		/// <summary>
		/// 두 KiwoomString이 같은지 비교하는 연산자입니다.
		/// </summary>
		/// <param name="left">왼쪽 KiwoomString</param>
		/// <param name="right">오른쪽 KiwoomString</param>
		/// <returns>같으면 true, 다르면 false</returns>
		public static bool operator ==(KiwoomString? left, KiwoomString? right)
		{
			if (ReferenceEquals(left, right)) return true;
			if (left is null || right is null) return false;
			return left.Equals(right);
		}

		/// <summary>
		/// 두 KiwoomString이 다른지 비교하는 연산자입니다.
		/// </summary>
		/// <param name="left">왼쪽 KiwoomString</param>
		/// <param name="right">오른쪽 KiwoomString</param>
		/// <returns>다르면 true, 같으면 false</returns>
		public static bool operator !=(KiwoomString? left, KiwoomString? right) => !(left == right);
	}
}
