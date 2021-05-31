using ItemService.Controllers;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using Xunit;

namespace ItemService.UnitTests
{
    public class WeatherForecastControllerTests
    {
        private readonly static ILogger<WeatherForecastController> _logger;
        private readonly WeatherForecastController weatherForecastController = new WeatherForecastController(_logger);
        [Fact]
        public void WeatherForecastController_Get_Returns_WeatherSummary()
        {
            IEnumerable<WeatherForecast> listOfWeatherForecasts =  weatherForecastController.Get();
            Xunit.Assert.NotNull(listOfWeatherForecasts);
        }
    }
}
