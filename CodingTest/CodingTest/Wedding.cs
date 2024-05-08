using System.ComponentModel;

namespace CodingTest
{
    internal class Wedding
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
            visitorder.Add(start + 1);
            SearchNode(graph, start, visited, visitorder, 0);
        }

        private static void SearchNode(in bool[,] graph, int start, bool[] visited, List<int> visitorder, int visitNum)
        {
            if (!visited[start])
                visitorder.Add(start + 1);
            visited[start] = true;
            if (visitNum == 3)
                return;
            for (int i = 0; i < graph.GetLength(0); i++)
            {
                if (graph[start, i] && !visited[i])
                    SearchNode(graph, i, visited, visitorder, visitNum + 1);
            }
        }
    }
}
