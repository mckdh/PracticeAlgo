using System;
using Xunit;

namespace PracticeAlgo.Tests
{
    public class TwoSumTest
    {
        //=================== TestInitialize =====================
        private TwoSumInterface CreateTwoSumClass()
        {
            return new TwoSumByOnePassHashTable();
        }

        //=================== Main =====================
        [Fact]
        public void TwoSumTest_main()
        {
            TwoSumInterface twoSumClass = CreateTwoSumClass();

            int[] givenNumbs = new int[] { 2, 7, 11, 15 };
            int target = 9;
            int[] expectResult = new int[] { 0, 1 };
            Assert.Equal(expectResult, twoSumClass.TwoSum(givenNumbs, target));

            givenNumbs = new int[] { 2, 7, 11, 15 };
            target = 18;
            expectResult = new int[] { 1, 2 };
            Assert.Equal(expectResult, twoSumClass.TwoSum(givenNumbs, target));

            givenNumbs = new int[] { 3, 2, 4 };
            target = 6;
            expectResult = new int[] { 1, 2 };
            Assert.Equal(expectResult, twoSumClass.TwoSum(givenNumbs, target));
        }
    }
}
