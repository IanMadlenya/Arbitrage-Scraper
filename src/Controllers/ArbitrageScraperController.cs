using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;
using Wyatt_Fleming.Models;
using Wyatt_Fleming.Models.HttpeBayClient;
using Wyatt_Fleming.Models.ViewModels;

namespace Wyatt_Fleming.Controllers
{
	[Route("/ArbitrageScraper")]
	public class ArbitrageScraperController : Controller
	{
		private readonly IeBayClient _eBayClient;

		public ArbitrageScraperController(IeBayClient eBayClient)
		{
			_eBayClient = eBayClient;
		}
		public ActionResult Index()
		{
			return View();
		}


		[Route ("/ArbitrageScraper/List")]
		public async Task<ViewResult> List()
		{
			var watch = System.Diagnostics.Stopwatch.StartNew();

			eBayBookListViewModel _eBayBookListViewModel = new eBayBookListViewModel();
			_eBayBookListViewModel.Books = await _eBayClient.GetBooks();

			watch.Stop();
			_eBayBookListViewModel.TimeToCompletion =  watch.ElapsedMilliseconds.ToString();
		
			return View(_eBayBookListViewModel);

		}
	}
}