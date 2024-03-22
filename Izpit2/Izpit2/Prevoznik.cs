using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Izpit2
{
    internal class Prevoznik
    {
        //  Vsebuje naj zasebne izvodove spremenljivke šifra(niz),
        //  ime(niz),štUr(celo število), licenca(niz),
        private string šifra;
        private string ime;
        private int štUr;
        private string licenca;

        public string Šifra { get => šifra; set => šifra = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Licenca { get => licenca; set => licenca = value; }
        //  lastnosti Šifra,
        //  Ime in Licenca(vse naj imajo metodi get in set)

        //  in metodo SpremeniUre, ki sprejme en celoštevilski
        //  argument.Metoda naj izračuna novo število ur vožnje
        //  prevoznika, tako da trenutnemu številu ur (štUr)
        //  prišteje vrednost argumenta.
        //  Če je argument negativno število, naj opozori uporabnika
        //  o napaki in ne zmanjšujte števila ur.
        public void SpremeniUre(int u)
        {
            if (u >= 0)
                štUr = štUr + u;
            else
                Console.WriteLine("Število ur mora biti pozitivno");

        }
        //  Razred Prevoznik naj vsebuje  tudi metodo Izpis,
        //  ki izpiše na zaslon (kar na konzolo) podatke o pilotu.
        public void Izpis()
        {
            Console.WriteLine("******PREVOZNIK*********");
            Console.WriteLine("Šifra   "+šifra);
            Console.WriteLine("Ime     "+ime);
            Console.WriteLine("Št. ur  "+štUr);
            Console.WriteLine("Licenca "+licenca);
            Console.WriteLine("************************");
        }
        //  V konstruktorju razreda Prevoznik nastavite štUr na 0.
        public Prevoznik()
        {
            štUr = 0;
        }
        

    }
}
