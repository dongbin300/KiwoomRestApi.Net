using KiwoomRestApi.Net.Enums.MarketCondition;
using KiwoomRestApi.Net.Objects.Commons;
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

		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetQuoteList>> GetQuoteListAsync(string stockCode)
		{
			const string apiId = "ka10007";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			var response = await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetQuote>(_endpoint, apiId, body).ConfigureAwait(false);
			return response.MapResponse(r => new KiwoomMarketConditionGetQuoteList(r));
		}

		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetAllMarketQuoteForRightsOfferings>> GetAllMarketQuoteForRightsOfferingsAsync(KiwoomMarketConditionRightsType rightsType)
		{
			const string apiId = "ka10011";
			var body = new HttpParameterMap()
				.AddField("newstk_recvrht_tp", rightsType);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetAllMarketQuoteForRightsOfferings>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetDailyInstitutionTradingStocks>> GetDailyInstitutionTradingStocksAsync(KiwoomMarketConditionMarketType marketType, KiwoomMarketConditionNetTradeType tradeType, KiwoomMarketConditionStockExchangeType stockExchangeType, DateTime startDate, DateTime endDate)
		{
			const string apiId = "ka10044";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("trde_tp", tradeType)
				.AddField("stex_tp", stockExchangeType)
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetDailyInstitutionTradingStocks>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetStockOriginTradeTrends>> GetStockOriginTradeTrendsAsync(string stockCode, DateTime startDate, DateTime endDate, KiwoomMarketConditionEstimatedUnitPriceType institutionEstimatedUnitPriceType, KiwoomMarketConditionEstimatedUnitPriceType foreignEstimatedUnitPriceType)
		{
			const string apiId = "ka10045";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate)
				.AddField("orgn_prsm_unp_tp", institutionEstimatedUnitPriceType)
				.AddField("for_prsm_unp_tp", foreignEstimatedUnitPriceType);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetStockOriginTradeTrends>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetHourlyContractStrengths>> GetHourlyContractStrengthsAsync(string stockCode)
		{
			const string apiId = "ka10046";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetHourlyContractStrengths>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetDailyContractStrengths>> GetDailyContractStrengthsAsync(string stockCode)
		{
			const string apiId = "ka10047";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetDailyContractStrengths>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetIntradayInvestorTradings>> GetIntradayInvestorTradingsAsync(KiwoomMarketConditionMarketType marketType, KiwoomMarketConditionAmountQuantityType amountQuantityType, KiwoomMarketConditionInvestorType investorType, bool isForeignAll, bool isSimultaneousNetPurchaseType, KiwoomMarketConditionStockExchangeType stockExchangeType)
		{
			const string apiId = "ka10063";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("amt_qty_tp", amountQuantityType)
				.AddField("invsr", investorType)
				.AddField("frgn_all", isForeignAll)
				.AddField("smtm_netprps_tp", isSimultaneousNetPurchaseType)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetIntradayInvestorTradings>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetIntradayInvestorTradeCharts>> GetIntradayInvestorTradeChartsAsync(KiwoomMarketConditionMarketType marketType, KiwoomMarketConditionAmountQuantityType amountQuantityType, KiwoomMarketConditionTradeType tradeType, KiwoomMarketConditionStockExchangeType stockExchangeType)
		{
			const string apiId = "ka10066";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("amt_qty_tp", amountQuantityType)
				.AddField("trde_tp", tradeType)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetIntradayInvestorTradeCharts>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetSecurityFirmStockTradeTrends>> GetSecurityFirmStockTradeTrendsAsync(string memberCompanyCode, string stockCode, DateTime startDate, DateTime endDate)
		{
			const string apiId = "ka10078";
			var body = new HttpParameterMap()
				.AddField("mmcm_cd", memberCompanyCode)
				.AddField("stk_cd", stockCode)
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetSecurityFirmStockTradeTrends>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetDailyStockPrices>> GetDailyStockPricesAsync(string stockCode, DateTime date, KiwoomMarketConditionAmountQuantityType2 amountQuantityType)
		{
			const string apiId = "ka10086";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("qry_dt", date)
				.AddField("indc_tp", amountQuantityType);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetDailyStockPrices>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetAfterHoursSinglePriceOrderBook>> GetAfterHoursSinglePriceOrderBookAsync(string stockCode)
		{
			const string apiId = "ka10087";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetAfterHoursSinglePriceOrderBook>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetAfterHoursSinglePriceOrderBookList>> GetAfterHoursSinglePriceOrderBookListAsync(string stockCode)
		{
			const string apiId = "ka10087";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			var response = await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetAfterHoursSinglePriceOrderBook>(_endpoint, apiId, body).ConfigureAwait(false);
			return response.MapResponse(r => new KiwoomMarketConditionGetAfterHoursSinglePriceOrderBookList(r));
		}

		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetHourlyProgramTradeTrends>> GetHourlyProgramTradeTrendsAsync(DateTime date, KiwoomMarketConditionAmountQuantityType3 amountQuantityType, KiwoomMarketConditionMarketType marketType, KiwoomMarketConditionTicMinuteType ticMinuteType, KiwoomMarketConditionStockExchangeType stockExchangeType)
		{
			const string apiId = "ka90005";
			string _marketType = (marketType, stockExchangeType) switch
			{
				(KiwoomMarketConditionMarketType.KOSPI, KiwoomMarketConditionStockExchangeType.KRX) => "P00101",
				(KiwoomMarketConditionMarketType.KOSPI, KiwoomMarketConditionStockExchangeType.NXT) => "P001_NX01",
				(KiwoomMarketConditionMarketType.KOSPI, _) => "P001_AL01",

				(KiwoomMarketConditionMarketType.KOSDAQ, KiwoomMarketConditionStockExchangeType.KRX) => "P10102",
				(KiwoomMarketConditionMarketType.KOSDAQ, KiwoomMarketConditionStockExchangeType.NXT) => "P101_NX02",
				(KiwoomMarketConditionMarketType.KOSDAQ, _) => "P101_AL02",

				_ => string.Empty
			};
			var body = new HttpParameterMap()
				.AddField("date", date)
				.AddField("amt_qty_tp", amountQuantityType)
				.AddField("mrkt_tp", _marketType)
				.AddField("min_tic_tp", ticMinuteType)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetHourlyProgramTradeTrends>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetProgramArbitrageBalanceTrends>> GetProgramArbitrageBalanceTrendsAsync(DateTime date, KiwoomMarketConditionStockExchangeType stockExchangeType)
		{
			const string apiId = "ka90006";
			var body = new HttpParameterMap()
				.AddField("date", date)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetProgramArbitrageBalanceTrends>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetProgramTradeAccumulatedTrends>> GetProgramTradeAccumulatedTrendsAsync(DateTime date, KiwoomMarketConditionAmountQuantityType amountQuantityType, KiwoomMarketConditionMarketType2 marketType, KiwoomMarketConditionStockExchangeType stockExchangeType)
		{
			const string apiId = "ka90007";
			var body = new HttpParameterMap()
				.AddField("date", date)
				.AddField("amt_qty_tp", amountQuantityType)
				.AddField("mrkt_tp", marketType)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetProgramTradeAccumulatedTrends>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetStockTimeProgramTradeTrends>> GetStockTimeProgramTradeTrendsAsync(DateTime date, string stockCode, KiwoomMarketConditionAmountQuantityType amountQuantityType)
		{
			const string apiId = "ka90008";
			var body = new HttpParameterMap()
				.AddField("date", date)
				.AddField("stk_cd", stockCode)
				.AddField("amt_qty_tp", amountQuantityType);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetStockTimeProgramTradeTrends>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetDailyProgramTradeTrends>> GetDailyProgramTradeTrendsAsync(DateTime date, KiwoomMarketConditionAmountQuantityType3 amountQuantityType, KiwoomMarketConditionMarketType marketType, KiwoomMarketConditionTicMinuteType ticMinuteType, KiwoomMarketConditionStockExchangeType stockExchangeType)
		{
			const string apiId = "ka90010";
			string _marketType = (marketType, stockExchangeType) switch
			{
				(KiwoomMarketConditionMarketType.KOSPI, KiwoomMarketConditionStockExchangeType.KRX) => "P00101",
				(KiwoomMarketConditionMarketType.KOSPI, KiwoomMarketConditionStockExchangeType.NXT) => "P001_NX01",
				(KiwoomMarketConditionMarketType.KOSPI, _) => "P001_AL01",

				(KiwoomMarketConditionMarketType.KOSDAQ, KiwoomMarketConditionStockExchangeType.KRX) => "P10102",
				(KiwoomMarketConditionMarketType.KOSDAQ, KiwoomMarketConditionStockExchangeType.NXT) => "P101_NX02",
				(KiwoomMarketConditionMarketType.KOSDAQ, _) => "P101_AL02",

				_ => string.Empty
			};
			var body = new HttpParameterMap()
				.AddField("date", date)
				.AddField("amt_qty_tp", amountQuantityType)
				.AddField("mrkt_tp", _marketType)
				.AddField("min_tic_tp", ticMinuteType)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetDailyProgramTradeTrends>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetStockDailyProgramTradeTrends>> GetStockDailyProgramTradeTrendsAsync(DateTime date, string stockCode, KiwoomMarketConditionAmountQuantityType amountQuantityType)
		{
			const string apiId = "ka90013";
			var body = new HttpParameterMap()
				.AddField("date", date)
				.AddField("stk_cd", stockCode)
				.AddField("amt_qty_tp", amountQuantityType);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetStockDailyProgramTradeTrends>(_endpoint, apiId, body).ConfigureAwait(false);
		}
	}
}
