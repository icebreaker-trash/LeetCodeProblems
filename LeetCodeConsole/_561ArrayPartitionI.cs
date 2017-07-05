using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeConsole
{
    class _561ArrayPartitionI
    {
        public static int ArrayPairSum(int[] nums)
        {
            if (nums.Length%2==0)
            {
                Array.Sort(nums);
                int res = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    res += nums[i];
                    i++;
                }
                return res;

            }
            return 0;

        }
    }
}
