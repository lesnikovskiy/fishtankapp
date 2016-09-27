using System.Collections.Generic;
using FishTankApp.Models;
using FishTankApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace FishTankApp.Controllers.Api
{
	public class HistoryDataController : Controller
	{
		private readonly ISensorDataService _sensorDataService;

		public HistoryDataController(ISensorDataService sensorDataService)
		{
			_sensorDataService = sensorDataService;
		}

		public IEnumerable<IntHistoryModel> GetWaterTemperatureHistory()
		{
			return _sensorDataService.GetWaterTemperatureFahrenheitHistory();
		}

		public IEnumerable<IntHistoryModel> GetFishMotionPercentageHistory()
		{
			return _sensorDataService.GetFishMotionPercentageHistory();
		}

		public IEnumerable<IntHistoryModel> GetWaterOpacityPercentageHistory()
		{
			return _sensorDataService.GetWaterOpacityPercentageHistory();
		}

		public IEnumerable<IntHistoryModel> GetLightIntensityLumensHistory()
		{
			return _sensorDataService.GetLightIntensityLumensHistory();
		}
	}
}