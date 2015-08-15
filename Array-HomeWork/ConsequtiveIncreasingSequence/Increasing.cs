using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program, which finds the maximal sequence of consecutive equal elements in an array. E.g.: {1, 1, 2, 3, 2, 2, 2, 1}  {2, 2, 2}.
*/
namespace SequenceOfRepeatingNumbers
{
    class RepeatingNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements for the Array : ");
            int numberOfElements = int.Parse(Console.ReadLine());
            int bestLength = 0;
            int counter = 1;
            int[] array = new int[numberOfElements];
            int bestPosition = 0;
            int position = 0;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter the {0} element of the array(must be a number) : ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int k = 0; k < array.Length; k++)
            {
                if (k == array.Length - 1)
                {
                    break;
                }

                if (array[k] < array[k + 1])
                {
                    position = k - 2;
                    counter++;
                    if (bestLength < counter)
                    {
                        bestPosition = position;
                        bestLength = counter;
                    }
                }

                else
                {
                    counter = 1;
                }
            }
            int printingCounter = 0;

            for (int i = bestPosition; i < bestPosition + bestLength - 1; i++)
            {
                printingCounter++;
                Console.Write(array[i - 1] + ", ");
            }
            Console.Write(array[bestPosition + printingCounter - 1]);
            Console.WriteLine();
        }
    }
}
