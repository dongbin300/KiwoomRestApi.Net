using Newtonsoft.Json;

using System;
using System.Globalization;

namespace KiwoomRestApi.Net.Converters
{
	public class KiwoomTimeSpanConverter : JsonConverter<TimeSpan?>
	{
		private static readonly string[] Formats = { "hhmmss", @"hh\:mm\:ss" };

		public override TimeSpan? ReadJson(JsonReader reader, Type objectType, TimeSpan? existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			var s = reader.Value as string;
			if (string.IsNullOrEmpty(s))
			{
				return null;
			}

			if (TimeSpan.TryParseExact(s, Formats, CultureInfo.InvariantCulture, out var ts))
			{
				return ts;
			}
			else
			{
				return default!;
			}
		}

		public override void WriteJson(JsonWriter writer, TimeSpan? value, JsonSerializer serializer)
		{
			writer.WriteValue(value?.ToString("hhmmss"));
		}
	}

}
