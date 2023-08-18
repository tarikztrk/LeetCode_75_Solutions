using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_75_Solutions
{
    public class MaxOperationsSolution
    {
        public int MaxOperations(int[] nums, int k)
        {
            Array.Sort(nums);
            int left = 0;
            int right = nums.Length - 1;
            int count = 0;
            while (left < right)
            {
                if (nums[left] + nums[right] == k)
                {
                    count++;
                    left++;
                    right--;
                }
                else if (nums[left] + nums[right] < k)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return count;

        }
    }
}
