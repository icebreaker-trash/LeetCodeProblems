using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeConsole
{
    class _575DistributeCandies
    {
        public static  int DistributeCandies(int[] candies)
        {
            if (candies.Length % 2 != 0) return -1;
            int diffkinds = candies.Distinct().Count();
            int distribute = candies.Length / 2;
            return diffkinds >= distribute ? distribute : diffkinds;
        }

        public int DistributeCandies2(int[] candies)
        {
            return Math.Min(
                candies.Length / 2,
                candies.Distinct().Count());
        }
    }
}
