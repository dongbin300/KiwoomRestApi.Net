using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.UsStock.Exchange
{
	/// <summary>
	/// 환전구분
	/// </summary>
	public enum KiwoomUsStockExchangeType
	{
		/// <summary>
		/// 원화(KRW)-&gt;달러(USD)
		/// </summary>
		[EnumMember(Value = "1")]
		KrwToUsd,
		/// <summary>
		/// 달러(USD)-&gt;원화(KRW)
		/// </summary>
		[EnumMember(Value = "2")]
		UsdToKrw
	}
}
