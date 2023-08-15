using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_75_Solutions
{
    //https://leetcode.com/problems/reverse-words-in-a-string/
    //151. Reverse Words in a String
    //Given an input string, reverse the string word by word.
    //Example 1:
    //Input: "the sky is blue"
    //Output: "blue is sky the"
    //Example 2:
    //Input: "  hello world!  "
    //Output: "world! hello"
    //Explanation: Your reversed string should not contain leading or trailing spaces.
    //Example 3:
    //Input: "a good   example"
    //Output: "example good a"
    //Explanation: You need to reduce multiple spaces between two words to a single space in the reversed string.
    public class ReverseWordsSolution
    {
        public string ReverseWords(string s)
        {
            StringBuilder sb = new StringBuilder();
            s = string.Join(" ", s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            string[] splittedWords = s.Split(' ').Reverse().ToArray();
            for (int i = 0; i < splittedWords.Length; i++)
            {
                sb.Append(splittedWords[i]); sb.Append(" ");
            }
            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }
    }
}
