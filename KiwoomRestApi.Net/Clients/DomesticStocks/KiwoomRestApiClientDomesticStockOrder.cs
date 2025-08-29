using KiwoomRestApi.Net.Enums.Order;
using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models;

using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.DomesticStocks
{
	/// <summary>
	/// 주문 API 클라이언트
	/// </summary>
	/// <param name="client"></param>
	public class KiwoomRestApiClientDomesticStockOrder(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = ApiEndpoint.DomesticStock.Order;

		/// <summary>
		/// KiwoomOrderType.Buy | kt10000 | 주식 매수주문<br/>
		/// KiwoomOrderType.Sell | kt10001 | 주식 매도주문
		/// </summary>
		/// <param name="orderType"></param>
		/// <param name="domesticStockExchangeType"></param>
		/// <param name="stockCode"></param>
		/// <param name="orderQuantity"></param>
		/// <param name="tradeType"></param>
		/// <param name="orderPrice"></param>
		/// <param name="conditionPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomOrderPlaceOrder>> PlaceOrderAsync(KiwoomOrderType orderType, KiwoomOrderDomesticStockExchangeType domesticStockExchangeType, string stockCode, decimal orderQuantity, KiwoomOrderTradeType tradeType, decimal? orderPrice = null, decimal? conditionPrice = null, CancellationToken cancellationToken = default)
		{
			string apiId = orderType == KiwoomOrderType.Buy ? "kt10000" : "kt10001";
			var body = new HttpParameterMap()
				.AddField("dmst_stex_tp", domesticStockExchangeType)
				.AddField("stk_cd", stockCode)
				.AddField("ord_qty", orderQuantity)
				.AddField("trde_tp", tradeType)
				.AddField("ord_uv", orderPrice)
				.AddField("cond_uv", conditionPrice);

			return await _client.PostKiwoomRestApiAsync<KiwoomOrderPlaceOrder>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | kt10002 | 주식 정정주문
		/// </summary>
		/// <param name="domesticStockExchangeType"></param>
		/// <param name="originalOrderId"></param>
		/// <param name="stockCode"></param>
		/// <param name="modifyQuantity"></param>
		/// <param name="modifyPrice"></param>
		/// <param name="modifyConditionPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomOrderModifyOrder>> ModifyOrderAsync(KiwoomOrderDomesticStockExchangeType domesticStockExchangeType, string originalOrderId, string stockCode, decimal modifyQuantity, decimal modifyPrice, decimal? modifyConditionPrice = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "kt10002";
			var body = new HttpParameterMap()
				.AddField("dmst_stex_tp", domesticStockExchangeType)
				.AddField("orig_ord_no", originalOrderId)
				.AddField("stk_cd", stockCode)
				.AddField("mdfy_qty", modifyQuantity)
				.AddField("mdfy_uv", modifyPrice)
				.AddField("mdfy_cond_uv", modifyConditionPrice);

			return await _client.PostKiwoomRestApiAsync<KiwoomOrderModifyOrder>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | kt10003 | 주식 취소주문
		/// </summary>
		/// <param name="domesticStockExchangeType"></param>
		/// <param name="originalOrderId"></param>
		/// <param name="stockCode"></param>
		/// <param name="cancelQuantity"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomOrderCancelOrder>> CancelOrderAsync(KiwoomOrderDomesticStockExchangeType domesticStockExchangeType, string originalOrderId, string stockCode, decimal? cancelQuantity = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "kt10003";

			// 취소수량 입력하지 않으면 잔량 전부 취소
			var _cancelQuantity = cancelQuantity ?? 0;

			var body = new HttpParameterMap()
				.AddField("dmst_stex_tp", domesticStockExchangeType)
				.AddField("orig_ord_no", originalOrderId)
				.AddField("stk_cd", stockCode)
				.AddField("cncl_qty", _cancelQuantity);

			return await _client.PostKiwoomRestApiAsync<KiwoomOrderCancelOrder>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}
	}
}
