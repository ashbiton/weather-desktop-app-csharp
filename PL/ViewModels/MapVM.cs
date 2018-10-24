using PL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace PL.ViewModels
{
    public class MapVM
    {
        MapModel MapModel { set; get; }
        public ObservableCollection<CityCompleteWeatherInfo> CitiesWeatherInfo;
        public MapVM(params string[] cities)
        {
            MapModel = new MapModel();
            CitiesWeatherInfo = new ObservableCollection<CityCompleteWeatherInfo>();
            FillCollection(cities);
        }

        private void FillCollection(string[] cities)
        {
            List<EssentialForecastData> forecastData = new List<EssentialForecastData>();
            TodayObject._RootObject currData = new TodayObject._RootObject();

            foreach(string city in cities)
            {

                forecastData = MapModel.getForecastInformation(city);
                currData = MapModel.getTodayInformation(city);
                CitiesWeatherInfo.Add(
                    new CityCompleteWeatherInfo
                    {
                        City = city,
                        ForecastData = forecastData,
                        CurrInfo = currData
                    });
            }
            //city = "Jerusalem";
            //forecastData = MapModel.getForecastInformation(city);
            //currData = MapModel.getTodayInformation(city);
            //CitiesWeatherInfo.Add(
            //    new CityCompleteWeatherInfo
            //    {
            //        City = city,
            //        ForecastData = forecastData,
            //        CurrInfo = currData
            //    });

            //city = "Tel Aviv";
            //forecastData = MapModel.getForecastInformation(city);
            //currData = MapModel.getTodayInformation(city);
            //CitiesWeatherInfo.Add(
            //    new CityCompleteWeatherInfo
            //    {
            //        City = city,
            //        ForecastData = forecastData,
            //        CurrInfo = currData
            //    });
        }
    }
}
