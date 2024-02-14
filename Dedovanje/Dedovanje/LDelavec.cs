using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedovanje
{
    internal class LDelavec:Delavec
    {
        private double letnaPlača;

        public double LetnaPlača { get => letnaPlača; set => letnaPlača = value; }
        public LDelavec()
        {
            Console.WriteLine("Konstruktor LDelavec");
        }
        public new double BrutoPlača
        {
            get {
                brutoPlača = letnaPlača / 12;
                return brutoPlača;
            }
        }
        public new void Izpis()
        {
            Console.WriteLine("********LETNI DELAVEC***************");
            Console.WriteLine("ID            " + delId);
            Console.WriteLine("Ime           " + ime);
            Console.WriteLine("Letna plača   " + letnaPlača);
            Console.WriteLine("Bruto plača   " + BrutoPlača);
            Console.WriteLine("*************************************");
        }
    }
}
