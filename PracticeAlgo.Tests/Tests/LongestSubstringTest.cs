using System;
using PracticeAlgo.LongestSubstringWithoutRepeating;
using Xunit;

namespace PracticeAlgo.Tests
{
    public class LongestSubstringTest
    {
        //=================== TestInitialize =====================
        private ILongestSubstring CreateMainClass()
        {
            //Possible Mock?
            return new LongestSubstringByMe();
        }

        //=================== Main =====================
        [Fact]
        public void Test_main()
        {
            ILongestSubstring longSubstring = CreateMainClass();

            string s = "abcabcbb";
            int expectResult = 3;
            Assert.Equal(expectResult, longSubstring.LengthOfLongestSubstring(s));

            string s2 = "bbbbb";
            int expectResult2 = 1;
            Assert.Equal(expectResult2, longSubstring.LengthOfLongestSubstring(s2));

            string s3 = "pwwkew";
            int expectResult3 = 3;
            Assert.Equal(expectResult3, longSubstring.LengthOfLongestSubstring(s3));
        }
    }
}
