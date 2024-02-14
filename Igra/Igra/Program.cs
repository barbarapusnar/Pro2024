using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Igra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //igraj igro
            Palčke p = new Palčke();
            while (!p.KonecIgre())
            {
                p.IzpisStanja();
                Console.WriteLine("Koliko palčk vzameš?");
                int število = int.Parse(Console.ReadLine());
                p.VzemiPalčke(število);
            }
            Console.WriteLine("Zmagal je " + p.DobiZmagovalca());
        }
    }
}
