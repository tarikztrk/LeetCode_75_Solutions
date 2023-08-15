using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_75_Solutions
{
    public class MoveZeroesSolution
    {
        public void MoveZeroes(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int x = i;
                if (nums[i] == 0)
                {
                    for (int j = i; j < nums.Length-1; j++)
                    {
                        if (nums[j+1] != 0)
                        {
                            int temp = nums[j + 1];
                            nums[j+1] = nums[x];
                            nums[x] = temp;
                            x++;
                        }
                    }
                }
            }
        }
    }
}
