namespace LeetCode.JulyChallenge2020
{
    class Day31_ClimbStairs
    {
        public int ClimbStairs(int n)
        {
            //This solution runs into TLE
            //if(n <= 2)
            //{
            //    return n;
            //}
            //return ClimbStairs(n-1) + ClimbStairs(n-2);

            if (n <= 2)
            {
                return n;
            }

            var dp = new int[n];
            dp[0] = 1;
            dp[1] = 2;

            for (int i = 2; i < n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[n - 1];
        }
    }
}
