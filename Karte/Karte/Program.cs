using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] barve = { "Srce","Karo","Pik","Križ"};
            string[] vrednosti = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Fant", "Kaval", "Dama", "Kralj", "As" };
            string[] kupKart = new string[barve.Length * vrednosti.Length];
            for (int k = 0; k < barve.Length; k++)
            {
                for (int j = 0; j < vrednosti.Length; j++)
                {
                    kupKart[k * vrednosti.Length + j] = barve[k] + " " + vrednosti[j];
                }
            }
            
            //mešanje : izberi naključno karto iz preostanka kupa in jo zamenjaj
            //s k-tim mestom v kupu
            Random r = new Random();
            for (int k = 0; k < kupKart.Length; k++)
            {
                int naključniIndeks = k + r.Next(kupKart.Length - k);
                string temp = kupKart[k];
                kupKart[k] = kupKart[naključniIndeks];
                kupKart[naključniIndeks] = temp;
            }
            for (int k = 0; k < kupKart.Length; k++)
            {
                Console.WriteLine(kupKart[k]);
            }
        }
    }
}
