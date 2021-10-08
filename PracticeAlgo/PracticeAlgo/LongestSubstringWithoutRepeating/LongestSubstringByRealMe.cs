using System;
using System.Collections.Generic;

namespace PracticeAlgo.LongestSubstringWithoutRepeating
{
    public class LongestSubstringByRealMe : ILongestSubstring
    {

        public int LengthOfLongestSubstring(string s)
        {
            int n = s.Length();
            int ans = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j <= n; j++)
                {
         
                }
            }
            return ans;
        }

        /*
        all string, i, j
        store val
        for i, j
            extract char 
            check val -> false
            add the store val
        */
    }
}