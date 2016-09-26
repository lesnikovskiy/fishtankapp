using FishTankApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace FishTankApp.Controllers
{
	public class HomeController : Controller
	{
		private IViewModelService _viewModelService;

		public HomeController(IViewModelService vieweModelService)
		{
			_viewModelService = vieweModelService;
		}

		public IActionResult Index()
		{
			ViewBag.Title = "Fish tank dashboard";
			return View(_viewModelService.GetDashboardViewModel());
		}
	}
}