using KiwoomRestApi.Net.Objects.Commons;

using System;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Extensions
{
	public static class KiwoomExtension
	{
		public static string ToFormattedString(this object? value)
		{
			if (value == null)
			{
				return string.Empty;
			}

			if (value is DateTime dt)
			{
				return dt.ToString("yyyyMMdd");
			}

			if (value is decimal dec)
			{
				return dec.ToString("F0");
			}

			if (value is bool boolean)
			{
				return boolean ? "1" : "0";
			}

			if (value is Enum e)
			{
				return e.ToEnumString();
			}

			return value.ToString() ?? string.Empty;
		}

		public static string ToEnumString(this Enum value)
		{
			var memberInfo = value.GetType().GetMember(value.ToString()).FirstOrDefault();
			if (memberInfo != null)
			{
				var enumMemberAttr = memberInfo.GetCustomAttribute<EnumMemberAttribute>();
				if (enumMemberAttr != null && !string.IsNullOrEmpty(enumMemberAttr.Value))
				{
					return enumMemberAttr.Value;
				}
			}
			return Convert.ToInt32(value).ToString();
		}

		public static KiwoomRestApiResponse<TTarget> MapResponse<TSource, TTarget>(
		this KiwoomRestApiResponse<TSource> source,
		Func<TSource, TTarget> mapper)
		where TSource : class
		where TTarget : class
		{
			if (source == null)
			{
				throw new ArgumentNullException(nameof(source));
			}

			if (mapper == null)
			{
				throw new ArgumentNullException(nameof(mapper));
			}

			TTarget? mappedData = source.Data != null ? mapper(source.Data) : null;

			return new KiwoomRestApiResponse<TTarget>
			{
				Data = mappedData,
				ReturnMessage = source.ReturnMessage,
				ReturnCode = source.ReturnCode,
				ApiId = source.ApiId,
				NextKey = source.NextKey,
				ContYn = source.ContYn
			};
		}
	}
}
