namespace KiwoomRestApi.Net.Enums.RankingInfo
{
    /// <summary>
    /// 기관구분
    /// </summary>
	public enum KiwoomRankingInfoInstitutionType
    {
        /// <summary>
        /// 금융투자
        /// </summary>
        FinancialInvestment = 1000,
        /// <summary>
        /// 보험
        /// </summary>
        Insurance = 2000,
        /// <summary>
        /// 투신
        /// </summary>
        InvestmentTrust = 3000,
        /// <summary>
        /// 은행
        /// </summary>
        Bank = 4000,
        /// <summary>
        /// 기타금융
        /// </summary>
        OtherFinancial = 5000,
        /// <summary>
        /// 연기금
        /// </summary>
        PensionFund = 6000,
        /// <summary>
        /// 국가
        /// </summary>
        Government = 7000,
        /// <summary>
        /// 기타법인
        /// </summary>
        OtherCorporation = 7100,
        /// <summary>
        /// 외국인
        /// </summary>
        Foreigner = 9000,
        /// <summary>
        /// 외국계
        /// </summary>
        ForeignCompany = 9100,
        /// <summary>
        /// 기관계
        /// </summary>
        InstitutionTotal = 9999
    }
}
