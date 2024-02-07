namespace CodingTest
{
    // (a + b + c + d) % e
    // (a%e + b%e + c%e + d%e) % e

    internal class InheritedDisease
    {
        static long P = 1000000007;

        public static void inheriteddisese(Queue<int> D, Queue<int> input, int lastMax, int lastNode, int Gen, int nodenum)
        {
            if (input.Count == 0)
                return;
            if (lastMax == -1)
            {
                D.Enqueue(1);
                inheriteddisese(D, input, 1, 1, 1, 1);
                return;
            }
            // int thisGenNodenum = nodenum * Gen; // 이번에 제작할 노드 총 갯수
            // int thisGenSelect = (nodenum + lastNode - lastMax - 1) * Gen + input.Dequeue();
            int NodeSelect = input.Dequeue(); // 이번에 선택될 노드 번지
            Console.WriteLine();
            D.Enqueue(lastNode + ((nodenum - (lastMax - lastNode ) - 1) * (Gen+1) + NodeSelect));
            Console.WriteLine(NodeSelect);
            Console.WriteLine(lastNode + ((nodenum - (lastMax - lastNode) - 1) * (Gen + 1)));
            Console.WriteLine($"{nodenum * (Gen + 1) + lastMax} {lastNode + ((nodenum - (lastMax - lastNode) - 1) * (Gen + 1) + NodeSelect)} {Gen + 1} {nodenum * (Gen + 1)}");
            inheriteddisese(D, input, nodenum * (Gen + 1) + lastMax, lastNode + ((nodenum - (lastMax - lastNode) - 1) * (Gen + 1) + NodeSelect), Gen + 1, nodenum * (Gen + 1));
            // 3 [2] 2 2
            return;
        }
    }
}