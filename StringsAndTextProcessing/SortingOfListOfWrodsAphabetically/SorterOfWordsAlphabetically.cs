using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingOfListOfWrodsAphabetically
{
    class SorterOfWordsAlphabetically
    {
        public static void SortingWordsAlphabetically(string listOfWords)
        {
            if (listOfWords == null || listOfWords == string.Empty)
            {
                throw new ArgumentNullException("the list is either empty or null");
            }
            else
            {
                string[] listOfWordsAsArray = listOfWords.ToLower().Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
                Array.Sort(listOfWordsAsArray);

                for (int i = 0; i < listOfWordsAsArray.Length; i++)
                {
                    Console.WriteLine(listOfWordsAsArray[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            string listOfWords = "and, or, Seperate, child, car, cat, Assault, bar, banana, zebra, ban, king, queen";
            SortingWordsAlphabetically(listOfWords);
        }
    }
}
