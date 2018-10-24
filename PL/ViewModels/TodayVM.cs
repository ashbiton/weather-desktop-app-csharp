using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using BE;
using PL.Models;
using System.Collections.ObjectModel;

namespace PL.ViewModels
{
    public class TodayVM
    {
        public TodayModel TodayModel { get; set; }
        public TodayObject._RootObject CurrentWeather { get; set; }
        public ObservableCollection<KeyValuePair<string,double>> NextHoursInfo { get; set; }
        public string City { get; set; }

        public TodayVM(string city)
        {
            City = city;
            TodayModel = new TodayModel();
            CurrentWeather = TodayModel.getCurrentInformation(city);
            NextHoursInfo = new ObservableCollection<KeyValuePair<string, double>>(TodayModel.getNextHoursInformation(city));
        }
        
    }
}
