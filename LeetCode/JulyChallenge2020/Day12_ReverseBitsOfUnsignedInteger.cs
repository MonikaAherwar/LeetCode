namespace LeetCode.JulyChallenge2020
{
    class Day12_ReverseBitsOfUnsignedInteger
    {
        public uint reverseBits(uint n)
        {

            uint num = 0;
            for (int i = 0; i < 32; ++i)
            {
                num <<= 1;
                num += n % 2;
                n >>= 1;
            }

            return num;
        }
    }
}
