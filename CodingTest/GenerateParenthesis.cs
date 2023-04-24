using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    internal class GenerateParenthesis
    {
        public IList<string> GenerateParentheses(int n)
        {
            List<string> ans = new List<string>();
            if (n == 0)
                ans.Add("");
            else
            {
                for (int c = 0; c < n; ++c)
                {
                    foreach (var left in GenerateParentheses(c))
                    {
                        foreach (var right in GenerateParentheses(c))
                        {
                            ans.Add($"({left}){right}");
                        }
                    }
                }
            }
            return ans;
        }
    }
}
