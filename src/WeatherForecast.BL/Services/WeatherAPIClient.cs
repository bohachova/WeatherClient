using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherForecast.DataObject;

namespace WeatherForecast.BL
{
    public class WeatherAPIClient
    {
        const string WEATHER_API_URL = "https://api.open-meteo.com/v1";
        const string WEATHER_API_LOCATIONS_URL = "https://geocoding-api.open-meteo.com/v1";

        public async Task<WeatherForecastResponse> GetWeatherForecastAsync()
        {
            using HttpClient client = new HttpClient();

            string latitude = WeatherResponseConverter.GetCoordinateAsString(AppSettingsUtility.selectedLocation.Latitude);
            string longitude = WeatherResponseConverter.GetCoordinateAsString(AppSettingsUtility.selectedLocation.Longitude);

            client.BaseAddress = new Uri($"{WEATHER_API_URL}/forecast?latitude={latitude}&longitude={longitude}&daily=temperature_2m_max,temperature_2m_min&timezone={AppSettingsUtility.selectedLocation.Timezone}&current_weather=true");

            return await GetResultAsync<WeatherForecastResponse>(client);
        }

        public async Task<WeatherForecastResponse> Get7DaysWeatherForecastAsync()
        {
            using HttpClient client = new HttpClient();

            string latitude = WeatherResponseConverter.GetCoordinateAsString(AppSettingsUtility.selectedLocation.Latitude);
            string longitude = WeatherResponseConverter.GetCoordinateAsString(AppSettingsUtility.selectedLocation.Longitude);

            string startDate = DateTime.Today.AddDays(1).ToString("yyyy-MM-dd");
            string endDate = DateTime.Today.AddDays(7).ToString("yyyy-MM-dd");

            client.BaseAddress = new Uri($"{WEATHER_API_URL}/forecast?latitude={latitude}&longitude={longitude}&daily=temperature_2m_max,temperature_2m_min,weathercode&timezone={AppSettingsUtility.selectedLocation.Timezone}&current_weather=true&start_date={startDate}&&end_date={endDate}");

            return await GetResultAsync<WeatherForecastResponse>(client);
        }

        public async Task<LocationsResponse> SearchLocations(string location)
        {
            using HttpClient client = new HttpClient();
            client.BaseAddress = new Uri($"{WEATHER_API_LOCATIONS_URL}/search?name={location}");

            return await GetResultAsync<LocationsResponse>(client);
        }

        async Task<T> GetResultAsync<T>(HttpClient client) where T : new()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(client.BaseAddress);

                var result = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<T>(result);
            }
            catch
            {
                return new T();
            }
            
        }
    }
}
