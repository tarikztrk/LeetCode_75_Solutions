using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_75_Solutions
{
    public class ProductExceptSelfSolution
    {
        //https://leetcode.com/problems/product-of-array-except-self/
        //238. Product of Array Except Self
        //Given an array nums of n integers where n > 1,  return an array output such that output[i] is equal to the product of all the
        //elements of nums except nums[i].
        //Example:
        //Input:  [1,2,3,4]
        //Output: [24,12,8,6]
        
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] result = new int[nums.Length];
            int zeroCount = 0;
            int productZero = 1;
            int product = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    product *= nums[i];

                }
                if (nums[i] == 0) { zeroCount++; }
                productZero *= nums[i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0 && zeroCount == 1)
                {
                    result[i] = product;
                }
                else if (nums[i] == 0 && zeroCount > 1)
                {
                    result[i] = 0;
                }
                else
                {
                    result[i] = productZero / nums[i];
                }
            }

            return result;

        }
    }
}
