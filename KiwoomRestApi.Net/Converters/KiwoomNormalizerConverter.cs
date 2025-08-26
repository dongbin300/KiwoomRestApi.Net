using KiwoomRestApi.Net.Objects.Commons;

using Newtonsoft.Json;

using System;
using System.Globalization;

namespace KiwoomRestApi.Net.Converters
{
	public class KiwoomNormalizerConverter : JsonConverter<KiwoomDecimal>
	{
		public override KiwoomDecimal ReadJson(JsonReader reader, Type objectType, KiwoomDecimal? existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			var s = reader.Value as string;
			if (string.IsNullOrWhiteSpace(s))
				return new KiwoomDecimal(null);

			s = s.Trim();

			string? direction = null;
			string valueStr = s;

			if (s.StartsWith("--"))
			{
				direction = "-";
				valueStr = "-" + s.Substring(2);
			}
			else if (s.StartsWith("+"))
			{
				direction = "+";
				valueStr = s.Substring(1);
			}
			else if (s.StartsWith("-") && !s.StartsWith("--"))
			{
				direction = "-";
				valueStr = s.Substring(1);
			}

			if (decimal.TryParse(valueStr, NumberStyles.Any, CultureInfo.InvariantCulture, out var result))
			{
				return new KiwoomDecimal(result, direction);
			}

			throw new JsonSerializationException($"Invalid decimal format: {s}");
		}

		public override void WriteJson(JsonWriter writer, KiwoomDecimal? value, JsonSerializer serializer)
		{
			if (value?.Value == null)
			{
				writer.WriteNull();
				return;
			}

			var output = value.Direction != null
				? $"{value.Direction}{value.Value.Value.ToString(CultureInfo.InvariantCulture)}"
				: value.Value.Value.ToString(CultureInfo.InvariantCulture);

			writer.WriteValue(output);
		}
	}
}
