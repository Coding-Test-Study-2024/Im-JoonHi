using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    internal class DFSandBFS
    {
        public static void DFS(in bool[,] graph, int start, out bool[] visited, out List<int> visitorder)
        {
            visited = new bool[graph.GetLength(0)];
            visitorder = new List<int>(graph.GetLength(0));

            for (int i = 0; i < graph.GetLength(0); i++)
            {
                visited[i] = false;
            }
            visited[start] = true;
            visitorder.Add(start+1);
            SearchNode(graph, start, visited, visitorder);
        }

        private static void SearchNode(in bool[,] graph, int start, bool[] visited, List<int> visitorder)
        {
            if(!visited[start])
                visitorder.Add(start+1);
            visited[start] = true;
            for (int i = 0; i < graph.GetLength(0); i++)
            {
                if (graph[start, i] && !visited[i])
                    SearchNode(graph, i, visited, visitorder);
            }
        }

        public static void BFS(in bool[,] graph, int start, out bool[] visited, out List<int> visitorder)
        {
            visited = new bool[graph.GetLength(0)];
            visitorder = new List<int>(graph.GetLength(0));

            for (int i = 0; i < graph.GetLength(0); i++)
            {
                visited[i] = false;
            }
            visited[start] = true;
            visitorder.Add(start+1);

            Queue<int> bfsQueue = new Queue<int>();

            bfsQueue.Enqueue(start);
            while (bfsQueue.Count > 0)
            {
                int next = bfsQueue.Dequeue();

                for (int i = 0; i < graph.GetLength(0); i++)
                {
                    if (graph[next, i] && !visited[i])
                    {
                        visitorder.Add(i + 1);
                        visited[i] = true;
                        bfsQueue.Enqueue(i);
                    }
                }
            }
        }
    }
}
