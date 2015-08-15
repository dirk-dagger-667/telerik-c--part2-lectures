using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfDaysBetweenDates
{
    class NumberOfDyas
    {
        static int WorkDaysBetweenTwoDates(DateTime dateLimit)
        {
            int counter = 0;
            DateTime[] officialHoliday = new DateTime[14];

            officialHoliday[0] = new DateTime(2014, 1, 1);
            officialHoliday[1] = new DateTime(2014, 3, 3);
            officialHoliday[2] = new DateTime(2014, 4, 18);
            officialHoliday[3] = new DateTime(2014, 4, 19);
            officialHoliday[4] = new DateTime(2014, 4, 20);
            officialHoliday[5] = new DateTime(2014, 5, 1);
            officialHoliday[6] = new DateTime(2014, 5, 6);
            officialHoliday[7] = new DateTime(2014, 5, 24);
            officialHoliday[8] = new DateTime(2014, 9, 6);
            officialHoliday[9] = new DateTime(2014, 9, 22);
            officialHoliday[10] = new DateTime(2014, 11, 1);
            officialHoliday[11] = new DateTime(2014, 12, 24);
            officialHoliday[12] = new DateTime(2014, 12, 25);
            officialHoliday[13] = new DateTime(2014, 12, 26);

            DateTime currentDate = DateTime.Now;
            DateTime memoryOfDate = new DateTime();

            while (currentDate.Equals(dateLimit) == false)
            {
                memoryOfDate = currentDate.Date;
                currentDate = memoryOfDate.AddDays(1);

                if (currentDate.DayOfWeek == DayOfWeek.Sunday || currentDate.DayOfWeek == DayOfWeek.Saturday)
                {
                    counter--;
                }

                for (int i = 0; i < officialHoliday.Length; i++)
                {
                    if (currentDate.Equals(officialHoliday[i]) == true)
                    {
                        counter--;
                    }
                }

                counter++;
            }

            return counter;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the month : ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the day : ");
            int day = int.Parse(Console.ReadLine());
            DateTime dateLimit = new DateTime(2014, month, day);

            int numberOfWorkDays = WorkDaysBetweenTwoDates(dateLimit);
            Console.WriteLine(numberOfWorkDays);

        }
    }
}
