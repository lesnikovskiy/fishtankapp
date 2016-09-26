using FishTankApp.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace FishTankApp
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc();

			services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();
			services.AddSingleton<ISensorDataService, SensorDataService>();
			services.AddSingleton<IViewModelService, ViewModelService>();
		}

		public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
		{
			loggerFactory.AddConsole();

			if (env.IsDevelopment())
				app.UseDeveloperExceptionPage();

			app.UseStaticFiles();
			app.UseStatusCodePages();
			app.UseMvcWithDefaultRoute();
		}
	}
}
