using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izpit4
{
    internal class Metalec : Atlet
    {//            Napišite podrazred Metalec,
     //            ki vsebuje specifične podatke za Metalca in
     //            sicer imeDiscipline in tabelo
     //6 metov(vsak met je neko realno število).
        string imeDiscipline;
        double[] meti = new double[6];
        //V metodi vnesiRezultat napišite kodo, s pomočjo katere
        //lahko vnesete vse mete.
        public override void vnesiRezultat()
        {
            for (int k = 0; k < 6; k++)
            {
                Console.WriteLine("Vnesi rezultat meta "+(k+1));
                meti[k] = double.Parse(Console.ReadLine());
            }
        }
        //Razredu dodajte konstruktor s 5 parametri,
        //najprej kličite konstruktor
        //baznega razreda, nato pa nastavite še ime discipline na
        //peti parameter.
        public Metalec(int s, string p, string i, string k,string d):
            base(s,p,i,k)
        {
            imeDiscipline = d;
        }
        //Skrijte metodo Izpis.V njej
        //najprej kličite metodo Izpis baznega razreda,
        //nato pa izpišite še rezultate vseh 6 metov.Dodajte
        //metodo NajboljšiMet, ki vrne najboljši met posameznega Metalca.
        public new void Izpis()
        {
            base.Izpis();
            Console.WriteLine("Disciplina "+imeDiscipline);
            for (int k=0;k<6;k++)
                Console.Write(meti[k]+"\t");
            Console.WriteLine();
        }
    }
}
