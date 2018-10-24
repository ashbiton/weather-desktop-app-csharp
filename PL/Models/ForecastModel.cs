using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;

namespace PL.Models
{
    public class ForecastModel
    {
        WeatherBL WeatherBL { set; get; }
        public ForecastModel(string city)
        {
            WeatherBL = new WeatherBL();
        }

        public List<EssentialForecastData> getMinimumForcastData(string city)
        {
            return WeatherBL.getMinimumForcastData(city);
        }
    }
}
