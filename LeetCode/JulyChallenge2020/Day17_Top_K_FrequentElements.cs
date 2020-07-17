using System.Collections.Generic;
using System.Linq;

namespace LeetCode.JulyChallenge2020
{
    class Day17_Top_K_FrequentElements
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            var dict = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (!dict.ContainsKey(num))
                {
                    dict[num] = 0;
                }

                dict[num]++;
            }

            var result = new int[k];
            foreach (var dic in dict.OrderByDescending(d => d.Value))
            {
                result[--k] = dic.Key;
                if (k == 0)
                    break;
            }

            return result;
        }
    }
}