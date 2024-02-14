using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaAbs
{
    internal abstract class DelavecBazni
    {
        protected string delId;
        protected string ime;
        protected double brutoPlača;
        public DelavecBazni(string d, string i)
        {
            DelId = d;ime = i;
        }
        public DelavecBazni()
        {

        }
        public string DelId { get => delId; set => delId = value; }
        public string Ime { get => ime; set => ime = value; }
        public abstract double BrutoPlača { get; }
        public abstract void Izpis();
    }
}
