using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelciusFarenheit
{
    class Program
    {
        const float lichaamsTempCelcius = 37.0f;
        static void Main(string[] args)
        {
            float lichaamsTempFarenheit = (lichaamsTempCelcius * 9.0f / 5f) + 32f;
            Console.WriteLine(lichaamsTempFarenheit);
        }
    }
}
