using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_75_Solutions
{
    public class IsSubsequenceSolution
    {
        public bool IsSubsequence(string s, string t)
        {
            int newLocation = -1;
            for (int i = 0; i < s.Length; i++)
            {
                if (!t.Contains(s[i]))
                {
                    return false;
                }
                newLocation = t.IndexOf(s[i]);
                t = t.Remove(0, newLocation + 1);
            }
            foreach (char x in s)
            {
                if (!t.Contains(x))
                {
                    return false;
                }
                newLocation = t.IndexOf(x);
                t =t.Remove(0, newLocation+1);

            }
            return true;
        }
    }
}
