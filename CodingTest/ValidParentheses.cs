using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
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
