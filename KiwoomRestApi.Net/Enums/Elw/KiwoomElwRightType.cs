using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.Elw
{
	public enum KiwoomElwRightType
	{
		/// <summary>
		/// 전체
		/// </summary>
		[EnumMember(Value = "000")]
		All,
		/// <summary>
		/// 콜
		/// </summary>
		[EnumMember(Value = "001")]
		Call,
		/// <summary>
		/// 풋
		/// </summary>
		[EnumMember(Value = "002")]
		Put,
		/// <summary>
		/// DC
		/// </summary>
		[EnumMember(Value = "003")]
		DC,
		/// <summary>
		/// DP
		/// </summary>
		[EnumMember(Value = "004")]
		DP,
		/// <summary>
		/// EX
		/// </summary>
		[EnumMember(Value = "005")]
		EX,
		/// <summary>
		/// 조기종료콜
		/// </summary>
		[EnumMember(Value = "006")]
		EarlyTerminationCall,
		/// <summary>
		/// 조기종료풋
		/// </summary>
		[EnumMember(Value = "007")]
		EarlyTerminationPut
	}

}
