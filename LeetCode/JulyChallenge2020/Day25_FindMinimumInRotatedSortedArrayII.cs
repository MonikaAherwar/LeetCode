namespace LeetCode.JulyChallenge2020
{
    class Day25_FindMinimumInRotatedSortedArrayII
    {
        public int FindMin(int[] nums)
        {
            int len = nums.Length;
            int i = 1;
            while (i < len && nums[i - 1] <= nums[i])
            {
                i++;
            }

            return (i == len) ? nums[0] : nums[i];
        }
    }
}
