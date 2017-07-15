using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeConsole
{
    class _292NimGame
    {
        public class Solution
        {
            public bool CanWinNim(int n)
            {
                return n % 4 != 0;
            }
        }
    }
}
