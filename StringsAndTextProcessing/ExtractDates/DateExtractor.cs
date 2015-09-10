using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

//Write a program that extracts from a text all dates written in format DD.MM.YYYY and prints them on the console in the standard format for Canada. Sample text:
//I was born at 14.06.1980. My sister was born at 3.7.1984. In 5/1999 I graduated my high school. The law says (see section 7.3.12) that we are allowed to do this (section 7.4.2.9).
//Extracted dates from the sample text:
//14.06.1980
//3.7.1984

namespace ExtractDates
{
    class DateExtractor
    {
        public static void ExtractingDates(string text)
        {
            if (text == null || text == string.Empty)
	        {
                throw new ArgumentNullException("text is either null or empty");
	        }
            else
            {
                string[] textToArray = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                DateTime date;

                for (int i = 0; i < textToArray.Length; i++)
                {
                    if (DateTime.TryParse(textToArray[i].Trim(new char[] {',', ' ', '.', '-'}), out date))
                    {
                        Console.WriteLine(date.ToLongDateString());
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-CA");

            string text = "I was born at 14.06.1980. My sister was born at 3.7.1984. In 5/1999 I graduated my high school. The law says (see section 7.3.12) that we are allowed to do this (section 7.4.2.9).";
            ExtractingDates(text);
        }
    }
}
