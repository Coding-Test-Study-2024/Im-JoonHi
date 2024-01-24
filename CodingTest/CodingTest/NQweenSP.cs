using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace CodingTest
{
    internal class NQweenSP
    {
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

        // Hill-Cimbing Huristic board
        public static void Hboard(int n, ref int[][] Hboard, int[] board)
        {
            int[] row = new int[n];
            Array.Fill(row, 0);
            for (int i = 0; i < n; i++)
            {
                Array.Fill(Hboard, row);
            }
            int col = 0;
            for (int i = 0; i < n; i++)
            {
                board[i] = col;
                for (int j = 0; j < n; j++)
                {
                    Hboard[i][j] += 1;
                    Hboard[j][col] += 1;
                    if (n > Math.Abs(j - col))
                        Hboard[j][j - col] += 1;
                    if (n > Math.Abs(col - j))
                        Hboard[j][col - j] += 1;
                }
            }
            for (int i = 0; i < n; i++)
            {
                col = board[i];
                Hboard[i][col] = 0;
            }
        }
    }
}