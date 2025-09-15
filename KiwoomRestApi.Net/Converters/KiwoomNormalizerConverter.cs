using KiwoomRestApi.Net.Objects.Commons;

using Newtonsoft.Json;

using System;
using System.Globalization;

namespace KiwoomRestApi.Net.Converters
{
    /// <summary>
    /// KiwoomDecimal, KiwoomString, KiwoomInt 타입의 JSON 직렬화/역직렬화를 처리하는 통합 컨버터입니다.
    /// </summary>
    /// <remarks>
    /// 키움증권 API에서 제공하는 특수한 형식을 각 타입에 맞게 변환합니다.
    /// - KiwoomDecimal: '--', '+', '-' 모두 지원 (숫자 파싱 포함)
    /// - KiwoomString: '+', '-'만 지원 (문자열 처리)
    /// - KiwoomInt: '--', '+', '-' 모두 지원 (정수 파싱 포함)
    /// </remarks>
    public class KiwoomNormalizerConverter : JsonConverter
    {
        /// <summary>
        /// 해당 타입이 변환 가능한지 확인합니다.
        /// </summary>
        /// <param name="objectType">확인할 타입</param>
        /// <returns>KiwoomDecimal, KiwoomString, 또는 KiwoomInt인 경우 true</returns>
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(KiwoomDecimal) ||
                   objectType == typeof(KiwoomString) ||
                   objectType == typeof(KiwoomInt);
        }

        /// <summary>
        /// JSON 문자열을 KiwoomDecimal, KiwoomString, 또는 KiwoomInt 객체로 역직렬화합니다.
        /// </summary>
        /// <param name="reader">JSON 리더</param>
        /// <param name="objectType">대상 타입 (KiwoomDecimal, KiwoomString, 또는 KiwoomInt)</param>
        /// <param name="existingValue">기존 값</param>
        /// <param name="serializer">JSON 직렬화기</param>
        /// <returns>변환된 객체</returns>
        /// <exception cref="JsonSerializationException">숫자 타입 변환 시 유효하지 않은 형식일 때 발생</exception>
        public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            var str = reader.Value as string;
            if (string.IsNullOrWhiteSpace(str))
            {
                return objectType switch
                {
                    var t when t == typeof(KiwoomDecimal) => new KiwoomDecimal(null),
                    var t when t == typeof(KiwoomString) => new KiwoomString(null),
                    var t when t == typeof(KiwoomInt) => new KiwoomInt(null),
                    _ => throw new JsonSerializationException($"Unsupported type: {objectType}")
                };
            }

            string s = str.Trim();
            string? direction = null;
            string valueStr = s;

            if (objectType == typeof(KiwoomDecimal))
            {
                // KiwoomDecimal: '--', '+', '-' 모두 지원
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
            else if (objectType == typeof(KiwoomInt))
            {
                // KiwoomInt: '--', '+', '-' 모두 지원
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

                if (int.TryParse(valueStr, NumberStyles.Any, CultureInfo.InvariantCulture, out var intResult))
                {
                    return new KiwoomInt(intResult, direction);
                }
                throw new JsonSerializationException($"Invalid integer format: {s}");
            }
            else // KiwoomString
            {
                // KiwoomString: '+', '-'만 지원 ('--' 없음)
                if (s.StartsWith("+"))
                {
                    direction = "+";
                    valueStr = s.Substring(1);
                }
                else if (s.StartsWith("-"))
                {
                    direction = "-";
                    valueStr = s.Substring(1);
                }
                return new KiwoomString(valueStr, direction);
            }
        }

        /// <summary>
        /// KiwoomDecimal, KiwoomString, 또는 KiwoomInt 객체를 JSON 문자열로 직렬화합니다.
        /// </summary>
        /// <param name="writer">JSON 라이터</param>
        /// <param name="value">직렬화할 객체</param>
        /// <param name="serializer">JSON 직렬화기</param>
        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            switch (value)
            {
                case KiwoomDecimal kd:
                    if (kd.Value == null)
                    {
                        writer.WriteNull();
                        return;
                    }
                    var decimalOutput = kd.Direction != null
                        ? $"{kd.Direction}{kd.Value.Value.ToString(CultureInfo.InvariantCulture)}"
                        : kd.Value.Value.ToString(CultureInfo.InvariantCulture);
                    writer.WriteValue(decimalOutput);
                    break;

                case KiwoomInt ki:
                    if (ki.Value == null)
                    {
                        writer.WriteNull();
                        return;
                    }
                    var intOutput = ki.Direction != null
                        ? $"{ki.Direction}{ki.Value.Value.ToString(CultureInfo.InvariantCulture)}"
                        : ki.Value.Value.ToString(CultureInfo.InvariantCulture);
                    writer.WriteValue(intOutput);
                    break;

                case KiwoomString ks:
                    if (ks.Value == null)
                    {
                        writer.WriteNull();
                        return;
                    }
                    var stringOutput = ks.Direction != null
                        ? $"{ks.Direction}{ks.Value}"
                        : ks.Value;
                    writer.WriteValue(stringOutput);
                    break;

                default:
                    writer.WriteNull();
                    break;
            }
        }
    }
}