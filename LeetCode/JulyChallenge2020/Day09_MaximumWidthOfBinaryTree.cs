using System;
using System.Collections.Generic;

namespace LeetCode.JulyChallenge2020
{
    class Day09_MaximumWidthOfBinaryTree
    {

        public int WidthOfBinaryTree(TreeNode root)
        {
            if (root == null) return 0;

            var queue = new Queue<(TreeNode node, int index)>();
            queue.Enqueue((root, 1));
            int max_count = 1;

            while (queue.Count > 0)
            {
                int size = queue.Count;
                var first = 0;

                for (int i = 0; i < size; i++)
                {
                    var item = queue.Dequeue();
                    if (i == 0)
                    {
                        first = item.index;
                    }
                    else
                    {
                        max_count = Math.Max(max_count, item.index - first + 1);
                    }

                    if (item.node.left != null)
                        queue.Enqueue((item.node.left, item.index * 2));

                    if (item.node.right != null)
                        queue.Enqueue((item.node.right, item.index * 2 + 1));
                }
            }

            return max_count;
        }
    }
}
