namespace KiwoomRestApi.Net.Objects
{
	public static class ApiEndpoint
	{
		public const string OAuthGet = "/oauth2/token";
		public const string OAuthRevoke = "/oauth2/revoke";

		public static class DomesticStock
		{
			public const string Account = "/api/dostk/acnt";
			public const string Chart = "/api/dostk/chart";
			public const string CreditOrder = "/api/dostk/crdordr";
			public const string Elw = "/api/dostk/elw";
			public const string Etf = "/api/dostk/etf";
			public const string ForeignInstitution = "/api/dostk/frgnistt";
			public const string StockInfo = "/api/dostk/stkinfo";
			public const string MarketCondition = "/api/dostk/mrkcond";
			public const string Order = "/api/dostk/ordr";
			public const string RankingInfo = "/api/dostk/rkinfo";
			public const string Sector = "/api/dostk/sect";
			public const string SecuritiesLendingAndBorrowing = "/api/dostk/slb";
			public const string ShortSale = "/api/dostk/shsa";
			public const string Theme = "/api/dostk/thme";
		}
	}
}