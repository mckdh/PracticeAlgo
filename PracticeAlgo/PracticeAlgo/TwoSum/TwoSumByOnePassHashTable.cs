using System.Globalization;
using System;
using System.Collections;

namespace PracticeAlgo
{
    public class TwoSumByOnePassHashTable: ITwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Hashtable ht = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if(ht.ContainsKey(complement)) {
                    return new int[] { (int)ht[complement], i };
                }
                ht.Add(nums[i], i);
            }
            return new int[] {0, 0};
        }
    }
}
