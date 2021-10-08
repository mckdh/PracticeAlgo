using System.Globalization;
using System;
using System.Linq;
using System.Collections.Generic;

namespace PracticeAlgo.MedianOfTwoSortedArrays
{
    public class MedianTwoSortedByMe : IMedianTwoSorted
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double returnValue = 0;

            int[] nums = nums1.Concat(nums2).ToArray();
            Array.Sort(nums);

            if(nums.Count() % 2 != 0) {
                // Odd
                int middleSize = (nums.Count() / 2);
                returnValue = nums[middleSize];
            } else {
                int middle1 = (nums.Count() / 2) - 1;
                int middle2 = middle1 + 1;
                double middleSum = nums[middle1] + nums[middle2];
                returnValue = (middleSum / 2);
            }

            return returnValue;
        }
    }
}