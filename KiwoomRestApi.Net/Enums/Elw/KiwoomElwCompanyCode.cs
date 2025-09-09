using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.Elw
{
	/// <summary>
	/// 발행사코드
	/// </summary>
	public enum KiwoomElwCompanyCode
	{
		/// <summary>
		/// 전체
		/// </summary>
		[EnumMember(Value = "000000000000")]
		All = 0,
		/// <summary>
		/// 교보
		/// </summary>
		Kyobo = 1,
		/// <summary>
		/// 신한금융투자
		/// </summary>
		ShinhanInvestment = 2,
		/// <summary>
		/// 한국투자증권
		/// </summary>
		KoreaInvestment = 3,
		/// <summary>
		/// 대신
		/// </summary>
		Daishin = 4,
		/// <summary>
		/// 미래대우
		/// </summary>
		MiraeAsset = 5,
		/// <summary>
		/// 신영
		/// </summary>
		ShinYoung = 6,
		/// <summary>
		/// NK투자증권
		/// </summary>
		NkInvestment = 12,
		/// <summary>
		/// KB증권
		/// </summary>
		KbInvestment = 17
	}
}
