using System;
using System.Collections.Generic;

namespace LeetCode.JulyChallenge2020
{
    class Day08_3Sum_TripletSumEqualsToZero
    {
        public class Solution
        {
            public IList<IList<int>> ThreeSum(int[] nums)
            {
                var result = new List<IList<int>>();
                var len = nums.Length;
                Array.Sort(nums);

                for (int i = 0; i < len - 2; i++)
                {
                    int left = i + 1;
                    int right = len - 1;
                    while (left < right)
                    {
                        var sum = -(nums[left] + nums[right]);

                        if (nums[i] == sum)
                        {
                            var list = new List<int>() { nums[i], nums[left], nums[right] };
                            result.Add(list);

                            // skip dupes
                            while (left < right && nums[left] == nums[left + 1])
                                left++;
                            while (left < right && nums[right] == nums[right - 1])
                                right--;

                            left++;
                            right--;

                        }
                        else if (nums[i] < sum)
                        {
                            left++;
                        }
                        else
                        {
                            right--;
                        }
                    }

                    // skip dupes
                    while (i < len - 1 && nums[i] == nums[i + 1])
                        i++;
                }

                return result;
            }
        }
    }
}
