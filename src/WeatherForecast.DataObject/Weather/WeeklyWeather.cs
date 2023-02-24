using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeatherForecast.DataObject
{
    public class WeeklyWeather
    {
        [JsonProperty("temperature_2m_max")]
        public List<double> MaxTemperature { get; set; }
        [JsonProperty("temperature_2m_min")]
        public List<double> MinTemperature { get; set; }
        [JsonProperty("weathercode")]
        public List<int> Weathercode { get; set; }
    }
}
