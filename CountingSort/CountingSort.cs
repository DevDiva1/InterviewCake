using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingSort
{
    using System;

    class Solution
    {
        static void Main(string[] args)
        {

            var result = CountingSort(new [] { 2, 1, 5, 6 }, 6);
            foreach (var item in result)
                Console.WriteLine(item);
            Console.ReadKey();
        }

        public static int[] CountingSort(int[] input, int max)
        {
            var numCount = new int[max + 1];
            foreach (var item in input)
            {
                numCount[item]++;
            }
            var sortedArrayIndex = 0;
            var sortedArray = new int[input.Length];
            for (var i = 0; i < numCount.Length; i++)
            {
                for (var count = 0; count < numCount[i]; count++)
                {
                    sortedArray[sortedArrayIndex] = i;
                    sortedArrayIndex++;
                }
            }
            return sortedArray;
        }

    }
}
