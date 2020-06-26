using System.Globalization;
using System;
using System.Collections;

namespace PracticeAlgo
{
    public class TwoSumByBruteForce: TwoSumInterface
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[] { 0, 0 };
            for (int i = 0; i < nums.Length; i++)
            {
                int iNumber = nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int jNumber = nums[j];
                    int sum = iNumber + jNumber;
                    if(sum == target) {
                        result[0] = i;
                        result[1] = j;
                        return result;
                    }
                }
            }
            return result;
        }
    }
}
