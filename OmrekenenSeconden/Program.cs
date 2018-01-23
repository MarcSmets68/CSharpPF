using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmrekenenSeconden
{
    class Program
    {
        const int totaalSeconden = 3886;
        static void Main(string[] args)
        {
            int uren, minuten, seconden, rest;
            uren = totaalSeconden / 3600;
            rest = totaalSeconden % 3600;
            minuten = rest / 60;
            rest = rest % 60;
            seconden = rest;

            Console.WriteLine("U:{0} M:{1} S:{2}",uren,minuten,seconden);

           



        }
    }
}
