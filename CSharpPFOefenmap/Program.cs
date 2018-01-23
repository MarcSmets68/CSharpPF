using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap
{
    class Program
    {
        delegate ConsoleColor KleurGetal(int Getal);

        static void Main(string[] args)

        {
            Func<int, ConsoleColor> kleurEvenOneven = getal => getal % 2 == 0 ? ConsoleColor.Green : ConsoleColor.Red;
            Func<int, ConsoleColor> kleurPosNeg = getal => getal < 0 ? ConsoleColor.Yellow : ConsoleColor.White;

            ToonGetallen(kleurEvenOneven);
            ToonGetallen(kleurPosNeg);
        }
        private static void ToonGetallen(Func<int, ConsoleColor> kleurgetal)
        {
            var getallen = new[] { 0, -1, 5, 6, -4, -6, 8, 9, 1, 10, -11, 10 };
            foreach (var getal in getallen)
            {
                Console.ForegroundColor = kleurgetal(getal);
                Console.WriteLine(getal);
            }
           
        }



    }
}

