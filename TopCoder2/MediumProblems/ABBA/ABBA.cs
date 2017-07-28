/*
 * Guillermo Alicea
 * 07.27.17
 * Problem: ABBA
 * 
*/

using System.Linq;
using System.Text;

namespace TopCoder2.MediumProblems.ABBA
{
    public class ABBA
    {
        public string canObtain(string initial, string target)
        {
            for (int i = target.Length - 1; i >= initial.Length; i--)
            {
                if (target.Last() == 'B')
                {
                    target = reverseString(target.Remove(i, 1));
                    continue;
                }

                target = target.Remove(i, 1);
            }

            return (initial == target) ? "Possible" : "Impossible";
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
