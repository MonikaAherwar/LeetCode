namespace LeetCode.JuneChallenge2020
{
    class Day7_CoinChangeProblem
    {
        public int CoinChange(int amount, int[] coins)
        {
            int n = coins.Length;
            int[] table = new int[amount + 1];

            for (int i = 0; i < table.Length; i++)
            {
                table[i] = 0;
            }

            // Base case (If given value is 0) 
            table[0] = 1;

            for (int i = 0; i < n; i++)
            for (int j = coins[i]; j <= amount; j++)
                table[j] += table[j - coins[i]];

            return table[amount];
        }
    }
}
