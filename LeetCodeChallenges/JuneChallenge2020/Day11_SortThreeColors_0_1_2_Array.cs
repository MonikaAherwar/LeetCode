namespace LeetCodeChallenges.JuneChallenge2020
{
    class Day11_SortThreeColors_0_1_2_Array
    {
        public void SortColors(int[] nums)
        {
            int lo = 0;
            int hi = nums.Length - 1;
            int mid = 0;

            while (mid <= hi)
            {
                switch (nums[mid])
                {
                    case 0:
                        {
                            var temp = nums[lo];
                            nums[lo] = nums[mid];
                            nums[mid] = temp;
                            lo++;
                            mid++;
                            break;
                        }
                    case 1:
                        mid++;
                        break;
                    case 2:
                        {
                            var temp = nums[mid];
                            nums[mid] = nums[hi];
                            nums[hi] = temp;
                            hi--;
                            break;
                        }
                }
            }
        }
    }
}
