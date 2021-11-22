using System;
using System.Collections.Generic;

namespace PracticeAlgo.LongestPalindromicSubstring
{
    public class LongestPalindromicSubstringMirror : ILongestPalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {
            //Get the middle word
            int stringLength = s.Length;
            int middlePoint = stringLength / 2;
            int middlePoint2 = 0;
            Boolean isEven = false;
            if(stringLength % 2 == 0) {
                isEven = true;
                middlePoint2 = middlePoint - 1;
            }

            //Expand
            string maxString = "";
            if(isEven) {
                for(int i = 0; i < middlePoint; i++) {
                    int startPoint = middlePoint - (i + 1);
                    int endPoint = middlePoint2 + (i + 1) + i;
                    string substring = s.Substring(startPoint, endPoint);
                    string reverseSub = ReverseString(substring);
                    if(substring.Equals(reverseSub) && substring.Length > maxString.Length) {
                        maxString = substring;
                    }
                }                
            } else {
                for(int i = 0; i < middlePoint; i++) {
                    int startPoint = middlePoint - i;
                    int endPoint = middlePoint + i + (i - 1);
                    string substring = s.Substring(startPoint, endPoint);
                    string reverseSub = ReverseString(substring);
                    if(substring.Equals(reverseSub) && substring.Length > maxString.Length) {
                        maxString = substring;
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