using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BL
{
    public class WeatherBL
    {
        WeatherDAL dal = new WeatherDAL();

        //public ForcastObject.RootObject getTodayLongWeatherData(string city)
        //{
        //    ForcastObject.RootObject rootObject = dal.GetWeatherData(city);
        //    ForcastObject.RootObject todayRoot = rootObject;
        //    todayRoot.list = new List<ForcastObject.List>();
        //    foreach (var item in rootObject.list)
        //    {
        //        if (IsToday(item.dt_txt))
        //            todayRoot.list.Add(item);
        //    }
        //    return todayRoot;
        //}

        public TodayObject._RootObject getTodayWeatherData(string city)
        {
            return dal.getNowWeather(city);
        }

        private bool IsToday(string date)
        {
            DateTime dateTime = DateTime.Parse(date);
            if (dateTime.Day == DateTime.Now.Day && dateTime.Month == DateTime.Now.Month)
                return true;
            else return false;
        }

        public ForcastObject.RootObject getForcastWeatherData(string city)
        {
            return dal.getForcastDataByCity(city);
        }

        public List<EssentialForecastData> getMinimumForcastData(string city)
        {
            ForcastObject.RootObject rootObject = getForcastWeatherData(city);
            List<EssentialForecastData> result = new List<EssentialForecastData>();
            string currDate = DateTime.Parse(rootObject.list[0].dt_txt).DayOfWeek.ToString().Substring(0, 3);
            CultureInfo culture = new CultureInfo("USA");
            currDate += "/" + DateTime.Parse(rootObject.list[0].dt_txt).Day + " " + DateTime.Parse(rootObject.list[0].dt_txt).ToString("MMMM", culture);
            int minTemp = Convert.ToInt32(rootObject.list[0].main.temp_min);
            int maxTemp = Convert.ToInt32(rootObject.list[0].main.temp_max);
            string icon = rootObject.list[0].weather[0].icon;
            foreach (var item in rootObject.list)
            {
                string itemDate = DateTime.Parse(item.dt_txt).DayOfWeek.ToString().Substring(0, 3);
                itemDate += "/" + DateTime.Parse(item.dt_txt).Day + " " + DateTime.Parse(item.dt_txt).ToString("MMMM", culture);
                if (itemDate != currDate)
                {

                    result.Add(new EssentialForecastData { DayDate = currDate, MaxTemp = maxTemp, MinTemp = minTemp, Icon = icon });
                    currDate = itemDate;
                    minTemp = Convert.ToInt32(item.main.temp_min);
                    maxTemp = Convert.ToInt32(item.main.temp_max);
                }

                else
                {
                    if (item.main.temp_max > maxTemp)
                    {
                        maxTemp = Convert.ToInt32(item.main.temp_max);
                        icon = item.weather[0].icon;
                    }
                    if (item.main.temp_min < minTemp)
                        minTemp = Convert.ToInt32(item.main.temp_min);
                }
            }
            return result;
        }
    }
}
