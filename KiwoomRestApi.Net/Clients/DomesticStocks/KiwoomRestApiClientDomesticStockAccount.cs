using KiwoomRestApi.Net.Enums.Account;
using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models;

using System;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.DomesticStocks
{
	public class KiwoomRestApiClientDomesticStockAccount(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = ApiEndpoint.DomesticStock.Account;

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetDateStockRealizedProfitLoss>> GetDateStockRealizedProfitLossAsync(string stockCode, DateTime startDate)
		{
			const string apiId = "ka10072";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("strt_dt", startDate);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetDateStockRealizedProfitLoss>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetPeriodStockRealizedProfitLoss>> GetPeriodStockRealizedProfitLossAsync(string stockCode, DateTime startDate, DateTime endDate)
		{
			const string apiId = "ka10073";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetPeriodStockRealizedProfitLoss>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetRealizedProfitLoss>> GetRealizedProfitLossAsync(DateTime startDate, DateTime endDate)
		{
			const string apiId = "ka10074";
			var body = new HttpParameterMap()
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetRealizedProfitLoss>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetOutstandingOrders>> GetOutstandingOrdersAsync(KiwoomAccountQueryType queryType, KiwoomAccountTradeType tradeType, KiwoomAccountStockExchangeType stockExchangeType, string stockCode = "")
		{
			const string apiId = "ka10075";
			var body = new HttpParameterMap()
				.AddField("all_stk_tp", queryType)
				.AddField("trde_tp", tradeType)
				.AddField("stex_tp", stockExchangeType)
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetOutstandingOrders>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetContracts>> GetContractsAsync(KiwoomAccountQueryType queryType, KiwoomAccountTradeType tradeType, KiwoomAccountStockExchangeType stockExchangeType, string stockCode = "", string orderId = "")
		{
			const string apiId = "ka10076";
			var body = new HttpParameterMap()
				.AddField("qry_tp", queryType)
				.AddField("sell_tp", tradeType)
				.AddField("stex_tp", stockExchangeType)
				.AddField("stk_cd", stockCode)
				.AddField("ord_no", orderId);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetContracts>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetTodayRealizedProfitLoss>> GetTodayRealizedProfitLossAsync(string stockCode)
		{
			const string apiId = "ka10077";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetTodayRealizedProfitLoss>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetProfitRate>> GetProfitRateAsync(KiwoomAccountStockExchangeType stockExchangeType)
		{
			const string apiId = "ka10085";
			var body = new HttpParameterMap()
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetProfitRate>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetOutstandingPartialOrders>> GetOutstandingPartialOrdersAsync(string orderId)
		{
			const string apiId = "ka10088";
			var body = new HttpParameterMap()
				.AddField("ord_no", orderId);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetOutstandingPartialOrders>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetTodayTradeDiaries>> GetTodayTradeDiariesAsync(KiwoomAccountOddLotType oddLotType, KiwoomAccountCashCreditType cashCreditType, DateTime? date = null)
		{
			const string apiId = "ka10170";
			var body = new HttpParameterMap()
				.AddField("ottks_tp", oddLotType)
				.AddField("ch_crd_tp", cashCreditType)
				.AddField("base_dt", date);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetTodayTradeDiaries>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetDeposits>> GetDepositsAsync(KiwoomAccountDepositQueryType queryType)
		{
			const string apiId = "kt00001";
			var body = new HttpParameterMap()
				.AddField("qry_tp", queryType);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetDeposits>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetDailyEstimatedDepositAssets>> GetDailyEstimatedDepositAssetsAsync(DateTime startDate, DateTime endDate)
		{
			const string apiId = "kt00002";
			var body = new HttpParameterMap()
				.AddField("start_dt", startDate)
				.AddField("end_dt", endDate);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetDailyEstimatedDepositAssets>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetEstimatedDepositAsset>> GetEstimatedDepositAssetAsync(KiwoomAccountDelistingQueryType queryType)
		{
			const string apiId = "kt00003";
			var body = new HttpParameterMap()
				.AddField("qry_tp", queryType);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetEstimatedDepositAsset>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetEvaluations>> GetEvaluationsAsync(KiwoomAccountDelistingQueryType queryType, KiwoomAccountStockExchangeType stockExchangeType)
		{
			const string apiId = "kt00004";
			var body = new HttpParameterMap()
				.AddField("qry_tp", queryType)
				.AddField("dmst_stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetEvaluations>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetContractBalances>> GetContractBalancesAsync(KiwoomAccountStockExchangeType stockExchangeType)
		{
			const string apiId = "kt00005";
			var body = new HttpParameterMap()
				.AddField("dmst_stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetContractBalances>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetOrderContractDetails>> GetOrderContractDetailsAsync(KiwoomAccountOrderQueryType queryType, KiwoomAccountStockBondType stockBondType, KiwoomAccountTradeType tradeType, KiwoomAccountDomesticStockExchangeType domesticStockExchangeType, DateTime? date = null, string stockCode = "", string fromOrderId = "")
		{
			const string apiId = "kt00007";
			var body = new HttpParameterMap()
				.AddField("qry_tp", queryType)
				.AddField("stk_bond_tp", stockBondType)
				.AddField("sell_tp", tradeType)
				.AddField("dmst_stex_tp", domesticStockExchangeType)
				.AddField("ord_dt", date)
				.AddField("stk_cd", stockCode)
				.AddField("fr_ord_no", fromOrderId);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetOrderContractDetails>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetNextDaySettlements>> GetNextDaySettlementsAsync(string startDealCodeId = "")
		{
			const string apiId = "kt00008";
			var body = new HttpParameterMap()
				.AddField("strt_dcd_seq", startDealCodeId);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetNextDaySettlements>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetOrderContracts>> GetOrderContractsAsync(KiwoomAccountOrderContractQueryType queryType, KiwoomAccountStockBondType stockBondType, KiwoomAccountTradeType tradeType, KiwoomAccountDomesticStockExchangeType domesticStockExchangeType, KiwoomAccountMarketType marketType, DateTime? date = null, string stockCode = "", string fromOrderId = "")
		{
			const string apiId = "kt00009";
			var body = new HttpParameterMap()
				.AddField("qry_tp", queryType)
				.AddField("stk_bond_tp", stockBondType)
				.AddField("sell_tp", tradeType)
				.AddField("dmst_stex_tp", domesticStockExchangeType)
				.AddField("mrkt_tp", marketType)
				.AddField("ord_dt", date)
				.AddField("stk_cd", stockCode)
				.AddField("fr_ord_no", fromOrderId);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetOrderContracts>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetMarginOrderAmounts>> GetMarginOrderAmountsAsync(string stockCode, KiwoomAccountTradeType tradeType, decimal buyPrice, decimal? buyQuantity = null, decimal? inOutAmount = null, decimal? expectedBuyPrice = null)
		{
			const string apiId = "kt00010";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("trde_tp", tradeType)
				.AddField("uv", buyPrice)
				.AddField("trde_qty", buyQuantity)
				.AddField("io_amt", inOutAmount)
				.AddField("exp_buy_unp", expectedBuyPrice);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetMarginOrderAmounts>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetMarginOrders>> GetMarginOrdersAsync(string stockCode, decimal? buyPrice = null)
		{
			const string apiId = "kt00011";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("uv", buyPrice);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetMarginOrders>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetAssuranceMarginOrders>> GetAssuranceMarginOrdersAsync(string stockCode, decimal? buyPrice = null)
		{
			const string apiId = "kt00012";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("uv", buyPrice);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetAssuranceMarginOrders>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetMarginDetails>> GetMarginDetailsAsync()
		{
			const string apiId = "kt00013";
			var body = new HttpParameterMap();

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetMarginDetails>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetConsignmentTrades>> GetConsignmentTradesAsync(KiwoomAccountTransactionType transactionType, KiwoomAccountGoodsType goodsType, KiwoomAccountDomesticStockExchangeType domesticStockExchangeType, DateTime startDate, DateTime endDate, string stockCode = "", string currencyCode = "", string foreignStockExchangeCode = "")
		{
			const string apiId = "kt00015";
			var body = new HttpParameterMap()
				.AddField("tp", transactionType)
				.AddField("gds_tp", goodsType)
				.AddField("dmst_stex_tp", domesticStockExchangeType)
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate)
				.AddField("stk_cd", stockCode)
				.AddField("crnc_cd", currencyCode)
				.AddField("frgn_stex_code", foreignStockExchangeCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetConsignmentTrades>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetDailyProfitRateDetails>> GetDailyProfitRateDetailsAsync(DateTime startDate, DateTime endDate)
		{
			const string apiId = "kt00016";
			var body = new HttpParameterMap()
				.AddField("fr_dt", startDate)
				.AddField("to_dt", endDate);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetDailyProfitRateDetails>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetDailyStatus>> GetDailyStatusAsync()
		{
			const string apiId = "kt00017";
			var body = new HttpParameterMap();

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetDailyStatus>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetEvaluationBalances>> GetEvaluationBalancesAsync(KiwoomAccountEvaluationBalanceQueryType queryType, KiwoomAccountDomesticStockExchangeType domesticStockExchangeType)
		{
			const string apiId = "kt00018";
			var body = new HttpParameterMap()
				.AddField("qry_tp", queryType)
				.AddField("dmst_stex_tp", domesticStockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetEvaluationBalances>(_endpoint, apiId, body).ConfigureAwait(false);
		}
	}
}
