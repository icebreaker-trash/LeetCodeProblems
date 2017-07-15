using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeConsole
{
    class _485MaxConsecutiveOnes
    {
        public int FindMaxConsecutiveOnes99(int[] nums)
        {
            var tmp= nums.GetEnumerator();
            int count = 0;
            IList<int> res = new List<int>();
            while (tmp.MoveNext())
            {
                if ((int)tmp.Current==1)
                {
                    count++;
                }
                else
                {
                    res.Add(count);
                    count = 0;
                }
                
            }

            return res.Any() ? res.Max() : 0;
        }

        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int res = 0, count = 0;
            foreach (var item in nums)
            {
                count = item == 0 ? 0 : count + 1;
                res = Math.Max(res, count);
            }
            return res;
        }
    }
}
