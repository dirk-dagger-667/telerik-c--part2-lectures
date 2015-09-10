using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads the date and time entered in the format "day.month.year hour:minutes:seconds" and prints the date and time after 6 hours and 30 minutes in the same format.

namespace AfterSixAndAHalfHours
{
    class AfterSixAndAHalfHours
    {
        public static void AfterHours(string dateString)
        {
            if (dateString == null || dateString == string.Empty)
            {
                throw new ArgumentNullException("input input date is null or empty");
            }
            else
            {
                DateTime date = new DateTime();

                if (DateTime.TryParse(dateString, out date))
                {
                    date = date.AddHours(6.5);
                    Console.WriteLine(date);
                }
                else
                {
                    throw new FormatException("The input is in an invalid format");
                }
            }
            
        }

        static void Main(string[] args)
        {
            string dateString = "18.12.2006 03:30:00";
            AfterHours(dateString);
        }
    }
}
