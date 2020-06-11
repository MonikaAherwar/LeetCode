namespace LeetCodeChallenges.JuneChallenge2020
{
    class Day10_SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            int i = 0;
            while (i < nums.Length && nums[i] < target)
            {
                i++;
            }

            return i;
        }
    }
}
