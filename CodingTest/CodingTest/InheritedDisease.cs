using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    // (a + b + c + d) % e
    // (a%e + b%e + c%e + d%e) % e

    internal class InheritedDisease
    {
        public static void inheriteddisese(Queue<int> D, Queue<int> input, int lastMax,int lastNode, int Gen, int nodenum)
        {
            if (input.Count == 0)
                return;
            if (lastMax == -1)
            {
                D.Enqueue(1);
                input.Dequeue();
                inheriteddisese(D, input, 1, 1, 2, 2);
                return;
            }
            // int thisGenNodenum = nodenum * Gen; // 이번에 제작할 노드 총 갯수
            // int thisGenSelect = (nodenum + lastNode - lastMax - 1) * Gen + input.Dequeue();
            int NodeSelect = input.Dequeue(); // 이번에 선택될 노드 번지
            Console.WriteLine((nodenum - (lastMax - lastNode) - 1) * Gen + NodeSelect);
            D.Enqueue(lastMax + (nodenum - (lastMax - lastNode) - 1) * Gen + NodeSelect);
            inheriteddisese(D, input, nodenum * (Gen+1), lastMax + (nodenum - (lastMax - lastNode) - 1) * Gen + NodeSelect, Gen + 1 , nodenum * Gen);
            return;
        }
    }
}
