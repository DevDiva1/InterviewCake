using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    //Given an array of integers, find the highest product you can get from three of the integers.
    class HighestProductOfThree
    {
        //Greedy approach
        public static int GetHighestProductOfThree(int[] arrayOfInts)
        {
            if (arrayOfInts.Length < 3)
            {
                throw new ArgumentException("Less than 3 times", nameof(arrayOfInts));
            }

            var highest = Math.Max(arrayOfInts[0], arrayOfInts[1]);
            var lowest = Math.Min(arrayOfInts[0], arrayOfInts[1]);

            var highestProductOf2 = arrayOfInts[0] * arrayOfInts[1];
            var lowestProductOf2 = arrayOfInts[0] * arrayOfInts[1];

            var highestProductOf3 = arrayOfInts[0] * arrayOfInts[1] * arrayOfInts[2];

            for (var i = 2; i < arrayOfInts.Length; i++)
            {
                int current = arrayOfInts[i];

                //Do we have a new highest product of 3?
                //It's either the current highest
                //Or current times the highest product of 2
                //Or current times the lowest of 2

                highestProductOf3 =
                    Math.Max(Math.Max(highestProductOf3, highestProductOf2 * current), current * lowestProductOf2);

                //Do we have new highest product of 2?
                //Do we have new lowest product of 2?
                //Do we have new highest?
                //Do we have new lowest?

                highestProductOf2 =
                    Math.Max(Math.Max(highestProductOf2, highest * current), current * lowest);

                lowestProductOf2 =
                    Math.Min(Math.Min(lowestProductOf2, highest * current), current * lowest);

                highest = Math.Max(current, highest);

                lowest = Math.Min(current,lowest);
            }
            return highestProductOf3;
        }
    }
}
