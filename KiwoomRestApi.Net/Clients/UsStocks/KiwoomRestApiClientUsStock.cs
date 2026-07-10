namespace KiwoomRestApi.Net.Clients.UsStocks
{
	/// <summary>
	/// 미국주식 관련 기능의 진입점입니다.
	/// 주문, 계좌, 차트 등 미국주식 하위 클라이언트를 제공합니다.
	/// </summary>
	/// <param name="client"></param>
	public class KiwoomRestApiClientUsStock(KiwoomRestApiClient client)
	{
		/// <summary>
		/// 미국주식 주문 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientUsStockOrder Order { get; set; } = new KiwoomRestApiClientUsStockOrder(client);

		/// <summary>
		/// 미국주식 차트 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientUsStockChart Chart { get; set; } = new KiwoomRestApiClientUsStockChart(client);

		/// <summary>
		/// 미국주식 투자정보 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientUsStockInvestmentInfo InvestmentInfo { get; set; } = new KiwoomRestApiClientUsStockInvestmentInfo(client);

		/// <summary>
		/// 미국주식 환전 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientUsStockExchange Exchange { get; set; } = new KiwoomRestApiClientUsStockExchange(client);

		/// <summary>
		/// 미국주식 종목정보 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientUsStockInfo StockInfo { get; set; } = new KiwoomRestApiClientUsStockInfo(client);

		/// <summary>
		/// 미국주식 업종 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientUsStockIndustry Industry { get; set; } = new KiwoomRestApiClientUsStockIndustry(client);

		/// <summary>
		/// 미국주식 시세 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientUsStockMarketCondition MarketCondition { get; set; } = new KiwoomRestApiClientUsStockMarketCondition(client);

		/// <summary>
		/// 미국주식 순위정보 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientUsStockRankingInfo RankingInfo { get; set; } = new KiwoomRestApiClientUsStockRankingInfo(client);

		/// <summary>
		/// 미국주식 관심종목 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientUsStockWatchlist Watchlist { get; set; } = new KiwoomRestApiClientUsStockWatchlist(client);

		/// <summary>
		/// 미국주식 계좌 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientUsStockAccount Account { get; set; } = new KiwoomRestApiClientUsStockAccount(client);
	}
}
