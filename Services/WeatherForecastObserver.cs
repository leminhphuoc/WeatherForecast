using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WeatherForecast.Models;

namespace WeatherForecast.Services
{
    public class WeatherForecastObserver : IObserver
    {
        private WeatherModel weatherModel;
        public bool isNewData = false;

        public void update(string src, decimal temp, decimal humidity, string weather, string weartherDescription, string icon = null)
        {
            icon = "http://openweathermap.org/img/wn/"+ icon + "@2x.png";
            temp = Math.Round(temp - 273);
            weatherModel = new WeatherModel() { Source = src, Temperature = temp, Humidity = humidity, Weather = weather, WeatherDescription = weartherDescription, WeatherIcon = icon };
            isNewData = true;
        }

        public WeatherModel GetWeatherData()
        {
            if(weatherModel == null)
            {
                return null;
            }
            return weatherModel;
        }
    }
}