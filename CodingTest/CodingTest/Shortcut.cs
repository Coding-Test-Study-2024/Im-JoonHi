namespace CodingTest
{
    internal class Shortcut
    {
        static public int shortcut(int n, int d, List<int> index, List<int> input1, List<int> input2, List<int> input3)
        {
            foreach(int end in input2)
            {

            }
            return 0;
        }

        public static void DFS(in bool[,] graph, int start, out bool[] visited, out int[] parents)
        {
            visited = new bool[graph.GetLength(0)];
            parents = new int[graph.GetLength(0)];

            for (int i = 0; i < graph.GetLength(0); i++)
            {
                visited[i] = false;
                parents[i] = -1;
            }

            SearchNode(graph, start, visited, parents);
        }

        private static void SearchNode(in bool[,] graph, int start, bool[] visited, int[] parents)
        {
            visited[start] = true;
            for (int i = 0; i < graph.GetLength(0); i++)
            {
                if (graph[start, i] &&
                    !visited[i])
                {
                    parents[i] = start;
                    SearchNode(graph, i, visited, parents);
                }
            }
        }
    }
}
