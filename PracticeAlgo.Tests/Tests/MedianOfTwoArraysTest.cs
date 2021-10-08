using System;
using Moq;
using PracticeAlgo.MedianOfTwoSortedArrays;
using Xunit;

namespace PracticeAlgo.Tests
{
    public class MedianOfTwoArraysTest
    {
        //=================== TestInitialize =====================
        private IMedianTwoSorted CreateMainClass()
        {
            return new MedianTwoSortedByMe();
        }

        //=================== Main =====================
        [Fact]
        public void Test_mock()
        {
            //Good mock example
            int[] example1_1 = new int[] { 1, 3 };
            int[] example1_2 = new int[] { 2 };
            double expectResult = 2.00000;

            var lsMock = new Mock<IMedianTwoSorted>();
            lsMock.Setup(l => l.FindMedianSortedArrays(example1_1, example1_2)).Returns(2.00000);
            IMedianTwoSorted mock = lsMock.Object;

            Assert.Equal(expectResult, mock.FindMedianSortedArrays(example1_1, example1_2));
        }

        [Fact]
        public void Test_main()
        {
            IMedianTwoSorted longSubstring = CreateMainClass();

            int[] example1_1 = new int[] { 1, 3 };
            int[] example1_2 = new int[] { 2 };
            double expectResult = 2.00000;
            Assert.Equal(expectResult, longSubstring.FindMedianSortedArrays(example1_1, example1_2));

            int[] example2_1 = new int[] { 1, 2 };
            int[] example2_2 = new int[] { 3, 4 };
            double expectResult2 = 2.50000;
            Assert.Equal(expectResult2, longSubstring.FindMedianSortedArrays(example2_1, example2_2));

            int[] example3_1 = new int[] {};
            int[] example3_2 = new int[] { 1 };
            double expectResult3 = 1.00000;
            Assert.Equal(expectResult3, longSubstring.FindMedianSortedArrays(example3_1, example3_2));

            int[] example4_1 = new int[] { 2 };
            int[] example4_2 = new int[] {};
            double expectResult4 = 2.00000;
            Assert.Equal(expectResult4, longSubstring.FindMedianSortedArrays(example4_1, example4_2));
        }
    }
}
