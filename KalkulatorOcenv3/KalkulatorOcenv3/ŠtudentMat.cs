using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorOcenv3
{
    internal class ŠtudentMat : Študent
    {
        public override string Izpis()
        {
            string r = "";
            r += "***********ŠTUDENT MATEMATIKE ************"+Environment.NewLine;
            r += "Delni izpit 1: " + Delni1 + Environment.NewLine;
            r += "Delni izpit 2: " + Delni2 + Environment.NewLine;
            r += "Končna ocena " + KončnaOcena() + Environment.NewLine;
            r += "Črka         " + Črka() + Environment.NewLine;
            return r;
        }

        public override double KončnaOcena()
        {
            return 0.5 * Delni1 + 0.5 * Delni2;
        }

        public override string Črka()
        {
            if (KončnaOcena() >= 90)
                return "A";
            if (KončnaOcena() >= 83)
                return "B";
            if (KončnaOcena() >= 76)
                return "C";
            if (KončnaOcena() >= 65)
                return "D";
            return "F";
        }
    }
}
