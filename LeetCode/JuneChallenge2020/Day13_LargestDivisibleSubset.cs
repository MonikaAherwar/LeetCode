using System;
using System.Collections.Generic;

namespace LeetCode.JuneChallenge2020
{
    class Day13_LargestDivisibleSubset
    {
        public IList<int> LargestDivisibleSubset(int[] arr)
        {

            if (arr.Length == 0)
            {
                return new List<int>();
            }

            Array.Sort(arr);

            int[] divCount = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
                divCount[i] = 1;

            int[] prev = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                prev[i] = -1;

            int max_ind = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] % arr[j] == 0 &&
                        divCount[i] < divCount[j] + 1)
                    {
                        prev[i] = j;
                        divCount[i] = divCount[j] + 1;

                    }

                }

                if (divCount[i] > divCount[max_ind])
                    max_ind = i;
            }

            int k = max_ind;
            List<int> ans = new List<int>();
            while (k >= 0)
            {
                ans.Add(arr[k]);
                k = prev[k];
            }

            return ans;
        }
    }
}
