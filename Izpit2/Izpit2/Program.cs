using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izpit2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Zapišite tudi začetni razred z metodo Main().
            //  V metodi Main() najprej ustvarite izvod razreda Prevoznik
            //  z imenom janez.Nastavite lastnost šifra objekta janez
            //  na "755", lastnost ime na »Janez Kranjski« ,
            //  lastnost licenca na »CLD« .
            //  Povečajte število ur za 7, izpišite podatke o pilotu,
            //  nato pa poskusite zmanjšati število ur za -10.
            //  Ponovno izpišite podatke o pilotu.
            Prevoznik janez = new Prevoznik();
            janez.Šifra = "755";
            janez.Ime = "Janze Kranjski";
            janez.Licenca = "CLD";
            janez.SpremeniUre(7);
            janez.Izpis();
            janez.SpremeniUre(-10);
            janez.Izpis();
            Console.ReadLine();
        }
    }
}
