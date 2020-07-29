using System.Collections.Generic;;

namespace LeetCode.JulyChallenge2020
{
    class Day23_SingleNumberIII
    {
        public int[] SingleNumber(int[] nums)
        {
            var hashSet = new HashSet<int>();
            foreach (var n in nums)
            {
                if (!hashSet.Contains(n))
                {
                    hashSet.Add(n);
                }
                else
                {
                    hashSet.Remove(n);
                }
            }

            int[] result = new int[2];
            hashSet.CopyTo(result);
            return result;
        }
    }
}
