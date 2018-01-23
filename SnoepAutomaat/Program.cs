using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnoepAutomaat
{
    class Program
    {
        const int betaald = 200;
        const int prijsSnoep = 64;
        static void Main(string[] args)
        {
            int verschil;
            int aantalEuro = 0;
            int aantalVijftig = 0;
            int aantalTwintig = 0;
            int aantalTien = 0;
            int aantalVijf = 0;
            int aantalTwee = 0;
            int aantalEen = 0;


            verschil = betaald - prijsSnoep;
            Console.WriteLine("Te betalen : " + prijsSnoep);
            Console.WriteLine("Wisselgeld : " + verschil);
            Console.WriteLine();
            aantalEuro = verschil / 100;
            verschil = verschil - (aantalEuro * 100);
            aantalVijftig = verschil / 50;
            verschil = verschil - (aantalVijftig * 50);
            aantalTwintig = verschil / 20;
            verschil = verschil - (aantalTwintig * 20);
            aantalTien = verschil / 10;
            verschil = verschil - (aantalTien * 10);
            aantalVijf = verschil / 5;
            verschil = verschil - (aantalVijf * 5);
            aantalTwee = verschil / 2;
            verschil = verschil - (aantalTwee * 2);
            aantalEen = verschil;



            Console.WriteLine("terug te krijgen muntstukken");
            Console.WriteLine("----------------------------");
            Console.WriteLine();
            Console.WriteLine("aantal euro : "+aantalEuro);
            Console.WriteLine("aantal 50 cent : "+aantalVijftig);
            Console.WriteLine("aantal 20 cent : "+aantalTwintig);
            Console.WriteLine("aantal 10 cent : "+aantalTien);
            Console.WriteLine("aantal 5 cent : "+aantalVijf);
            Console.WriteLine("aantal 2 cent : "+aantalTwee);
            Console.WriteLine("aantal 1 cent : "+aantalEen);
         



        }
    }
}
