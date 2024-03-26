using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izpit4
{
    abstract class Atlet
    {
        protected int startnaŠtevilka;
        protected string priimek;
        protected string ime;
        protected string klub;
        public Atlet(int s, string p, string i, string k)
        {
            startnaŠtevilka = s; priimek = p; ime = i; klub = k;
        }
        public abstract void vnesiRezultat();
        public void Izpis()
        {
            Console.WriteLine("Startna številka " + startnaŠtevilka +
            "\nAtlet " + ime + " " + priimek +
            "\nKlub " + klub + "\n");
        }
    }
}
