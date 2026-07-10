using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.UsStock.RankingInfo
{
	/// <summary>
	/// 서비스 유형
	/// </summary>
	public enum KiwoomUsStockRankingInfoServiceType
	{
		/// <summary>
		/// 30초
		/// </summary>
		[EnumMember(Value = "B286")]
		Seconds30,
		/// <summary>
		/// 1분
		/// </summary>
		[EnumMember(Value = "B281")]
		Minutes1,
		/// <summary>
		/// 10분
		/// </summary>
		[EnumMember(Value = "B282")]
		Minutes10,
		/// <summary>
		/// 1시간
		/// </summary>
		[EnumMember(Value = "B283")]
		Hours1,
		/// <summary>
		/// 당일
		/// </summary>
		[EnumMember(Value = "B284")]
		Today
	}
}
