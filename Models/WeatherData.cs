using Newtonsoft.Json;

namespace WeatherForecast.Models
{
    public class WeatherData
    {
        [JsonProperty("main")]
        public string Weather  { get; set; }

        [JsonProperty("description")]
        public string WeahterDescription { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }
    }
}