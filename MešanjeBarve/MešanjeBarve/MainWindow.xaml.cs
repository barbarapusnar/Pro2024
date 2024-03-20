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

namespace MešanjeBarve
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sldRdeča_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte r = (byte)sldRdeča.Value;
            byte g = (byte)sldZelena.Value;
            byte b = (byte)sldModra.Value;
            p1.Fill = new SolidColorBrush(Color.FromRgb(r, g, b));
        }

        private void sldZelena_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte r = (byte)sldRdeča.Value;
            byte g = (byte)sldZelena.Value;
            byte b = (byte)sldModra.Value;
            p1.Fill = new SolidColorBrush(Color.FromRgb(r, g, b));
        }

        private void sldModra_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte r = (byte)sldRdeča.Value;
            byte g = (byte)sldZelena.Value;
            byte b = (byte)sldModra.Value;
            p1.Fill = new SolidColorBrush(Color.FromRgb(r, g, b));
        }
    }
}
