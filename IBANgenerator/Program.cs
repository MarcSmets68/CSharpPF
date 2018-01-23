using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBANgenerator
{
    class Program
    {
        const string ALFABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static void Main(string[] args)
        {
            string rekeningNummer, controleRekening, controlenummer, controleGetal;
            ulong rest97;
            rekeningNummer = "739-0102134-91";
            controleRekening = rekeningNummer.Replace("-", "") + "BE00";
            //Console.WriteLine(controleRekening);

            controlenummer = VervangLetters(controleRekening);
            //Console.WriteLine(controlenummer);
            rest97 = ulong.Parse(controlenummer) % 97ul;
            controleGetal = (98 - rest97).ToString();
            //Console.WriteLine(controleGetal);

            string nummerIban = controlenummer.Remove(12);
            Console.WriteLine("BE" + controleGetal + " " + nummerIban.Insert(12," ").
                Insert(8," ").Insert(4," "));
            

       
        }
        private static string VervangLetters(string nummer)
        {
            char teken;
            string nr = string.Empty;
            for (int teller = 0; teller < nummer.Length; teller++)
            {
                teken = nummer[teller];
                if (teken >= 'A' && teken <= 'Z')
                {
                    nr += ALFABET.IndexOf(teken) + 10;

                }
                else
                    nr += teken;

            }
            return nr;

        }
    }
}
