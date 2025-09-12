using Newtonsoft.Json;

using System;
using System.Globalization;

namespace KiwoomRestApi.Net.Converters
{
	/// <summary>
	/// Kiwoom API에서 사용하는 시간 문자열과 C# TimeSpan 타입 간의 변환을 처리하는 JSON 컨버터
	/// </summary>
	public class KiwoomTimeSpanConverter : JsonConverter<TimeSpan?>
	{
		/// <summary>지원하는 시간 형식들 (hhmmss, hh:mm:ss)</summary>
		private static readonly string[] Formats = { "hhmmss", @"hh\:mm\:ss" };

		/// <summary>
		/// JSON에서 읽은 시간 문자열을 TimeSpan으로 변환합니다.
		/// </summary>
		/// <param name="reader">JSON 리더</param>
		/// <param name="objectType">대상 객체 타입</param>
		/// <param name="existingValue">기존 값</param>
		/// <param name="hasExistingValue">기존 값 존재 여부</param>
		/// <param name="serializer">JSON 시리얼라이저</param>
		/// <returns>변환된 TimeSpan 값 또는 null</returns>
		public override TimeSpan? ReadJson(JsonReader reader, Type objectType, TimeSpan? existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			var s = reader.Value as string;
			// 빈 문자열이면 null 반환
			if (string.IsNullOrEmpty(s))
			{
				return null;
			}

			// 지원하는 형식 중 하나로 파싱 시도
			if (TimeSpan.TryParseExact(s, Formats, CultureInfo.InvariantCulture, out var ts))
			{
				return ts;
			}
			else
			{
				// 파싱 실패 시 기본값 반환
				return default!;
			}
		}

		/// <summary>
		/// TimeSpan 값을 JSON으로 쓸 때 시간 문자열로 변환합니다.
		/// </summary>
		/// <param name="writer">JSON 라이터</param>
		/// <param name="value">변환할 TimeSpan 값</param>
		/// <param name="serializer">JSON 시리얼라이저</param>
		public override void WriteJson(JsonWriter writer, TimeSpan? value, JsonSerializer serializer)
		{
			// hhmmss 형식으로 출력
			writer.WriteValue(value?.ToString("hhmmss"));
		}
	}

}
