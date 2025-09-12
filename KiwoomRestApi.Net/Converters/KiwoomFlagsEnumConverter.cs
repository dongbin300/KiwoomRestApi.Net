using Newtonsoft.Json;

using System;

namespace KiwoomRestApi.Net.Converters
{
	/// <summary>
	/// Kiwoom API에서 사용하는 플래그 열거형과 C# Enum 타입 간의 변환을 처리하는 JSON 컨버터
	/// </summary>
	/// <typeparam name="T">변환할 Enum 타입</typeparam>
	public class KiwoomFlagsEnumConverter<T> : JsonConverter<T> where T : Enum
	{
		/// <summary>
		/// JSON에서 읽은 값을 플래그 열거형으로 변환합니다.
		/// </summary>
		/// <param name="reader">JSON 리더</param>
		/// <param name="objectType">대상 객체 타입</param>
		/// <param name="existingValue">기존 값</param>
		/// <param name="hasExistingValue">기존 값 존재 여부</param>
		/// <param name="serializer">JSON 시리얼라이저</param>
		/// <returns>변환된 Enum 값</returns>
		/// <exception cref="JsonSerializationException">유효하지 않은 열거형 형식일 경우 예외 발생</exception>
		public override T? ReadJson(JsonReader reader, Type objectType, T? existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			// 정수 타입인 경우 직접 변환
			if (reader.TokenType == JsonToken.Integer)
			{
				var intValue = Convert.ToInt64(reader.Value);
				return (T)Enum.ToObject(typeof(T), intValue);
			}
			// 문자열 타입인 경우
			else if (reader.TokenType == JsonToken.String)
			{
				if (reader.Value is not string strValue || string.IsNullOrEmpty(strValue))
				{
					return default!;
				}

				// 숫자 문자열인 경우 파싱하여 변환
				if (long.TryParse(strValue, out var parsed))
				{
					return (T)Enum.ToObject(typeof(T), parsed);
				}

				// 쉼표로 구분된 플래그 값들인 경우 (예: "1,2,4")
				if (strValue.Contains(","))
				{
					var parts = strValue.Split(',');
					long combinedValue = 0;

					// 각 플래그 값을 OR 연산으로 조합
					foreach (var part in parts)
					{
						var trimmedPart = part.Trim();
						if (long.TryParse(trimmedPart, out var partValue))
						{
							combinedValue |= partValue;
						}
					}

					return (T)Enum.ToObject(typeof(T), combinedValue);
				}

				// 열거형 이름으로 파싱 시도 (대소문자 구분 안함)
				return (T)Enum.Parse(typeof(T), strValue, ignoreCase: true);
			}

			throw new JsonSerializationException($"Invalid enum format: {reader.Value}");
		}

		/// <summary>
		/// 플래그 열거형 값을 JSON으로 쓸 때 정수 값으로 변환합니다.
		/// </summary>
		/// <param name="writer">JSON 라이터</param>
		/// <param name="value">변환할 Enum 값</param>
		/// <param name="serializer">JSON 시리얼라이저</param>
		public override void WriteJson(JsonWriter writer, T? value, JsonSerializer serializer)
		{
			// Enum 값을 정수로 변환하여 출력
			var intValue = Convert.ToInt64(value);
			writer.WriteValue(intValue);
		}
	}
}
