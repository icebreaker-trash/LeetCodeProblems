using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeConsole
{
    class _104MaximumDepthofBinaryTree
    {
        public static int MaxDepth(TreeNode root)
        {
            if (root==null)
            {
                return 0;
            }
            int left = 1;
            int right = 1;
            left += MaxDepth(root.left);
            right += MaxDepth(root.right);
            return Math.Max(left, right);

        }

        public int MaxDepth2(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
        }
    }
}
