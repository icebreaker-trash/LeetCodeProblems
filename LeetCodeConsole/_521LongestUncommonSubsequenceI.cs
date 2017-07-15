using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeConsole
{
    class _521LongestUncommonSubsequenceI
    {
        public int FindLUSlength(string a, string b)
        {
            return a == b ? -1 : Math.Max(a.Length, b.Length);
        }
    }
}
