﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap
{
    class BankBediende
    {
        private string voornaamValue;

        public string Voornaam
        {
            get { return voornaamValue; }
            set { voornaamValue = value; }
        }
        private string naamValue;

        public string Naam
        {
            get { return naamValue; }
            set { naamValue = value; }
        }
        public BankBediende(string voornaam, string naam)
        {
            Voornaam = voornaam;
            Naam = Naam;
        }
        public override string ToString()
        {
            return "BankBediende " + Voornaam + ' ' + Naam;
        }
        public void RekeningUittrekselTonen(Rekening rekening)
        {
            Console.WriteLine("Datum: {0:dd-MM-yyy}", DateTime.Today);
            Console.WriteLine("Rekeninguittreksel van " +
                "rekening {0}", rekening.RekeningNummer);
            Console.WriteLine("Vorig Saldo: {0} euro", rekening.VorigSaldo);
            if (rekening.Saldo > rekening.VorigSaldo)
            {
                Console.WriteLine("Storting van {0} euro.",
                    rekening.Saldo - rekening.VorigSaldo);

            }
            else
            {
                Console.WriteLine("Afhaling van {0} euro",
                    rekening.VorigSaldo - rekening.Saldo);
            }
            Console.WriteLine("Nieuw saldo {0} euro",
            rekening.Saldo);

        }

        public void SaldoInHetRoodMelden(Rekening rekening)
        {
            Console.WriteLine("Afhaling niet mogelijk, saldo ontoereikend");
            Console.WriteLine("Maximum af te halen bedrag : {0} euro",rekening.Saldo);
        }





    }
}
