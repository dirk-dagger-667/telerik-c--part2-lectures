using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ComparingTwoArraysSecondEdition
{
    class Comparison
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the length of array 1 : ");
            int lengthOfFirstArray = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length of array 2 : ");
            int lengthOfSecondArray = int.Parse(Console.ReadLine());
            int[] firstArray = new int[lengthOfFirstArray];
            int[] secondArray = new int[lengthOfSecondArray];

            if (firstArray.Length != secondArray.Length)
            {
                Console.WriteLine("The arrays are not the same");
            }
            else
            {
                for (int i = 0; ; i++)
                {
                    Console.Write("Write the {0} element of the first array : ", i);
                    firstArray[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    Console.Write("Write the {0} element of the second array : ", i);
                    secondArray[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if (firstArray[i] != secondArray[i])
                    {
                        Console.WriteLine("The arrays are not equel");
                        break;
                    }
                }
            }
        }
    }
}
