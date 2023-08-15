using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_75_Solutions
{
    public class CompressSolution
    {
        //https://leetcode.com/problems/string-compression/
        //443. String Compression
        //Given an array of characters, compress it in-place.
        //The length after compression must always be smaller than or equal to the original array.
        //Every element of the array should be a character (not int) of length 1.
        //After you are done modifying the input array in-place, return the new length of the array.
        //Follow up:
        //Could you solve it using only O(1) extra space?
        //Example 1:
        //Input:
        //["a","a","b","b","c","c","c"]
        //Output:
        //Return 6, and the first 6 characters of the input array should be: ["a","2","b","2","c","3"]

        //public int Compress(char[] chars)
        //{
        //    int count = 1;
        //    int index = 0;
        //    for (int i = 0; i < chars.Length; i++)
        //    {
        //        if (i != chars.Length - 1 && chars[i + 1] == chars[i])
        //        {
        //            count++;
        //        }
        //        else if (i != chars.Length - 1 && chars[i + 1] != chars[i])
        //        {
        //            chars[index++] = chars[i];
        //            if (count > 1)
        //            {
        //                foreach (char item in count.ToString().ToCharArray())
        //                {
        //                    chars[index++] = item;
        //                }
        //            }
        //            count = 1;
        //        }
        //        else
        //        {
        //            chars[index++] = chars[i];
        //            foreach (char item in count.ToString().ToCharArray())
        //            {
        //                chars[index++] = item;
        //            }
        //        }
        //    }
        //    return index;
        //}


        public int Compress(char[] chars)
        {
            StringBuilder sb = new StringBuilder();
            int count = 1;
            for (int i = 0; i < chars.Length; i++)
            {
                if (i != chars.Length - 1 && chars[i + 1] == chars[i])
                {
                    count++;
                }
                else if (i != chars.Length - 1 && chars[i + 1] != chars[i])
                {
                    sb.Append(chars[i]);
                    if (count > 1)
                    {
                        sb.Append(count);
                        count = 1;
                    }
                }
                else
                {
                    sb.Append(chars[i]);
                    sb.Append(count);
                }
            }
            return sb.ToString().ToCharArray().Length;
        }
    }
}
