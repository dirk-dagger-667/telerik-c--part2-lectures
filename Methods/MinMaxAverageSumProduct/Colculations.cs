using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable number of arguments.


namespace MinMaxAverageSumProduct
{
    class Colculations
    {
        static int MinimumValue(params int[] integerSet)
        {
            int bestPosition = 0;

            for (int i = 1; i < integerSet.Length; i++)
            {
                if (integerSet[bestPosition] > integerSet[i])
                {
                    bestPosition = i;
                }
            }

            return integerSet[bestPosition];
        }

        static int MaximumValue(params int[] integerSet)
        {
            int bestPosition = 0;

            for (int i = 1; i < integerSet.Length; i++)
            {
                if (integerSet[bestPosition] < integerSet[i])
                {
                    bestPosition = i;
                }
            }

            return integerSet[bestPosition];
        }

        static int Sum(params int[] integerSet)
        {
            int sum = 0;

            for (int i = 0; i < integerSet.Length; i++)
            {
                sum += integerSet[i];
            }

            return sum;
        }

        static int Multiply(params int[] integerSet)
        {
            int result = 1;

            for (int i = 0; i < integerSet.Length; i++)
            {
                result *= integerSet[i];
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(@"Enter the sequnce you desire using "" "" between the elements");
            string inputSequenceString = Console.ReadLine();
            char delimiter = ' ';
            string[] correctedString = inputSequenceString.Split(delimiter);
            int[] integerSet = new int[correctedString.Length];

            for (int i = 0; i < integerSet.Length; i++)
            {
                integerSet[i] = int.Parse(correctedString[i]);
            }

            Console.WriteLine("Maximum : {0}",MaximumValue(integerSet));
            Console.WriteLine("Minimun : {0}", MinimumValue(integerSet));
            Console.WriteLine("Sum : {0}", Sum(integerSet));
            Console.WriteLine("Result : {0}", Multiply(integerSet));
        }
    }
}
