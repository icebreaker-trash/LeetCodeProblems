using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeConsole
{
    class _520DetectCapital
    {
        public class Solution
        {
            public bool DetectCapitalUse(string word)
            {
                if (word==String.Empty)
                {
                    return false;
                }
                if (word.ToUpper() == word)
                {
                    return true;
                }
                if (word.ToLower()==word)
                {
                    return true;
                }
                if (word.Length>1)
                {
                    for (int i = 1; i < word.Length; i++)
                    {
                        if (char.IsUpper(word[i]))
                        {
                            return false;
                        }
                    }
                }
                char[] chararray = word.ToCharArray();
                chararray[0] = char.ToUpper(chararray[0]);
                return new string(chararray) ==word;
            }

            public bool DetectCapitalUse2(string word)
            {
                string upper = word.ToUpper();
                if (upper == word)
                {
                    return true;
                }
                string lower = word.ToLower();
                if (lower == word)
                {
                    return true;
                }
                if (word.Substring(1) == lower.Substring(1))
                {
                    return true;
                }
                return false;
            }

            public bool DetectCapitalUse3(string word)
            {
                string up = word.ToUpper();
                if (up == word) return true;
                for (int i = 1; i < word.Length; i++)
                {
                    if (up[i] == word[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
