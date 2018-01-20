using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace LeetCodeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = -128;
            sbyte n = 127;
            sbyte b = -1;
            sbyte c = +0;
            sbyte d = -0;
            var s = Convert.ToString(a, 2);
            var s1 = Convert.ToString(n, 2);
            var s2 = Convert.ToString(b, 2);
            var s3 = Convert.ToString(c, 2);
            var s4 = Convert.ToString(d, 2);
            //_617MergeTwoBinaryTrees.TesTTreeNode();
            //TreeNode t1 = new TreeNode(1) { left = new TreeNode(3) { left = new TreeNode(5) }, right = new TreeNode(2) };
            //TreeNode t2 = new TreeNode(2) { left = new TreeNode(1) { right = new TreeNode(4) }, right = new TreeNode(3) { right = new TreeNode(7) } };

            //var r1 = t1?.left?.right?.val??0;
            //var r2 = t2?.left?.left?.val??0;

            //var res= _561ArrayPartitionI.ArrayPairSum(new int[] {1, 4, 3, 2});
            //var s = Convert.ToString(1000, 2);
            //int a = ~1000;
            //var s2 = Convert.ToString(a, 2);
            //var cc= a ^ 1000;
            //var cc2 = Convert.ToString(cc, 2);
            //var ee = Convert.ToInt32(s2,2);
            //var res =_500KeyboardRow.FindWords(new []{ "Hello", "Alaska", "Dad", "Peace" });

            //var res1 = _566ReshapetheMatrix.MatrixReshape(new [,] {{ 1, 2 },{ 3, 4 }}, 1, 4);
            //var res2 = _566ReshapetheMatrix.MatrixReshape(new[,] { { 1, 2 }, { 3, 4 } }, 2, 4);
            //var str = _557ReverseWordsinaStringIII.ReverseWords("Let's take LeetCode contest");
            //string read = File.ReadAllText(@"D:\Test\ReverseString.txt");
            //Stopwatch stopwatch = Stopwatch.StartNew();
            //var s=_344ReverseString.ReverseString(read);
            //stopwatch.Stop();
            ////Console.WriteLine(stopwatch.ElapsedMilliseconds.ToString());

            //Console.ReadKey();
            //IList<TreeNode> res = new List<TreeNode>();
            //res.Add(null);
            //res.Add(null);
            //res.Add(null);
            //res.Add(null);

            //Queue<TreeNode> tree = new Queue<TreeNode>();
            //tree.Enqueue(null);
            //tree.Enqueue(null);
            //tree.Enqueue(null);
            //tree.Enqueue(null);
            //tree.Enqueue(null);
            //tree.Enqueue(null);
            //_637AverageofLevelsinBinaryTree.AverageOfLevels(new TreeNode(3)
            //{
            //    left = new TreeNode(9),
            //    right = new TreeNode(20) {left = new TreeNode(15), right = new TreeNode(7)}
            //});

            //_463IslandPerimeter.IslandPerimeter(new int[,]
            //{
            //    {0, 1, 0, 0},
            //    {1, 1, 1, 0},
            //    {0, 1, 0, 0},
            //    {1, 1, 0, 0}
            //});
            //Console.WriteLine(1000^1000);
            //Console.ReadKey();
            //_104MaximumDepthofBinaryTree.MaxDepth(new TreeNode(1)
            //{
            //    left = new TreeNode(2)
            //    {
            //        left = new TreeNode(3) {left = new TreeNode(4) {right = new TreeNode(5) {right = new TreeNode(6)}}}
            //    }
            //});
            Console.ReadKey();
        }
    }
}