using Newtonsoft.Json;

namespace WeatherForecast.DataObject
{
    public class Location
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("latitude")]
        public double Latitude { get; set; }
        [JsonProperty("longitude")]
        public double Longitude { get; set; }
        [JsonProperty("timezone")]
        public string Timezone { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("admin1")]
        public string AdminRegion { get; set; }
    }
}
