using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    internal class FloorDecoration
    {
        public static int Count(char[,] floor) 
        {
            int flooring = 0;
            bool[,] visited = new bool[floor.GetLength(0), floor.GetLength(1)];
            for (int i = 0; i < floor.GetLength(0); i++)
                for (int j = 0; j < floor.GetLength(1); j++)
                    visited[i, j] = false;

            for (int i = 0; i < floor.GetLength(0); i++)
            {
                for (int j = 0; j < floor.GetLength(1); j++)
                {
                    Console.Write(floor[i, j]);
                    if (visited[i, j] == false)
                    {
                        findfloor(-1, j, i, floor, ref visited);
                        flooring += 1;
                    }
                }
                Console.WriteLine();
            }

            return flooring;
        }

        public static void findfloor(int pattern, int x, int y, char[,] floor, ref bool[,] visited)
        {
            if (pattern == -1)
            {
                if (floor[y, x] == '-')
                {
                    visited[y, x] = true;
                    if (x != floor.GetLength(1) - 1)
                        findfloor(0, x + 1, y, floor, ref visited);
                }
                else if (floor[y, x] == '|')
                {
                    visited[y, x] = true;
                    if (y != floor.GetLength(0) - 1)
                        findfloor(1, x, y + 1, floor, ref visited);
                }
            }
            else if (pattern == 0)
            {
                if (floor[y, x] == '-')
                {
                    visited[y, x] = true;
                    if (x != floor.GetLength(1) - 1)
                        findfloor(0, x + 1, y, floor, ref visited);
                }
                else
                    return;
            }
            else if (pattern == 1)
            {
                if (floor[y, x] == '|')
                {
                    visited[y, x] = true;
                    if (y != floor.GetLength(0) - 1)
                        findfloor(1, x, y + 1, floor, ref visited);
                }
                else
                    return;
            }
        }
    }
}
