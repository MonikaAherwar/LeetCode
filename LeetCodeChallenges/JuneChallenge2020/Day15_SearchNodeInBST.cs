namespace LeetCodeChallenges.JuneChallenge2020
{
    class Day15_SearchNodeInBST
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            while (root != null)
            {
                if (root.val == val)
                {
                    return root;
                }

                root = root.val > val ? root.left : root.right;
            }

            return null;
        }
    }
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
}
