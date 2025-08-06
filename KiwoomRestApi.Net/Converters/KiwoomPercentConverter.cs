

using Newtonsoft.Json;

using System;
using System.Globalization;

namespace KiwoomRestApi.Net.Converters
{
	public class KiwoomPercentConverter : JsonConverter<decimal>
	{
		public override decimal ReadJson(JsonReader reader, Type objectType, decimal existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			if (reader.Value == null)
				return 0m;

			var s = reader.Value.ToString()?.Trim();
			if (string.IsNullOrEmpty(s))
				return 0m;

			if (s.EndsWith("%"))
				s = s.Substring(0, s.Length - 1);

			if (decimal.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out var value))
			{
				return value / 100m;
			}

			throw new JsonSerializationException($"Cannot convert '{reader.Value}' to decimal percent value");
		}

		public override void WriteJson(JsonWriter writer, decimal value, JsonSerializer serializer)
		{
			writer.WriteValue((value * 100m).ToString(CultureInfo.InvariantCulture) + "%");
		}
	}
}
