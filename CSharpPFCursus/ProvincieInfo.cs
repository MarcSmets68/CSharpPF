using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFCursus
{
    public class ProvincieInfo
    {
        public int ProvincieGrootte(string provincieNaam)
        {
            StreamReader lezer = new StreamReader(@"C:\VS2015\provincies.txt");
            try
            {
                string regel;
                while ((regel = lezer.ReadLine()) != null)
                {
                    int dubbelePuntPos = regel.IndexOf(':');
                    string provincie = regel.Substring(0, dubbelePuntPos);
                    if (provincie == provincieNaam)
                        return int.Parse(regel.Substring(dubbelePuntPos + 1));

                }
            }
           finally
            {
                lezer.Close();
            }
            
            throw new Exception("Onbestaande provincie:" + provincieNaam);
          
        }
    }
}
