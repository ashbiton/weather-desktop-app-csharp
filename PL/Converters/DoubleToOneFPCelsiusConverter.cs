using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace PL.Converters
{
    class DoubleToOneFPCelsiusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int result = 0;
            try
            {
                result = Int32.Parse(value.ToString());
            }
            catch(Exception e)
            {
                double d = Double.Parse(value.ToString());
                result = (int)d;
            }
            return string.Format("{0}°", result);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
