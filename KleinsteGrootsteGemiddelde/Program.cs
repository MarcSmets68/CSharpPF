using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KleinsteGrootsteGemiddelde
{
    class Program
    {
        static void Main(string[] args)
        {
            int aantal=0, som=0, getal, gemiddelde = 0;
            Console.WriteLine("Geef een getal groter dan 0. (STOP='-1')");
            getal = int.Parse(Console.ReadLine());
            int grootsteGetal = getal;
            int kleinsteGetal = getal;
            while ( getal != -1)
            {
                if (getal >= 0)
                {
                    if (getal < kleinsteGetal)
                        kleinsteGetal = getal;
                    if (getal > grootsteGetal)
                        grootsteGetal = getal;
                    aantal++;
                    som += getal;
                    Console.WriteLine("Geef een getal groter dan 0. (STOP='-1')");
                    getal = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("enkel positieve getallen zijn toegelaten");
                    Console.WriteLine("Geef een getal groter dan 0. (STOP='-1')");
                    getal = int.Parse(Console.ReadLine());
                }

            }
            if (aantal > 0)
            {
                gemiddelde = som / aantal;
                Console.WriteLine("Het grootste getal = {0}", grootsteGetal);
                Console.WriteLine("Het kleinste getal = {0}", kleinsteGetal);
                Console.WriteLine("het gemiddelde = {0}", gemiddelde);
            }
           else
                Console.WriteLine("Er werden geen getallen ingevoerd.");


        }
    }
}
