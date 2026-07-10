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
			public const string Industry = "/api/dostk/sect";
			public const string SecuritiesLending = "/api/dostk/slb";
			public const string ShortSale = "/api/dostk/shsa";
			public const string Theme = "/api/dostk/thme";
			public const string Watchlist = "/api/dostk/watchlist";

			public const string Socket = "/api/dostk/websocket";
		}

		public static class UsStock
		{
			public const string Account = "/api/us/acnt";
			public const string Chart = "/api/us/chart";
			public const string Exchange = "/api/us/exchange";
			public const string Industry = "/api/us/sect";
			public const string InvestmentInfo = "/api/us/invtinfo";
			public const string MarketCondition = "/api/us/mrkcond";
			public const string Order = "/api/us/ordr";
			public const string RankingInfo = "/api/us/rkinfo";
			public const string Socket = "/api/us/websocket";
			public const string StockInfo = "/api/us/stkinfo";
			public const string Watchlist = "/api/us/watchlist";
		}
	}
}