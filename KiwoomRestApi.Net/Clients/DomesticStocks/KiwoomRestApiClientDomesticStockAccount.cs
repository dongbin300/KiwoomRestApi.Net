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
	}
}
