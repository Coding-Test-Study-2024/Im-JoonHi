namespace CodingTest
{
    internal class Program
    {
        //8주차

        // BOJ-5567 결혼식
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int n = int.Parse(num);
            num = Console.ReadLine();
            int m = int.Parse(num);
            bool[,] graph = new bool[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    graph[i, j] = false;

            for (int i = 0; i < m; i++)
            {
                string input = Console.ReadLine();
                string[] Buf2 = input.Split(' ');
                graph[(int.Parse(Buf2[0])) - 1, (int.Parse(Buf2[1])) - 1] = true;
                graph[(int.Parse(Buf2[1])) - 1, (int.Parse(Buf2[0])) - 1] = true;
            }

            bool[] Visited = new bool[graph.GetLength(0)];
            Array.Fill(Visited, false);
            List<int> bfsPath;
            Wedding.DFS(in graph, 0, out Visited, out bfsPath);
            int result = -1;
            foreach (bool numbers in Visited)
                if (numbers)
                    result++;
            Console.WriteLine(result);
        }


    }
}