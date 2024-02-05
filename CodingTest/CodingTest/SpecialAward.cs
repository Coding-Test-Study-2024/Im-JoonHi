namespace CodingTest
{
    internal class SpecialAward
    {
        static public int specialAward(in int[,] input, int n, int x, int y)
        {
            List<int> buf;
            if (n == 2)
            {
                buf = new List<int>(4)
                {
                        input[y, x],
                        input[y, x + 1],
                        input[y + 1, x],
                        input[y + 1, x + 1]
                };
                buf.Sort();
                return buf[1];
            }

            int start = n / 2;
            buf = new List<int>(4)
            {
                        specialAward(input, n / 2, x, y),
                        specialAward(input, n / 2, x, y + start),
                        specialAward(input, n / 2, x + start, y),
                        specialAward(input, n / 2, x + start, y + start)
            };
            buf.Sort();
            return buf[1];
        }
    }
}
