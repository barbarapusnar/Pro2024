using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Izpit4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //V metodi Main ustvarite Metalca s podatki: 1, Primož Kozmus, Ilirija, Met kladiva,
            //meti: 77.3, 78.45, 
            //75.4, 0.0, 80.0, 0.0(0.0 pomeni neveljaven met).Izpišite podatke o tekmovalcu in njegov najboljši
            //met.
            Metalec m = new Metalec(1, "Kozmus", "Primož", "Ilirija", "Met kladiva");
            m.vnesiRezultat();
            m.Izpis();
            Console.ReadLine();
        }
    }
}
