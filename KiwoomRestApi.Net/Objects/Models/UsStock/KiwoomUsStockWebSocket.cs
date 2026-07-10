using KiwoomRestApi.Net.Converters;
using KiwoomRestApi.Net.Objects.Commons;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models.UsStock
{
	public record KiwoomUsStockWebSocketReceiveMessage<T>
	{
		/// <summary>
		/// 결과코드 - 통신결과에대한 코드(등록, 해지요청시에만 값 전송 0:정상,1:오류, 데이터 실시간 수신시 미전송)
		/// </summary>
		[JsonProperty("return_code")]
		public int? ReturnCode;
		/// <summary>
		/// 결과메시지 - 통신결과에 대한 메시지
		/// </summary>
		[JsonProperty("return_msg")]
		public string? ReturnMessage;
		/// <summary>
		/// 서비스명 - 등록,해지요청시 요청값 반환, 실시간수신시 REAL 반환
		/// </summary>
		[JsonProperty("trnm")]
		public string? ServiceName;
		/// <summary>
		/// 실시간 등록리스트
		/// </summary>
		[JsonProperty("data")]
		public IEnumerable<KiwoomUsStockWebSocketRealtimeSubscription<T>>? Data;
	}

	public record KiwoomUsStockWebSocketRealtimeSubscription<T>
	{
		/// <summary>
		/// 실시간항목 - TR 명(F4,F5,FE,FT)
		/// </summary>
		[JsonProperty("type")]
		public string? Type;
		/// <summary>
		/// 실시간 항목명
		/// </summary>
		[JsonProperty("name")]
		public string? Name;
		/// <summary>
		/// 실시간 등록 요소 - 종목코드
		/// </summary>
		[JsonProperty("item")]
		public string? Item;
		/// <summary>
		/// 거래소구분 (FE, FT에서만 전달)
		/// </summary>
		[JsonProperty("stexTp")]
		public string? StockExchangeType;
		/// <summary>
		/// 실시간 값 리스트
		/// </summary>
		[JsonProperty("values")]
		public T? Values;
	}

	/// <summary>
	/// | F4 | 미국주식 실시간 주문 확인
	/// </summary>
	public record KiwoomUsStockWebSocketRealtimeOrder
	{
		/// <summary>
		/// 계좌번호 (9201)
		/// </summary>
		[JsonProperty("9201")]
		public string? AccountId;
		/// <summary>
		/// 주문번호 (9203)
		/// </summary>
		[JsonProperty("9203")]
		public string? OrderId;
		/// <summary>
		/// 종목,업종코드 (9001)
		/// </summary>
		[JsonProperty("9001")]
		public string? StockCode;
		/// <summary>
		/// 종목명 (302)
		/// </summary>
		[JsonProperty("302")]
		public string? StockName;
		/// <summary>
		/// 주문구분 (905) - 10:원주문, 11:정정주문, 12:취소주문
		/// </summary>
		[JsonProperty("905")]
		public string? OrderType;
		/// <summary>
		/// 매도수구분 (907) - 01:매도, 02:매수
		/// </summary>
		[JsonProperty("907")]
		public string? OrderSide;
		/// <summary>
		/// 매도수구분명 (50072)
		/// </summary>
		[JsonProperty("50072")]
		public string? OrderSideName;
		/// <summary>
		/// 원주문번호 (904)
		/// </summary>
		[JsonProperty("904")]
		public string? OriginalOrderId;
		/// <summary>
		/// 주문수량 (900)
		/// </summary>
		[JsonProperty("900")]
		public decimal? OrderQuantity;
		/// <summary>
		/// 주문가격 (901)
		/// </summary>
		[JsonProperty("901")]
		public decimal? OrderPrice;
		/// <summary>
		/// 매매구분 (906)
		/// </summary>
		[JsonProperty("906")]
		public string? TradeType;
		/// <summary>
		/// 매매구분명 (50073)
		/// </summary>
		[JsonProperty("50073")]
		public string? TradeTypeName;
		/// <summary>
		/// 주문상태 (913)
		/// </summary>
		[JsonProperty("913")]
		public string? OrderStatus;
		/// <summary>
		/// 주문/체결시간 (908)
		/// </summary>
		[JsonProperty("908")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? OrderTradeTime;
		/// <summary>
		/// 주문STOP가격 (50810)
		/// </summary>
		[JsonProperty("50810")]
		public decimal? StopPrice;
		/// <summary>
		/// 통화코드 (8043)
		/// </summary>
		[JsonProperty("8043")]
		public string? CurrencyCode;
		/// <summary>
		/// 예약구분 (50841)
		/// </summary>
		[JsonProperty("50841")]
		public string? ReservationType;
		/// <summary>
		/// (재무)국가코드 (55190)
		/// </summary>
		[JsonProperty("55190")]
		public string? CountryCode;
		/// <summary>
		/// 국가명 (1091)
		/// </summary>
		[JsonProperty("1091")]
		public string? CountryName;
	}

	/// <summary>
	/// | F5 | 미국주식 실시간 체결
	/// </summary>
	public record KiwoomUsStockWebSocketRealtimeExecution
	{
		/// <summary>
		/// 계좌번호 (9201)
		/// </summary>
		[JsonProperty("9201")]
		public string? AccountId;
		/// <summary>
		/// 국가명 (1091)
		/// </summary>
		[JsonProperty("1091")]
		public string? CountryName;
		/// <summary>
		/// 거래소코드 (8046)
		/// </summary>
		[JsonProperty("8046")]
		public string? ExchangeCode;
		/// <summary>
		/// 종목코드 (9001)
		/// </summary>
		[JsonProperty("9001")]
		public string? StockCode;
		/// <summary>
		/// 종목명 (302)
		/// </summary>
		[JsonProperty("302")]
		public string? StockName;
		/// <summary>
		/// 원주문번호 (904)
		/// </summary>
		[JsonProperty("904")]
		public string? OriginalOrderId;
		/// <summary>
		/// 주문번호 (9203)
		/// </summary>
		[JsonProperty("9203")]
		public string? OrderId;
		/// <summary>
		/// 주문구분 (905) - 10:원주문, 11:정정주문, 12:취소주문
		/// </summary>
		[JsonProperty("905")]
		public string? OrderType;
		/// <summary>
		/// 매도수구분 (907) - 01:매도, 02:매수
		/// </summary>
		[JsonProperty("907")]
		public string? OrderSide;
		/// <summary>
		/// 매도수구분명 (50072)
		/// </summary>
		[JsonProperty("50072")]
		public string? OrderSideName;
		/// <summary>
		/// 매매구분명 (50073)
		/// </summary>
		[JsonProperty("50073")]
		public string? TradeTypeName;
		/// <summary>
		/// 주문/체결시간 (908)
		/// </summary>
		[JsonProperty("908")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? OrderTradeTime;
		/// <summary>
		/// 주문상태 - 텍스트값(주문전송, 무효주문, 부분체결, 체결완료 등) (913)
		/// </summary>
		[JsonProperty("913")]
		public string? OrderStatus;
		/// <summary>
		/// 주문수량 (900)
		/// </summary>
		[JsonProperty("900")]
		public decimal? OrderQuantity;
		/// <summary>
		/// 주문가격 (901)
		/// </summary>
		[JsonProperty("901")]
		public decimal? OrderPrice;
		/// <summary>
		/// 미체결수량 (902)
		/// </summary>
		[JsonProperty("902")]
		public decimal? UnsettledQuantity;
		/// <summary>
		/// 체결번호 (909)
		/// </summary>
		[JsonProperty("909")]
		public string? TradeId;
		/// <summary>
		/// 체결가 (910)
		/// </summary>
		[JsonProperty("910")]
		public decimal? TradePrice;
		/// <summary>
		/// 체결량 (911)
		/// </summary>
		[JsonProperty("911")]
		public decimal? TradeQuantity;
		/// <summary>
		/// 보유수량 (930)
		/// </summary>
		[JsonProperty("930")]
		public decimal? HoldingQuantity;
		/// <summary>
		/// 매입단가 (931)
		/// </summary>
		[JsonProperty("931")]
		public decimal? BuyPrice;
		/// <summary>
		/// 당일매도수량 (934)
		/// </summary>
		[JsonProperty("934")]
		public decimal? TodaySellQuantity;
		/// <summary>
		/// 당일매수수량 (936)
		/// </summary>
		[JsonProperty("936")]
		public decimal? TodayBuyQuantity;
		/// <summary>
		/// 전일매도수량 (8004)
		/// </summary>
		[JsonProperty("8004")]
		public decimal? PreviousDaySellQuantity;
		/// <summary>
		/// 전일매수수량 (8005)
		/// </summary>
		[JsonProperty("8005")]
		public decimal? PreviousDayBuyQuantity;
		/// <summary>
		/// 손익금액 (8018)
		/// </summary>
		[JsonProperty("8018")]
		public decimal? ProfitLossAmount;
		/// <summary>
		/// 손익율 (8019)
		/// </summary>
		[JsonProperty("8019")]
		public KiwoomDecimal? ProfitLossRate;
		/// <summary>
		/// 통화코드 (8043)
		/// </summary>
		[JsonProperty("8043")]
		public string? CurrencyCode;
		/// <summary>
		/// 세금 (8075)
		/// </summary>
		[JsonProperty("8075")]
		public decimal? Tax;
		/// <summary>
		/// 수수료 (13006)
		/// </summary>
		[JsonProperty("13006")]
		public decimal? Fee;
		/// <summary>
		/// 실현손익매입금 (50724)
		/// </summary>
		[JsonProperty("50724")]
		public decimal? RealizedProfitLossPurchaseAmount;
		/// <summary>
		/// 환전실현손익매입금액 (50725)
		/// </summary>
		[JsonProperty("50725")]
		public decimal? ExchangeRealizedProfitLossPurchaseAmount;
		/// <summary>
		/// 주문STOP가격 (50810)
		/// </summary>
		[JsonProperty("50810")]
		public decimal? StopPrice;
		/// <summary>
		/// 예약구분 (50841)
		/// </summary>
		[JsonProperty("50841")]
		public string? ReservationType;
		/// <summary>
		/// 환전실현손익금액 (50844)
		/// </summary>
		[JsonProperty("50844")]
		public decimal? ExchangeRealizedProfitLossAmount;
		/// <summary>
		/// (재무)국가코드 (55190)
		/// </summary>
		[JsonProperty("55190")]
		public string? CountryCode;
	}

	/// <summary>
	/// | FE | 미국주식 실시간 체결가
	/// </summary>
	public record KiwoomUsStockWebSocketRealtimeTrade
	{
		/// <summary>
		/// 현재가 (10)
		/// </summary>
		[JsonProperty("10")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 전일대비 (11)
		/// </summary>
		[JsonProperty("11")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 등락율 (12)
		/// </summary>
		[JsonProperty("12")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 누적거래량 (13)
		/// </summary>
		[JsonProperty("13")]
		public decimal? AccumulatedVolume;
		/// <summary>
		/// 누적거래대금 (14)
		/// </summary>
		[JsonProperty("14")]
		public decimal? AccumulatedTransactionAmount;
		/// <summary>
		/// 체결량 (15)
		/// </summary>
		[JsonProperty("15")]
		public KiwoomDecimal? TradeQuantity;
		/// <summary>
		/// 시가 (16)
		/// </summary>
		[JsonProperty("16")]
		public KiwoomDecimal? Open;
		/// <summary>
		/// 고가 (17)
		/// </summary>
		[JsonProperty("17")]
		public KiwoomDecimal? High;
		/// <summary>
		/// 저가 (18)
		/// </summary>
		[JsonProperty("18")]
		public KiwoomDecimal? Low;
		/// <summary>
		/// 시간 (20)
		/// </summary>
		[JsonProperty("20")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? Time;
		/// <summary>
		/// 체결일자 (22)
		/// </summary>
		[JsonProperty("22")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? TradeDate;
		/// <summary>
		/// 전일대비기호 (25)
		/// </summary>
		[JsonProperty("25")]
		public string? ChangeSign;
		/// <summary>
		/// (최우선)매도호가 (27)
		/// </summary>
		[JsonProperty("27")]
		public KiwoomDecimal? BestSellQuote;
		/// <summary>
		/// (최우선)매수호가 (28)
		/// </summary>
		[JsonProperty("28")]
		public KiwoomDecimal? BestBuyQuote;
		/// <summary>
		/// 전일거래량대비(비율) (30)
		/// </summary>
		[JsonProperty("30")]
		public KiwoomDecimal? PreviousDayVolumeChangeRate;
		/// <summary>
		/// 체결강도 (228)
		/// </summary>
		[JsonProperty("228")]
		public decimal? TradeMomentum;
		/// <summary>
		/// 장구분 (290)
		/// </summary>
		[JsonProperty("290")]
		public string? MarketType;
		/// <summary>
		/// 현지 체결시간 (51020)
		/// </summary>
		[JsonProperty("51020")]
		public string? LocalTradeTime;
	}

	/// <summary>
	/// | FT | 미국주식 10호가
	/// </summary>
	public record KiwoomUsStockWebSocketRealtimeOrderBook
	{
		/// <summary>
		/// 시간 (21)
		/// </summary>
		[JsonProperty("21")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? Time;
		/// <summary>
		/// 매도1호가 (41)
		/// </summary>
		[JsonProperty("41")]
		public KiwoomDecimal? SellPrice1;
		/// <summary>
		/// 매도1호가잔량 (61)
		/// </summary>
		[JsonProperty("61")]
		public decimal? SellQuantity1;
		/// <summary>
		/// 매도1호가직전대비 (81)
		/// </summary>
		[JsonProperty("81")]
		public decimal? SellPriceChange1;
		/// <summary>
		/// 매수1호가 (51)
		/// </summary>
		[JsonProperty("51")]
		public KiwoomDecimal? BuyPrice1;
		/// <summary>
		/// 매수1호가잔량 (71)
		/// </summary>
		[JsonProperty("71")]
		public decimal? BuyQuantity1;
		/// <summary>
		/// 매수1호가직전대비 (91)
		/// </summary>
		[JsonProperty("91")]
		public decimal? BuyPriceChange1;
		/// <summary>
		/// 매도2호가 (42)
		/// </summary>
		[JsonProperty("42")]
		public KiwoomDecimal? SellPrice2;
		/// <summary>
		/// 매도2호가잔량 (62)
		/// </summary>
		[JsonProperty("62")]
		public decimal? SellQuantity2;
		/// <summary>
		/// 매도2호가직전대비 (82)
		/// </summary>
		[JsonProperty("82")]
		public decimal? SellPriceChange2;
		/// <summary>
		/// 매수2호가 (52)
		/// </summary>
		[JsonProperty("52")]
		public KiwoomDecimal? BuyPrice2;
		/// <summary>
		/// 매수2호가잔량 (72)
		/// </summary>
		[JsonProperty("72")]
		public decimal? BuyQuantity2;
		/// <summary>
		/// 매수2호가직전대비 (92)
		/// </summary>
		[JsonProperty("92")]
		public decimal? BuyPriceChange2;
		/// <summary>
		/// 매도3호가 (43)
		/// </summary>
		[JsonProperty("43")]
		public KiwoomDecimal? SellPrice3;
		/// <summary>
		/// 매도3호가잔량 (63)
		/// </summary>
		[JsonProperty("63")]
		public decimal? SellQuantity3;
		/// <summary>
		/// 매도3호가직전대비 (83)
		/// </summary>
		[JsonProperty("83")]
		public decimal? SellPriceChange3;
		/// <summary>
		/// 매수3호가 (53)
		/// </summary>
		[JsonProperty("53")]
		public KiwoomDecimal? BuyPrice3;
		/// <summary>
		/// 매수3호가잔량 (73)
		/// </summary>
		[JsonProperty("73")]
		public decimal? BuyQuantity3;
		/// <summary>
		/// 매수3호가직전대비 (93)
		/// </summary>
		[JsonProperty("93")]
		public decimal? BuyPriceChange3;
		/// <summary>
		/// 매도4호가 (44)
		/// </summary>
		[JsonProperty("44")]
		public KiwoomDecimal? SellPrice4;
		/// <summary>
		/// 매도4호가잔량 (64)
		/// </summary>
		[JsonProperty("64")]
		public decimal? SellQuantity4;
		/// <summary>
		/// 매도4호가직전대비 (84)
		/// </summary>
		[JsonProperty("84")]
		public decimal? SellPriceChange4;
		/// <summary>
		/// 매수4호가 (54)
		/// </summary>
		[JsonProperty("54")]
		public KiwoomDecimal? BuyPrice4;
		/// <summary>
		/// 매수4호가잔량 (74)
		/// </summary>
		[JsonProperty("74")]
		public decimal? BuyQuantity4;
		/// <summary>
		/// 매수4호가직전대비 (94)
		/// </summary>
		[JsonProperty("94")]
		public decimal? BuyPriceChange4;
		/// <summary>
		/// 매도5호가 (45)
		/// </summary>
		[JsonProperty("45")]
		public KiwoomDecimal? SellPrice5;
		/// <summary>
		/// 매도5호가잔량 (65)
		/// </summary>
		[JsonProperty("65")]
		public decimal? SellQuantity5;
		/// <summary>
		/// 매도5호가직전대비 (85)
		/// </summary>
		[JsonProperty("85")]
		public decimal? SellPriceChange5;
		/// <summary>
		/// 매수5호가 (55)
		/// </summary>
		[JsonProperty("55")]
		public KiwoomDecimal? BuyPrice5;
		/// <summary>
		/// 매수5호가잔량 (75)
		/// </summary>
		[JsonProperty("75")]
		public decimal? BuyQuantity5;
		/// <summary>
		/// 매수5호가직전대비 (95)
		/// </summary>
		[JsonProperty("95")]
		public decimal? BuyPriceChange5;
		/// <summary>
		/// 매도6호가 (46)
		/// </summary>
		[JsonProperty("46")]
		public KiwoomDecimal? SellPrice6;
		/// <summary>
		/// 매도6호가잔량 (66)
		/// </summary>
		[JsonProperty("66")]
		public decimal? SellQuantity6;
		/// <summary>
		/// 매도6호가직전대비 (86)
		/// </summary>
		[JsonProperty("86")]
		public decimal? SellPriceChange6;
		/// <summary>
		/// 매수6호가 (56)
		/// </summary>
		[JsonProperty("56")]
		public KiwoomDecimal? BuyPrice6;
		/// <summary>
		/// 매수6호가잔량 (76)
		/// </summary>
		[JsonProperty("76")]
		public decimal? BuyQuantity6;
		/// <summary>
		/// 매수6호가직전대비 (96)
		/// </summary>
		[JsonProperty("96")]
		public decimal? BuyPriceChange6;
		/// <summary>
		/// 매도7호가 (47)
		/// </summary>
		[JsonProperty("47")]
		public KiwoomDecimal? SellPrice7;
		/// <summary>
		/// 매도7호가잔량 (67)
		/// </summary>
		[JsonProperty("67")]
		public decimal? SellQuantity7;
		/// <summary>
		/// 매도7호가직전대비 (87)
		/// </summary>
		[JsonProperty("87")]
		public decimal? SellPriceChange7;
		/// <summary>
		/// 매수7호가 (57)
		/// </summary>
		[JsonProperty("57")]
		public KiwoomDecimal? BuyPrice7;
		/// <summary>
		/// 매수7호가잔량 (77)
		/// </summary>
		[JsonProperty("77")]
		public decimal? BuyQuantity7;
		/// <summary>
		/// 매수7호가직전대비 (97)
		/// </summary>
		[JsonProperty("97")]
		public decimal? BuyPriceChange7;
		/// <summary>
		/// 매도8호가 (48)
		/// </summary>
		[JsonProperty("48")]
		public KiwoomDecimal? SellPrice8;
		/// <summary>
		/// 매도8호가잔량 (68)
		/// </summary>
		[JsonProperty("68")]
		public decimal? SellQuantity8;
		/// <summary>
		/// 매도8호가직전대비 (88)
		/// </summary>
		[JsonProperty("88")]
		public decimal? SellPriceChange8;
		/// <summary>
		/// 매수8호가 (58)
		/// </summary>
		[JsonProperty("58")]
		public KiwoomDecimal? BuyPrice8;
		/// <summary>
		/// 매수8호가잔량 (78)
		/// </summary>
		[JsonProperty("78")]
		public decimal? BuyQuantity8;
		/// <summary>
		/// 매수8호가직전대비 (98)
		/// </summary>
		[JsonProperty("98")]
		public decimal? BuyPriceChange8;
		/// <summary>
		/// 매도9호가 (49)
		/// </summary>
		[JsonProperty("49")]
		public KiwoomDecimal? SellPrice9;
		/// <summary>
		/// 매도9호가잔량 (69)
		/// </summary>
		[JsonProperty("69")]
		public decimal? SellQuantity9;
		/// <summary>
		/// 매도9호가직전대비 (89)
		/// </summary>
		[JsonProperty("89")]
		public decimal? SellPriceChange9;
		/// <summary>
		/// 매수9호가 (59)
		/// </summary>
		[JsonProperty("59")]
		public KiwoomDecimal? BuyPrice9;
		/// <summary>
		/// 매수9호가잔량 (79)
		/// </summary>
		[JsonProperty("79")]
		public decimal? BuyQuantity9;
		/// <summary>
		/// 매수9호가직전대비 (99)
		/// </summary>
		[JsonProperty("99")]
		public decimal? BuyPriceChange9;
		/// <summary>
		/// 매도10호가 (50)
		/// </summary>
		[JsonProperty("50")]
		public KiwoomDecimal? SellPrice10;
		/// <summary>
		/// 매도10호가잔량 (70)
		/// </summary>
		[JsonProperty("70")]
		public decimal? SellQuantity10;
		/// <summary>
		/// 매도10호가직전대비 (90)
		/// </summary>
		[JsonProperty("90")]
		public decimal? SellPriceChange10;
		/// <summary>
		/// 매수10호가 (60)
		/// </summary>
		[JsonProperty("60")]
		public KiwoomDecimal? BuyPrice10;
		/// <summary>
		/// 매수10호가잔량 (80)
		/// </summary>
		[JsonProperty("80")]
		public decimal? BuyQuantity10;
		/// <summary>
		/// 매수10호가직전대비 (100)
		/// </summary>
		[JsonProperty("100")]
		public decimal? BuyPriceChange10;
		/// <summary>
		/// 매도호가총잔량 (121)
		/// </summary>
		[JsonProperty("121")]
		public decimal? TotalSellQuantity;
		/// <summary>
		/// 매도호가총잔량직전대비 (122)
		/// </summary>
		[JsonProperty("122")]
		public decimal? TotalSellQuantityChange;
		/// <summary>
		/// 매수호가총잔량 (125)
		/// </summary>
		[JsonProperty("125")]
		public decimal? TotalBuyQuantity;
		/// <summary>
		/// 매수호가총잔량직전대비 (126)
		/// </summary>
		[JsonProperty("126")]
		public decimal? TotalBuyQuantityChange;
	}

	/// <summary>
	/// | usa20281 | 미국주식 조건검색 요청 일반 결과 항목
	/// </summary>
	public record KiwoomUsStockWebSocketConditionSearchRequest
	{
		/// <summary>
		/// 거래소구분
		/// </summary>
		[JsonProperty("stex_tp")]
		public string? ExchangeType;
		/// <summary>
		/// 종목코드 (9001)
		/// </summary>
		[JsonProperty("9001")]
		public string? StockCode;
		/// <summary>
		/// 종목명 (302)
		/// </summary>
		[JsonProperty("302")]
		public string? StockName;
		/// <summary>
		/// 현재가 (10)
		/// </summary>
		[JsonProperty("10")]
		public string? CurrentPrice;
		/// <summary>
		/// 전일대비기호 (25)
		/// </summary>
		[JsonProperty("25")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비 (11)
		/// </summary>
		[JsonProperty("11")]
		public string? Change;
		/// <summary>
		/// 등락율 (12)
		/// </summary>
		[JsonProperty("12")]
		public string? ChangeRate;
		/// <summary>
		/// 누적거래량 (13)
		/// </summary>
		[JsonProperty("13")]
		public string? AccumulatedVolume;
		/// <summary>
		/// 시가 (16)
		/// </summary>
		[JsonProperty("16")]
		public string? Open;
		/// <summary>
		/// 고가 (17)
		/// </summary>
		[JsonProperty("17")]
		public string? High;
		/// <summary>
		/// 저가 (18)
		/// </summary>
		[JsonProperty("18")]
		public string? Low;
		/// <summary>
		/// 미공개 필드 (318)
		/// </summary>
		[JsonProperty("318")]
		public string? Field318;
	}
}
