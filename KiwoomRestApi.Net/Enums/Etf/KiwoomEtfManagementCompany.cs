using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.Etf
{
	/// <summary>
	/// 운용사
	/// </summary>
	public enum KiwoomEtfManagementCompany
	{
		/// <summary>
		/// 전체
		/// </summary>
		[EnumMember(Value = "0000")]
		All = 0,
		/// <summary>
		/// KODEX (삼성)
		/// </summary>
		KODEX_Samsung = 3020,
		/// <summary>
		/// KOSEF (키움)
		/// </summary>
		KOSEF_Kiwoom = 3027,
		/// <summary>
		/// TIGER (미래에셋)
		/// </summary>
		TIGER_MiraeAsset = 3191,
		/// <summary>
		/// KINDEX (한국투자)
		/// </summary>
		KINDEX_KoreaInvestment = 3228,
		/// <summary>
		/// KStar (KB)
		/// </summary>
		KStar_KB = 3023,
		/// <summary>
		/// 아리랑 (한화)
		/// </summary>
		Arirang_Hanwha = 3022,
		/// <summary>
		/// 기타운용사
		/// </summary>
		Other = 9999
	}
}
