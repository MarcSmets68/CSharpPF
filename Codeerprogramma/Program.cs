using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeerprogramma
{
    class Program
    {
        const string ALFABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static void Main(string[] args)
        {
            char[] codeersleutel = { 'Q', 'S', 'P', 'A', 'T', 'V', 'X', 'B', 'C', 'R', 'J', 'Y', 'E', 'D', 'U', 'O', 'H', 'Z', 'G', 'I', 'F', 'L', 'N', 'W', 'K', 'M' };
            int index = 0;
            Console.WriteLine("Geef een tekst in ");
            string tekst = Console.ReadLine().ToUpper;
                  for(int i = 0; i < tekst.Length; i++)
            {
               index = ALFABET.LastIndexOf(tekst[i]);
                              if (index == -1)
                    Console.Write(tekst[i]);
                else
                    Console.Write(codeersleutel[index]);
                            }
            Console.WriteLine(); 
                    }
            }
}
