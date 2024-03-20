using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Izpit1naloga
{
    internal class VBarvo : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //ploščino spremeni v barvo
            int pl = 0;
            SolidColorBrush br = new SolidColorBrush(Colors.Black);
            string ploš = (string)value;
            if (!String.IsNullOrEmpty(ploš ))
            {
                
                pl = int.Parse(ploš);
                if (pl < 7000)
                {
                    br = new SolidColorBrush(Colors.Red);
                }
                else
                { 
                  if (pl<10000)
                        br = new SolidColorBrush(Colors.Green);
                  else
                        br = new SolidColorBrush(Colors.Blue);
                }
            }
            return br;
        }
        

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
