using KiwoomRestApi.Net.Enums.UsStock.Order;
using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models.UsStock;

using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.UsStocks
{
	/// <summary>
	/// 미국주식 주문 API 클라이언트
	/// 현재 5개
	/// </summary>
	/// <param name="client"></param>
	public class KiwoomRestApiClientUsStockOrder(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = ApiEndpoint.UsStock.Order;

		/// <summary>
		/// 미국주식 가격 필드는 소수점(센트)을 포함하므로 공용 포매터의 F0 변환을 피하기 위해
		/// 소수점을 보존한 문자열로 직접 변환합니다. null은 그대로 전달합니다.
		/// </summary>
		private static string? FormatPrice(decimal? value) => value?.ToString(CultureInfo.InvariantCulture);

		/// <summary>
		/// | ust20000 | 미국주식 매수주문
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="orderQuantity">주문수량</param>
		/// <param name="transactionType">해외매매구분</param>
		/// <param name="orderPrice">주문단가 (지정가 계열 매매구분 시 필수)</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockOrderBuyOrder>> BuyOrderAsync(KiwoomUsStockOrderExchangeType exchangeType, string stockCode, decimal orderQuantity, KiwoomUsStockOrderTransactionType transactionType, decimal? orderPrice = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ust20000";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cd", stockCode)
				.AddField("ord_qty", orderQuantity)
				.AddField("ord_uv", FormatPrice(orderPrice))
				.AddField("trde_tp", transactionType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockOrderBuyOrder>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ust20001 | 미국주식 매도주문
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="orderQuantity">주문수량</param>
		/// <param name="transactionType">매매구분</param>
		/// <param name="orderPrice">주문단가 (지정가 계열 매매구분 시 필수)</param>
		/// <param name="stopPrice">STOP가격 (STOP, STOP LIMIT 매매구분 시 필수)</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockOrderSellOrder>> SellOrderAsync(KiwoomUsStockOrderExchangeType exchangeType, string stockCode, decimal orderQuantity, KiwoomUsStockOrderTransactionType transactionType, decimal? orderPrice = null, decimal? stopPrice = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ust20001";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("stex_tp", exchangeType)
				.AddField("ord_qty", orderQuantity)
				.AddField("ord_uv", FormatPrice(orderPrice))
				.AddField("stop_pric", FormatPrice(stopPrice))
				.AddField("trde_tp", transactionType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockOrderSellOrder>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ust20002 | 미국주식 정정주문
		/// </summary>
		/// <param name="originalOrderId">원주문번호</param>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="modifyPrice">정정단가</param>
		/// <param name="stopPrice">STOP가격</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockOrderModifyOrder>> ModifyOrderAsync(string originalOrderId, KiwoomUsStockOrderExchangeType exchangeType, string stockCode, decimal? modifyPrice = null, decimal? stopPrice = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ust20002";
			var body = new HttpParameterMap()
				.AddField("orig_ord_no", originalOrderId)
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cd", stockCode)
				.AddField("mdfy_uv", FormatPrice(modifyPrice))
				.AddField("stop_pric", FormatPrice(stopPrice));

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockOrderModifyOrder>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ust20003 | 미국주식 취소주문
		/// </summary>
		/// <param name="originalOrderId">원주문번호</param>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockOrderCancelOrder>> CancelOrderAsync(string originalOrderId, KiwoomUsStockOrderExchangeType exchangeType, string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ust20003";
			var body = new HttpParameterMap()
				.AddField("orig_ord_no", originalOrderId)
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockOrderCancelOrder>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ust31490 | 미국주식 증거금율별 주문가능수량 조회
		/// </summary>
		/// <param name="stockCode">종목코드</param>
		/// <param name="buyPrice">매수가격</param>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockOrderAvailableQuantity>> GetAvailableOrderQuantityAsync(string stockCode, decimal buyPrice, KiwoomUsStockOrderExchangeType? exchangeType = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ust31490";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cd", stockCode)
				.AddField("uv", FormatPrice(buyPrice));

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockOrderAvailableQuantity>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}
	}
}
