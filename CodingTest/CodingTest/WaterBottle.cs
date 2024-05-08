namespace CodingTest
{
    internal class WaterBottle
    {
        // BOJ-1052 물병
        static public int waterbottle(int n, int k)
        {
            if (n <= k)
                return 0;   // 만약 n <= k 라면 조건을 달성한 것이기에 바로 0을 출력
            int result = n;
            int answer = 0;
            List<int> pow2 = new List<int>();   // 2의 거듭제곱 리스트
            int pow = 1;
            pow2.Add(pow);
            while (true)                        // 계산에 필요한 만큼의 거듭제곱 리스트 생성
            {
                pow *= 2;
                pow2.Add(pow);
                if (pow > n)
                    break;
            }
            for (int i = 0; i < k - 1; i++)     // 2의 거듭제곱과 뺴면서 마지막 1개를 제외한 나머지 모두 만들수있는 병을 만든다.
            {
                for (int j = i + 2; j > 0; j--)
                {
                    if (pow2.Count() >= j && (result - (pow2[pow2.Count() - j]) > 0))
                    {
                        result -= pow2[pow2.Count() - j];
                        break;
                    }
                }
                if (result == 0)
                    break;
            }
            if (result != 0)                    // 마지막 하나로 병 하나를 만들수 있게 만들 병 갯수를 찾는다.
                for(int i = 0; i < pow2.Count(); i++)
                    if(result <= pow2[i])
                    {
                        answer = pow2[i] - result;
                        break;
                    }
            return answer;
        }
    }
}
