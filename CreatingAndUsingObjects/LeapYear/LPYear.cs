using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class LPYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Etner the year for checking : ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Is the {0} year a leap year : {1}",year,DateTime.IsLeapYear(year));
        }
    }
}
