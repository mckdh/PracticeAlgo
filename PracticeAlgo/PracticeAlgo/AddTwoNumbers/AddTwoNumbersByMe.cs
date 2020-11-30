using System;
using System.Collections.Generic;
using PracticeAlgo.AddTwoNumbers;

namespace PracticeAlgo
{
    public class AddTwoNumbersByMe : AddTwoNumbersInterface
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            //Extract values
            List<int> listForll1, listForll2;
            NodeToList(l1, l2, out listForll1, out listForll2);

            //Sort Inverse
            listForll1.Reverse();
            listForll2.Reverse();

            //Change value
            string l1String, l2String;
            ToOneNumber(listForll1, listForll2, out l1String, out l2String);
            // Console.WriteLine("l1String [" + l1String + "]");
            // Console.WriteLine("l2String [" + l2String + "]");
            //here
            l1String = "1000000000000000000000000000001";

            //Add
            double resultInt = Double.Parse(l1String) + Double.Parse(l2String);
            String resultString = resultInt + "";
            // Console.WriteLine("resultString [" + resultString + "]");

            //Save node conversely.
            ListNode resultNode = GetResultNode(resultString);
            return resultNode;
        }

        private static ListNode GetResultNode(string resultString)
        {
            ListNode resultNode = new ListNode(0);
            ListNode beforeNode = new ListNode(0);
            for (int i = 0; i < resultString.Length; i++)
            {
                char c = resultString[i];
                int cInt = (int)(c - '0');
                if (i == 0)
                {
                    resultNode = new ListNode(cInt);
                }
                else
                {
                    resultNode = new ListNode(cInt, beforeNode);
                }
                // Console.WriteLine("resultNode [" + resultNode.val + "]");
                beforeNode = resultNode;
            }

            return resultNode;
        }

        private static void ToOneNumber(List<int> listForll1, List<int> listForll2, out string l1String, out string l2String)
        {
            l1String = "";
            for (int i = 0; i < listForll1.Count; i++)
            {
                l1String = l1String + "" + listForll1[i];
            }

            l2String = "";
            for (int i = 0; i < listForll2.Count; i++)
            {
                l2String = l2String + "" + listForll2[i];
            }
        }

        private static void NodeToList(ListNode l1, ListNode l2, out List<int> listForll1, out List<int> listForll2)
        {
            listForll1 = new List<int>();
            while (true)
            {
                //I'm here..
                listForll1.Add(l1.val);
                // Console.WriteLine("l1.val [" + l1.val + "]");
                // Console.WriteLine("l2.val [" + l2.val + "]");
                if (l1.next == null)
                {
                    break;
                }
                l1 = l1.next;
            } 

            listForll2 = new List<int>();
            while (true)
            {
                //I'm here..
                listForll2.Add(l2.val);
                // Console.WriteLine("l1.val [" + l1.val + "]");
                // Console.WriteLine("l2.val [" + l2.val + "]");
                if (l2.next == null)
                {
                    break;
                }
                l2 = l2.next;
            } 
        }
    }
}
