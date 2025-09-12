

using Newtonsoft.Json;

using System;
using System.Globalization;

namespace KiwoomRestApi.Net.Converters
{
	/// <summary>
	/// Kiwoom API에서 사용하는 퍼센트 문자열과 C# decimal 타입 간의 변환을 처리하는 JSON 컨버터
	/// </summary>
	public class KiwoomPercentConverter : JsonConverter<decimal>
	{
		/// <summary>
		/// JSON에서 읽은 퍼센트 값을 decimal로 변환합니다.
		/// </summary>
		/// <param name="reader">JSON 리더</param>
		/// <param name="objectType">대상 객체 타입</param>
		/// <param name="existingValue">기존 값</param>
		/// <param name="hasExistingValue">기존 값 존재 여부</param>
		/// <param name="serializer">JSON 시리얼라이저</param>
		/// <returns>퍼센트 값을 소수점 형태로 변환 (예: 10% -> 0.1)</returns>
		/// <exception cref="JsonSerializationException">변환할 수 없는 값일 경우 예외 발생</exception>
		public override decimal ReadJson(JsonReader reader, Type objectType, decimal existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			// null 값은 0으로 처리
			if (reader.Value == null)
				return 0m;

			var s = reader.Value.ToString()?.Trim() ?? "0";

			// % 기호가 있으면 제거
			if (s.EndsWith("%"))
				s = s.Substring(0, s.Length - 1);

			// 숫자로 파싱 가능하면 100으로 나누어 소수점 형태로 변환
			if (decimal.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out var value))
			{
				return value / 100m;
			}

			throw new JsonSerializationException($"Cannot convert '{reader.Value}' to decimal percent value");
		}

		/// <summary>
		/// decimal 값을 JSON으로 쓸 때 퍼센트 문자열로 변환합니다.
		/// </summary>
		/// <param name="writer">JSON 라이터</param>
		/// <param name="value">변환할 decimal 값</param>
		/// <param name="serializer">JSON 시리얼라이저</param>
		public override void WriteJson(JsonWriter writer, decimal value, JsonSerializer serializer)
		{
			// 소수점 값을 100배하여 퍼센트 형태로 출력 (예: 0.1 -> 10%)
			writer.WriteValue((value * 100m).ToString(CultureInfo.InvariantCulture) + "%");
		}
	}
}
