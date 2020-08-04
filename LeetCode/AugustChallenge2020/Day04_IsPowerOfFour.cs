using System;

namespace LeetCode.AugustChallenge2020
{
    class Day04_IsPowerOfFour
    {
        public bool IsPowerOfFour(int num)
        {

            if (num <= 0)
            {
                return false;
            }

            var b = (int)Math.Log(num, 4);
            return Math.Pow(4, b) == num;
        }
    }
}
