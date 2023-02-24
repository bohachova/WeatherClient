using System.Collections.Generic;
using System.Linq;
using WeatherForecast.DataObject;

namespace WeatherForecast.BL
{
    public static class WeatherResponseConverter
    {
        readonly static HashSet<int> cloudRange = new HashSet<int>(Enumerable.Range(1, 3));
        readonly static HashSet<int> fogRange = new HashSet<int>(Enumerable.Range(45,4));
        readonly static HashSet<int> rainRange = new HashSet<int>(Enumerable.Range(51,17));
        readonly static HashSet<int> rainRange2 = new HashSet<int>(Enumerable.Range(80,3));
        readonly static HashSet<int> snowRange = new HashSet<int>(Enumerable.Range(71,7));
        readonly static HashSet<int> snowRange2 = new HashSet<int>(Enumerable.Range(85,2));

        readonly static HashSet<int> rangeNE = new HashSet<int>(Enumerable.Range(20, 49));
        readonly static HashSet<int> rangeE = new HashSet<int>(Enumerable.Range(70, 49));
        readonly static HashSet<int> rangeSE = new HashSet<int>(Enumerable.Range(120, 39));
        readonly static HashSet<int> rangeS = new HashSet<int>(Enumerable.Range(160, 39));
        readonly static HashSet<int> rangeSW = new HashSet<int>(Enumerable.Range(200, 49));
        readonly static HashSet<int> rangeW = new HashSet<int>(Enumerable.Range(250, 39));
        readonly static HashSet<int> rangeNW = new HashSet<int>(Enumerable.Range(290, 49));
        readonly static HashSet<int> rangeN = new HashSet<int>(Enumerable.Range(340, 19));
        readonly static HashSet<int> rangeN2 = new HashSet<int>(Enumerable.Range(0, 19));



        public static string GetCoordinateAsString(double coordinate) { return coordinate.ToString().Replace(",", "."); }

        public static WeatherCode GetWeatherCodeAsEnum(int code) 
        {
            if (cloudRange.Contains(code))
                return WeatherCode.Clouds;
            else if (fogRange.Contains(code))
                return WeatherCode.Fog;
            else if (rainRange.Contains(code) || rainRange2.Contains(code))
                return WeatherCode.Rain;
            else if (snowRange.Contains(code) || snowRange2.Contains(code))
                return WeatherCode.Snow;
            else
                return WeatherCode.Clear;
        }

        public static string ReadWindDirectionCode(int code)
        {
            if (rangeNE.Contains(code))
                return "NE";
            else if (rangeE.Contains(code))
                return "E";
            else if (rangeSE.Contains(code))
                return "SE";
            else if (rangeS.Contains(code))
                return "S";
            else if (rangeSW.Contains(code))
                return "SW";
            else if (rangeW.Contains(code))
                return "W";
            else if (rangeNW.Contains(code))
                return "NW";
            else if (rangeN.Contains(code) || rangeN2.Contains(code))
                return "N";
            else
                return "N/D";
        }

        
        
    }
}
