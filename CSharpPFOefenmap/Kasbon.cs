using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap
{
    public class Kasbon : ISpaarmiddel
    {
        //  interne Values
        private readonly DateTime EersteAankoop = new DateTime(1900, 1, 1);
        private DateTime aankoopDatumValue;
        private decimal bedragValue;
        private int looptijdValue;
        private decimal intrestValue;
        private Klant eigenaarValue;

        // Properties
        public DateTime AankoopDatum
        {
            get
            {
                return aankoopDatumValue;
            }
            set
            {
                if (value < EersteAankoop)
                    throw new Exception(string.Format(
                        "De aankoopdatum mag niet voor{0} zijn",
                        EersteAankoop.ToLongDateString()));

                    aankoopDatumValue = value;
            }
        }
        public decimal Bedrag
        {
            get
            {
                return Bedrag;
            }
            set
            {
                if (value < 0m)
                    throw new Exception("Bedrag moet positief zijn");
                    bedragValue = value;
            }
        }
        public int Looptijd
        {
            get
            {
                return looptijdValue;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Looptijd mag niet negarief zijn");
                    looptijdValue = value;
            }
        }
        public decimal Intrest
        {
            get
            {
                return intrestValue;
            }
            set
            {
                if (value <= 0)
                    throw new Exception("Intrest moet positief zijn");
                    intrestValue = value;
            }
        }
        public Klant Eigenaar
        {
            get
            {
                return eigenaarValue;
            }
            set
            {
                eigenaarValue = value;
            }
        }


        //constructor(s)
        public Kasbon(DateTime aankoopDatum, decimal bedrag, int looptijd, decimal intrest, Klant eigenaar)
        {
            AankoopDatum = aankoopDatum;
            Bedrag = bedrag;
            Looptijd = looptijd;
            Intrest = intrest;
            Eigenaar = eigenaar;
        }
        public void Afbeelden()
        {
            if (Eigenaar != null)
            {
                Console.WriteLine("Eigenaar");
                Eigenaar.Afbeelden();
            }
            Console.WriteLine("Aankoopdatum : {0:dd-MM-yyyy}",AankoopDatum);
            Console.WriteLine("Bedrag {0}", Bedrag);
            Console.WriteLine("Looptijd {0}", Looptijd);
            Console.WriteLine("Intrest {0}",Intrest);

        }
    }
}
