using Newtonsoft.Json;

namespace WeatherForecast.DataObject
{
    public class WeatherForecastResponse
    {
        [JsonProperty("current_weather")]
        public CurrentWeather CurrentWeather { get; set; }

        [JsonProperty("daily")]
        public WeeklyWeather WeeklyWeather { get; set; }
    }
}
