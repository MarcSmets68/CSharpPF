using System;
using System.Collections.Generic;

namespace CSharpPFCursus

{

    class Program
    {

        public static void Main(string[] args)
        {
            var aantalKinderen = 3;
            var wedde = 1500m;
            var namen = new List<string>();

            Console.WriteLine(aantalKinderen.GetType());
            Console.WriteLine(wedde.GetType());
            Console.WriteLine(namen.GetType());
        }
    }
}
