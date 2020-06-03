using System;
using System.Linq;

namespace LeetCodeChallenges.JuneChallange2020
{
    class Day3_Two_City_Scheduling
    {
        public int TwoCitySchedulingCost(int[][] costs)
        {
            int length = costs.Length;
            int minSum = 0;
            int countA = 0, countB = 0;

            foreach (var cost in costs.OrderByDescending(c => Math.Abs(c[0] - c[1])))
            {
                if (cost[0] < cost[1])
                {
                    if (countA < length / 2)
                    {
                        countA++;
                        minSum += cost[0];
                    }
                    else
                    {
                        countB++;
                        minSum += cost[1];
                    }
                }
                else
                {
                    if (countB < length / 2)
                    {
                        countB++;
                        minSum += cost[1];
                    }
                    else
                    {
                        countA++;
                        minSum += cost[0];
                    }
                }
            }

            return minSum;
        }
    }
}
