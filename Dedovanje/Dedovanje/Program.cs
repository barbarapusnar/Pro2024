using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedovanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Delavec d = new Delavec();
            d.DelId = "098";
            d.Ime = "Janez Novak";
            d.UrnaPostavka = 8;
            d.ŠtUr = 176;
            d.Izpis();
            LDelavec a = new LDelavec();
            a.DelId = "111";
            a.Ime = "Miha Kovač";
            a.LetnaPlača = 12000;
            a.Izpis();
        }
    }
}
