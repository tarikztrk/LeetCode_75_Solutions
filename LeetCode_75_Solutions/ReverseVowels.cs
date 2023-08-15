using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_75_Solutions
{
    public class ReverseVowelsSolution
    {
        //https://leetcode.com/problems/reverse-vowels-of-a-string/
        //345. Reverse Vowels of a String
        //Write a function that takes a string as input and reverse only the vowels of a string.
        //Example 1:
        //Input: "hello"
        //Output: "holle"
        //Example 2: 
        //Input: "leetcode"
        //Output: "leotcede"

        public string ReverseVowels(string s)
        {

            StringBuilder sb = new StringBuilder(s);
            string characters = "aAeEiIoOuU";
            List<char> words = new List<char>();
            List<int> index = new List<int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (characters.Contains(s[i]))
                {
                    words.Add(s[i]);
                    index.Add(i);
                }
            }
            words.Reverse();
            for (int i = 0; i < index.Count; i++)
            {
                sb[index[i]] = words[i];
            }
            return sb.ToString();
        }


    }
}
