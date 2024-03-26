namespace CodingTest
{
    internal class Program
    {
        // 8주차

        /*
        // BOJ-1026 보물
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
        
        // BOJ-1049 기타줄
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            string[] buf = num.Split(" ");
            int n = int.Parse(buf[0]);
            int m = int.Parse(buf[1]);
            List<int> input1 = new List<int>(m);
            List<int> input2 = new List<int>(m);
            for (int i = 0; i < m; i++)
            {
                num = Console.ReadLine();
                buf = num.Split(" ");
                input1.Add(int.Parse(buf[0]));
                input2.Add(int.Parse(buf[1]));
            }
            Console.WriteLine(GuitarStrings.stringCount(n, ref input1, ref input2));
        }
        */
        //BOJ-1052 물병
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] buf = input.Split(" ");
            int n = int.Parse(buf[0]);
            int k = int.Parse(buf[1]);
            if (n <= 10000000 && k <= 1000)
                Console.WriteLine(WaterBottle.waterbottle(n, k));
            else
                Console.WriteLine(-1);
        }
    }
}
