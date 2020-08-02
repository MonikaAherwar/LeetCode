namespace LeetCode.AugustChallenge2020
{
    class Day02_DesignHashSet
    {
    }

    public class MyHashSet
    {
        /** Initialize your data structure here. */
        int[] MyHash;
        public MyHashSet()
        {
            MyHash = new int[1000000];
        }

        public void Add(int key)
        {
            MyHash[key] = 1;
        }

        public void Remove(int key)
        {
            MyHash[key] = 0;
        }

        /** Returns true if this set contains the specified element */
        public bool Contains(int key)
        {
            return MyHash[key] == 1;
        }
    }

    /**
     * Your MyHashSet object will be instantiated and called as such:
     * MyHashSet obj = new MyHashSet();
     * obj.Add(key);
     * obj.Remove(key);
     * bool param_3 = obj.Contains(key);
     * All values will be in the range of [0, 1000000]
     * The number of operations will be in the range of [1, 10000]
     * Please do not use the built-in HashSet library
     */
}
