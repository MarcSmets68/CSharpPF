using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kortingsbon
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal korting = 0m;
            Console.WriteLine("voer het aankoopbedrag in :");
            decimal aankoopBedrag = decimal.Parse(Console.ReadLine());

            if (aankoopBedrag > 100m)
            {
                korting = aankoopBedrag * 0.05m;
            }
            else
            {
                if (aankoopBedrag >= 50)
                {
                    korting = aankoopBedrag * 0.03m;

                }
                else
                {
                    if (aankoopBedrag >= 25)
                    {
                        korting = aankoopBedrag * 0.02m;

                    }
                    else
                    {
                        korting = aankoopBedrag * 0.01m;
                    }
                }
               
               
            }
            Console.WriteLine($"je betaald slechts : " + $"{aankoopBedrag - korting} euro");
        }
    }
}
