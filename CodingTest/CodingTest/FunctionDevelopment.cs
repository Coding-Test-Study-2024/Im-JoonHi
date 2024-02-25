using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    // 기능개발 https://school.programmers.co.kr/learn/courses/30/lessons/42586
    internal class FunctionDevelopment
    {
        public int[] solution(int[] progresses, int[] speeds)
        {
            List<int> answer = new List<int>(progresses.Length);
            int[] prog = progresses;
            int done = 0;
            bool end = false; 

            while (!end)
            {
                for (int i = 0; i < progresses.Length; i++)
                {
                    if (prog[i] != -1 && prog[i] != -2)
                    {
                        prog[i] += speeds[i];
                        if (prog[i] >= 100)
                            prog[i] = -1;
                    }
                    if (i == 0 && prog[i] == -1)
                    {
                        done++;
                        prog[i] = -2;
                    }
                    else if (prog[i] == -1 && prog[i - 1] == -2)
                    {
                        done++;
                        prog[i] = -2;
                    }
                }

                if (done != 0)
                    answer.Add(done);
                done = 0;
                end = true;
                for (int j = 0; j < prog.Length; j++)
                    if (prog[j] != -2) end = false;
            }

            return answer.ToArray();
        }
    }
}
