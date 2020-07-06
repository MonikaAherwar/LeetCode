namespace LeetCode.JuneChallenge2020
{
    class Day8_PowerOfTwo
    {
        public bool IsPowerOfTwo(int x)
        {
            return !(x < 0) && x != 0 && ((x & (x - 1)) == 0);
        }
    }
}
