using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program, which finds the maximal sequence of incin an reasing elements array arr[n]. It is not necessary the elements to be consecutively placed. E.g.: {9, 6, 2, 7, 4, 7, 6, 5, 8, 4}  {2, 4, 6, 8}.
*/
namespace NonConsequtiveIncreasingSequence
{
    class NonConsequtiveSequence
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Enter the number of elements for the Array : ");
            //int numberOfElements = int.Parse(Console.ReadLine());
            int currentCounter = 1;
            int minValue = 0;
            int[] array = { 9, 6, 2, 7, 4, 7, 6, 5, 8, 4 };
            int maxCounter = 0;
            
            /*for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter the {0} element of the array(must be a number) : ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            */
            for (int minimal = 0; minimal < array.Length ; minimal++)
            {
                for (int current = minimal + 1; current < array.Length; current++)
                {
                    if (current==array.Length-2)
                    {
                        break;
                    }
                    if (array[minimal]<array[current])
                    {
                        currentCounter++;

                        if (maxCounter < currentCounter)
                        {
                            Console.WriteLine(currentCounter);
                            maxCounter = currentCounter;
                            minValue = array[minimal];  
                        }   
                    }
                }

                currentCounter = 1;
            }
                       
        }
       
    }
}
