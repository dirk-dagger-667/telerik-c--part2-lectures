using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ComparingCharArrays
{
    class CharComparison
    {
        static void Main(string[] args)
        {

            string inputCharSequenceOne = Console.ReadLine();
            string inputCharSequenceTwo = Console.ReadLine();

            char[] arrayOne = inputCharSequenceOne.ToCharArray();
            char[] arrayTwo = inputCharSequenceTwo.ToCharArray();
            bool equal = false;
            for (int i = 0; i < arrayOne.Length && i < arrayTwo.Length; i++)
            {
                if (arrayOne[i] > arrayTwo[i])
                {
                    Console.WriteLine(arrayTwo[i]);

                    break;
                }
                else if (arrayOne[i] < arrayTwo[i])
                {
                    Console.WriteLine(arrayOne);

                    break;
                }
                else
                {
                    equal = true;
                }
            }

            if (equal == true)
            {
                if (arrayOne.Length > arrayTwo.Length)
                {
                    Console.WriteLine(inputCharSequenceOne);
                }
                if (arrayTwo.Length > arrayOne.Length)
                {
                    Console.WriteLine(inputCharSequenceTwo);
                }
                else
                {
                    Console.WriteLine("They are qual!");
                }
            }





        }
    }
}

