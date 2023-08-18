using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_75_Solutions
{
    public class MaxAreaSolution
    {
        public int MaxArea(int[] height)
        {
            int leftPtr = 0;   
            int rigthPtr = height.Length-1;
            int maxArea = 0; 
            
            while(leftPtr < rigthPtr)
            {
                int area = Math.Abs(leftPtr - rigthPtr) * Math.Min(height[leftPtr], height[rigthPtr]);
                if (area > maxArea)
                {
                    maxArea = area;
                }

                if (height[leftPtr] < height[rigthPtr])
                {
                    leftPtr++;
                }
                else
                {
                    rigthPtr--;
                }
            }
               
               
            return maxArea;
        }
    }
}
