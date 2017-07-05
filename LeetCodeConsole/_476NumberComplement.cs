using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeConsole
{
    class _476NumberComplement
    {
        public static int FindComplement(int num)
        {
            return num ^ (int.MaxValue >> Convert.ToString(num, 2).Length);
        }
    }
}
