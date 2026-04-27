using Adapter.Legacy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Project.Entities
{
    public class WeatherForcastAdabter
    {
        private readonly WeatherForecast _weather;

        public WeatherForcastAdabter(WeatherForecast weather)
        {
            _weather = weather;
        }

        public DateOnly Date => _weather.Date;

        public int TemperatureC => _weather.TemperatureC;

        public int TemperatureF => _weather.TemperatureF;

        public bool UnderZero => TemperatureC < 0;

        public string? Summary  => _weather.Summary;


    }
}
