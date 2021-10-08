using System;
using System.Collections.Generic;

namespace PracticeAlgo.LongestSubstringWithoutRepeating
{
    public class LongestSubstringByMe : ILongestSubstring
    {
        public int LengthOfLongestSubstring(string s)
        {

            int max = 0;
            int n = s.Length;
            for (int i = 0; i < n; i++)
            {
                var set = new HashSet<char>();
                for (int j = i + 1; j <= n; j++)
                {
                    char ch = s[j-1];
                    if (set.Contains(ch)) {
                        break;
                    } else {
                        set.Add(ch);
                        if(set.Count > max) {
                            max = set.Count;
                        }
                    }
                }
            }
            return max;
        }
    }
}