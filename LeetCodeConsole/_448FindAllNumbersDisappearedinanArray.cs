using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeConsole
{
    class _448FindAllNumbersDisappearedinanArray
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            //TreeNode
            //IList<int> lst =new List<int>();
            //int len = nums.Length;
            int[] output = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                output[i] = i + 1;
            }
            return output.Except(nums).ToList();
            //return lst;
        }

        public IList<int> FindDisappearedNumbers2(int[] nums)
        {
            IList<int> re = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                //int n=;
                if (nums[Math.Abs(nums[i]) - 1] > 0)
                {
                    nums[Math.Abs(nums[i]) - 1] = -nums[Math.Abs(nums[i]) - 1];
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                    re.Add(i + 1);
            }
            return re;
        }
    }
}
