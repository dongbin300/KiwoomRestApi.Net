using Newtonsoft.Json;

using System;

namespace KiwoomRestApi.Net.Converters
{
	public class KiwoomBoolConverter : JsonConverter<bool>
	{
		public override bool ReadJson(JsonReader reader, Type objectType, bool existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			var s = reader.Value?.ToString();
			if (string.Equals(s, "Y", StringComparison.OrdinalIgnoreCase)) return true;
			if (string.Equals(s, "N", StringComparison.OrdinalIgnoreCase)) return false;

			throw new JsonSerializationException($"Invalid value for boolean conversion: {s}");
		}

		public override void WriteJson(JsonWriter writer, bool value, JsonSerializer serializer)
		{
			writer.WriteValue(value ? "Y" : "N");
		}
	}
}
