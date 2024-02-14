﻿using System.Text;

namespace CodingTest
{
    internal class Program
    {
        /* 3주차
        // 쿼드트리
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int n = int.Parse(num);
            bool[,] file = new bool[n, n];

            string input;
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                for (int j = 0; j < n; j++)
                    file[i, j] = input[j] is '1' ? true : false;
            }

            StringBuilder output = new StringBuilder();
            QuadTree.Quadtree(file, n, 0, 0, output);
            Console.WriteLine(output);
        }

        // 종이의 개수
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int n = int.Parse(num);
            int[,] ints = new int[n, n];

            string input;
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                string[] buf = input.Split(" ");
                for (int j = 0; j < n; j++)
                    ints[i, j] = int.Parse(buf[j]);
            }
            int[] output = new int[3] { 0, 0, 0 };
            NumberOfPapers.Numberofpapers(ints, n, 0, 0, ref output);
            foreach (int result in output)
                Console.WriteLine(result);
        }
        */

        // 하노이 탑 이동 순서
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sw = new StringBuilder();

            // 하노이 탑 최소이동횟수는 2^n - 1
            sw.AppendLine($"{Math.Pow(2, n) - 1}");
            HanoiMovementOrder.MoveOrder(sw, n, 1, 2, 3);
            Console.WriteLine(sw);
        }
    }
}
