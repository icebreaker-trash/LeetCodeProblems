using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeConsole
{
    class _500KeyboardRow
    {
        
        public static string[] FindWords(string[] words)
        {
            List<string> res = new List<string>();
            string[] constrow = { "qwertyuiop", "asdfghjkl", "zxcvbnm" }; 
            foreach (var item in words)
            {
                foreach (var row in constrow)
                {
                    bool flag = true;
                    foreach (var letter in item.ToLower())
                    {
                        if (row.IndexOf(letter)==-1)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        res.Add(item);
                        break;//满足1行必定不满足其余
                    }
                }
            }
            return res.ToArray();//565 ms 555 ms 659ms
        }


    }
}
