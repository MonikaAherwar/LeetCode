namespace LeetCodeChallenges.JuneChallange2020
{
    public class Day1_InvertBinayTree
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            var l = InvertTree(root.left);
            var r = InvertTree(root.right);

            root.left = r;
            root.right = l;

            return root;
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
