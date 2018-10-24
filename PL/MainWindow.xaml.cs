using BE;
using PL.Commands;
using PL.UserControls;
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

namespace PL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindowVM CurrentVM { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            ToolTipService.ShowDurationProperty.OverrideMetadata(
                typeof(DependencyObject), new FrameworkPropertyMetadata(Int32.MaxValue));
            CurrentVM = new MainWindowVM();
            this.DataContext = CurrentVM;
            //Icon="C:\Users\Computer\Desktop\WeatherApp\PL\Images\weather-icon-with-sun-and-clouds-vector-11107180.jpg"
        }

    }
}
