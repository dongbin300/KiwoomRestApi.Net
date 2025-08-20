using KiwoomRestApi.Net.Clients;
using KiwoomRestApi.Net.Enums.RankingInfo;
using KiwoomRestApi.Net.Enums.ForeignInstitution;

using System.IO;
using System.Windows;
using KiwoomRestApi.Net.Objects;
using System.Diagnostics;
using Newtonsoft.Json;
using KiwoomRestApi.Net.Objects.Models;
using KiwoomRestApi.Net.Enums.WebSocket;

namespace KiwoomRestApi.Net.Examples
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		KiwoomSocketClient socketClient;

		public MainWindow()
		{
			InitializeComponent();

			var appKey = File.ReadAllText("D:\\Assets\\kiwoom_appkey_mock.txt");
			var secretKey = File.ReadAllText("D:\\Assets\\kiwoom_secretkey_mock.txt");
			//var token = File.ReadAllText("D:\\Assets\\kiwoom_token.txt");

			var client = KiwoomRestApiClient.Create(appKey, secretKey, true);
			var startDate = new DateTime(2025, 8, 1);
			var endDate = new DateTime(2025, 8, 7);
			var stockCode = "452400";

			//var __result__ = client.MarketCondition.GetQuoteListAsync(stockCode).Result;

			//socketClient = KiwoomSocketClient.Create(client.Token, true);

			//socketClient.OnConditionSearchRequestReceived += (message) =>
			//{

			//};
		}

		private async void Test_Click(object sender, RoutedEventArgs e)
		{
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