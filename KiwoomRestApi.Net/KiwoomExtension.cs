using System;

namespace KiwoomRestApi.Net
{
	public static class KiwoomExtension
	{
		public static string ToCodeString<TEnum>(this TEnum enumValue) where TEnum : struct, Enum
		{
			return Convert.ToInt32(enumValue).ToString();
		}

		public static string ToKiwoomDateString(this DateTime dateTime)
		{
			return dateTime.ToString("yyyyMMdd");
		}
	}
}
