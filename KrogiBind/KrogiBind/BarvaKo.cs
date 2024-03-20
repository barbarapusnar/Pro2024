using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace KrogiBind
{ 
[ValueConversion(typeof(string),typeof(SolidColorBrush))]
    internal class BarvaKo : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string a = (string)value; //je v textboxu polmer
            int x = 0;
            if (a != "")
                x = int.Parse(a);
            SolidColorBrush br = new SolidColorBrush();
            if (x <= 100)
                br.Color = Colors.Red;
            else
                if (x <= 200)
                br.Color = Colors.Green;
            else
                br.Color = Colors.Blue;
            return br;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
