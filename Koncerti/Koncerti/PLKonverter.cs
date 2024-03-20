using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Koncerti
{
    [ValueConversion(typeof(string),typeof(PrivilegLevel))]
    internal class PLKonverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            PrivilegLevel p = (PrivilegLevel)value;
            string s = "";
            switch (p)
            {
                case PrivilegLevel.Standard:
                    s = "Standard";break;
                case PrivilegLevel.Premium:
                    s = "Premium"; break;
                case PrivilegLevel.Excecutive:
                    s = "Executive"; break;
                case PrivilegLevel.PremimExecuitve:
                    s = "Premium executive"; break;
            }
            return s;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            PrivilegLevel p = PrivilegLevel.PremimExecuitve;
            string s = (string)value;
            switch (s)
            {
                case "Standard":
                    p = PrivilegLevel.Standard; break;
                case "Premium":
                    p = PrivilegLevel.Premium; break;
                case "Executive":
                    p = PrivilegLevel.Excecutive; break;
                case "Premium executive":
                    p = PrivilegLevel.PremimExecuitve; break;
            }
            return p;
        }
    }
}
