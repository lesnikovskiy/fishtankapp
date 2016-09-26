using FishTankApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;

namespace FishTankApp.Services
{
	public class ViewModelService : IViewModelService
	{
		private readonly ISensorDataService _sensorDataService;
		private readonly IUrlHelper _urlHelper;

		public ViewModelService(ISensorDataService sensorDataService,
		IUrlHelperFactory urlHelper,
		IActionContextAccessor actionContextAccessor)
		{
			_sensorDataService = sensorDataService;
			_urlHelper = urlHelper.GetUrlHelper(actionContextAccessor.ActionContext); // Add Startup.AddServices services.AddSingleton<IActionContextAccessor, ActionContextAccessor>(); to use it.
		}

		public DashboardViewModel GetDashboardViewModel()
		{
			return new DashboardViewModel
			{
				WaterTemperatureTile = new SensorTileViewModel
				{
					Title = "Water temperature",
					Value = _sensorDataService.GetWaterTemperatureFahrenheit().Value,
					ColorCssClass = "panel-primary",
					IconCssClass = "fa-sliders",
					Url = _urlHelper.Action("GetWaterTemperatureChart", "History")
				},
				FishMotionTile = new SensorTileViewModel
				{
					Title = "Fish motion",
					Value = _sensorDataService.GetFishMotionPercentage().Value,
					ColorCssClass = "panel-green",
					IconCssClass = "fa-car",
					Url = _urlHelper.Action("GetFishMotionPercentageChart", "History")
				},
				WaterOpacityTile = new SensorTileViewModel
				{
					Title = "Water opacity",
					Value = _sensorDataService.GetWaterOpacityPercentage().Value,
					ColorCssClass = "panel-yellow",
					IconCssClass = "fa-adjust",
					Url = _urlHelper.Action("GetWaterOpacityPercentageChart", "History")
				},
				LightIntensityTile = new SensorTileViewModel
				{
					Title = "Light intensity",
					Value = _sensorDataService.GetLightIntensityLumens().Value,
					ColorCssClass = "panel-red",
					IconCssClass = "fa-lightbulb-o",
					Url = _urlHelper.Action("GetLightIntensityLumensChart", "History")
				}
			};
		}
	}
}