using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voertuigen
{
    public class Vrachtwagen : Voertuig, IVervuiler
    {
        public Vrachtwagen()
            : base()
        {
            MaximumLading = 10000f;
        }
        public Vrachtwagen(string polishouder, decimal kostprijs, int pk, float gemiddeldVerbruik, string nummerplaat, float maximumLading)
            : base(polishouder, kostprijs, pk, gemiddeldVerbruik, nummerplaat)
        {
            MaximumLading = maximumLading;
        }

        private float maximumLadingValue;
        public float MaximumLading
        { 
            get
            {
                return maximumLadingValue;
            }
            set
            {
                if (value >= 0f)
                    maximumLadingValue = value;
            }

        }
        public override double GetKyotoScore()
        {
            double kyotoScore = 0.0;
            if (MaximumLading != 0)
            {
                kyotoScore = (GemiddeldVerbruik * Pk) / (MaximumLading / 1000.0);
            }
            return kyotoScore;

        }

        public override void Afbeelden()
        {
            Console.WriteLine("Vrachtwagen");
            base.Afbeelden();
            Console.WriteLine("Maximum Lading {0}",MaximumLading);
        }

        public double GeefVervuiling()
        {
            return GetKyotoScore()*20;
        }
    }
}
