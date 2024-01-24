using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    internal class NQweens
    {
        public static void NQween(int n, int loop, int[] qweens, ref int result)
        {
            if (loop == n)
            {
                Console.WriteLine(string.Join(", ", qweens));
                result += 1;
                return;
            }
            for (int i = 0; i < n; i++)
            {
                if (qweens.Contains(i))
                    continue;
                if (CanPlace(qweens, i))
                {
                    qweens[loop] = i;
                    NQween(n, loop + 1, qweens, ref result);
                }
                qweens[loop] = -1;
            }
        }

        public static bool CanPlace(int[] qweens, int col)
        {
            int row = 0;
            if (qweens[0] == -1)
                return true;
            for (int i = 0; i < qweens.Length; i++)
                if (qweens[i] == -1)
                {
                    row = i;
                    break;
                }
            for (int i = 0; i < row; i++)
            {
                if (qweens[i] == col)
                    return false;
                if (col == qweens[i] + row - i)
                    return false;
                if (qweens[i] - row + i > -1 && col == qweens[i] - row + i)
                    return false;
            }
            return true;
        }

        public static void Newboard(ref int[] board)
        {
            for (int i = 0; i < board.Length; i++)
                board[i] = -1;
        }
    }
}
