using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    internal class Activate_code
    {
        static void Main1(string[] args)
        {
            /* 1주차

            // 바닥 장식
            StringBuilder sb = new StringBuilder();

            string num = Console.ReadLine();
            string[] splited = num.Split(" ");
            int N = int.Parse(splited[0]);
            int M = int.Parse(splited[1]);
            char[,] floor = new char[N, M];

            int coord = 0;
            string input = Console.ReadLine();
            while (!string.IsNullOrEmpty(input))
            {
                for (int i = 0; i < input.Length; i++)
                    floor[coord, i] = input[i];
                coord++;
                input = Console.ReadLine();
            }
            Console.WriteLine(FloorDecoration.Count(floor));

            // ChickenTopN
            string input = Console.ReadLine();
            int N = int.Parse(input);
            List<int> grade = new List<int>(N);
            input = Console.ReadLine();
            for (int i = 0; i < N; i++)
                grade.Add(int.Parse((input.Split(" "))[i]));
            input = Console.ReadLine();
            int K = int.Parse(input);
            ChickenTopN.ChickenTOPN(K, N, ref grade);
            Console.WriteLine(string.Join(' ', grade));

            // 칸토어 집합
            StringBuilder sb = new StringBuilder();

            string input = Console.ReadLine();
            while (!string.IsNullOrEmpty(input))
            {
                int N = int.Parse(input);
                List<char> output = new List<char>();
                CantorSet.Cantorset(N, -1, ref output);
                foreach (char c in output)
                    sb.Append(c);
                sb.AppendLine();
                input = Console.ReadLine();
            }
            Console.WriteLine(sb.ToString());
            */

            /* 2주차

            // InheritedDisease
            static void Main(string[] args)
            {
                string num = Console.ReadLine();
                int n = int.Parse(num);

                Queue<int> ints = new Queue<int>(n);
                string input = Console.ReadLine();
                string[] Buf = input.Split(' ');
                for (int i = 0; i < n; i++)
                    ints.Enqueue(int.Parse(Buf[i]));

                Queue<int> D = new Queue<int>(n);
                InheritedDisease.inheriteddisese(D, ints, -1, 0, 0, 0);

                for (int i = 0; i < n; i++)
                    Console.Write($"{D.Dequeue()} ");
            }

            //특별상이라도 받고 싶어
            static void Main(string[] args)
            {
                string num = Console.ReadLine();
                int n = int.Parse(num);
                int[,] ints = new int[n, n];

                string input;
                for (int i = 0; i < n; i++)
                {
                    input = Console.ReadLine();
                    string[] Buf = input.Split(' ');
                    for (int j = 0; j < n; j++)
                        ints[i, j] = int.Parse(Buf[j]);
                }
                Console.WriteLine(SpecialAward.specialAward(ref ints, n, 0, 0));
            }

            // 색종이 만들기
            static void Main(string[] args)
            {
                string num = Console.ReadLine();
                int n = int.Parse(num);
                bool[,] paper = new bool[n, n];

                string input;
                for (int i = 0; i < n; i++)
                {
                    input = Console.ReadLine();
                    string[] Buf = input.Split(' ');
                    for (int j = 0; j < n; j++)
                        paper[i, j] = Buf[j] is "1" ? true : false;
                }

                int[] output = new int[2] { 0, 0 };
                MakingOrigami.origami(paper, n, 0, 0, ref output);
                foreach(int result in output)
                    Console.WriteLine(result);
            }
            */

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
       */

            /* 5주차
            // BOJ-2606 바이러스
            static void Main(string[] args)
            {
                string num = Console.ReadLine();
                int n = int.Parse(num);
                bool[,] graph = new bool[n,n];
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        graph[i, j] = false;

                num = Console.ReadLine();
                n = int.Parse(num);

                for (int i = 0; i < n; i++)
                {
                    string input = Console.ReadLine();
                    string[] Buf = input.Split(' ');
                    graph[(int.Parse(Buf[0]))-1, (int.Parse(Buf[1]))-1] = true;
                    graph[(int.Parse(Buf[1]))-1, (int.Parse(Buf[0]))-1] = true;
                }

                bool[] bfsVisited;
                Virus.virus(in graph, 0, out bfsVisited);
                Console.WriteLine(PrintGraphSearch(bfsVisited));
            }

            private static int PrintGraphSearch(bool[] visited)
            {
                int visit = -1;
                for (int i = 0; i < visited.Length; i++)
                {
                    if (visited[i] == true) visit++;
                }
                return visit;
            }

            // BOJ-1260 DFS와 BFS
            static void Main(string[] args)
            {
                string num = Console.ReadLine();
                string[] Buf = num.Split(' ');
                int n = int.Parse(Buf[0]);
                int start = int.Parse(Buf[2]);
                bool[,] graph = new bool[n, n];
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        graph[i, j] = false;

                n = int.Parse(Buf[1]);
                for (int i = 0; i < n; i++)
                {
                    string input = Console.ReadLine();
                    string[] Buf2 = input.Split(' ');
                    graph[(int.Parse(Buf2[0])) - 1, (int.Parse(Buf2[1])) - 1] = true;
                    graph[(int.Parse(Buf2[1])) - 1, (int.Parse(Buf2[0])) - 1] = true;
                }

                bool[] Visited = new bool[graph.GetLength(0)];
                Array.Fill(Visited, false);
                // DFS 탐색
                bool[] dfsVisited;
                List<int> dfsPath;
                DFSandBFS.DFS(in graph, start-1, out Visited, out dfsPath);
                foreach (int numbers in dfsPath)
                    Console.Write($"{numbers} ");
                Console.WriteLine();

                // BFS 탐색
                Array.Fill(Visited, false);
                List<int> bfsPath;
                DFSandBFS.BFS(in graph, start-1, out Visited, out bfsPath);
                foreach (int numbers in bfsPath)
                    Console.Write($"{numbers} ");
                Console.WriteLine();
            }

            // BOJ-2210 숫자판 점프
            static void Main(string[] args)
            {
                List<string> board = new List<string>(25);
                for (int i = 0; i < 5; i++)
                {
                    string input = Console.ReadLine();
                    string[] Buf = input.Split(' ');
                    board.Add(Buf[0]);
                    board.Add(Buf[1]);
                    board.Add(Buf[2]);
                    board.Add(Buf[3]);
                    board.Add(Buf[4]);
                }
                Console.Write(NumberBoardJump.numboardjump(board.ToArray()));
            }
            */

            /* 6주차

            // BOJ-1026 보물
            static void Main(string[] args)
            {
                string num = Console.ReadLine();
                int n = int.Parse(num);
                List<int> input1 = new List<int>(n);
                List<int> input2 = new List<int>(n);

                string input;
                input = Console.ReadLine();
                string[] buf = input.Split(" ");
                for (int i = 0; i < n; i++)
                    input1.Add(int.Parse(buf[i]));

                input = Console.ReadLine();
                buf = input.Split(" ");
                for (int i = 0; i < n; i++)
                    input2.Add(int.Parse(buf[i]));

                input1.Sort(); input2.Sort();
                Console.WriteLine(Treasure.treasure(ref input1, ref input2));
            }
        
            // BOJ-1049 기타줄
            static void Main(string[] args)
            {
                string num = Console.ReadLine();
                string[] buf = num.Split(" ");
                int n = int.Parse(buf[0]);
                int m = int.Parse(buf[1]);
                List<int> input1 = new List<int>(m);
                List<int> input2 = new List<int>(m);
                for (int i = 0; i < m; i++)
                {
                    num = Console.ReadLine();
                    buf = num.Split(" ");
                    input1.Add(int.Parse(buf[0]));
                    input2.Add(int.Parse(buf[1]));
                }
                Console.WriteLine(GuitarStrings.stringCount(n, ref input1, ref input2));
            }

            //BOJ-1052 물병
            static void Main(string[] args)
            {
                string input = Console.ReadLine();
                string[] buf = input.Split(" ");
                int n = int.Parse(buf[0]);
                int k = int.Parse(buf[1]);
                if (n <= 10000000 && k <= 1000)
                    Console.WriteLine(WaterBottle.waterbottle(n, k));
                else
                    Console.WriteLine(-1);
            }
            */

            /* 번외

            /* NQWEEN
            Console.Write("NQween 입력 : ");
            int input = int.Parse(Console.ReadLine());
            int[] qweens = new int[input];
            NQweens.Newboard(ref qweens);
            int result = 0;
            NQweens.NQween(input, 0, qweens, ref result);
            Console.WriteLine("///");
            Console.WriteLine(result);
            */
        }
    }
}
