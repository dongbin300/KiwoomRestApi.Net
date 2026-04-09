using System;
using System.Collections.Generic;
using System.IO;

namespace KiwoomRestApi.Net.Misc
{
	public class KeyVault
	{
		public static (string AppKey, string SecretKey) GetKey(string keyword)
		{
			string filePath = @"D:\Assets\api.txt";

			if (!File.Exists(filePath))
			{
				return (string.Empty, string.Empty);
			}

			using var reader = new StreamReader(filePath);
			string? line;
			bool inSection = false;
			List<string> resultLines = [];

			while ((line = reader.ReadLine()) != null)
			{
				line = line.Trim();

				if (string.IsNullOrWhiteSpace(line))
					continue;

				if (line.Equals(keyword, StringComparison.OrdinalIgnoreCase) || line.Equals($"# {keyword}", StringComparison.OrdinalIgnoreCase))
				{
					inSection = true;
					continue;
				}

				if (inSection)
				{
					if (line.StartsWith("#"))
						break;

					if (!string.IsNullOrWhiteSpace(line))
					{
						resultLines.Add(line);
						if (resultLines.Count >= 2)
							break;
					}
				}
			}

			string appKey = resultLines.Count > 0 ? resultLines[0] : string.Empty;
			string secretKey = resultLines.Count > 1 ? resultLines[1] : string.Empty;

			return (appKey, secretKey);
		}
	}
}
