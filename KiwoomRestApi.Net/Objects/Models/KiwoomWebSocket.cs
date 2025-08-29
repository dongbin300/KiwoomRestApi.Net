using KiwoomRestApi.Net.Converters;
using KiwoomRestApi.Net.Enums.WebSocket;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models
{
	public record KiwoomWebSocketSendMessage
	{
		[JsonProperty("trnm")]
		public string? ServiceName;
		[JsonProperty("grp_no")]
		public string? GroupId;
		[JsonProperty("refresh")]
		public string? Refresh;
		[JsonProperty("data")]
		public IEnumerable<KiwoomWebSocketSendMessageItem> Data = [];
	}

	public record KiwoomWebSocketSendMessageItem
	{
		[JsonProperty("item")]
		public IEnumerable<string>? Item;
		[JsonProperty("type")]
		public IEnumerable<string> Type = [];
	}

	public record KiwoomWebSocketReceiveMessage<T>
	{
		[JsonProperty("return_code")]
		public int? ReturnCode;
		[JsonProperty("return_msg")]
		public string? ReturnMessage;
		[JsonProperty("trnm")]
		public string? ServiceName;
		[JsonProperty("data")]
		public IEnumerable<KiwoomWebSocketRealtimeSubscription<T>>? Data;
	}

	public record KiwoomWebSocketReceiveMessage2<T>
	{
		[JsonProperty("return_code")]
		public int? ReturnCode;
		[JsonProperty("return_msg")]
		public string? ReturnMessage;
		[JsonProperty("trnm")]
		public string? ServiceName;
		[JsonProperty("seq")]
		public decimal? Id;
		[JsonProperty("cont-yn")]
		public string? ContinueYn;
		[JsonProperty("next-key")]
		public string? NextKey;
		[JsonProperty("data")]
		public IEnumerable<T>? Data;
	}

	public record KiwoomWebSocketRealtimeSubscription<T>
	{
		[JsonProperty("type")]
		public string? Type;
		[JsonProperty("name")]
		public string? Name;
		[JsonProperty("item")]
		public string? Item;
		[JsonProperty("values")]
		public T? Values;
	}
	public record KiwoomWebSocketRealtimeOrderExecution
	{
		[JsonProperty("9201")]
		public decimal? AccountNumber;
		[JsonProperty("9203")]
		public decimal? OrderNumber;
		[JsonProperty("9205")]
		public decimal? ManagerId;
		[JsonProperty("9001")]
		public decimal? SymbolCode;
		[JsonProperty("912")]
		public string? OrderBusinessType;
		[JsonProperty("913")]
		public string? OrderStatus;
		[JsonProperty("302")]
		public string? SymbolName;
		[JsonProperty("900")]
		public decimal? OrderQuantity;
		[JsonProperty("901")]
		public decimal? OrderPrice;
		[JsonProperty("902")]
		public decimal? UnsettledQuantity;
		[JsonProperty("903")]
		public decimal? TotalExecutionAmount;
		[JsonProperty("904")]
		public decimal? OriginalOrderNumber;
		[JsonProperty("905")]
		public string? OrderClassification;
		[JsonProperty("906")]
		public string? TradeClassification;
		[JsonProperty("907")]
		public string? SellBuyClassification;
		[JsonProperty("908")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? OrderExecutionTime;
		[JsonProperty("909")]
		public decimal? ExecutionNumber;
		[JsonProperty("910")]
		public decimal? ExecutionPrice;
		[JsonProperty("911")]
		public decimal? ExecutionQuantity;
		[JsonProperty("10")]
		public decimal? CurrentPrice;
		[JsonProperty("27")]
		public decimal? BestAskPrice;
		[JsonProperty("28")]
		public decimal? BestBidPrice;
		[JsonProperty("914")]
		public decimal? UnitExecutionPrice;
		[JsonProperty("915")]
		public decimal? UnitExecutionQuantity;
		[JsonProperty("938")]
		public decimal? TodayFee;
		[JsonProperty("939")]
		public decimal? TodayTax;
		[JsonProperty("919")]
		public string? RejectReason;
		[JsonProperty("920")]
		public decimal? ScreenNumber;
		[JsonProperty("921")]
		public decimal? TerminalNumber;
		[JsonProperty("922")]
		public string? CreditType;
		[JsonProperty("923")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? LoanDate;
		[JsonProperty("10010")]
		public decimal? AfterMarketSinglePrice;
		[JsonProperty("2134")]
		public KiwoomWebSocketStockExchangeType? ExchangeType;
		[JsonProperty("2135")]
		public string? ExchangeTypeName;
		[JsonProperty("2136")]
		public string? SORFlag;
	}

	public record KiwoomWebSocketRealtimeBalance
	{
		[JsonProperty("9201")]
		public decimal? AccountNumber;
		[JsonProperty("9001")]
		public decimal? SymbolCode;
		[JsonProperty("917")]
		public string? CreditClassification;
		[JsonProperty("916")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? LoanDate;
		[JsonProperty("302")]
		public string? SymbolName;
		[JsonProperty("10")]
		public decimal? CurrentPrice;
		[JsonProperty("930")]
		public decimal? HoldingQuantity;
		[JsonProperty("931")]
		public decimal? PurchaseUnitPrice;
		[JsonProperty("932")]
		public decimal? TotalPurchaseAmount;
		[JsonProperty("933")]
		public decimal? OrderableQuantity;
		[JsonProperty("945")]
		public decimal? TodayNetBuyVolume;
		[JsonProperty("946")]
		public string? SellBuyClassification;
		[JsonProperty("950")]
		public decimal? TodayTotalSellProfitLoss;
		[JsonProperty("951")]
		public string? ExtraItem1;
		[JsonProperty("27")]
		public decimal? BestAskPrice;
		[JsonProperty("28")]
		public decimal? BestBidPrice;
		[JsonProperty("307")]
		public decimal? ReferencePrice;
		[JsonProperty("8019")]
		public decimal? ProfitLossRate;
		[JsonProperty("957")]
		public decimal? CreditAmount;
		[JsonProperty("958")]
		public decimal? CreditInterest;
		[JsonProperty("918")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? ExpirationDate;
		[JsonProperty("990")]
		public decimal? TodayRealizedProfitLossStock;
		[JsonProperty("991")]
		public decimal? TodayRealizedProfitLossRateStock;
		[JsonProperty("992")]
		public decimal? TodayRealizedProfitLossCredit;
		[JsonProperty("993")]
		public decimal? TodayRealizedProfitLossRateCredit;
		[JsonProperty("959")]
		public decimal? CollateralLoanQuantity;
		[JsonProperty("924")]
		public string? ExtraItem2;
	}

	public record KiwoomWebSocketRealtimeStockTrend
	{
		[JsonProperty("10")]
		public decimal? CurrentPrice;
		[JsonProperty("11")]
		public string? ChangeFromPrevDay;
		[JsonProperty("12")]
		public decimal? RateOfChange;
		[JsonProperty("27")]
		public decimal? BestAskPrice;
		[JsonProperty("28")]
		public decimal? BestBidPrice;
		[JsonProperty("13")]
		public decimal? AccumulatedVolume;
		[JsonProperty("14")]
		public decimal? AccumulatedAmount;
		[JsonProperty("16")]
		public decimal? OpeningPrice;
		[JsonProperty("17")]
		public decimal? HighPrice;
		[JsonProperty("18")]
		public decimal? LowPrice;
		[JsonProperty("25")]
		public string? ChangeSymbol;
		[JsonProperty("26")]
		public string? VolumeComparedPrevDay;
		[JsonProperty("29")]
		public decimal? AmountChange;
		[JsonProperty("30")]
		public string? VolumeRatioPrevDay;
		[JsonProperty("31")]
		public decimal? TurnoverRate;
		[JsonProperty("32")]
		public decimal? TransactionCost;
		[JsonProperty("311")]
		public decimal? MarketCap;
		[JsonProperty("567")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? UpperLimitTime;
		[JsonProperty("568")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? LowerLimitTime;
	}

	public record KiwoomWebSocketRealtimeStockExecution
	{
		[JsonProperty("20")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? TradeTime;
		[JsonProperty("10")]
		public decimal? CurrentPrice;
		[JsonProperty("11")]
		public decimal? ChangeFromPrevDay;
		[JsonProperty("12")]
		public decimal? RateOfChange;
		[JsonProperty("27")]
		public decimal? BestAskPrice;
		[JsonProperty("28")]
		public decimal? BestBidPrice;
		[JsonProperty("15")]
		public decimal? TradeVolume;
		[JsonProperty("13")]
		public decimal? AccumulatedVolume;
		[JsonProperty("14")]
		public decimal? AccumulatedAmount;
		[JsonProperty("16")]
		public decimal? OpeningPrice;
		[JsonProperty("17")]
		public decimal? HighPrice;
		[JsonProperty("18")]
		public decimal? LowPrice;
		[JsonProperty("25")]
		public decimal? ChangeSymbol;
		[JsonProperty("26")]
		public decimal? VolumeComparedPrevDay;
		[JsonProperty("29")]
		public decimal? AmountChange;
		[JsonProperty("30")]
		public decimal? VolumeRatioPrevDay;
		[JsonProperty("31")]
		public decimal? TurnoverRate;
		[JsonProperty("32")]
		public decimal? TransactionCost;
		[JsonProperty("228")]
		public decimal? Strength;
		[JsonProperty("311")]
		public decimal? MarketCap;
		[JsonProperty("290")]
		public decimal? SessionDivision;
		[JsonProperty("691")]
		public decimal? KOAccessibility;
		[JsonProperty("567")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? UpperLimitTime;
		[JsonProperty("568")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? LowerLimitTime;
		[JsonProperty("851")]
		public decimal? RatioComparedPrevSameTime;
		[JsonProperty("1890")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? OpeningTime;
		[JsonProperty("1891")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? HighTime;
		[JsonProperty("1892")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? LowTime;
		[JsonProperty("1030")]
		public decimal? SellExecutionVolume;
		[JsonProperty("1031")]
		public decimal? BuyExecutionVolume;
		[JsonProperty("1032")]
		public decimal? BuyRatio;
		[JsonProperty("1071")]
		public decimal? SellExecutionCount;
		[JsonProperty("1072")]
		public decimal? BuyExecutionCount;
		[JsonProperty("1313")]
		public decimal? InstantAmount;
		[JsonProperty("1315")]
		public decimal? SingleSellExecutionVolume;
		[JsonProperty("1316")]
		public decimal? SingleBuyExecutionVolume;
		[JsonProperty("1314")]
		public decimal? NetBuyExecutionVolume;
		[JsonProperty("1497")]
		public decimal? CFDInitialMargin;
		[JsonProperty("1498")]
		public decimal? CFDMaintenanceMargin;
		[JsonProperty("620")]
		public decimal? AveragePriceToday;
		[JsonProperty("732")]
		public decimal? CFDTransactionCost;
		[JsonProperty("852")]
		public decimal? ShortSellingCost;
		[JsonProperty("9081")]
		public KiwoomWebSocketStockExchangeType? ExchangeType;
	}

	public record KiwoomWebSocketRealtimeStockPriorAsk
	{
		[JsonProperty("27")]
		public decimal? BestAskPrice;
		[JsonProperty("28")]
		public decimal? BestBidPrice;
	}

	public record KiwoomWebSocketRealtimeStockAskBid
	{
		[JsonProperty("21")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? QuoteTime;
		[JsonProperty("41")]
		public decimal? SellPrice1;
		[JsonProperty("61")]
		public decimal? SellQuantity1;
		[JsonProperty("81")]
		public decimal? SellPriceChange1;
		[JsonProperty("51")]
		public decimal? BuyPrice1;
		[JsonProperty("71")]
		public decimal? BuyQuantity1;
		[JsonProperty("91")]
		public decimal? BuyPriceChange1;
		[JsonProperty("42")]
		public decimal? SellPrice2;
		[JsonProperty("62")]
		public decimal? SellQuantity2;
		[JsonProperty("82")]
		public decimal? SellPriceChange2;
		[JsonProperty("52")]
		public decimal? BuyPrice2;
		[JsonProperty("72")]
		public decimal? BuyQuantity2;
		[JsonProperty("92")]
		public decimal? BuyPriceChange2;
		[JsonProperty("43")]
		public decimal? SellPrice3;
		[JsonProperty("63")]
		public decimal? SellQuantity3;
		[JsonProperty("83")]
		public decimal? SellPriceChange3;
		[JsonProperty("53")]
		public decimal? BuyPrice3;
		[JsonProperty("73")]
		public decimal? BuyQuantity3;
		[JsonProperty("93")]
		public decimal? BuyPriceChange3;
		[JsonProperty("44")]
		public decimal? SellPrice4;
		[JsonProperty("64")]
		public decimal? SellQuantity4;
		[JsonProperty("84")]
		public decimal? SellPriceChange4;
		[JsonProperty("54")]
		public decimal? BuyPrice4;
		[JsonProperty("74")]
		public decimal? BuyQuantity4;
		[JsonProperty("94")]
		public decimal? BuyPriceChange4;
		[JsonProperty("45")]
		public decimal? SellPrice5;
		[JsonProperty("65")]
		public decimal? SellQuantity5;
		[JsonProperty("85")]
		public decimal? SellPriceChange5;
		[JsonProperty("55")]
		public decimal? BuyPrice5;
		[JsonProperty("75")]
		public decimal? BuyQuantity5;
		[JsonProperty("95")]
		public decimal? BuyPriceChange5;
		[JsonProperty("46")]
		public decimal? SellPrice6;
		[JsonProperty("66")]
		public decimal? SellQuantity6;
		[JsonProperty("86")]
		public decimal? SellPriceChange6;
		[JsonProperty("56")]
		public decimal? BuyPrice6;
		[JsonProperty("76")]
		public decimal? BuyQuantity6;
		[JsonProperty("96")]
		public decimal? BuyPriceChange6;
		[JsonProperty("47")]
		public decimal? SellPrice7;
		[JsonProperty("67")]
		public decimal? SellQuantity7;
		[JsonProperty("87")]
		public decimal? SellPriceChange7;
		[JsonProperty("57")]
		public decimal? BuyPrice7;
		[JsonProperty("77")]
		public decimal? BuyQuantity7;
		[JsonProperty("97")]
		public decimal? BuyPriceChange7;
		[JsonProperty("48")]
		public decimal? SellPrice8;
		[JsonProperty("68")]
		public decimal? SellQuantity8;
		[JsonProperty("88")]
		public decimal? SellPriceChange8;
		[JsonProperty("58")]
		public decimal? BuyPrice8;
		[JsonProperty("78")]
		public decimal? BuyQuantity8;
		[JsonProperty("98")]
		public decimal? BuyPriceChange8;
		[JsonProperty("49")]
		public decimal? SellPrice9;
		[JsonProperty("69")]
		public decimal? SellQuantity9;
		[JsonProperty("89")]
		public decimal? SellPriceChange9;
		[JsonProperty("59")]
		public decimal? BuyPrice9;
		[JsonProperty("79")]
		public decimal? BuyQuantity9;
		[JsonProperty("99")]
		public decimal? BuyPriceChange9;
		[JsonProperty("50")]
		public decimal? SellPrice10;
		[JsonProperty("70")]
		public decimal? SellQuantity10;
		[JsonProperty("60")]
		public decimal? BuyPrice10;
		[JsonProperty("90")]
		public decimal? SellPriceChange10;
		[JsonProperty("80")]
		public decimal? BuyQuantity10;
		[JsonProperty("100")]
		public decimal? BuyPriceChange10;
		[JsonProperty("121")]
		public decimal? TotalSellVolume;
		[JsonProperty("122")]
		public decimal? TotalSellVolumeChange;
		[JsonProperty("125")]
		public decimal? TotalBuyVolume;
		[JsonProperty("126")]
		public decimal? TotalBuyVolumeChange;
		[JsonProperty("23")]
		public decimal? ExpectedExecutionPrice;
		[JsonProperty("24")]
		public decimal? ExpectedExecutionQuantity;
		[JsonProperty("128")]
		public decimal? NetBuyVolume;
		[JsonProperty("129")]
		public decimal? BuyRatio;
		[JsonProperty("138")]
		public decimal? NetSellVolume;
		[JsonProperty("139")]
		public decimal? SellRatio;
		[JsonProperty("200")]
		public decimal? ExpectedExecutionPriceComparedToPrevClose;
		[JsonProperty("201")]
		public decimal? ExpectedExecutionPriceChangeRate;
		[JsonProperty("238")]
		public string? ExpectedExecutionPriceChangeSymbol;
		[JsonProperty("291")]
		public decimal? ExpectedExecutionPriceDuringSession;
		[JsonProperty("292")]
		public decimal? ExpectedExecutionAmount;
		[JsonProperty("293")]
		public string? ExpectedExecutionPriceComparedSymbol;
		[JsonProperty("294")]
		public decimal? ExpectedExecutionPriceCompared;
		[JsonProperty("295")]
		public decimal? ExpectedExecutionPriceComparedChangeRate;
		[JsonProperty("621")]
		public decimal? LP_SellQuantity1;
		[JsonProperty("631")]
		public decimal? LP_BuyQuantity1;
		[JsonProperty("622")]
		public decimal? LP_SellQuantity2;
		[JsonProperty("632")]
		public decimal? LP_BuyQuantity2;
		[JsonProperty("623")]
		public decimal? LP_SellQuantity3;
		[JsonProperty("633")]
		public decimal? LP_BuyQuantity3;
		[JsonProperty("624")]
		public decimal? LP_SellQuantity4;
		[JsonProperty("634")]
		public decimal? LP_BuyQuantity4;
		[JsonProperty("625")]
		public decimal? LP_SellQuantity5;
		[JsonProperty("635")]
		public decimal? LP_BuyQuantity5;
		[JsonProperty("626")]
		public decimal? LP_SellQuantity6;
		[JsonProperty("636")]
		public decimal? LP_BuyQuantity6;
		[JsonProperty("627")]
		public decimal? LP_SellQuantity7;
		[JsonProperty("637")]
		public decimal? LP_BuyQuantity7;
		[JsonProperty("628")]
		public decimal? LP_SellQuantity8;
		[JsonProperty("638")]
		public decimal? LP_BuyQuantity8;
		[JsonProperty("629")]
		public decimal? LP_SellQuantity9;
		[JsonProperty("639")]
		public decimal? LP_BuyQuantity9;
		[JsonProperty("630")]
		public decimal? LP_SellQuantity10;
		[JsonProperty("640")]
		public decimal? LP_BuyQuantity10;
		[JsonProperty("13")]
		public decimal? AccumulatedVolume;
		[JsonProperty("299")]
		public decimal? ExpectedExecutionVolumeRate;
		[JsonProperty("215")]
		public string? MarketOperationDivision;
		[JsonProperty("216")]
		public string? InvestorTicker;
		[JsonProperty("6044")]
		public decimal? KRX_SellVolume1;
		[JsonProperty("6045")]
		public decimal? KRX_SellVolume2;
		[JsonProperty("6046")]
		public decimal? KRX_SellVolume3;
		[JsonProperty("6047")]
		public decimal? KRX_SellVolume4;
		[JsonProperty("6048")]
		public decimal? KRX_SellVolume5;
		[JsonProperty("6049")]
		public decimal? KRX_SellVolume6;
		[JsonProperty("6050")]
		public decimal? KRX_SellVolume7;
		[JsonProperty("6051")]
		public decimal? KRX_SellVolume8;
		[JsonProperty("6052")]
		public decimal? KRX_SellVolume9;
		[JsonProperty("6053")]
		public decimal? KRX_SellVolume10;
		[JsonProperty("6054")]
		public decimal? KRX_BuyVolume1;
		[JsonProperty("6055")]
		public decimal? KRX_BuyVolume2;
		[JsonProperty("6056")]
		public decimal? KRX_BuyVolume3;
		[JsonProperty("6057")]
		public decimal? KRX_BuyVolume4;
		[JsonProperty("6058")]
		public decimal? KRX_BuyVolume5;
		[JsonProperty("6059")]
		public decimal? KRX_BuyVolume6;
		[JsonProperty("6060")]
		public decimal? KRX_BuyVolume7;
		[JsonProperty("6061")]
		public decimal? KRX_BuyVolume8;
		[JsonProperty("6062")]
		public decimal? KRX_BuyVolume9;
		[JsonProperty("6063")]
		public decimal? KRX_BuyVolume10;
		[JsonProperty("6064")]
		public decimal? KRX_TotalSellVolume;
		[JsonProperty("6065")]
		public decimal? KRX_TotalBuyVolume;
		[JsonProperty("6066")]
		public decimal? NXT_SellVolume1;
		[JsonProperty("6067")]
		public decimal? NXT_SellVolume2;
		[JsonProperty("6068")]
		public decimal? NXT_SellVolume3;
		[JsonProperty("6069")]
		public decimal? NXT_SellVolume4;
		[JsonProperty("6070")]
		public decimal? NXT_SellVolume5;
		[JsonProperty("6071")]
		public decimal? NXT_SellVolume6;
		[JsonProperty("6072")]
		public decimal? NXT_SellVolume7;
		[JsonProperty("6073")]
		public decimal? NXT_SellVolume8;
		[JsonProperty("6074")]
		public decimal? NXT_SellVolume9;
		[JsonProperty("6075")]
		public decimal? NXT_SellVolume10;
		[JsonProperty("6076")]
		public decimal? NXT_BuyVolume1;
		[JsonProperty("6077")]
		public decimal? NXT_BuyVolume2;
		[JsonProperty("6078")]
		public decimal? NXT_BuyVolume3;
		[JsonProperty("6079")]
		public decimal? NXT_BuyVolume4;
		[JsonProperty("6080")]
		public decimal? NXT_BuyVolume5;
		[JsonProperty("6081")]
		public decimal? NXT_BuyVolume6;
		[JsonProperty("6082")]
		public decimal? NXT_BuyVolume7;
		[JsonProperty("6083")]
		public decimal? NXT_BuyVolume8;
		[JsonProperty("6084")]
		public decimal? NXT_BuyVolume9;
		[JsonProperty("6085")]
		public decimal? NXT_BuyVolume10;
		[JsonProperty("6086")]
		public decimal? NXT_TotalSellVolume;
		[JsonProperty("6087")]
		public decimal? NXT_TotalBuyVolume;
		[JsonProperty("6100")]
		public decimal? KRX_MidSellTotalVolumeChange;
		[JsonProperty("6101")]
		public decimal? KRX_MidSellTotalVolume;
		[JsonProperty("6102")]
		public decimal? KRX_MidPrice;
		[JsonProperty("6103")]
		public decimal? KRX_MidBuyTotalVolume;
		[JsonProperty("6104")]
		public decimal? KRX_MidBuyTotalVolumeChange;
		[JsonProperty("6105")]
		public decimal? NXT_MidSellTotalVolumeChange;
		[JsonProperty("6106")]
		public decimal? NXT_MidSellTotalVolume;
		[JsonProperty("6107")]
		public decimal? NXT_MidPrice;
		[JsonProperty("6108")]
		public decimal? NXT_MidBuyTotalVolume;
		[JsonProperty("6109")]
		public decimal? NXT_MidBuyTotalVolumeChange;
		[JsonProperty("6110")]
		public decimal? KRX_MidPriceChange;
		[JsonProperty("6111")]
		public string? KRX_MidPriceChangeSymbol;
		[JsonProperty("6112")]
		public decimal? KRX_MidPriceChangeRate;
		[JsonProperty("6113")]
		public decimal? NXT_MidPriceChange;
		[JsonProperty("6114")]
		public string? NXT_MidPriceChangeSymbol;
		[JsonProperty("6115")]
		public decimal? NXT_MidPriceChangeRate;
	}

	public record KiwoomWebSocketRealtimeStockAfterHoursAsk
	{
		[JsonProperty("21")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? QuoteTime;
		[JsonProperty("131")]
		public decimal? AfterHoursTotalSellVolume;
		[JsonProperty("132")]
		public decimal? AfterHoursTotalSellVolumeChange;
		[JsonProperty("135")]
		public decimal? AfterHoursTotalBuyVolume;
		[JsonProperty("136")]
		public decimal? AfterHoursTotalBuyVolumeChange;
	}

	public record KiwoomWebSocketRealtimeStockDailyTrader
	{
		[JsonProperty("141")]
		public string? SellBroker1;
		[JsonProperty("161")]
		public decimal? SellBrokerQuantity1;
		[JsonProperty("166")]
		public decimal? SellBrokerChange1;
		[JsonProperty("146")]
		public string? SellBrokerCode1;
		[JsonProperty("271")]
		public string? SellBrokerColor1;
		[JsonProperty("151")]
		public string? BuyBroker1;
		[JsonProperty("171")]
		public decimal? BuyBrokerQuantity1;
		[JsonProperty("176")]
		public decimal? BuyBrokerChange1;
		[JsonProperty("156")]
		public string? BuyBrokerCode1;
		[JsonProperty("281")]
		public string? BuyBrokerColor1;
		[JsonProperty("142")]
		public string? SellBroker2;
		[JsonProperty("162")]
		public decimal? SellBrokerQuantity2;
		[JsonProperty("167")]
		public decimal? SellBrokerChange2;
		[JsonProperty("147")]
		public string? SellBrokerCode2;
		[JsonProperty("272")]
		public string? SellBrokerColor2;
		[JsonProperty("152")]
		public string? BuyBroker2;
		[JsonProperty("172")]
		public decimal? BuyBrokerQuantity2;
		[JsonProperty("177")]
		public decimal? BuyBrokerChange2;
		[JsonProperty("157")]
		public string? BuyBrokerCode2;
		[JsonProperty("282")]
		public string? BuyBrokerColor2;
		[JsonProperty("143")]
		public string? SellBroker3;
		[JsonProperty("163")]
		public decimal? SellBrokerQuantity3;
		[JsonProperty("168")]
		public decimal? SellBrokerChange3;
		[JsonProperty("148")]
		public string? SellBrokerCode3;
		[JsonProperty("273")]
		public string? SellBrokerColor3;
		[JsonProperty("153")]
		public string? BuyBroker3;
		[JsonProperty("173")]
		public decimal? BuyBrokerQuantity3;
		[JsonProperty("178")]
		public decimal? BuyBrokerChange3;
		[JsonProperty("158")]
		public string? BuyBrokerCode3;
		[JsonProperty("283")]
		public string? BuyBrokerColor3;
		[JsonProperty("144")]
		public string? SellBroker4;
		[JsonProperty("164")]
		public decimal? SellBrokerQuantity4;
		[JsonProperty("169")]
		public decimal? SellBrokerChange4;
		[JsonProperty("149")]
		public string? SellBrokerCode4;
		[JsonProperty("274")]
		public string? SellBrokerColor4;
		[JsonProperty("154")]
		public string? BuyBroker4;
		[JsonProperty("174")]
		public decimal? BuyBrokerQuantity4;
		[JsonProperty("179")]
		public decimal? BuyBrokerChange4;
		[JsonProperty("159")]
		public string? BuyBrokerCode4;
		[JsonProperty("284")]
		public string? BuyBrokerColor4;
		[JsonProperty("145")]
		public string? SellBroker5;
		[JsonProperty("165")]
		public decimal? SellBrokerQuantity5;
		[JsonProperty("170")]
		public decimal? SellBrokerChange5;
		[JsonProperty("150")]
		public string? SellBrokerCode5;
		[JsonProperty("275")]
		public string? SellBrokerColor5;
		[JsonProperty("155")]
		public string? BuyBroker5;
		[JsonProperty("175")]
		public decimal? BuyBrokerQuantity5;
		[JsonProperty("180")]
		public decimal? BuyBrokerChange5;
		[JsonProperty("160")]
		public string? BuyBrokerCode5;
		[JsonProperty("285")]
		public string? BuyBrokerColor5;
		[JsonProperty("261")]
		public decimal? ForeignSellEstimateSum;
		[JsonProperty("262")]
		public decimal? ForeignSellEstimateChange;
		[JsonProperty("263")]
		public decimal? ForeignBuyEstimateSum;
		[JsonProperty("264")]
		public decimal? ForeignBuyEstimateChange;
		[JsonProperty("267")]
		public decimal? ForeignNetBuyEstimateSum;
		[JsonProperty("268")]
		public decimal? ForeignNetBuyEstimateChange;
		[JsonProperty("337")]
		public string? ExchangeDivision;

	}

	public record KiwoomWebSocketRealtimeEtfNav
	{
		[JsonProperty("36")]
		public decimal? NAV;
		[JsonProperty("37")]
		public decimal? NAVChangeFromPrevDay;
		[JsonProperty("38")]
		public decimal? NAVRateOfChange;
		[JsonProperty("39")]
		public decimal? TrackingErrorRate;
		[JsonProperty("20")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? ExecutionTime;
		[JsonProperty("10")]
		public decimal? CurrentPrice;
		[JsonProperty("11")]
		public decimal? ChangeFromPrevDay;
		[JsonProperty("12")]
		public decimal? RateOfChange;
		[JsonProperty("13")]
		public decimal? AccumulatedVolume;
		[JsonProperty("25")]
		public string? ChangeSymbol;
		[JsonProperty("667")]
		public decimal? ELWGearingRatio;
		[JsonProperty("668")]
		public decimal? ELWBreakEvenRatio;
		[JsonProperty("669")]
		public decimal? ELWCapitalSupportPoint;
		[JsonProperty("265")]
		public decimal? NAVIndexDisparityRate;
		[JsonProperty("266")]
		public decimal? NAVETFDisparityRate;

	}

	public record KiwoomWebSocketRealtimeStockExpectedExecution
	{
		[JsonProperty("20")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? ExecutionTime;
		[JsonProperty("10")]
		public decimal? CurrentPrice;
		[JsonProperty("11")]
		public decimal? ChangeFromPrevDay;
		[JsonProperty("12")]
		public decimal? RateOfChange;
		[JsonProperty("15")]
		public decimal? TradeVolume;
		[JsonProperty("13")]
		public decimal? AccumulatedVolume;
		[JsonProperty("25")]
		public string? ChangeSymbol;
	}

	public record KiwoomWebSocketRealtimeSectorIndex
	{
		[JsonProperty("20")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? ExecutionTime;
		[JsonProperty("10")]
		public decimal? CurrentPrice;
		[JsonProperty("11")]
		public decimal? ChangeFromPrevDay;
		[JsonProperty("12")]
		public decimal? RateOfChange;
		[JsonProperty("15")]
		public decimal? TradeVolume;
		[JsonProperty("13")]
		public decimal? AccumulatedVolume;
		[JsonProperty("14")]
		public decimal? AccumulatedAmount;
		[JsonProperty("16")]
		public decimal? OpeningPrice;
		[JsonProperty("17")]
		public decimal? HighPrice;
		[JsonProperty("18")]
		public decimal? LowPrice;
		[JsonProperty("25")]
		public string? ChangeSymbol;
		[JsonProperty("26")]
		public string? VolumeComparedToPrevDay;
	}

	public record KiwoomWebSocketRealtimeSectorFluctuation
	{
		[JsonProperty("20")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? ExecutionTime;
		[JsonProperty("252")]
		public int? RisingStockCount;
		[JsonProperty("251")]
		public int? UpperLimitStockCount;
		[JsonProperty("253")]
		public int? NoChangeStockCount;
		[JsonProperty("255")]
		public int? FallingStockCount;
		[JsonProperty("254")]
		public int? LowerLimitStockCount;
		[JsonProperty("13")]
		public decimal? AccumulatedVolume;
		[JsonProperty("14")]
		public decimal? AccumulatedAmount;
		[JsonProperty("10")]
		public decimal? CurrentPrice;
		[JsonProperty("11")]
		public decimal? ChangeFromPrevDay;
		[JsonProperty("12")]
		public decimal? RateOfChange;
		[JsonProperty("256")]
		public int? TradingStocksCount;
		[JsonProperty("257")]
		public decimal? TradingRatio;
		[JsonProperty("25")]
		public string? ChangeSymbol;
	}

	public record KiwoomWebSocketRealtimeStockInfo
	{
		[JsonProperty("297")]
		public string? ArbitraryExtension;
		[JsonProperty("592")]
		public string? PreMarketArbitraryExtension;
		[JsonProperty("593")]
		public string? PostMarketArbitraryExtension;
		[JsonProperty("305")]
		public decimal? UpperLimitPrice;
		[JsonProperty("306")]
		public decimal? LowerLimitPrice;
		[JsonProperty("307")]
		public decimal? ReferencePrice;
		[JsonProperty("689")]
		public string? EarlyTerminationELWOccurrence;
		[JsonProperty("594")]
		public string? CurrencyUnit;
		[JsonProperty("382")]
		public string? MarginRateDisplay;
		[JsonProperty("370")]
		public string? StockInformation;
	}

	public record KiwoomWebSocketRealtimeElwTheoreticalPrice
	{
		[JsonProperty("20")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? ExecutionTime;
		[JsonProperty("10")]
		public decimal? CurrentPrice;
		[JsonProperty("670")]
		public decimal? ELWTheoreticalPrice;
		[JsonProperty("671")]
		public decimal? ELWImpliedVolatility;
		[JsonProperty("672")]
		public decimal? ELWDelta;
		[JsonProperty("673")]
		public decimal? ELWGamma;
		[JsonProperty("674")]
		public decimal? ELWTheta;
		[JsonProperty("675")]
		public decimal? ELWVega;
		[JsonProperty("676")]
		public decimal? ELWRho;
		[JsonProperty("706")]
		public decimal? LPQuoteImpliedVolatility;
	}

	public record KiwoomWebSocketRealtimeMarketOpenTime
	{
		/// <summary>
		/// 0:KRX장전, 3:KRX장시작, P:NXT프리마켓개시, Q:NXT프리마켓종료, R:NXT메인마켓개시, S:NXT메인마켓종료, T:NXT애프터마켓단일가개시, U:NXT애프터마켓개시, V:NXT종가매매종료, W:NXT애프터마켓종료
		/// </summary>
		[JsonProperty("215")]
		public string? MarketOperationDivision;
		[JsonProperty("20")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? ExecutionTime;
		[JsonProperty("214")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? ExpectedRemainingMarketStartTime;
	}

	public record KiwoomWebSocketRealtimeElwIndicator
	{
		[JsonProperty("20")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? ExecutionTime;
		[JsonProperty("666")]
		public decimal? ELWParity;
		[JsonProperty("1211")]
		public decimal? ELWPremium;
		[JsonProperty("667")]
		public decimal? ELWGearingRatio;
		[JsonProperty("668")]
		public decimal? ELWBreakEvenRatio;
		[JsonProperty("669")]
		public decimal? ELWCapitalSupportPoint;
	}

	public record KiwoomWebSocketRealtimeProgramTrading
	{
		[JsonProperty("20")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? ExecutionTime;
		[JsonProperty("10")]
		public decimal? CurrentPrice;
		[JsonProperty("25")]
		public string? ChangeSymbol;
		[JsonProperty("11")]
		public decimal? ChangeFromPrevDay;
		[JsonProperty("12")]
		public decimal? RateOfChange;
		[JsonProperty("13")]
		public decimal? AccumulatedVolume;
		[JsonProperty("202")]
		public decimal? SellQuantity;
		[JsonProperty("204")]
		public decimal? SellAmount;
		[JsonProperty("206")]
		public decimal? BuyQuantity;
		[JsonProperty("208")]
		public decimal? BuyAmount;
		[JsonProperty("210")]
		public decimal? NetBuyQuantity;
		[JsonProperty("211")]
		public decimal? NetBuyQuantityChange;
		[JsonProperty("212")]
		public decimal? NetBuyAmount;
		[JsonProperty("213")]
		public decimal? NetBuyAmountChange;
		[JsonProperty("214")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? ExpectedRemainingMarketStartTime;
		[JsonProperty("215")]
		public string? MarketOperationDivision;
		[JsonProperty("216")]
		public string? InvestorByTicker;
	}

	public record KiwoomWebSocketRealtimeViTriggeredReleased
	{
		[JsonProperty("9001")]
		public string? StockCode;
		[JsonProperty("302")]
		public string? StockName;
		[JsonProperty("13")]
		public decimal? AccumulatedVolume;
		[JsonProperty("14")]
		public decimal? AccumulatedAmount;
		[JsonProperty("9068")]
		public string? VIDispatchDivision;
		[JsonProperty("9008")]
		public string? MarketClassification;
		[JsonProperty("9075")]
		public string? PreMarketDivision;
		[JsonProperty("1221")]
		public decimal? VIDispatchPrice;
		[JsonProperty("1223")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? TradeExecutionProcessingTime;
		[JsonProperty("1224")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? VIReleaseTime;
		[JsonProperty("1225")]
		public string? VIApplicationType;
		[JsonProperty("1236")]
		public decimal? ReferencePriceStatic;
		[JsonProperty("1237")]
		public decimal? ReferencePriceDynamic;
		[JsonProperty("1238")]
		public decimal? DisparityRateStatic;
		[JsonProperty("1239")]
		public decimal? DisparityRateDynamic;
		[JsonProperty("1489")]
		public decimal? VIDispatchPriceChangeRate;
		[JsonProperty("1490")]
		public int? VIDispatchCount;
		[JsonProperty("9069")]
		public string? DispatchDirectionDivision;
		[JsonProperty("1279")]
		public string? ExtraItem;
	}

	public record KiwoomWebSocketConditionSearchList
	{
		[JsonProperty("seq")]
		public int? Id;
		[JsonProperty("name")]
		public string? Name;
	}

	public record KiwoomWebSocketConditionSearchRequest
	{
		[JsonProperty("9001")]
		public string? StockCode;
		[JsonProperty("302")]
		public string? StockName;
		[JsonProperty("10")]
		public string? CurrentPrice;
		[JsonProperty("25")]
		public string? DiffSymbol;
		[JsonProperty("11")]
		public string? DiffAmount;
		[JsonProperty("12")]
		public string? FluctuationRate;
		[JsonProperty("13")]
		public string? AccumulatedVolume;
		[JsonProperty("16")]
		public string? OpenPrice;
		[JsonProperty("17")]
		public string? HighPrice;
		[JsonProperty("18")]
		public string? LowPrice;
	}

	public record KiwoomWebSocketConditionSearchRequestRealtime
	{
		[JsonProperty("jmcode")]
		public string? StockCode;
	}

	public record KiwoomWebSocketConditionSearchRequestRealtime2
	{
		[JsonProperty("trnm")]
		public string? ServiceName;
		[JsonProperty("type")]
		public string? RealType;
		[JsonProperty("name")]
		public string? RealName;
		[JsonProperty("values")]
		public KiwoomWebSocketConditionSearchRequestRealtime2Value? Values;
	}
	public record KiwoomWebSocketConditionSearchRequestRealtime2Value
	{
		[JsonProperty("841")]
		public string? SerialNumber;
		[JsonProperty("9001")]
		public string? StockCode;
		/// <summary>
		/// I 삽입, D 삭제
		/// </summary>
		[JsonProperty("843")]
		public string? InsertDeleteType;
		[JsonProperty("20")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? TradeTime;
		[JsonProperty("907")]
		public string? SellBuyType;
	}

	public record KiwoomWebSocketConditionSearchClear
	{

	}

}
