using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WeatherForecast.API;
using WeatherForecast.Services;

namespace WeatherForecast.Controllers
{
    public class WeatherForecastController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var observer = new WeatherForecastObserver();

            var weatherSubject = new WeatherDataSubject();

            weatherSubject.registerObserver(observer);
            await weatherSubject.dataChanged();

            var weatherData = observer.GetWeatherData();

            return View(weatherData); 
        }
    }
}