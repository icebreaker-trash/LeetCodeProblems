using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace LeetCodeConsole
{
    class _557ReverseWordsinaStringIII
    {
        public static string ReverseWords(string s)
        {
            StringBuilder sb = new StringBuilder();
            Regex reg = new Regex(@"\S+");
            Regex spaceRegex = new Regex(@"\s+");
            var Enum = spaceRegex.Matches(s.Trim()).GetEnumerator();
            foreach (Match item in reg.Matches(s.Trim()))
            {
                sb.Append(new string(item.Value.Reverse().ToArray()));
                if (Enum.MoveNext())
                {
                    sb.Append(((Match)Enum.Current).Value);
                }
            }
            IList<string> skb = new List<string>();
            return sb.ToString();
        }

        public string ReverseWords2(string s)
        {
            char[] sb = s.ToCharArray();
            int i = 0;
            for (int j = 0; j < s.Length; j++)
            {
                if (sb[j] == ' ')
                {
                    Reverse(sb, i, j - 1);
                    i = j + 1;
                }
            }
            Reverse(sb, i, s.Length - 1);
            return new string(sb);

        }

        public void Reverse(char[] sb, int l, int r)
        {
            while (l < r)
            {
                char tmp = sb[l];
                sb[l] = sb[r];
                sb[r] = tmp;
                l++;
                r--;
            };
        }
    }
}
