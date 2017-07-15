using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeConsole
{
    class _412FizzBuzz
    {
        public IList<string> FizzBuzz(int n)
        {
            IList<string> result = new List<string>();
            for (int i = 1; i < n+1; i++)
            {
                if (i%15==0)
                {
                    result.Add("FizzBuzz");
                }
                else if (i%3==0)
                {
                    result.Add("Fizz");
                }
                else if (i%5==0)
                {
                    result.Add("Buzz");
                }
                else
                {
                    result.Add(i.ToString());
                }
            }

            return result;
        }
    }
}
