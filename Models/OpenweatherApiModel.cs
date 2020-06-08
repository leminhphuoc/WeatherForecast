using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherForecast.Models
{
    public class OpenweatherApiModel
    {
        [JsonProperty("weather")]
        public List<WeatherData> Weather { get; set; }

        [JsonProperty("main")]
        public TemperatureApiModel Temperature { get; set; }
    }
}