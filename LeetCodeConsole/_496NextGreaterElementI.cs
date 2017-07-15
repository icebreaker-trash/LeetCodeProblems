using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeConsole
{
    class _496NextGreaterElementI
    {
        public int[] NextGreaterElement(int[] findNums, int[] nums)
        {
            IList<int> result =new List<int>();
            foreach (int t in findNums)
            {
                int index = -1;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (t==nums[j])
                    {
                        index = j;
                    }
                    if (index!=-1)
                    {
                        if (nums[j]>t) //注意set这个条件
                        {
                            result.Add(nums[j]);
                            break;
                        }
                    }

                    if (j==nums.Length-1)
                    {
                        result.Add(-1);
                    }
                }
            }

            return result.ToArray();
        }

        public int[] NextGreaterElement2(int[] findNums, int[] nums)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();
            Stack<int> stk = new Stack<int>();
            int i = 0;
            while (i < nums.Length)
            {
                while (stk.Count != 0 && stk.Peek() < nums[i])
                    d[stk.Pop()] = nums[i];
                stk.Push(nums[i]);
                i++;
            }
            for (int j = 0; j < findNums.Length; j++)
                findNums[j] = d.ContainsKey(findNums[j]) ? d[findNums[j]] : -1;
            return findNums;
        }
    }
}
