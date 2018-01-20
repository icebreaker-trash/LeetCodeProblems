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

        public static string ReverseString4(string s)
        {
            int i = 0, j = s.Length-1;
            var chararr = s.ToCharArray();
            while (i<j)
            {
                var tmp = chararr[j];
                chararr[j] = chararr[i];
                chararr[i] = tmp;
                i++;
                j--;
            }
            return new string(chararr);
        }

        public static string ReverseString5(string s)
        {
            
            var chararr = s.ToCharArray();
            for (int i = 0; i < s.Length/2; i++)
            {
                var tmp = chararr[i];
                chararr[i] = chararr[s.Length-1-i];
                chararr[s.Length - 1 - i] = tmp;
            }
            
            return new string(chararr);
        }
    }
}
