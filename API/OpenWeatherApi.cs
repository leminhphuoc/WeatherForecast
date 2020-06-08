using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherForecast.Models;

namespace WeatherForecast.API
{
    public class OpenWeatherApi
    {
        public async Task<OpenweatherApiModel> GetWeatherData(string apiUrl)
        { 
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var apiData = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<OpenweatherApiModel>(apiData);
                    return result;
                }
            }
            return null;
        }
    }
}