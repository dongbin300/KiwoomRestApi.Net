using KiwoomRestApi.Net.Enums;
using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Models;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.DomesticStocks
{
	public class KiwoomRestApiClientDomesticStockAccount(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = "/api/dostk/acnt";

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetDateStockRealizedProfitLoss>> GetDateStockRealizedProfitLoss(string stockCode, DateTime startDate)
		{
			const string apiId = "ka10072";
			var bodies = new Dictionary<string, string>
			{
				["stk_cd"] = stockCode,
				["strt_dt"] = startDate.ToKiwoomDateString(),
			};

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetDateStockRealizedProfitLoss>(_endpoint, apiId, bodies).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetPeriodStockRealizedProfitLoss>> GetPeriodStockRealizedProfitLoss(string stockCode, DateTime startDate, DateTime endDate)
		{
			const string apiId = "ka10073";
			var bodies = new Dictionary<string, string>
			{
				["stk_cd"] = stockCode,
				["strt_dt"] = startDate.ToKiwoomDateString(),
				["end_dt"] = endDate.ToKiwoomDateString(),
			};

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetPeriodStockRealizedProfitLoss>(_endpoint, apiId, bodies).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetRealizedProfitLoss>> GetRealizedProfitLoss(DateTime startDate, DateTime endDate)
		{
			const string apiId = "ka10074";
			var bodies = new Dictionary<string, string>
			{
				["strt_dt"] = startDate.ToKiwoomDateString(),
				["end_dt"] = endDate.ToKiwoomDateString(),
			};

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetRealizedProfitLoss>(_endpoint, apiId, bodies).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetOutstandingOrders>> GetOutstandingOrders(KiwoomQueryType queryType, KiwoomTradeType tradeType, KiwoomStockExchangeType stockExchangeType, string stockCode = "")
		{
			const string apiId = "ka10075";
			var bodies = new Dictionary<string, string>
			{
				["all_stk_tp"] = queryType.ToCodeString(),
				["trde_tp"] = tradeType.ToCodeString(),
				["stex_tp"] = stockExchangeType.ToCodeString(),
				["stk_cd"] = stockCode
			};

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetOutstandingOrders>(_endpoint, apiId, bodies).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetContracts>> GetContracts(KiwoomQueryType queryType, KiwoomTradeType tradeType, KiwoomStockExchangeType stockExchangeType, string stockCode = "", string orderId = "")
		{
			const string apiId = "ka10076";
			var bodies = new Dictionary<string, string>
			{
				["qry_tp"] = queryType.ToCodeString(),
				["sell_tp"] = tradeType.ToCodeString(),
				["stex_tp"] = stockExchangeType.ToCodeString(),
				["stk_cd"] = stockCode,
				["ord_no"] = orderId
			};

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetContracts>(_endpoint, apiId, bodies).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetTodayRealizedProfitLoss>> GetTodayRealizedProfitLoss(string stockCode)
		{
			const string apiId = "ka10077";
			var bodies = new Dictionary<string, string>
			{
				["stk_cd"] = stockCode
			};

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetTodayRealizedProfitLoss>(_endpoint, apiId, bodies).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetProfitRate>> GetProfitRate(KiwoomStockExchangeType stockExchangeType)
		{
			const string apiId = "ka10085";
			var bodies = new Dictionary<string, string>
			{
				["stex_tp"] = stockExchangeType.ToCodeString()
			};

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetProfitRate>(_endpoint, apiId, bodies).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetOutstandingPartialOrders>> GetOutstandingPartialOrders(string orderId)
		{
			const string apiId = "ka10088";
			var bodies = new Dictionary<string, string>
			{
				["ord_no"] = orderId
			};

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetOutstandingPartialOrders>(_endpoint, apiId, bodies).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetTodayTradeDiaries>> GetTodayTradeDiaries(KiwoomOddLotType oddLotType, KiwoomCashCreditType cashCreditType, DateTime? date = null)
		{
			const string apiId = "ka10170";
			var bodies = new Dictionary<string, string>
			{
				["ottks_tp"] = oddLotType.ToCodeString(),
				["ch_crd_tp"] = cashCreditType.ToCodeString(),
				["base_dt"] = date.ToKiwoomDateString()

			};

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetTodayTradeDiaries>(_endpoint, apiId, bodies).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetDeposits>> GetDeposits(KiwoomDepositQueryType queryType)
		{
			const string apiId = "kt00001";
			var bodies = new Dictionary<string, string>
			{
				["qry_tp"] = queryType.ToCodeString()

			};

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetDeposits>(_endpoint, apiId, bodies).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetDailyEstimatedDepositAssets>> GetDailyEstimatedDepositAssets(DateTime startDate, DateTime endDate)
		{
			const string apiId = "kt00002";
			var bodies = new Dictionary<string, string>
			{
				["start_dt"] = startDate.ToKiwoomDateString(),
				["end_dt"] = endDate.ToKiwoomDateString()
			};

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetDailyEstimatedDepositAssets>(_endpoint, apiId, bodies).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetEstimatedDepositAsset>> GetEstimatedDepositAsset(KiwoomDelistingQueryType queryType)
		{
			const string apiId = "kt00003";
			var bodies = new Dictionary<string, string>
			{
				["qry_tp"] = queryType.ToCodeString()
			};

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetEstimatedDepositAsset>(_endpoint, apiId, bodies).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetEvaluations>> GetEvaluations(KiwoomDelistingQueryType queryType, KiwoomStockExchangeType stockExchangeType)
		{
			const string apiId = "kt00004";
			var bodies = new Dictionary<string, string>
			{
				["qry_tp"] = queryType.ToCodeString(),
				["dmst_stex_tp"] = stockExchangeType.ToCodeString()
			};

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetEvaluations>(_endpoint, apiId, bodies).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetContractBalances>> GetContractBalances(KiwoomStockExchangeType stockExchangeType)
		{
			const string apiId = "kt00005";
			var bodies = new Dictionary<string, string>
			{
				["dmst_stex_tp"] = stockExchangeType.ToCodeString()
			};

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetContractBalances>(_endpoint, apiId, bodies).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomAccountGetOrderContractDetails>> GetOrderContractDetails(KiwoomOrderQueryType orderQueryType, KiwoomStockBondType stockBondType, KiwoomTradeType tradeType, KiwoomDomesticStockExchangeType domesticStockExchangeType, DateTime? date = null, string stockCode = "", string fromOrderId = "")
		{
			const string apiId = "kt00007";
			var bodies = new Dictionary<string, string>
			{
				["qry_tp"] = orderQueryType.ToCodeString(),
				["stk_bond_tp"] = stockBondType.ToCodeString(),
				["sell_tp"] = tradeType.ToCodeString(),
				["dmst_stex_tp"] = domesticStockExchangeType.ToCodeString(),
				["ord_dt"] = date.ToKiwoomDateString(),
				["stk_cd"] = stockCode,
				["fr_ord_no"] = fromOrderId
			};

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetOrderContractDetails>(_endpoint, apiId, bodies).ConfigureAwait(false);
		}
	}
}
