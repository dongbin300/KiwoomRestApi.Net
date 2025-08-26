using KiwoomRestApi.Net.Clients;
using KiwoomRestApi.Net.Configuration;
using KiwoomRestApi.Net.Interfaces;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

using System;

namespace KiwoomRestApi.Net.Extensions
{
	/// <summary>
	/// IServiceCollection에 대한 키움 REST API 의존성 주입 확장 메서드를 제공합니다.
	/// </summary>
	public static class ServiceCollectionExtensions
	{
		/// <summary>
		/// 키움 REST API 서비스를 의존성 주입 컨테이너에 등록합니다.
		/// </summary>
		/// <param name="services">서비스 컬렉션</param>
		/// <param name="configure">구성 설정 델리게이트</param>
		/// <returns>업데이트된 서비스 컬렉션</returns>
		/// <example>
		/// <code>
		/// services.AddKiwoomRestApi(config => {
		///     config.AppKey = "your-app-key";
		///     config.SecretKey = "your-secret-key";
		///     config.IsMock = true;
		/// });
		/// </code>
		/// </example>
		public static IServiceCollection AddKiwoomRestApi(this IServiceCollection services, Action<KiwoomConfiguration> configure)
		{
			services.Configure(configure);

			services.AddSingleton<IClient, BaseClient>();
			services.AddSingleton(provider =>
			{
				var config = provider.GetRequiredService<IOptions<KiwoomConfiguration>>().Value;
				return new KiwoomRestApiClient(config);
			});

			return services;
		}

		/// <summary>
		/// 구성 객체를 사용하여 키움 REST API 서비스를 의존성 주입 컨테이너에 등록합니다.
		/// </summary>
		/// <param name="services">서비스 컬렉션</param>
		/// <param name="configuration">키움 구성 객체</param>
		/// <returns>업데이트된 서비스 컬렉션</returns>
		public static IServiceCollection AddKiwoomRestApi(this IServiceCollection services, KiwoomConfiguration configuration)
		{
			services.AddSingleton(Options.Create(configuration));

			services.AddSingleton<IClient, BaseClient>();
			services.AddSingleton(provider =>
			{
				var config = provider.GetRequiredService<IOptions<KiwoomConfiguration>>().Value;
				return new KiwoomRestApiClient(config);
			});

			return services;
		}

		/// <summary>
		/// 기본 매개변수를 사용하여 키움 REST API 서비스를 의존성 주입 컨테이너에 등록합니다.
		/// </summary>
		/// <param name="services">서비스 컬렉션</param>
		/// <param name="appKey">키움증권에서 발급받은 앱 키</param>
		/// <param name="secretKey">키움증권에서 발급받은 시크릿 키</param>
		/// <param name="isMock">모의투자 여부 (기본값: false)</param>
		/// <returns>업데이트된 서비스 컬렉션</returns>
		public static IServiceCollection AddKiwoomRestApi(this IServiceCollection services, string appKey, string secretKey, bool isMock = false)
		{
			var config = new KiwoomConfiguration
			{
				AppKey = appKey,
				SecretKey = secretKey,
				IsMock = isMock
			};

			return services.AddKiwoomRestApi(config);
		}
	}
}