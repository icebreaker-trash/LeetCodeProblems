using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeConsole
{
    class _136SingleNumber
    {
        public int SingleNumber(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            IList<int> list = new List<int>();
            foreach (var t in nums)
            {
                if (!set.Add(t))
                {
                    list.Add(t);
                }
            }

            return nums.Except(list).FirstOrDefault();
        }

        public int SingleNumber2(int[] nums)
        {
            return nums.GroupBy(x => x).First(g => g.Count() == 1).Key;
        }

        public int SingleNumber3(int[] nums)
        {
            int val = 0;
            foreach (var n in nums)
            {
                val ^= n;
            }
            return val;
        }


        public int SingleNumber4(int[] nums)
        {

            var dict = new HashSet<int>();

            foreach (int t in nums)
            {
                if (!dict.Add(t))
                {
                    dict.Remove(t);
                }
            }
            return dict.Single();
        }

        public int SingleNumber5(int[] nums)
        {
            return nums.Aggregate((x, y) => x ^ y);
        }

        public int SingleNumber6(int[] nums)
        {
            return nums.GroupBy(x => x).First(g => g.Count() == 1).Key;
        }
    }
}
