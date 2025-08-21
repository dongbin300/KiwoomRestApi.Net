using Newtonsoft.Json;

using System;
using System.Globalization;

namespace KiwoomRestApi.Net.Converters
{
	public class KiwoomDateTimeConverter : JsonConverter<DateTime?>
	{
		private const string FormatDate = "yyyyMMdd";
		private const string FormatDateTime = "yyyyMMddHHmmss";

		public override DateTime? ReadJson(JsonReader reader, Type objectType, DateTime? existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			var s = reader.Value as string;
			if (string.IsNullOrEmpty(s))
			{
				return null;
			}
			if (s == "00000000")
			{
				return DateTime.MinValue;
			}

			if (DateTime.TryParseExact(s, FormatDate, CultureInfo.InvariantCulture, DateTimeStyles.None, out var dtDate))
			{
				return dtDate;
			}

			if (DateTime.TryParseExact(s, FormatDateTime, CultureInfo.InvariantCulture, DateTimeStyles.None, out var dtDateTime))
			{
				return dtDateTime;
			}

			throw new JsonSerializationException($"Invalid date format: {s}");
		}

		public override void WriteJson(JsonWriter writer, DateTime? value, JsonSerializer serializer)
		{
			writer.WriteValue(value?.ToString(FormatDate));
		}
	}
}
