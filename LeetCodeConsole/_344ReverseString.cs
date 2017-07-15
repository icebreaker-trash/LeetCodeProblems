using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace LeetCodeConsole
{
    class _344ReverseString
    {
        public static string ReverseString(string s)
        {
            return new string(s.Reverse().ToArray());
        }

        public static string ReverseString2(string s)
        {
            
            Stack<char> charStack = new Stack<char>();
            foreach (char t in s)
            {
                charStack.Push(t);
            }
            return new string(charStack.ToArray());
        }

        public static string ReverseString3(string s)
        {
            var rev = s.ToCharArray();
            Array.Reverse(rev);
            return new string(rev);
        }
    }
}
