using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    // BOJ-2630 색종이 만들기
    internal class MakingOrigami
    {
        public static void origami(bool[,] paper, int n, int x, int y, ref int[] output) 
        {
            bool color = paper[y, x];
            bool isSame = true;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (paper[y + i, x + j] != color)
                    {
                        isSame = false;
                        break;
                    }
                if (!isSame) break;
                }
            if (!isSame)
            {
                int start = n / 2;
                origami(paper, start, x, y, ref output);
                origami(paper, start, x + start, y, ref output);
                origami(paper, start, x, y + start, ref output);
                origami(paper, start, x + start, y + start, ref output);
            }
            else
            {
                if (color == false)
                    output[0] += 1;
                else
                    output[1] += 1;
            }
        }
    }
}
