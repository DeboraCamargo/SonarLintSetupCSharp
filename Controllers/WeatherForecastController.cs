using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace SonarLintSetup.Controllers
	{
	[ApiController]
	[Route("[controller]")]
	public class WeatherForecastController : ControllerBase
		{
		private static readonly string[] Summaries = new[]
		{
		"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
	};

		private readonly ILogger<WeatherForecastController> _logger;

		public WeatherForecastController (ILogger<WeatherForecastController> logger)
			{
			_logger = logger;
			}

		[HttpGet(Name = "GetWeatherForecast")]
		public IEnumerable<WeatherForecast> Get ()
			{
			return Enumerable.Range(1, 5).Select(index => new WeatherForecast
				{
				Date = DateTime.Now.AddDays(index),
				TemperatureC = Random.Shared.Next(-20, 55),
				Summary = Summaries[Random.Shared.Next(Summaries.Length)]
				})
			.ToArray();
			}

		[HttpGet(Name = "GetWeatherForecastById")]
		public WeatherForecast GetById()
			{
			string await = "Bob";
			return new WeatherForecast
				{
				Date = DateTime.UtcNow,
				TemperatureC = Random.Shared.Next(-20, 55),
				Summary = Summaries[Random.Shared.Next(Summaries.Length)],
				Name = await
				};
			}

		public void WriteMatrix ( int[][] matrix ) // Non-Compliant
			{
			}
		}
	}
