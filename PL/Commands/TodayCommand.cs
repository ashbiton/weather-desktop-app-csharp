using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace PL.Commands
{
    public class TodayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public event EventHandler ShowToday;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ShowToday?.Invoke(this, new EventArgs());
            //MainWindow
        }
    }
}
