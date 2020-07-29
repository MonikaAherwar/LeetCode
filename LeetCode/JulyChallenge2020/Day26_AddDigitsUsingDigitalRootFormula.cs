namespace LeetCode.JulyChallenge2020
{
    class Day26_AddDigitsUsingDigitalRootFormula
    {
        public int AddDigits(int num)
        {
            //Using Digital Root method
            int mod = 10;
            int res = 0;

            if (num == 0)
            {
                res = 0;
            }
            else if (num % (mod - 1) == 0)
            {
                res = (mod - 1);
            }
            else
            {
                res = num % (mod - 1);
            }

            return res;
            //We can also summarize above code to below formula
            //return (1 + (num - 1) % (mod -1));
        }
    }
}
