using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap
{
    public class SpaarRekening : Rekening
    {
        private static decimal intrestValue;
        public static decimal Intrest
        {
            get
            {
                return intrestValue;
            }
            set
            {
                if (value <= 0m)
                    throw new Exception("Intrest moet positief zijn");
                    intrestValue = value;
            }
        }
        public SpaarRekening(string nummer, decimal saldo, DateTime creatieDatum, decimal intrest, Klant eigenaar)
            : base(nummer, saldo, creatieDatum, eigenaar)
        {
            Intrest = intrest;
        }

        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine("Intrest: {0}",Intrest);

        }

    }
}
