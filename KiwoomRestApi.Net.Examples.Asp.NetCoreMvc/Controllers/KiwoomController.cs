using KiwoomRestApi.Net.Clients;
using KiwoomRestApi.Net.Enums.StockInfo;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace KiwoomRestApi.Net.Examples.Asp.NetCoreMvc.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KiwoomController : ControllerBase
    {
        private readonly KiwoomRestApiClient _kiwoomClient;
        private readonly ILogger<KiwoomController> _logger;

        public KiwoomController(KiwoomRestApiClient kiwoomClient, ILogger<KiwoomController> logger)
        {
            _kiwoomClient = kiwoomClient;
            _logger = logger;
        }

        [HttpGet("test")]
        public async Task<IActionResult> TestConnection()
        {
            try
            {
                _logger.LogInformation("Testing Kiwoom connection");
                
                return Ok(new
                {
                    success = true,
                    message = "KiwoomRestApiClient is ready",
                    token = _kiwoomClient.Token,
                    isMock = true
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error testing connection");
                return BadRequest(new { success = false, error = ex.Message });
            }
        }

        [HttpGet("stockinfo/{stockCode}")]
        public async Task<IActionResult> GetStockInfo(string stockCode)
        {
            try
            {
                _logger.LogInformation("Getting stock info for {StockCode}", stockCode);
                
                var result = await _kiwoomClient.StockInfo.GetStockInfoAsync(
                    stockCode, 
                    DateTime.Today, 
                    KiwoomStockInfoMarginLoanType.Loan
                );

                _logger.LogInformation("API Response - ReturnCode: {ReturnCode}, Message: {Message}", 
                    result.ReturnCode, result.ReturnMessage);

                if (result.Data != null)
                {
                    _logger.LogInformation("Stock info received: StockCode={StockCode}, StockName={StockName}, CurrentPrice={CurrentPrice}",
                        result.Data.StockCode, result.Data.StockName, result.Data.CurrentPrice);
                }
                else
                {
                    _logger.LogWarning("Stock info data is null");
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting stock info for {StockCode}", stockCode);
                return BadRequest(new { error = ex.Message, stackTrace = ex.StackTrace });
            }
        }

        [HttpGet("tradeinfo/{stockCode}")]
        public async Task<IActionResult> GetTradeInfo(string stockCode)
        {
            try
            {
                _logger.LogInformation("Getting trade info for {StockCode}", stockCode);
                
                var result = await _kiwoomClient.StockInfo.GetTradeInfoAsync(stockCode);
                
                _logger.LogInformation("Trade info API Response - ReturnCode: {ReturnCode}, Message: {Message}", 
                    result.ReturnCode, result.ReturnMessage);

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting trade info for {StockCode}", stockCode);
                return BadRequest(new { error = ex.Message, stackTrace = ex.StackTrace });
            }
        }

        [HttpGet("chart/{stockCode}")]
        public async Task<IActionResult> GetChart(string stockCode, [FromQuery] DateTime? date = null)
        {
            try
            {
                var chartDate = date ?? DateTime.Today;
                _logger.LogInformation("Getting chart for {StockCode} on {Date}", stockCode, chartDate);
                
                var result = await _kiwoomClient.Chart.GetDailyChartsAsync(
                    stockCode, 
                    chartDate, 
                    KiwoomRestApi.Net.Enums.Chart.KiwoomChartUseOption.Use
                );
                
                _logger.LogInformation("Chart API Response - ReturnCode: {ReturnCode}, Message: {Message}", 
                    result.ReturnCode, result.ReturnMessage);

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting chart for {StockCode}", stockCode);
                return BadRequest(new { error = ex.Message, stackTrace = ex.StackTrace });
            }
        }

        [HttpGet("debug/{stockCode}")]
        public async Task<IActionResult> DebugStockInfo(string stockCode)
        {
            try
            {
                _logger.LogInformation("=== DEBUG: Starting detailed analysis for {StockCode} ===", stockCode);

                // Test different margin loan types
                var marginTypes = new[]
                {
                    KiwoomStockInfoMarginLoanType.Loan,
                    KiwoomStockInfoMarginLoanType.ShortSale
                };

                var results = new List<object>();

                foreach (var marginType in marginTypes)
                {
                    try
                    {
                        _logger.LogInformation("Testing with margin type: {MarginType}", marginType);
                        
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
                            lowPrice = result.Data?.LowPrice,
                            fullDataJson = result.Data != null ? JsonConvert.SerializeObject(result.Data, Formatting.Indented) : null
                        };

                        results.Add(debugInfo);

                        _logger.LogInformation("Margin type {MarginType} result: Code={Code}, Message={Message}, DataNull={DataNull}",
                            marginType, result.ReturnCode, result.ReturnMessage, result.Data == null);

                        if (result.Data != null && !string.IsNullOrEmpty(result.Data.StockCode))
                        {
                            _logger.LogInformation("SUCCESS: Found data with margin type {MarginType}", marginType);
                            break; // Found working data, no need to test others
                        }
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "Error testing margin type {MarginType}", marginType);
                        results.Add(new 
                        { 
                            marginType = marginType.ToString(), 
                            error = ex.Message 
                        });
                    }
                }

                return Ok(new
                {
                    stockCode,
                    testDate = DateTime.Today.ToString("yyyy-MM-dd"),
                    clientToken = _kiwoomClient.Token,
                    results
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in debug endpoint for {StockCode}", stockCode);
                return BadRequest(new { error = ex.Message, stackTrace = ex.StackTrace });
            }
        }
    }
}