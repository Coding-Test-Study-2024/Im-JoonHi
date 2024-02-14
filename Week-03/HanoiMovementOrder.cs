using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    internal class HanoiMovementOrder
    {
        public static void MoveOrder(StringBuilder sw, int n, int from, int mid, int to)
        {
            // n 원판갯수, from 출발지점, mid 중간지점, to 도착지점
            if (n == 0)
                return;
            // 현제 가장 큰 원판이 없는 경우의 하노이 움직임
            // 당연히 빈곳이될 중앙을 to로 바꿈
            MoveOrder(sw, n - 1, from, to, mid);

            // 가장 큰 원판의 이동
            sw.Append(from);
            sw.Append(" ");
            sw.AppendLine($"{to}");

            // 모두 중간에 옮겼으니 다시 끝으로 이동시키는 재귀를 돌린다.
            MoveOrder(sw, n - 1, mid, from, to);
        }
    }
}
