using System.Text;
using System.Collections.Generic;

namespace CodingTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;

            string name = "JEROEN";
            List<char> names = new List<char>(name.Length);
            foreach (char n in name)
                names.Add(n);
            foreach (char n in names)
            {
                Console.WriteLine(Convert.ToInt32(n)-64);
            }
        }
    }
}
