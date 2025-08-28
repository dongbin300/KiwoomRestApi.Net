using KiwoomRestApi.Net.Clients;
using KiwoomRestApi.Net.Enums.Chart;
using KiwoomRestApi.Net.Enums.StockInfo;
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
        private KiwoomRestApiClient _kiwoomClient = default!;
        private KiwoomSocketClient? _socketClient;

        public MainWindow()
        {
            InitializeComponent();
            InitializeKiwoomClient();
        }

        private void InitializeKiwoomClient()
        {
            try
            {
                StatusText.Text = "Initializing KiwoomRestApiClient...";
                
                var appKey = File.ReadAllText("D:\\Assets\\kiwoom_appkey_mock.txt");
                var secretKey = File.ReadAllText("D:\\Assets\\kiwoom_secretkey_mock.txt");
                
                _kiwoomClient = KiwoomRestApiClient.Create(appKey, secretKey, isMock: true);
                
                StatusText.Text = $"✅ Ready! Token: {_kiwoomClient.Token.Substring(0, Math.Min(20, _kiwoomClient.Token.Length))}...";
                
                LogMessage("🚀 KiwoomRestApiClient initialized successfully!");
                LogMessage($"📝 Token: {_kiwoomClient.Token}");
                LogMessage($"🎯 Mock Mode: Enabled");
                LogMessage($"📊 Ready to test APIs!");
            }
            catch (Exception ex)
            {
                StatusText.Text = "❌ Failed to initialize";
                LogError("Failed to initialize KiwoomRestApiClient", ex);
            }
        }

        private void LogMessage(string message)
        {
            Dispatcher.Invoke(() =>
            {
                var timestamp = DateTime.Now.ToString("HH:mm:ss");
                ResultsTextBox.AppendText($"[{timestamp}] {message}\n");
                ResultsTextBox.ScrollToEnd();
            });
        }

        private void LogError(string message, Exception ex)
        {
            Dispatcher.Invoke(() =>
            {
                var timestamp = DateTime.Now.ToString("HH:mm:ss");
                ResultsTextBox.AppendText($"[{timestamp}] ❌ ERROR: {message}\n");
                ResultsTextBox.AppendText($"Exception: {ex.Message}\n");
                ResultsTextBox.AppendText($"StackTrace: {ex.StackTrace}\n\n");
                ResultsTextBox.ScrollToEnd();
            });
        }

        private void LogResult(string operation, object result)
        {
            Dispatcher.Invoke(() =>
            {
                var timestamp = DateTime.Now.ToString("HH:mm:ss");
                var json = JsonConvert.SerializeObject(result, Formatting.Indented);
                ResultsTextBox.AppendText($"[{timestamp}] 📊 {operation} Result:\n");
                ResultsTextBox.AppendText($"{json}\n\n");
                ResultsTextBox.ScrollToEnd();
            });
        }

        private void TestConnection_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LogMessage("🔗 Testing connection...");
                
                if (_kiwoomClient == null)
                {
                    LogMessage("❌ KiwoomRestApiClient not initialized");
                    return;
                }

                var result = new
                {
                    success = true,
                    message = "KiwoomRestApiClient is ready",
                    token = _kiwoomClient.Token,
                    isMock = true,
                    timestamp = DateTime.Now
                };

                LogResult("Connection Test", result);
            }
            catch (Exception ex)
            {
                LogError("Connection test failed", ex);
            }
        }

        private async void GetStockInfo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var stockCode = StockCodeTextBox.Text.Trim();
                if (string.IsNullOrEmpty(stockCode))
                {
                    LogMessage("❌ Please enter a stock code");
                    return;
                }

                LogMessage($"📊 Getting stock info for {stockCode}...");

                var result = await _kiwoomClient.StockInfo.GetStockInfoAsync(
                    stockCode, 
                    DateTime.Today, 
                    KiwoomStockInfoMarginLoanType.Loan
                );

                LogMessage($"API Response - ReturnCode: {result.ReturnCode}, Message: {result.ReturnMessage}");

                if (result.Data != null)
                {
                    LogMessage($"✅ Stock info received: {result.Data.StockName} - {result.Data.CurrentPrice}원");
                }
                else
                {
                    LogMessage("⚠️ Stock info data is null");
                }

                LogResult($"Stock Info ({stockCode})", result);
            }
            catch (Exception ex)
            {
                LogError($"Getting stock info failed", ex);
            }
        }

        private async void GetTradeInfo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var stockCode = StockCodeTextBox.Text.Trim();
                if (string.IsNullOrEmpty(stockCode))
                {
                    LogMessage("❌ Please enter a stock code");
                    return;
                }

                LogMessage($"📈 Getting trade info for {stockCode}...");

                var result = await _kiwoomClient.StockInfo.GetTradeInfoAsync(stockCode);
                
                LogMessage($"API Response - ReturnCode: {result.ReturnCode}, Message: {result.ReturnMessage}");
                LogResult($"Trade Info ({stockCode})", result);
            }
            catch (Exception ex)
            {
                LogError($"Getting trade info failed", ex);
            }
        }

        private async void GetChart_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var stockCode = StockCodeTextBox.Text.Trim();
                if (string.IsNullOrEmpty(stockCode))
                {
                    LogMessage("❌ Please enter a stock code");
                    return;
                }

                LogMessage($"📉 Getting chart data for {stockCode}...");

                var result = await _kiwoomClient.Chart.GetDailyChartsAsync(
                    stockCode, 
                    DateTime.Today, 
                    KiwoomChartUseOption.Use
                );
                
                LogMessage($"API Response - ReturnCode: {result.ReturnCode}, Message: {result.ReturnMessage}");
                LogResult($"Chart Data ({stockCode})", result);
            }
            catch (Exception ex)
            {
                LogError($"Getting chart data failed", ex);
            }
        }

        private async void Debug_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var stockCode = StockCodeTextBox.Text.Trim();
                if (string.IsNullOrEmpty(stockCode))
                {
                    LogMessage("❌ Please enter a stock code");
                    return;
                }

                LogMessage($"🔧 Starting debug analysis for {stockCode}...");

                // Test different margin loan types
                var marginTypes = new[]
                {
                    KiwoomStockInfoMarginLoanType.Loan,
                    KiwoomStockInfoMarginLoanType.ShortSale
                };

                var debugResults = new List<object>();

                foreach (var marginType in marginTypes)
                {
                    try
                    {
                        LogMessage($"Testing with margin type: {marginType}");
                        
                        var result = await _kiwoomClient.StockInfo.GetStockInfoAsync(
                            stockCode, 
                            DateTime.Today, 
                            marginType
                        );

                        var debugInfo = new
                        {
                            marginType = marginType.ToString(),
                            returnCode = result.ReturnCode,
                            returnMessage = result.ReturnMessage,
                            isSuccess = result.IsSuccess,
                            dataIsNull = result.Data == null,
                            stockCode = result.Data?.StockCode,
                            stockName = result.Data?.StockName,
                            currentPrice = result.Data?.CurrentPrice,
                            basePrice = result.Data?.BasePrice,
                            openPrice = result.Data?.OpenPrice,
                            highPrice = result.Data?.HighPrice,
                            lowPrice = result.Data?.LowPrice
                        };

                        debugResults.Add(debugInfo);

                        LogMessage($"Margin type {marginType} result: Code={result.ReturnCode}, Message={result.ReturnMessage}, DataNull={result.Data == null}");

                        if (result.Data != null && !string.IsNullOrEmpty(result.Data.StockCode))
                        {
                            LogMessage($"✅ SUCCESS: Found data with margin type {marginType}");
                            break; // Found working data, no need to test others
                        }
                    }
                    catch (Exception ex)
                    {
                        LogError($"Error testing margin type {marginType}", ex);
                        debugResults.Add(new 
                        { 
                            marginType = marginType.ToString(), 
                            error = ex.Message 
                        });
                    }
                }

                var finalResult = new
                {
                    stockCode,
                    testDate = DateTime.Today.ToString("yyyy-MM-dd"),
                    clientToken = _kiwoomClient.Token,
                    results = debugResults
                };

                LogResult($"Debug Analysis ({stockCode})", finalResult);
            }
            catch (Exception ex)
            {
                LogError($"Debug analysis failed", ex);
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            ResultsTextBox.Clear();
            LogMessage("🗑️ Results cleared");
        }
    }
}