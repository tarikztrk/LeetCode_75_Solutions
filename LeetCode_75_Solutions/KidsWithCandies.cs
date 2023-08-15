using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_75_Solutions
{
    public class KidsWithCandiesSolution
    {
        //https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/
        //1431. Kids With the Greatest Number of Candies
        //Given the array candies and the integer extraCandies, where candies[i] represents the number of candies that the ith kid has.
        //For each kid check if there is a way to distribute extraCandies among the kids such that he or she can have the greatest number of candies among them.
        //Notice that multiple kids can have the greatest number of candies.
        //Example 1:
        //Input: candies = [2,3,5,1,3], extraCandies = 3
        //Output: [true,true,true,false,true]
        //Explanation:
        //Kid 1 has 2 candies and if he or she receives all extra candies (3) will have 5 candies --- the greatest number of candies among the kids.
        //Kid 2 has 3 candies and if he or she receives at least 2 extra candies will have the greatest number of candies among the kids.

        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            IList<bool> res = new List<bool>();
            int max = candies.Max();

            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] + extraCandies >= max)
                {
                    res.Add(true);
                }
                else
                {
                    res.Add(false);
                }
            }
            return res;
        }
    }
}
