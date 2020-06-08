using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherForecast.Models
{
    public class WeatherModel
    {
        public decimal Temperature { get; set; }
        public decimal Humidity { get; set; }
        public string Weather { get; set; }
        public string WeatherDescription { get; set; }
        public string WeatherIcon { get; set; }
        public string Source { get; set; }
    }
}