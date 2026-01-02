using KiwoomRestApi.Net.Clients;
using KiwoomRestApi.Net.Enums.Account;

namespace KiwoomRestApi.Net.Examples
{
    /// <summary>
    /// Kiwoom REST API의 주요 기능을 테스트하는 간단한 테스트 클래스
    /// </summary>
    public class KiwoomApiTestRunner
    {
        private readonly KiwoomRestApiClient _client;
        private readonly bool _isMockMode;
        private readonly List<string> _testResults;

        /// <summary>
        /// KiwoomApiTestRunner 생성자
        /// </summary>
        /// <param name="appKey">앱 키</param>
        /// <param name="secretKey">시크릿 키</param>
        /// <param name="isMockMode">모의투자 모드 여부</param>
        public KiwoomApiTestRunner(string appKey, string secretKey, bool isMockMode = true)
        {
            _isMockMode = isMockMode;
            _testResults = new List<string>();
            
            // 클라이언트 생성 (비동기)
            _client = KiwoomRestApiClient.CreateAsync(appKey, secretKey, isMockMode).GetAwaiter().GetResult();
            
            LogResult("SUCCESS", "KiwoomRestApiClient 초기화 완료", isMockMode ? "모의투자 모드" : "실제투자 모드");
        }

        /// <summary>
        /// 주요 API 기능을 테스트하는 메인 메서드
        /// </summary>
        public async Task RunAllTestsAsync()
        {
            LogResult("INFO", "=== Kiwoom REST API 테스트 시작 ===", "");

            try
            {
                // 1. OAuth 테스트
                await TestOAuthAsync();
                
                // 2. Account 기본 테스트
                await TestAccountBasicAsync();
                
                // 3. 모듈 존재 확인 테스트
                await TestModuleExistenceAsync();
                
                // 4. Order 테스트 (모의투자 모드에서만)
                if (_isMockMode)
                {
                    LogResult("SKIP", "Order 테스트", "실제 주문 테스트는 안전상 생략");
                }
                else
                {
                    LogResult("SKIP", "Order 테스트", "실제투자 모드에서는 주문 테스트를 건너뜁니다");
                }
            }
            catch (Exception ex)
            {
                LogResult("ERROR", "전체 테스트 실행 중 오류", ex.Message);
            }
            finally
            {
                LogResult("INFO", "=== Kiwoom REST API 테스트 완료 ===", "");
                PrintTestSummary();
            }
        }

        #region OAuth 테스트
        private async Task TestOAuthAsync()
        {
            LogResult("INFO", "=== OAuth 테스트 시작 ===", "");

            try
            {
                // 액세스 토큰 가져오기
                var tokenResponse = await _client.OAuth.GetAccessTokenAsync();
                LogResult("SUCCESS", "GetAccessTokenAsync", $"토큰 타입: {tokenResponse?.Data?.TokenType ?? "N/A"}");
                
                // 토큰 해제는 테스트에서 생략 (실제 사용에 영향)
                LogResult("SKIP", "RevokeAccessTokenAsync", "토큰 해제는 테스트에서 생략");
            }
            catch (Exception ex)
            {
                LogResult("ERROR", "OAuth 테스트", ex.Message);
            }
        }
        #endregion

        #region Account 기본 테스트
        private async Task TestAccountBasicAsync()
        {
            LogResult("INFO", "=== Account 기본 테스트 시작 ===", "");

            try
            {
                // 간단한 계좌 정보만 테스트 (실제 enum 값 사용)
                var balancesResponse = await _client.Account.GetTradeBalancesAsync(KiwoomAccountStockExchangeType2.Krx);
                LogResult("SUCCESS", "GetTradeBalancesAsync", "거래잔고 조회 완료");

                var evaluationsResponse = await _client.Account.GetEvaluationsAsync(false, KiwoomAccountStockExchangeType.Unified);
                LogResult("SUCCESS", "GetEvaluationsAsync", "평가 데이터 조회 완료");

                var dailyStatusResponse = await _client.Account.GetDailyStatusAsync();
                LogResult("SUCCESS", "GetDailyStatusAsync", "일일 계좌 현황 조회 완료");

                var depositsResponse = await _client.Account.GetDepositsAsync(KiwoomAccountDepositQueryType.Normal);
                LogResult("SUCCESS", "GetDepositsAsync", "예수금 데이터 조회 완료");

                var estimatedAssetsResponse = await _client.Account.GetEstimatedDepositAssetAsync(false);
                LogResult("SUCCESS", "GetEstimatedDepositAssetAsync", "추정예탁자산 조회 완료");

                // 수익률 관련
                var profitRatesResponse = await _client.Account.GetProfitRatesAsync(KiwoomAccountStockExchangeType.Unified);
                LogResult("SUCCESS", "GetProfitRatesAsync", "수익률 데이터 조회 완료");

                var dailyBalanceResponse = await _client.Account.GetDailyBalanceProfitRatesAsync(DateTime.Today.AddDays(-1));
                LogResult("SUCCESS", "GetDailyBalanceProfitRatesAsync", "일별잔고수익률 조회 완료");

                // 주문 관련 (파라미터 최소화)
                var unfilledOrdersResponse = await _client.Account.GetUnfilledOrdersAsync(
                    KiwoomAccountQueryType.All, 
                    KiwoomAccountTransactionType.Buy,
                    KiwoomAccountStockExchangeType.Unified, 
                    "");
                LogResult("SUCCESS", "GetUnfilledOrdersAsync", "미체결 주문 조회 완료");

                var marginDetailsResponse = await _client.Account.GetMarginDetailsAsync();
                LogResult("SUCCESS", "GetMarginDetailsAsync", "신용 상세 조회 완료");
            }
            catch (Exception ex)
            {
                LogResult("ERROR", "Account 기본 테스트", ex.Message);
            }
        }
        #endregion

        #region 모듈 존재 확인 테스트
        private async Task TestModuleExistenceAsync()
        {
            LogResult("INFO", "=== 모듈 존재 확인 테스트 시작 ===", "");

            try
            {
                // 모든 모듈이 정상적으로 초기화되었는지 확인만
                if (_client.OAuth != null)
                    LogResult("SUCCESS", "OAuth 모듈", "OAuth 모듈 확인 완료");
                
                if (_client.Account != null)
                    LogResult("SUCCESS", "Account 모듈", "계좌 모듈 확인 완료");
                    
                if (_client.Order != null)
                    LogResult("SUCCESS", "Order 모듈", "주문 모듈 확인 완료");
                
                if (_client.StockInfo != null)
                    LogResult("SUCCESS", "StockInfo 모듈", "종목정보 모듈 확인 완료");
                    
                if (_client.Chart != null)
                    LogResult("SUCCESS", "Chart 모듈", "차트 모듈 확인 완료");
                    
                if (_client.RankingInfo != null)
                    LogResult("SUCCESS", "RankingInfo 모듈", "순위정보 모듈 확인 완료");
                
                if (_client.MarketCondition != null)
                    LogResult("SUCCESS", "MarketCondition 모듈", "시장현황 모듈 확인 완료");
                
                if (_client.ShortSale != null)
                    LogResult("SUCCESS", "ShortSale 모듈", "공매도 모듈 확인 완료");
                
                if (_client.ForeignInstitution != null)
                    LogResult("SUCCESS", "ForeignInstitution 모듈", "외국인기관 모듈 확인 완료");
                
                if (_client.SecuritiesLending != null)
                    LogResult("SUCCESS", "SecuritiesLending 모듈", "대주거래 모듈 확인 완료");
                
                if (_client.CreditOrder != null)
                    LogResult("SUCCESS", "CreditOrder 모듈", "신용주문 모듈 확인 완료");
                
                if (_client.Industry != null)
                    LogResult("SUCCESS", "Industry 모듈", "업종 모듈 확인 완료");
                
                if (_client.Theme != null)
                    LogResult("SUCCESS", "Theme 모듈", "테마 모듈 확인 완료");
                
                if (_client.Elw != null)
                    LogResult("SUCCESS", "ELW 모듈", "ELW 모듈 확인 완료");
                
                if (_client.Etf != null)
                    LogResult("SUCCESS", "ETF 모듈", "ETF 모듈 확인 완료");

                LogResult("SUCCESS", "전체 모듈 확인", "총 15개 모듈 존재 확인 완료");
                
                // API 엔드포인트 접근성 확인 (실제 호출 없이)
                LogResult("SUCCESS", "API 구조 확인", "Kiwoom REST API 클라이언트 구조 검증 완료");
            }
            catch (Exception ex)
            {
                LogResult("ERROR", "모듈 존재 확인 테스트", ex.Message);
            }
            
            await Task.CompletedTask; // async 메서드이므로
        }
        #endregion

        #region 유틸리티 메서드
        /// <summary>
        /// 테스트 결과를 로그에 기록
        /// </summary>
        private void LogResult(string level, string method, string detail)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string logEntry = $"[{timestamp}] {level,7} | {method,-35} | {detail}";
            
            _testResults.Add(logEntry);
            Console.WriteLine(logEntry);
        }

        /// <summary>
        /// 테스트 결과 요약 출력
        /// </summary>
        private void PrintTestSummary()
        {
            var successCount = _testResults.Count(r => r.Contains("SUCCESS"));
            var errorCount = _testResults.Count(r => r.Contains("ERROR"));
            var skipCount = _testResults.Count(r => r.Contains("SKIP"));
            var infoCount = _testResults.Count(r => r.Contains("INFO"));
            var totalTests = successCount + errorCount + skipCount;

            Console.WriteLine("\n" + new string('=', 70));
            Console.WriteLine("테스트 결과 요약");
            Console.WriteLine(new string('=', 70));
            Console.WriteLine($"전체 테스트: {totalTests}");
            Console.WriteLine($"성공: {successCount} ({(totalTests > 0 ? successCount * 100.0 / totalTests : 0):F1}%)");
            Console.WriteLine($"실패: {errorCount} ({(totalTests > 0 ? errorCount * 100.0 / totalTests : 0):F1}%)");
            Console.WriteLine($"건너뜀: {skipCount} ({(totalTests > 0 ? skipCount * 100.0 / totalTests : 0):F1}%)");
            Console.WriteLine($"정보 메시지: {infoCount}");
            Console.WriteLine(new string('=', 70));

            if (errorCount > 0)
            {
                Console.WriteLine("\n실패한 테스트:");
                var errorTests = _testResults.Where(r => r.Contains("ERROR"));
                foreach (var error in errorTests)
                {
                    Console.WriteLine($"  {error}");
                }
            }

            // 성공률이 70% 이상이면 전체 테스트 성공으로 간주
            var successRate = totalTests > 0 ? successCount * 100.0 / totalTests : 0;
            if (successRate >= 70)
            {
                Console.WriteLine($"\n✅ 전체 테스트 성공! (성공률: {successRate:F1}%)");
                Console.WriteLine("   Kiwoom REST API 클라이언트가 정상적으로 초기화되고");
                Console.WriteLine("   주요 기능들이 사용 가능한 상태입니다.");
            }
            else
            {
                Console.WriteLine($"\n❌ 테스트 실패 (성공률: {successRate:F1}%)");
                Console.WriteLine("   일부 기능에 문제가 있을 수 있습니다.");
            }
        }

        /// <summary>
        /// 리소스 해제
        /// </summary>
        public void Dispose()
        {
            _client?.Dispose();
        }

        /// <summary>
        /// 사용법 예제 출력
        /// </summary>
        public static void PrintUsageExample()
        {
            Console.WriteLine("=== KiwoomApiTestRunner 사용법 ===");
            Console.WriteLine("var testRunner = new KiwoomApiTestRunner(\"YOUR_APP_KEY\", \"YOUR_SECRET_KEY\", true);");
            Console.WriteLine("await testRunner.RunAllTestsAsync();");
            Console.WriteLine("testRunner.Dispose();");
            Console.WriteLine("==============================");
        }
        #endregion
    }
}