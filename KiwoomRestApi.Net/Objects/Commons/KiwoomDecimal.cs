using KiwoomRestApi.Net.Converters;

using Newtonsoft.Json;

namespace KiwoomRestApi.Net.Objects.Commons
{
	[JsonConverter(typeof(KiwoomNormalizerConverter))]
	public class KiwoomDecimal(decimal? value = null, string? direction = null)
	{
		public string? Direction { get; private set; } = direction;
		public decimal? Value { get; private set; } = value;

		public static implicit operator decimal?(KiwoomDecimal? value) => value?.Value;
		public static implicit operator KiwoomDecimal(decimal? value) => new(value);

		public override string ToString() => Direction != null ? $"{Direction}{Value}" : Value?.ToString() ?? "null";
	}
}
