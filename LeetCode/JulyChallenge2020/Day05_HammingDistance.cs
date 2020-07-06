namespace LeetCode.JulyChallenge2020
{
    class Day05_HammingDistance
    {
        public int HammingDistance(int x, int y)
        {

            //Get XOR
            int z = x ^ y;
            int setBits = 0;

            //Count number of bits which are set
            while (z > 0)
            {
                setBits += z & 1;
                z >>= 1;
            }

            return setBits;
        }
    }
}
