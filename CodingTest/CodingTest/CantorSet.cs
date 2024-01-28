using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    internal class CantorSet
    {
        public static void Cantorset(int n, int status, ref List<char> output)
        {
            if (status == -1){
                output = new List<char>((int)Math.Pow(3, n));
                Cantorset(n, 1, ref output);
                return;
            }
            if (n == 0)
            {
                if (status == 0) 
                    output.Add(' ');
                else
                    output.Add('-');
                return;
            }
            int MAX = (int)Math.Pow(3, n);
            if (status == 0)
            {
                Cantorset(0, 0, ref output);
                return;
            }
            Cantorset(n - 1, status, ref output);
            for (int i = 0; i < MAX / 3; i++)
            {
                Cantorset(n - 1, 0, ref output);
            }
            Cantorset(n - 1, status, ref output);
        }
    }
}
