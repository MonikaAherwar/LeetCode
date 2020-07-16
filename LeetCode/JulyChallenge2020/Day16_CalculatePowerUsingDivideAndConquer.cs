namespace LeetCode.JulyChallenge2020
{
    class Day16_CalculatePowerUsingDivideAndConquer
    {
        public double MyPow(double x, int n)
        {
            if (n == 0) return 1;
            if (x == 0) return 0;

            long N = n;
            if (N < 0)
            {
                x = 1 / x;
                N = -N;
            }

            double res = 1;
            while (N > 0)
            {
                if (N % 2 == 1)
                {
                    res = res * x;
                }
                x = x * x;
                N = N / 2;
            }

            return res;
        }
    }
}
