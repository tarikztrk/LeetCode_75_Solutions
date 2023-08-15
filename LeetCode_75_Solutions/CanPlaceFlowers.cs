using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_75_Solutions
{
    public class CanPlaceFlowersSolution
    {
        //https://leetcode.com/problems/can-place-flowers/
        //605. Can Place Flowers
        //Suppose you have a long flowerbed in which some of the plots are planted and some are not.
        //However, flowers cannot be planted in adjacent plots - they would compete for water and both would die.
        //Given a flowerbed (represented as an array containing 0 and 1, where 0 means empty and 1 means not empty),
        //and a number n, return if n new flowers can be planted in it without violating the no-adjacent-flowers rule.
        //Example 1:
        //Input: flowerbed = [1,0,0,0,1], n = 1
        //Output: True
        //Example 2:
        //Input: flowerbed = [1,0,0,0,1], n = 2
        //Output: False

        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int count = 0;
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 0)
                {
                    bool leftCheck = i==0 || flowerbed[i-1] == 0;
                    bool rightCheck = i==flowerbed.Length-1 || flowerbed[i+1] == 0;
                    if (leftCheck && rightCheck)
                    {
                        flowerbed[i] = 1;
                        count++;
                    }
                }
            }

            return count >= n;
        }
    }
}
