using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    internal class HorseRunningRace
    {
        public class Solution
        {
            public string[] solution(string[] players, string[] callings)
            {

                LinkedList<string> list = new LinkedList<string>();
                var ranking = new SortedDictionary<string, LinkedListNode<string>>();

                foreach (string player in players)
                {
                    ranking.Add(player, list.AddLast(player));
                }

                foreach (string call in callings)
                {
                    LinkedListNode<string> buf = ranking[call].Previous;
                    list.Remove(ranking[call].Previous);
                    list.AddAfter(ranking[call], buf);
                }

                string[] answer = new string[players.Length];
                list.CopyTo(answer, 0);

                /*
                int num = -1;
                string buf = null;

                answer = players;
                for(int i = 0; i < callings.Length; i++){
                    num = rank(answer, callings[i]);
                    buf = answer[num];
                    answer[num] = answer[num-1];
                    answer[num-1] = buf;
                }

                return answer;
            }
            */
                return answer;
            }

            /*
            static int rank(string[] players, string called)
            {
                for (int i = 0; i < players.Length; i++)
                {
                    if (players[i] == called)
                        return i;
                }
                return -1;
            }
            */
        }
    }
}
