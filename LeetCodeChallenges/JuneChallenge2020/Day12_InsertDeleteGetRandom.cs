using System;
using System.Collections.Generic;

namespace LeetCodeChallenges.JuneChallenge2020
{
    class Day12_InsertDeleteGetRandom
    {
        List<int> randomSet = null;
        HashSet<int> mySet = null;

        /** Initialize your data structure here. */
        public Day12_InsertDeleteGetRandom()
        {
            randomSet = new List<int>();
            mySet = new HashSet<int>();
        }

        /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
        public bool Insert(int val)
        {

            if (!mySet.Contains(val))
            {
                randomSet.Add(val);
                mySet.Add(val);
                return true;
            }
            return false;
        }

        /** Removes a value from the set. Returns true if the set contained the specified element. */
        public bool Remove(int val)
        {

            if (mySet.Contains(val))
            {
                randomSet.Remove(val);
                mySet.Remove(val);
                return true;
            }
            return false;
        }

        /** Get a random element from the set. */
        public int GetRandom()
        {

            var random = new Random();
            int index = random.Next(randomSet.Count);
            return randomSet[index];
        }
    }
}
