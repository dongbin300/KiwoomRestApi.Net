using KiwoomRestApi.Net.Objects.Commons;

using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Extensions
{
	public static class KiwoomExtension
	{
		private static readonly ConcurrentDictionary<Enum, string> _enumCache = new();

		public static string ToFormattedString(this object? value)
		{
			return value switch
			{
				null => string.Empty,
				DateTime dt => dt.ToString("yyyyMMdd"),
				decimal dec => dec.ToString("F0"),
				bool boolean => boolean ? "1" : "0",
				Enum e => e.ToEnumString(),
				_ => value.ToString() ?? string.Empty
			};
		}

		public static string ToEnumString(this Enum value)
		{
			return _enumCache.GetOrAdd(value, (key) =>
			{
				var type = key.GetType();
				var name = key.ToString();
				var memberInfo = type.GetMember(name).FirstOrDefault();

				if (memberInfo != null)
				{
					var attr = memberInfo.GetCustomAttribute<EnumMemberAttribute>();
					if (attr != null && !string.IsNullOrEmpty(attr.Value))
					{
						return attr.Value!;
					}
				}

				return Convert.ToInt32(key).ToString();
			});
		}

		public static KiwoomRestApiResponse<TTarget> MapResponse<TSource, TTarget>(this KiwoomRestApiResponse<TSource> source, Func<TSource, TTarget> mapper) where TSource : class where TTarget : class
		{
			if (source == null)
			{
				throw new ArgumentNullException(nameof(source));
			}

			if (mapper == null)
			{
				throw new ArgumentNullException(nameof(mapper));
			}

			return new KiwoomRestApiResponse<TTarget>
			{
				Data = source.Data is { } data ? mapper(data) : null,
				ReturnMessage = source.ReturnMessage,
				ReturnCode = source.ReturnCode,
				ApiId = source.ApiId,
				NextKey = source.NextKey,
				ContYn = source.ContYn
			};
		}
	}
}
