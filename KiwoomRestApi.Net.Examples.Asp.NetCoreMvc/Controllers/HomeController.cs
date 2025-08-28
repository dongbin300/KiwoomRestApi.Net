using KiwoomRestApi.Net.Examples.Asp.NetCoreMvc.Models;
using KiwoomRestApi.Net.Clients;

using Microsoft.AspNetCore.Mvc;

using System.Diagnostics;

namespace KiwoomRestApi.Net.Examples.Asp.NetCoreMvc.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly KiwoomRestApiClient _kiwoomClient;

		public HomeController(ILogger<HomeController> logger, KiwoomRestApiClient kiwoomClient)
		{
			_logger = logger;
			_kiwoomClient = kiwoomClient;
		}

		public IActionResult Index()
		{
			ViewBag.KiwoomToken = _kiwoomClient.Token;
			return View();
		}

		public IActionResult Kiwoom()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
