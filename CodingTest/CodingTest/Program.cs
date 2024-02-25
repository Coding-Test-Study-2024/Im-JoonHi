using System.Text;
using System.Collections.Generic;

namespace CodingTest
{
    internal class Program
    {
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
    }
}
