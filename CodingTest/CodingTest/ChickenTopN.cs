using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    internal class ChickenTopN
    {
        /* 첫 번째 줄에 치킨집의 개수 N(4 ≤ N ≤ 220)이 주어진다.
         * N은 항상 2의 거듭제곱 꼴이다.
         * 두 번째 줄에는 N개의 치킨집의 맛의 수치들이 빈칸을 구분으로 주어지며
         * 이 값은 10억보다 작거나 같은 자연수 또는 0이다.
         */

        public static void ChickenTOPN(int K, int N, ref List<int> grade) 
        {
            int now = 0;ㅎ

            for (int i = 0; i < K; i++)
            {
                // List.Sort(QuickSort 시작지점, 시작점으로부터 Sort할 인수 갯수, 소트 방식 (defult 오름차순))
                // List.Sort는 .Net4 이전은 퀵소트, 인트로 정렬, 현 .Net 8 기준 힙 정렬을 사용한다고 한다.
                // (MSDN : MicroSoft Developer Network 에서 List.Sort(인수3개) 참조)

                // 치킨집의 갯수 N을 K명이 나눠서 Sort를 진행
                grade.Sort(now, N / K, null);
                
                // 어디까지 Sort를 했는지 기록 후 진행한 정렬 지점부터 다시 정렬
                now += N / K;
            }
            // 예상되는 시간 복잡도 O(NlogN)
            // for문 안에 있으나 결국 N개의 인수를 정렬한것과 같기에 NlogN으로 수렴
            // N > K
            // K( (N/K)log(N/K) ) = K( N/KlogN - N/KlogK ) = NlogN - NlogK
            // => O(NlogN)

            // 결국 병합정렬또한 같은 시간복잡도를 가지기에 또같이 NlogN의 시간대를 가지기에 비슷한 시간대의 시간복잡도가 나온다.
        }
    }
}
