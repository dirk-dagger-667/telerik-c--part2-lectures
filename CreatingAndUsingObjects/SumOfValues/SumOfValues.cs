using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfValues
{
    class SumOfValues
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Enter the sequence of numbers separeting the values using "" "" : ");
            string inputNumbersString = Console.ReadLine();
            char[] delimiter = new Char[] {' '};
            string[] stringArrayOfValues = inputNumbersString.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
            int sum = 0;

            for (int i = 0; i < stringArrayOfValues.Length; i++)
            {
                int curentValue = int.Parse(stringArrayOfValues[i]);
                sum += curentValue;
            }
            Console.WriteLine("The sum is : {0}",sum);
        }
    }
}
