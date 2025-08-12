using KiwoomRestApi.Net.Enums.MarketCondition;
using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Models;

using System;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.DomesticStocks
{
	public class KiwoomRestApiClientDomesticStockMarketCondition(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = "/api/dostk/mrkcond";

		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetOrderBook>> GetOrderBookAsync(string stockCode)
		{
			const string apiId = "ka10004";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetOrderBook>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetOrderBookList>> GetOrderBookListAsync(string stockCode)
		{
			const string apiId = "ka10004";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			var response = await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetOrderBook>(_endpoint, apiId, body).ConfigureAwait(false);
			return response.MapResponse(r => new KiwoomMarketConditionGetOrderBookList(r));
		}

		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetDailyWeeklyMonthly>> GetDailyWeeklyMonthlyAsync(string stockCode)
		{
			const string apiId = "ka10005";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetDailyWeeklyMonthly>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetHourMinute>> GetHourMinuteAsync(string stockCode)
		{
			const string apiId = "ka10006";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetHourMinute>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetQuote>> GetQuoteAsync(string stockCode)
		{
			const string apiId = "ka10007";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetQuote>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetAllMarketQuoteForRightsOfferings>> GetAllMarketQuoteForRightsOfferingsAsync(KiwoomMarketConditionRightsType rightsType)
		{
			const string apiId = "ka10011";
			var body = new HttpParameterMap()
				.AddField("newstk_recvrht_tp", rightsType);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetAllMarketQuoteForRightsOfferings>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetDailyInstitutionTradingStock>> GetDailyInstitutionTradingStockAsync(KiwoomMarketConditionMarketType marketType, KiwoomMarketConditionNetTradeType tradeType, KiwoomMarketConditionStockExchangeType stockExchangeType, DateTime startDate, DateTime endDate)
		{
			const string apiId = "ka10044";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("trde_tp", tradeType)
				.AddField("stex_tp", stockExchangeType)
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetDailyInstitutionTradingStock>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetStockOriginTradeTrend>> GetStockOriginTradeTrendAsync(string stockCode, DateTime startDate, DateTime endDate, KiwoomMarketConditionEstimatedUnitPriceType institutionEstimatedUnitPriceType, KiwoomMarketConditionEstimatedUnitPriceType foreignEstimatedUnitPriceType)
		{
			const string apiId = "ka10045";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate)
				.AddField("orgn_prsm_unp_tp", institutionEstimatedUnitPriceType)
				.AddField("for_prsm_unp_tp", foreignEstimatedUnitPriceType);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetStockOriginTradeTrend>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetContractStrengthByTime>> GetContractStrengthByTimeAsync(string stockCode)
		{
			const string apiId = "ka10046";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetContractStrengthByTime>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetContractStrengthByDate>> GetContractStrengthByDateAsync(string stockCode)
		{
			const string apiId = "ka10047";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetContractStrengthByDate>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetIntradayInvestorTrading>> GetIntradayInvestorTradingAsync(KiwoomMarketConditionMarketType marketType, KiwoomMarketConditionAmountQuantityType amountQuantityType, KiwoomMarketConditionInvestorType investorType, bool isForeignAll, bool isSimultaneousNetPurchaseType, KiwoomMarketConditionStockExchangeType stockExchangeType)
		{
			const string apiId = "ka10063";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("amt_qty_tp", amountQuantityType)
				.AddField("invsr", investorType)
				.AddField("frgn_all", isForeignAll)
				.AddField("smtm_netprps_tp", isSimultaneousNetPurchaseType)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetIntradayInvestorTrading>(_endpoint, apiId, body).ConfigureAwait(false);
		}
	}
}
