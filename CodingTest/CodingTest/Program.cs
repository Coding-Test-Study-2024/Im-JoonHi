namespace CodingTest
{
    internal class Program
    {

        /* 7주차 */

        // BOJ-17204 죽음의 게임
        /*
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
        */

        // BOJ-1446 지름길
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            string[] buf = num.Split(" ");
            int n = int.Parse(buf[0]);
            int d = int.Parse(buf[1]);

            List<int> index = new List<int>();

            List<int> input1 = new List<int>(n);
            List<int> input2 = new List<int>(n);
            List<int> input3 = new List<int>(n);
            for (int i = 0; i < n; i++)
            {
                num = Console.ReadLine();
                buf = num.Split(" ");
                input1.Add(int.Parse(buf[0]));
                input2.Add(int.Parse(buf[1]));
                if (input2[i] < d)
                    if (!index.Contains(input2[i]))
                        index.Add(input2[i]);
                input3.Add(int.Parse(buf[1]));
            }
            index.Sort();


        }

    }
}
