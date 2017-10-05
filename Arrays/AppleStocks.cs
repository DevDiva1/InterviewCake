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
            //Edge case
            if (stocks.Length < 2)
            {
                throw new ArgumentException("Input requires more than 2 items to buy and sell",nameof(stocks));
            }
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
