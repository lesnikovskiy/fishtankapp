using System.Collections.Generic;
using FishTankApp.Models;

namespace FishTankApp.Services
{
	public interface ISensorDataService
	{
		IntHistoryModel GetWaterTemperatureFahrenheit();
		IEnumerable<IntHistoryModel> GetWaterTemperatureFahrenheitHistory();
		IntHistoryModel GetFishMotionPercentage();
		IEnumerable<IntHistoryModel> GetFishMotionPercentageHistory();
		IntHistoryModel GetWaterOpacityPercentage();
		IEnumerable<IntHistoryModel> GetWaterOpacityPercentageHistory();
		IntHistoryModel GetLightIntensityLumens();
		IEnumerable<IntHistoryModel> GetLightIntensityLumensHistory();
	}
}