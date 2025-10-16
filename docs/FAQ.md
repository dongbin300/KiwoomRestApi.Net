# KiwoomRestApi.Net FAQ

## Table of Contents
- [Getting Started](#getting-started)
- [API Usage](#api-usage)
- [Authentication](#authentication)
- [Real-time Data](#real-time-data)
- [Trading](#trading)
- [Error Handling](#error-handling)
- [Performance](#performance)
- [Mock vs Real Trading](#mock-vs-real-trading)

---

## Getting Started

### Q1: What are the prerequisites for using KiwoomRestApi.Net?
**A:** You need:
- .NET 6.0 or higher
- Kiwoom Securities account with API access
- App Key and Secret Key from Kiwoom OpenAPI portal
- Visual Studio 2022 or VS Code

### Q2: How do I install the library?
**A:** Install via NuGet:
```bash
dotnet add package KiwoomRestApi.Net
```
Or via Package Manager Console:
```
Install-Package KiwoomRestApi.Net
```

### Q3: What's the difference between mock mode and real trading?
**A:**
- **Mock Mode**: Uses simulated data, no real transactions, free for testing
- **Real Mode**: Live market data, actual trades occur, requires real account

---

## API Usage

### Q4: How do I get stock information?
**A:** Use the StockInfo client:
```csharp
var stockInfo = await client.StockInfo.GetStockInfoAsync(
    stockCode: "005930",
    date: DateTime.Today,
    marginLoanType: KiwoomStockInfoMarginLoanType.Loan
);
```

### Q5: How do I handle pagination for large data sets?
**A:** Check the `ContYn` and `NextKey` properties:
```csharp
do {
    var result = await client.SomeApiCallAsync();
    // Process result.Data
    client.NextKey = result.NextKey;
    client.ContYn = result.ContYn ? "Y" : "";
} while (result.ContYn && !string.IsNullOrEmpty(result.NextKey));
```

### Q6: Can I make multiple API calls simultaneously?
**A:** Yes, the library is fully async. However, be aware of Kiwoom's rate limits:
```csharp
var tasks = new[]
{
    client.StockInfo.GetStockInfoAsync("005930", DateTime.Today),
    client.StockInfo.GetStockInfoAsync("000660", DateTime.Today),
    client.StockInfo.GetStockInfoAsync("035420", DateTime.Today)
};

var results = await Task.WhenAll(tasks);
```

---

## Authentication

### Q7: How do I get API keys?
**A:**
1. Log in to Kiwoom's OpenAPI portal
2. Register your application
3. Generate App Key and Secret Key
4. Choose between Mock or Real environment

### Q8: Do I need to manually handle tokens?
**A:** No, the library handles token management automatically:
```csharp
var client = await KiwoomRestApiClient.CreateAsync(appKey, secretKey, isMock);
// Token is obtained and stored automatically
```

### Q9: What should I do if my token expires?
**A:** The library automatically handles token refresh. If you encounter token issues:
```csharp
// Reinitialize the client
await client.InitializeAsync();
```

---

## Real-time Data

### Q10: How do I set up real-time data streaming?
**A:** Use the WebSocket client:
```csharp
var socketClient = await KiwoomSocketClient.CreateAsync(client.Token, isMock);

// Subscribe to real-time data
await socketClient.WebSocket.SubscribeAsync(
    serviceNames: [KiwoomWebSocketServiceName.StockExecution],
    stockCodes: ["005930", "000660"]
);
```

### Q11: How do I handle real-time events?
**A:** Subscribe to event handlers:
```csharp
socketClient.OnRealtimeStockTradeReceived += (data) => {
    foreach (var item in data) {
        Console.WriteLine($"{item.Values.CurrentPrice}");
    }
};
```

### Q12: Can I subscribe to multiple stock codes at once?
**A:** Yes, you can subscribe to up to 100 stock codes:
```csharp
var stockCodes = new[] { "005930", "000660", "035420", /* ... more stocks */ };
await socketClient.WebSocket.SubscribeAsync(
    serviceNames: [KiwoomWebSocketServiceName.StockExecution],
    stockCodes: stockCodes
);
```

---

## Trading

### Q13: How do I place a buy order?
**A:** Use the Order client:
```csharp
var order = await client.Order.PlaceOrderAsync(
    orderType: KiwoomOrderType.Buy,
    exchangeType: KiwoomOrderDomesticStockExchangeType.Krx,
    stockCode: "005930",
    quantity: 10,
    transactionType: KiwoomOrderTransactionType.Market
);
```

### Q14: How do I cancel or modify an order?
**A:** Use the appropriate methods:
```csharp
// Cancel
await client.Order.CancelOrderAsync(exchangeType, orderNumber, stockCode, quantity);

// Modify
await client.Order.ModifyOrderAsync(exchangeType, orderNumber, stockCode, newQuantity, newPrice);
```

### Q15: How do I check my order status?
**A:** Use the account client:
```csharp
var unfilledOrders = await client.Account.GetUnfilledOrdersAsync(
    queryType: KiwoomAccountQueryType.All,
    transactionType: KiwoomAccountTransactionType.All,
    stockExchangeType: KiwoomAccountStockExchangeType.Unified
);
```

### Q16: Is paper trading available?
**A:** Yes, use mock mode for paper trading:
```csharp
var client = await KiwoomRestApiClient.CreateAsync(appKey, secretKey, isMock: true);
// All orders will be simulated
```

---

## Error Handling

### Q17: What are common error codes?
**A:**
- `OVERFLOW`: Too many requests
- `NOT_EXIST`: Stock code doesn't exist
- `INVALID_PARAMETER`: Invalid API parameters
- `AUTH_EXPIRED`: Authentication expired

### Q18: How do I handle API errors?
**A:** Always check the response:
```csharp
var result = await client.SomeApiCallAsync();
if (!result.IsSuccess) {
    Console.WriteLine($"Error: {result.ErrorMessage}");
    // Handle error appropriately
}
```

### Q19: What should I do when I get rate limited?
**A:** Implement exponential backoff:
```csharp
int retryCount = 0;
int maxRetries = 3;

while (retryCount < maxRetries) {
    var result = await client.SomeApiCallAsync();
    if (result.IsSuccess) break;

    if (result.ErrorMessage?.Contains("OVERFLOW") == true) {
        await Task.Delay(1000 * (int)Math.Pow(2, retryCount));
        retryCount++;
    }
}
```

---

## Performance

### Q20: How can I improve performance?
**A:**
- Use async/await properly
- Implement caching for frequently accessed data
- Use rate limiting to avoid API limits
- Batch requests where possible
- Dispose clients properly

### Q21: Is there a built-in caching mechanism?
**A:** No, but you can implement one easily:
```csharp
public class SimpleCache
{
    private readonly Dictionary<string, (DateTime timestamp, object data)> _cache = new();

    public async Task<T> GetOrCreateAsync<T>(string key, Func<Task<T>> factory, TimeSpan expiry)
    {
        if (_cache.TryGetValue(key, out var cached) &&
            DateTime.Now - cached.timestamp < expiry) {
            return (T)cached.data;
        }

        var data = await factory();
        _cache[key] = (DateTime.Now, data);
        return data;
    }
}
```

### Q22: How do I properly dispose of clients?
**A:** Use using statements or call Dispose:
```csharp
// Using statement (recommended)
using var client = await KiwoomRestApiClient.CreateAsync(appKey, secretKey, isMock);

// Manual disposal
var client = await KiwoomRestApiClient.CreateAsync(appKey, secretKey, isMock);
try {
    // Use client
} finally {
    client.Dispose();
}
```

---

## Mock vs Real Trading

### Q23: Which features work in mock mode?
**A:** Most features work in mock mode:
- Stock information lookup
- Market data retrieval
- Chart data
- Ranking information
- Real-time data streaming
- Paper trading (simulated orders)

### Q24: What doesn't work in mock mode?
**A:** Some account-specific features:
- Real account balances
- Actual order execution
- Real profit/loss data
- Some regulatory reporting features

### Q25: How do I switch from mock to real trading?
**A:** Just change the `isMock` parameter:
```csharp
// Mock mode
var mockClient = await KiwoomRestApiClient.CreateAsync(appKey, secretKey, isMock: true);

// Real mode
var realClient = await KiwoomRestApiClient.CreateAsync(appKey, secretKey, isMock: false);
```

---

## Additional Questions

### Q26: Can I use this in a background service?
**A:** Yes, the library is designed for background services:
```csharp
public class KiwoomBackgroundService : BackgroundService
{
    private readonly KiwoomRestApiClient _client;

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            // Your logic here
            await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
        }
    }
}
```

### Q27: How do I handle WebSocket disconnections?
**A:** Implement reconnection logic:
```csharp
socketClient.OnMessageReceived += async (message) => {
    if (message.ServiceName == "SYSTEM" && message.ReturnCode != 0) {
        // Handle disconnection
        await ReconnectAsync();
    }
};

async Task ReconnectAsync() {
    try {
        await socketClient.DisconnectAsync();
        socketClient = await KiwoomSocketClient.CreateAsync(client.Token, isMock);
        // Resubscribe to previous subscriptions
    } catch (Exception ex) {
        Console.WriteLine($"Reconnection failed: {ex.Message}");
    }
}
```

### Q28: Where can I get more help?
**A:**
- Check the [API Reference](api-reference.html)
- Review the [Tutorial](tutorial.html)
- Open an issue on the GitHub repository
- Join our community discussions

---

## Troubleshooting Checklist

- [ ] Verify your API keys are correct
- [ ] Check if you're using the correct environment (mock vs real)
- [ ] Ensure your internet connection is stable
- [ ] Verify stock codes are valid (6 digits)
- [ ] Check for rate limiting (slow down requests)
- [ ] Review error messages carefully
- [ ] Ensure proper async/await usage
- [ ] Dispose clients properly

---

*Last updated: October 2025*