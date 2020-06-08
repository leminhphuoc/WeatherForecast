using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WeatherForecast.API;

namespace WeatherForecast.Services
{
    public class WeatherDataSubject : ISubject
    {
        private string apiURL = "http://api.openweathermap.org/data/2.5/weather?id=1566083&APPID=73b6aef35789338c657102fbc8f8eecd";
        private decimal Temperature;
        private decimal Humidity;
        private string Weather;
        private string WeatherDescription;
        private string WeatherIcon;

        List<IObserver> observerList;

        public WeatherDataSubject()
        {
            observerList = new List<IObserver>();
        }

        public void notifyObservers()
        {
            foreach(var observer in observerList)
            {
                observer.update("Openweather",Temperature, Humidity, Weather, WeatherDescription, WeatherIcon);
            }
        }

        public void registerObserver(IObserver o)
        {
            observerList.Add(o);
        }

        public void unregisterObserver(IObserver o)
        {
            observerList.RemoveAt(observerList.IndexOf(o));
        }

        public async Task<bool> dataChanged()
        {
            var api = new OpenWeatherApi();
            var apiResult = await api.GetWeatherData(apiURL);
            Temperature = apiResult.Temperature.Temperature;
            Humidity = apiResult.Temperature.Humidity;
            Weather = apiResult.Weather.First().Weather;
            WeatherDescription = apiResult.Weather.First().WeahterDescription;
            WeatherIcon = apiResult.Weather.First().Icon;

            notifyObservers();
            return true;
        }
    }
}