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
            bool res = true;
            var a = s.Distinct().ToArray();
            foreach (var x in a)
            {
                if (!t.Contains(x))
                {
                    res = false;
                }
            }
            return res;
        }
    }
}
