using System;
using System.Collections.Generic;
using System.Text;
using LeetCodeChallenges.JuneChallenge2020;

namespace LeetCodeChallenges.JulyChallenge2020
{
    class Day02_BinaryTreeLevelOrderTraversal_II
    {
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {

            var result = new List<IList<int>>();

            if (root == null)
                return result;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Any())
            {
                var size = queue.Count;
                var level = new List<int>();

                while (size-- > 0)
                {
                    root = queue.Dequeue();
                    level.Add(root.val);

                    if (root.left != null)
                        queue.Enqueue(root.left);
                    if (root.right != null)
                        queue.Enqueue(root.right);
                }

                result.Insert(0, level);
            }

            return result;
        }
    }

    //Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
