using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeConsole
{
    class _371SumofTwoIntegers
    {
        public int GetSum(int a, int b)
        {
            while (true)
            {
                if (b == 0) return a;
                var a1 = a;
                a = a ^ b;
                b = (a1 & b) << 1;
            }
        }
    }
}
