using Newtonsoft.Json;

namespace WeatherForecast.DataObject
{
    public class CurrentWeather
    {
        [JsonProperty("temperature")]
        public double Temperature { get; set; }
        [JsonProperty("weathercode")]
        public int WeatherCode { get; set; }
        [JsonProperty("windspeed")]
        public double Windspeed { get; set; }
        [JsonProperty("winddirection")]
        public double WindDirection { get; set; }
    }
}
