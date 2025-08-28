using KiwoomRestApi.Net.Clients.DomesticStocks;
using KiwoomRestApi.Net.Configuration;
using KiwoomRestApi.Net.Converters;
using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Commons;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients
{
	/// <summary>
	/// 키움증권 OpenAPI REST API 클라이언트입니다.
	/// 주식 거래, 조회, 실시간 데이터 등의 기능을 제공합니다.
	/// </summary>
	/// <example>
	/// <code>
	/// var client = KiwoomRestApiClient.Create(appKey, secretKey, true);
	/// var stockInfo = await client.StockInfo.GetStockInfoAsync("005930", DateTime.Today, KiwoomStockInfoMarginLoanType.Loan);
	/// Console.WriteLine($"삼성전자 현재가: {stockInfo.Data.CurrentPrice}원");
	/// </code>
	/// </example>
	public class KiwoomRestApiClient : BaseClient
	{
		/// <summary>
		/// 앱 키를 가져옵니다.
		/// </summary>
		public string AppKey { get; private set; } = string.Empty;

		/// <summary>
		/// 시크릿 키를 가져옵니다.
		/// </summary>
		public string SecretKey { get; private set; } = string.Empty;

		/// <summary>
		/// OAuth 인증 헤더를 가져오거나 설정합니다.
		/// </summary>
		public string? Authorization { get; set; }

		/// <summary>
		/// 연속 조회 여부를 가져오거나 설정합니다.
		/// </summary>
		public string ContYn { get; set; } = string.Empty;

		/// <summary>
		/// 다음 조회 키를 가져오거나 설정합니다.
		/// </summary>
		public string NextKey { get; set; } = string.Empty;

		/// <summary>
		/// 액세스 토큰을 가져오거나 설정합니다.
		/// </summary>
		public string Token { get; set; } = string.Empty;

		/// <summary>
		/// OAuth 인증 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientOAuth OAuth { get; set; }

		/// <summary>
		/// 계좌 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientDomesticStockAccount Account { get; set; }

		/// <summary>
		/// 공매도 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientDomesticStockShortSale ShortSale { get; set; }

		/// <summary>
		/// 외국인/기관 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientDomesticStockForeignInstitution ForeignInstitution { get; set; }

		/// <summary>
		/// 대차거래 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientDomesticStockSecuritiesLendingAndBorrowing SLB { get; set; }

		/// <summary>
		/// 순위 정보 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientDomesticStockRankingInfo Ranking { get; set; }

		/// <summary>
		/// 시장 상황 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientDomesticStockMarketCondition MarketCondition { get; set; }

		/// <summary>
		/// 신용 주문 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientDomesticStockCreditOrder CreditOrder { get; set; }

		/// <summary>
		/// 업종 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientDomesticStockSector Sector { get; set; }

		/// <summary>
		/// 주식 정보 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientDomesticStockInfo StockInfo { get; set; }

		/// <summary>
		/// 주문 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientDomesticStockOrder Order { get; set; }

		/// <summary>
		/// 차트 데이터 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientDomesticStockChart Chart { get; set; }

		/// <summary>
		/// 테마 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientDomesticStockTheme Theme { get; set; }

		/// <summary>
		/// ELW 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientDomesticStockElw Elw { get; set; }

		/// <summary>
		/// ETF 관련 기능을 제공합니다.
		/// </summary>
		public KiwoomRestApiClientDomesticStockEtf Etf { get; set; }

		/// <summary>
		/// 설정 객체를 사용하여 KiwoomRestApiClient의 새 인스턴스를 초기화합니다.
		/// </summary>
		/// <param name="configuration">키움 API 설정</param>
		/// <exception cref="ArgumentNullException">configuration이 null인 경우</exception>
		public KiwoomRestApiClient(KiwoomConfiguration configuration)
			: this(configuration.AppKey, configuration.SecretKey, configuration.Token, configuration.IsMock)
		{
			if (configuration.HttpClient != null)
			{
				Client?.Dispose();
				Client = configuration.HttpClient;
			}

			if (configuration.RequestTimeout != default)
			{
				Client.Timeout = configuration.RequestTimeout;
			}
		}

		/// <summary>
		/// 앱 키와 시크릿 키를 사용하여 KiwoomRestApiClient의 새 인스턴스를 초기화합니다.
		/// </summary>
		/// <param name="appKey">키움증권에서 발급받은 앱 키</param>
		/// <param name="secretKey">키움증권에서 발급받은 시크릿 키</param>
		/// <param name="isMock">모의투자 여부 (기본값: false)</param>
		/// <exception cref="ArgumentException">appKey 또는 secretKey가 null 또는 빈 문자열인 경우</exception>
		public KiwoomRestApiClient(string appKey, string secretKey, bool isMock = false)
		: this(appKey, secretKey, null, isMock)
		{
		}

		/// <summary>
		/// 앱 키, 시크릿 키, 토큰을 사용하여 KiwoomRestApiClient의 새 인스턴스를 초기화합니다.
		/// </summary>
		/// <param name="appKey">키움증권에서 발급받은 앱 키</param>
		/// <param name="secretKey">키움증권에서 발급받은 시크릿 키</param>
		/// <param name="token">OAuth 액세스 토큰 (선택적)</param>
		/// <param name="isMock">모의투자 여부 (기본값: false)</param>
		/// <exception cref="ArgumentException">appKey 또는 secretKey가 null 또는 빈 문자열인 경우</exception>
		public KiwoomRestApiClient(string appKey, string secretKey, string? token, bool isMock = false)
		{
			Client = new HttpClient
			{
				BaseAddress = new Uri(isMock ? KiwoomUrls.MockRestApiHost : KiwoomUrls.RestApiHost)
			};
			AppKey = appKey;
			SecretKey = secretKey;
			Authorization = token != null ? $"Bearer {token}" : null;
			Token = token ?? string.Empty;

			OAuth = new KiwoomRestApiClientOAuth(this);
			Account = new KiwoomRestApiClientDomesticStockAccount(this);
			ShortSale = new KiwoomRestApiClientDomesticStockShortSale(this);
			ForeignInstitution = new KiwoomRestApiClientDomesticStockForeignInstitution(this);
			SLB = new KiwoomRestApiClientDomesticStockSecuritiesLendingAndBorrowing(this);
			Ranking = new KiwoomRestApiClientDomesticStockRankingInfo(this);
			MarketCondition = new KiwoomRestApiClientDomesticStockMarketCondition(this);
			CreditOrder = new KiwoomRestApiClientDomesticStockCreditOrder(this);
			Sector = new KiwoomRestApiClientDomesticStockSector(this);
			StockInfo = new KiwoomRestApiClientDomesticStockInfo(this);
			Order = new KiwoomRestApiClientDomesticStockOrder(this);
			Chart = new KiwoomRestApiClientDomesticStockChart(this);
			Theme = new KiwoomRestApiClientDomesticStockTheme(this);
			Elw = new KiwoomRestApiClientDomesticStockElw(this);
			Etf = new KiwoomRestApiClientDomesticStockEtf(this);
		}

		/// <summary>
		/// 키움 API 클라이언트를 생성하고 자동으로 초기화합니다. (동기)
		/// </summary>
		/// <param name="appKey">키움증권에서 발급받은 앱 키</param>
		/// <param name="secretKey">키움증권에서 발급받은 시크릿 키</param>
		/// <param name="isMock">모의투자 여부 (기본값: false)</param>
		/// <returns>초기화된 KiwoomRestApiClient 인스턴스</returns>
		/// <exception cref="InvalidOperationException">토큰 획득에 실패한 경우</exception>
		public static KiwoomRestApiClient Create(string appKey, string secretKey, bool isMock = false)
		{
			var client = new KiwoomRestApiClient(appKey, secretKey, isMock);
			client.Initialize();
			return client;
		}

		/// <summary>
		/// 키움 API 클라이언트를 생성하고 비동기로 초기화합니다.
		/// </summary>
		/// <param name="appKey">키움증권에서 발급받은 앱 키</param>
		/// <param name="secretKey">키움증권에서 발급받은 시크릿 키</param>
		/// <param name="isMock">모의투자 여부 (기본값: false)</param>
		/// <returns>초기화된 KiwoomRestApiClient 인스턴스를 반환하는 Task</returns>
		/// <exception cref="InvalidOperationException">토큰 획득에 실패한 경우</exception>
		public static async Task<KiwoomRestApiClient> CreateAsync(string appKey, string secretKey, bool isMock = false)
		{
			var client = new KiwoomRestApiClient(appKey, secretKey, isMock);
			await client.InitializeAsync();
			return client;
		}

		/// <summary>
		/// 클라이언트를 초기화하고 액세스 토큰을 획득합니다. (동기)
		/// </summary>
		/// <exception cref="InvalidOperationException">토큰 획득에 실패한 경우</exception>
		public void Initialize()
		{
			Token = OAuth.GetAccessTokenAsync().Result.Data?.Token ?? throw new InvalidOperationException("Token is null");
			Authorization = $"Bearer {Token}";
		}

		/// <summary>
		/// 클라이언트를 비동기로 초기화하고 액세스 토큰을 획득합니다.
		/// </summary>
		/// <returns>초기화 작업을 나타내는 Task</returns>
		/// <exception cref="InvalidOperationException">토큰 획득에 실패한 경우</exception>
		public async Task InitializeAsync()
		{
			var result = await OAuth.GetAccessTokenAsync();
			Token = result.Data?.Token ?? throw new InvalidOperationException("Token is null");
			Authorization = $"Bearer {Token}";
		}

		/// <summary>
		/// API 요청에 사용할 기본 헤더를 가져옵니다.
		/// </summary>
		/// <returns>기본 헤더를 포함한 딕셔너리</returns>
		public IDictionary<string, string> GetDefaultHeaders()
		{
			var headers = new Dictionary<string, string>
			{
				["appkey"] = AppKey,
				["appsecret"] = SecretKey
			};

			if (!string.IsNullOrEmpty(Authorization))
			{
				headers["authorization"] = Authorization!;
			}

			return headers;
		}

		public async Task<KiwoomRestApiResponse<T>> PostKiwoomRestApiAsync<T>(string endpoint, string apiId, IDictionary<string, string>? body = null, CancellationToken cancellationToken = default)
		{
			var headers = new HttpParameterMap()
				.AddField("api-id", apiId)
				.AddField("authorization", Authorization)
				.AddField("cont-yn", ContYn)
				.AddField("next-key", NextKey);

			var response = await PostAsync<JObject>(endpoint, headers, body, cancellationToken).ConfigureAwait(false);

			if (response.Body == null)
				return new KiwoomRestApiResponse<T>();

			var jsonString = response.Body.ToString();

			var settings = new JsonSerializerSettings
			{
				Converters = { new KiwoomRestApiResponseConverter<T>() }
			};

			var result = JsonConvert.DeserializeObject<KiwoomRestApiResponse<T>>(jsonString, settings) ?? new KiwoomRestApiResponse<T>();

			AssignHeadersToResponse(result, response.Headers);

			return result;
		}

		private void AssignHeadersToResponse<T>(KiwoomRestApiResponse<T> response, IDictionary<string, IEnumerable<string>>? headers)
		{
			if (headers == null)
				return;

			if (headers.TryGetValue("api-id", out var apiIdValues))
				response.ApiId = apiIdValues.FirstOrDefault() ?? string.Empty;

			if (headers.TryGetValue("cont-yn", out var contYnValues))
				response.ContYn = contYnValues.FirstOrDefault() ?? string.Empty;

			if (headers.TryGetValue("next-key", out var nextKeyValues))
				response.NextKey = nextKeyValues.FirstOrDefault() ?? string.Empty;
		}
	}
}
