using BE;
using InteractiveDataDisplay.WPF;
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
    /// Interaction logic for Today.xaml
    /// </summary>
    public partial class Today : UserControl
    {
        public TodayVM TodayVM { get; set; }

        public Today(string city)
        {
            InitializeComponent();
            TodayVM = new TodayVM(city);
            this.DataContext = TodayVM;
        }
        
    }
}
