using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voertuigen
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrivaat[] privateGegevens = new IPrivaat[3];
            Personenwagen pw = new Personenwagen("Marc", 5000m, 90, 6f, "1-HGF-654", 5, 5);
            Vrachtwagen vw = new Vrachtwagen("Chris", 14500m, 600, 22f, "1-TRD-258", 15000f);
            Personenwagen pw2 = new Personenwagen("Ben", 1000m, 110, 8f, "1-UJH-681", 3, 5);
            privateGegevens[0] = pw;
            privateGegevens[1] = vw;
            privateGegevens[2] = pw2;

            foreach (IPrivaat gegeven in privateGegevens)
                Console.WriteLine(gegeven.GeefPrivateData());

            IMilieu[] milieugegevens = new IMilieu[3];
            milieugegevens[0] = pw;
            milieugegevens[1] = vw;
            milieugegevens[2] = pw2;

            foreach(IMilieu voertuig in milieugegevens)
                Console.WriteLine(voertuig.GeefMilieuData());



        }
    }
}

