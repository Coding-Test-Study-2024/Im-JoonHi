using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    // BOJ-1026 보물
    internal class Treasure
    {
        static public int treasure(ref List<int> nums1, ref List<int> nums2)
        {
            int result = 0;
            int n = nums1.Count;
            for(int i = 0; i < n; i++) 
            {
                result += nums1[i]*nums2[n-i-1];
            }
            return result;
        }
    }
}
