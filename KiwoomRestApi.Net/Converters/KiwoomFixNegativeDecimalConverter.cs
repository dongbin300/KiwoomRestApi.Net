using Newtonsoft.Json;

using System;
using System.Globalization;

namespace KiwoomRestApi.Net.Converters
{
	public class KiwoomFixNegativeDecimalConverter : JsonConverter<decimal>
	{
		public override decimal ReadJson(JsonReader reader, Type objectType, decimal existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			var s = reader.Value as string;
			if (string.IsNullOrWhiteSpace(s))
				throw new JsonSerializationException("Decimal value is null or empty.");

			s = s?.Replace("--", "-").Trim();

			if (decimal.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out var result))
			{
				return result;
			}

			throw new JsonSerializationException($"Invalid decimal format: {s}");
		}

		public override void WriteJson(JsonWriter writer, decimal value, JsonSerializer serializer)
		{
			writer.WriteValue(value.ToString(CultureInfo.InvariantCulture));
		}
	}
}
