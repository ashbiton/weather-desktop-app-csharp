using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PL.Commands
{
    public class MapCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public event EventHandler ViewMap;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (ViewMap != null)
                ViewMap(this, new EventArgs());
        }
    }
}
