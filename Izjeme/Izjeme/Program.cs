using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izjeme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //uporabnik vnese 2 števili in jaz izračunam in izpišem količnik
            try
            {
                Console.WriteLine("Vnesi deljenca od 1 do 100");
                int deljenec = int.Parse(Console.ReadLine());
                if (deljenec > 100 || deljenec < 1)
                    throw new Exception("Preveliko ali premajhno število");
                Console.WriteLine("Vnesi delitelja od 1 do 10");
                int delitelj = int.Parse(Console.ReadLine());
                double količnik = (double)deljenec / delitelj;
                Console.WriteLine("Količnik je " + količnik);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Deljenje z 0 ni dovoljeno");
            }
            catch (FormatException)
            {
                Console.WriteLine("Napačen vnos");
            }

            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            finally 
            {
                Console.WriteLine("Hvala, ker ste računali z nami");
            }
            Console.ReadLine();
        }
    }
}
