using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enkapsulacija
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student marija = new Student();
            //Console.WriteLine(marija.Izpis());
            marija.StudentId = "234";
            marija.Ime = "Barbara";
            Console.WriteLine(marija.PovprečnaOcena);
            //marija.povprečnaOcena = 9;
            //marija.star = -5;
            marija.Star = 20;
            MessageBox.Show(marija.Izpis());
            marija.Star = 13;
        }
    }
}
