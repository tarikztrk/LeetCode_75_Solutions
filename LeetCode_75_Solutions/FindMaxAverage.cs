using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_75_Solutions
{
    public class FindMaxAverageSolution
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            
            double sum = nums.Take(k).Sum();
            double res = sum;
            for (int i = k; i < nums.Length; i++)
            {
                sum += nums[i] - nums[i-k];
                res = Math.Max(res, sum);
            }
            return res/k;
        }
    }

}
