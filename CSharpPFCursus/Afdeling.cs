using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Personeel
{
    public class Afdeling
    {
        public const int Verdiepingen = 10;
        public Afdeling(string naam, int verdieping)
        {
            Afdelingsnaam = naam;
            Verdieping = verdieping;

        }
        private string afdelingsnaam;
        public string Afdelingsnaam
        {
            get
            {
                return afdelingsnaam;
            }
            set
            {
                afdelingsnaam = value;
            }
        }

        private int verdieping;
        public int Verdieping
        {
            get
            {
                return verdieping;
            }
            set
            {
                if (value >= 0 && value <= Verdiepingen)
                    verdieping = value;
            }
        }

        // override ToString()

        public override string ToString()
        {
            return String.Format("Afdeling: {0} op verdieping {1} ",Afdelingsnaam, Verdieping);
        }
    }
}
