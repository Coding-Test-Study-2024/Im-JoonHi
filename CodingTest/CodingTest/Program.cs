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
            Console.WriteLine(SpecialAward.specialAward(ints, n, 0, 0));
        }
    }
}
