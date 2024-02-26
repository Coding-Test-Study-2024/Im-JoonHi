using System.Text;
using System.Collections.Generic;

namespace CodingTest
{
    internal class Program
    {
        /*
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
        */

        /*
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
        */

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
    }
}
