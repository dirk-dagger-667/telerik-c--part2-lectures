using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Extend the program to support also subtraction and multiplication of polynomials.


namespace SubstractionAndMultiplicationOfPolynomials
{
    class SubAndMultiOfPolys
    {
        static int[] AddingPolinomials(int[] firstPol, int[] secondPol)
        {
            int minLength = 0;
            int maxLength = 0;

            if (firstPol.Length > secondPol.Length)
            {
                minLength = secondPol.Length;
                maxLength = firstPol.Length;
            }

            else
            {
                minLength = firstPol.Length;
                maxLength = secondPol.Length;
            }

            int[] sum = new int[maxLength];

            for (int i = 0; i < minLength; i++)
            {
                sum[i] = firstPol[i] + secondPol[i];
            }

            for (int i = minLength; i < maxLength; i++)
            {
                if (firstPol.Length > secondPol.Length)
                {
                    sum[i] = firstPol[i];
                }

                else if (firstPol.Length < secondPol.Length)
                {
                    sum[i] = secondPol[i];
                }
            }

            return sum;
        }

        static int[] SubstractingPolinomials(int[] firstPol, int[] secondPol)
        {
            int minLength = 0;
            int maxLength = 0;

            if (firstPol.Length > secondPol.Length)
            {
                minLength = secondPol.Length;
                maxLength = firstPol.Length;
            }

            else
            {
                minLength = firstPol.Length;
                maxLength = secondPol.Length;
            }

            int[] difference = new int[maxLength];

            for (int i = 0; i < minLength; i++)
            {
                difference[i] = firstPol[i] - secondPol[i];
            }

            for (int i = minLength; i < maxLength; i++)
            {
                if (firstPol.Length > secondPol.Length)
                {
                    difference[i] = firstPol[i];
                }

                else if (firstPol.Length < secondPol.Length)
                {
                    difference[i] = secondPol[i];
                }
            }

            return difference;
        }

        static int[] MultiplyPolinomials(int[] firstPol, int[] secondPol)
        {
            int[] result = new int[firstPol.Length + secondPol.Length - 1];

            for (int i = 0; i < firstPol.Length; i++)
            {
                for (int j = 0; j < secondPol.Length; j++)
                {
                    result[i + j] += firstPol[i] * secondPol[j];
                }
            }

            return result;
        }

        static int[] InputCoeficients()
        {
            Console.WriteLine("Enter the power of the polynom : ");
            int power = int.Parse(Console.ReadLine());
            int[] polynom = new int[power + 1];

            for (int i = 0; i <= power; i++)
            {
                Console.Write("enter the coeficient of the x^{0} : ", (power - i));
                polynom[i] = int.Parse(Console.ReadLine());
            }

            return polynom;
        }

        static void Main(string[] args)
        {
            int[] firstPolynomial = InputCoeficients();
            int[] secondPolynomial = InputCoeficients();

            int[] sum = AddingPolinomials(firstPolynomial, secondPolynomial);
            int[] difference = SubstractingPolinomials(firstPolynomial, secondPolynomial);
            int[] result = MultiplyPolinomials(firstPolynomial, secondPolynomial);


            for (int i = 0; i < sum.Length; i++)
            {
                Console.Write(sum[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < difference.Length; i++)
            {
                Console.Write(difference[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
            

        }
    }
}
