using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izpit1naloga
{
    internal class Pravokotnik
    {
        private int a;
        private int b;

        public int A
        {
            get => a;
            set {
                if (value < 0)
                    throw new Exception("Vrednost mora biti +");
                a = value; }
        }
        public int B
        {
            get => b;
            set {
                if (value < 0)
                    throw new Exception("Vrednost mora biti +");
                b = value; }

        }    
    }
}
