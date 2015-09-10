using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads two dates entered in the format "day.month.year" and calculates the number of days between them.
//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2006
//Distance: 4 days

namespace DaysBwtweenTwoDates
{
    class CalculatorTwoDates
    {
        static void Main(string[] args)
        {
            string dateAsString1 = "12.08.2003";
            string dateAsString2 = "12.08.2008";
            DateTime date1 = DateTime.Parse(dateAsString1);
            DateTime date2 = DateTime.Parse(dateAsString2);

            if (DateTime.Compare(date1, date2) < 0)
            {
                TimeSpan diff1 = date2.Subtract(date1);
                Console.WriteLine(diff1.Days);
            }
            else if (DateTime.Compare(date1, date2) == 0)
            {
                Console.WriteLine("The dates are equal");
            }
            else
            {
                TimeSpan diff2 = date1.Subtract(date2);
                Console.WriteLine(diff2.Days);
            }
        }
    }
}
