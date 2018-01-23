using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schrikkeljaar
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Voer jaartal in: ");
            int jaar = Convert.ToInt32(Console.ReadLine());
            //oplossing 1
            string schrikkel;
            if (jaar % 4 == 0)
                if (jaar % 100 == 0 && jaar % 400 != 0) schrikkel = "geen";
                else schrikkel = "een";
            else schrikkel = "geen";
            Console.WriteLine("Het jaar {0} is {1} schrikkeljaar", jaar, schrikkel);
           
        }
    }
}
