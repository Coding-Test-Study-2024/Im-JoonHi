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

        static void Main(string[] args)
        {
            int[,] graph = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                string input = Console.ReadLine();
                string[] Buf = input.Split(' ');
                graph[i,0] = int.Parse(Buf[0]);
                graph[i,1] = int.Parse(Buf[1]);
                graph[i,2] = int.Parse(Buf[2]);
                graph[i,3] = int.Parse(Buf[3]);
                graph[i,4] = int.Parse(Buf[4]);
            }
        }
    }
}
