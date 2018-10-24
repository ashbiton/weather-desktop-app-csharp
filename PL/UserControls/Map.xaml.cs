using PL.Commands;
using PL.ViewModels;
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
    /// Interaction logic for Map.xaml
    /// </summary>
    public partial class Map : UserControl
    {
        public MapVM MapVM { get; set; }

        public Map()
        {
            InitializeComponent();
            MapVM = new MapVM("Jerusalem","Tel Aviv","Haifa","Beer Sheva","Eilat","Zefat","Tiberias");
            this.DataContext = MapVM.CitiesWeatherInfo;
           
        }
    }
}
