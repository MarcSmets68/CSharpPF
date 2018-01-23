using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voertuigen
{
    public abstract class Voertuig: IPrivaat, IMilieu
    {
        //Constructors
        public Voertuig() : this("onbepaald", 0m, 0, 0f, "onbepaald")
        {
        }
        public Voertuig(string polishouder, decimal kostprijs, int pk, float gemiddeldVerbruik, string nummerplaat)
        {
            this.Polishouder = polishouder;
            this.Kostprijs = kostprijs;
            this.Pk = pk;
            this.GemiddeldVerbruik = gemiddeldVerbruik;
            this.Nummerplaat = nummerplaat;

        }

        //Values
        private string polishouderValue;
        private decimal kostprijsValue;
        private int pkValue;
        private float gemiddeldVerbruikValue;
        private string nummerplaatValue;

        //Properties
        public string Polishouder
        {
            get
            {
                return polishouderValue;

            }
            set
            {
                polishouderValue = value;
            }

        }

        public decimal Kostprijs
        {
            get
            {
                return kostprijsValue;
            }

            set
            {
                if (value > 0m)
                    kostprijsValue = value;
            }
        }

        public string Nummerplaat
        {
            get
            {
                return nummerplaatValue;
            }

            set
            {
                nummerplaatValue = value;
            }
        }

        public int Pk
        {
            get
            {
                return pkValue;
            }

            set
            {
                if (value >= 0)
                    pkValue = value;
            }
        }

        public float GemiddeldVerbruik
        {
            get
            {
                return gemiddeldVerbruikValue;
            }

            set
            {
                if (value >= 0f)
                    gemiddeldVerbruikValue = value;
            }
        }

        public virtual void Afbeelden()
        {
            Console.WriteLine("Polishouder: {0}", Polishouder);
            Console.WriteLine("Kostprijs: {0}", Kostprijs);
            Console.WriteLine("Aantal pk: {0}", Pk);
            Console.WriteLine("Gemiddeld verbruik: {0}", GemiddeldVerbruik);
            Console.WriteLine("Nummerplaat: {0}", Nummerplaat);
        }

        public abstract double GetKyotoScore();

        public string GeefMilieuData()
        {
            return string.Format("PK : {0} - kostprijs : {1} - Verbruik : {2}",Pk,Kostprijs,GemiddeldVerbruik);
        }

        public string GeefPrivateData()
        {
            return string.Format("Polishouder : {0} - Nummerplaat {1}", Polishouder, Nummerplaat);
        }
    }
}
