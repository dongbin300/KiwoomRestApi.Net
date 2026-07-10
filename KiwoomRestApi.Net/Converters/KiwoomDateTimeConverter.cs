using Newtonsoft.Json;

using System;
using System.Globalization;

namespace KiwoomRestApi.Net.Converters
{
	/// <summary>
	/// Kiwoom API에서 사용하는 날짜/시간 문자열과 C# DateTime 타입 간의 변환을 처리하는 JSON 컨버터
	/// </summary>
	public class KiwoomDateTimeConverter : JsonConverter<DateTime?>
	{
		/// <summary>날짜 형식 (yyyyMMdd)</summary>
		private const string FormatDate = "yyyyMMdd";

		/// <summary>
		/// JSON에서 읽은 날짜/시간 문자열을 DateTime으로 변환합니다.
		/// </summary>
		/// <param name="reader">JSON 리더</param>
		/// <param name="objectType">대상 객체 타입</param>
		/// <param name="existingValue">기존 값</param>
		/// <param name="hasExistingValue">기존 값 존재 여부</param>
		/// <param name="serializer">JSON 시리얼라이저</param>
		/// <returns>변환된 DateTime 값 또는 null</returns>
		/// <exception cref="JsonSerializationException">유효하지 않은 날짜 형식일 경우 예외 발생</exception>
		public override DateTime? ReadJson(JsonReader reader, Type objectType, DateTime? existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			var s = reader.Value as string;
			// 빈 문자열이면 null 반환
			if (s is null || s.Length == 0)
			{
				return null;
			}
			// "00000000"은 DateTime.MinValue로 처리
			if (s == "00000000")
			{
				return DateTime.MinValue;
			}
			// 날짜 형식 (yyyyMMdd) 파싱 시도
			if (DateTime.TryParseExact(s, FormatDate, CultureInfo.InvariantCulture, DateTimeStyles.None, out var dtDate))
			{
				return dtDate;
			}
			// 날짜시간 형식 (yyyyMMddHHmmss) 파싱 시도
			// 해외주식(미국주식 등)은 한국시간 기준 자정을 넘는 체결시간을 시(HH) 24 이상으로 표기하므로 TimeSpan으로 직접 계산
			if (s.Length == 14 && long.TryParse(s, NumberStyles.None, CultureInfo.InvariantCulture, out _))
			{
				var year = int.Parse(s.Substring(0, 4), CultureInfo.InvariantCulture);
				var month = int.Parse(s.Substring(4, 2), CultureInfo.InvariantCulture);
				var day = int.Parse(s.Substring(6, 2), CultureInfo.InvariantCulture);
				var hour = int.Parse(s.Substring(8, 2), CultureInfo.InvariantCulture);
				var minute = int.Parse(s.Substring(10, 2), CultureInfo.InvariantCulture);
				var second = int.Parse(s.Substring(12, 2), CultureInfo.InvariantCulture);
				return new DateTime(year, month, day) + new TimeSpan(hour, minute, second);
			}
			// 시간 형식 (HHmmss) 파싱 시도 - 오늘 날짜와 결합, 시(HH) 24 이상도 지원
			if (s.Length == 6 && long.TryParse(s, NumberStyles.None, CultureInfo.InvariantCulture, out _))
			{
				var hour = int.Parse(s.Substring(0, 2), CultureInfo.InvariantCulture);
				var minute = int.Parse(s.Substring(2, 2), CultureInfo.InvariantCulture);
				var second = int.Parse(s.Substring(4, 2), CultureInfo.InvariantCulture);
				return DateTime.Today + new TimeSpan(hour, minute, second);
			}
			throw new JsonSerializationException($"Invalid date format: {s}");
		}
		/// <summary>
		/// DateTime 값을 JSON으로 쓸 때 날짜 문자열로 변환합니다.
		/// </summary>
		/// <param name="writer">JSON 라이터</param>
		/// <param name="value">변환할 DateTime 값</param>
		/// <param name="serializer">JSON 시리얼라이저</param>
		public override void WriteJson(JsonWriter writer, DateTime? value, JsonSerializer serializer)
		{
			// 날짜 형식 (yyyyMMdd)으로 출력
			writer.WriteValue(value?.ToString(FormatDate));
		}
	}
}
