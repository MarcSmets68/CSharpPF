using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap
{
    public class Zichtrekening : Rekening
    {
        public Zichtrekening(string nummer, decimal saldo, DateTime creatieDatum, decimal maxKrediet, Klant eigenaar)
            : base(nummer, saldo, creatieDatum, eigenaar)
        {
            MaxKrediet = maxKrediet;
        }

        private decimal maxKredietValue;
        public decimal MaxKrediet
        {
            get
            {
                return maxKredietValue;
            }
            set
            {
                if (value > 0m)
                    throw new Exception("Maximumkrediet mag niet positief zijn");
                maxKredietValue = value;
            }
        }
        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine("Max.Krediet: {0}", MaxKrediet);
        }

    }
}
