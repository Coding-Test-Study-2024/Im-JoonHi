using System.Text;

namespace CodingTest
{
    internal class GlobalMaxMin
    {
        public string solution(string s)
        {
            List<int> ints = new List<int>();
            foreach (string buffer in s.Split(" "))
                ints.Add(int.Parse(buffer));
            ints.Sort();

            StringBuilder answer = new StringBuilder();
            answer.Append(ints[0]);
            answer.Append(" ");
            answer.Append(ints[ints.Count - 1]);
            return answer.ToString();
        }
    }
}
