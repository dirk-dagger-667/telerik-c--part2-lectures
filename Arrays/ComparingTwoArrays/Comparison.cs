using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ComparingTwoArrays
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
                for (int i = 0; i < lengthOfFirstArray; i++)
                {
                    Console.Write("Enter the {0} element of the array : ", i);
                    firstArray[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                }
                for (int k = 0; k < lengthOfSecondArray; k++)
                {
                    Console.Write("Enter the {0} element of the array : ", k);
                    firstArray[k] = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                }
                for (int j = 0; ; j++)
                {
                    if (firstArray[j] != secondArray[j])
                    {
                        Console.WriteLine("The arrays are not the same!");
                        break;
                    }
                }

            }
        }
    }
}
