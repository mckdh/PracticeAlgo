using PracticeAlgo.AddTwoNumbers;
using Xunit;

namespace PracticeAlgo.Tests
{
    public class AddTwoNumbersTest
    {
        //=================== TestInitialize =====================
        private IAddTwoNumbers CreateTargetClass()
        {
            return new AddTwoNumbersByOfficial();
        }

        //=================== Main =====================
        [Fact]
        public void TwoSumTest_main()
        {
            /* 
            Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
            Explanation: 342 + 465 = 807.
            Output: 7 -> 0 -> 8

            Input: l1 = [0], l2 = [0]
            Output: [0]

            Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
            Output:     [8,9,9,9,0,0,0,1]

            Input
            [1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1]
            [5,6,4]
            Output
            [0,3,-5,21,1]
            Expected
            [6,6,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1]

            각 노드 하나씩만 더한다.
            올림이 발생하면 다음 자리로 옮긴다.

            1. 거꾸로 변환해서 더한다.
            2. 결과를 다시 거꾸로 바꾼다.
             */
            IAddTwoNumbers targetClass = CreateTargetClass();

            //Test Case #3
            ListNode l14_3 = new ListNode(1);
            ListNode l13_3 = new ListNode(0, l14_3);
            ListNode l12_3 = new ListNode(0, l13_3);
            ListNode l11_3 = new ListNode(0, l12_3);
            ListNode l10_3 = new ListNode(0, l11_3);
            ListNode l09_3 = new ListNode(1, l10_3);

            ListNode l21_3 = new ListNode(4);
            ListNode l21_2 = new ListNode(6, l21_3);
            ListNode l21_1 = new ListNode(5, l21_2);

            ListNode resultNode_3 = targetClass.AddTwoNumbers(l09_3, l21_1);

            //100466
            ListNode compare1 = new ListNode(1);
            ListNode compare2 = new ListNode(0, compare1);
            ListNode compare3 = new ListNode(0, compare2);
            ListNode compare4 = new ListNode(4, compare3);
            ListNode compare5 = new ListNode(6, compare4);
            ListNode compare6 = new ListNode(6, compare5);

            Assert.Equal(compare6.val, resultNode_3.val);

/*
            //Test Case #1
            ListNode l13 = new ListNode(3);
            ListNode l12 = new ListNode(4, l13);
            ListNode l11 = new ListNode(2, l12);

            ListNode l23 = new ListNode(4);
            ListNode l22 = new ListNode(6, l23);
            ListNode l21 = new ListNode(5, l22);

            ListNode resultNode = targetClass.AddTwoNumbers(l11, l21);

            ListNode result3 = new ListNode(8);
            ListNode result2 = new ListNode(0, result3);
            ListNode resultSample = new ListNode(7, result2);

            Assert.Equal(resultSample.next.next.val, resultNode.next.next.val);
            Assert.Equal(resultSample.next.val, resultNode.next.val);
            Assert.Equal(resultSample.val, resultNode.val);

            //Test Case #2
            ListNode l12_2 = new ListNode(8);
            ListNode l11_2 = new ListNode(1, l12_2);

            ListNode l21_2 = new ListNode(0);

            ListNode resultNode_2 = targetClass.AddTwoNumbers(l11_2, l21_2);

            ListNode result2_2 = new ListNode(8);
            ListNode resultSample_2 = new ListNode(1, result2_2);

            Assert.Equal(resultSample_2.next.val, resultNode_2.next.val);
            Assert.Equal(resultSample_2.val, resultNode_2.val);
            */

        }
    }
}
