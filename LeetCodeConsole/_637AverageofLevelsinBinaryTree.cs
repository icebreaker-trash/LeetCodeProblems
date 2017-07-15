using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeConsole
{
    class _637AverageofLevelsinBinaryTree
    {
        public static IList<double> AverageOfLevels(TreeNode root)
        {
            List<double> result = new List<double> {root.val};
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count>0)
            {
                int count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    var indexNode = queue.Dequeue();
                    if (indexNode.left != null)
                    {
                        queue.Enqueue(indexNode.left);

                    }
                    if (indexNode.right != null)
                    {
                        queue.Enqueue(indexNode.right);

                    }
                }
                if (queue.Count>0)
                {
                    result.Add(queue.Average(t => t.val));
                }
                

            }
            return result;
        }
    }
}
