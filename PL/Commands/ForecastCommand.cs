using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PL.Commands
{
    public class ForecastCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public event EventHandler ShowForecast;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ShowForecast?.Invoke(this, new EventArgs());
        }
    }
}
