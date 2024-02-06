using System.Diagnostics;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Text;

namespace CodingTest
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int n = int.Parse(num);
            int[,] ints = new int[n, n];

            string input;
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                string[] Buf = input.Split(' ');
                for (int j = 0; j < n; j++)
                    ints[i, j] = int.Parse(Buf[j]);
            }
            Console.WriteLine(SpecialAward.specialAward(ref ints, n, 0, 0));
        }
        

        // 색종이 만들기
        /*
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int n = int.Parse(num);
            bool[,] paper = new bool[n, n];

            string input;
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                string[] Buf = input.Split(' ');
                for (int j = 0; j < n; j++)
                    paper[i, j] = Buf[j] is "1" ? true : false;
            }

            int[] output = new int[2] { 0, 0 };
            MakingOrigami.origami(paper, n, 0, 0, ref output);
            foreach(int result in output)
                Console.WriteLine(result);
        }
        */
    }
}
