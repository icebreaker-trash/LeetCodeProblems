using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeConsole
{
    class _566ReshapetheMatrix
    {
        public static int[,] MatrixReshape(int[,] nums, int r, int c)
        {
            int[,] target = new int[r,c];
            if (nums.Length==r*c)
            {
                IList<int> total = new List<int>();
                foreach (var item in nums)
                {
                    total.Add(item);
                }
                int index = 0;
                for (int i = 0; i < r; i++)
                {
                    for (int j = 0; j < c; j++)
                    {
                        target[i, j] = total[index];
                        index++;
                    }
                }
                return target;
            }
            return nums;
        }
    }
}
