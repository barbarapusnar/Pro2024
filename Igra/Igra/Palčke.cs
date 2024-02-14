using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Igra
{
    internal class Palčke
    {
        int štPalčk;
        int igralec;//1=igralec 1, 2=igralec 2
        public Palčke()
        {
            štPalčk = 11;
            igralec = 1;
        }
        public Palčke(int št)
        {
            štPalčk = št;
            igralec = 1;
        }
        public Palčke(int št,int i)
        {
            štPalčk= št;igralec = i;
        }
        public void VzemiPalčke(int n)
        {
            //igralec, ki je na vrsti vzame n palčk. Če je n>=1 in <=3 je ok in zamenjam igralca
            if (n >= 1 && n <= 3)
            {
                štPalčk = štPalčk - n;
                igralec = 3 - igralec;
            }
            else
            {
                Console.WriteLine("Dovoljeno je od 1 do 3 palčke. Vzeti si hotel "+n);
            }
        }
        public bool KonecIgre()
        {
            return štPalčk <= 0;
        }
        public int DobiZmagovalca()
        {
            return igralec;
        }
        public void IzpisStanja()
        {
            Console.WriteLine("Na mizi je "+štPalčk+" palčk.");
            Console.WriteLine("Na vrsti je "+igralec);
            Console.WriteLine("____________________________");
        }
    }
}
