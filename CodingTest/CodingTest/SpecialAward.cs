namespace CodingTest
{
    // BOJ-24460 특별상이라도 받고 싶어
    internal class SpecialAward
    {
        static public int specialAward(in int[,] input, int n, int x, int y)
        {
            int[] buf = new int[4];
            if (n == 2)
            {
                buf = [input[y, x],input[y, x + 1],input[y + 1, x],input[y + 1, x + 1]];
                Array.Sort(buf);
                return buf[1];
            }

            int start = n / 2;
            buf =
            [
                        specialAward(input, n / 2, x, y),
                        specialAward(input, n / 2, x, y + start),
                        specialAward(input, n / 2, x + start, y),
                        specialAward(input, n / 2, x + start, y + start)
            ];
            Array.Sort(buf);
            return buf[1];
        }
    }
}
