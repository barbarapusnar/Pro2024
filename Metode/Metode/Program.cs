using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IzpišiSporočilo("C#","zelo");
            string a = "Java";
            IzpišiSporočilo(a);
            Console.WriteLine("Kateri je tvoj najljubši jezik?");
            string x = Console.ReadLine();
            IzpišiSporočilo(x," najbolj");
            IzpišiSporočilo(42);
            
        }
        static void IzpišiSporočilo(string jezik,string koliko)
        {
            Console.WriteLine("Rad imam "+jezik+" "+koliko);
           
        }
        static void IzpišiSporočilo(string jezik)
        {
            Console.WriteLine("Rad imam " + jezik );
        }
        static void IzpišiSporočilo(int število)
        {
            Console.WriteLine("Najljubše število " + število);
        }
        
    }
}
