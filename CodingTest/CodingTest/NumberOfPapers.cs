using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    internal class NumberOfPapers
    {
        public static void Numberofpapers(int[,] ints, int n, int x, int y, ref int[] output)
        {
            int color = ints[y, x];
            bool isSame = true;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (ints[y + i, x + j] != color)
                    {
                        isSame = false;
                        break;
                    }
                    if (!isSame) break;
                }
            if (!isSame)
            {
                int start = n / 3;
                Numberofpapers(ints, start, x, y, ref output);
                Numberofpapers(ints, start, x + start, y, ref output);
                Numberofpapers(ints, start, x + start + start, y, ref output);
                Numberofpapers(ints, start, x, y + start, ref output);
                Numberofpapers(ints, start, x + start, y + start, ref output);
                Numberofpapers(ints, start, x + start + start, y + start, ref output);
                Numberofpapers(ints, start, x, y + start + start, ref output);
                Numberofpapers(ints, start, x + start, y + start + start, ref output);
                Numberofpapers(ints, start, x + start + start, y + start + start, ref output);
            }
            else
            {
                switch (color)
                {
                    case -1:
                        output[0] += 1;
                        break;
                    case 0:
                        output[1] += 1;
                        break;
                    case 1:
                        output[2] += 1;
                        break;
                }
            }
        }
    }
}
