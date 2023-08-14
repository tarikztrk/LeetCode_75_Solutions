using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_75_Solutions
{
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
