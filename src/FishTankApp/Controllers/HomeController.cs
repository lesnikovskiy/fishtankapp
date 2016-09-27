using System;
using FishTankApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace FishTankApp.Controllers
{
	public class HomeController : Controller
	{
		private readonly IViewModelService _viewModelService;

		public HomeController(IViewModelService vieweModelService)
		{
			_viewModelService = vieweModelService;
		}

		public IActionResult Index()
		{
			ViewBag.Title = "Fish tank dashboard";
			return View(_viewModelService.GetDashboardViewModel());
		}

		public IActionResult Feed(int foodAmount)
		{
			var model = _viewModelService.GetDashboardViewModel();
			model.LastFed = $"{DateTime.Now.Hour}:{DateTime.Now.Minute}. Amount: {foodAmount}";

			return View("Index", model);
		}
	}
}