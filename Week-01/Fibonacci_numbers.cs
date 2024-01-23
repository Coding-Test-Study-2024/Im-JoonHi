using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    internal class Fibonacci_numbers
    {
        public class Solution
        {
            public int fivonacci(int loop, int prev, int now)
            {
                if (loop == 0) return prev;
                return fivonacci(loop - 1, now % 1234567, (prev + now) % 1234567);
            }

            public int solution(int n)
            {
                int answer = fivonacci(n, 0, 1);
                return answer;
            }
        }
    }
}
