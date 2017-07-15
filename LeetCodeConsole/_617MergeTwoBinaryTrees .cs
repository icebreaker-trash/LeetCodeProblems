using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeConsole
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x) => val = x;

    }
    class _617MergeTwoBinaryTrees
    {
        public static TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            TreeNode node = t1==null&&t2==null?null:new TreeNode((t1?.val??0) + (t2?.val??0));//优先级问题
            if (node==null)
            {
                return null;
            }
            if (t1?.left!=null||t2?.left!=null)
            {
                node.left = MergeTrees(t1?.left, t2?.left);
            }
            if (t1?.right != null || t2?.right != null)
            {
                node.right = MergeTrees(t1?.right, t2?.right);
            }

            return node;
        }

        public static TreeNode TesTTreeNode()
        {
            TreeNode t1 = new TreeNode(1) {left = new TreeNode(3){left = new TreeNode(5)}, right = new TreeNode(2)};
            TreeNode t2 =new TreeNode(2){left = new TreeNode(1){right = new TreeNode(4)},right = new TreeNode(3){right = new TreeNode(7)}};
            var result = MergeTrees(t1, t2);
            return result;
        }

        //public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        //{
        //    if (t1 == null) return t2;
        //    if (t2 == null) return t1;
        //    TreeNode node = new TreeNode(t1.val + t2.val);
        //    node.left = MergeTrees(t1.left, t2.left);
        //    node.right = MergeTrees(t1.right, t2.right);
        //    return node;
        //}
    }


}
