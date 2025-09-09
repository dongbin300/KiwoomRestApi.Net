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
		public decimal? ImpliedVolatility;
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
		public KiwoomDecimal? Theta;
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
		public TimeSpan? TradeTime;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// ELW이론가
		/// </summary>
		[JsonProperty("elwtheory_pric")]
		public decimal? ElwTheoryPrice;
		/// <summary>
		/// IV
		/// </summary>
		[JsonProperty("iv")]
		public decimal? ImpliedVolatility;
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
		public KiwoomDecimal? Theta;
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

	public record KiwoomElwGetPriceVolatilities
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
		public IEnumerable<KiwoomElwGetPriceVolatilityItem>? Items;
	}
	public record KiwoomElwGetPriceVolatilityItem
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
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 거래종료ELW기준가
		/// </summary>
		[JsonProperty("trde_end_elwbase_pric")]
		public decimal? TransactionEndElwBasePrice;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 기준대비
		/// </summary>
		[JsonProperty("base_pre")]
		public KiwoomDecimal? BaseChange;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 급등율
		/// </summary>
		[JsonProperty("jmp_rt")]
		public decimal? SurgeRate;
	}

	public record KiwoomElwGetBrokerNetTransactionTops
	{
		/// <summary>
		/// 거래원별ELW순매매상위
		/// </summary>
		[JsonProperty("trde_ori_elwnettrde_upper")]
		public IEnumerable<KiwoomElwGetBrokerNetTransactionTopItem>? Items;
	}
	public record KiwoomElwGetBrokerNetTransactionTopItem
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
		public KiwoomDecimal? Change;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 순매수
		/// </summary>
		[JsonProperty("netprps")]
		public KiwoomDecimal? NetBuy;
		/// <summary>
		/// 매수거래량
		/// </summary>
		[JsonProperty("buy_trde_qty")]
		public KiwoomDecimal? BuyVolume;
		/// <summary>
		/// 매도거래량
		/// </summary>
		[JsonProperty("sel_trde_qty")]
		public KiwoomDecimal? SellVolume;
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
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 대비구분
		/// </summary>
		[JsonProperty("pre_tp")]
		public string? ChangeType;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 거래대금
		/// </summary>
		[JsonProperty("trde_prica")]
		public decimal? TransactionAmount;
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
		public KiwoomDecimal? Weight;
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
		public string? IssuerName;
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
		public string? RightsType;
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
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 대비구분
		/// </summary>
		[JsonProperty("pre_tp")]
		public string? ChangeType;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? Volume;
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
		public string? IssuerName;
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
		public string? RightsType;
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
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 대비구분
		/// </summary>
		[JsonProperty("pre_tp")]
		public string? ChangeType;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 거래량대비
		/// </summary>
		[JsonProperty("trde_qty_pre")]
		public decimal? VolumeChange;
		/// <summary>
		/// 거래대금
		/// </summary>
		[JsonProperty("trde_prica")]
		public decimal? TransactionAmount;
		/// <summary>
		/// 전일거래량
		/// </summary>
		[JsonProperty("pred_trde_qty")]
		public decimal? PreviousDayVolume;
		/// <summary>
		/// 매도호가
		/// </summary>
		[JsonProperty("sel_bid")]
		public decimal? SellPrice;
		/// <summary>
		/// 매수호가
		/// </summary>
		[JsonProperty("buy_bid")]
		public decimal? BuyPrice;
		/// <summary>
		/// 패리티
		/// </summary>
		[JsonProperty("prty")]
		public decimal? Parity;
		/// <summary>
		/// 기어링비율
		/// </summary>
		[JsonProperty("gear_rt")]
		public decimal? GearingRate;
		/// <summary>
		/// 손익분기율
		/// </summary>
		[JsonProperty("pl_qutr_rt")]
		public KiwoomDecimal? BreakEvenRate;
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
		public decimal? ConversionRate;
		/// <summary>
		/// LP보유비율
		/// </summary>
		[JsonProperty("lpposs_rt")]
		public KiwoomDecimal? LpHoldingRate;
		/// <summary>
		/// 손익분기점
		/// </summary>
		[JsonProperty("pl_qutr_pt")]
		public KiwoomDecimal? BreakEvenPoint;
		/// <summary>
		/// 최종거래일
		/// </summary>
		[JsonProperty("fin_trde_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? FinalTransactionDate;
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
		public DateTime? LpStartEndSupplyDate;
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
		public KiwoomDecimal? DisparityRate;
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
		public string? XrayInstantTradeVolumeType;
		/// <summary>
		/// Xray순간체결량증거금100구분
		/// </summary>
		[JsonProperty("xraymont_cntr_qty_profa_100tp")]
		public string? XrayInstantTradeVolumeMargin100Type;
	}

	public record KiwoomElwGetChangeRateRanks
	{
		/// <summary>
		/// ELW등락율순위
		/// </summary>
		[JsonProperty("elwflu_rt_rank")]
		public IEnumerable<KiwoomElwGetChangeRateRankItem>? Items;
	}
	public record KiwoomElwGetChangeRateRankItem
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
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 대비기호
		/// </summary>
		[JsonProperty("pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 매도잔량
		/// </summary>
		[JsonProperty("sel_req")]
		public decimal? SellRemainQuantity;
		/// <summary>
		/// 매수잔량
		/// </summary>
		[JsonProperty("buy_req")]
		public decimal? BuyRemainQuantity;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 거래대금
		/// </summary>
		[JsonProperty("trde_prica")]
		public decimal? TransactionAmount;
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
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 대비기호
		/// </summary>
		[JsonProperty("pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 매도잔량
		/// </summary>
		[JsonProperty("sel_req")]
		public decimal? SellRemainQuantity;
		/// <summary>
		/// 매수잔량
		/// </summary>
		[JsonProperty("buy_req")]
		public decimal? BuyRemainQuantity;
		/// <summary>
		/// 순매수잔량
		/// </summary>
		[JsonProperty("netprps_req")]
		public decimal? NetBuyRemainQuantity;
		/// <summary>
		/// 거래대금
		/// </summary>
		[JsonProperty("trde_prica")]
		public decimal? TransactionAmount;
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
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 대비기호
		/// </summary>
		[JsonProperty("pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? AccumulatedVolume;
		/// <summary>
		/// 근접율
		/// </summary>
		[JsonProperty("alacc_rt")]
		public decimal? ProximityRate;
	}

	public record KiwoomElwGetStockInfo
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
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
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
		public string? ElwRightsContent;
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
		public KiwoomDecimal? DisparityRate;
		/// <summary>
		/// ELW내재변동성
		/// </summary>
		[JsonProperty("elwinnr_vltl")]
		public decimal? ElwImpliedVolatility;
		/// <summary>
		/// 예상권리가
		/// </summary>
		[JsonProperty("exp_rght_pric")]
		public decimal? ExpectedRightsPrice;
		/// <summary>
		/// ELW손익분기율
		/// </summary>
		[JsonProperty("elwpl_qutr_rt")]
		public KiwoomDecimal? ElwBreakEvenRate;
		/// <summary>
		/// ELW행사가
		/// </summary>
		[JsonProperty("elwexec_pric")]
		public decimal? ElwExercisePrice;
		/// <summary>
		/// ELW전환비율
		/// </summary>
		[JsonProperty("elwcnvt_rt")]
		public decimal? ElwConversionRate;
		/// <summary>
		/// ELW보상율
		/// </summary>
		[JsonProperty("elwcmpn_rt")]
		public decimal? ElwCompensationRate;
		/// <summary>
		/// ELW가격상승참여율
		/// </summary>
		[JsonProperty("elwpric_rising_part_rt")]
		public decimal? ElwPriceIncreaseParticipationRate;
		/// <summary>
		/// ELW권리유형
		/// </summary>
		[JsonProperty("elwrght_type")]
		public string? ElwRightsType;
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
		public string? ElwLpOrderable;
		/// <summary>
		/// LP보유비율
		/// </summary>
		[JsonProperty("lpposs_rt")]
		public KiwoomDecimal? LpHoldingRate;
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
		public DateTime? ElwFinalTransactionDate;
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
		public string? IsEvaluationCompleted;
		/// <summary>
		/// 전체최고가
		/// </summary>
		[JsonProperty("all_hgst_pric")]
		public decimal? TotalHigh;
		/// <summary>
		/// 전체최저가
		/// </summary>
		[JsonProperty("all_lwst_pric")]
		public decimal? TotalLow;
		/// <summary>
		/// 직후최고가
		/// </summary>
		[JsonProperty("imaf_hgst_pric")]
		public decimal? ImmediateAfterHigh;
		/// <summary>
		/// 직후최저가
		/// </summary>
		[JsonProperty("imaf_lwst_pric")]
		public decimal? ImmediateAfterLow;
		/// <summary>
		/// 후반장최고가
		/// </summary>
		[JsonProperty("sndhalf_mrkt_hgst_pric")]
		public decimal? SecondHalfHigh;
		/// <summary>
		/// 후반장최저가
		/// </summary>
		[JsonProperty("sndhalf_mrkt_lwst_pric")]
		public decimal? SecondHalfLow;
	}
}
