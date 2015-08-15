using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonConsequtiveSequence
{
    class NonConsequtive
    {
        static void Main(string[] args)
        {

            string inputArrayOne = Console.ReadLine();
            char[] delimiter = new char[] {',', ' '};
            string[] inputOne = inputArrayOne.Split(delimiter,StringSplitOptions.RemoveEmptyEntries);
            int[] arr = new int[inputOne.Length];
            for (int i = 0; i < inputOne.Length; i++)
            {
                arr[i] = int.Parse(inputOne[i]);
            }
            int[] longestSequence = FindLongestSubsequence(arr);
            for (int i = 0; i < longestSequence.Length; i++)
            {
                Console.Write(longestSequence[i] + " ");
            }
            Console.WriteLine();
        }

        public static int[] FindLongestSubsequence(int[] arr)
        {
            int[] len = new int[arr.Length];
            len[0] = 1;
            for (int x = 1; x < arr.Length; x++)
			{
                int max = 0;
                for (int prev = 0; prev < x; prev++)
			    {
                    if (arr[prev] < arr[x])
	                    {
                        int current = len[prev];
                        if (true)
	                        {
		                        max = current;
	                        }
	                    }
			    }
                len[x] = 1 + max;
			}

            int maxLength = len.Max();
            int[] longestSubsequence = new int[maxLength];
            int maxLengthIndex = 0;

            for (int i = len.Length - 1; i >= 0; i--)
			{
			 if (len[i] == maxLength)
            	{
		            longestSubsequence[maxLength - 1] = arr[i];
                    maxLengthIndex = i;
                 break;
	            }
			}

            int currentIndex = maxLengthIndex - 1;
            int currentMaxIndex = maxLengthIndex;
            int sequenceIndex = maxLength - 2;

            while (true)
	        {
	            if (sequenceIndex == -1 || currentIndex == -1)
	            {
		            break;
	            }
                if (len[currentIndex] == len[currentMaxIndex] - 1)
	            {
                    longestSubsequence[sequenceIndex] = arr[currentIndex];
                    sequenceIndex--;
                    currentMaxIndex = currentIndex;
	            }
                currentIndex--;
	        }
            return longestSubsequence;
        }
        public static int[] ProcessInput()
        {
            int arrayLength = int.Parse(Console.ReadLine());
            int[] arr = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;

        }
    }
}
