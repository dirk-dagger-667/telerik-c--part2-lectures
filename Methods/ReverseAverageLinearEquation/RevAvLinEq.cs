using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAverageLinearEquation
{
    class RevAvLinEq
    {
        static string ReverseNumber(string number)
        {
            string reversedNumber = null;

            if (number[0] == '-')
            {
                Console.WriteLine("Number needs to be positive!!! I ain't gonna do a thing till you give me a positive number!!!");
                return null;
            }

            else
            {
                for (int i = number.Length - 1; i >= 0; i--)
                {
                    reversedNumber += number[i].ToString();
                }
            }

            return reversedNumber;
        }

        static double FindAverageOfNumbers(int[] inputSequence)
        {
            double average = inputSequence.Sum() / inputSequence.Length;
            return average;
        }

        static void SolvingLinearEquations(int a, int b)
        {
            if (a == 0)
            {
                Console.WriteLine(@"Gimme a number for ""a"", that's not 0, or else.............!");   
            }

            else
            {
                Console.Write(-(double)b/(double)a);
                Console.WriteLine();
            }
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter one of the three choices : ReverseNumber / FindAverage / SolveEquation");

            string inputChoice = Console.ReadLine();

            if ( inputChoice == "ReverseNumber")
            {
                Console.WriteLine("Enter the number for reversal : ");
                string number = Console.ReadLine();
                Console.WriteLine(ReverseNumber(number));
            }

            if(inputChoice == "FindAverage")
            {
                Console.WriteLine(@"Enter the sequence of integers using "" "" between elements : ");
                string sequence = Console.ReadLine();
                char delimiter = ' ';
                string[] realSequence = sequence.Split(delimiter);
                int[] integerSequance = new int[realSequence.Length];

                for (int i = 0; i < integerSequance.Length; i++)
                {
                    integerSequance[i] = int.Parse(realSequence[i]);
                }

                Console.WriteLine("The average is : {0}", FindAverageOfNumbers(integerSequance));
            }

            if(inputChoice == "SolveEquation")
            {
                Console.WriteLine("Enter the number, each on a new row : ");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.Write("The root of the equation is : ");

                SolvingLinearEquations(a, b);
            }

        }
    }
}
