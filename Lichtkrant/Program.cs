using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lichtkrant
{
    class Program
    {
        const string BoodschapWeekdag = "We wensen u een prettige werkdag!";
        const string BoodschapWeekend = "We wensen u een fijn weekend!";
        const string OpeningsurenWeekdag = "9u00-12u00 en 13u00-18u00";
        const string OpeningsurenZaterdag = "10u00-12u00";
        const string OpeningsurenZondag = "Gesloten";

        static void Main(string[] args)
        {
            Console.WriteLine("welke dag is het ? ");
            DateTime datum = DateTime.Parse(Console.ReadLine());

            StringBuilder boodschap = new StringBuilder("Openingsuren");
            Console.WriteLine(datum.DayOfWeek);
            switch (datum.DayOfWeek)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    boodschap.Append(OpeningsurenWeekdag);
                    boodschap.AppendLine();
                    boodschap.Append(BoodschapWeekdag);
                    break;
                case DayOfWeek.Saturday:
                    boodschap.Append(OpeningsurenZaterdag + 
                        Environment.NewLine + BoodschapWeekend);
                    break;
                case DayOfWeek.Sunday:
                    boodschap.Append(OpeningsurenZondag +
                        Environment.NewLine + BoodschapWeekdag);
                    break;
                default:
                    break;

             

            }

            Console.WriteLine(boodschap.ToString());

        }
    }
}
