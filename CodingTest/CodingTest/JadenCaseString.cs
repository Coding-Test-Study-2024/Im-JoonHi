using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    internal class JadenCaseString
    {
        public string solution(string s)
        {
            char[] chars = s.ToLower().ToCharArray();
            chars[0] = char.ToUpper(chars[0]);
            for (int i = 1; i < chars.Length; i++)
                if (chars[i - 1] == ' ')
                    chars[i] = char.ToUpper(chars[i]);
            return string.Join(string.Empty, chars);
        }
    }
}
