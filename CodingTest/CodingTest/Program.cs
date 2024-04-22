namespace CodingTest
{
    internal class Program
    {

        /* 7주차 */

        // PGM-12951 JadenCase 문자열 만들기
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int n = int.Parse(num);
            List<int> input1 = new List<int>(n);
            List<int> input2 = new List<int>(n);

            string input;
            input = Console.ReadLine();
            string[] buf = input.Split(" ");
            for (int i = 0; i < n; i++)
                input1.Add(int.Parse(buf[i]));

            input = Console.ReadLine();
            buf = input.Split(" ");
            for (int i = 0; i < n; i++)
                input2.Add(int.Parse(buf[i]));

            input1.Sort(); input2.Sort();
            Console.WriteLine(Treasure.treasure(ref input1, ref input2));
        }

        // PGM-12939 최댓값과 최솟값
    }
}
