using Newtonsoft.Json;

using System;
using System.Globalization;

namespace KiwoomRestApi.Net.Converters
{
	public class KiwoomNullableDateConverter : JsonConverter<DateTime?>
	{
		private const string Format = "yyyyMMdd";

		public override DateTime? ReadJson(JsonReader reader, Type objectType, DateTime? existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			var s = reader.Value as string;
			if (string.IsNullOrEmpty(s))
			{
				return null;
			}
			if (DateTime.TryParseExact(s, Format, CultureInfo.InvariantCulture, DateTimeStyles.None, out var dt))
			{
				return dt;
			}
			throw new JsonSerializationException($"Invalid date format: {s}");
		}

		public override void WriteJson(JsonWriter writer, DateTime? value, JsonSerializer serializer)
		{
			writer.WriteValue(value?.ToString(Format));
		}
	}
}
