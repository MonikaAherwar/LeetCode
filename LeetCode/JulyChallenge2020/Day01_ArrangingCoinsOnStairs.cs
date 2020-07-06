namespace LeetCode.JulyChallenge2020
{
    class Day01_ArrangingCoinsOnStairs
    {
        public int ArrangeCoins(int n)
        {
            var stairs = 0;
            while (n >= (stairs + 1))
            {

                n = n - (stairs + 1);

                if (n < 0)
                {
                    break;
                }

                stairs++;
            }

            return stairs;
        }
    }
}
