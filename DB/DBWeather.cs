using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class DBWeather
    {
        private Dictionary<string,ForcastObject.RootObject> WeatherByCity = new Dictionary<string, ForcastObject.RootObject>();

        public ForcastObject.RootObject getWeatherByCity(string city)
        {
            if(WeatherByCity.ContainsKey(city))
                return WeatherByCity[city];
            else
                return null;
        }

        public void setWeatherByCity(string city, ForcastObject.RootObject rootObject)
        {
            if (!WeatherByCity.ContainsKey(city))
                WeatherByCity.Add(city, rootObject);
            else
                WeatherByCity[city] = rootObject;
        }
    }
}
