using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class AppleStocks
    {
        static void Main(string[] args)
        {
            //var maxProfit = GetMaximumProfit_BruteForce(new int[] { 10, 7, 1, 3, 11, 1 });
            var maxProfit2 = GetMaximumProfit(new int[] { 10, 7, 1, 3, 11, 1 });
            Console.WriteLine(maxProfit2);
            Console.ReadKey();
        }

        //Brute Force Approach
        //Time Complexity - O(n2)
        public static int GetMaximumProfit_BruteForce(int[] stocks)
        {
            var maxProfit = 0;
            for (var i = 0; i < stocks.Length; i++)
            {
                for (var j = i; j < stocks.Length; j++)
                {
                    var currentProfit = stocks[j] - stocks[i];
                    if (maxProfit < currentProfit)
                    {
                        maxProfit = currentProfit;
                    }
                }
            }
            return maxProfit;
        }

        //Time Complexit - O(n)
        public static int GetMaximumProfit(int[] stocks)
        {
            var minPrice = stocks[0];
            var maxProfit = stocks[1] - stocks[0];
            for (var i = 1; i < stocks.Length; i++)
            {
                var currentPrice = stocks[i];
                int potentialProfit = currentPrice - minPrice;
                maxProfit = Math.Max(potentialProfit, maxProfit);
                minPrice = Math.Min(minPrice, currentPrice);
            }
            return maxProfit;
        }

    }
}
