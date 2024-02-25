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

            // DFS 탐색
            bool[] dfsVisited;
            int[] dfsPath;
            DFSandBFS.DFS(in graph, start, out dfsVisited, out dfsPath);
            Console.WriteLine("<DFS>");
            PrintGraphSearch(dfsVisited, dfsPath);
            Console.WriteLine();

            // BFS 탐색
            bool[] bfsVisited;
            int[] bfsPath;
            DFSandBFS.BFS(in graph, start, out bfsVisited, out bfsPath);
            Console.WriteLine("<BFS>");
            PrintGraphSearch(bfsVisited, bfsPath);
            Console.WriteLine();
        }
        private static void PrintGraphSearch(bool[] visited, int[] path)
        {
            Console.WriteLine($"{"Vertex",8}{"Visit",8}{"Path",8}");

            for (int i = 0; i < visited.Length; i++)
            {
                Console.WriteLine($"{i,8}{visited[i],8}{path[i],8}");
            }
        }
    }
}
