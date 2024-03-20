using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koncerti
{
    enum PrivilegLevel { Standard, Premium, Excecutive, PremimExecuitve}
    internal class NakupKarte
    {
        private string imeDogodka;
        private string štKupca;
        private PrivilegLevel nivo;
        private int štVstopnic;
        public bool PreveriŠtVstopnic(PrivilegLevel p, int š)
        {
            bool vrni = false;
            switch (p)
            {
                case PrivilegLevel.Standard:
                    vrni = š <= 2;
                    break;
                case PrivilegLevel.Premium:
                    vrni = š <= 4;
                    break;
                case PrivilegLevel.Excecutive:
                    vrni = š <= 8;
                    break;
                case PrivilegLevel.PremimExecuitve:
                    vrni = š <= 10;
                    break;
            }
            return vrni;
        }
        public string ImeDogodka 
        {   get => imeDogodka;
            set 
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new Exception("Obvezen podatek");
                imeDogodka = value; 
            } 
        }

        public string ŠtKupca 
        { 
            get => štKupca;
            set 
            {  if (String.IsNullOrEmpty(value))
                    throw new Exception("Št. kupca je obvezna");
                štKupca = value; 
            }
        
        }

        public int ŠtVstopnic 
        { 
            get => štVstopnic;
            set {
                if (!PreveriŠtVstopnic(nivo, value))
                    throw new Exception("Napačno število za ta status");
                štVstopnic = value;
            } 
        }

        public PrivilegLevel Nivo 
        { 
            get => nivo;
            set 
            {
                if (!PreveriŠtVstopnic(value, štVstopnic))
                    throw new Exception("Napačno število za ta status");
                nivo = value; 
            } 
        }
    }
}
