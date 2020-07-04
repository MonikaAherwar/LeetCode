using System;

namespace LeetCodeChallenges.JulyChallenge2020
{
    class NthUglyNumber_II
    {
        public int Day04_NthUglyNumber(int n)
        {
            int[] ugly = new int[n];
            int i2 = 0, i3 = 0, i5 = 0;
            int next_twos = 2;
            int next_threes = 3;
            int next_fives = 5;
            int next_ugly = 1;
            ugly[0] = 1;

            for (int i = 1; i < n; i++)
            {
                next_ugly = Math.Min(next_twos,
                    Math.Min(next_threes,
                        next_fives));

                ugly[i] = next_ugly;

                if (next_ugly == next_twos)
                {
                    i2 = i2 + 1;
                    next_twos = ugly[i2] * 2;
                }
                if (next_ugly == next_threes)
                {
                    i3 = i3 + 1;
                    next_threes = ugly[i3] * 3;
                }
                if (next_ugly == next_fives)
                {
                    i5 = i5 + 1;
                    next_fives = ugly[i5] * 5;
                }
            }

            return next_ugly;
        }
    }
}
