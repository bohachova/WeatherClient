using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeatherForecast.DataObject
{
    public class LocationsResponse
    {
        [JsonProperty("results")]
        public List<Location> Results { get; set; }
    }
}
