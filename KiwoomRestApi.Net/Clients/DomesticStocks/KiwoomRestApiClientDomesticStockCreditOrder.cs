using KiwoomRestApi.Net.Enums.CreditOrder;
using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models;

using System;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.DomesticStocks
{
	public class KiwoomRestApiClientDomesticStockCreditOrder(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = ApiEndpoint.DomesticStock.CreditOrder;

		public async Task<KiwoomRestApiResponse<KiwoomCreditOrderGetCreditOrder>> GetCreditOrderBuyAsync(KiwoomCreditOrderDomesticStockExchangeType domesticStockExchangeType, string stockCode, decimal orderQuantity, KiwoomCreditOrderTradeType tradeType, decimal? orderPrice = null, decimal? conditionPrice = null)
		{
			const string apiId = "kt10006";
			var body = new HttpParameterMap()
				.AddField("dmst_stex_tp", domesticStockExchangeType)
				.AddField("stk_cd", stockCode)
				.AddField("ord_qty", orderQuantity)
				.AddField("ord_uv", orderPrice)
				.AddField("trde_tp", tradeType)
				.AddField("cond_uv", conditionPrice);

			return await _client.PostKiwoomRestApiAsync<KiwoomCreditOrderGetCreditOrder>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomCreditOrderGetCreditOrder>> GetCreditOrderSellAsync(KiwoomCreditOrderDomesticStockExchangeType domesticStockExchangeType, string stockCode, decimal orderQuantity, KiwoomCreditOrderTradeType tradeType, KiwoomCreditOrderDealType dealType, decimal? orderPrice = null, decimal? conditionPrice = null, DateTime? loanDate = null)
		{
			const string apiId = "kt10007";
			var body = new HttpParameterMap()
				.AddField("dmst_stex_tp", domesticStockExchangeType)
				.AddField("stk_cd", stockCode)
				.AddField("ord_qty", orderQuantity)
				.AddField("ord_uv", orderPrice)
				.AddField("trde_tp", tradeType)
				.AddField("cond_uv", conditionPrice)
				.AddField("crd_deal_tp", dealType)
				.AddField("crd_loan_dt", loanDate);

			return await _client.PostKiwoomRestApiAsync<KiwoomCreditOrderGetCreditOrder>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomCreditOrderGetCreditOrderModification>> GetCreditOrderModificationAsync(KiwoomCreditOrderDomesticStockExchangeType domesticStockExchangeType, string originalOrderId, string stockCode, decimal modifyQuantity, decimal modifyPrice, decimal? modifyConditionPrice = null)
		{
			const string apiId = "kt10008";
			var body = new HttpParameterMap()
				.AddField("dmst_stex_tp", domesticStockExchangeType)
				.AddField("orig_ord_no", originalOrderId)
				.AddField("stk_cd", stockCode)
				.AddField("mdfy_qty", modifyQuantity)
				.AddField("mdfy_uv", modifyPrice)
				.AddField("mdfy_cond_uv", modifyConditionPrice);

			return await _client.PostKiwoomRestApiAsync<KiwoomCreditOrderGetCreditOrderModification>(_endpoint, apiId, body).ConfigureAwait(false);
		}

		public async Task<KiwoomRestApiResponse<KiwoomCreditOrderGetCreditOrderCancellation>> GetCreditOrderCancellationAsync(KiwoomCreditOrderDomesticStockExchangeType domesticStockExchangeType, string originalOrderId, string stockCode, decimal cancelQuantity)
		{
			const string apiId = "kt10009";
			var body = new HttpParameterMap()
				.AddField("dmst_stex_tp", domesticStockExchangeType)
				.AddField("orig_ord_no", originalOrderId)
				.AddField("stk_cd", stockCode)
				.AddField("cncl_qty", cancelQuantity);

			return await _client.PostKiwoomRestApiAsync<KiwoomCreditOrderGetCreditOrderCancellation>(_endpoint, apiId, body).ConfigureAwait(false);
		}
	}
}
