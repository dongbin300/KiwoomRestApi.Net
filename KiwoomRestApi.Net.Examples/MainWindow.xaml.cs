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

			var client = new KiwoomRestApiClient(appKey, secretKey, true);

			var aa = client.Account.GetContracts(KiwoomQueryType.All, KiwoomTradeType.All, KiwoomStockExchangeType.Unified).Result;

			//var a = client.OAuth.GetAccessToken().Result;
			//var tokenValue = a.Data?.Token ?? string.Empty;
			//File.WriteAllText("D:\\Assets\\kiwoom_token.txt", tokenValue);
			//var b = client.OAuth.RevokeAccessToken(tokenValue).Result;
		}
	}
}