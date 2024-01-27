using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    internal class ChickenTopN
    {
        public static void ChickenTOPN(int K, int N, ref List<int> grade) 
        {
            int now = 0;

            for (int i = 0; i < K; i++)
            {
                grade.Sort(now, N / K, null);
                now += N / K;
            }
        }
    }
}
