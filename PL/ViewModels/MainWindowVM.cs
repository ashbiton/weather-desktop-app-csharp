using PL.Commands;
using PL.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using PL.UserControls;

namespace PL.ViewModels
{
    public class MainWindowVM :INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        public event PropertyChangedEventHandler CityPropertyChanged;
        private UserControl userControl; 
        public UserControl UserControl
        {
            get { return userControl; }
            set
            {
                if (userControl == value)
                    return;
                userControl = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("UserControl"));

            }
        }

        private string city;
        public string City
        {
            get { return city; }
            set
            {
                city = value;
                if (CityPropertyChanged != null)
                    CityPropertyChanged(this, new PropertyChangedEventArgs("City"));
            }
        }
        public MainWindowButtons MainWindowButtons { set; get; }
        public TodayCommand TodayCommand { set; get; }
        public MapCommand MapCommand { set; get; }
        public ForecastCommand ForecastCommand { set; get; }
        public string[] Cities { set; get; }
        private MainModel Model { set; get; }

        public MainWindowVM()
        {
            Model = new MainModel();
            City = "Jerusalem";
            MainWindowButtons = new MainWindowButtons();
            TodayCommand = new TodayCommand();
            MapCommand = new MapCommand();
            ForecastCommand = new ForecastCommand();
            Cities = Model.getListOfCities();
            TodayCommand.ShowToday += TodayCommand_ShowToday;
            ForecastCommand.ShowForecast += ForecastCommand_ShowForecast;
            MapCommand.ViewMap += MapCommand_ViewMap;
            UserControl = new UserControls.Today("Jerusalem");
            MainWindowButtons.todayButton.IsChecked = true;
            CityPropertyChanged += MainWindowVM_CityPropertyChanged;
        }

        private void MainWindowVM_CityPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (this.UserControl.GetType().Equals(typeof(Forcast)))
                this.UserControl = new UserControls.Forcast(City);

            if (this.UserControl.GetType().Equals(typeof(Today)))
                this.UserControl = new UserControls.Today(City);
                
        }

        private void MapCommand_ViewMap(object sender, EventArgs e)
        {
            this.UserControl = new UserControls.Map();
        }

        private void ForecastCommand_ShowForecast(object sender, EventArgs e)
        {
            this.UserControl = new UserControls.Forcast(City);
        }

        private void UserControls_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
        }

        private void TodayCommand_ShowToday(object sender, EventArgs e)
        {
                this.UserControl = new UserControls.Today(City);
        }
    }
}
