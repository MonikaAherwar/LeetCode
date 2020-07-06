using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.JuneChallenge2020
{
    class Day5_RandomPickWithWeights
    {
        private int[] prefixSum;
        private int totalSum = 0;

        public Day5_RandomPickWithWeights(int[] w)
        {
            this.prefixSum = new int[w.Length];
            int sum = 0;
            for (int i = 0; i < w.Length; i++)
            {
                sum += w[i];
                this.totalSum += w[i];
                this.prefixSum[i] = sum;
            }
        }

        public int PickIndex()
        {
            var rand = new Random();
            int target = rand.Next(0, this.totalSum);

            int i;
            for (i = 0; i < this.prefixSum.Length; i++)
            {
                if (target < prefixSum[i])
                {
                    return i;
                }
            }
            return i - 1;
        }
    }
}
