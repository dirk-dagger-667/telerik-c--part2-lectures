using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

namespace BiggestNumberBinSearch
{
    class UsingBinSearch
    {
        static void Main(string[] args)
        {
            int numberN = int.Parse(Console.ReadLine());
            int numberK = int.Parse(Console.ReadLine());
            int[] arrayForAnalysing = new int[numberN];

            for (int i = 0; i < numberN; i++)
            {
                Console.WriteLine("Write the {0} element of the array : ", i);
                arrayForAnalysing[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arrayForAnalysing);

            int indexOfK = Array.BinarySearch(arrayForAnalysing,numberK);

            if (indexOfK < 0)
            {
                Console.WriteLine(arrayForAnalysing[Math.Abs(indexOfK) - 2]);
            }

            else if (indexOfK >= 0)
            {
                Console.WriteLine(arrayForAnalysing[indexOfK]);
            }
        }
    }
}
