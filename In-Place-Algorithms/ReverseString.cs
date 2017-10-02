using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace In_Place_Algorithms
{
    class ReverseString
    {
        public string Reverse(string input)
        {
            var strChars = input.ToCharArray();
            var startIndex = 0;
            var endIndex = strChars.Length - 1;

            while (startIndex < endIndex)
            {
                //swap characters
                var tempChar = strChars[startIndex];
                strChars[startIndex] = strChars[endIndex];
                strChars[endIndex] = tempChar;

                //move towards middle
                startIndex++;
                endIndex--;
            }
            return new string(strChars);   
        }
    }
}
