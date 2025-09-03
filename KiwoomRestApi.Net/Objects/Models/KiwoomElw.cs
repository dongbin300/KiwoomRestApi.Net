using KiwoomRestApi.Net.Converters;
using KiwoomRestApi.Net.Objects.Commons;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models
{
	public record KiwoomElwGetDailySensitivityIndices
	{
		/// <summary>
		/// ELW일별민감도지표
		/// </summary>
		[JsonProperty("elwdaly_snst_ix")]
		public IEnumerable<KiwoomElwGetDailySensitivityIndexItem>? Items;
	}
	public record KiwoomElwGetDailySensitivityIndexItem
	{
		/// <summary>
		/// 일자
		/// </summary>
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		/// <summary>
		/// IV
		/// </summary>
		[JsonProperty("iv")]
		public decimal? Iv;
		/// <summary>
		/// 델타
		/// </summary>
		[JsonProperty("delta")]
		public decimal? Delta;
		/// <summary>
		/// 감마
		/// </summary>
		[JsonProperty("gam")]
		public decimal? Gamma;
		/// <summary>
		/// 썸타
		/// </summary>
		[JsonProperty("theta")]
		public decimal? Theta;
		/// <summary>
		/// 베가
		/// </summary>
		[JsonProperty("vega")]
		public decimal? Vega;
		/// <summary>
		/// 로
		/// </summary>
		[JsonProperty("law")]
		public decimal? Law;
		/// <summary>
		/// LP
		/// </summary>
		[JsonProperty("lp")]
		public decimal? Lp;
	}

	public record KiwoomElwGetSensitivityIndeices
	{
		/// <summary>
		/// ELW민감도지표배열
		/// </summary>
		[JsonProperty("elwsnst_ix_array")]
		public IEnumerable<KiwoomElwGetSensitivityIndexItem>? Items;
	}
	public record KiwoomElwGetSensitivityIndexItem
	{
		/// <summary>
		/// 체결시간
		/// </summary>
		[JsonProperty("cntr_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? ContractTime;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		/// <summary>
		/// ELW이론가
		/// </summary>
		[JsonProperty("elwtheory_pric")]
		public decimal? ElwTheoryPrice;
		/// <summary>
		/// IV
		/// </summary>
		[JsonProperty("iv")]
		public decimal? Iv;
		/// <summary>
		/// 델타
		/// </summary>
		[JsonProperty("delta")]
		public decimal? Delta;
		/// <summary>
		/// 감마
		/// </summary>
		[JsonProperty("gam")]
		public decimal? Gamma;
		/// <summary>
		/// 쎄타
		/// </summary>
		[JsonProperty("theta")]
		public decimal? Theta;
		/// <summary>
		/// 베가
		/// </summary>
		[JsonProperty("vega")]
		public decimal? Vega;
		/// <summary>
		/// 로
		/// </summary>
		[JsonProperty("law")]
		public decimal? Law;
		/// <summary>
		/// LP
		/// </summary>
		[JsonProperty("lp")]
		public decimal? Lp;
	}

	public record KiwoomElwGetPriceJumpFluctuations
	{
		/// <summary>
		/// 기준가시간
		/// </summary>
		[JsonProperty("base_pric_tm")]
		public string? BasePriceTime;
		/// <summary>
		/// ELW가격급등락
		/// </summary>
		[JsonProperty("elwpric_jmpflu")]
		public IEnumerable<KiwoomElwGetPriceJumpFluctuationItem>? Items;
	}
	public record KiwoomElwGetPriceJumpFluctuationItem
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 순위
		/// </summary>
		[JsonProperty("rank")]
		public int? Rank;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 대비기호
		/// </summary>
		[JsonProperty("pre_sig")]
		public string? PreviousSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		/// <summary>
		/// 거래종료ELW기준가
		/// </summary>
		[JsonProperty("trde_end_elwbase_pric")]
		public decimal? TradeEndElwBasePrice;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		/// <summary>
		/// 기준대비
		/// </summary>
		[JsonProperty("base_pre")]
		public decimal? BaseDifference;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? TradeVolume;
		/// <summary>
		/// 급등율
		/// </summary>
		[JsonProperty("jmp_rt")]
		public decimal? JumpRate;
	}

	public record KiwoomElwGetNetTradeTopByTraders
	{
		/// <summary>
		/// 거래원별ELW순매매상위
		/// </summary>
		[JsonProperty("trde_ori_elwnettrde_upper")]
		public IEnumerable<KiwoomElwGetNetTradeTopByTraderItem>? Items;
	}
	public record KiwoomElwGetNetTradeTopByTraderItem
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 주가등락
		/// </summary>
		[JsonProperty("stkpc_flu")]
		public KiwoomDecimal? PriceFluctuation;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? TradeVolume;
		/// <summary>
		/// 순매수
		/// </summary>
		[JsonProperty("netprps")]
		public decimal? NetPurchase;
		/// <summary>
		/// 매수거래량
		/// </summary>
		[JsonProperty("buy_trde_qty")]
		public decimal? BuyTradeVolume;
		/// <summary>
		/// 매도거래량
		/// </summary>
		[JsonProperty("sel_trde_qty")]
		public decimal? SellTradeVolume;
	}

	public record KiwoomElwGetLpHoldingDailyTrends
	{
		/// <summary>
		/// ELWLP보유일별추이
		/// </summary>
		[JsonProperty("elwlpposs_daly_trnsn")]
		public IEnumerable<KiwoomElwGetLpHoldingDailyTrendItem>? Items;
	}
	public record KiwoomElwGetLpHoldingDailyTrendItem
	{
		/// <summary>
		/// 일자
		/// </summary>
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		/// <summary>
		/// 대비구분
		/// </summary>
		[JsonProperty("pre_tp")]
		public string? DifferenceType;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? TradeVolume;
		/// <summary>
		/// 거래대금
		/// </summary>
		[JsonProperty("trde_prica")]
		public decimal? TradeAmount;
		/// <summary>
		/// 변동수량
		/// </summary>
		[JsonProperty("chg_qty")]
		public decimal? ChangeQuantity;
		/// <summary>
		/// LP보유수량
		/// </summary>
		[JsonProperty("lprmnd_qty")]
		public decimal? LpHoldingQuantity;
		/// <summary>
		/// 비중
		/// </summary>
		[JsonProperty("wght")]
		public decimal? Weight;
	}

	public record KiwoomElwGetDisparityRates
	{
		/// <summary>
		/// ELW괴리율
		/// </summary>
		[JsonProperty("elwdispty_rt")]
		public IEnumerable<KiwoomElwGetDisparityRateItem>? Items;
	}
	public record KiwoomElwGetDisparityRateItem
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 발행사명
		/// </summary>
		[JsonProperty("isscomp_nm")]
		public string? IssuerCompanyName;
		/// <summary>
		/// 회차
		/// </summary>
		[JsonProperty("sqnc")]
		public string? Sequence;
		/// <summary>
		/// 기초자산명
		/// </summary>
		[JsonProperty("base_aset_nm")]
		public string? BaseAssetName;
		/// <summary>
		/// 권리구분
		/// </summary>
		[JsonProperty("rght_tp")]
		public string? RightType;
		/// <summary>
		/// 괴리율
		/// </summary>
		[JsonProperty("dispty_rt")]
		public KiwoomDecimal? DisparityRate;
		/// <summary>
		/// 베이시스
		/// </summary>
		[JsonProperty("basis")]
		public KiwoomDecimal? Basis;
		/// <summary>
		/// 잔존일수
		/// </summary>
		[JsonProperty("srvive_dys")]
		public int? RemainingDays;
		/// <summary>
		/// 이론가
		/// </summary>
		[JsonProperty("theory_pric")]
		public decimal? TheoryPrice;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		/// <summary>
		/// 대비구분
		/// </summary>
		[JsonProperty("pre_tp")]
		public string? DifferenceType;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? TradeVolume;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
	}

	public record KiwoomElwGetConditionSearchs
	{
		/// <summary>
		/// ELW조건검색
		/// </summary>
		[JsonProperty("elwcnd_qry")]
		public IEnumerable<KiwoomElwGetConditionSearchItem>? Items;
	}
	public record KiwoomElwGetConditionSearchItem
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 발행사명
		/// </summary>
		[JsonProperty("isscomp_nm")]
		public string? IssuerCompanyName;
		/// <summary>
		/// 회차
		/// </summary>
		[JsonProperty("sqnc")]
		public string? Sequence;
		/// <summary>
		/// 기초자산명
		/// </summary>
		[JsonProperty("base_aset_nm")]
		public string? BaseAssetName;
		/// <summary>
		/// 권리구분
		/// </summary>
		[JsonProperty("rght_tp")]
		public string? RightType;
		/// <summary>
		/// 만기일
		/// </summary>
		[JsonProperty("expr_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? ExpirationDate;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		/// <summary>
		/// 대비구분
		/// </summary>
		[JsonProperty("pre_tp")]
		public string? DifferenceType;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? TradeVolume;
		/// <summary>
		/// 거래량대비
		/// </summary>
		[JsonProperty("trde_qty_pre")]
		public decimal? TradeVolumeCompared;
		/// <summary>
		/// 거래대금
		/// </summary>
		[JsonProperty("trde_prica")]
		public decimal? TradeAmount;
		/// <summary>
		/// 전일거래량
		/// </summary>
		[JsonProperty("pred_trde_qty")]
		public decimal? PreviousTradeVolume;
		/// <summary>
		/// 매도호가
		/// </summary>
		[JsonProperty("sel_bid")]
		public decimal? SellBidPrice;
		/// <summary>
		/// 매수호가
		/// </summary>
		[JsonProperty("buy_bid")]
		public decimal? BuyBidPrice;
		/// <summary>
		/// 패리티
		/// </summary>
		[JsonProperty("prty")]
		public decimal? Parity;
		/// <summary>
		/// 기어링비율
		/// </summary>
		[JsonProperty("gear_rt")]
		public decimal? GearingRatio;
		/// <summary>
		/// 손익분기율
		/// </summary>
		[JsonProperty("pl_qutr_rt")]
		public decimal? BreakEvenRatio;
		/// <summary>
		/// 자본지지점
		/// </summary>
		[JsonProperty("cfp")]
		public decimal? CapitalSupportPoint;
		/// <summary>
		/// 이론가
		/// </summary>
		[JsonProperty("theory_pric")]
		public decimal? TheoryPrice;
		/// <summary>
		/// 내재변동성
		/// </summary>
		[JsonProperty("innr_vltl")]
		public decimal? ImpliedVolatility;
		/// <summary>
		/// 델타
		/// </summary>
		[JsonProperty("delta")]
		public decimal? Delta;
		/// <summary>
		/// 레버리지
		/// </summary>
		[JsonProperty("lvrg")]
		public decimal? Leverage;
		/// <summary>
		/// 행사가격
		/// </summary>
		[JsonProperty("exec_pric")]
		public decimal? ExercisePrice;
		/// <summary>
		/// 전환비율
		/// </summary>
		[JsonProperty("cnvt_rt")]
		public decimal? ConversionRatio;
		/// <summary>
		/// LP보유비율
		/// </summary>
		[JsonProperty("lpposs_rt")]
		public decimal? LpHoldingRate;
		/// <summary>
		/// 손익분기점
		/// </summary>
		[JsonProperty("pl_qutr_pt")]
		public decimal? BreakEvenPoint;
		/// <summary>
		/// 최종거래일
		/// </summary>
		[JsonProperty("fin_trde_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? FinalTradeDate;
		/// <summary>
		/// 상장일
		/// </summary>
		[JsonProperty("flo_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? ListingDate;
		/// <summary>
		/// LP초종공급일
		/// </summary>
		[JsonProperty("lpinitlast_suply_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? LpInitialLastSupplyDate;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 잔존일수
		/// </summary>
		[JsonProperty("srvive_dys")]
		public int? RemainingDays;
		/// <summary>
		/// 괴리율
		/// </summary>
		[JsonProperty("dispty_rt")]
		public decimal? DisparityRate;
		/// <summary>
		/// LP회원사명
		/// </summary>
		[JsonProperty("lpmmcm_nm")]
		public string? LpMemberName;
		/// <summary>
		/// LP회원사명1
		/// </summary>
		[JsonProperty("lpmmcm_nm_1")]
		public string? LpMemberName1;
		/// <summary>
		/// LP회원사명2
		/// </summary>
		[JsonProperty("lpmmcm_nm_2")]
		public string? LpMemberName2;
		/// <summary>
		/// Xray순간체결량정리매매구분
		/// </summary>
		[JsonProperty("xraymont_cntr_qty_arng_trde_tp")]
		public string? XrayInstantTradeClassification;
		/// <summary>
		/// Xray순간체결량증거금100구분
		/// </summary>
		[JsonProperty("xraymont_cntr_qty_profa_100tp")]
		public string? XrayInstantTradeMargin100Classification;
	}

	public record KiwoomElwGetFluctuationRateRanks
	{
		/// <summary>
		/// ELW등락율순위
		/// </summary>
		[JsonProperty("elwflu_rt_rank")]
		public IEnumerable<KiwoomElwGetFluctuationRateRankItem>? Items;
	}
	public record KiwoomElwGetFluctuationRateRankItem
	{
		/// <summary>
		/// 순위
		/// </summary>
		[JsonProperty("rank")]
		public int? Rank;
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		/// <summary>
		/// 대비기호
		/// </summary>
		[JsonProperty("pre_sig")]
		public string? DifferenceSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		/// <summary>
		/// 매도잔량
		/// </summary>
		[JsonProperty("sel_req")]
		public decimal? SellRequestVolume;
		/// <summary>
		/// 매수잔량
		/// </summary>
		[JsonProperty("buy_req")]
		public decimal? BuyRequestVolume;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? TradeVolume;
		/// <summary>
		/// 거래대금
		/// </summary>
		[JsonProperty("trde_prica")]
		public decimal? TradeAmount;
	}

	public record KiwoomElwGetRequestRanks
	{
		/// <summary>
		/// ELW잔량순위
		/// </summary>
		[JsonProperty("elwreq_rank")]
		public IEnumerable<KiwoomElwGetRequestRankItem>? Items;
	}
	public record KiwoomElwGetRequestRankItem
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 순위
		/// </summary>
		[JsonProperty("rank")]
		public int? Rank;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		/// <summary>
		/// 대비기호
		/// </summary>
		[JsonProperty("pre_sig")]
		public string? DifferenceSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? TradeVolume;
		/// <summary>
		/// 매도잔량
		/// </summary>
		[JsonProperty("sel_req")]
		public decimal? SellRequestVolume;
		/// <summary>
		/// 매수잔량
		/// </summary>
		[JsonProperty("buy_req")]
		public decimal? BuyRequestVolume;
		/// <summary>
		/// 순매수잔량
		/// </summary>
		[JsonProperty("netprps_req")]
		public decimal? NetPurchaseRequestVolume;
		/// <summary>
		/// 거래대금
		/// </summary>
		[JsonProperty("trde_prica")]
		public decimal? TradeAmount;
	}

	public record KiwoomElwGetProximityRates
	{
		/// <summary>
		/// ELW근접율
		/// </summary>
		[JsonProperty("elwalacc_rt")]
		public IEnumerable<KiwoomElwGetProximityRateItem>? Items;
	}
	public record KiwoomElwGetProximityRateItem
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		/// <summary>
		/// 대비기호
		/// </summary>
		[JsonProperty("pre_sig")]
		public string? DifferenceSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? AccumulatedTradeVolume;
		/// <summary>
		/// 근접율
		/// </summary>
		[JsonProperty("alacc_rt")]
		public decimal? ProximityRate;
	}

	public record KiwoomElwGetAssetInfo
	{
		/// <summary>
		/// 자산코드
		/// </summary>
		[JsonProperty("aset_cd")]
		public string? AssetCode;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public decimal? CurrentPrice;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? PreviousDifferenceSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public decimal? PreviousDifference;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public decimal? FluctuationRate;
		/// <summary>
		/// LP회원사명
		/// </summary>
		[JsonProperty("lpmmcm_nm")]
		public string? LpMemberName;
		/// <summary>
		/// LP회원사명1
		/// </summary>
		[JsonProperty("lpmmcm_nm_1")]
		public string? LpMemberName1;
		/// <summary>
		/// LP회원사명2
		/// </summary>
		[JsonProperty("lpmmcm_nm_2")]
		public string? LpMemberName2;
		/// <summary>
		/// ELW권리내용
		/// </summary>
		[JsonProperty("elwrght_cntn")]
		public string? ElwRightContent;
		/// <summary>
		/// ELW만기평가가격
		/// </summary>
		[JsonProperty("elwexpr_evlt_pric")]
		public decimal? ElwExpirationEvaluationPrice;
		/// <summary>
		/// ELW이론가
		/// </summary>
		[JsonProperty("elwtheory_pric")]
		public decimal? ElwTheoryPrice;
		/// <summary>
		/// 괴리율
		/// </summary>
		[JsonProperty("dispty_rt")]
		public decimal? DisparityRate;
		/// <summary>
		/// ELW내재변동성
		/// </summary>
		[JsonProperty("elwinnr_vltl")]
		public decimal? ElwImpliedVolatility;
		/// <summary>
		/// 예상권리가
		/// </summary>
		[JsonProperty("exp_rght_pric")]
		public decimal? ExpectedRightPrice;
		/// <summary>
		/// ELW손익분기율
		/// </summary>
		[JsonProperty("elwpl_qutr_rt")]
		public decimal? ElwBreakEvenRatio;
		/// <summary>
		/// ELW행사가
		/// </summary>
		[JsonProperty("elwexec_pric")]
		public decimal? ElwExercisePrice;
		/// <summary>
		/// ELW전환비율
		/// </summary>
		[JsonProperty("elwcnvt_rt")]
		public decimal? ElwConversionRatio;
		/// <summary>
		/// ELW보상율
		/// </summary>
		[JsonProperty("elwcmpn_rt")]
		public decimal? ElwCompensationRatio;
		/// <summary>
		/// ELW가격상승참여율
		/// </summary>
		[JsonProperty("elwpric_rising_part_rt")]
		public decimal? ElwPriceRisingParticipationRate;
		/// <summary>
		/// ELW권리유형
		/// </summary>
		[JsonProperty("elwrght_type")]
		public string? ElwRightType;
		/// <summary>
		/// ELW잔존일수
		/// </summary>
		[JsonProperty("elwsrvive_dys")]
		public int? ElwRemainingDays;
		/// <summary>
		/// 주식수
		/// </summary>
		[JsonProperty("stkcnt")]
		public int? StockCount;
		/// <summary>
		/// ELWLP주문가능
		/// </summary>
		[JsonProperty("elwlpord_pos")]
		public string? ElwLpOrderPossible;
		/// <summary>
		/// LP보유비율
		/// </summary>
		[JsonProperty("lpposs_rt")]
		public decimal? LpHoldingRate;
		/// <summary>
		/// LP보유수량
		/// </summary>
		[JsonProperty("lprmnd_qty")]
		public decimal? LpHoldingQuantity;
		/// <summary>
		/// ELW스프레드
		/// </summary>
		[JsonProperty("elwspread")]
		public decimal? ElwSpread;
		/// <summary>
		/// ELW패리티
		/// </summary>
		[JsonProperty("elwprty")]
		public decimal? ElwParity;
		/// <summary>
		/// ELW기어링
		/// </summary>
		[JsonProperty("elwgear")]
		public decimal? ElwGearing;
		/// <summary>
		/// ELW상장일
		/// </summary>
		[JsonProperty("elwflo_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? ElwListingDate;
		/// <summary>
		/// ELW최종거래일
		/// </summary>
		[JsonProperty("elwfin_trde_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? ElwFinalTradeDate;
		/// <summary>
		/// 만기일
		/// </summary>
		[JsonProperty("expr_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? ExpirationDate;
		/// <summary>
		/// 행사일
		/// </summary>
		[JsonProperty("exec_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? ExerciseDate;
		/// <summary>
		/// LP공급종료일
		/// </summary>
		[JsonProperty("lpsuply_end_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? LpSupplyEndDate;
		/// <summary>
		/// ELW지급일
		/// </summary>
		[JsonProperty("elwpay_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? ElwPaymentDate;
		/// <summary>
		/// ELW투자지표산출
		/// </summary>
		[JsonProperty("elwinvt_ix_comput")]
		public string? ElwInvestmentIndexComputation;
		/// <summary>
		/// ELW지급대리인
		/// </summary>
		[JsonProperty("elwpay_agnt")]
		public string? ElwPaymentAgent;
		/// <summary>
		/// ELW결재방법
		/// </summary>
		[JsonProperty("elwappr_way")]
		public string? ElwApprovalMethod;
		/// <summary>
		/// ELW권리행사방식
		/// </summary>
		[JsonProperty("elwrght_exec_way")]
		public string? ElwRightExerciseMethod;
		/// <summary>
		/// ELW발행기관
		/// </summary>
		[JsonProperty("elwpblicte_orgn")]
		public string? ElwIssuingInstitution;
		/// <summary>
		/// 확정지급액
		/// </summary>
		[JsonProperty("dcsn_pay_amt")]
		public decimal? DecisionPaymentAmount;
		/// <summary>
		/// KO베리어
		/// </summary>
		[JsonProperty("kobarr")]
		public string? KoBarrier;
		/// <summary>
		/// IV
		/// </summary>
		[JsonProperty("iv")]
		public decimal? ImpliedVolatility;
		/// <summary>
		/// 종기종료ELW발생
		/// </summary>
		[JsonProperty("clsprd_end_elwocr")]
		public string? ClosingPeriodEndElwOccurrence;
		/// <summary>
		/// 기초자산1
		/// </summary>
		[JsonProperty("bsis_aset_1")]
		public string? BaseAsset1;
		/// <summary>
		/// 기초자산구성비율1
		/// </summary>
		[JsonProperty("bsis_aset_comp_rt_1")]
		public decimal? BaseAssetCompositionRate1;
		/// <summary>
		/// 기초자산2
		/// </summary>
		[JsonProperty("bsis_aset_2")]
		public string? BaseAsset2;
		/// <summary>
		/// 기초자산구성비율2
		/// </summary>
		[JsonProperty("bsis_aset_comp_rt_2")]
		public decimal? BaseAssetCompositionRate2;
		/// <summary>
		/// 기초자산3
		/// </summary>
		[JsonProperty("bsis_aset_3")]
		public string? BaseAsset3;
		/// <summary>
		/// 기초자산구성비율3
		/// </summary>
		[JsonProperty("bsis_aset_comp_rt_3")]
		public decimal? BaseAssetCompositionRate3;
		/// <summary>
		/// 기초자산4
		/// </summary>
		[JsonProperty("bsis_aset_4")]
		public string? BaseAsset4;
		/// <summary>
		/// 기초자산구성비율4
		/// </summary>
		[JsonProperty("bsis_aset_comp_rt_4")]
		public decimal? BaseAssetCompositionRate4;
		/// <summary>
		/// 기초자산5
		/// </summary>
		[JsonProperty("bsis_aset_5")]
		public string? BaseAsset5;
		/// <summary>
		/// 기초자산구성비율5
		/// </summary>
		[JsonProperty("bsis_aset_comp_rt_5")]
		public decimal? BaseAssetCompositionRate5;
		/// <summary>
		/// 평가시작일자
		/// </summary>
		[JsonProperty("fr_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? EvaluationStartDate;
		/// <summary>
		/// 평가종료일자
		/// </summary>
		[JsonProperty("to_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? EvaluationEndDate;
		/// <summary>
		/// 평가시작시간
		/// </summary>
		[JsonProperty("fr_tm")]
		public string? EvaluationStartTime;
		/// <summary>
		/// 평가종료시간
		/// </summary>
		[JsonProperty("evlt_end_tm")]
		public string? EvaluationEndTime;
		/// <summary>
		/// 평가가격
		/// </summary>
		[JsonProperty("evlt_pric")]
		public decimal? EvaluationPrice;
		/// <summary>
		/// 평가완료여부
		/// </summary>
		[JsonProperty("evlt_fnsh_yn")]
		public string? EvaluationFinishedYn;
		/// <summary>
		/// 전체최고가
		/// </summary>
		[JsonProperty("all_hgst_pric")]
		public decimal? AllTimeHighPrice;
		/// <summary>
		/// 전체최저가
		/// </summary>
		[JsonProperty("all_lwst_pric")]
		public decimal? AllTimeLowPrice;
		/// <summary>
		/// 직후최고가
		/// </summary>
		[JsonProperty("imaf_hgst_pric")]
		public decimal? ImmediateAfterHighPrice;
		/// <summary>
		/// 직후최저가
		/// </summary>
		[JsonProperty("imaf_lwst_pric")]
		public decimal? ImmediateAfterLowPrice;
		/// <summary>
		/// 후반장최고가
		/// </summary>
		[JsonProperty("sndhalf_mrkt_hgst_pric")]
		public decimal? SecondHalfMarketHighPrice;
		/// <summary>
		/// 후반장최저가
		/// </summary>
		[JsonProperty("sndhalf_mrkt_lwst_pric")]
		public decimal? SecondHalfMarketLowPrice;
	}
}
