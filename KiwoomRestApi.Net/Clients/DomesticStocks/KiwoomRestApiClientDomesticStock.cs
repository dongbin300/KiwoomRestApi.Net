namespace KiwoomRestApi.Net.Clients.DomesticStocks
{
	/// <summary>
	/// 국내주식 관련 기능의 진입점입니다.
	/// 계좌, 주문, 차트 등 국내주식 하위 클라이언트를 제공합니다.
	/// </summary>
	/// <param name="client"></param>
	public class KiwoomRestApiClientDomesticStock(KiwoomRestApiClient client)
	{
		/// <summary>
		/// 계좌 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientDomesticStockAccount Account { get; set; } = new KiwoomRestApiClientDomesticStockAccount(client);

		/// <summary>
		/// 공매도 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientDomesticStockShortSale ShortSale { get; set; } = new KiwoomRestApiClientDomesticStockShortSale(client);

		/// <summary>
		/// 외국인/기관 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientDomesticStockForeignInstitution ForeignInstitution { get; set; } = new KiwoomRestApiClientDomesticStockForeignInstitution(client);

		/// <summary>
		/// 대차거래 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientDomesticStockSecuritiesLending SecuritiesLending { get; set; } = new KiwoomRestApiClientDomesticStockSecuritiesLending(client);

		/// <summary>
		/// 순위 정보 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientDomesticStockRankingInfo RankingInfo { get; set; } = new KiwoomRestApiClientDomesticStockRankingInfo(client);

		/// <summary>
		/// 시장 상황 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientDomesticStockMarketCondition MarketCondition { get; set; } = new KiwoomRestApiClientDomesticStockMarketCondition(client);

		/// <summary>
		/// 신용 주문 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientDomesticStockCreditOrder CreditOrder { get; set; } = new KiwoomRestApiClientDomesticStockCreditOrder(client);

		/// <summary>
		/// 업종 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientDomesticStockIndustry Industry { get; set; } = new KiwoomRestApiClientDomesticStockIndustry(client);

		/// <summary>
		/// 주식 정보 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientDomesticStockInfo StockInfo { get; set; } = new KiwoomRestApiClientDomesticStockInfo(client);

		/// <summary>
		/// 주문 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientDomesticStockOrder Order { get; set; } = new KiwoomRestApiClientDomesticStockOrder(client);

		/// <summary>
		/// 차트 데이터 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientDomesticStockChart Chart { get; set; } = new KiwoomRestApiClientDomesticStockChart(client);

		/// <summary>
		/// 테마 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientDomesticStockTheme Theme { get; set; } = new KiwoomRestApiClientDomesticStockTheme(client);

		/// <summary>
		/// ELW 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientDomesticStockElw Elw { get; set; } = new KiwoomRestApiClientDomesticStockElw(client);

		/// <summary>
		/// ETF 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientDomesticStockEtf Etf { get; set; } = new KiwoomRestApiClientDomesticStockEtf(client);

		/// <summary>
		/// 관심종목 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientDomesticStockWatchlist Watchlist { get; set; } = new KiwoomRestApiClientDomesticStockWatchlist(client);
	}
}
