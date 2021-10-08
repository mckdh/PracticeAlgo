using System;
using Moq;
using PracticeAlgo.LongestSubstringWithoutRepeating;
using Xunit;

namespace PracticeAlgo.Tests
{
    public class LongestSubstringTest
    {
        //=================== TestInitialize =====================
        private ILongestSubstring CreateMainClass()
        {
            return new LongestSubstringByMe();
        }

        //=================== Main =====================
        [Fact]
        public void Test_mock()
        {
            //Good mock example
            var lsMock = new Mock<ILongestSubstring>();
            lsMock.Setup(l => l.LengthOfLongestSubstring("abcabcbb")).Returns(3);
            ILongestSubstring mock = lsMock.Object;

            string s = "abcabcbb";
            int expectResult = 3;
            Assert.Equal(expectResult, mock.LengthOfLongestSubstring(s));
        }

        [Fact]
        public void Test_main()
        {
            //Given a string s, find the length of the longest substring without repeating characters.
            ILongestSubstring longSubstring = CreateMainClass();

            string s0 = "abcabcbb";
            int expectResult0 = 3;
            Assert.Equal(expectResult0, longSubstring.LengthOfLongestSubstring(s0));

            string s2 = "bbbbb";
            int expectResult2 = 1;
            Assert.Equal(expectResult2, longSubstring.LengthOfLongestSubstring(s2)); 

            string s3 = "pwwkew"; //wke
            int expectResult3 = 3;
            Assert.Equal(expectResult3, longSubstring.LengthOfLongestSubstring(s3));
        }
    }
}
