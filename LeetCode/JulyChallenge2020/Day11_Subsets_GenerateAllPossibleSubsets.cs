using System.Collections.Generic;

namespace LeetCode.JulyChallenge2020
{
    class Day11_Subsets_GenerateAllPossibleSubsets
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            return SubsetsHelper(nums, new List<IList<int>>(), 0);
        }

        public IList<IList<int>> SubsetsHelper(int[] nums, IList<IList<int>> result, int index)
        {
            if (index == 0)
            {
                result.Add(new List<int>());
            }

            if (index == nums.Length)
            {
                return result;
            }

            int precount = result.Count;
            for (int i = 0; i < precount; i++)
            {
                var currentList = new List<int>(result[i]);
                currentList.Add(nums[index]);
                result.Add(currentList);
            }

            return SubsetsHelper(nums, result, index + 1);
        }
    }
}
