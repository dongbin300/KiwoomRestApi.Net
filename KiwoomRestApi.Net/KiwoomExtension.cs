using KiwoomRestApi.Net.Objects;

using System;

namespace KiwoomRestApi.Net
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
				return Convert.ToInt32(e).ToString();
			}

			return value.ToString() ?? string.Empty;
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
