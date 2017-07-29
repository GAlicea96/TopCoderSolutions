/*
 * Guillermo Alicea
 * 07.28.17
 * Problem: ABBADiv1
 * 
*/

using System.Linq;
using System.Text;

namespace TopCoder2.EasyProblems.ABBADiv1
{
    public class ABBADiv1
    {
        private bool possible;

        public string canObtain(string initial, string target)
        {
            return (solution(initial, target)) ? "Possible" : "Impossible";
        }

        private bool solution(string initial, string target)
        {
            if (initial.Length >= target.Length)
            {
                return possible || initial.Equals(target);
            }

            if (target.First() == 'B')
                possible = possible || solution(initial, reverseString(target).Remove(target.Length - 1, 1));
            if (target.Last() == 'A')
                possible = possible || solution(initial, target.Remove(target.Length - 1, 1));

            return possible;
        }

        private string reverseString(string s)
        {
            StringBuilder temp = new StringBuilder();

            for (int i = s.Length - 1; i >= 0; i--)
            {
                temp.Append(s[i]);
            }

            return temp.ToString();
        }
    }
}
