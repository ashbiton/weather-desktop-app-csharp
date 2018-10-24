using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class CityCompleteWeatherInfo
    {
        public string City { get; set; }
        public int HeightParam { get; set; }
        public int WidthParam { get; set; }
        public TodayObject._RootObject CurrInfo { get; set; }
        public List<EssentialForecastData> ForecastData { get; set; }
    }
}
