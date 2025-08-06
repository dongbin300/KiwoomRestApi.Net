using KiwoomRestApi.Net.Clients;
using KiwoomRestApi.Net.Enums;

using System.IO;
using System.Windows;

namespace KiwoomRestApi.Net.Examples
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			var appKey = File.ReadAllText("D:\\Assets\\kiwoom_appkey_mock.txt");
			var secretKey = File.ReadAllText("D:\\Assets\\kiwoom_secretkey_mock.txt");
			//var token = File.ReadAllText("D:\\Assets\\kiwoom_token.txt");

			var client = KiwoomRestApiClient.Create(appKey, secretKey, true);
			var startDate = new DateTime(2025, 8, 1);
			var endDate = new DateTime(2025, 8, 6);
			var stockCode = "452400";

			var __result__ = client.ForeignInstitution.GetContinuousTradesAsync(KiwoomQueryTypePeriod.FiveDays, KiwoomStockExchangeType2.Unified, KiwoomMarketType2.KOSPI, KiwoomNetSellAmountType.NetBuy, KiwoomStockIndustryType.Stock, KiwoomAmountQuantityType.Amount).Result;

		}
	}
}