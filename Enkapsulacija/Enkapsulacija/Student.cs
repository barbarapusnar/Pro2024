using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Enkapsulacija
{
    internal class Student
    {
        private string studentId;
        public string StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }

        public string Ime { get => ime; set => ime = value; }
        public string Naslov { get => naslov; set => naslov = value; }
        public double PovprečnaOcena { get => povprečnaOcena;  }
        public int Star { 
            get => star;
            set {
                if (value > 18)
                    star = value;
                else
                    throw new Exception("Napačna starost");            
            } 
        }

        private string ime;

        private string naslov;
        private int star;
        private double povprečnaOcena;
        public Student()
        {
            studentId = "1234";
            ime = "Marija Novak";
            naslov = "Cankarjeva 7, Nova Gorica";
            star = 20;
            povprečnaOcena = 7.5;
        }
        public string Izpis()
        {
            string zaIzpis = "";
            zaIzpis += "*******ŠTUDENT******"+Environment.NewLine;
            zaIzpis += "Id        " + studentId + Environment.NewLine;
            zaIzpis += "Ime       " + ime + Environment.NewLine;
            zaIzpis += "Naslov    " + naslov + Environment.NewLine;
            zaIzpis += "Starost   " + star + Environment.NewLine;
            zaIzpis += "Povprečje " + povprečnaOcena + Environment.NewLine;
            return zaIzpis;
        }
    }
}
