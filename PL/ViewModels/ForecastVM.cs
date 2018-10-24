using BE;
using PL.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.ViewModels
{
    public class ForecastVM
    {
        ForecastModel ForecastModel { set; get; }
        public ObservableCollection<EssentialForecastData> ForecastInformation { set; get; }

        public ForecastVM(string city)
        {
            ForecastModel = new ForecastModel(city);
            ForecastInformation = new ObservableCollection<EssentialForecastData>(ForecastModel.getMinimumForcastData(city));
        }


    }
}
