using KiwoomRestApi.Net.Objects.Commons;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System;
using System.Diagnostics;

namespace KiwoomRestApi.Net.Converters
{
	/// <summary>
	/// Kiwoom REST API 응답 형식을 KiwoomRestApiResponse 객체로 변환하는 JSON 컨버터
	/// </summary>
	/// <typeparam name="T">응답 데이터의 타입</typeparam>
	public class KiwoomRestApiResponseConverter<T> : JsonConverter<KiwoomRestApiResponse<T>>
	{
		/// <summary>
		/// JSON 응답을 KiwoomRestApiResponse 객체로 변환합니다.
		/// </summary>
		/// <param name="reader">JSON 리더</param>
		/// <param name="objectType">대상 객체 타입</param>
		/// <param name="existingValue">기존 값</param>
		/// <param name="hasExistingValue">기존 값 존재 여부</param>
		/// <param name="serializer">JSON 시리얼라이저</param>
		/// <returns>변환된 KiwoomRestApiResponse 객체</returns>
		public override KiwoomRestApiResponse<T>? ReadJson(JsonReader reader, Type objectType, KiwoomRestApiResponse<T>? existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			var jsonObject = JObject.Load(reader);

			// 응답 공통 정보 추출
			var response = new KiwoomRestApiResponse<T>
			{
				ReturnMessage = jsonObject["return_msg"]?.ToString().Trim() ?? "",
				ReturnCode = jsonObject["return_code"]?.ToObject<int>() ?? 0
			};

			// 공통 필드 제거
			jsonObject.Remove("return_msg");
            jsonObject.Remove("return_code");

            // 나머지 데이터를 지정된 타입으로 변환
            response.Data = jsonObject.ToObject<T>(serializer)!;

            return response;
        }

        /// <summary>
        /// KiwoomRestApiResponse 객체를 JSON으로 직렬화합니다. (미구현)
        /// </summary>
        /// <param name="writer">JSON 라이터</param>
        /// <param name="value">직렬화할 값</param>
        /// <param name="serializer">JSON 시리얼라이저</param>
        /// <exception cref="NotImplementedException">쓰기 기능은 구현되지 않음</exception>
        public override void WriteJson(JsonWriter writer, KiwoomRestApiResponse<T>? value, JsonSerializer serializer)
		{
			throw new NotImplementedException();
		}
	}
}
