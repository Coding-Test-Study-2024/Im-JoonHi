using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    // BOJ-1049 기타줄
    internal class GuitarStrings
    {
        public static int stringCount(int n, ref List<int> input1, ref List<int> input2)
        {
            int min;
            input1.Sort();
            input2.Sort();
            min = input2[0]*n;                              // 낟게로 샀을때 최소값
            int j = input1[0]*((n/6)+1);                    // 전부 묶음으로 샀을때 최소값
            int k = (input1[0]*(n/6))+((n%6)*input2[0]);    // 섞어서 샀을때 최소값
            if (min > j)
                min = j;
            if (min > k)
                min = k;
            return min;
        }
    }
}
