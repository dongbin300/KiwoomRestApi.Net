using Newtonsoft.Json;

using System;
using System.Globalization;

namespace KiwoomRestApi.Net.Converters
{
	public class KiwoomTimeConverter : JsonConverter<TimeSpan>
	{
		private const string Format = "hhmmss";

		public override TimeSpan ReadJson(JsonReader reader, Type objectType, TimeSpan existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			var s = reader.Value as string;
			if (string.IsNullOrEmpty(s))
				throw new JsonSerializationException("Time value is null or empty.");

			if (TimeSpan.TryParseExact(s, Format, CultureInfo.InvariantCulture, out var ts))
			{
				return ts;
			}

			throw new JsonSerializationException($"Invalid time format: {s}");
		}

		public override void WriteJson(JsonWriter writer, TimeSpan value, JsonSerializer serializer)
		{
			writer.WriteValue(value.ToString(@"hhmmss"));
		}
	}
}
