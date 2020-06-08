using Newtonsoft.Json;

namespace WeatherForecast.Models
{
    public class TemperatureApiModel
    {
        [JsonProperty("temp")]
        public decimal Temperature { get; set; }

        [JsonProperty("humidity")]
        public decimal Humidity { get; set; }
    }
}