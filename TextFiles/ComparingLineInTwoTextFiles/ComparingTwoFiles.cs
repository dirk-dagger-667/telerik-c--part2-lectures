using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ComparingLineInTwoTextFiles
{
    class ComparingTwoFiles
    {
        static void CalcNumberOfDifferentLines(string pathOne, string pathTwo)
        {
            StreamReader fileOne = new StreamReader(pathOne);
            StreamReader fileTwo = new StreamReader(pathTwo);

            int counterForEqual = 0;
            int counterAllLines = 0;

            using (fileTwo)
            {
                using (fileOne)
                {
                    string line1 = fileOne.ReadLine();
                    string line2 = fileTwo.ReadLine();

                    while (line1 != null && line2 != null)
                    {
                        if (line1 == line2)
                        {
                            counterForEqual++;
                        }
                        counterAllLines++;
                        line1 = fileOne.ReadLine();
                        line2 = fileTwo.ReadLine();
                    }
                }
            }

            Console.WriteLine("The number of equal lines is : {0}", counterForEqual);
            Console.WriteLine("The number of different lines is : {0}", counterAllLines - counterForEqual);
        }

        static void Main(string[] args)
        {
            string fileOnePath = Console.ReadLine();
            string fileTwoPath = Console.ReadLine();

            CalcNumberOfDifferentLines(fileOnePath, fileTwoPath);
        }
    }
}
