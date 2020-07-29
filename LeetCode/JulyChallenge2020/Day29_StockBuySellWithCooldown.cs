using System;

namespace LeetCode.JulyChallenge2020
{
    class Day29_StockBuySellWithCooldown
    {
        public int MaxProfit(int[] prices)
        {
            var len = prices.Length;
            var result = new int[len];
            var sell = new int[len];

            for (int i = 1; i < len; i++)
            {
                var diff = prices[i] - prices[i - 1];
                sell[i] = diff + Math.Max(sell[i - 1], i > 2 ? result[i - 3] : 0);
                result[i] = Math.Max(sell[i], result[i - 1]);
            }

            return len == 0 ? 0 : result[len - 1];
        }
    }
}
