using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class ProductsOfAllIntsExceptAtIndex
    {
        public static int[] GetProductOfAllIntsExceptAtIndex(int[] input)
        {
            if (input.Length < 2)
            {
                throw new ArgumentException(
                    "Getting the product of numbers at other indices requires at least 2 numbers",
                    nameof(input));
            }

            var product = new int[input.Length];
            var productSoFar = 1;
            for (var i = 0; i < input.Length; i++)
            {
                product[i] = productSoFar;
                productSoFar *= input[i];
            }
            productSoFar = 1;
            for (var i = input.Length - 1; i >= 0; i--)
            {
                product[i] *= productSoFar;
                productSoFar *= input[i];
            }
            return product;
        }
    }
}
