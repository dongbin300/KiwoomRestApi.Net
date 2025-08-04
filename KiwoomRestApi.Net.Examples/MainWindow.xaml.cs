using KiwoomRestApi.Net.Clients;

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

			var appKey = File.ReadAllText("D:\\Assets\\kiwoom_appkey.txt");
			var secretKey = File.ReadAllText("D:\\Assets\\kiwoom_secretkey.txt");

			var client = new KiwoomRestApiClient(appKey, secretKey);

			var a = client.OAuth.GetAccessToken().Result;
			var token = a.Data?.Token ?? string.Empty;
			var b = client.OAuth.RevokeAccessToken(token).Result;
		}
	}
}