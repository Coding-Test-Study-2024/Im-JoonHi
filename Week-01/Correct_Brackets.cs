using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    internal class Correct_Brackets
    {
        public class Solution
        {
            public bool solution(string s)
            {
                bool answer = true;
                if (s == null) return true;
                Stack<char> stack1 = new Stack<char>();
                foreach (char str in s)
                {
                    if (answer == true)
                    {
                        switch (str)
                        {
                            case '(':
                                stack1.Push(str);
                                break;
                            case ')':
                                if (stack1.Count == 0) answer = false;
                                else if (stack1.Count != 0 && stack1.Pop() != '(') answer = false;
                                break;
                            default:
                                break;
                        }
                    }
                }
                if (stack1.Count != 0) answer = false;
                return answer;
            }
        }
    }
}
