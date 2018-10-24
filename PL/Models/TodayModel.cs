using BE;
using BL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.Models
{
    public class TodayModel
    {
        public WeatherBL WeatherBL { get; set; }

        public TodayModel()
        {
            WeatherBL = new WeatherBL();
        }

        public TodayObject._RootObject getCurrentInformation(string city)
        {
            return WeatherBL.getTodayWeatherData(city);
        }

        internal List<KeyValuePair<string, double>> getNextHoursInformation(string city)
        {
            var tempResult = WeatherBL.getForcastWeatherData(city);
            List<KeyValuePair<string, double>> result = new List<KeyValuePair<string, double>>();
            for (int i = 0; i < 8; i++)
            {
                var item = tempResult.list[i];
                result.Add(new KeyValuePair<string, double>(DateTime.Parse(item.dt_txt).ToShortTimeString(), Convert.ToInt32(item.main.temp)));
            }

            return result;
        }
    }
}
