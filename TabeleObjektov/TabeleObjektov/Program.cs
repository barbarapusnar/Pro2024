using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabeleObjektov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Napis[] vsi = new Napis[3]; //inicializacija tabele
            //vsi[0] = new Napis(); //inicializira izvod razreda Napis
            //vsi[0].Izpiši();
            for (int k = 0; k < vsi.Length; k++)
            {
                vsi[k] = new Napis();
                vsi[k].Izpiši();
            }

        }
    }
}
