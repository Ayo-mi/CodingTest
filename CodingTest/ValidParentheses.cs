/*
 * Valid Parentheses
 * Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if
 * the input string is valid.
 * An input string is valid if:
 * 1. Open brackets must be closed by the same type of brackets.
 * 2. Open brackets must be closed in the correct order.
 * 
 * Example 1:
 * Input: s = "()"
 * Output: true
 * 
 * Example 2:
 * Input: s = "([]{"
 * Output: true
 * 
 * Example 3:
 * Input: s = "(]" 
 * Output: false
 * 
 * Example 4:
 * Input: s = "[]"
 * Output: true
 * 
 * Constraints:
 * 
 * 1 <= s.length <= 104
 * s consists of parentheses only '[]{}'.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    class ValidParentheses
    {
        private Dictionary<char, char> hashTable;

        public ValidParentheses()
        {
            this.hashTable = new Dictionary<char, char>();
            this.hashTable.Add(')', '(');
            this.hashTable.Add('}', '{');
            this.hashTable.Add(']', '[');
        }

        public bool isValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            for(int i =0; i < s.Length; i++)
            {
                char c = s[i];

                if (this.hashTable.ContainsKey(c))
                {
                    char topElement = stack.Count == 0 ? '#' : stack.Pop();

                    if (topElement != this.hashTable[c])
                        return false;
                    
                }else
                    stack.Push(c);
            }

            return stack.Count == 0;
        }
    }
}
