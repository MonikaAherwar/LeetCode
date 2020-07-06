namespace LeetCode.JulyChallenge2020
{
    class Day06_PlusOne
    {
        public int[] PlusOne(int[] digits)
        {
            var len = digits.Length;

            for (var i = len - 1; i >= 0; i--)
            {
                if (digits[i] != 9)
                {
                    digits[i] = digits[i] + 1;
                    return digits;
                }
                digits[i] = 0;
            }

            var result = new int[len + 1];
            result[0] = 1;
            return result;
        }
    }
}
