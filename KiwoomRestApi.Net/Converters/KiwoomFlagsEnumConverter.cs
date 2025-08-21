using Newtonsoft.Json;

using System;

namespace KiwoomRestApi.Net.Converters
{
	public class KiwoomFlagsEnumConverter<T> : JsonConverter<T> where T : Enum
	{
		public override T? ReadJson(JsonReader reader, Type objectType, T? existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			if (reader.TokenType == JsonToken.Integer)
			{
				var intValue = Convert.ToInt64(reader.Value);
				return (T)Enum.ToObject(typeof(T), intValue);
			}
			else if (reader.TokenType == JsonToken.String)
			{
				var strValue = reader.Value?.ToString();
				if (string.IsNullOrEmpty(strValue))
				{
					return default!;
				}
				if (long.TryParse(strValue, out var parsed))
				{
					return (T)Enum.ToObject(typeof(T), parsed);
				}
				return (T)Enum.Parse(typeof(T), strValue!, ignoreCase: true);
			}
			throw new JsonSerializationException($"Invalid enum format: {reader.Value}");
		}

		public override void WriteJson(JsonWriter writer, T? value, JsonSerializer serializer)
		{
			var intValue = Convert.ToInt64(value);
			writer.WriteValue(intValue);
		}
	}

}
