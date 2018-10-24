using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace PL.Models
{ 
    public class MapModel
    {
        public WeatherBL WeatherBL { get; set; }
        public MapModel()
        {
            WeatherBL = new WeatherBL();
        }

        public TodayObject._RootObject getTodayInformation(string city)
        {
            return WeatherBL.getTodayWeatherData(city);
        }

        public List<EssentialForecastData> getForecastInformation(string city)
        {
            return WeatherBL.getMinimumForcastData(city);
        }
    }
}
