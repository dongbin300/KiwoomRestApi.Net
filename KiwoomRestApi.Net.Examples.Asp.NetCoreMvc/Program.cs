using KiwoomRestApi.Net.Clients;

namespace KiwoomRestApi.Net.Examples.Asp.NetCoreMvc
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllersWithViews()
				.AddNewtonsoftJson(options =>
				{
					options.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
					options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Include;
					options.SerializerSettings.DefaultValueHandling = Newtonsoft.Json.DefaultValueHandling.Include;
					options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
				});

			// Configure KiwoomRestApiClient as a singleton service
			builder.Services.AddSingleton(provider =>
			{
				var appKey = File.ReadAllText("D:\\Assets\\kiwoom_appkey_mock.txt");
				var secretKey = File.ReadAllText("D:\\Assets\\kiwoom_secretkey_mock.txt");
				return KiwoomRestApiClient.Create(appKey, secretKey, isMock: true);
			});

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseRouting();

			app.UseAuthorization();

			app.MapStaticAssets();
			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}")
				.WithStaticAssets();

			app.Run();
		}
	}
}
