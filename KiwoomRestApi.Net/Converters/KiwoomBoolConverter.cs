using Newtonsoft.Json;

using System;

namespace KiwoomRestApi.Net.Converters
{
	/// <summary>
	/// Kiwoom API에서 사용하는 Y/N 문자열과 C# bool 타입 간의 변환을 처리하는 JSON 컨버터
	/// </summary>
	public class KiwoomBoolConverter : JsonConverter<bool>
	{
		/// <summary>
		/// JSON에서 읽은 값을 bool로 변환합니다.
		/// </summary>
		/// <param name="reader">JSON 리더</param>
		/// <param name="objectType">대상 객체 타입</param>
		/// <param name="existingValue">기존 값</param>
		/// <param name="hasExistingValue">기존 값 존재 여부</param>
		/// <param name="serializer">JSON 시리얼라이저</param>
		/// <returns>"Y"는 true, "N"은 false로 변환</returns>
		/// <exception cref="JsonSerializationException">Y/N이 아닌 값일 경우 예외 발생</exception>
		public override bool ReadJson(JsonReader reader, Type objectType, bool existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			var s = reader.Value?.ToString();
			// "Y" 또는 "y"를 true로 변환
			if (string.Equals(s, "Y", StringComparison.OrdinalIgnoreCase)) return true;
			// "N" 또는 "n"을 false로 변환
			if (string.Equals(s, "N", StringComparison.OrdinalIgnoreCase)) return false;

			// Y/N이 아닌 값이면 예외 발생
			throw new JsonSerializationException($"Invalid value for boolean conversion: {s}");
		}

		/// <summary>
		/// bool 값을 JSON으로 쓸 때 Y/N 문자열로 변환합니다.
		/// </summary>
		/// <param name="writer">JSON 라이터</param>
		/// <param name="value">변환할 bool 값</param>
		/// <param name="serializer">JSON 시리얼라이저</param>
		public override void WriteJson(JsonWriter writer, bool value, JsonSerializer serializer)
		{
			// true는 "Y", false는 "N"으로 변환하여 출력
			writer.WriteValue(value ? "Y" : "N");
		}
	}
}
