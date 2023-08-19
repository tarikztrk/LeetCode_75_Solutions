using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_75_Solutions
{
    public class MaxVowelsSolution
    {
        public int MaxVowels(string s, int k)
        {
            string vovels = "aeiou";
            string str = s.Substring(0, k);
            int count = str.Count(x => vovels.Contains(x));
            int max = count;
            for (int i = k; i < s.Length; i++)
            {
                if (count == k)
                {
                    return count;
                }
                if (vovels.Contains(s[i]))
                {
                    count++;
                }
                if (vovels.Contains(s[i-k]))
                {
                    count--;
                }
                max = max > count ? max : count;
            }
            return max;
        }
    }
}
