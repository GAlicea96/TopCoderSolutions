/*
 * Guillermo Alicea
 * 07.27.17
 * Problem: AB
 * 
*/

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TopCoder2.Easy
{
    class AB
    {
        private List<string> answers;
        private int N;
        private int K;

        public string createString(int N, int K)
        {
            answers = new List<string>();
            this.N = N;
            this.K = K;

            answerFinder(new StringBuilder());

            return answers.Count > 0 ? answers.First() : "";
        }

        private void answerFinder(StringBuilder current)
        {
            if (current.Length == N)
            {
                string temp = current.ToString();
                if (isValid(temp))
                {
                    answers.Add(temp);
                }
                return;
            }

            StringBuilder temp2 = new StringBuilder(current.ToString());
            temp2.Append("A");
            answerFinder(temp2);
            answerFinder(current.Append("B"));
        }

        private bool isValid(string candidate)
        {
            int kCount = 0;
            for (int j = 0; j < candidate.Length; j++)
            {
                if (candidate[j] != 'A') continue;

                for (int g = j + 1; g < candidate.Length; g++)
                {
                    if (candidate[g] == 'B')
                    {
                        kCount++;
                    }
                }
            }

            //Valid string found
            return kCount == K;
        }
    }
}
