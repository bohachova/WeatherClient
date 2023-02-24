using Newtonsoft.Json;
using System.IO;
using WeatherForecast.DataObject;

namespace WeatherForecast.BL
{
    public static class AppSettingsUtility
    {
        const string PATH = "settings.json";
        public static Location selectedLocation { get; set; }

        public static void SaveSettings ()
        {
            var data = JsonConvert.SerializeObject(selectedLocation);
            File.WriteAllText(PATH, data);
        }
        public static void ReadSettings()
        {
            if (File.Exists(PATH))
            {
                try
                {
                    var data = File.ReadAllText(PATH);
                    selectedLocation = JsonConvert.DeserializeObject<Location>(data);
                }
                catch 
                {
                    return;
                }
                
            }
        }
    }
}
