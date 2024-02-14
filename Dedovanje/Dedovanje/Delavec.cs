using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedovanje
{
    internal class Delavec
    {
        protected string delId;
        protected string ime;
        protected double urnaPostavka;
        protected int štUr;
        protected double brutoPlača;

        public string DelId { get => delId; set => delId = value; }
        public string Ime { get => ime; set => ime = value; }
        public double UrnaPostavka { get => urnaPostavka; set => urnaPostavka = value; }
        public int ŠtUr { get => štUr; set => štUr = value; }
        public double BrutoPlača 
        {  
            get {
                brutoPlača = štUr * urnaPostavka;
                return brutoPlača; 
            }
        }
        public Delavec()
        {
            Console.WriteLine("Konstruktor razreda delavec");
        }
        public void Izpis()
        {
            Console.WriteLine("***************DELAVEC***************");
            Console.WriteLine("ID            "+delId);
            Console.WriteLine("Ime           "+ime);
            Console.WriteLine("Urna postavka " + urnaPostavka);
            Console.WriteLine("Število ur    " + štUr);
            Console.WriteLine("Bruto plača   "+BrutoPlača);
            Console.WriteLine("*************************************");
        }
    }
}
