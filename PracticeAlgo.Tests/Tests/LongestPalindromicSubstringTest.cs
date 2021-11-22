using System;
using Moq;
using PracticeAlgo.LongestPalindromicSubstring;
using Xunit;

namespace PracticeAlgo.Tests
{
    public class LongestPalindromicSubstringTest
    {
        //=================== TestInitialize =====================
        private ILongestPalindromicSubstring CreateMainClass()
        {
            return new LongestPalindromicSubstringMirror();
        }

        //=================== Main =====================
        [Fact]
        public void Test_mock()
        {
            //Good mock example
            var lsMock = new Mock<ILongestPalindromicSubstring>();
            lsMock.Setup(l => l.LongestPalindrome("babad")).Returns("bab");
            ILongestPalindromicSubstring mock = lsMock.Object;

            string expectResult = "bab";
            Assert.Equal(expectResult, mock.LongestPalindrome("babad"));
        }

        [Fact]
        public void Test_main()
        {
            //Given a string s, find the length of the longest substring without repeating characters.
            ILongestPalindromicSubstring longPalindromicString = CreateMainClass();

            string s0 = "babad";
            string expectOutput0 = "aba";
            Assert.Equal(expectOutput0, longPalindromicString.LongestPalindrome(s0));

            string s2 = "cbbd";
            string expectResult2 = "bb";
            Assert.Equal(expectResult2, longPalindromicString.LongestPalindrome(s2)); 

            string s3 = "a";
            string expectResult3 = "a";
            Assert.Equal(expectResult3, longPalindromicString.LongestPalindrome(s3));

            string s4 = "ac";
            string expectResult4 = "a";
            Assert.Equal(expectResult4, longPalindromicString.LongestPalindrome(s4));
        }
    }
}
