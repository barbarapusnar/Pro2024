using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaštevniTipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Planeti p = Planeti.Uran;
            Console.WriteLine(p);
            //Console.WriteLine(p+" je po vrsti "+(int)p);
            if (p<=Planeti.Mars)
                Console.WriteLine("Obhodni čas je "+(int)p);
            else
                Console.WriteLine("Ne poznam obhodnega časa");
            Console.WriteLine("Vnesi obhodni čas planeta, jaz ti povem planet");
            int čas = int.Parse(Console.ReadLine());
            Console.WriteLine("Vnesel si leto na "+(Planeti)čas);
        }
    }
}
