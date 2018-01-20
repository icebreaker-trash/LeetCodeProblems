using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeConsole
{
    class _226InvertBinaryTree
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root==null)
            {
                return null;
            }
            var tmp = root.left;
            root.left = InvertTree(root.right);
            root.right = InvertTree(tmp);
            return root;
        }
    }
}
