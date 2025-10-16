using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums
{
    public enum KiwoomGoldSpotStockCode
    {
        /// <summary>
        /// 금 99.99% 순도 1kg
        /// </summary>
		[EnumMember(Value = "M04020000")]
        Gold_1kg,
        /// <summary>
        /// 미니금 99.99% 순도 100g
        /// </summary>
		[EnumMember(Value = "M04020100")]
        MiniGold_100g
    }
}
