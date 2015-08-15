using System;
using System.Linq;
using System.Collections.Generic;

namespace SequenceOfGivenSumOfGivenNumberOfElements
{
    class NKS
    {
        static void Main()
        {
            int numberN = int.Parse(Console.ReadLine());
            int numberK = int.Parse(Console.ReadLine());
            int numberS = int.Parse(Console.ReadLine());
            int[] array = new int[numberN];

            for (int i = 0; i < numberN; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int subsetsCount = (int)Math.Pow(2, numberN);

            for (int i = 1; i < subsetsCount; i++)
            {
                int sum = 0;
                int bitsOfI = i;
                for (int j = 0; j < numberN; j++)
                {
                    if (bitsOfI % 2 == 1)
                    {
                        sum += array[j];
                    }
                    bitsOfI = bitsOfI >> 1;
                }
                if (sum == numberS)
                {
                    char[] binaryCount = Convert.ToString(i,2).ToCharArray();
                    int counter = 0;
                    Array.Reverse(binaryCount);
                    for (int k= 0; k < binaryCount.Length; k++)
                    {
                        if (binaryCount[k] == '1')
                        {
                            counter++;
                        }
                    }

                    if (counter == numberK)
                    {
                        Console.WriteLine("True");

                        for (int l = 0; l < binaryCount.Length; l++)
                        {
                            if (binaryCount[l] == '1')
                            {
                                Console.Write(" " + array[l]);
                            }
                        }

                        return;
                    }
                }
            }
            Console.WriteLine("False");
        }
    }

}
