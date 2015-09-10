using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
//        x2 + 5 = 1x2 + 0x + 5  501


namespace PolynomialSum
{
    class Adding
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

        static int[] InputCoeficients()
        {
            Console.WriteLine("Enter the power of the polynom : ");
            int power = int.Parse(Console.ReadLine());
            int[] polynom = new int[power + 1];

            for (int i = 0; i <= power; i++)
            {
                Console.Write("enter the coeficient of the x^{0} : ",(power - i));
                polynom[i] = int.Parse(Console.ReadLine());
            }

            return polynom;
        }

        static void Main(string[] args)
        {
            int[] firstPolynomial = InputCoeficients();
            int[] secondPolynomial = InputCoeficients();

            int[] sumOfAdditionOfPolynomials = AddingPolinomials(firstPolynomial, secondPolynomial);

            for (int i = 0; i < sumOfAdditionOfPolynomials.Length; i++)
            {
                Console.Write(sumOfAdditionOfPolynomials[i] + " ");
            }

        }
    }
}
