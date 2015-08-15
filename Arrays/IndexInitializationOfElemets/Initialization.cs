using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program, which creates an array of 20 elements of type integer and initializes each of the elements with a value equals to the index of the element multiplied by 5. Print the elements to the console.
*/
namespace IndexInitializationOfElemets
{
    class Initialization
    {
        static void Main(string[] args)
        {

            int[] array = new int[20];
            for (int i = 0; i < 20; i++)
            {
                array[i]=5*i;
                Console.WriteLine(array[i]);
            }

        }
    }
}
