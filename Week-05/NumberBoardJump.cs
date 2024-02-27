using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    internal class NumberBoardJump
    {
        public static int numboardjump(string[] board)
        {
            Stack<string> numbers = new Stack<string>(6);
            List<string> result = new List<string>();
            for (int i = 0; i < 25; i++)
            {
                boardjump(board, ref numbers, ref result, i);
            }
            return result.Count;
        }

        public static void boardjump(string[] board, ref Stack<string> numbers, ref List<string> result, int start)
        {
            if (numbers.Count == 6)
            {
                string nums = string.Join("", numbers);
                if (!result.Contains(nums))
                    result.Add(nums);
                return;
            }
            if ((start - 5) >= 0)
            {
                numbers.Push(board[start-5]);
                boardjump(board, ref numbers, ref result, start -5);
                numbers.Pop();
            }
            if ((start + 5) < 24)
            {
                numbers.Push(board[start + 5]);
                boardjump(board, ref numbers, ref result, start +5);
                numbers.Pop();
            }
            if ((start-1) >= 0)
            {
                numbers.Push(board[start-1]);
                boardjump(board, ref numbers, ref result, start -1);
                numbers.Pop();
            }
            if ((start+1) < 24)
            {
                numbers.Push(board[start+1]);
                boardjump(board, ref numbers, ref result, start +1);
                numbers.Pop();
            }
        }
    }
}
