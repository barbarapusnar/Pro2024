using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnir
{
    internal class Ekipa
    {
        string ime;
        int štTekem;
        int štZmag;
        int štNeodločenih;
        int daniGoli;
        int prejetiGoli;

        public string Ime { get => ime; set => ime = value; }

        public Ekipa(string i)
        {
            ime = i;
            štTekem = 0;štZmag = 0;štNeodločenih = 0;daniGoli = 0;
            prejetiGoli = 0;
        }
        public void VpisRezultata(int d, int p)
        {
            //vpiši rezultat za ekipo d=dani goli, p=prejeti goli
            daniGoli += d;
            prejetiGoli += p;
            štTekem++;
            if (d > p)
                štZmag++;
            if (d == p)
                štNeodločenih++;
        }
        //koliko ima ekipa točk
        public int ŠtTočk()
        {
            return štZmag * 3 + štNeodločenih;
        }
        public int GolRazlika() //lahko je negativna
        {
            return daniGoli - prejetiGoli;
        }
        public string Izpis()
        {
            return ime + "\t" + ŠtTočk() + "\t" + GolRazlika() + "\t" + daniGoli;
        }
        public bool BoljšaEkipa(Ekipa x)
        {
            if (this.ŠtTočk() > x.ŠtTočk())
                return true;
            if (this.ŠtTočk() == x.ŠtTočk() && this.GolRazlika() > x.GolRazlika())
                return true;
            if (this.ŠtTočk() == x.ŠtTočk() &&
                this.GolRazlika() == x.GolRazlika() &&
                this.daniGoli > x.daniGoli)
                return true;
            return false;
        }
    }
}
