using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxAverageSumProduct
{
    class Colculations
    {
        static T MinimumValue<T>(params T[] Set)
        {
            dynamic bestPosition = 0;

            for (int i = 1; i < Set.Length; i++)
            {
                if ((dynamic)Set[bestPosition] > (dynamic )Set[i])
                {
                    bestPosition = i;
                }
            }

            return Set[bestPosition];
        }

        static T MaximumValue<T>(params T[] Set)
        {
            dynamic bestPosition = 0;

            for (int i = 1; i < Set.Length; i++)
            {
                if ((dynamic)Set[bestPosition] < (dynamic)Set[i])
                {
                    bestPosition = i;
                }
            }

            return Set[bestPosition];
        }

        static T Sum<T>(params T[] Set)
        {
            dynamic sum = 0;

            for (int i = 0; i < Set.Length; i++)
            {
                sum += Set[i];
            }

            return sum;
        }

        static T Multiply<T>(params T[] Set)
        {
            dynamic result = 1;

            for (int i = 0; i < Set.Length; i++)
            {
                result *= Set[i];
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

            Console.WriteLine("Maximum : {0}", MaximumValue(integerSet));
            Console.WriteLine("Minimun : {0}", MinimumValue(integerSet));
            Console.WriteLine("Sum : {0}", Sum(integerSet));
            Console.WriteLine("Result : {0}", Multiply(integerSet));
        }
    }
}
