using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap
{
    public abstract class Rekening: ISpaarmiddel
    {
        private readonly DateTime EersteCreatie = new DateTime(1900, 1, 1);
        private string rekeningNummerValue;
        private decimal saldoValue;
        private DateTime creatieDatumValue;

        // definitie van de delegate
        public delegate void Transactie(Rekening rekening);
        // Declaratie van de events
        public event Transactie RekeningUittreksel;
        public event Transactie SaldoInHetRood;

        private decimal vorigSaldoValue;
        public decimal VorigSaldo
        {
            get
            {
                return vorigSaldoValue;
            }
            set
            {
                vorigSaldoValue = value;
            }
        }
        public string RekeningNummer
        {
            get
            {
                return rekeningNummerValue;
            }
            set
            {
                if (! IsGeldigRekeningNummer(value))
                {
                    throw new Exception(string.Format("Ongeldig rekeningnummer!"));
                    
                }
                rekeningNummerValue = value;
            }
        }
        public decimal Saldo
        {
            get
            {
                return saldoValue;
            }
            set
            {
                saldoValue = value;

            }

        }
        public DateTime CreatieDatum
        {
            get
            {
                return creatieDatumValue;
            }
            set
            {
                if (value < EersteCreatie)
                {
                    throw new Exception(string.Format(
                        "De creatiedatum mag niet voor {0} zijn'",
                        EersteCreatie.ToLongDateString()));
                    creatieDatumValue = value;
                }
            }
        }
        private Klant eigenaarValue;
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
        public Rekening(string nummer, decimal saldo, DateTime creatieDatum, Klant eigenaar)
        {
            RekeningNummer = nummer;
            Saldo = saldo;
            CreatieDatum = creatieDatum;
            Eigenaar = eigenaar;
        }
       



        public virtual void Afbeelden()
        {
            if (Eigenaar != null)
            {
                Console.WriteLine("Eigenaar : ");
                Eigenaar.Afbeelden();
            }

            Console.WriteLine("Rekeningnummer {0}", RekeningNummer);
            Console.WriteLine("Saldo : {0}", Saldo);
            Console.WriteLine("Creatiedatum {0:dd-MM-yyyy}", CreatieDatum);

        }
        public void Storten(decimal bedrag)
        {
            VorigSaldo = Saldo;
            Saldo += bedrag;
            if (RekeningUittreksel != null)
                RekeningUittreksel(this);
        }
        public void Afhalen(decimal bedrag)
        {
            VorigSaldo = Saldo;
            if (bedrag <= Saldo)
            {
                Saldo -= bedrag;
                if (RekeningUittreksel != null)
                    RekeningUittreksel(this);
            }
            else
            {
                if (SaldoInHetRood != null)
                    SaldoInHetRood(this);
            }
        }

        private bool IsGeldigRekeningNummer(string rekeningNummer)
        {
            if (string.IsNullOrWhiteSpace(rekeningNummer))
                return false;
            if (rekeningNummer.Length != 16)
                return false;
            if (rekeningNummer.Substring(0, 2) != "BE")
                return false;
            int derdeVierdeTeken;
            if (!int.TryParse(rekeningNummer.Substring(2, 2), out derdeVierdeTeken))
                return false;
            ulong belgischRekeningNummer;
            if (!ulong.TryParse(rekeningNummer.Substring(4, 12), out belgischRekeningNummer))
                return false;
            ulong eerste10 = belgischRekeningNummer / 100ul;
            int laatste2 = (int)(belgischRekeningNummer % 100ul);
            return (int)(eerste10 % 97ul) == laatste2;

        }
    }
}
