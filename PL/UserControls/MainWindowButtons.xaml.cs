using PL.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PL.UserControls
{
    /// <summary>
    /// Interaction logic for MainWindowButtons.xaml
    /// </summary>
    public partial class MainWindowButtons : UserControl
    {
        public TodayCommand TodayCommand { set; get; }
        public MapCommand MapCommand { set; get; }
        public ForecastCommand ForecastCommand { set; get; }

        public MainWindowButtons()
        {
            InitializeComponent();
            TodayCommand = new TodayCommand();
            MapCommand = new MapCommand();
            ForecastCommand = new ForecastCommand();
        }

    }
}
