using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeConsole
{
    class _538ConvertBSTtoGreaterTree
    {
        public int sum = 0;
        public TreeNode ConvertBST(TreeNode root)
        {
            if (root==null)
            {
                return null;
            }
            ConvertBST(root.right);
            root.val += sum;
            sum = root.val;
            ConvertBST(root.left);
            return root;


        }
    }
}
