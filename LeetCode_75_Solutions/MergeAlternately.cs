using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_75_Solutions
{
    /**
     * You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, 
     * starting with word1. If a string is longer than the other, append the additional letters onto the end of the merged string.
     * 
     * Return the merged string.
     * Example 1
     * Input: word1 = "abc", word2 = "pqr"
     * Output: "apbqcr"
     * Explanation: The merged string will be merged as so:
     * word1:  a   b   c
     * word2:    p   q   r
     * merged: a p b q c r
     */
    
    public class MergeAlternatelySolution
    {
        public string MergeAlternately(string word1, string word2)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int max = word1.Length >= word2.Length ? word1.Length : word2.Length;
            for (int i = 0; i < max; i++)
            {
                if (i < word1.Length)
                {
                    stringBuilder.Append(word1[i]);
                }
                if (i < word2.Length)
                {
                    stringBuilder.Append(word2[i]);
                }
            }
            return stringBuilder.ToString();
        }
    }
}
