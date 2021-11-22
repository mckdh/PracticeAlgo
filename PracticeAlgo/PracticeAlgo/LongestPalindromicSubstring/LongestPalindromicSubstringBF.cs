using System;
using System.Collections.Generic;

namespace PracticeAlgo.LongestPalindromicSubstring
{
    public class LongestPalindromicSubstringBF : ILongestPalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {

            string maxString = "";
            int n = s.Length;
            for (int i = 0; i < n; i++)
            {
           
                for (int j = i + 1; j < n + 1; j++)
                {
                    int length = j - i;
                    string sub = s.Substring(i, length);
                    string reverseSub = ReverseString(sub);
                    if(sub.Equals(reverseSub) && sub.Length > maxString.Length) {
                        maxString = sub;
                    }
                }
            }

            return maxString;
        }

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }

}