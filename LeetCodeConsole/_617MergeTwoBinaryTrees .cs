using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeConsole
{
    public class TreeNode
    {
        public int Val;
        public TreeNode Left;
        public TreeNode Right;

        public TreeNode(int x) => Val = x;

    }
    class _617MergeTwoBinaryTrees
    {
        public static TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            TreeNode node = t1==null&&t2==null?null:new TreeNode((t1?.Val??0) + (t2?.Val??0));//优先级问题
            if (node==null)
            {
                return null;
            }
            if (t1?.Left!=null||t2?.Left!=null)
            {
                node.Left = MergeTrees(t1?.Left, t2?.Left);
            }
            if (t1?.Right != null || t2?.Right != null)
            {
                node.Right = MergeTrees(t1?.Right, t2?.Right);
            }

            return node;
        }

        public static TreeNode TesTTreeNode()
        {
            TreeNode t1 = new TreeNode(1) {Left = new TreeNode(3){Left = new TreeNode(5)}, Right = new TreeNode(2)};
            TreeNode t2 =new TreeNode(2){Left = new TreeNode(1){Right = new TreeNode(4)},Right = new TreeNode(3){Right = new TreeNode(7)}};
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
