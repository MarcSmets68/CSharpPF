using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priemgetal
{
    class Program
    {
        static void Main(string[] args)
        {
            int invoerGetal=0;
            int deling = 0;
            bool priemGetal=true;
            while (invoerGetal <1)
            {
                Console.WriteLine("geef een geheel getal");
                invoerGetal = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("deelbaar door 1");
            for (int i = 2; i <= invoerGetal-1; i++)
            {
                deling = invoerGetal % i;
                if (deling == 0)
                {
                    Console.WriteLine("deelbaar door {0}",i);
                    priemGetal = false;
                }
               
            }
            Console.WriteLine("deelbaar door {0}",invoerGetal);

            if (priemGetal)
                Console.WriteLine("{0} is een priemgetal",invoerGetal);
            else
                Console.WriteLine("{0} is geen priemgetal",invoerGetal);
                    }
    }
}
