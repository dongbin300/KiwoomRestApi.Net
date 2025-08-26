using KiwoomRestApi.Net.Clients;
using KiwoomRestApi.Net.Configuration;
using KiwoomRestApi.Net.Interfaces;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

using System;

namespace KiwoomRestApi.Net.Extensions
{
	public static class ServiceCollectionExtensions
	{
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