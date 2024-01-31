using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazrediUvod
{
    internal class Napis
    {
        //lastnosti razreda
        public string najljubšiProgram;
        public static int štIzvodov;
        //obnašanje - metode
        public Napis()
        {
            Console.WriteLine("Konstruktor brez parametrov");
            najljubšiProgram = "neznan";
            štIzvodov++;
        }
        public Napis(string jezik)
        {
            Console.WriteLine("Konstruktor s parametri");
            najljubšiProgram = jezik;
            štIzvodov++;
        }
        public void Izpiši()
        {
            Console.WriteLine("Rad imam "+najljubšiProgram);
        }
        public void Koliko()
        {
            Console.WriteLine("Število izvodov je "+štIzvodov);
        }
        ~Napis()
        {
            Console.WriteLine("Uničevalec");
        }
    }
}
