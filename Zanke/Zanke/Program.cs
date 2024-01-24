using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zanke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UČIMO SE POŠTEVANKO");
            //Console.WriteLine("Vnesi karkoli K=konec");
            string vnos = "";// Console.ReadLine();
            Random r = new Random();
            do
            {
                int prvo = r.Next(1, 11); //izmisli si naključno število med 1 in 10
                int drugo = r.Next(1, 11);
                Console.Write(prvo + "x" + drugo + " = ");
                int rešitev = int.Parse(Console.ReadLine());
                if (prvo * drugo == rešitev)
                {
                    Console.WriteLine("Pravilno");
                }
                else
                {
                    Console.WriteLine("Napačno");
                }
                //sprememba pogoja
                Console.WriteLine("Nadljujem ? K=konec");
                vnos = Console.ReadLine();
            } while (vnos.ToUpper() != "K");
            Console.WriteLine("Konec zanke");
            Console.ReadLine();
        }
    }
}
