namespace CodingTest
{
    // BOJ-2606 바이러스
    internal class Virus
    {
        public static void virus(in bool[,] graph, int start, out bool[] visited)
        {
            visited = new bool[graph.GetLength(0)];

            for (int i = 0; i < graph.GetLength(0); i++)
            {
                visited[i] = false;
            }
            visited[start] = true;

            Queue<int> bfsQueue = new Queue<int>();

            bfsQueue.Enqueue(start);
            while (bfsQueue.Count > 0)
            {
                int next = bfsQueue.Dequeue();

                for (int i = 0; i < graph.GetLength(0); i++)
                {
                    if (graph[next, i] &&
                        !visited[i])
                    {
                        visited[i] = true;
                        bfsQueue.Enqueue(i);
                    }
                }
            }
        }
    }
}
