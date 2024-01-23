using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    internal class NQween
    {
        internal class NQweens
        {
            public void NQweens(int n, int loop, int[] qweens, ref int result)
            {
                if (loop == qweens.Length)
                    return;
                for (int i = loop; i < 0; i--)
                {

                }
            }

            public bool CanPlace(int[] qweens, int col)
            {
                int row = 0;
                for (int i = 0; i < qweens.Length; i++)
                    if (qweens[i] == -1)
                        row = i;
                for (int i = 0; i < row; i++) 
                {
                    if (qweens[i] == col)
                        return false;
                    if (((qweens[i] + 1) * col) == col)
                        return false;
                    if (((qweens[i] + 1))
                }
                return true;
            }
        }
    }
}
