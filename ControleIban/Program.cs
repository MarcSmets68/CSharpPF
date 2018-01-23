using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleIban
{
    class Program
    {
        const string ALFABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static void Main(string[] args)
        {
            string rekening, code;
            string rekeningnr = "BE73 0631 5475 6360";

            rekening = rekeningnr.Replace(" ", "");
            rekening = rekening.Substring(4) + rekening.Substring(0, 4);

            rekening = VervangLetters(rekening);

            Console.WriteLine(ulong.Parse(rekening) % 97ul == 1 ?
                "geldig rekeningnr" : "geen geldig rekeningnr");

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
