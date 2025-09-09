using KiwoomRestApi.Net.Clients;
using KiwoomRestApi.Net.Enums.Chart;
using KiwoomRestApi.Net.Enums.StockInfo;
using KiwoomRestApi.Net.Enums.WebSocket;

using Newtonsoft.Json;
using System.IO;
using System.Windows;

namespace KiwoomRestApi.Net.Examples
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
		KiwoomSocketClient socketClient = default!;

		public MainWindow()
		{
			InitializeComponent();

			var appKey = File.ReadAllText("D:\\Assets\\kiwoom_appkey_mock.txt");
			var secretKey = File.ReadAllText("D:\\Assets\\kiwoom_secretkey_mock.txt");
			//var token = File.ReadAllText("D:\\Assets\\kiwoom_token.txt");

			var client = KiwoomRestApiClient.Create(appKey, secretKey, true);
			var startDate = new DateTime(2025, 8, 1);
			var endDate = new DateTime(2025, 8, 25);
			var stockCode = "005930";

			//var __result__ = client.Account.GetFilledOrdersAsync(Enums.Account.KiwoomAccountQueryType.All, Enums.Account.KiwoomAccountTransactionType.All, Enums.Account.KiwoomAccountStockExchangeType.Unified).Result;
			var __result__ = client.Account.GetUnfilledOrdersAsync(Enums.Account.KiwoomAccountQueryType.All, Enums.Account.KiwoomAccountTransactionType.All, Enums.Account.KiwoomAccountStockExchangeType.Unified).Result;

			//socketClient = KiwoomSocketClient.Create(client.Token, true);

			//socketClient.OnRealtimeOrderExecutionReceived += (message) =>
			//{

			//};

			//socketClient.OnRealtimeStockExecutionReceived += (message) =>
			//{

			//};

		}

		private async void Test_Click(object sender, RoutedEventArgs e)
		{
			//await socketClient.WebSocket.SubscribeAsync([KiwoomWebSocketServiceName.OrderExecution | KiwoomWebSocketServiceName.StockExecution], ["005930"]);
			//await socketClient.WebSocket.GetConditionSearchListAsync().ConfigureAwait(false);
			//await socketClient.WebSocket.GetConditionSearchRequestAsync(20).ConfigureAwait(false);
			//await socketClient.WebSocket.GetConditionSearchClearAsync(20).ConfigureAwait(false);
		}

		private async void Test2_Click(object sender, RoutedEventArgs e)
		{
			await socketClient.DisconnectAsync().ConfigureAwait(false);
		}

		private async void Test3_Click(object sender, RoutedEventArgs e)
		{

		}

		private async void Test4_Click(object sender, RoutedEventArgs e)
		{

		}
	}
}