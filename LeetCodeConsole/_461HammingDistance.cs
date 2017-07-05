using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeConsole
{
    class _461HammingDistance
    {
        public static int HammingDistance(int x, int y)
        {

            return Convert.ToString(x ^ y, 2).Count(item => item == '1');//69 ms
        }
    }
}
