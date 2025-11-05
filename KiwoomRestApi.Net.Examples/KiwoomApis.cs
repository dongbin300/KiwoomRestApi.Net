using KiwoomRestApi.Net.Clients;

using KiwoomRestApi.Net.Enums;
using KiwoomRestApi.Net.Enums.Account;
using KiwoomRestApi.Net.Enums.Chart;
using KiwoomRestApi.Net.Enums.CreditOrder;
using KiwoomRestApi.Net.Enums.Elw;
using KiwoomRestApi.Net.Enums.Etf;
using KiwoomRestApi.Net.Enums.ForeignInstitution;
using KiwoomRestApi.Net.Enums.Industry;
using KiwoomRestApi.Net.Enums.MarketCondition;
using KiwoomRestApi.Net.Enums.Order;
using KiwoomRestApi.Net.Enums.RankingInfo;
using KiwoomRestApi.Net.Enums.SecuritiesLending;
using KiwoomRestApi.Net.Enums.ShortSale;
using KiwoomRestApi.Net.Enums.StockInfo;
using KiwoomRestApi.Net.Enums.Theme;
using KiwoomRestApi.Net.Enums.WebSocket;

using Newtonsoft.Json;

using System.IO;

namespace KiwoomRestApi.Net.Examples
{
    public class KiwoomApis
    {
        private readonly KiwoomRestApiClient _client;
        private readonly KiwoomSocketClient _client2;
        private readonly int mock = 2;

        public KiwoomApis()
        {
            if (mock > 0)
            {
                var appKey = File.ReadAllText("D:\\Assets\\kiwoom_appkey_mock.txt");
                var secretKey = File.ReadAllText("D:\\Assets\\kiwoom_secretkey_mock.txt");
                _client = KiwoomRestApiClient.Create(appKey, secretKey, true);
                _client2 = KiwoomSocketClient.Create(_client.Token, true);
            }
            else
            {
                var appKey = File.ReadAllText("D:\\Assets\\kiwoom_appkey.txt");
                var secretKey = File.ReadAllText("D:\\Assets\\kiwoom_secretkey.txt");
                _client = KiwoomRestApiClient.Create(appKey, secretKey, false);
                _client2 = KiwoomSocketClient.Create(_client.Token, false);
            }
        }

        public void Run()
        {
            var stockCode = "005930";
            var startDate = new DateTime(2025, 10, 1);
            var endDate = new DateTime(2025, 10, 14);
            var date = new DateTime(2025, 10, 14);

            //var a1 = _client.Account.GetAvailableWithdrawalAmountsAsync(stockCode, KiwoomAccountTransactionType.All, 100).Result; // no mock
            //var a2 = _client.Account.GetConsignedTransactionsAsync(KiwoomAccountTransactionType2.All, KiwoomAccountGoodsType.All, KiwoomAccountDomesticStockExchangeType.All, startDate, endDate).Result; // no mock
            //var a3 = _client.Account.GetCreditDepositOrdersAsync(stockCode).Result; // no mock
            //var a4 = _client.Account.GetDailyBalanceProfitRatesAsync(date).Result; // no mock
            //var a5 = _client.Account.GetDailyEstimatedDepositAssetsAsync(startDate, endDate).Result; // no mock
            //var a6 = _client.Account.GetDailyProfitRateDetailsAsync(startDate, endDate).Result; // no mock
            //var a7 = _client.Account.GetDailyRealizedProfitLossesAsync(startDate, endDate).Result;
            //var a8 = _client.Account.GetDailyStatusAsync().Result;
            //var a9 = _client.Account.GetDailyStockRealizedProfitLossesAsync(stockCode, startDate).Result;
            //var a10 = _client.Account.GetDailyStockRealizedProfitLossPeriodsAsync(stockCode, startDate, endDate).Result;
            //var a11 = _client.Account.GetDepositsAsync(KiwoomAccountDepositQueryType.Normal).Result;
            //var a12 = _client.Account.GetEstimatedDepositAssetAsync(false).Result;
            //var a13 = _client.Account.GetEvaluationBalancesAsync(KiwoomAccountEvaluationBalanceQueryType.Aggregate, KiwoomAccountDomesticStockExchangeType.All).Result;
            //var a14 = _client.Account.GetEvaluationsAsync(false, KiwoomAccountStockExchangeType.Unified).Result;
            //var a15 = _client.Account.GetFilledOrdersAsync(KiwoomAccountQueryType.All, KiwoomAccountTransactionType.All, KiwoomAccountStockExchangeType.Unified).Result;
            //var a16 = _client.Account.GetMarginDetailsAsync().Result;
            //var a17 = _client.Account.GetMarginOrdersAsync(stockCode).Result;
            //var a18 = _client.Account.GetNextDaySettlementsAsync().Result;
            //var a19 = _client.Account.GetOrderTradeDetailsAsync(KiwoomAccountOrderQueryType.OrderSequence, KiwoomAccountStockBondType.All, KiwoomAccountTransactionType.All, KiwoomAccountDomesticStockExchangeType.All).Result;
            //var a20 = _client.Account.GetOrderTradesAsync(KiwoomAccountOrderTradeQueryType.All, KiwoomAccountStockBondType.All, KiwoomAccountTransactionType.All, KiwoomAccountDomesticStockExchangeType.All, KiwoomAccountMarketType.All).Result;
            //var a21 = _client.Account.GetProfitRatesAsync(KiwoomAccountStockExchangeType.Unified).Result;
            //var a22 = _client.Account.GetTodayRealizedProfitLossAsync(stockCode).Result;
            //var a23 = _client.Account.GetTodayTransactionJournalsAsync(KiwoomAccountOddLotType.TodaySellAll, KiwoomAccountCashCreditType.All).Result;
            //var a24 = _client.Account.GetTradeBalancesAsync(KiwoomAccountStockExchangeType.Unified).Result;
            //var a25 = _client.Account.GetUnfilledOrdersAsync(KiwoomAccountQueryType.All, KiwoomAccountTransactionType.All, KiwoomAccountStockExchangeType.Unified).Result;
            //var a26 = _client.Account.GetUnfilledSplitOrdersAsync(stockCode).Result;

            //var b1 = _client.Chart.GetDailyChartsAsync(stockCode, date, true).Result;
            //var b2 = _client.Chart.GetIndustryDailyChartsAsync(KiwoomChartIndustryCode.Kospi200, date).Result;
            //var b3 = _client.Chart.GetIndustryMinuteChartsAsync(KiwoomChartIndustryCode.Kospi200, 15).Result;
            //var b4 = _client.Chart.GetIndustryMonthlyChartsAsync(KiwoomChartIndustryCode.Kospi200, date).Result;
            //var b5 = _client.Chart.GetIndustryTickChartsAsync(KiwoomChartIndustryCode.Kospi200, 15).Result;
            //var b6 = _client.Chart.GetIndustryWeeklyChartsAsync(KiwoomChartIndustryCode.Kospi200, date).Result;
            //var b7 = _client.Chart.GetIndustryYearlyChartsAsync(KiwoomChartIndustryCode.Kospi200, date).Result;
            //var b8 = _client.Chart.GetIntradayInvestorTradeChartsAsync(KiwoomChartMarketType.Kospi, KiwoomChartAmountQuantityType.Quantity, KiwoomChartTransactionType.Buy, stockCode).Result;
            //var b9 = _client.Chart.GetMinuteChartsAsync(stockCode, 15, false).Result;
            //var b10 = _client.Chart.GetMonthlyChartsAsync(stockCode, date, false).Result;
            //var b11 = _client.Chart.GetStockInvestorInstitutionChartsAsync(date, stockCode, KiwoomChartAmountQuantityType.Amount, KiwoomChartTransactionType.Buy, KiwoomChartUnitType.One).Result;
            var b12 = _client.Chart.GetTickChartsAsync(stockCode, 15, false).Result;
            //var b13 = _client.Chart.GetWeeklyChartsAsync(stockCode, date, false).Result;
            //var b14 = _client.Chart.GetYearlyChartsAsync(stockCode, date, false).Result;
            //var b15 = _client.Chart.GetGoldSpotTickChartsAsync(KiwoomGoldSpotStockCode.Gold_1kg, 10, true).Result;
            //var b16 = _client.Chart.GetGoldSpotMinuteChartsAsync(KiwoomGoldSpotStockCode.Gold_1kg, 10, true).Result;
            //var b17 = _client.Chart.GetGoldSpotDailyChartsAsync(KiwoomGoldSpotStockCode.Gold_1kg, date, true).Result;
            //var b18 = _client.Chart.GetGoldSpotWeeklyChartsAsync(KiwoomGoldSpotStockCode.Gold_1kg, date, true).Result;
            //var b19 = _client.Chart.GetGoldSpotMonthlyChartsAsync(KiwoomGoldSpotStockCode.Gold_1kg, date, true).Result;
            //var b20 = _client.Chart.GetGoldSpotTodayTickChartsAsync(KiwoomGoldSpotStockCode.Gold_1kg, 10).Result;
            //var b21 = _client.Chart.GetGoldSpotTodayMinuteChartsAsync(KiwoomGoldSpotStockCode.Gold_1kg, 10).Result;

            //var c1 = _client.CreditOrder.PlaceBuyOrderAsync(KiwoomCreditOrderDomesticStockExchangeType.Krx, stockCode, 1, KiwoomCreditOrderTransactionType.BestLimit).Result; // no mock
            //var c2 = _client.CreditOrder.PlaceSellOrderAsync(KiwoomCreditOrderDomesticStockExchangeType.Krx, stockCode, 1, KiwoomCreditOrderTransactionType.BestLimit, KiwoomCreditOrderCreditTransactionType.Loan).Result; // no mock
            //var c3 = _client.CreditOrder.ModifyOrderAsync(KiwoomCreditOrderDomesticStockExchangeType.Krx, "0", stockCode, 1, 100).Result; // no mock
            //var c4 = _client.CreditOrder.CancelOrderAsync(KiwoomCreditOrderDomesticStockExchangeType.Krx, "0", stockCode, 1).Result; // no mock

            //var d1 = _client.Elw.GetBrokerNetTransactionTopsAsync(KiwoomElwCompanyCode.All, 0, KiwoomElwNetTransactionType.NetBuy, 3, false).Result;
            //var d2 = _client.Elw.GetChangeRateRanksAsync(KiwoomElwSortType.None, KiwoomElwRightsType.All, false).Result;
            //var d3 = _client.Elw.GetConditionSearchsAsync(KiwoomElwCompanyCode.All, "0", KiwoomElwRightsType.All, KiwoomElwCompanyCode.All, KiwoomElwSortType.None).Result;
            //var d4 = _client.Elw.GetDailySensitivityIndicesAsync(stockCode).Result;
            //var d5 = _client.Elw.GetDisparityRatesAsync(KiwoomElwCompanyCode.All, "0", KiwoomElwRightsType.All, KiwoomElwCompanyCode.All, false).Result;
            //var d6 = _client.Elw.GetLpHoldingDailyTrendsAsync("0", date).Result;
            //var d7 = _client.Elw.GetPriceVolatilitiesAsync(KiwoomElwChangeType.Surge, KiwoomElwTimeType.Day, 0, 0, KiwoomElwCompanyCode.All, "0", KiwoomElwRightsType.All, KiwoomElwCompanyCode.All, false).Result;
            //var d8 = _client.Elw.GetProximityRatesAsync(stockCode).Result;
            //var d9 = _client.Elw.GetRequestRanksAsync(KiwoomElwSortType2.NetBuyTop, KiwoomElwRightsType.All, false).Result;
            //var d10 = _client.Elw.GetSensitivityIndeicesAsync(stockCode).Result;
            //var d11 = _client.Elw.GetStockInfoAsync(stockCode).Result;

            //var e1 = _client.Etf.GetAllMarketPricesAsync(KiwoomEtfTaxType.All, KiwoomEtfNavChange.All, KiwoomEtfManagementCompany.All, KiwoomEtfTaxationType.All, KiwoomEtfStockExchangeType.Unified).Result;
            //var e2 = _client.Etf.GetDailyTradesAsync(stockCode).Result;
            //var e3 = _client.Etf.GetDailyTransactionsAsync(stockCode).Result;
            //var e4 = _client.Etf.GetHourlyTrades2Async(stockCode).Result;
            //var e5 = _client.Etf.GetHourlyTradesAsync(stockCode).Result;
            //var e6 = _client.Etf.GetHourlyTransactions2Async(stockCode).Result;
            //var e7 = _client.Etf.GetHourlyTransactionsAsync(stockCode).Result;
            //var e8 = _client.Etf.GetProfitRatesAsync(stockCode, "0", KiwoomEtfPeriodType.Month1).Result;
            //var e9 = _client.Etf.GetStockInfoAsync(stockCode).Result;

            //var f1 = _client.ForeignInstitution.GetContinuousTransactionsAsync(KiwoomForeignInstitutionStockExchangeType.Unified, KiwoomForeignInstitutionMarketType.Kospi, KiwoomForeignInstitutionStockIndustryType.Industry, KiwoomForeignInstitutionAmountQuantityType.Amount).Result;
            //var f2 = _client.ForeignInstitution.GetStockForeignersAsync(stockCode).Result;
            //var f3 = _client.ForeignInstitution.GetStockInstitutionsAsync(stockCode).Result;
            //var f4 = _client.ForeignInstitution.GetGoldSpotInvestorStatusAsync().Result;

            //var g1 = _client.Industry.GetAllIndustryIndicesAsync(KiwoomIndustryMarketType2.Kospi).Result;
            //var g2 = _client.Industry.GetCurrentPricesAsync(KiwoomIndustryMarketType.Kospi, KiwoomIndustryCode.Kospi200).Result;
            //var g3 = _client.Industry.GetDailyPricesAsync(KiwoomIndustryMarketType.Kospi, KiwoomIndustryCode.Kospi200).Result;
            //var g4 = _client.Industry.GetInvestorNetBuysAsync(KiwoomIndustryMarketType.Kospi, KiwoomIndustryAmountQuantityType.Amount, KiwoomIndustryStockExchangeType.Unified).Result;
            //var g5 = _client.Industry.GetPricesAsync(KiwoomIndustryMarketType.Kospi, KiwoomIndustryCode.Kospi200, KiwoomIndustryStockExchangeType.Unified).Result;
            //var g6 = _client.Industry.GetProgramTransactionInfoAsync(stockCode).Result;

            //var h1 = _client.MarketCondition.GetAfterMarketSinglePriceOrderBookAsync(stockCode).Result;
            //var h2 = _client.MarketCondition.GetAfterMarketSinglePriceOrderBookListAsync(stockCode).Result;
            //var h3 = _client.MarketCondition.GetAllMarketQuoteForRightsOfferingsAsync(KiwoomMarketConditionRightsType.All).Result;
            //var h4 = _client.MarketCondition.GetDailyInstitutionTradingStocksAsync(KiwoomMarketConditionMarketType.All, KiwoomMarketConditionNetTransactionType.NetBuy, KiwoomMarketConditionStockExchangeType.Unified, startDate, endDate).Result;
            //var h5 = _client.MarketCondition.GetDailyProgramTradeTrendsAsync(date, KiwoomMarketConditionAmountQuantityType3.Amount1M, KiwoomMarketConditionMarketType3.Kospi
            //    , KiwoomMarketConditionTickMinuteType.Minute, KiwoomMarketConditionStockExchangeType.Unified).Result;
            //var h6 = _client.MarketCondition.GetDailyStockPricesAsync(stockCode, date, KiwoomMarketConditionAmountQuantityType2.Quantity).Result;
            //var h7 = _client.MarketCondition.GetDailyTradeMomentumsAsync(stockCode).Result;
            //var h8 = _client.MarketCondition.GetDailyWeeklyMonthlyAsync(stockCode).Result;
            //var h9 = _client.MarketCondition.GetHourlyProgramTradeTrendsAsync(date, KiwoomMarketConditionAmountQuantityType3.Amount1M, KiwoomMarketConditionMarketType3.Kospi, KiwoomMarketConditionTickMinuteType.Minute, KiwoomMarketConditionStockExchangeType.Unified).Result;
            //var h10 = _client.MarketCondition.GetHourlyTradeMomentumsAsync(stockCode).Result;
            //var h11 = _client.MarketCondition.GetHourMinuteAsync(stockCode).Result;
            //var h12 = _client.MarketCondition.GetIntradayInvestorTradeChartsAsync(KiwoomMarketConditionMarketType.All, KiwoomMarketConditionAmountQuantityType.Quantity, KiwoomMarketConditionTransactionType.Buy, KiwoomMarketConditionStockExchangeType.Unified).Result;
            //var h13 = _client.MarketCondition.GetIntradayInvestorTradingsAsync(KiwoomMarketConditionMarketType.Kospi, KiwoomMarketConditionAmountQuantityType.Amount, KiwoomMarketConditionInvestorType.Institution, true, true, KiwoomMarketConditionStockExchangeType.Unified).Result;
            //var h14 = _client.MarketCondition.GetOrderBookAsync(stockCode).Result;
            //var h15 = _client.MarketCondition.GetOrderBookListAsync(stockCode).Result;
            //var h16 = _client.MarketCondition.GetProgramArbitrageBalanceTrendsAsync(date, KiwoomMarketConditionStockExchangeType.Unified).Result;
            //var h17 = _client.MarketCondition.GetProgramTradeAccumulatedTrendsAsync(date, KiwoomMarketConditionAmountQuantityType.Quantity, KiwoomMarketConditionMarketType2.Kospi, KiwoomMarketConditionStockExchangeType.Unified).Result;
            //var h18 = _client.MarketCondition.GetQuoteAsync(stockCode).Result;
            //var h19 = _client.MarketCondition.GetQuoteListAsync(stockCode).Result;
            //var h20 = _client.MarketCondition.GetSecurityFirmStockTradeTrendsAsync("01", stockCode, startDate, endDate).Result;
            //var h21 = _client.MarketCondition.GetStockDailyProgramTradeTrendsAsync(date, stockCode, KiwoomMarketConditionAmountQuantityType.Quantity).Result;
            //var h22 = _client.MarketCondition.GetStockInstitutionTransactionTrendsAsync(stockCode, startDate, endDate, KiwoomMarketConditionUnitPriceType.BuyPrice, KiwoomMarketConditionUnitPriceType.BuyPrice).Result;
            //var h23 = _client.MarketCondition.GetStockTimeProgramTradeTrendsAsync(date, stockCode, KiwoomMarketConditionAmountQuantityType.Quantity).Result;
            //var h24 = _client.MarketCondition.GetGoldTradeTrendsAsync(KiwoomGoldSpotStockCode.Gold_1kg).Result;
            //var h25 = _client.MarketCondition.GetGoldDailyTrendsAsync(KiwoomGoldSpotStockCode.Gold_1kg, date).Result;
            //var h26 = _client.MarketCondition.GetGoldExpectedTradesAsync(KiwoomGoldSpotStockCode.Gold_1kg).Result;
            //var h27 = _client.MarketCondition.GetGoldInfoAsync(KiwoomGoldSpotStockCode.Gold_1kg).Result;
            //var h28 = _client.MarketCondition.GetGoldQuotesAsync(KiwoomGoldSpotStockCode.Gold_1kg, 10).Result;

            //var i1 = _client.Order.PlaceOrderAsync(KiwoomOrderType.Buy, KiwoomOrderDomesticStockExchangeType.Krx, stockCode, 1, KiwoomOrderTransactionType.Market).Result;
            //var i2 = _client.Order.PlaceOrderAsync(KiwoomOrderType.Sell, KiwoomOrderDomesticStockExchangeType.Krx, stockCode, 1, KiwoomOrderTransactionType.Market).Result;
            //var i3 = _client.Order.ModifyOrderAsync(KiwoomOrderDomesticStockExchangeType.Krx, "1", stockCode, 1, 100).Result;
            //var i4 = _client.Order.CancelOrderAsync(KiwoomOrderDomesticStockExchangeType.Krx, "1", stockCode, 1).Result;
            //var i5 = _client.Order.GoldSpotPlaceOrderAsync(KiwoomOrderType.Buy, KiwoomGoldSpotStockCode.MiniGold_100g, 1, KiwoomOrderGoldSpotTransactionType.Normal).Result; // no mock
            //var i6 = _client.Order.GoldSpotPlaceOrderAsync(KiwoomOrderType.Sell, KiwoomGoldSpotStockCode.MiniGold_100g, 1, KiwoomOrderGoldSpotTransactionType.Normal).Result; // no mock
            //var i7 = _client.Order.GoldSpotModifyOrderAsync("1", KiwoomGoldSpotStockCode.MiniGold_100g, 1, 100).Result; // no mock
            //var i8 = _client.Order.GoldSpotCancelOrderAsync("1", KiwoomGoldSpotStockCode.MiniGold_100g).Result; // no mock

            //var j1 = _client.RankingInfo.GetAfterMarketSinglePriceChangeRateRanksAsync(KiwoomRankingInfoMarketType.All, KiwoomRankingInfoChangeSortType.Up, KiwoomRankingInfoStockCondition.All, 100, KiwoomRankingInfoCreditCondition.All, 1000).Result;
            //var j2 = _client.RankingInfo.GetChangeRateTopsAsync(KiwoomRankingInfoMarketType.All, KiwoomRankingInfoChangeSortType.Up, 100, KiwoomRankingInfoStockCondition.All, KiwoomRankingInfoCreditCondition.All, true, KiwoomRankingInfoPriceCondition.All, 1000, KiwoomRankingInfoStockExchangeType.Unified).Result;
            //var j3 = _client.RankingInfo.GetCreditRateTopsAsync(KiwoomRankingInfoMarketType.All, 100, KiwoomRankingInfoStockCondition.All, true, KiwoomRankingInfoCreditCondition.All, KiwoomRankingInfoStockExchangeType.Unified).Result;
            //var j4 = _client.RankingInfo.GetEqualNetTransactionRanksAsync(KiwoomRankingInfoMarketType.All, KiwoomRankingInfoNetTransactionType2.NetBuy, KiwoomRankingInfoEqualNetTransactionRankSortType.Quantity, KiwoomRankingInfoUnitType.One, KiwoomRankingInfoStockExchangeType.Unified, startDate).Result;
            //var j5 = _client.RankingInfo.GetExpectedTradeChangeRateTopsAsync(KiwoomRankingInfoMarketType.All, KiwoomRankingInfoTradeChangeSortType.Down, 100, KiwoomRankingInfoStockCondition.All, KiwoomRankingInfoCreditCondition.All, KiwoomRankingInfoPriceCondition.All, KiwoomRankingInfoStockExchangeType.Unified).Result;
            //var j6 = _client.RankingInfo.GetForeignContinuousNetTransactionTopsAsync(KiwoomRankingInfoMarketType.All, KiwoomRankingInfoContinuousNetTransactionType.ContinuousNetBuy, KiwoomRankingInfoStockExchangeType.Unified, 5).Result;
            //var j7 = _client.RankingInfo.GetForeignInstitutionTransactionTopsAsync(KiwoomRankingInfoMarketType.All, KiwoomRankingInfoAmountQuantityType.Amount, true, KiwoomRankingInfoStockExchangeType.Unified).Result;
            //var j8 = _client.RankingInfo.GetForeignLimitUsageRateIncreaseTopsAsync(KiwoomRankingInfoMarketType.All, KiwoomRankingInfoStockExchangeType.Unified, 5).Result;
            //var j9 = _client.RankingInfo.GetForeignPeriodTransactionTopsAsync(KiwoomRankingInfoMarketType.All, KiwoomRankingInfoNetTransactionType.NetBuy, KiwoomRankingInfoStockExchangeType.Unified, 5).Result;
            //var j10 = _client.RankingInfo.GetForeignWicketTransactionTopsAsync(KiwoomRankingInfoMarketType.All, KiwoomRankingInfoForeignWicketTransactionType.Buy, KiwoomRankingInfoAmountQuantityType.Quantity, KiwoomRankingInfoStockExchangeType.Unified, 5).Result;
            //var j11 = _client.RankingInfo.GetNetBuyBrokerRanksAsync(KiwoomRankingInfoBrokerRankQueryDateType.Period, KiwoomRankingInfoDayType.Today, KiwoomRankingInfoBrokerRankSortType.Date, stockCode, null, null, 5).Result;
            //var j12 = _client.RankingInfo.GetOpenMarketInvestorTransactionTopsAsync(KiwoomRankingInfoMarketType.All, KiwoomRankingInfoNetTransactionType2.NetBuy, KiwoomRankingInfoInstitutionType.Insurance).Result;
            //var j13 = _client.RankingInfo.GetOrderBookSpikesAsync(KiwoomRankingInfoMarketType.All, KiwoomRankingInfoTransactionType.BuyQuantity, KiwoomRankingInfoSpikeSortType.SpikeRate, 100, KiwoomRankingInfoStockCondition.All, KiwoomRankingInfoStockExchangeType.Unified, 3).Result;
            //var j14 = _client.RankingInfo.GetOrderBookTopsAsync(KiwoomRankingInfoMarketType.All, KiwoomRankingInfoSortType.BuyRate, 100, KiwoomRankingInfoStockCondition.All, KiwoomRankingInfoCreditCondition.All, KiwoomRankingInfoStockExchangeType.Unified).Result;
            //var j15 = _client.RankingInfo.GetPreviousDayVolumeTopsAsync(KiwoomRankingInfoMarketType.All, KiwoomRankingInfoPreviousDayVolumeQueryType.PreviousDayVolumeTop100, KiwoomRankingInfoStockExchangeType.Unified, 3, 7).Result;
            //var j16 = _client.RankingInfo.GetRemainQuantityRateSpikesAsync(KiwoomRankingInfoMarketType.All, KiwoomRankingInfoRateType.BuyToSellRate, 100, KiwoomRankingInfoStockCondition.All, KiwoomRankingInfoStockExchangeType.Unified, 3).Result;
            //var j17 = _client.RankingInfo.GetSecuritiesTransactionTopsAsync(100, KiwoomRankingInfoNetTransactionType2.NetBuy, KiwoomRankingInfoStockExchangeType.Unified, "01", 5).Result;
            //var j18 = _client.RankingInfo.GetStockSecuritiesRanksAsync(KiwoomRankingInfoSecuritiesRankQueryType.NetBuyRankSort, stockCode, startDate, endDate, 5).Result;
            //var j19 = _client.RankingInfo.GetTodayMainBrokersAsync(stockCode).Result;
            //var j20 = _client.RankingInfo.GetTodayTopExitBrokersAsync(stockCode).Result;
            //var j21 = _client.RankingInfo.GetTodayVolumeTopsAsync(KiwoomRankingInfoMarketType.All, KiwoomRankingInfoVolumeSortType.Volume, KiwoomRankingInfoStockCondition.All, KiwoomRankingInfoCreditCondition.All, 100, KiwoomRankingInfoPriceCondition2.All, 1000, KiwoomRankingInfoMarketOpenType.All, KiwoomRankingInfoStockExchangeType.Unified).Result;
            //var j22 = _client.RankingInfo.GetTransactionAmountTopsAsync(KiwoomRankingInfoMarketType.All, true, KiwoomRankingInfoStockExchangeType.Unified).Result;
            //var j23 = _client.RankingInfo.GetVolumeSpikesAsync(KiwoomRankingInfoMarketType.All, KiwoomRankingInfoSpikeSortType.Spike, KiwoomRankingInfoTimeType.Minute, 100, KiwoomRankingInfoStockCondition.All, KiwoomRankingInfoPriceType.All, KiwoomRankingInfoStockExchangeType.Unified, 3).Result;

            //var k1 = _client.SecuritiesLending.GetBorrowedTradeHistoriesAsync(KiwoomSecuritiesLendingMarketType.Kospi, date).Result;
            //var k2 = _client.SecuritiesLending.GetBorrowedTradesAsync().Result;
            //var k3 = _client.SecuritiesLending.GetBorrowedTradeTop10Async(KiwoomSecuritiesLendingMarketType.Kospi, startDate).Result;
            //var k4 = _client.SecuritiesLending.GetStockBorrowedTradesAsync(stockCode).Result;

            //var l1 = _client.ShortSale.GetShortsTransactionsAsync(stockCode, startDate, endDate).Result;

            //var m1 = _client.StockInfo.GetBrokerInfoAsync(stockCode).Result;
            //var m2 = _client.StockInfo.GetBrokerInstantVolumesAsync("01", KiwoomStockInfoMarketType2.All, 1000, KiwoomStockInfoPriceCondition.All, KiwoomStockInfoStockExchangeType.Unified).Result;
            //var m3 = _client.StockInfo.GetBrokerPriceAnalysesAsync(stockCode, startDate, endDate, KiwoomStockInfoQueryDateType.Period, KiwoomStockInfoDayType.Today, 5, KiwoomStockInfoSortType.Date, "01", KiwoomStockInfoStockExchangeType.Unified).Result;
            //var m4 = _client.StockInfo.GetCreditLoanAvailableAsync(stockCode).Result;
            //var m5 = _client.StockInfo.GetCreditLoanAvailableStocksAsync(KiwoomStockInfoMarketDealType.All).Result;
            //var m6 = _client.StockInfo.GetCreditTransactionTrendsAsync(stockCode, date, KiwoomStockInfoMarginLoanType.Loan).Result;
            //var m7 = _client.StockInfo.GetDailyTransactionDetailsAsync(stockCode, startDate).Result;
            //var m8 = _client.StockInfo.GetFavoriteStocksAsync(stockCode).Result;
            //var m9 = _client.StockInfo.GetHighLowPersAsync(KiwoomStockInfoPerType.HighPer, KiwoomStockInfoStockExchangeType.Unified).Result;
            //var m10 = _client.StockInfo.GetHighLowProximitiesAsync(KiwoomStockInfoNewHighLowType.NewHigh, 1, KiwoomStockInfoMarketType.All, 100, KiwoomStockInfoStockCondition.All, KiwoomStockInfoCreditCondition.All, KiwoomStockInfoStockExchangeType.Unified).Result;
            //var m11 = _client.StockInfo.GetIndustryCodesAsync(KiwoomStockInfoMarketType4.Kospi).Result;
            //var m12 = _client.StockInfo.GetInvestorDailyTransactionStocksAsync(startDate, endDate, KiwoomStockInfoNetTransactionType.NetBuy, KiwoomStockInfoMarketType.All, KiwoomStockInfoInvestorType.Retail, KiwoomStockInfoStockExchangeType.Unified).Result;
            //var m13 = _client.StockInfo.GetListItemAsync(stockCode).Result;
            //var m14 = _client.StockInfo.GetListsAsync(KiwoomStockInfoMarketType3.Kosdaq).Result;
            //var m15 = _client.StockInfo.GetMemberCompanysAsync().Result;
            //var m16 = _client.StockInfo.GetNewHighLowsAsync(KiwoomStockInfoMarketType.All, KiwoomStockInfoNewHighLowType.NewHigh, KiwoomStockInfoHighLowCloseType.HighLow, KiwoomStockInfoStockCondition.All, 100, KiwoomStockInfoCreditCondition.All, true, 5, KiwoomStockInfoStockExchangeType.Unified).Result;
            //var m17 = _client.StockInfo.GetOpenChangeRatesAsync(KiwoomStockInfoChangeSortType.High, 100, KiwoomStockInfoMarketType.Kospi, true, KiwoomStockInfoStockCondition.All, KiwoomStockInfoCreditCondition.All, KiwoomStockInfoPriceCondition.All, KiwoomStockInfoChangeCondition.Top, KiwoomStockInfoStockExchangeType.Unified).Result;
            //var m18 = _client.StockInfo.GetPriceConcentrationsAsync(KiwoomStockInfoMarketType.All, 1, true, 3, 7, KiwoomStockInfoStockExchangeType.Unified).Result;
            //var m19 = _client.StockInfo.GetPriceVolatilitiesAsync(KiwoomStockInfoMarketType.All, KiwoomStockInfoChangeType.Surge, KiwoomStockInfoTimeType.MinutesAgo, 3, 100, KiwoomStockInfoStockCondition.All, KiwoomStockInfoCreditCondition.All, KiwoomStockInfoPriceCondition.All, true, KiwoomStockInfoStockExchangeType.Unified).Result;
            //var m20 = _client.StockInfo.GetProgramNetBuyTop50Async(KiwoomStockInfoNetTransactionType.NetBuy, KiwoomStockInfoAmountQuantityType.Amount, KiwoomStockInfoMarketType5.Kospi, KiwoomStockInfoStockExchangeType.Unified).Result;
            //var m21 = _client.StockInfo.GetRealtimeStockRanksAsync(KiwoomStockInfoQueryType.OneMinute).Result;
            //var m22 = _client.StockInfo.GetStockInfoAsync(stockCode, date, KiwoomStockInfoMarginLoanType.Loan).Result;
            //var m23 = _client.StockInfo.GetStockInvestorInstitutionsAsync(date, stockCode, KiwoomStockInfoAmountQuantityType.Amount, KiwoomStockInfoTransactionType.Buy, KiwoomStockInfoUnitType.One).Result;
            //var m24 = _client.StockInfo.GetStockInvestorInstitutionTotalsAsync(stockCode, startDate, endDate, KiwoomStockInfoAmountQuantityType.Quantity, KiwoomStockInfoUnitType.Thousand).Result;
            //var m25 = _client.StockInfo.GetStockProgramTransactionStatusAsync(date, KiwoomStockInfoMarketType5.Kospi, KiwoomStockInfoStockExchangeType.Unified).Result;
            //var m26 = _client.StockInfo.GetTodayPreviousDayTradeQuantitiesAsync(stockCode, KiwoomStockInfoDayType2.PreviousDay).Result;
            //var m27 = _client.StockInfo.GetTodayPreviousDayTradesAsync(stockCode, KiwoomStockInfoDayType2.Today, KiwoomStockInfoTickMinuteType.Tick, new TimeSpan(10, 30, 0)).Result;
            //var m28 = _client.StockInfo.GetTradesAsync(stockCode).Result;
            //var m29 = _client.StockInfo.GetUpperLowersAsync(KiwoomStockInfoMarketType.All, KiwoomStockInfoUpDownType.Up, KiwoomStockInfoUpDownPriceSortType.ChangeRate, KiwoomStockInfoStockCondition.All, 100, KiwoomStockInfoCreditCondition.All, KiwoomStockInfoPriceCondition.All, KiwoomStockInfoStockExchangeType.Unified).Result;
            //var m30 = _client.StockInfo.GetViStrikeStocksAsync(KiwoomStockInfoMarketType.All, KiwoomStockInfoBeforeMarketType.All, KiwoomStockInfoTriggerType.All, KiwoomStockInfoSkipStockType.Alert, true, 100, 10000000, false, 0, 0, KiwoomStockInfoTriggerDirection.All, KiwoomStockInfoStockExchangeType.Unified).Result;
            //var m31 = _client.StockInfo.GetVolumeUpdatesAsync(KiwoomStockInfoMarketType.All, 7, 100, KiwoomStockInfoStockExchangeType.Unified).Result;

            //var n1 = _client.Theme.GetComponentStocksAsync("550", KiwoomThemeStockExchangeType.Unified).Result;
            //var n2 = _client.Theme.GetGroupsAsync(KiwoomThemeQueryType.All, 1, KiwoomThemeChangeProfitType.TopChangeRate, KiwoomThemeStockExchangeType.Unified).Result;

            //_client2.WebSocket.SubscribeAsync([KiwoomWebSocketServiceName.Balance], [stockCode], "1").Wait();

            //_client2.WebSocket.GetConditionSearchClearAsync(1).Wait();
            //_client2.WebSocket.GetConditionSearchListAsync().Wait();
            //_client2.WebSocket.GetConditionSearchRequestAsync(1).Wait();
            //_client2.WebSocket.GetConditionSearchRequestRealtimeAsync(1).Wait();

            //_client2.OnRealtimeBalanceReceived += (e) =>
            //{

            //};
        }


    }
}
