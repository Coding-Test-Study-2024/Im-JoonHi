using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    internal class QuadTree
    {
        static public void Quadtree(bool[,] file, int n, int x, int y, StringBuilder output)
        {
            bool video = file[y, x];
            bool isSame = true;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (file[y + i, x + j] != video)
                    {
                        isSame = false;
                        break;
                    }
                    if (!isSame) break;
                }
            if (!isSame)
            {
                output.Append("(");
                int start = n / 2;
                Quadtree(file, start, x, y, output);
                Quadtree(file, start, x + start, y, output);
                Quadtree(file, start, x, y + start, output);
                Quadtree(file, start, x + start, y + start, output);
                output.Append(")");
            }
            else
            {
                if (video == false)
                    output.Append("0");
                else
                    output.Append("1");
            }
        }
    }
}
