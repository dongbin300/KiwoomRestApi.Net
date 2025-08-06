using System.Collections.Generic;
using System.Linq;

namespace KiwoomRestApi.Net.Objects
{
	public class HttpParameterMap : Dictionary<string, string>
	{
		public HttpParameterMap AddField(string key, object? value)
		{
			base[key] = value.ToFormattedString();
			return this;
		}

		public override string ToString()
		{
			return string.Join(", ", this.Select(kv => $"{kv.Key}: {kv.Value}"));
		}
	}

}
