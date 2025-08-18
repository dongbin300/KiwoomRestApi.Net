using KiwoomRestApi.Net.Objects.Commons;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System;

namespace KiwoomRestApi.Net.Converters
{
	public class KiwoomRestApiResponseConverter<T> : JsonConverter<KiwoomRestApiResponse<T>>
	{
		public override KiwoomRestApiResponse<T>? ReadJson(JsonReader reader, Type objectType, KiwoomRestApiResponse<T>? existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			var jsonObject = JObject.Load(reader);

			var response = new KiwoomRestApiResponse<T>
			{
				ReturnMessage = jsonObject["return_msg"]?.ToString().Trim() ?? "",
				ReturnCode = jsonObject["return_code"]?.ToObject<int>() ?? 0
			};

			jsonObject.Remove("return_msg");
			jsonObject.Remove("return_code");

			response.Data = jsonObject.ToObject<T>(serializer)!;

			return response;
		}

		public override void WriteJson(JsonWriter writer, KiwoomRestApiResponse<T>? value, JsonSerializer serializer)
		{
			throw new NotImplementedException();
		}
	}
}
