using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_75_Solutions
{ /**
   * For two strings s and t, we say "t divides s" if and only if s = t + ... + t (i.e., t is concatenated with itself one or more times).
   * Given two strings str1 and str2, return the largest string x such that x divides both str1 and str2.
   * Example 1:
   * 
   * Input: str1 = "ABCABC", str2 = "ABC"
   * Output: "ABC"
   * Example 2:
   * 
   * Input: str1 = "ABABAB", str2 = "ABAB"
   * Output: "AB"
   * Example 3:
   * 
   * Input: str1 = "LEET", str2 = "CODE"
   * Output: ""
   * 
   * Constraints:
   * 1 <= str1.length, str2.length <= 1000
   * str1 and str2 consist of English uppercase letters.
   * 
   */
    public class GcdOfStringsSolution
    {
        public string GcdOfStrings(string str1, string str2)
        {
            string baseStr = str1.Length >= str2.Length ? str2 : str1;
            int count = baseStr.Length;

            for (int i = 0; i < count; i++)
            {
                if (str1.Length % baseStr.Length == 0 && str2.Length % baseStr.Length == 0)
                {
                    if (str1 == JoinBase(baseStr, (str1.Length / baseStr.Length)) && str2 == JoinBase(baseStr, (str2.Length / baseStr.Length)))
                    {
                        return baseStr;
                    }
                    else
                    {
                        baseStr = baseStr.Substring(0, baseStr.Length - 1);
                    }
                }
                else
                {
                    baseStr = baseStr.Substring(0, baseStr.Length - 1);
                }
            }

            return "";
        }

        private string JoinBase(string str, int count)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                sb.Append(str);
            }
            return sb.ToString();
        }
    }
}
